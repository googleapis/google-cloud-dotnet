// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/admanager/v1/role_messages.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.AdManager.V1 {

  /// <summary>Holder for reflection information generated from google/ads/admanager/v1/role_messages.proto</summary>
  public static partial class RoleMessagesReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/admanager/v1/role_messages.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static RoleMessagesReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Citnb29nbGUvYWRzL2FkbWFuYWdlci92MS9yb2xlX21lc3NhZ2VzLnByb3Rv",
            "Ehdnb29nbGUuYWRzLmFkbWFuYWdlci52MRooZ29vZ2xlL2Fkcy9hZG1hbmFn",
            "ZXIvdjEvcm9sZV9lbnVtcy5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhh",
            "dmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byL5AgoEUm9s",
            "ZRIRCgRuYW1lGAEgASgJQgPgQQgSGQoHcm9sZV9pZBgCIAEoA0ID4EEDSACI",
            "AQESHgoMZGlzcGxheV9uYW1lGAMgASgJQgPgQQJIAYgBARIdCgtkZXNjcmlw",
            "dGlvbhgEIAEoCUID4EEBSAKIAQESGgoIYnVpbHRfaW4YBSABKAhCA+BBA0gD",
            "iAEBEkwKBnN0YXR1cxgGIAEoDjIyLmdvb2dsZS5hZHMuYWRtYW5hZ2VyLnYx",
            "LlJvbGVTdGF0dXNFbnVtLlJvbGVTdGF0dXNCA+BBA0gEiAEBOlXqQVIKHWFk",
            "bWFuYWdlci5nb29nbGVhcGlzLmNvbS9Sb2xlEiRuZXR3b3Jrcy97bmV0d29y",
            "a19jb2RlfS9yb2xlcy97cm9sZX0qBXJvbGVzMgRyb2xlQgoKCF9yb2xlX2lk",
            "Qg8KDV9kaXNwbGF5X25hbWVCDgoMX2Rlc2NyaXB0aW9uQgsKCV9idWlsdF9p",
            "bkIJCgdfc3RhdHVzQsUBChtjb20uZ29vZ2xlLmFkcy5hZG1hbmFnZXIudjFC",
            "EVJvbGVNZXNzYWdlc1Byb3RvUAFaQGdvb2dsZS5nb2xhbmcub3JnL2dlbnBy",
            "b3RvL2dvb2dsZWFwaXMvYWRzL2FkbWFuYWdlci92MTthZG1hbmFnZXKqAhdH",
            "b29nbGUuQWRzLkFkTWFuYWdlci5WMcoCF0dvb2dsZVxBZHNcQWRNYW5hZ2Vy",
            "XFYx6gIaR29vZ2xlOjpBZHM6OkFkTWFuYWdlcjo6VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.AdManager.V1.RoleEnumsReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.AdManager.V1.Role), global::Google.Ads.AdManager.V1.Role.Parser, new[]{ "Name", "RoleId", "DisplayName", "Description", "BuiltIn", "Status" }, new[]{ "RoleId", "DisplayName", "Description", "BuiltIn", "Status" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The `Role` resource.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Role : pb::IMessage<Role>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Role> _parser = new pb::MessageParser<Role>(() => new Role());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Role> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.AdManager.V1.RoleMessagesReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Role() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Role(Role other) : this() {
      _hasBits0 = other._hasBits0;
      name_ = other.name_;
      roleId_ = other.roleId_;
      displayName_ = other.displayName_;
      description_ = other.description_;
      builtIn_ = other.builtIn_;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Role Clone() {
      return new Role(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Identifier. The resource name of the `Role`.
    /// Format: `networks/{network_code}/roles/{role_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "role_id" field.</summary>
    public const int RoleIdFieldNumber = 2;
    private readonly static long RoleIdDefaultValue = 0L;

    private long roleId_;
    /// <summary>
    /// Output only. `Role` ID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long RoleId {
      get { if ((_hasBits0 & 1) != 0) { return roleId_; } else { return RoleIdDefaultValue; } }
      set {
        _hasBits0 |= 1;
        roleId_ = value;
      }
    }
    /// <summary>Gets whether the "role_id" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasRoleId {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "role_id" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearRoleId() {
      _hasBits0 &= ~1;
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 3;
    private readonly static string DisplayNameDefaultValue = "";

    private string displayName_;
    /// <summary>
    /// Required. The display name of the `Role`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_ ?? DisplayNameDefaultValue; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "display_name" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasDisplayName {
      get { return displayName_ != null; }
    }
    /// <summary>Clears the value of the "display_name" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDisplayName() {
      displayName_ = null;
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 4;
    private readonly static string DescriptionDefaultValue = "";

    private string description_;
    /// <summary>
    /// Optional. The description of the `Role`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_ ?? DescriptionDefaultValue; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }
    /// <summary>Gets whether the "description" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasDescription {
      get { return description_ != null; }
    }
    /// <summary>Clears the value of the "description" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearDescription() {
      description_ = null;
    }

    /// <summary>Field number for the "built_in" field.</summary>
    public const int BuiltInFieldNumber = 5;
    private readonly static bool BuiltInDefaultValue = false;

    private bool builtIn_;
    /// <summary>
    /// Output only. Whether the `Role` is a built-in or custom user role.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool BuiltIn {
      get { if ((_hasBits0 & 2) != 0) { return builtIn_; } else { return BuiltInDefaultValue; } }
      set {
        _hasBits0 |= 2;
        builtIn_ = value;
      }
    }
    /// <summary>Gets whether the "built_in" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasBuiltIn {
      get { return (_hasBits0 & 2) != 0; }
    }
    /// <summary>Clears the value of the "built_in" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearBuiltIn() {
      _hasBits0 &= ~2;
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 6;
    private readonly static global::Google.Ads.AdManager.V1.RoleStatusEnum.Types.RoleStatus StatusDefaultValue = global::Google.Ads.AdManager.V1.RoleStatusEnum.Types.RoleStatus.Unspecified;

    private global::Google.Ads.AdManager.V1.RoleStatusEnum.Types.RoleStatus status_;
    /// <summary>
    /// Output only. The status of the `Role`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Ads.AdManager.V1.RoleStatusEnum.Types.RoleStatus Status {
      get { if ((_hasBits0 & 4) != 0) { return status_; } else { return StatusDefaultValue; } }
      set {
        _hasBits0 |= 4;
        status_ = value;
      }
    }
    /// <summary>Gets whether the "status" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasStatus {
      get { return (_hasBits0 & 4) != 0; }
    }
    /// <summary>Clears the value of the "status" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearStatus() {
      _hasBits0 &= ~4;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Role);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Role other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (RoleId != other.RoleId) return false;
      if (DisplayName != other.DisplayName) return false;
      if (Description != other.Description) return false;
      if (BuiltIn != other.BuiltIn) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (HasRoleId) hash ^= RoleId.GetHashCode();
      if (HasDisplayName) hash ^= DisplayName.GetHashCode();
      if (HasDescription) hash ^= Description.GetHashCode();
      if (HasBuiltIn) hash ^= BuiltIn.GetHashCode();
      if (HasStatus) hash ^= Status.GetHashCode();
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
      if (HasRoleId) {
        output.WriteRawTag(16);
        output.WriteInt64(RoleId);
      }
      if (HasDisplayName) {
        output.WriteRawTag(26);
        output.WriteString(DisplayName);
      }
      if (HasDescription) {
        output.WriteRawTag(34);
        output.WriteString(Description);
      }
      if (HasBuiltIn) {
        output.WriteRawTag(40);
        output.WriteBool(BuiltIn);
      }
      if (HasStatus) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
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
      if (Name.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Name);
      }
      if (HasRoleId) {
        output.WriteRawTag(16);
        output.WriteInt64(RoleId);
      }
      if (HasDisplayName) {
        output.WriteRawTag(26);
        output.WriteString(DisplayName);
      }
      if (HasDescription) {
        output.WriteRawTag(34);
        output.WriteString(Description);
      }
      if (HasBuiltIn) {
        output.WriteRawTag(40);
        output.WriteBool(BuiltIn);
      }
      if (HasStatus) {
        output.WriteRawTag(48);
        output.WriteEnum((int) Status);
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
      if (Name.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Name);
      }
      if (HasRoleId) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(RoleId);
      }
      if (HasDisplayName) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (HasDescription) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (HasBuiltIn) {
        size += 1 + 1;
      }
      if (HasStatus) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Role other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.HasRoleId) {
        RoleId = other.RoleId;
      }
      if (other.HasDisplayName) {
        DisplayName = other.DisplayName;
      }
      if (other.HasDescription) {
        Description = other.Description;
      }
      if (other.HasBuiltIn) {
        BuiltIn = other.BuiltIn;
      }
      if (other.HasStatus) {
        Status = other.Status;
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
            Name = input.ReadString();
            break;
          }
          case 16: {
            RoleId = input.ReadInt64();
            break;
          }
          case 26: {
            DisplayName = input.ReadString();
            break;
          }
          case 34: {
            Description = input.ReadString();
            break;
          }
          case 40: {
            BuiltIn = input.ReadBool();
            break;
          }
          case 48: {
            Status = (global::Google.Ads.AdManager.V1.RoleStatusEnum.Types.RoleStatus) input.ReadEnum();
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
          case 16: {
            RoleId = input.ReadInt64();
            break;
          }
          case 26: {
            DisplayName = input.ReadString();
            break;
          }
          case 34: {
            Description = input.ReadString();
            break;
          }
          case 40: {
            BuiltIn = input.ReadBool();
            break;
          }
          case 48: {
            Status = (global::Google.Ads.AdManager.V1.RoleStatusEnum.Types.RoleStatus) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
