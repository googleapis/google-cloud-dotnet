// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/cloudcontrolspartner/v1/completion_state.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.CloudControlsPartner.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/cloudcontrolspartner/v1/completion_state.proto</summary>
  public static partial class CompletionStateReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/cloudcontrolspartner/v1/completion_state.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompletionStateReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjtnb29nbGUvY2xvdWQvY2xvdWRjb250cm9sc3BhcnRuZXIvdjEvY29tcGxl",
            "dGlvbl9zdGF0ZS5wcm90bxIkZ29vZ2xlLmNsb3VkLmNsb3VkY29udHJvbHNw",
            "YXJ0bmVyLnYxKm8KD0NvbXBsZXRpb25TdGF0ZRIgChxDT01QTEVUSU9OX1NU",
            "QVRFX1VOU1BFQ0lGSUVEEAASCwoHUEVORElORxABEg0KCVNVQ0NFRURFRBAC",
            "EgoKBkZBSUxFRBADEhIKDk5PVF9BUFBMSUNBQkxFEARCmAIKKGNvbS5nb29n",
            "bGUuY2xvdWQuY2xvdWRjb250cm9sc3BhcnRuZXIudjFCFENvbXBsZXRpb25T",
            "dGF0ZVByb3RvUAFaXGNsb3VkLmdvb2dsZS5jb20vZ28vY2xvdWRjb250cm9s",
            "c3BhcnRuZXIvYXBpdjEvY2xvdWRjb250cm9sc3BhcnRuZXJwYjtjbG91ZGNv",
            "bnRyb2xzcGFydG5lcnBiqgIkR29vZ2xlLkNsb3VkLkNsb3VkQ29udHJvbHNQ",
            "YXJ0bmVyLlYxygIkR29vZ2xlXENsb3VkXENsb3VkQ29udHJvbHNQYXJ0bmVy",
            "XFYx6gInR29vZ2xlOjpDbG91ZDo6Q2xvdWRDb250cm9sc1BhcnRuZXI6OlYx",
            "YgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Google.Cloud.CloudControlsPartner.V1.CompletionState), }, null, null));
    }
    #endregion

  }
  #region Enums
  /// <summary>
  /// Enum for possible completion states.
  /// </summary>
  public enum CompletionState {
    /// <summary>
    /// Unspecified completion state.
    /// </summary>
    [pbr::OriginalName("COMPLETION_STATE_UNSPECIFIED")] Unspecified = 0,
    /// <summary>
    /// Task started (has start date) but not yet completed.
    /// </summary>
    [pbr::OriginalName("PENDING")] Pending = 1,
    /// <summary>
    /// Succeeded state.
    /// </summary>
    [pbr::OriginalName("SUCCEEDED")] Succeeded = 2,
    /// <summary>
    /// Failed state.
    /// </summary>
    [pbr::OriginalName("FAILED")] Failed = 3,
    /// <summary>
    /// Not applicable state.
    /// </summary>
    [pbr::OriginalName("NOT_APPLICABLE")] NotApplicable = 4,
  }

  #endregion

}

#endregion Designer generated code
