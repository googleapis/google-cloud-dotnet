// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: google/maps/fleetengine/delivery/v1/task_tracking_info.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Google.Maps.FleetEngine.Delivery.V1 {

  /// <summary>Holder for reflection information generated from google/maps/fleetengine/delivery/v1/task_tracking_info.proto</summary>
  public static partial class TaskTrackingInfoReflection {

    #region Descriptor
    /// <summary>File descriptor for google/maps/fleetengine/delivery/v1/task_tracking_info.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static TaskTrackingInfoReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "Cjxnb29nbGUvbWFwcy9mbGVldGVuZ2luZS9kZWxpdmVyeS92MS90YXNrX3Ry",
            "YWNraW5nX2luZm8ucHJvdG8SHG1hcHMuZmxlZXRlbmdpbmUuZGVsaXZlcnku",
            "djEaH2dvb2dsZS9hcGkvZmllbGRfYmVoYXZpb3IucHJvdG8aGWdvb2dsZS9h",
            "cGkvcmVzb3VyY2UucHJvdG8aMGdvb2dsZS9tYXBzL2ZsZWV0ZW5naW5lL2Rl",
            "bGl2ZXJ5L3YxL2NvbW1vbi5wcm90bxo7Z29vZ2xlL21hcHMvZmxlZXRlbmdp",
            "bmUvZGVsaXZlcnkvdjEvZGVsaXZlcnlfdmVoaWNsZXMucHJvdG8aL2dvb2ds",
            "ZS9tYXBzL2ZsZWV0ZW5naW5lL2RlbGl2ZXJ5L3YxL3Rhc2tzLnByb3RvGh9n",
            "b29nbGUvcHJvdG9idWYvdGltZXN0YW1wLnByb3RvGh5nb29nbGUvcHJvdG9i",
            "dWYvd3JhcHBlcnMucHJvdG8aGGdvb2dsZS90eXBlL2xhdGxuZy5wcm90byKu",
            "BwoQVGFza1RyYWNraW5nSW5mbxIMCgRuYW1lGAEgASgJEhgKC3RyYWNraW5n",
            "X2lkGAIgASgJQgPgQQUSTwoQdmVoaWNsZV9sb2NhdGlvbhgDIAEoCzI1Lm1h",
            "cHMuZmxlZXRlbmdpbmUuZGVsaXZlcnkudjEuRGVsaXZlcnlWZWhpY2xlTG9j",
            "YXRpb24SMgoVcm91dGVfcG9seWxpbmVfcG9pbnRzGAQgAygLMhMuZ29vZ2xl",
            "LnR5cGUuTGF0TG5nEjkKFHJlbWFpbmluZ19zdG9wX2NvdW50GAUgASgLMhsu",
            "Z29vZ2xlLnByb3RvYnVmLkludDMyVmFsdWUSRgohcmVtYWluaW5nX2RyaXZp",
            "bmdfZGlzdGFuY2VfbWV0ZXJzGAYgASgLMhsuZ29vZ2xlLnByb3RvYnVmLklu",
            "dDMyVmFsdWUSOgoWZXN0aW1hdGVkX2Fycml2YWxfdGltZRgHIAEoCzIaLmdv",
            "b2dsZS5wcm90b2J1Zi5UaW1lc3RhbXASQgoeZXN0aW1hdGVkX3Rhc2tfY29t",
            "cGxldGlvbl90aW1lGAggASgLMhouZ29vZ2xlLnByb3RvYnVmLlRpbWVzdGFt",
            "cBI3CgVzdGF0ZRgLIAEoDjIoLm1hcHMuZmxlZXRlbmdpbmUuZGVsaXZlcnku",
            "djEuVGFzay5TdGF0ZRJECgx0YXNrX291dGNvbWUYCSABKA4yLi5tYXBzLmZs",
            "ZWV0ZW5naW5lLmRlbGl2ZXJ5LnYxLlRhc2suVGFza091dGNvbWUSNQoRdGFz",
            "a19vdXRjb21lX3RpbWUYDCABKAsyGi5nb29nbGUucHJvdG9idWYuVGltZXN0",
            "YW1wEkkKEHBsYW5uZWRfbG9jYXRpb24YCiABKAsyKi5tYXBzLmZsZWV0ZW5n",
            "aW5lLmRlbGl2ZXJ5LnYxLkxvY2F0aW9uSW5mb0ID4EEFEkQKEnRhcmdldF90",
            "aW1lX3dpbmRvdxgNIAEoCzIoLm1hcHMuZmxlZXRlbmdpbmUuZGVsaXZlcnku",
            "djEuVGltZVdpbmRvdxI/CgphdHRyaWJ1dGVzGA4gAygLMisubWFwcy5mbGVl",
            "dGVuZ2luZS5kZWxpdmVyeS52MS5UYXNrQXR0cmlidXRlOmLqQV8KK2ZsZWV0",
            "ZW5naW5lLmdvb2dsZWFwaXMuY29tL1Rhc2tUcmFja2luZ0luZm8SMHByb3Zp",
            "ZGVycy97cHJvdmlkZXJ9L3Rhc2tUcmFja2luZ0luZm8ve3RyYWNraW5nfUK2",
            "AQojZ29vZ2xlLm1hcHMuZmxlZXRlbmdpbmUuZGVsaXZlcnkudjFCFVRhc2tU",
            "cmFja2luZ0luZm9Qcm90b1ABWkljbG91ZC5nb29nbGUuY29tL2dvL21hcHMv",
            "ZmxlZXRlbmdpbmUvZGVsaXZlcnkvYXBpdjEvZGVsaXZlcnlwYjtkZWxpdmVy",
            "eXBiogIEQ0ZFRKoCI0dvb2dsZS5NYXBzLkZsZWV0RW5naW5lLkRlbGl2ZXJ5",
            "LlYxYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Api.FieldBehaviorReflection.Descriptor, global::Google.Api.ResourceReflection.Descriptor, global::Google.Maps.FleetEngine.Delivery.V1.CommonReflection.Descriptor, global::Google.Maps.FleetEngine.Delivery.V1.DeliveryVehiclesReflection.Descriptor, global::Google.Maps.FleetEngine.Delivery.V1.TasksReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.TimestampReflection.Descriptor, global::Google.Protobuf.WellKnownTypes.WrappersReflection.Descriptor, global::Google.Type.LatlngReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Google.Maps.FleetEngine.Delivery.V1.TaskTrackingInfo), global::Google.Maps.FleetEngine.Delivery.V1.TaskTrackingInfo.Parser, new[]{ "Name", "TrackingId", "VehicleLocation", "RoutePolylinePoints", "RemainingStopCount", "RemainingDrivingDistanceMeters", "EstimatedArrivalTime", "EstimatedTaskCompletionTime", "State", "TaskOutcome", "TaskOutcomeTime", "PlannedLocation", "TargetTimeWindow", "Attributes" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// The `TaskTrackingInfo` message. The message contains task tracking
  /// information which will be used for display. If a tracking ID is associated
  /// with multiple Tasks, Fleet Engine uses a heuristic to decide which Task's
  /// TaskTrackingInfo to select.
  /// </summary>
  public sealed partial class TaskTrackingInfo : pb::IMessage<TaskTrackingInfo>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<TaskTrackingInfo> _parser = new pb::MessageParser<TaskTrackingInfo>(() => new TaskTrackingInfo());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<TaskTrackingInfo> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Google.Maps.FleetEngine.Delivery.V1.TaskTrackingInfoReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TaskTrackingInfo() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TaskTrackingInfo(TaskTrackingInfo other) : this() {
      name_ = other.name_;
      trackingId_ = other.trackingId_;
      vehicleLocation_ = other.vehicleLocation_ != null ? other.vehicleLocation_.Clone() : null;
      routePolylinePoints_ = other.routePolylinePoints_.Clone();
      RemainingStopCount = other.RemainingStopCount;
      RemainingDrivingDistanceMeters = other.RemainingDrivingDistanceMeters;
      estimatedArrivalTime_ = other.estimatedArrivalTime_ != null ? other.estimatedArrivalTime_.Clone() : null;
      estimatedTaskCompletionTime_ = other.estimatedTaskCompletionTime_ != null ? other.estimatedTaskCompletionTime_.Clone() : null;
      state_ = other.state_;
      taskOutcome_ = other.taskOutcome_;
      taskOutcomeTime_ = other.taskOutcomeTime_ != null ? other.taskOutcomeTime_.Clone() : null;
      plannedLocation_ = other.plannedLocation_ != null ? other.plannedLocation_.Clone() : null;
      targetTimeWindow_ = other.targetTimeWindow_ != null ? other.targetTimeWindow_.Clone() : null;
      attributes_ = other.attributes_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public TaskTrackingInfo Clone() {
      return new TaskTrackingInfo(this);
    }

    /// <summary>Field number for the "name" field.</summary>
    public const int NameFieldNumber = 1;
    private string name_ = "";
    /// <summary>
    /// Must be in the format `providers/{provider}/taskTrackingInfo/{tracking}`,
    /// where `tracking` represents the tracking ID.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Name {
      get { return name_; }
      set {
        name_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "tracking_id" field.</summary>
    public const int TrackingIdFieldNumber = 2;
    private string trackingId_ = "";
    /// <summary>
    /// Immutable. The tracking ID of a Task.
    /// * Must be a valid Unicode string.
    /// * Limited to a maximum length of 64 characters.
    /// * Normalized according to [Unicode Normalization Form C]
    /// (http://www.unicode.org/reports/tr15/).
    /// * May not contain any of the following ASCII characters: '/', ':', '?',
    /// ',', or '#'.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TrackingId {
      get { return trackingId_; }
      set {
        trackingId_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "vehicle_location" field.</summary>
    public const int VehicleLocationFieldNumber = 3;
    private global::Google.Maps.FleetEngine.Delivery.V1.DeliveryVehicleLocation vehicleLocation_;
    /// <summary>
    /// The vehicle's last location.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Maps.FleetEngine.Delivery.V1.DeliveryVehicleLocation VehicleLocation {
      get { return vehicleLocation_; }
      set {
        vehicleLocation_ = value;
      }
    }

    /// <summary>Field number for the "route_polyline_points" field.</summary>
    public const int RoutePolylinePointsFieldNumber = 4;
    private static readonly pb::FieldCodec<global::Google.Type.LatLng> _repeated_routePolylinePoints_codec
        = pb::FieldCodec.ForMessage(34, global::Google.Type.LatLng.Parser);
    private readonly pbc::RepeatedField<global::Google.Type.LatLng> routePolylinePoints_ = new pbc::RepeatedField<global::Google.Type.LatLng>();
    /// <summary>
    /// A list of points which when connected forms a polyline of the vehicle's
    /// expected route to the location of this task.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Type.LatLng> RoutePolylinePoints {
      get { return routePolylinePoints_; }
    }

    /// <summary>Field number for the "remaining_stop_count" field.</summary>
    public const int RemainingStopCountFieldNumber = 5;
    private static readonly pb::FieldCodec<int?> _single_remainingStopCount_codec = pb::FieldCodec.ForStructWrapper<int>(42);
    private int? remainingStopCount_;
    /// <summary>
    /// Indicates the number of stops the vehicle remaining until the task stop is
    /// reached, including the task stop. For example, if the vehicle's next stop
    /// is the task stop, the value will be 1.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int? RemainingStopCount {
      get { return remainingStopCount_; }
      set {
        remainingStopCount_ = value;
      }
    }


    /// <summary>Field number for the "remaining_driving_distance_meters" field.</summary>
    public const int RemainingDrivingDistanceMetersFieldNumber = 6;
    private static readonly pb::FieldCodec<int?> _single_remainingDrivingDistanceMeters_codec = pb::FieldCodec.ForStructWrapper<int>(50);
    private int? remainingDrivingDistanceMeters_;
    /// <summary>
    /// The total remaining distance in meters to the `VehicleStop` of interest.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int? RemainingDrivingDistanceMeters {
      get { return remainingDrivingDistanceMeters_; }
      set {
        remainingDrivingDistanceMeters_ = value;
      }
    }


    /// <summary>Field number for the "estimated_arrival_time" field.</summary>
    public const int EstimatedArrivalTimeFieldNumber = 7;
    private global::Google.Protobuf.WellKnownTypes.Timestamp estimatedArrivalTime_;
    /// <summary>
    /// The timestamp that indicates the estimated arrival time to the stop
    /// location.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EstimatedArrivalTime {
      get { return estimatedArrivalTime_; }
      set {
        estimatedArrivalTime_ = value;
      }
    }

    /// <summary>Field number for the "estimated_task_completion_time" field.</summary>
    public const int EstimatedTaskCompletionTimeFieldNumber = 8;
    private global::Google.Protobuf.WellKnownTypes.Timestamp estimatedTaskCompletionTime_;
    /// <summary>
    /// The timestamp that indicates the estimated completion time of a Task.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp EstimatedTaskCompletionTime {
      get { return estimatedTaskCompletionTime_; }
      set {
        estimatedTaskCompletionTime_ = value;
      }
    }

    /// <summary>Field number for the "state" field.</summary>
    public const int StateFieldNumber = 11;
    private global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.State state_ = global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.State.Unspecified;
    /// <summary>
    /// The current execution state of the Task.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.State State {
      get { return state_; }
      set {
        state_ = value;
      }
    }

    /// <summary>Field number for the "task_outcome" field.</summary>
    public const int TaskOutcomeFieldNumber = 9;
    private global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.TaskOutcome taskOutcome_ = global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.TaskOutcome.Unspecified;
    /// <summary>
    /// The outcome of attempting to execute a Task.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.TaskOutcome TaskOutcome {
      get { return taskOutcome_; }
      set {
        taskOutcome_ = value;
      }
    }

    /// <summary>Field number for the "task_outcome_time" field.</summary>
    public const int TaskOutcomeTimeFieldNumber = 12;
    private global::Google.Protobuf.WellKnownTypes.Timestamp taskOutcomeTime_;
    /// <summary>
    /// The timestamp that indicates when the Task's outcome was set by the
    /// provider.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Protobuf.WellKnownTypes.Timestamp TaskOutcomeTime {
      get { return taskOutcomeTime_; }
      set {
        taskOutcomeTime_ = value;
      }
    }

    /// <summary>Field number for the "planned_location" field.</summary>
    public const int PlannedLocationFieldNumber = 10;
    private global::Google.Maps.FleetEngine.Delivery.V1.LocationInfo plannedLocation_;
    /// <summary>
    /// Immutable. The location where the Task will be completed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Maps.FleetEngine.Delivery.V1.LocationInfo PlannedLocation {
      get { return plannedLocation_; }
      set {
        plannedLocation_ = value;
      }
    }

    /// <summary>Field number for the "target_time_window" field.</summary>
    public const int TargetTimeWindowFieldNumber = 13;
    private global::Google.Maps.FleetEngine.Delivery.V1.TimeWindow targetTimeWindow_;
    /// <summary>
    /// The time window during which the task should be completed.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Google.Maps.FleetEngine.Delivery.V1.TimeWindow TargetTimeWindow {
      get { return targetTimeWindow_; }
      set {
        targetTimeWindow_ = value;
      }
    }

    /// <summary>Field number for the "attributes" field.</summary>
    public const int AttributesFieldNumber = 14;
    private static readonly pb::FieldCodec<global::Google.Maps.FleetEngine.Delivery.V1.TaskAttribute> _repeated_attributes_codec
        = pb::FieldCodec.ForMessage(114, global::Google.Maps.FleetEngine.Delivery.V1.TaskAttribute.Parser);
    private readonly pbc::RepeatedField<global::Google.Maps.FleetEngine.Delivery.V1.TaskAttribute> attributes_ = new pbc::RepeatedField<global::Google.Maps.FleetEngine.Delivery.V1.TaskAttribute>();
    /// <summary>
    /// The custom attributes set on the task.
    /// </summary>
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public pbc::RepeatedField<global::Google.Maps.FleetEngine.Delivery.V1.TaskAttribute> Attributes {
      get { return attributes_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as TaskTrackingInfo);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(TaskTrackingInfo other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Name != other.Name) return false;
      if (TrackingId != other.TrackingId) return false;
      if (!object.Equals(VehicleLocation, other.VehicleLocation)) return false;
      if(!routePolylinePoints_.Equals(other.routePolylinePoints_)) return false;
      if (RemainingStopCount != other.RemainingStopCount) return false;
      if (RemainingDrivingDistanceMeters != other.RemainingDrivingDistanceMeters) return false;
      if (!object.Equals(EstimatedArrivalTime, other.EstimatedArrivalTime)) return false;
      if (!object.Equals(EstimatedTaskCompletionTime, other.EstimatedTaskCompletionTime)) return false;
      if (State != other.State) return false;
      if (TaskOutcome != other.TaskOutcome) return false;
      if (!object.Equals(TaskOutcomeTime, other.TaskOutcomeTime)) return false;
      if (!object.Equals(PlannedLocation, other.PlannedLocation)) return false;
      if (!object.Equals(TargetTimeWindow, other.TargetTimeWindow)) return false;
      if(!attributes_.Equals(other.attributes_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Name.Length != 0) hash ^= Name.GetHashCode();
      if (TrackingId.Length != 0) hash ^= TrackingId.GetHashCode();
      if (vehicleLocation_ != null) hash ^= VehicleLocation.GetHashCode();
      hash ^= routePolylinePoints_.GetHashCode();
      if (remainingStopCount_ != null) hash ^= RemainingStopCount.GetHashCode();
      if (remainingDrivingDistanceMeters_ != null) hash ^= RemainingDrivingDistanceMeters.GetHashCode();
      if (estimatedArrivalTime_ != null) hash ^= EstimatedArrivalTime.GetHashCode();
      if (estimatedTaskCompletionTime_ != null) hash ^= EstimatedTaskCompletionTime.GetHashCode();
      if (State != global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.State.Unspecified) hash ^= State.GetHashCode();
      if (TaskOutcome != global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.TaskOutcome.Unspecified) hash ^= TaskOutcome.GetHashCode();
      if (taskOutcomeTime_ != null) hash ^= TaskOutcomeTime.GetHashCode();
      if (plannedLocation_ != null) hash ^= PlannedLocation.GetHashCode();
      if (targetTimeWindow_ != null) hash ^= TargetTimeWindow.GetHashCode();
      hash ^= attributes_.GetHashCode();
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
      if (TrackingId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TrackingId);
      }
      if (vehicleLocation_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(VehicleLocation);
      }
      routePolylinePoints_.WriteTo(output, _repeated_routePolylinePoints_codec);
      if (remainingStopCount_ != null) {
        _single_remainingStopCount_codec.WriteTagAndValue(output, RemainingStopCount);
      }
      if (remainingDrivingDistanceMeters_ != null) {
        _single_remainingDrivingDistanceMeters_codec.WriteTagAndValue(output, RemainingDrivingDistanceMeters);
      }
      if (estimatedArrivalTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(EstimatedArrivalTime);
      }
      if (estimatedTaskCompletionTime_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(EstimatedTaskCompletionTime);
      }
      if (TaskOutcome != global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.TaskOutcome.Unspecified) {
        output.WriteRawTag(72);
        output.WriteEnum((int) TaskOutcome);
      }
      if (plannedLocation_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(PlannedLocation);
      }
      if (State != global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.State.Unspecified) {
        output.WriteRawTag(88);
        output.WriteEnum((int) State);
      }
      if (taskOutcomeTime_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(TaskOutcomeTime);
      }
      if (targetTimeWindow_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(TargetTimeWindow);
      }
      attributes_.WriteTo(output, _repeated_attributes_codec);
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
      if (TrackingId.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(TrackingId);
      }
      if (vehicleLocation_ != null) {
        output.WriteRawTag(26);
        output.WriteMessage(VehicleLocation);
      }
      routePolylinePoints_.WriteTo(ref output, _repeated_routePolylinePoints_codec);
      if (remainingStopCount_ != null) {
        _single_remainingStopCount_codec.WriteTagAndValue(ref output, RemainingStopCount);
      }
      if (remainingDrivingDistanceMeters_ != null) {
        _single_remainingDrivingDistanceMeters_codec.WriteTagAndValue(ref output, RemainingDrivingDistanceMeters);
      }
      if (estimatedArrivalTime_ != null) {
        output.WriteRawTag(58);
        output.WriteMessage(EstimatedArrivalTime);
      }
      if (estimatedTaskCompletionTime_ != null) {
        output.WriteRawTag(66);
        output.WriteMessage(EstimatedTaskCompletionTime);
      }
      if (TaskOutcome != global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.TaskOutcome.Unspecified) {
        output.WriteRawTag(72);
        output.WriteEnum((int) TaskOutcome);
      }
      if (plannedLocation_ != null) {
        output.WriteRawTag(82);
        output.WriteMessage(PlannedLocation);
      }
      if (State != global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.State.Unspecified) {
        output.WriteRawTag(88);
        output.WriteEnum((int) State);
      }
      if (taskOutcomeTime_ != null) {
        output.WriteRawTag(98);
        output.WriteMessage(TaskOutcomeTime);
      }
      if (targetTimeWindow_ != null) {
        output.WriteRawTag(106);
        output.WriteMessage(TargetTimeWindow);
      }
      attributes_.WriteTo(ref output, _repeated_attributes_codec);
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
      if (TrackingId.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(TrackingId);
      }
      if (vehicleLocation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(VehicleLocation);
      }
      size += routePolylinePoints_.CalculateSize(_repeated_routePolylinePoints_codec);
      if (remainingStopCount_ != null) {
        size += _single_remainingStopCount_codec.CalculateSizeWithTag(RemainingStopCount);
      }
      if (remainingDrivingDistanceMeters_ != null) {
        size += _single_remainingDrivingDistanceMeters_codec.CalculateSizeWithTag(RemainingDrivingDistanceMeters);
      }
      if (estimatedArrivalTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EstimatedArrivalTime);
      }
      if (estimatedTaskCompletionTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(EstimatedTaskCompletionTime);
      }
      if (State != global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.State.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) State);
      }
      if (TaskOutcome != global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.TaskOutcome.Unspecified) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) TaskOutcome);
      }
      if (taskOutcomeTime_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TaskOutcomeTime);
      }
      if (plannedLocation_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(PlannedLocation);
      }
      if (targetTimeWindow_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(TargetTimeWindow);
      }
      size += attributes_.CalculateSize(_repeated_attributes_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(TaskTrackingInfo other) {
      if (other == null) {
        return;
      }
      if (other.Name.Length != 0) {
        Name = other.Name;
      }
      if (other.TrackingId.Length != 0) {
        TrackingId = other.TrackingId;
      }
      if (other.vehicleLocation_ != null) {
        if (vehicleLocation_ == null) {
          VehicleLocation = new global::Google.Maps.FleetEngine.Delivery.V1.DeliveryVehicleLocation();
        }
        VehicleLocation.MergeFrom(other.VehicleLocation);
      }
      routePolylinePoints_.Add(other.routePolylinePoints_);
      if (other.remainingStopCount_ != null) {
        if (remainingStopCount_ == null || other.RemainingStopCount != 0) {
          RemainingStopCount = other.RemainingStopCount;
        }
      }
      if (other.remainingDrivingDistanceMeters_ != null) {
        if (remainingDrivingDistanceMeters_ == null || other.RemainingDrivingDistanceMeters != 0) {
          RemainingDrivingDistanceMeters = other.RemainingDrivingDistanceMeters;
        }
      }
      if (other.estimatedArrivalTime_ != null) {
        if (estimatedArrivalTime_ == null) {
          EstimatedArrivalTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        EstimatedArrivalTime.MergeFrom(other.EstimatedArrivalTime);
      }
      if (other.estimatedTaskCompletionTime_ != null) {
        if (estimatedTaskCompletionTime_ == null) {
          EstimatedTaskCompletionTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        EstimatedTaskCompletionTime.MergeFrom(other.EstimatedTaskCompletionTime);
      }
      if (other.State != global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.State.Unspecified) {
        State = other.State;
      }
      if (other.TaskOutcome != global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.TaskOutcome.Unspecified) {
        TaskOutcome = other.TaskOutcome;
      }
      if (other.taskOutcomeTime_ != null) {
        if (taskOutcomeTime_ == null) {
          TaskOutcomeTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
        }
        TaskOutcomeTime.MergeFrom(other.TaskOutcomeTime);
      }
      if (other.plannedLocation_ != null) {
        if (plannedLocation_ == null) {
          PlannedLocation = new global::Google.Maps.FleetEngine.Delivery.V1.LocationInfo();
        }
        PlannedLocation.MergeFrom(other.PlannedLocation);
      }
      if (other.targetTimeWindow_ != null) {
        if (targetTimeWindow_ == null) {
          TargetTimeWindow = new global::Google.Maps.FleetEngine.Delivery.V1.TimeWindow();
        }
        TargetTimeWindow.MergeFrom(other.TargetTimeWindow);
      }
      attributes_.Add(other.attributes_);
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
            TrackingId = input.ReadString();
            break;
          }
          case 26: {
            if (vehicleLocation_ == null) {
              VehicleLocation = new global::Google.Maps.FleetEngine.Delivery.V1.DeliveryVehicleLocation();
            }
            input.ReadMessage(VehicleLocation);
            break;
          }
          case 34: {
            routePolylinePoints_.AddEntriesFrom(input, _repeated_routePolylinePoints_codec);
            break;
          }
          case 42: {
            int? value = _single_remainingStopCount_codec.Read(input);
            if (remainingStopCount_ == null || value != 0) {
              RemainingStopCount = value;
            }
            break;
          }
          case 50: {
            int? value = _single_remainingDrivingDistanceMeters_codec.Read(input);
            if (remainingDrivingDistanceMeters_ == null || value != 0) {
              RemainingDrivingDistanceMeters = value;
            }
            break;
          }
          case 58: {
            if (estimatedArrivalTime_ == null) {
              EstimatedArrivalTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EstimatedArrivalTime);
            break;
          }
          case 66: {
            if (estimatedTaskCompletionTime_ == null) {
              EstimatedTaskCompletionTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EstimatedTaskCompletionTime);
            break;
          }
          case 72: {
            TaskOutcome = (global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.TaskOutcome) input.ReadEnum();
            break;
          }
          case 82: {
            if (plannedLocation_ == null) {
              PlannedLocation = new global::Google.Maps.FleetEngine.Delivery.V1.LocationInfo();
            }
            input.ReadMessage(PlannedLocation);
            break;
          }
          case 88: {
            State = (global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.State) input.ReadEnum();
            break;
          }
          case 98: {
            if (taskOutcomeTime_ == null) {
              TaskOutcomeTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(TaskOutcomeTime);
            break;
          }
          case 106: {
            if (targetTimeWindow_ == null) {
              TargetTimeWindow = new global::Google.Maps.FleetEngine.Delivery.V1.TimeWindow();
            }
            input.ReadMessage(TargetTimeWindow);
            break;
          }
          case 114: {
            attributes_.AddEntriesFrom(input, _repeated_attributes_codec);
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
            TrackingId = input.ReadString();
            break;
          }
          case 26: {
            if (vehicleLocation_ == null) {
              VehicleLocation = new global::Google.Maps.FleetEngine.Delivery.V1.DeliveryVehicleLocation();
            }
            input.ReadMessage(VehicleLocation);
            break;
          }
          case 34: {
            routePolylinePoints_.AddEntriesFrom(ref input, _repeated_routePolylinePoints_codec);
            break;
          }
          case 42: {
            int? value = _single_remainingStopCount_codec.Read(ref input);
            if (remainingStopCount_ == null || value != 0) {
              RemainingStopCount = value;
            }
            break;
          }
          case 50: {
            int? value = _single_remainingDrivingDistanceMeters_codec.Read(ref input);
            if (remainingDrivingDistanceMeters_ == null || value != 0) {
              RemainingDrivingDistanceMeters = value;
            }
            break;
          }
          case 58: {
            if (estimatedArrivalTime_ == null) {
              EstimatedArrivalTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EstimatedArrivalTime);
            break;
          }
          case 66: {
            if (estimatedTaskCompletionTime_ == null) {
              EstimatedTaskCompletionTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(EstimatedTaskCompletionTime);
            break;
          }
          case 72: {
            TaskOutcome = (global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.TaskOutcome) input.ReadEnum();
            break;
          }
          case 82: {
            if (plannedLocation_ == null) {
              PlannedLocation = new global::Google.Maps.FleetEngine.Delivery.V1.LocationInfo();
            }
            input.ReadMessage(PlannedLocation);
            break;
          }
          case 88: {
            State = (global::Google.Maps.FleetEngine.Delivery.V1.Task.Types.State) input.ReadEnum();
            break;
          }
          case 98: {
            if (taskOutcomeTime_ == null) {
              TaskOutcomeTime = new global::Google.Protobuf.WellKnownTypes.Timestamp();
            }
            input.ReadMessage(TaskOutcomeTime);
            break;
          }
          case 106: {
            if (targetTimeWindow_ == null) {
              TargetTimeWindow = new global::Google.Maps.FleetEngine.Delivery.V1.TimeWindow();
            }
            input.ReadMessage(TargetTimeWindow);
            break;
          }
          case 114: {
            attributes_.AddEntriesFrom(ref input, _repeated_attributes_codec);
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