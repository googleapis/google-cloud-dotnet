// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/enterpriseknowledgegraph/v1/job_state.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.EnterpriseKnowledgeGraph.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/enterpriseknowledgegraph/v1/job_state.proto</summary>
  public static partial class JobStateReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/enterpriseknowledgegraph/v1/job_state.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static JobStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjhnb29nbGUvY2xvdWQvZW50ZXJwcmlzZWtub3dsZWRnZWdyYXBoL3YxL2pv",
            "Yl9zdGF0ZS5wcm90bxIoZ29vZ2xlLmNsb3VkLmVudGVycHJpc2Vrbm93bGVk",
            "Z2VncmFwaC52MSqeAgoISm9iU3RhdGUSGQoVSk9CX1NUQVRFX1VOU1BFQ0lG",
            "SUVEEAASFQoRSk9CX1NUQVRFX1BFTkRJTkcQCRIVChFKT0JfU1RBVEVfUlVO",
            "TklORxABEhcKE0pPQl9TVEFURV9TVUNDRUVERUQQAhIUChBKT0JfU1RBVEVf",
            "RkFJTEVEEAMSFwoTSk9CX1NUQVRFX0NBTkNFTExFRBAEEiIKHkpPQl9TVEFU",
            "RV9LTk9XTEVER0VfRVhUUkFDVElPThAFEiEKHUpPQl9TVEFURV9SRUNPTl9Q",
            "UkVQUk9DRVNTSU5HEAYSGAoUSk9CX1NUQVRFX0NMVVNURVJJTkcQBxIgChxK",
            "T0JfU1RBVEVfRVhQT1JUSU5HX0NMVVNURVJTEAhCrQIKLGNvbS5nb29nbGUu",
            "Y2xvdWQuZW50ZXJwcmlzZWtub3dsZWRnZWdyYXBoLnYxQg1Kb2JTdGF0ZVBy",
            "b3RvUAFaaGNsb3VkLmdvb2dsZS5jb20vZ28vZW50ZXJwcmlzZWtub3dsZWRn",
            "ZWdyYXBoL2FwaXYxL2VudGVycHJpc2Vrbm93bGVkZ2VncmFwaHBiO2VudGVy",
            "cHJpc2Vrbm93bGVkZ2VncmFwaHBiqgIoR29vZ2xlLkNsb3VkLkVudGVycHJp",
            "c2VLbm93bGVkZ2VHcmFwaC5WMcoCKEdvb2dsZVxDbG91ZFxFbnRlcnByaXNl",
            "S25vd2xlZGdlR3JhcGhcVjHqAitHb29nbGU6OkNsb3VkOjpFbnRlcnByaXNl",
            "S25vd2xlZGdlR3JhcGg6OlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.EnterpriseKnowledgeGraph.V1.JobState), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Describes the state of a job.
  /// </summary>
  public enum JobState {
    /// <summary>
    /// The job state is unspecified.
    /// </summary>
    [pbr::OriginalName("JOB_STATE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// The service is preparing to run the job.
    /// </summary>
    [pbr::OriginalName("JOB_STATE_PENDING")] Pending = 9,
    /// <summary>
    /// The job is in progress.
    /// </summary>
    [pbr::OriginalName("JOB_STATE_RUNNING")] Running = 1,
    /// <summary>
    /// The job completed successfully.
    /// </summary>
    [pbr::OriginalName("JOB_STATE_SUCCEEDED")] Succeeded = 2,
    /// <summary>
    /// The job failed.
    /// </summary>
    [pbr::OriginalName("JOB_STATE_FAILED")] Failed = 3,
    /// <summary>
    /// The job has been cancelled.
    /// </summary>
    [pbr::OriginalName("JOB_STATE_CANCELLED")] Cancelled = 4,
    /// <summary>
    /// Entity Recon API: The knowledge extraction job is running.
    /// </summary>
    [pbr::OriginalName("JOB_STATE_KNOWLEDGE_EXTRACTION")] KnowledgeExtraction = 5,
    /// <summary>
    /// Entity Recon API: The preprocessing job is running.
    /// </summary>
    [pbr::OriginalName("JOB_STATE_RECON_PREPROCESSING")] ReconPreprocessing = 6,
    /// <summary>
    /// Entity Recon API: The clustering job is running.
    /// </summary>
    [pbr::OriginalName("JOB_STATE_CLUSTERING")] Clustering = 7,
    /// <summary>
    /// Entity Recon API: The exporting clusters job is running.
    /// </summary>
    [pbr::OriginalName("JOB_STATE_EXPORTING_CLUSTERS")] ExportingClusters = 8,
  }

  #endregion

}

#endregion Designer generated code
