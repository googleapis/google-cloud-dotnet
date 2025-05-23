// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/maps/weather/v1/air_pressure.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Geo.Weather.V1 {

  /// <summary>Holder for reflection information generated from google/maps/weather/v1/air_pressure.proto</summary>
  public static partial class AirPressureReflection {

    #region Descriptor
    /// <summary>File descriptor for google/maps/weather/v1/air_pressure.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static AirPressureReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cilnb29nbGUvbWFwcy93ZWF0aGVyL3YxL2Fpcl9wcmVzc3VyZS5wcm90bxIW",
            "Z29vZ2xlLm1hcHMud2VhdGhlci52MSJRCgtBaXJQcmVzc3VyZRIlChhtZWFu",
            "X3NlYV9sZXZlbF9taWxsaWJhcnMYASABKAJIAIgBAUIbChlfbWVhbl9zZWFf",
            "bGV2ZWxfbWlsbGliYXJzQqQBChpjb20uZ29vZ2xlLm1hcHMud2VhdGhlci52",
            "MUIQQWlyUHJlc3N1cmVQcm90b1ABWjpjbG91ZC5nb29nbGUuY29tL2dvL21h",
            "cHMvd2VhdGhlci9hcGl2MS93ZWF0aGVycGI7d2VhdGhlcnBiogIFR01XVjGq",
            "AhVHb29nbGUuR2VvLldlYXRoZXIuVjHKAhVHb29nbGVcR2VvXFdlYXRoZXJc",
            "VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Geo.Weather.V1.AirPressure), global::Google.Geo.Weather.V1.AirPressure.Parser, new[]{ "MeanSeaLevelMillibars" }, new[]{ "MeanSeaLevelMillibars" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Represents the atmospheric air pressure conditions.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class AirPressure : pb::IMessage<AirPressure>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<AirPressure> _parser = new pb::MessageParser<AirPressure>(() => new AirPressure());
    private pb::UnknownFieldSet _unknownFields;
    private int _hasBits0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<AirPressure> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Geo.Weather.V1.AirPressureReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AirPressure() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AirPressure(AirPressure other) : this() {
      _hasBits0 = other._hasBits0;
      meanSeaLevelMillibars_ = other.meanSeaLevelMillibars_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public AirPressure Clone() {
      return new AirPressure(this);
    }

    /// <summary>Field number for the "mean_sea_level_millibars" field.</summary>
    public const int MeanSeaLevelMillibarsFieldNumber = 1;
    private readonly static float MeanSeaLevelMillibarsDefaultValue = 0F;

    private float meanSeaLevelMillibars_;
    /// <summary>
    /// The mean sea level air pressure in millibars.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public float MeanSeaLevelMillibars {
      get { if ((_hasBits0 & 1) != 0) { return meanSeaLevelMillibars_; } else { return MeanSeaLevelMillibarsDefaultValue; } }
      set {
        _hasBits0 |= 1;
        meanSeaLevelMillibars_ = value;
      }
    }
    /// <summary>Gets whether the "mean_sea_level_millibars" field is set</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool HasMeanSeaLevelMillibars {
      get { return (_hasBits0 & 1) != 0; }
    }
    /// <summary>Clears the value of the "mean_sea_level_millibars" field</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void ClearMeanSeaLevelMillibars() {
      _hasBits0 &= ~1;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as AirPressure);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(AirPressure other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (!pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.Equals(MeanSeaLevelMillibars, other.MeanSeaLevelMillibars)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (HasMeanSeaLevelMillibars) hash ^= pbc::ProtobufEqualityComparers.BitwiseSingleEqualityComparer.GetHashCode(MeanSeaLevelMillibars);
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
      if (HasMeanSeaLevelMillibars) {
        output.WriteRawTag(13);
        output.WriteFloat(MeanSeaLevelMillibars);
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
      if (HasMeanSeaLevelMillibars) {
        output.WriteRawTag(13);
        output.WriteFloat(MeanSeaLevelMillibars);
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
      if (HasMeanSeaLevelMillibars) {
        size += 1 + 4;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(AirPressure other) {
      if (other == null) {
        return;
      }
      if (other.HasMeanSeaLevelMillibars) {
        MeanSeaLevelMillibars = other.MeanSeaLevelMillibars;
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
          case 13: {
            MeanSeaLevelMillibars = input.ReadFloat();
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
          case 13: {
            MeanSeaLevelMillibars = input.ReadFloat();
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
