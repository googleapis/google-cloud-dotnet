// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/ads/admanager/v1/operating_system_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Ads.AdManager.V1 {

  /// <summary>Holder for reflection information generated from google/ads/admanager/v1/operating_system_service.proto</summary>
  public static partial class OperatingSystemServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for google/ads/admanager/v1/operating_system_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OperatingSystemServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjZnb29nbGUvYWRzL2FkbWFuYWdlci92MS9vcGVyYXRpbmdfc3lzdGVtX3Nl",
            "cnZpY2UucHJvdG8SF2dvb2dsZS5hZHMuYWRtYW5hZ2VyLnYxGjdnb29nbGUv",
            "YWRzL2FkbWFuYWdlci92MS9vcGVyYXRpbmdfc3lzdGVtX21lc3NhZ2VzLnBy",
            "b3RvGhxnb29nbGUvYXBpL2Fubm90YXRpb25zLnByb3RvGhdnb29nbGUvYXBp",
            "L2NsaWVudC5wcm90bxofZ29vZ2xlL2FwaS9maWVsZF9iZWhhdmlvci5wcm90",
            "bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90byJbChlHZXRPcGVyYXRpbmdT",
            "eXN0ZW1SZXF1ZXN0Ej4KBG5hbWUYASABKAlCMOBBAvpBKgooYWRtYW5hZ2Vy",
            "Lmdvb2dsZWFwaXMuY29tL09wZXJhdGluZ1N5c3RlbSLHAQobTGlzdE9wZXJh",
            "dGluZ1N5c3RlbXNSZXF1ZXN0EjgKBnBhcmVudBgBIAEoCUIo4EEC+kEiCiBh",
            "ZG1hbmFnZXIuZ29vZ2xlYXBpcy5jb20vTmV0d29yaxIWCglwYWdlX3NpemUY",
            "AiABKAVCA+BBARIXCgpwYWdlX3Rva2VuGAMgASgJQgPgQQESEwoGZmlsdGVy",
            "GAQgASgJQgPgQQESFQoIb3JkZXJfYnkYBSABKAlCA+BBARIRCgRza2lwGAYg",
            "ASgFQgPgQQEikAEKHExpc3RPcGVyYXRpbmdTeXN0ZW1zUmVzcG9uc2USQwoR",
            "b3BlcmF0aW5nX3N5c3RlbXMYASADKAsyKC5nb29nbGUuYWRzLmFkbWFuYWdl",
            "ci52MS5PcGVyYXRpbmdTeXN0ZW0SFwoPbmV4dF9wYWdlX3Rva2VuGAIgASgJ",
            "EhIKCnRvdGFsX3NpemUYAyABKAUy0AMKFk9wZXJhdGluZ1N5c3RlbVNlcnZp",
            "Y2USqwEKEkdldE9wZXJhdGluZ1N5c3RlbRIyLmdvb2dsZS5hZHMuYWRtYW5h",
            "Z2VyLnYxLkdldE9wZXJhdGluZ1N5c3RlbVJlcXVlc3QaKC5nb29nbGUuYWRz",
            "LmFkbWFuYWdlci52MS5PcGVyYXRpbmdTeXN0ZW0iN9pBBG5hbWWC0+STAioS",
            "KC92MS97bmFtZT1uZXR3b3Jrcy8qL29wZXJhdGluZ1N5c3RlbXMvKn0SvgEK",
            "FExpc3RPcGVyYXRpbmdTeXN0ZW1zEjQuZ29vZ2xlLmFkcy5hZG1hbmFnZXIu",
            "djEuTGlzdE9wZXJhdGluZ1N5c3RlbXNSZXF1ZXN0GjUuZ29vZ2xlLmFkcy5h",
            "ZG1hbmFnZXIudjEuTGlzdE9wZXJhdGluZ1N5c3RlbXNSZXNwb25zZSI52kEG",
            "cGFyZW50gtPkkwIqEigvdjEve3BhcmVudD1uZXR3b3Jrcy8qfS9vcGVyYXRp",
            "bmdTeXN0ZW1zGkfKQRhhZG1hbmFnZXIuZ29vZ2xlYXBpcy5jb23SQSlodHRw",
            "czovL3d3dy5nb29nbGVhcGlzLmNvbS9hdXRoL2FkbWFuYWdlckLPAQobY29t",
            "Lmdvb2dsZS5hZHMuYWRtYW5hZ2VyLnYxQhtPcGVyYXRpbmdTeXN0ZW1TZXJ2",
            "aWNlUHJvdG9QAVpAZ29vZ2xlLmdvbGFuZy5vcmcvZ2VucHJvdG8vZ29vZ2xl",
            "YXBpcy9hZHMvYWRtYW5hZ2VyL3YxO2FkbWFuYWdlcqoCF0dvb2dsZS5BZHMu",
            "QWRNYW5hZ2VyLlYxygIXR29vZ2xlXEFkc1xBZE1hbmFnZXJcVjHqAhpHb29n",
            "bGU6OkFkczo6QWRNYW5hZ2VyOjpWMWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Ads.AdManager.V1.OperatingSystemMessagesReflection.Descriptor, global::Google.Api.AnnotationsReflection.Descriptor, global::Google.Api.ClientReflection.Descriptor, global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.AdManager.V1.GetOperatingSystemRequest), global::Google.Ads.AdManager.V1.GetOperatingSystemRequest.Parser, new[]{ "Name" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.AdManager.V1.ListOperatingSystemsRequest), global::Google.Ads.AdManager.V1.ListOperatingSystemsRequest.Parser, new[]{ "Parent", "PageSize", "PageToken", "Filter", "OrderBy", "Skip" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Ads.AdManager.V1.ListOperatingSystemsResponse), global::Google.Ads.AdManager.V1.ListOperatingSystemsResponse.Parser, new[]{ "OperatingSystems", "NextPageToken", "TotalSize" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Request object for `GetOperatingSystem` method.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class GetOperatingSystemRequest : pb::IMessage<GetOperatingSystemRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<GetOperatingSystemRequest> _parser = new pb::MessageParser<GetOperatingSystemRequest>(() => new GetOperatingSystemRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<GetOperatingSystemRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.AdManager.V1.OperatingSystemServiceReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetOperatingSystemRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetOperatingSystemRequest(GetOperatingSystemRequest other) : this() {
      name_ = other.name_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public GetOperatingSystemRequest Clone() {
      return new GetOperatingSystemRequest(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Required. The resource name of the OperatingSystem.
    /// Format: `networks/{network_code}/operatingSystems/{operating_system_id}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as GetOperatingSystemRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(GetOperatingSystemRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
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
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(GetOperatingSystemRequest other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
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
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Request object for `ListOperatingSystems` method.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ListOperatingSystemsRequest : pb::IMessage<ListOperatingSystemsRequest>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ListOperatingSystemsRequest> _parser = new pb::MessageParser<ListOperatingSystemsRequest>(() => new ListOperatingSystemsRequest());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ListOperatingSystemsRequest> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.AdManager.V1.OperatingSystemServiceReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListOperatingSystemsRequest() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListOperatingSystemsRequest(ListOperatingSystemsRequest other) : this() {
      parent_ = other.parent_;
      pageSize_ = other.pageSize_;
      pageToken_ = other.pageToken_;
      filter_ = other.filter_;
      orderBy_ = other.orderBy_;
      skip_ = other.skip_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListOperatingSystemsRequest Clone() {
      return new ListOperatingSystemsRequest(this);
    }

    /// <summary>Field number for the "parent" field.</summary>
    public const int ParentFieldNumber = 1;
    private string parent_ = "";
    /// <summary>
    /// Required. The parent, which owns this collection of OperatingSystems.
    /// Format: `networks/{network_code}`
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Parent {
      get { return parent_; }
      set {
        parent_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "page_size" field.</summary>
    public const int PageSizeFieldNumber = 2;
    private int pageSize_;
    /// <summary>
    /// Optional. The maximum number of `OperatingSystems` to return. The service
    /// may return fewer than this value. If unspecified, at most 50
    /// `OperatingSystems` will be returned. The maximum value is 1000; values
    /// above 1000 will be coerced to 1000.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int PageSize {
      get { return pageSize_; }
      set {
        pageSize_ = value;
      }
    }

    /// <summary>Field number for the "page_token" field.</summary>
    public const int PageTokenFieldNumber = 3;
    private string pageToken_ = "";
    /// <summary>
    /// Optional. A page token, received from a previous `ListOperatingSystems`
    /// call. Provide this to retrieve the subsequent page.
    ///
    /// When paginating, all other parameters provided to `ListOperatingSystems`
    /// must match the call that provided the page token.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string PageToken {
      get { return pageToken_; }
      set {
        pageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "filter" field.</summary>
    public const int FilterFieldNumber = 4;
    private string filter_ = "";
    /// <summary>
    /// Optional. Expression to filter the response.
    /// See syntax details at
    /// https://developers.google.com/ad-manager/api/beta/filters
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Filter {
      get { return filter_; }
      set {
        filter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "order_by" field.</summary>
    public const int OrderByFieldNumber = 5;
    private string orderBy_ = "";
    /// <summary>
    /// Optional. Expression to specify sorting order.
    /// See syntax details at
    /// https://developers.google.com/ad-manager/api/beta/filters#order
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string OrderBy {
      get { return orderBy_; }
      set {
        orderBy_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "skip" field.</summary>
    public const int SkipFieldNumber = 6;
    private int skip_;
    /// <summary>
    /// Optional. Number of individual resources to skip while paginating.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int Skip {
      get { return skip_; }
      set {
        skip_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ListOperatingSystemsRequest);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ListOperatingSystemsRequest other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Parent != other.Parent) return false;
      if (PageSize != other.PageSize) return false;
      if (PageToken != other.PageToken) return false;
      if (Filter != other.Filter) return false;
      if (OrderBy != other.OrderBy) return false;
      if (Skip != other.Skip) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Parent.Length != 0) hash ^= Parent.GetHashCode();
      if (PageSize != 0) hash ^= PageSize.GetHashCode();
      if (PageToken.Length != 0) hash ^= PageToken.GetHashCode();
      if (Filter.Length != 0) hash ^= Filter.GetHashCode();
      if (OrderBy.Length != 0) hash ^= OrderBy.GetHashCode();
      if (Skip != 0) hash ^= Skip.GetHashCode();
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
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (PageSize != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PageToken);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Filter);
      }
      if (OrderBy.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OrderBy);
      }
      if (Skip != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Skip);
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
      if (Parent.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Parent);
      }
      if (PageSize != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(PageSize);
      }
      if (PageToken.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(PageToken);
      }
      if (Filter.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(Filter);
      }
      if (OrderBy.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(OrderBy);
      }
      if (Skip != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(Skip);
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
      if (Parent.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Parent);
      }
      if (PageSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(PageSize);
      }
      if (PageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(PageToken);
      }
      if (Filter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Filter);
      }
      if (OrderBy.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(OrderBy);
      }
      if (Skip != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Skip);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ListOperatingSystemsRequest other) {
      if (other == null) {
        return;
      }
      if (other.Parent.Length != 0) {
        Parent = other.Parent;
      }
      if (other.PageSize != 0) {
        PageSize = other.PageSize;
      }
      if (other.PageToken.Length != 0) {
        PageToken = other.PageToken;
      }
      if (other.Filter.Length != 0) {
        Filter = other.Filter;
      }
      if (other.OrderBy.Length != 0) {
        OrderBy = other.OrderBy;
      }
      if (other.Skip != 0) {
        Skip = other.Skip;
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
            Parent = input.ReadString();
            break;
          }
          case 16: {
            PageSize = input.ReadInt32();
            break;
          }
          case 26: {
            PageToken = input.ReadString();
            break;
          }
          case 34: {
            Filter = input.ReadString();
            break;
          }
          case 42: {
            OrderBy = input.ReadString();
            break;
          }
          case 48: {
            Skip = input.ReadInt32();
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
            Parent = input.ReadString();
            break;
          }
          case 16: {
            PageSize = input.ReadInt32();
            break;
          }
          case 26: {
            PageToken = input.ReadString();
            break;
          }
          case 34: {
            Filter = input.ReadString();
            break;
          }
          case 42: {
            OrderBy = input.ReadString();
            break;
          }
          case 48: {
            Skip = input.ReadInt32();
            break;
          }
        }
      }
    }
    #endif

  }

  /// <summary>
  /// Response object for `ListOperatingSystemsRequest` containing matching
  /// `OperatingSystem` objects.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class ListOperatingSystemsResponse : pb::IMessage<ListOperatingSystemsResponse>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ListOperatingSystemsResponse> _parser = new pb::MessageParser<ListOperatingSystemsResponse>(() => new ListOperatingSystemsResponse());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ListOperatingSystemsResponse> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Ads.AdManager.V1.OperatingSystemServiceReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListOperatingSystemsResponse() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListOperatingSystemsResponse(ListOperatingSystemsResponse other) : this() {
      operatingSystems_ = other.operatingSystems_.Clone();
      nextPageToken_ = other.nextPageToken_;
      totalSize_ = other.totalSize_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ListOperatingSystemsResponse Clone() {
      return new ListOperatingSystemsResponse(this);
    }

    /// <summary>Field number for the "operating_systems" field.</summary>
    public const int OperatingSystemsFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Ads.AdManager.V1.OperatingSystem> _repeated_operatingSystems_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Ads.AdManager.V1.OperatingSystem.Parser);
    private readonly pbc::RepeatedField<global::Google.Ads.AdManager.V1.OperatingSystem> operatingSystems_ = new pbc::RepeatedField<global::Google.Ads.AdManager.V1.OperatingSystem>();
    /// <summary>
    /// The `OperatingSystem` objects from the specified network.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Ads.AdManager.V1.OperatingSystem> OperatingSystems {
      get { return operatingSystems_; }
    }

    /// <summary>Field number for the "next_page_token" field.</summary>
    public const int NextPageTokenFieldNumber = 2;
    private string nextPageToken_ = "";
    /// <summary>
    /// A token, which can be sent as `page_token` to retrieve the next page.
    /// If this field is omitted, there are no subsequent pages.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string NextPageToken {
      get { return nextPageToken_; }
      set {
        nextPageToken_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "total_size" field.</summary>
    public const int TotalSizeFieldNumber = 3;
    private int totalSize_;
    /// <summary>
    /// Total number of `OperatingSystem` objects.
    /// If a filter was included in the request, this reflects the total number
    /// after the filtering is applied.
    ///
    /// `total_size` will not be calculated in the response unless it has been
    /// included in a response field mask. The response field mask can be provided
    /// to the method by using the URL parameter `$fields` or `fields`, or by using
    /// the HTTP/gRPC header `X-Goog-FieldMask`.
    ///
    /// For more information, see
    /// https://developers.google.com/ad-manager/api/beta/field-masks
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int TotalSize {
      get { return totalSize_; }
      set {
        totalSize_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ListOperatingSystemsResponse);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ListOperatingSystemsResponse other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!operatingSystems_.Equals(other.operatingSystems_)) return false;
      if (NextPageToken != other.NextPageToken) return false;
      if (TotalSize != other.TotalSize) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= operatingSystems_.GetHashCode();
      if (NextPageToken.Length != 0) hash ^= NextPageToken.GetHashCode();
      if (TotalSize != 0) hash ^= TotalSize.GetHashCode();
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
      operatingSystems_.WriteTo(output, _repeated_operatingSystems_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      if (TotalSize != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(TotalSize);
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
      operatingSystems_.WriteTo(ref output, _repeated_operatingSystems_codec);
      if (NextPageToken.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(NextPageToken);
      }
      if (TotalSize != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(TotalSize);
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
      size += operatingSystems_.CalculateSize(_repeated_operatingSystems_codec);
      if (NextPageToken.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(NextPageToken);
      }
      if (TotalSize != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TotalSize);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ListOperatingSystemsResponse other) {
      if (other == null) {
        return;
      }
      operatingSystems_.Add(other.operatingSystems_);
      if (other.NextPageToken.Length != 0) {
        NextPageToken = other.NextPageToken;
      }
      if (other.TotalSize != 0) {
        TotalSize = other.TotalSize;
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
            operatingSystems_.AddEntriesFrom(input, _repeated_operatingSystems_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
            break;
          }
          case 24: {
            TotalSize = input.ReadInt32();
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
            operatingSystems_.AddEntriesFrom(ref input, _repeated_operatingSystems_codec);
            break;
          }
          case 18: {
            NextPageToken = input.ReadString();
            break;
          }
          case 24: {
            TotalSize = input.ReadInt32();
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
