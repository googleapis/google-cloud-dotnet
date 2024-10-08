// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/deploy/v1/log_enums.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Deploy.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/deploy/v1/log_enums.proto</summary>
  public static partial class LogEnumsReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/deploy/v1/log_enums.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static LogEnumsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZnb29nbGUvY2xvdWQvZGVwbG95L3YxL2xvZ19lbnVtcy5wcm90bxIWZ29v",
            "Z2xlLmNsb3VkLmRlcGxveS52MSqWAgoEVHlwZRIUChBUWVBFX1VOU1BFQ0lG",
            "SUVEEAASJAogVFlQRV9QVUJTVUJfTk9USUZJQ0FUSU9OX0ZBSUxVUkUQARIe",
            "ChpUWVBFX1JFU09VUkNFX1NUQVRFX0NIQU5HRRADEhgKFFRZUEVfUFJPQ0VT",
            "U19BQk9SVEVEEAQSHQoZVFlQRV9SRVNUUklDVElPTl9WSU9MQVRFRBAFEhkK",
            "FVRZUEVfUkVTT1VSQ0VfREVMRVRFRBAGEhcKE1RZUEVfUk9MTE9VVF9VUERB",
            "VEUQBxIhCh1UWVBFX0RFUExPWV9QT0xJQ1lfRVZBTFVBVElPThAIEiIKGlRZ",
            "UEVfUkVOREVSX1NUQVRVRVNfQ0hBTkdFEAIaAggBQmEKGmNvbS5nb29nbGUu",
            "Y2xvdWQuZGVwbG95LnYxQg1Mb2dFbnVtc1Byb3RvUAFaMmNsb3VkLmdvb2ds",
            "ZS5jb20vZ28vZGVwbG95L2FwaXYxL2RlcGxveXBiO2RlcGxveXBiYgZwcm90",
            "bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.Deploy.V1.Type), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Type indicates the type of the log entry and can be used as a filter.
  /// </summary>
  public enum Type {
    /// <summary>
    /// Type is unspecified.
    /// </summary>
    [pbr::OriginalName("TYPE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// A Pub/Sub notification failed to be sent.
    /// </summary>
    [pbr::OriginalName("TYPE_PUBSUB_NOTIFICATION_FAILURE")] PubsubNotificationFailure = 1,
    /// <summary>
    /// Resource state changed.
    /// </summary>
    [pbr::OriginalName("TYPE_RESOURCE_STATE_CHANGE")] ResourceStateChange = 3,
    /// <summary>
    /// A process aborted.
    /// </summary>
    [pbr::OriginalName("TYPE_PROCESS_ABORTED")] ProcessAborted = 4,
    /// <summary>
    /// Restriction check failed.
    /// </summary>
    [pbr::OriginalName("TYPE_RESTRICTION_VIOLATED")] RestrictionViolated = 5,
    /// <summary>
    /// Resource deleted.
    /// </summary>
    [pbr::OriginalName("TYPE_RESOURCE_DELETED")] ResourceDeleted = 6,
    /// <summary>
    /// Rollout updated.
    /// </summary>
    [pbr::OriginalName("TYPE_ROLLOUT_UPDATE")] RolloutUpdate = 7,
    /// <summary>
    /// Deploy Policy evaluation.
    /// </summary>
    [pbr::OriginalName("TYPE_DEPLOY_POLICY_EVALUATION")] DeployPolicyEvaluation = 8,
    /// <summary>
    /// Deprecated: This field is never used. Use release_render log type instead.
    /// </summary>
    [global::System.ObsoleteAttribute]
    [pbr::OriginalName("TYPE_RENDER_STATUES_CHANGE")] RenderStatuesChange = 2,
  }

  #endregion

}

#endregion Designer generated code
