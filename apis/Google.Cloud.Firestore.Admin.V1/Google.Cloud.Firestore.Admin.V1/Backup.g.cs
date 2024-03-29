// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/firestore/admin/v1/backup.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Cloud.Firestore.Admin.V1 {

  /// <summary>Holder for reflection information generated from google/firestore/admin/v1/backup.proto</summary>
  public static partial class BackupReflection {

    #region Descriptor
    /// <summary>File descriptor for google/firestore/admin/v1/backup.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static BackupReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiZnb29nbGUvZmlyZXN0b3JlL2FkbWluL3YxL2JhY2t1cC5wcm90bxIZZ29v",
            "Z2xlLmZpcmVzdG9yZS5hZG1pbi52MRofZ29vZ2xlL2FwaS9maWVsZF9iZWhh",
            "dmlvci5wcm90bxoZZ29vZ2xlL2FwaS9yZXNvdXJjZS5wcm90bxofZ29vZ2xl",
            "L3Byb3RvYnVmL3RpbWVzdGFtcC5wcm90byLgBAoGQmFja3VwEhEKBG5hbWUY",
            "ASABKAlCA+BBAxI7CghkYXRhYmFzZRgCIAEoCUIp4EED+kEjCiFmaXJlc3Rv",
            "cmUuZ29vZ2xlYXBpcy5jb20vRGF0YWJhc2USGQoMZGF0YWJhc2VfdWlkGAcg",
            "ASgJQgPgQQMSNgoNc25hcHNob3RfdGltZRgDIAEoCzIaLmdvb2dsZS5wcm90",
            "b2J1Zi5UaW1lc3RhbXBCA+BBAxI0CgtleHBpcmVfdGltZRgEIAEoCzIaLmdv",
            "b2dsZS5wcm90b2J1Zi5UaW1lc3RhbXBCA+BBAxI7CgVzdGF0cxgGIAEoCzIn",
            "Lmdvb2dsZS5maXJlc3RvcmUuYWRtaW4udjEuQmFja3VwLlN0YXRzQgPgQQMS",
            "OwoFc3RhdGUYCCABKA4yJy5nb29nbGUuZmlyZXN0b3JlLmFkbWluLnYxLkJh",
            "Y2t1cC5TdGF0ZUID4EEDGlcKBVN0YXRzEhcKCnNpemVfYnl0ZXMYASABKANC",
            "A+BBAxIbCg5kb2N1bWVudF9jb3VudBgCIAEoA0ID4EEDEhgKC2luZGV4X2Nv",
            "dW50GAMgASgDQgPgQQMiSgoFU3RhdGUSFQoRU1RBVEVfVU5TUEVDSUZJRUQQ",
            "ABIMCghDUkVBVElORxABEgkKBVJFQURZEAISEQoNTk9UX0FWQUlMQUJMRRAD",
            "Ol7qQVsKH2ZpcmVzdG9yZS5nb29nbGVhcGlzLmNvbS9CYWNrdXASOHByb2pl",
            "Y3RzL3twcm9qZWN0fS9sb2NhdGlvbnMve2xvY2F0aW9ufS9iYWNrdXBzL3ti",
            "YWNrdXB9QtoBCh1jb20uZ29vZ2xlLmZpcmVzdG9yZS5hZG1pbi52MUILQmFj",
            "a3VwUHJvdG9QAVo5Y2xvdWQuZ29vZ2xlLmNvbS9nby9maXJlc3RvcmUvYXBp",
            "djEvYWRtaW4vYWRtaW5wYjthZG1pbnBiogIER0NGU6oCH0dvb2dsZS5DbG91",
            "ZC5GaXJlc3RvcmUuQWRtaW4uVjHKAh9Hb29nbGVcQ2xvdWRcRmlyZXN0b3Jl",
            "XEFkbWluXFYx6gIjR29vZ2xlOjpDbG91ZDo6RmlyZXN0b3JlOjpBZG1pbjo6",
            "VjFiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Firestore.Admin.V1.Backup), global::Google.Cloud.Firestore.Admin.V1.Backup.Parser, new[]{ "Name", "Database", "DatabaseUid", "SnapshotTime", "ExpireTime", "Stats", "State" }, null, new[]{ typeof(global::Google.Cloud.Firestore.Admin.V1.Backup.Types.State) }, null, new pbr::GeneratedClrTypeInfo[] { new pbr::GeneratedClrTypeInfo(typeof(global::Google.Cloud.Firestore.Admin.V1.Backup.Types.Stats), global::Google.Cloud.Firestore.Admin.V1.Backup.Types.Stats.Parser, new[]{ "SizeBytes", "DocumentCount", "IndexCount" }, null, null, null, null)})
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// A Backup of a Cloud Firestore Database.
  ///
  /// The backup contains all documents and index configurations for the given
  /// database at a specific point in time.
  /// </summary>
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Backup : pb::IMessage<Backup>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Backup> _parser = new pb::MessageParser<Backup>(() => new Backup());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Backup> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Cloud.Firestore.Admin.V1.BackupReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Backup() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Backup(Backup other) : this() {
      name_ = other.name_;
      database_ = other.database_;
      databaseUid_ = other.databaseUid_;
      snapshotTime_ = other.snapshotTime_ != null ? other.snapshotTime_.Clone() : null;
      expireTime_ = other.expireTime_ != null ? other.expireTime_.Clone() : null;
      stats_ = other.stats_ != null ? other.stats_.Clone() : null;
      state_ = other.state_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Backup Clone() {
      return new Backup(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Output only. The unique resource name of the Backup.
    ///
    /// Format is `projects/{project}/locations/{location}/backups/{backup}`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "database" field.</summary>
    public const int DatabaseFieldNumber = 2;
    private string database_ = "";
    /// <summary>
    /// Output only. Name of the Firestore database that the backup is from.
    ///
    /// Format is `projects/{project}/databases/{database}`.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Database {
      get { return database_; }
      set {
        database_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "database_uid" field.</summary>
    public const int DatabaseUidFieldNumber = 7;
    private string databaseUid_ = "";
    /// <summary>
    /// Output only. The system-generated UUID4 for the Firestore database that the
    /// backup is from.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string DatabaseUid {
      get { return databaseUid_; }
      set {
        databaseUid_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "snapshot_time" field.</summary>
    public const int SnapshotTimeFieldNumber = 3;
    private global::Google.Protobuf.WellKnownTypes.Timestamp snapshotTime_;
    /// <summary>
    /// Output only. The backup contains an externally consistent copy of the
    /// database at this time.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp SnapshotTime {
      get { return snapshotTime_; }
      set {
        snapshotTime_ = value;
      }
    }

    /// <summary>Field number for the "expire_time" field.</summary>
    public const int ExpireTimeFieldNumber = 4;
    private global::Google.Protobuf.WellKnownTypes.Timestamp expireTime_;
    /// <summary>
    /// Output only. The timestamp at which this backup expires.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp ExpireTime {
      get { return expireTime_; }
      set {
        expireTime_ = value;
      }
    }

    /// <summary>Field number for the "stats" field.</summary>
    public const int StatsFieldNumber = 6;
    private global::Google.Cloud.Firestore.Admin.V1.Backup.Types.Stats stats_;
    /// <summary>
    /// Output only. Statistics about the backup.
    ///
    /// This data only becomes available after the backup is fully materialized to
    /// secondary storage. This field will be empty till then.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Firestore.Admin.V1.Backup.Types.Stats Stats {
      get { return stats_; }
      set {
        stats_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 8;
    private global::Google.Cloud.Firestore.Admin.V1.Backup.Types.State state_ = global::Google.Cloud.Firestore.Admin.V1.Backup.Types.State.Unspecified;
    /// <summary>
    /// Output only. The current state of the backup.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Cloud.Firestore.Admin.V1.Backup.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Backup);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Backup other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (Database != other.Database) return false;
      if (DatabaseUid != other.DatabaseUid) return false;
      if (!object.Equals(SnapshotTime, other.SnapshotTime)) return false;
      if (!object.Equals(ExpireTime, other.ExpireTime)) return false;
      if (!object.Equals(Stats, other.Stats)) return false;
      if (State != other.State) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (Database.Length != 0) hash ^= Database.GetHashCode();
      if (DatabaseUid.Length != 0) hash ^= DatabaseUid.GetHashCode();
      if (snapshotTime_ != null) hash ^= SnapshotTime.GetHashCode();
      if (expireTime_ != null) hash ^= ExpireTime.GetHashCode();
      if (stats_ != null) hash ^= Stats.GetHashCode();
      if (State != global::Google.Cloud.Firestore.Admin.V1.Backup.Types.State.Unspecified) hash ^= State.GetHashCode();
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
      if (Database.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Database);
      }
      if (snapshotTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(SnapshotTime);
      }
      if (expireTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ExpireTime);
      }
      if (stats_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Stats);
      }
      if (DatabaseUid.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(DatabaseUid);
      }
      if (State != global::Google.Cloud.Firestore.Admin.V1.Backup.Types.State.Unspecified) {
        output.WriteRawTag(64);
        output.WriteEnum((int) State);
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
      if (Database.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Database);
      }
      if (snapshotTime_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(SnapshotTime);
      }
      if (expireTime_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(ExpireTime);
      }
      if (stats_ != null) {
        output.WriteRawTag(50);
        output.WriteMessage(Stats);
      }
      if (DatabaseUid.Length != 0) {
        output.WriteRawTag(58);
        output.WriteString(DatabaseUid);
      }
      if (State != global::Google.Cloud.Firestore.Admin.V1.Backup.Types.State.Unspecified) {
        output.WriteRawTag(64);
        output.WriteEnum((int) State);
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
      if (Database.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Database);
      }
      if (DatabaseUid.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(DatabaseUid);
      }
      if (snapshotTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(SnapshotTime);
      }
      if (expireTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(ExpireTime);
      }
      if (stats_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Stats);
      }
      if (State != global::Google.Cloud.Firestore.Admin.V1.Backup.Types.State.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Backup other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.Database.Length != 0) {
        Database = other.Database;
      }
      if (other.DatabaseUid.Length != 0) {
        DatabaseUid = other.DatabaseUid;
      }
      if (other.snapshotTime_ != null) {
        if (snapshotTime_ == null) {
          SnapshotTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        SnapshotTime.MergeFrom(other.SnapshotTime);
      }
      if (other.expireTime_ != null) {
        if (expireTime_ == null) {
          ExpireTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        ExpireTime.MergeFrom(other.ExpireTime);
      }
      if (other.stats_ != null) {
        if (stats_ == null) {
          Stats = new global::Google.Cloud.Firestore.Admin.V1.Backup.Types.Stats();
        }
        Stats.MergeFrom(other.Stats);
      }
      if (other.State != global::Google.Cloud.Firestore.Admin.V1.Backup.Types.State.Unspecified) {
        State = other.State;
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
            Database = input.ReadString();
            break;
          }
          case 26: {
            if (snapshotTime_ == null) {
              SnapshotTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(SnapshotTime);
            break;
          }
          case 34: {
            if (expireTime_ == null) {
              ExpireTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ExpireTime);
            break;
          }
          case 50: {
            if (stats_ == null) {
              Stats = new global::Google.Cloud.Firestore.Admin.V1.Backup.Types.Stats();
            }
            input.ReadMessage(Stats);
            break;
          }
          case 58: {
            DatabaseUid = input.ReadString();
            break;
          }
          case 64: {
            State = (global::Google.Cloud.Firestore.Admin.V1.Backup.Types.State) input.ReadEnum();
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
            Database = input.ReadString();
            break;
          }
          case 26: {
            if (snapshotTime_ == null) {
              SnapshotTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(SnapshotTime);
            break;
          }
          case 34: {
            if (expireTime_ == null) {
              ExpireTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(ExpireTime);
            break;
          }
          case 50: {
            if (stats_ == null) {
              Stats = new global::Google.Cloud.Firestore.Admin.V1.Backup.Types.Stats();
            }
            input.ReadMessage(Stats);
            break;
          }
          case 58: {
            DatabaseUid = input.ReadString();
            break;
          }
          case 64: {
            State = (global::Google.Cloud.Firestore.Admin.V1.Backup.Types.State) input.ReadEnum();
            break;
          }
        }
      }
    }
    #endif

    #region Nested types
    /// <summary>Container for nested types declared in the Backup message type.</summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static partial class Types {
      /// <summary>
      /// Indicate the current state of the backup.
      /// </summary>
      public enum State {
        /// <summary>
        /// The state is unspecified.
        /// </summary>
        [pbr::OriginalName("STATE_UNSPECIFIED")] Unspecified = 0,
        /// <summary>
        /// The pending backup is still being created. Operations on the
        /// backup will be rejected in this state.
        /// </summary>
        [pbr::OriginalName("CREATING")] Creating = 1,
        /// <summary>
        /// The backup is complete and ready to use.
        /// </summary>
        [pbr::OriginalName("READY")] Ready = 2,
        /// <summary>
        /// The backup is not available at this moment.
        /// </summary>
        [pbr::OriginalName("NOT_AVAILABLE")] NotAvailable = 3,
      }

      /// <summary>
      /// Backup specific statistics.
      /// </summary>
      [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
      public sealed partial class Stats : pb::IMessage<Stats>
      #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
          , pb::IBufferMessage
      #endif
      {
        private static readonly pb::MessageParser<Stats> _parser = new pb::MessageParser<Stats>(() => new Stats());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pb::MessageParser<Stats> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public static pbr::MessageDescriptor Descriptor {
          get { return global::Google.Cloud.Firestore.Admin.V1.Backup.Descriptor.NestedTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        pbr::MessageDescriptor pb::IMessage.Descriptor {
          get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Stats() {
          OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Stats(Stats other) : this() {
          sizeBytes_ = other.sizeBytes_;
          documentCount_ = other.documentCount_;
          indexCount_ = other.indexCount_;
          _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public Stats Clone() {
          return new Stats(this);
        }

        /// <summary>Field number for the "size_bytes" field.</summary>
        public const int SizeBytesFieldNumber = 1;
        private long sizeBytes_;
        /// <summary>
        /// Output only. Summation of the size of all documents and index entries in
        /// the backup, measured in bytes.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public long SizeBytes {
          get { return sizeBytes_; }
          set {
            sizeBytes_ = value;
          }
        }

        /// <summary>Field number for the "document_count" field.</summary>
        public const int DocumentCountFieldNumber = 2;
        private long documentCount_;
        /// <summary>
        /// Output only. The total number of documents contained in the backup.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public long DocumentCount {
          get { return documentCount_; }
          set {
            documentCount_ = value;
          }
        }

        /// <summary>Field number for the "index_count" field.</summary>
        public const int IndexCountFieldNumber = 3;
        private long indexCount_;
        /// <summary>
        /// Output only. The total number of index entries contained in the backup.
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public long IndexCount {
          get { return indexCount_; }
          set {
            indexCount_ = value;
          }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override bool Equals(object other) {
          return Equals(other as Stats);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public bool Equals(Stats other) {
          if (ReferenceEquals(other, null)) {
            return false;
          }
          if (ReferenceEquals(other, this)) {
            return true;
          }
          if (SizeBytes != other.SizeBytes) return false;
          if (DocumentCount != other.DocumentCount) return false;
          if (IndexCount != other.IndexCount) return false;
          return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public override int GetHashCode() {
          int hash = 1;
          if (SizeBytes != 0L) hash ^= SizeBytes.GetHashCode();
          if (DocumentCount != 0L) hash ^= DocumentCount.GetHashCode();
          if (IndexCount != 0L) hash ^= IndexCount.GetHashCode();
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
          if (SizeBytes != 0L) {
            output.WriteRawTag(8);
            output.WriteInt64(SizeBytes);
          }
          if (DocumentCount != 0L) {
            output.WriteRawTag(16);
            output.WriteInt64(DocumentCount);
          }
          if (IndexCount != 0L) {
            output.WriteRawTag(24);
            output.WriteInt64(IndexCount);
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
          if (SizeBytes != 0L) {
            output.WriteRawTag(8);
            output.WriteInt64(SizeBytes);
          }
          if (DocumentCount != 0L) {
            output.WriteRawTag(16);
            output.WriteInt64(DocumentCount);
          }
          if (IndexCount != 0L) {
            output.WriteRawTag(24);
            output.WriteInt64(IndexCount);
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
          if (SizeBytes != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(SizeBytes);
          }
          if (DocumentCount != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(DocumentCount);
          }
          if (IndexCount != 0L) {
            size += 1 + pb::CodedOutputStream.ComputeInt64Size(IndexCount);
          }
          if (_unknownFields != null) {
            size += _unknownFields.CalculateSize();
          }
          return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
        public void MergeFrom(Stats other) {
          if (other == null) {
            return;
          }
          if (other.SizeBytes != 0L) {
            SizeBytes = other.SizeBytes;
          }
          if (other.DocumentCount != 0L) {
            DocumentCount = other.DocumentCount;
          }
          if (other.IndexCount != 0L) {
            IndexCount = other.IndexCount;
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
                SizeBytes = input.ReadInt64();
                break;
              }
              case 16: {
                DocumentCount = input.ReadInt64();
                break;
              }
              case 24: {
                IndexCount = input.ReadInt64();
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
                SizeBytes = input.ReadInt64();
                break;
              }
              case 16: {
                DocumentCount = input.ReadInt64();
                break;
              }
              case 24: {
                IndexCount = input.ReadInt64();
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
