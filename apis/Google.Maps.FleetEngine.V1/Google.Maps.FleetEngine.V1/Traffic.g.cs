// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/maps/fleetengine/v1/traffic.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Maps.FleetEngine.V1 {

  /// <summary>Holder for reflection information generated from google/maps/fleetengine/v1/traffic.proto</summary>
  public static partial class TrafficReflection {

    #region Descriptor
    /// <summary>File descriptor for google/maps/fleetengine/v1/traffic.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TrafficReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cihnb29nbGUvbWFwcy9mbGVldGVuZ2luZS92MS90cmFmZmljLnByb3RvEhNt",
            "YXBzLmZsZWV0ZW5naW5lLnYxIuMBChRTcGVlZFJlYWRpbmdJbnRlcnZhbBIi",
            "ChpzdGFydF9wb2x5bGluZV9wb2ludF9pbmRleBgBIAEoBRIgChhlbmRfcG9s",
            "eWxpbmVfcG9pbnRfaW5kZXgYAiABKAUSPgoFc3BlZWQYAyABKA4yLy5tYXBz",
            "LmZsZWV0ZW5naW5lLnYxLlNwZWVkUmVhZGluZ0ludGVydmFsLlNwZWVkIkUK",
            "BVNwZWVkEhUKEVNQRUVEX1VOU1BFQ0lGSUVEEAASCgoGTk9STUFMEAESCAoE",
            "U0xPVxACEg8KC1RSQUZGSUNfSkFNEAMiiAEKGUNvbnN1bWFibGVUcmFmZmlj",
            "UG9seWxpbmUSSQoWc3BlZWRfcmVhZGluZ19pbnRlcnZhbBgBIAMoCzIpLm1h",
            "cHMuZmxlZXRlbmdpbmUudjEuU3BlZWRSZWFkaW5nSW50ZXJ2YWwSIAoYZW5j",
            "b2RlZF9wYXRoX3RvX3dheXBvaW50GAIgASgJQpcBChpnb29nbGUubWFwcy5m",
            "bGVldGVuZ2luZS52MUIMVHJhZmZpY1Byb3RvUAFaRmNsb3VkLmdvb2dsZS5j",
            "b20vZ28vbWFwcy9mbGVldGVuZ2luZS9hcGl2MS9mbGVldGVuZ2luZXBiO2Zs",
            "ZWV0ZW5naW5lcGKiAgNDRkWqAhpHb29nbGUuTWFwcy5GbGVldEVuZ2luZS5W",
            "MWIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Maps.FleetEngine.V1.SpeedReadingInterval), global::Google.Maps.FleetEngine.V1.SpeedReadingInterval.Parser, new[]{ "StartPolylinePointIndex", "EndPolylinePointIndex", "Speed" }, null, new[]{ typeof(global::Google.Maps.FleetEngine.V1.SpeedReadingInterval.Types.Speed) }, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Maps.FleetEngine.V1.ConsumableTrafficPolyline), global::Google.Maps.FleetEngine.V1.ConsumableTrafficPolyline.Parser, new[]{ "SpeedReadingInterval", "EncodedPathToWaypoint" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Traffic density indicator on a contiguous segment of a path. Given a path
  /// with points P_0, P_1, ... , P_N (zero-based index), the SpeedReadingInterval
  /// defines an interval and describes its traffic using the following categories.
  /// </summary>
  public sealed partial class SpeedReadingInterval : pb::IMessage<SpeedReadingInterval>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SpeedReadingInterval> _parser = new pb::MessageParser<SpeedReadingInterval>(() => new SpeedReadingInterval());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SpeedReadingInterval> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Maps.FleetEngine.V1.TrafficReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpeedReadingInterval() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpeedReadingInterval(SpeedReadingInterval other) : this() {
      startPolylinePointIndex_ = other.startPolylinePointIndex_;
      endPolylinePointIndex_ = other.endPolylinePointIndex_;
      speed_ = other.speed_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SpeedReadingInterval Clone() {
      return new SpeedReadingInterval(this);
    }

    /// <summary>Field number for the "start_polyline_point_index" field.</summary>
    public const int StartPolylinePointIndexFieldNumber = 1;
    private int startPolylinePointIndex_;
    /// <summary>
    /// The starting index of this interval in the path.
    /// In JSON, when the index is 0, the field will appear to be unpopulated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int StartPolylinePointIndex {
      get { return startPolylinePointIndex_; }
      set {
        startPolylinePointIndex_ = value;
      }
    }

    /// <summary>Field number for the "end_polyline_point_index" field.</summary>
    public const int EndPolylinePointIndexFieldNumber = 2;
    private int endPolylinePointIndex_;
    /// <summary>
    /// The ending index of this interval in the path.
    /// In JSON, when the index is 0, the field will appear to be unpopulated.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int EndPolylinePointIndex {
      get { return endPolylinePointIndex_; }
      set {
        endPolylinePointIndex_ = value;
      }
    }

    /// <summary>Field number for the "speed" field.</summary>
    public const int SpeedFieldNumber = 3;
    private global::Google.Maps.FleetEngine.V1.SpeedReadingInterval.Types.Speed speed_ = global::Google.Maps.FleetEngine.V1.SpeedReadingInterval.Types.Speed.Unspecified;
    /// <summary>
    /// Traffic speed in this interval.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Maps.FleetEngine.V1.SpeedReadingInterval.Types.Speed Speed {
      get { return speed_; }
      set {
        speed_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SpeedReadingInterval);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SpeedReadingInterval other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (StartPolylinePointIndex != other.StartPolylinePointIndex) return false;
      if (EndPolylinePointIndex != other.EndPolylinePointIndex) return false;
      if (Speed != other.Speed) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (StartPolylinePointIndex != 0) hash ^= StartPolylinePointIndex.GetHashCode();
      if (EndPolylinePointIndex != 0) hash ^= EndPolylinePointIndex.GetHashCode();
      if (Speed != global::Google.Maps.FleetEngine.V1.SpeedReadingInterval.Types.Speed.Unspecified) hash ^= Speed.GetHashCode();
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
      if (StartPolylinePointIndex != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(StartPolylinePointIndex);
      }
      if (EndPolylinePointIndex != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(EndPolylinePointIndex);
      }
      if (Speed != global::Google.Maps.FleetEngine.V1.SpeedReadingInterval.Types.Speed.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Speed);
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
      if (StartPolylinePointIndex != 0) {
        output.WriteRawTag(8);
        output.WriteInt32(StartPolylinePointIndex);
      }
      if (EndPolylinePointIndex != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(EndPolylinePointIndex);
      }
      if (Speed != global::Google.Maps.FleetEngine.V1.SpeedReadingInterval.Types.Speed.Unspecified) {
        output.WriteRawTag(24);
        output.WriteEnum((int) Speed);
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
      if (StartPolylinePointIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StartPolylinePointIndex);
      }
      if (EndPolylinePointIndex != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EndPolylinePointIndex);
      }
      if (Speed != global::Google.Maps.FleetEngine.V1.SpeedReadingInterval.Types.Speed.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Speed);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SpeedReadingInterval other) {
      if (other == null) {
        return;
      }
      if (other.StartPolylinePointIndex != 0) {
        StartPolylinePointIndex = other.StartPolylinePointIndex;
      }
      if (other.EndPolylinePointIndex != 0) {
        EndPolylinePointIndex = other.EndPolylinePointIndex;
      }
      if (other.Speed != global::Google.Maps.FleetEngine.V1.SpeedReadingInterval.Types.Speed.Unspecified) {
        Speed = other.Speed;
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
          case 8: {
            StartPolylinePointIndex = input.ReadInt32();
            break;
          }
          case 16: {
            EndPolylinePointIndex = input.ReadInt32();
            break;
          }
          case 24: {
            Speed = (global::Google.Maps.FleetEngine.V1.SpeedReadingInterval.Types.Speed) input.ReadEnum();
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
          case 8: {
            StartPolylinePointIndex = input.ReadInt32();
            break;
          }
          case 16: {
            EndPolylinePointIndex = input.ReadInt32();
            break;
          }
          case 24: {
            Speed = (global::Google.Maps.FleetEngine.V1.SpeedReadingInterval.Types.Speed) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the SpeedReadingInterval message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// The classification of polyline speed based on traffic data.
      /// </summary>
      public enum Speed {
        /// <summary>
        /// Default value. This value is unused.
        /// </summary>
        [pbr::OriginalName("SPEED_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// Normal speed, no slowdown is detected.
        /// </summary>
        [pbr::OriginalName("NORMAL")] Normal = 1,
        /// <summary>
        /// Slowdown detected, but no traffic jam formed.
        /// </summary>
        [pbr::OriginalName("SLOW")] Slow = 2,
        /// <summary>
        /// Traffic jam detected.
        /// </summary>
        [pbr::OriginalName("TRAFFIC_JAM")] TrafficJam = 3,
      }

    }
    #endregion

  }

  /// <summary>
  /// Traffic density along a Vehicle's path.
  /// </summary>
  public sealed partial class ConsumableTrafficPolyline : pb::IMessage<ConsumableTrafficPolyline>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<ConsumableTrafficPolyline> _parser = new pb::MessageParser<ConsumableTrafficPolyline>(() => new ConsumableTrafficPolyline());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<ConsumableTrafficPolyline> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Maps.FleetEngine.V1.TrafficReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConsumableTrafficPolyline() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConsumableTrafficPolyline(ConsumableTrafficPolyline other) : this() {
      speedReadingInterval_ = other.speedReadingInterval_.Clone();
      encodedPathToWaypoint_ = other.encodedPathToWaypoint_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ConsumableTrafficPolyline Clone() {
      return new ConsumableTrafficPolyline(this);
    }

    /// <summary>Field number for the "speed_reading_interval" field.</summary>
    public const int SpeedReadingIntervalFieldNumber = 1;
    private static readonly pb::FieldCodec<global::Google.Maps.FleetEngine.V1.SpeedReadingInterval> _repeated_speedReadingInterval_codec
        = pb::FieldCodec.ForMessage(10, global::Google.Maps.FleetEngine.V1.SpeedReadingInterval.Parser);
    private readonly pbc::RepeatedField<global::Google.Maps.FleetEngine.V1.SpeedReadingInterval> speedReadingInterval_ = new pbc::RepeatedField<global::Google.Maps.FleetEngine.V1.SpeedReadingInterval>();
    /// <summary>
    /// Traffic speed along the path from the previous waypoint to the current
    /// waypoint.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Maps.FleetEngine.V1.SpeedReadingInterval> SpeedReadingInterval {
      get { return speedReadingInterval_; }
    }

    /// <summary>Field number for the "encoded_path_to_waypoint" field.</summary>
    public const int EncodedPathToWaypointFieldNumber = 2;
    private string encodedPathToWaypoint_ = "";
    /// <summary>
    /// The path the driver is taking from the previous waypoint to the current
    /// waypoint. This path has landmarks in it so clients can show traffic markers
    /// along the path (see `speed_reading_interval`).  Decoding is not yet
    /// supported.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string EncodedPathToWaypoint {
      get { return encodedPathToWaypoint_; }
      set {
        encodedPathToWaypoint_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as ConsumableTrafficPolyline);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(ConsumableTrafficPolyline other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if(!speedReadingInterval_.Equals(other.speedReadingInterval_)) return false;
      if (EncodedPathToWaypoint != other.EncodedPathToWaypoint) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      hash ^= speedReadingInterval_.GetHashCode();
      if (EncodedPathToWaypoint.Length != 0) hash ^= EncodedPathToWaypoint.GetHashCode();
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
      speedReadingInterval_.WriteTo(output, _repeated_speedReadingInterval_codec);
      if (EncodedPathToWaypoint.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(EncodedPathToWaypoint);
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
      speedReadingInterval_.WriteTo(ref output, _repeated_speedReadingInterval_codec);
      if (EncodedPathToWaypoint.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(EncodedPathToWaypoint);
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
      size += speedReadingInterval_.CalculateSize(_repeated_speedReadingInterval_codec);
      if (EncodedPathToWaypoint.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(EncodedPathToWaypoint);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(ConsumableTrafficPolyline other) {
      if (other == null) {
        return;
      }
      speedReadingInterval_.Add(other.speedReadingInterval_);
      if (other.EncodedPathToWaypoint.Length != 0) {
        EncodedPathToWaypoint = other.EncodedPathToWaypoint;
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
            speedReadingInterval_.AddEntriesFrom(input, _repeated_speedReadingInterval_codec);
            break;
          }
          case 18: {
            EncodedPathToWaypoint = input.ReadString();
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
            speedReadingInterval_.AddEntriesFrom(ref input, _repeated_speedReadingInterval_codec);
            break;
          }
          case 18: {
            EncodedPathToWaypoint = input.ReadString();
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