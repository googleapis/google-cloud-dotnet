// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/cloud/discoveryengine/v1/data_store.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.DiscoveryEngine.V1 {

  /// <summary>Holder for reflection information generated from google/cloud/discoveryengine/v1/data_store.proto</summary>
  public static partial class DataStoreReflection {

    #region Descriptor
    /// <summary>File descriptor for google/cloud/discoveryengine/v1/data_store.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static DataStoreReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjBnb29nbGUvY2xvdWQvZGlzY292ZXJ5ZW5naW5lL3YxL2RhdGFfc3RvcmUu",
            "cHJvdG8SH2dvb2dsZS5jbG91ZC5kaXNjb3ZlcnllbmdpbmUudjEaH2dvb2ds",
            "ZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9hcGkvcmVzb3Vy",
            "Y2UucHJvdG8aLGdvb2dsZS9jbG91ZC9kaXNjb3ZlcnllbmdpbmUvdjEvY29t",
            "bW9uLnByb3RvGkBnb29nbGUvY2xvdWQvZGlzY292ZXJ5ZW5naW5lL3YxL2Rv",
            "Y3VtZW50X3Byb2Nlc3NpbmdfY29uZmlnLnByb3RvGixnb29nbGUvY2xvdWQv",
            "ZGlzY292ZXJ5ZW5naW5lL3YxL3NjaGVtYS5wcm90bxofZ29vZ2xlL3Byb3Rv",
            "YnVmL3RpbWVzdGFtcC5wcm90byLYBgoJRGF0YVN0b3JlEhEKBG5hbWUYASAB",
            "KAlCA+BBBRIZCgxkaXNwbGF5X25hbWUYAiABKAlCA+BBAhJRChFpbmR1c3Ry",
            "eV92ZXJ0aWNhbBgDIAEoDjIxLmdvb2dsZS5jbG91ZC5kaXNjb3Zlcnllbmdp",
            "bmUudjEuSW5kdXN0cnlWZXJ0aWNhbEID4EEFEkUKDnNvbHV0aW9uX3R5cGVz",
            "GAUgAygOMi0uZ29vZ2xlLmNsb3VkLmRpc2NvdmVyeWVuZ2luZS52MS5Tb2x1",
            "dGlvblR5cGUSHgoRZGVmYXVsdF9zY2hlbWFfaWQYByABKAlCA+BBAxJVCg5j",
            "b250ZW50X2NvbmZpZxgGIAEoDjI4Lmdvb2dsZS5jbG91ZC5kaXNjb3Zlcnll",
            "bmdpbmUudjEuRGF0YVN0b3JlLkNvbnRlbnRDb25maWdCA+BBBRI0CgtjcmVh",
            "dGVfdGltZRgEIAEoCzIaLmdvb2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCA+BB",
            "AxJdChpkb2N1bWVudF9wcm9jZXNzaW5nX2NvbmZpZxgbIAEoCzI5Lmdvb2ds",
            "ZS5jbG91ZC5kaXNjb3ZlcnllbmdpbmUudjEuRG9jdW1lbnRQcm9jZXNzaW5n",
            "Q29uZmlnEkAKD3N0YXJ0aW5nX3NjaGVtYRgcIAEoCzInLmdvb2dsZS5jbG91",
            "ZC5kaXNjb3ZlcnllbmdpbmUudjEuU2NoZW1hImkKDUNvbnRlbnRDb25maWcS",
            "HgoaQ09OVEVOVF9DT05GSUdfVU5TUEVDSUZJRUQQABIOCgpOT19DT05URU5U",
            "EAESFAoQQ09OVEVOVF9SRVFVSVJFRBACEhIKDlBVQkxJQ19XRUJTSVRFEAM6",
            "yQHqQcUBCihkaXNjb3ZlcnllbmdpbmUuZ29vZ2xlYXBpcy5jb20vRGF0YVN0",
            "b3JlEj9wcm9qZWN0cy97cHJvamVjdH0vbG9jYXRpb25zL3tsb2NhdGlvbn0v",
            "ZGF0YVN0b3Jlcy97ZGF0YV9zdG9yZX0SWHByb2plY3RzL3twcm9qZWN0fS9s",
            "b2NhdGlvbnMve2xvY2F0aW9ufS9jb2xsZWN0aW9ucy97Y29sbGVjdGlvbn0v",
            "ZGF0YVN0b3Jlcy97ZGF0YV9zdG9yZX1CgQIKI2NvbS5nb29nbGUuY2xvdWQu",
            "ZGlzY292ZXJ5ZW5naW5lLnYxQg5EYXRhU3RvcmVQcm90b1ABWk1jbG91ZC5n",
            "b29nbGUuY29tL2dvL2Rpc2NvdmVyeWVuZ2luZS9hcGl2MS9kaXNjb3Zlcnll",
            "bmdpbmVwYjtkaXNjb3ZlcnllbmdpbmVwYqICD0RJU0NPVkVSWUVOR0lORaoC",
            "H0dvb2dsZS5DbG91ZC5EaXNjb3ZlcnlFbmdpbmUuVjHKAh9Hb29nbGVcQ2xv",
            "dWRcRGlzY292ZXJ5RW5naW5lXFYx6gIiR29vZ2xlOjpDbG91ZDo6RGlzY292",
            "ZXJ5RW5naW5lOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Cloud.DiscoveryEngine.V1.CommonReflection.Descriptor, global::Google.Cloud.DiscoveryEngine.V1.DocumentProcessingConfigReflection.Descriptor, global::Google.Cloud.DiscoveryEngine.V1.SchemaReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.DiscoveryEngine.V1.DataStore), global::Google.Cloud.DiscoveryEngine.V1.DataStore.Parser, new[]{ "Name", "DisplayName", "IndustryVertical", "SolutionTypes", "DefaultSchemaId", "ContentConfig", "CreateTime", "DocumentProcessingConfig", "StartingSchema" }, null, new[]{ typeof(global::Google.Cloud.DiscoveryEngine.V1.DataStore.Types.ContentConfig) }, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// DataStore captures global settings and configs at the DataStore level.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class DataStore : pb::IMessage<DataStore>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<DataStore> _parser = new pb::MessageParser<DataStore>(() => new DataStore());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<DataStore> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.DiscoveryEngine.V1.DataStoreReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataStore() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataStore(DataStore other) : this() {
      name_ = other.name_;
      displayName_ = other.displayName_;
      industryVertical_ = other.industryVertical_;
      solutionTypes_ = other.solutionTypes_.Clone();
      defaultSchemaId_ = other.defaultSchemaId_;
      contentConfig_ = other.contentConfig_;
      createTime_ = other.createTime_ != null ? other.createTime_.Clone() : null;
      documentProcessingConfig_ = other.documentProcessingConfig_ != null ? other.documentProcessingConfig_.Clone() : null;
      startingSchema_ = other.startingSchema_ != null ? other.startingSchema_.Clone() : null;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public DataStore Clone() {
      return new DataStore(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Immutable. The full resource name of the data store.
    /// Format:
    /// `projects/{project}/locations/{location}/collections/{collection_id}/dataStores/{data_store_id}`.
    ///
    /// This field must be a UTF-8 encoded string with a length limit of 1024
    /// characters.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "display_name" field.</summary>
    public const int DisplayNameFieldNumber = 2;
    private string displayName_ = "";
    /// <summary>
    /// Required. The data store display name.
    ///
    /// This field must be a UTF-8 encoded string with a length limit of 128
    /// characters. Otherwise, an INVALID_ARGUMENT error is returned.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DisplayName {
      get { return displayName_; }
      set {
        displayName_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "industry_vertical" field.</summary>
    public const int IndustryVerticalFieldNumber = 3;
    private global::Google.Cloud.DiscoveryEngine.V1.IndustryVertical industryVertical_ = global::Google.Cloud.DiscoveryEngine.V1.IndustryVertical.Unspecified;
    /// <summary>
    /// Immutable. The industry vertical that the data store registers.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.DiscoveryEngine.V1.IndustryVertical IndustryVertical {
      get { return industryVertical_; }
      set {
        industryVertical_ = value;
      }
    }

    /// <summary>Field number for the "solution_types" field.</summary>
    public const int SolutionTypesFieldNumber = 5;
    private static readonly pb::FieldCodec<global::Google.Cloud.DiscoveryEngine.V1.SolutionType> _repeated_solutionTypes_codec
        = pb::FieldCodec.ForEnum(42, x => (int) x, x => (global::Google.Cloud.DiscoveryEngine.V1.SolutionType) x);
    private readonly pbc::RepeatedField<global::Google.Cloud.DiscoveryEngine.V1.SolutionType> solutionTypes_ = new pbc::RepeatedField<global::Google.Cloud.DiscoveryEngine.V1.SolutionType>();
    /// <summary>
    /// The solutions that the data store enrolls. Available solutions for each
    /// [industry_vertical][google.cloud.discoveryengine.v1.DataStore.industry_vertical]:
    ///
    /// * `MEDIA`: `SOLUTION_TYPE_RECOMMENDATION` and `SOLUTION_TYPE_SEARCH`.
    /// * `SITE_SEARCH`: `SOLUTION_TYPE_SEARCH` is automatically enrolled. Other
    ///   solutions cannot be enrolled.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Cloud.DiscoveryEngine.V1.SolutionType> SolutionTypes {
      get { return solutionTypes_; }
    }

    /// <summary>Field number for the "default_schema_id" field.</summary>
    public const int DefaultSchemaIdFieldNumber = 7;
    private string defaultSchemaId_ = "";
    /// <summary>
    /// Output only. The id of the default
    /// [Schema][google.cloud.discoveryengine.v1.Schema] asscociated to this data
    /// store.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DefaultSchemaId {
      get { return defaultSchemaId_; }
      set {
        defaultSchemaId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "content_config" field.</summary>
    public const int ContentConfigFieldNumber = 6;
    private global::Google.Cloud.DiscoveryEngine.V1.DataStore.Types.ContentConfig contentConfig_ = global::Google.Cloud.DiscoveryEngine.V1.DataStore.Types.ContentConfig.Unspecified;
    /// <summary>
    /// Immutable. The content config of the data store. If this field is unset,
    /// the server behavior defaults to
    /// [ContentConfig.NO_CONTENT][google.cloud.discoveryengine.v1.DataStore.ContentConfig.NO_CONTENT].
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.DiscoveryEngine.V1.DataStore.Types.ContentConfig ContentConfig {
      get { return contentConfig_; }
      set {
        contentConfig_ = value;
      }
    }

    /// <summary>Field number for the "create_time" field.</summary>
    public const int CreateTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp createTime_;
    /// <summary>
    /// Output only. Timestamp the
    /// [DataStore][google.cloud.discoveryengine.v1.DataStore] was created at.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp CreateTime {
      get { return createTime_; }
      set {
        createTime_ = value;
      }
    }

    /// <summary>Field number for the "document_processing_config" field.</summary>
    public const int DocumentProcessingConfigFieldNumber = 27;
    private global::Google.Cloud.DiscoveryEngine.V1.DocumentProcessingConfig documentProcessingConfig_;
    /// <summary>
    /// Configuration for Document understanding and enrichment.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.DiscoveryEngine.V1.DocumentProcessingConfig DocumentProcessingConfig {
      get { return documentProcessingConfig_; }
      set {
        documentProcessingConfig_ = value;
      }
    }

    /// <summary>Field number for the "starting_schema" field.</summary>
    public const int StartingSchemaFieldNumber = 28;
    private global::Google.Cloud.DiscoveryEngine.V1.Schema startingSchema_;
    /// <summary>
    /// The start schema to use for this
    /// [DataStore][google.cloud.discoveryengine.v1.DataStore] when provisioning
    /// it. If unset, a default vertical specialized schema will be used.
    ///
    /// This field is only used by [CreateDataStore][] API, and will be ignored if
    /// used in other APIs. This field will be omitted from all API responses
    /// including [CreateDataStore][] API. To retrieve a schema of a
    /// [DataStore][google.cloud.discoveryengine.v1.DataStore], use
    /// [SchemaService.GetSchema][google.cloud.discoveryengine.v1.SchemaService.GetSchema]
    /// API instead.
    ///
    /// The provided schema will be validated against certain rules on schema.
    /// Learn more from [this
    /// doc](https://cloud.google.com/generative-ai-app-builder/docs/provide-schema).
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.DiscoveryEngine.V1.Schema StartingSchema {
      get { return startingSchema_; }
      set {
        startingSchema_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as DataStore);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(DataStore other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (DisplayName != other.DisplayName) return false;
      if (IndustryVertical != other.IndustryVertical) return false;
      if(!solutionTypes_.Equals(other.solutionTypes_)) return false;
      if (DefaultSchemaId != other.DefaultSchemaId) return false;
      if (ContentConfig != other.ContentConfig) return false;
      if (!object.Equals(CreateTime, other.CreateTime)) return false;
      if (!object.Equals(DocumentProcessingConfig, other.DocumentProcessingConfig)) return false;
      if (!object.Equals(StartingSchema, other.StartingSchema)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (DisplayName.Length != 0) hash ^= DisplayName.GetHashCode();
      if (IndustryVertical != global::Google.Cloud.DiscoveryEngine.V1.IndustryVertical.Unspecified) hash ^= IndustryVertical.GetHashCode();
      hash ^= solutionTypes_.GetHashCode();
      if (DefaultSchemaId.Length != 0) hash ^= DefaultSchemaId.GetHashCode();
      if (ContentConfig != global::Google.Cloud.DiscoveryEngine.V1.DataStore.Types.ContentConfig.Unspecified) hash ^= ContentConfig.GetHashCode();
      if (createTime_ != null) hash ^= CreateTime.GetHashCode();
      if (documentProcessingConfig_ != null) hash ^= DocumentProcessingConfig.GetHashCode();
      if (startingSchema_ != null) hash ^= StartingSchema.GetHashCode();
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
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (IndustryVertical != global::Google.Cloud.DiscoveryEngine.V1.IndustryVertical.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) IndustryVertical);
      }
      if (createTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreateTime);
      }
      solutionTypes_.WriteTo(output, _repeated_solutionTypes_codec);
      if (ContentConfig != global::Google.Cloud.DiscoveryEngine.V1.DataStore.Types.ContentConfig.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) ContentConfig);
      }
      if (DefaultSchemaId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(DefaultSchemaId);
      }
      if (documentProcessingConfig_ != null) {
        output.WriteRawTag(218, 1);
        output.WriteMessage(DocumentProcessingConfig);
      }
      if (startingSchema_ != null) {
        output.WriteRawTag(226, 1);
        output.WriteMessage(StartingSchema);
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
      if (DisplayName.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(DisplayName);
      }
      if (IndustryVertical != global::Google.Cloud.DiscoveryEngine.V1.IndustryVertical.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) IndustryVertical);
      }
      if (createTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(CreateTime);
      }
      solutionTypes_.WriteTo(ref output, _repeated_solutionTypes_codec);
      if (ContentConfig != global::Google.Cloud.DiscoveryEngine.V1.DataStore.Types.ContentConfig.Unspecified) {
        output.WriteRawTag(48);
        output.WriteEnum((int) ContentConfig);
      }
      if (DefaultSchemaId.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(DefaultSchemaId);
      }
      if (documentProcessingConfig_ != null) {
        output.WriteRawTag(218, 1);
        output.WriteMessage(DocumentProcessingConfig);
      }
      if (startingSchema_ != null) {
        output.WriteRawTag(226, 1);
        output.WriteMessage(StartingSchema);
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
      if (DisplayName.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DisplayName);
      }
      if (IndustryVertical != global::Google.Cloud.DiscoveryEngine.V1.IndustryVertical.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) IndustryVertical);
      }
      size += solutionTypes_.CalculateSize(_repeated_solutionTypes_codec);
      if (DefaultSchemaId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DefaultSchemaId);
      }
      if (ContentConfig != global::Google.Cloud.DiscoveryEngine.V1.DataStore.Types.ContentConfig.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) ContentConfig);
      }
      if (createTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(CreateTime);
      }
      if (documentProcessingConfig_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(DocumentProcessingConfig);
      }
      if (startingSchema_ != null) {
        size += 2 + pb::CodedOutputStream.ComputeMessageSize(StartingSchema);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(DataStore other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.DisplayName.Length != 0) {
        DisplayName = other.DisplayName;
      }
      if (other.IndustryVertical != global::Google.Cloud.DiscoveryEngine.V1.IndustryVertical.Unspecified) {
        IndustryVertical = other.IndustryVertical;
      }
      solutionTypes_.Add(other.solutionTypes_);
      if (other.DefaultSchemaId.Length != 0) {
        DefaultSchemaId = other.DefaultSchemaId;
      }
      if (other.ContentConfig != global::Google.Cloud.DiscoveryEngine.V1.DataStore.Types.ContentConfig.Unspecified) {
        ContentConfig = other.ContentConfig;
      }
      if (other.createTime_ != null) {
        if (createTime_ == null) {
          CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        CreateTime.MergeFrom(other.CreateTime);
      }
      if (other.documentProcessingConfig_ != null) {
        if (documentProcessingConfig_ == null) {
          DocumentProcessingConfig = new global::Google.Cloud.DiscoveryEngine.V1.DocumentProcessingConfig();
        }
        DocumentProcessingConfig.MergeFrom(other.DocumentProcessingConfig);
      }
      if (other.startingSchema_ != null) {
        if (startingSchema_ == null) {
          StartingSchema = new global::Google.Cloud.DiscoveryEngine.V1.Schema();
        }
        StartingSchema.MergeFrom(other.StartingSchema);
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
          case 18: {
            DisplayName = input.ReadString();
            break;
          }
          case 24: {
            IndustryVertical = (global::Google.Cloud.DiscoveryEngine.V1.IndustryVertical) input.ReadEnum();
            break;
          }
          case 34: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 42:
          case 40: {
            solutionTypes_.AddEntriesFrom(input, _repeated_solutionTypes_codec);
            break;
          }
          case 48: {
            ContentConfig = (global::Google.Cloud.DiscoveryEngine.V1.DataStore.Types.ContentConfig) input.ReadEnum();
            break;
          }
          case 58: {
            DefaultSchemaId = input.ReadString();
            break;
          }
          case 218: {
            if (documentProcessingConfig_ == null) {
              DocumentProcessingConfig = new global::Google.Cloud.DiscoveryEngine.V1.DocumentProcessingConfig();
            }
            input.ReadMessage(DocumentProcessingConfig);
            break;
          }
          case 226: {
            if (startingSchema_ == null) {
              StartingSchema = new global::Google.Cloud.DiscoveryEngine.V1.Schema();
            }
            input.ReadMessage(StartingSchema);
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
            DisplayName = input.ReadString();
            break;
          }
          case 24: {
            IndustryVertical = (global::Google.Cloud.DiscoveryEngine.V1.IndustryVertical) input.ReadEnum();
            break;
          }
          case 34: {
            if (createTime_ == null) {
              CreateTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(CreateTime);
            break;
          }
          case 42:
          case 40: {
            solutionTypes_.AddEntriesFrom(ref input, _repeated_solutionTypes_codec);
            break;
          }
          case 48: {
            ContentConfig = (global::Google.Cloud.DiscoveryEngine.V1.DataStore.Types.ContentConfig) input.ReadEnum();
            break;
          }
          case 58: {
            DefaultSchemaId = input.ReadString();
            break;
          }
          case 218: {
            if (documentProcessingConfig_ == null) {
              DocumentProcessingConfig = new global::Google.Cloud.DiscoveryEngine.V1.DocumentProcessingConfig();
            }
            input.ReadMessage(DocumentProcessingConfig);
            break;
          }
          case 226: {
            if (startingSchema_ == null) {
              StartingSchema = new global::Google.Cloud.DiscoveryEngine.V1.Schema();
            }
            input.ReadMessage(StartingSchema);
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the DataStore message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Content config of the data store.
      /// </summary>
      public enum ContentConfig {
        /// <summary>
        /// Default value.
        /// </summary>
        [pbr::OriginalName("CONTENT_CONFIG_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Only contains documents without any
        /// [Document.content][google.cloud.discoveryengine.v1.Document.content].
        /// </summary>
        [pbr::OriginalName("NO_CONTENT")] NoContent = 1,
        /// <summary>
        /// Only contains documents with
        /// [Document.content][google.cloud.discoveryengine.v1.Document.content].
        /// </summary>
        [pbr::OriginalName("CONTENT_REQUIRED")] ContentRequired = 2,
        /// <summary>
        /// The data store is used for public website search.
        /// </summary>
        [pbr::OriginalName("PUBLIC_WEBSITE")] PublicWebsite = 3,
      }

    }
    #endregion

  }

  #endregion

}

#endregion Designer generated code
