using Nuke.Common;
using Nuke.Common.CI;
using Nuke.Common.CI.AzurePipelines;
using Nuke.Common.CI.GitHubActions;
using Nuke.Common.CI.TeamCity;
using Nuke.Common.Execution;
using Nuke.Common.Git;
using Nuke.Common.IO;
using Nuke.Common.ProjectModel;
using Nuke.Common.Tooling;
using Nuke.Common.Tools.DotNet;
using Nuke.Common.Tools.GitVersion;
using Nuke.Common.Utilities;
using Nuke.Common.Utilities.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using static Nuke.Common.ChangeLog.ChangelogTasks;
using static Nuke.Common.ControlFlow;
using static Nuke.Common.IO.FileSystemTasks;
using static Nuke.Common.IO.PathConstruction;
using static Nuke.Common.Tools.DotNet.DotNetTasks;
using static Nuke.Common.Tools.Git.GitTasks;

[CheckBuildProjectConfigurations]
[ShutdownDotNetAfterServerBuild]
[GitHubActions(
    "dotnet-core",
    GitHubActionsImage.UbuntuLatest,
    OnPushBranches = new[] { MainBranch, ReleaseBranchPrefix + "/*" },
    InvokedTargets = new[] { nameof(Publish) },
    ImportGitHubTokenAs = nameof(GitHubToken),
    ImportSecrets =
        new[]
        {
            nameof(NuGetApiKey)
        })]
partial class Build : NukeBuild
{
    /// Support plugins are available for:
    ///   - JetBrains ReSharper        https://nuke.build/resharper
    ///   - JetBrains Rider            https://nuke.build/rider
    ///   - Microsoft VisualStudio     https://nuke.build/visualstudio
    ///   - Microsoft VSCode           https://nuke.build/vscode

    public static int Main() => Execute<Build>(x => x.Compile);

    [CI] private readonly TeamCity TeamCity;
    [CI] private readonly AzurePipelines AzurePipelines;
    [CI] private readonly GitHubActions GitHubActions;

    [Parameter("Configuration to build - Default is 'Debug' (local) or 'Release' (server)")]
    private readonly Configuration Configuration = IsLocalBuild ? Configuration.Debug : Configuration.Release;

    [Solution] private readonly Solution Solution;
    [GitRepository] private readonly GitRepository GitRepository;
    [GitVersion(Framework = "netcoreapp3.1")] private readonly GitVersion GitVersion;

    AbsolutePath SourceDirectory => RootDirectory / "src";
    AbsolutePath TestsDirectory => RootDirectory / "tests";
    AbsolutePath OutputDirectory => RootDirectory / "output";

    private const string MainBranch = "main";
    private const string DevelopBranch = "develop";
    private const string ReleaseBranchPrefix = "release";

    private bool IsOriginalRepository => GitRepository != null && GitRepository.Identifier == "MarkZither/UnOffSiSenseDotNet";

    private string NuGetPackageSource => "https://api.nuget.org/v3/index.json";
    private string GitHubPackageSource => $"https://nuget.pkg.github.com/{GitHubActions.GitHubRepositoryOwner}/index.json";
    string Source => IsOriginalRepository ? NuGetPackageSource : GitHubPackageSource;

    [Parameter] private readonly string NuGetApiKey;

    private Target Clean => _ => _
         .Before(Restore)
         .Executes(() =>
         {
             SourceDirectory.GlobDirectories("**/bin", "**/obj").ForEach(DeleteDirectory);
             TestsDirectory.GlobDirectories("**/bin", "**/obj").ForEach(DeleteDirectory);
             EnsureCleanDirectory(OutputDirectory);
         });

    private Target Restore => _ => _
         .Executes(() =>
         {
             DotNetRestore(s => s
                 .SetProjectFile(Solution));
         });

    private Target Compile => _ => _
         .DependsOn(Restore)
         .Executes(() =>
         {
             DotNetBuild(s => s
                 .SetProjectFile(Solution)
                 .SetConfiguration(Configuration)
                 .SetAssemblyVersion(GitVersion.AssemblySemVer)
                 .SetFileVersion(GitVersion.AssemblySemFileVer)
                 .SetInformationalVersion(GitVersion.InformationalVersion)
                 .EnableNoRestore());
         });

    private string ChangelogFile => RootDirectory / "CHANGELOG.md";
    private AbsolutePath PackageDirectory => OutputDirectory / "packages";
    private IReadOnlyCollection<AbsolutePath> PackageFiles => PackageDirectory.GlobFiles("*.nupkg");
    private IEnumerable<string> ChangelogSectionNotes => ExtractChangelogSectionNotes(ChangelogFile);

    private Target Pack => _ => _
         .DependsOn(Compile)
         .Produces(PackageDirectory / "*.nupkg")
         .Executes(() =>
         {
             DotNetPack(_ => _
                 .SetProject(Solution)
                 .SetNoBuild(InvokedTargets.Contains(Compile))
                 .SetConfiguration(Configuration)
                 .SetOutputDirectory(PackageDirectory)
                 .SetVersion(GitVersion.NuGetVersionV2)
                 .SetPackageReleaseNotes(GetNuGetReleaseNotes(ChangelogFile, GitRepository)));
         });

    private Target Publish => _ => _
     .ProceedAfterFailure()
     .DependsOn(Clean/*, Test*/, Pack)
     .Consumes(Pack)
     .Requires(() => !NuGetApiKey.IsNullOrEmpty() || !IsOriginalRepository)
     .Requires(() => GitHasCleanWorkingCopy())
     .Requires(() => Configuration.Equals(Configuration.Release))
     .Requires(() => IsOriginalRepository && GitRepository.IsOnMainBranch() ||
                     IsOriginalRepository && GitRepository.IsOnReleaseBranch() ||
                     !IsOriginalRepository && GitRepository.IsOnDevelopBranch())
     .Executes(() =>
     {
         if (!IsOriginalRepository)
         {
             DotNetNuGetAddSource(_ => _
                 .SetSource(GitHubPackageSource)
                 .SetUsername(GitHubActions.GitHubActor)
                 .SetPassword(GitHubToken));
         }

         Assert(PackageFiles.Count == 1, "packages.Count == 1");

         DotNetNuGetPush(_ => _
                 .SetSource(Source)
                 .SetApiKey(NuGetApiKey)
                 .CombineWith(PackageFiles, (_, v) => _
                     .SetTargetPath(v)),
             degreeOfParallelism: 5,
             completeOnFailure: true);
     });
}