// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V0
{
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for ListUsingGET.
    /// </summary>
    public static partial class ListUsingGETExtensions
    {
            /// <summary>
            /// Gets all datasources
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='q'>
            /// q
            /// </param>
            /// <param name='s'>
            /// s
            /// </param>
            /// <param name='sharedWith'>
            /// sharedWith
            /// </param>
            public static IList<DataSourcesDTO> One(this IListUsingGET operations, string q = default(string), string s = default(string), string sharedWith = default(string))
            {
                return operations.OneAsync(q, s, sharedWith).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets all datasources
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='q'>
            /// q
            /// </param>
            /// <param name='s'>
            /// s
            /// </param>
            /// <param name='sharedWith'>
            /// sharedWith
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IList<DataSourcesDTO>> OneAsync(this IListUsingGET operations, string q = default(string), string s = default(string), string sharedWith = default(string), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.OneWithHttpMessagesAsync(q, s, sharedWith, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}