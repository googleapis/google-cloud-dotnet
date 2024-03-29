// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/securitycenter/v2/security_posture.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.SecurityCenter.V2 {

  /// <summary>Holder for reflection information generated from google/cloud/securitycenter/v2/security_posture.proto</summary>
  public static partial class SecurityPostureReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/securitycenter/v2/security_posture.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SecurityPostureReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjVnb29nbGUvY2xvdWQvc2VjdXJpdHljZW50ZXIvdjIvc2VjdXJpdHlfcG9z",
            "dHVyZS5wcm90bxIeZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnYyIugC",
            "Cg9TZWN1cml0eVBvc3R1cmUSDAoEbmFtZRgBIAEoCRITCgtyZXZpc2lvbl9p",
            "ZBgCIAEoCRIjChtwb3N0dXJlX2RlcGxveW1lbnRfcmVzb3VyY2UYAyABKAkS",
            "GgoScG9zdHVyZV9kZXBsb3ltZW50GAQgASgJEhYKDmNoYW5nZWRfcG9saWN5",
            "GAUgASgJEhIKCnBvbGljeV9zZXQYBiABKAkSDgoGcG9saWN5GAcgASgJEmAK",
            "FHBvbGljeV9kcmlmdF9kZXRhaWxzGAggAygLMkIuZ29vZ2xlLmNsb3VkLnNl",
            "Y3VyaXR5Y2VudGVyLnYyLlNlY3VyaXR5UG9zdHVyZS5Qb2xpY3lEcmlmdERl",
            "dGFpbHMaUwoSUG9saWN5RHJpZnREZXRhaWxzEg0KBWZpZWxkGAEgASgJEhYK",
            "DmV4cGVjdGVkX3ZhbHVlGAIgASgJEhYKDmRldGVjdGVkX3ZhbHVlGAMgASgJ",
            "Qu4BCiJjb20uZ29vZ2xlLmNsb3VkLnNlY3VyaXR5Y2VudGVyLnYyQhRTZWN1",
            "cml0eVBvc3R1cmVQcm90b1ABWkpjbG91ZC5nb29nbGUuY29tL2dvL3NlY3Vy",
            "aXR5Y2VudGVyL2FwaXYyL3NlY3VyaXR5Y2VudGVycGI7c2VjdXJpdHljZW50",
            "ZXJwYqoCHkdvb2dsZS5DbG91ZC5TZWN1cml0eUNlbnRlci5WMsoCHkdvb2ds",
            "ZVxDbG91ZFxTZWN1cml0eUNlbnRlclxWMuoCIUdvb2dsZTo6Q2xvdWQ6OlNl",
            "Y3VyaXR5Q2VudGVyOjpWMmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V2.SecurityPosture), global::Google.Cloud.SecurityCenter.V2.SecurityPosture.Parser, new[]{ "Name", "RevisionId", "PostureDeploymentResource", "PostureDeployment", "ChangedPolicy", "PolicySet", "Policy", "PolicyDriftDetails" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.SecurityCenter.V2.SecurityPosture.Types.PolicyDriftDetails), global::Google.Cloud.SecurityCenter.V2.SecurityPosture.Types.PolicyDriftDetails.Parser, new[]{ "Field", "ExpectedValue", "DetectedValue" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents a posture that is deployed on Google Cloud by the
  /// Security Command Center Posture Management service.
  /// A posture contains one or more policy sets. A policy set is a
  /// group of policies that enforce a set of security rules on Google
  /// Cloud.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SecurityPosture : pb::IMessage<SecurityPosture>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SecurityPosture> _parser = new pb::MessageParser<SecurityPosture>(() => new SecurityPosture());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SecurityPosture> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.SecurityCenter.V2.SecurityPostureReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SecurityPosture() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SecurityPosture(SecurityPosture other) : this() {
      name_ = other.name_;
      revisionId_ = other.revisionId_;
      postureDeploymentResource_ = other.postureDeploymentResource_;
      postureDeployment_ = other.postureDeployment_;
      changedPolicy_ = other.changedPolicy_;
      policySet_ = other.policySet_;
      policy_ = other.policy_;
      policyDriftDetails_ = other.policyDriftDetails_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SecurityPosture Clone() {
      return new SecurityPosture(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Name of the posture, for example, `CIS-Posture`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "revision_id" field.</summary>
    public const int RevisionIdFieldNumber = 2;
    private string revisionId_ = "";
    /// <summary>
    /// The version of the posture, for example, `c7cfa2a8`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string RevisionId {
      get { return revisionId_; }
      set {
        revisionId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "posture_deployment_resource" field.</summary>
    public const int PostureDeploymentResourceFieldNumber = 3;
    private string postureDeploymentResource_ = "";
    /// <summary>
    /// The project, folder, or organization on which the posture is deployed,
    /// for example, `projects/{project_number}`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PostureDeploymentResource {
      get { return postureDeploymentResource_; }
      set {
        postureDeploymentResource_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "posture_deployment" field.</summary>
    public const int PostureDeploymentFieldNumber = 4;
    private string postureDeployment_ = "";
    /// <summary>
    /// The name of the posture deployment, for example,
    /// `organizations/{org_id}/posturedeployments/{posture_deployment_id}`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PostureDeployment {
      get { return postureDeployment_; }
      set {
        postureDeployment_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "changed_policy" field.</summary>
    public const int ChangedPolicyFieldNumber = 5;
    private string changedPolicy_ = "";
    /// <summary>
    /// The name of the updated policy, for example,
    /// `projects/{project_id}/policies/{constraint_name}`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string ChangedPolicy {
      get { return changedPolicy_; }
      set {
        changedPolicy_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "policy_set" field.</summary>
    public const int PolicySetFieldNumber = 6;
    private string policySet_ = "";
    /// <summary>
    /// The name of the updated policy set, for example, `cis-policyset`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PolicySet {
      get { return policySet_; }
      set {
        policySet_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "policy" field.</summary>
    public const int PolicyFieldNumber = 7;
    private string policy_ = "";
    /// <summary>
    /// The ID of the updated policy, for example, `compute-policy-1`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Policy {
      get { return policy_; }
      set {
        policy_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "policy_drift_details" field.</summary>
    public const int PolicyDriftDetailsFieldNumber = 8;
    private static readonly pb::FieldCodec<global::Google.Cloud.SecurityCenter.V2.SecurityPosture.Types.PolicyDriftDetails> _repeated_policyDriftDetails_codec
        = pb::FieldCodec.ForMessage(66, global::Google.Cloud.SecurityCenter.V2.SecurityPosture.Types.PolicyDriftDetails.Parser);
    private readonly pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V2.SecurityPosture.Types.PolicyDriftDetails> policyDriftDetails_ = new pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V2.SecurityPosture.Types.PolicyDriftDetails>();
    /// <summary>
    /// The details about a change in an updated policy that violates the deployed
    /// posture.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.SecurityCenter.V2.SecurityPosture.Types.PolicyDriftDetails> PolicyDriftDetails {
      get { return policyDriftDetails_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SecurityPosture);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SecurityPosture other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (RevisionId != other.RevisionId) return false;
      if (PostureDeploymentResource != other.PostureDeploymentResource) return false;
      if (PostureDeployment != other.PostureDeployment) return false;
      if (ChangedPolicy != other.ChangedPolicy) return false;
      if (PolicySet != other.PolicySet) return false;
      if (Policy != other.Policy) return false;
      if(!policyDriftDetails_.Equals(other.policyDriftDetails_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (RevisionId.Length != 0) hash ^= RevisionId.GetHashCode();
      if (PostureDeploymentResource.Length != 0) hash ^= PostureDeploymentResource.GetHashCode();
      if (PostureDeployment.Length != 0) hash ^= PostureDeployment.GetHashCode();
      if (ChangedPolicy.Length != 0) hash ^= ChangedPolicy.GetHashCode();
      if (PolicySet.Length != 0) hash ^= PolicySet.GetHashCode();
      if (Policy.Length != 0) hash ^= Policy.GetHashCode();
      hash ^= policyDriftDetails_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (RevisionId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RevisionId);
      }
      if (PostureDeploymentResource.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PostureDeploymentResource);
      }
      if (PostureDeployment.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(PostureDeployment);
      }
      if (ChangedPolicy.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ChangedPolicy);
      }
      if (PolicySet.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(PolicySet);
      }
      if (Policy.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Policy);
      }
      policyDriftDetails_.WriteTo(output, _repeated_policyDriftDetails_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (RevisionId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(RevisionId);
      }
      if (PostureDeploymentResource.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PostureDeploymentResource);
      }
      if (PostureDeployment.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(PostureDeployment);
      }
      if (ChangedPolicy.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(ChangedPolicy);
      }
      if (PolicySet.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(PolicySet);
      }
      if (Policy.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(Policy);
      }
      policyDriftDetails_.WriteTo(ref output, _repeated_policyDriftDetails_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (RevisionId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(RevisionId);
      }
      if (PostureDeploymentResource.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PostureDeploymentResource);
      }
      if (PostureDeployment.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PostureDeployment);
      }
      if (ChangedPolicy.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(ChangedPolicy);
      }
      if (PolicySet.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PolicySet);
      }
      if (Policy.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Policy);
      }
      size += policyDriftDetails_.CalculateSize(_repeated_policyDriftDetails_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SecurityPosture other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.RevisionId.Length != 0) {
        RevisionId = other.RevisionId;
      }
      if (other.PostureDeploymentResource.Length != 0) {
        PostureDeploymentResource = other.PostureDeploymentResource;
      }
      if (other.PostureDeployment.Length != 0) {
        PostureDeployment = other.PostureDeployment;
      }
      if (other.ChangedPolicy.Length != 0) {
        ChangedPolicy = other.ChangedPolicy;
      }
      if (other.PolicySet.Length != 0) {
        PolicySet = other.PolicySet;
      }
      if (other.Policy.Length != 0) {
        Policy = other.Policy;
      }
      policyDriftDetails_.Add(other.policyDriftDetails_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            RevisionId = input.ReadString();
            break;
          }
          case 26: {
            PostureDeploymentResource = input.ReadString();
            break;
          }
          case 34: {
            PostureDeployment = input.ReadString();
            break;
          }
          case 42: {
            ChangedPolicy = input.ReadString();
            break;
          }
          case 50: {
            PolicySet = input.ReadString();
            break;
          }
          case 58: {
            Policy = input.ReadString();
            break;
          }
          case 66: {
            policyDriftDetails_.AddEntriesFrom(input, _repeated_policyDriftDetails_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Name = input.ReadString();
            break;
          }
          case 18: {
            RevisionId = input.ReadString();
            break;
          }
          case 26: {
            PostureDeploymentResource = input.ReadString();
            break;
          }
          case 34: {
            PostureDeployment = input.ReadString();
            break;
          }
          case 42: {
            ChangedPolicy = input.ReadString();
            break;
          }
          case 50: {
            PolicySet = input.ReadString();
            break;
          }
          case 58: {
            Policy = input.ReadString();
            break;
          }
          case 66: {
            policyDriftDetails_.AddEntriesFrom(ref input, _repeated_policyDriftDetails_codec);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the SecurityPosture message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The policy field that violates the deployed posture and its expected and
      /// detected values.
      /// </summary>
      [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
      public sealed partial class PolicyDriftDetails : pb::IMessage<PolicyDriftDetails>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<PolicyDriftDetails> _parser = new pb::MessageParser<PolicyDriftDetails>(() => new PolicyDriftDetails());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<PolicyDriftDetails> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.SecurityCenter.V2.SecurityPosture.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PolicyDriftDetails() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PolicyDriftDetails(PolicyDriftDetails other) : this() {
          field_ = other.field_;
          expectedValue_ = other.expectedValue_;
          detectedValue_ = other.detectedValue_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public PolicyDriftDetails Clone() {
          return new PolicyDriftDetails(this);
        }

        /// <summary>Field number for the "field" field.</summary>
        public const int FieldFieldNumber = 1;
        private string field_ = "";
        /// <summary>
        /// The name of the updated field, for example
        /// constraint.implementation.policy_rules[0].enforce
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string Field {
          get { return field_; }
          set {
            field_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "expected_value" field.</summary>
        public const int ExpectedValueFieldNumber = 2;
        private string expectedValue_ = "";
        /// <summary>
        /// The value of this field that was configured in a posture, for example,
        /// `true` or `allowed_values={"projects/29831892"}`.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string ExpectedValue {
          get { return expectedValue_; }
          set {
            expectedValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        /// <summary>Field number for the "detected_value" field.</summary>
        public const int DetectedValueFieldNumber = 3;
        private string detectedValue_ = "";
        /// <summary>
        /// The detected value that violates the deployed posture, for example,
        /// `false` or `allowed_values={"projects/22831892"}`.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public string DetectedValue {
          get { return detectedValue_; }
          set {
            detectedValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as PolicyDriftDetails);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(PolicyDriftDetails other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (Field != other.Field) return false;
          if (ExpectedValue != other.ExpectedValue) return false;
          if (DetectedValue != other.DetectedValue) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (Field.Length != 0) hash ^= Field.GetHashCode();
          if (ExpectedValue.Length != 0) hash ^= ExpectedValue.GetHashCode();
          if (DetectedValue.Length != 0) hash ^= DetectedValue.GetHashCode();
          if (_unknownFields != null) {
            hash ^= _unknownFields.GetHashCode();
          }
          return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override string ToString() {
          return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void WriteTo(pb::CodedOutputStream output) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          output.WriteRawMessage(this);
        #else
          if (Field.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Field);
          }
          if (ExpectedValue.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(ExpectedValue);
          }
          if (DetectedValue.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(DetectedValue);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(output);
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
          if (Field.Length != 0) {
            output.WriteRawTag(10);
            output.WriteString(Field);
          }
          if (ExpectedValue.Length != 0) {
            output.WriteRawTag(18);
            output.WriteString(ExpectedValue);
          }
          if (DetectedValue.Length != 0) {
            output.WriteRawTag(26);
            output.WriteString(DetectedValue);
          }
          if (_unknownFields != null) {
            _unknownFields.WriteTo(ref output);
          }
        }
        #endif

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public int CalculateSize() {
          int size = 0;
          if (Field.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(Field);
          }
          if (ExpectedValue.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(ExpectedValue);
          }
          if (DetectedValue.Length != 0) {
            size += 1 + pb::CodedOutputStream.ComputeStringSize(DetectedValue);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(PolicyDriftDetails other) {
          if (other == null) {
            return;
          }
          if (other.Field.Length != 0) {
            Field = other.Field;
          }
          if (other.ExpectedValue.Length != 0) {
            ExpectedValue = other.ExpectedValue;
          }
          if (other.DetectedValue.Length != 0) {
            DetectedValue = other.DetectedValue;
          }
          _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(pb::CodedInputStream input) {
        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          input.ReadRawMessage(this);
        #else
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                break;
              case 10: {
                Field = input.ReadString();
                break;
              }
              case 18: {
                ExpectedValue = input.ReadString();
                break;
              }
              case 26: {
                DetectedValue = input.ReadString();
                break;
              }
            }
          }
        #endif
        }

        #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
          uint tag;
          while ((tag = input.ReadTag()) != 0) {
            switch(tag) {
              default:
                _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
                break;
              case 10: {
                Field = input.ReadString();
                break;
              }
              case 18: {
                ExpectedValue = input.ReadString();
                break;
              }
              case 26: {
                DetectedValue = input.ReadString();
                break;
              }
            }
          }
        }
        #endif

      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
