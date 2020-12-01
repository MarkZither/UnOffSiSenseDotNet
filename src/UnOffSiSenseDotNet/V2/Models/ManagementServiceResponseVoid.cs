// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace UnOffSiSenseDotNet.V2_0.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// ManagementServiceResponseVoid
    /// </summary>
    public partial class ManagementServiceResponseVoid
    {
        /// <summary>
        /// Initializes a new instance of the ManagementServiceResponseVoid
        /// class.
        /// </summary>
        public ManagementServiceResponseVoid()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ManagementServiceResponseVoid
        /// class.
        /// </summary>
        /// <param name="status">Possible values include: 'OK',
        /// 'CUBE_NOT_FOUND', 'PATH_DOES_NOT_EXIST', 'ALREADY_ATTACHED',
        /// 'FAILED_TO_START_CUBE', 'MISSING_DATA_GROUP', 'MISSING_MODEL',
        /// 'NOT_VALID', 'NOT_FOUND', 'FAILED_TO_DETACH', 'FAILED_TO_STOP',
        /// 'CUBE_STATUS_ERROR', 'CUBE_ALREADY_STOPPED', 'STOP_CUBE_ERROR',
        /// 'NO_SUCH_CUBE', 'CUBE_ALREADY_RUNNING',
        /// 'TOO_MANY_CUBES_ALREADY_RUNNING', 'CUBE_ALREADY_STARTING',
        /// 'START_CUBE_ERROR', 'CUBE_NOT_REGISTERED',
        /// 'START_CUBE_INTERRUPTED', 'PROVIDER_ERROR', 'FAILED_TO_MAKE_DIR',
        /// 'FAILED_TO_WRITE_FILE', 'FAILED_TO_ATTACH', 'BAD_CUBE_NAME',
        /// 'CUBE_IS_BUSY', 'FAILED_TO_MIGRATE', 'FILE_MISSING',
        /// 'FILE_TOO_BIG', 'CUBE_ALREADY_EXISTS', 'FAILED_TO_SAVE_DATASOURCE',
        /// 'FAILED_TO_RESET_STORAGE', 'FAILED_TO_RESET_BUILD_STORAGE',
        /// 'FAILED_TO_RESET_FARM', 'FAILED_TO_RESET_K8S',
        /// 'FAILED_LOADING_CUBE', 'INTERNAL_ERROR', 'UNAUTHORIZED',
        /// 'UNKNOWN_SERVICE', 'INSUFFICIENT_DISK_RESOURCES', 'TASK_NOT_FOUND',
        /// 'TASK_NOT_RUNNING', 'BAD_REQUEST', 'UNSUPPORTED_DATA_SOURCE_TYPE',
        /// 'AWS_ERROR', 'SYSTEM_IN_RESTORE', 'SYSTEM_IN_BACKUP',
        /// 'SYSTEM_ADD_EC_ACTIVITY_HALTED'</param>
        public ManagementServiceResponseVoid(string error = default(string), string status = default(string), int? statusCode = default(int?))
        {
            Error = error;
            Status = status;
            StatusCode = statusCode;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public string Error { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'OK', 'CUBE_NOT_FOUND',
        /// 'PATH_DOES_NOT_EXIST', 'ALREADY_ATTACHED', 'FAILED_TO_START_CUBE',
        /// 'MISSING_DATA_GROUP', 'MISSING_MODEL', 'NOT_VALID', 'NOT_FOUND',
        /// 'FAILED_TO_DETACH', 'FAILED_TO_STOP', 'CUBE_STATUS_ERROR',
        /// 'CUBE_ALREADY_STOPPED', 'STOP_CUBE_ERROR', 'NO_SUCH_CUBE',
        /// 'CUBE_ALREADY_RUNNING', 'TOO_MANY_CUBES_ALREADY_RUNNING',
        /// 'CUBE_ALREADY_STARTING', 'START_CUBE_ERROR', 'CUBE_NOT_REGISTERED',
        /// 'START_CUBE_INTERRUPTED', 'PROVIDER_ERROR', 'FAILED_TO_MAKE_DIR',
        /// 'FAILED_TO_WRITE_FILE', 'FAILED_TO_ATTACH', 'BAD_CUBE_NAME',
        /// 'CUBE_IS_BUSY', 'FAILED_TO_MIGRATE', 'FILE_MISSING',
        /// 'FILE_TOO_BIG', 'CUBE_ALREADY_EXISTS', 'FAILED_TO_SAVE_DATASOURCE',
        /// 'FAILED_TO_RESET_STORAGE', 'FAILED_TO_RESET_BUILD_STORAGE',
        /// 'FAILED_TO_RESET_FARM', 'FAILED_TO_RESET_K8S',
        /// 'FAILED_LOADING_CUBE', 'INTERNAL_ERROR', 'UNAUTHORIZED',
        /// 'UNKNOWN_SERVICE', 'INSUFFICIENT_DISK_RESOURCES', 'TASK_NOT_FOUND',
        /// 'TASK_NOT_RUNNING', 'BAD_REQUEST', 'UNSUPPORTED_DATA_SOURCE_TYPE',
        /// 'AWS_ERROR', 'SYSTEM_IN_RESTORE', 'SYSTEM_IN_BACKUP',
        /// 'SYSTEM_ADD_EC_ACTIVITY_HALTED'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statusCode")]
        public int? StatusCode { get; set; }

    }
}
