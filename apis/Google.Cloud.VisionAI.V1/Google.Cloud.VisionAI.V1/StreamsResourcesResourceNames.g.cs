// Copyright 2024 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gcvv = Google.Cloud.VisionAI.V1;
using sys = System;

namespace Google.Cloud.VisionAI.V1
{
    /// <summary>Resource name for the <c>Stream</c> resource.</summary>
    public sealed partial class StreamName : gax::IResourceName, sys::IEquatable<StreamName>
    {
        /// <summary>The possible contents of <see cref="StreamName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/clusters/{cluster}/streams/{stream}</c>.
            /// </summary>
            ProjectLocationClusterStream = 1,
        }

        private static gax::PathTemplate s_projectLocationClusterStream = new gax::PathTemplate("projects/{project}/locations/{location}/clusters/{cluster}/streams/{stream}");

        /// <summary>Creates a <see cref="StreamName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="StreamName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static StreamName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new StreamName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="StreamName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/streams/{stream}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="StreamName"/> constructed from the provided ids.</returns>
        public static StreamName FromProjectLocationClusterStream(string projectId, string locationId, string clusterId, string streamId) =>
            new StreamName(ResourceNameType.ProjectLocationClusterStream, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), streamId: gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StreamName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/streams/{stream}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StreamName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/streams/{stream}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string clusterId, string streamId) =>
            FormatProjectLocationClusterStream(projectId, locationId, clusterId, streamId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="StreamName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/streams/{stream}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="StreamName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/streams/{stream}</c>.
        /// </returns>
        public static string FormatProjectLocationClusterStream(string projectId, string locationId, string clusterId, string streamId) =>
            s_projectLocationClusterStream.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)));

        /// <summary>Parses the given resource name string into a new <see cref="StreamName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/streams/{stream}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="streamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="StreamName"/> if successful.</returns>
        public static StreamName Parse(string streamName) => Parse(streamName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="StreamName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/streams/{stream}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="streamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="StreamName"/> if successful.</returns>
        public static StreamName Parse(string streamName, bool allowUnparsed) =>
            TryParse(streamName, allowUnparsed, out StreamName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StreamName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/streams/{stream}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="streamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string streamName, out StreamName result) => TryParse(streamName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="StreamName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/streams/{stream}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="streamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="StreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string streamName, bool allowUnparsed, out StreamName result)
        {
            gax::GaxPreconditions.CheckNotNull(streamName, nameof(streamName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationClusterStream.TryParseName(streamName, out resourceName))
            {
                result = FromProjectLocationClusterStream(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(streamName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private StreamName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clusterId = null, string locationId = null, string projectId = null, string streamId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClusterId = clusterId;
            LocationId = locationId;
            ProjectId = projectId;
            StreamId = streamId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="StreamName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/streams/{stream}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        public StreamName(string projectId, string locationId, string clusterId, string streamId) : this(ResourceNameType.ProjectLocationClusterStream, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), streamId: gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Cluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ClusterId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Stream</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string StreamId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationClusterStream: return s_projectLocationClusterStream.Expand(ProjectId, LocationId, ClusterId, StreamId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as StreamName);

        /// <inheritdoc/>
        public bool Equals(StreamName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(StreamName a, StreamName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(StreamName a, StreamName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Event</c> resource.</summary>
    public sealed partial class EventName : gax::IResourceName, sys::IEquatable<EventName>
    {
        /// <summary>The possible contents of <see cref="EventName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/clusters/{cluster}/events/{event}</c>.
            /// </summary>
            ProjectLocationClusterEvent = 1,
        }

        private static gax::PathTemplate s_projectLocationClusterEvent = new gax::PathTemplate("projects/{project}/locations/{location}/clusters/{cluster}/events/{event}");

        /// <summary>Creates a <see cref="EventName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EventName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EventName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EventName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EventName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/events/{event}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventId">The <c>Event</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EventName"/> constructed from the provided ids.</returns>
        public static EventName FromProjectLocationClusterEvent(string projectId, string locationId, string clusterId, string eventId) =>
            new EventName(ResourceNameType.ProjectLocationClusterEvent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), eventId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventId, nameof(eventId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EventName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/events/{event}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventId">The <c>Event</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EventName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/events/{event}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string clusterId, string eventId) =>
            FormatProjectLocationClusterEvent(projectId, locationId, clusterId, eventId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EventName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/events/{event}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventId">The <c>Event</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EventName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/events/{event}</c>.
        /// </returns>
        public static string FormatProjectLocationClusterEvent(string projectId, string locationId, string clusterId, string eventId) =>
            s_projectLocationClusterEvent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(eventId, nameof(eventId)));

        /// <summary>Parses the given resource name string into a new <see cref="EventName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/clusters/{cluster}/events/{event}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="eventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EventName"/> if successful.</returns>
        public static EventName Parse(string eventName) => Parse(eventName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EventName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/clusters/{cluster}/events/{event}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="eventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EventName"/> if successful.</returns>
        public static EventName Parse(string eventName, bool allowUnparsed) =>
            TryParse(eventName, allowUnparsed, out EventName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EventName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/clusters/{cluster}/events/{event}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="eventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EventName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string eventName, out EventName result) => TryParse(eventName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EventName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/clusters/{cluster}/events/{event}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="eventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EventName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string eventName, bool allowUnparsed, out EventName result)
        {
            gax::GaxPreconditions.CheckNotNull(eventName, nameof(eventName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationClusterEvent.TryParseName(eventName, out resourceName))
            {
                result = FromProjectLocationClusterEvent(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(eventName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EventName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clusterId = null, string eventId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClusterId = clusterId;
            EventId = eventId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EventName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/events/{event}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventId">The <c>Event</c> ID. Must not be <c>null</c> or empty.</param>
        public EventName(string projectId, string locationId, string clusterId, string eventId) : this(ResourceNameType.ProjectLocationClusterEvent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), eventId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventId, nameof(eventId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Cluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ClusterId { get; }

        /// <summary>
        /// The <c>Event</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EventId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationClusterEvent: return s_projectLocationClusterEvent.Expand(ProjectId, LocationId, ClusterId, EventId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EventName);

        /// <inheritdoc/>
        public bool Equals(EventName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EventName a, EventName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EventName a, EventName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Series</c> resource.</summary>
    public sealed partial class SeriesName : gax::IResourceName, sys::IEquatable<SeriesName>
    {
        /// <summary>The possible contents of <see cref="SeriesName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/clusters/{cluster}/series/{series}</c>.
            /// </summary>
            ProjectLocationClusterSeries = 1,
        }

        private static gax::PathTemplate s_projectLocationClusterSeries = new gax::PathTemplate("projects/{project}/locations/{location}/clusters/{cluster}/series/{series}");

        /// <summary>Creates a <see cref="SeriesName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SeriesName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SeriesName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SeriesName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SeriesName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/series/{series}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="seriesId">The <c>Series</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SeriesName"/> constructed from the provided ids.</returns>
        public static SeriesName FromProjectLocationClusterSeries(string projectId, string locationId, string clusterId, string seriesId) =>
            new SeriesName(ResourceNameType.ProjectLocationClusterSeries, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), seriesId: gax::GaxPreconditions.CheckNotNullOrEmpty(seriesId, nameof(seriesId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SeriesName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/series/{series}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="seriesId">The <c>Series</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SeriesName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/series/{series}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string clusterId, string seriesId) =>
            FormatProjectLocationClusterSeries(projectId, locationId, clusterId, seriesId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SeriesName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/series/{series}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="seriesId">The <c>Series</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SeriesName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/series/{series}</c>.
        /// </returns>
        public static string FormatProjectLocationClusterSeries(string projectId, string locationId, string clusterId, string seriesId) =>
            s_projectLocationClusterSeries.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(seriesId, nameof(seriesId)));

        /// <summary>Parses the given resource name string into a new <see cref="SeriesName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/series/{series}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="seriesName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SeriesName"/> if successful.</returns>
        public static SeriesName Parse(string seriesName) => Parse(seriesName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SeriesName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/series/{series}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="seriesName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SeriesName"/> if successful.</returns>
        public static SeriesName Parse(string seriesName, bool allowUnparsed) =>
            TryParse(seriesName, allowUnparsed, out SeriesName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SeriesName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/series/{series}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="seriesName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SeriesName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string seriesName, out SeriesName result) => TryParse(seriesName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SeriesName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/series/{series}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="seriesName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SeriesName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string seriesName, bool allowUnparsed, out SeriesName result)
        {
            gax::GaxPreconditions.CheckNotNull(seriesName, nameof(seriesName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationClusterSeries.TryParseName(seriesName, out resourceName))
            {
                result = FromProjectLocationClusterSeries(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(seriesName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SeriesName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clusterId = null, string locationId = null, string projectId = null, string seriesId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClusterId = clusterId;
            LocationId = locationId;
            ProjectId = projectId;
            SeriesId = seriesId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SeriesName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/series/{series}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="seriesId">The <c>Series</c> ID. Must not be <c>null</c> or empty.</param>
        public SeriesName(string projectId, string locationId, string clusterId, string seriesId) : this(ResourceNameType.ProjectLocationClusterSeries, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), seriesId: gax::GaxPreconditions.CheckNotNullOrEmpty(seriesId, nameof(seriesId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Cluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ClusterId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Series</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SeriesId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationClusterSeries: return s_projectLocationClusterSeries.Expand(ProjectId, LocationId, ClusterId, SeriesId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SeriesName);

        /// <inheritdoc/>
        public bool Equals(SeriesName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SeriesName a, SeriesName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SeriesName a, SeriesName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Channel</c> resource.</summary>
    public sealed partial class ChannelName : gax::IResourceName, sys::IEquatable<ChannelName>
    {
        /// <summary>The possible contents of <see cref="ChannelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/clusters/{cluster}/channels/{channel}</c>.
            /// </summary>
            ProjectLocationClusterChannel = 1,
        }

        private static gax::PathTemplate s_projectLocationClusterChannel = new gax::PathTemplate("projects/{project}/locations/{location}/clusters/{cluster}/channels/{channel}");

        /// <summary>Creates a <see cref="ChannelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ChannelName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ChannelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ChannelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ChannelName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/channels/{channel}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ChannelName"/> constructed from the provided ids.</returns>
        public static ChannelName FromProjectLocationClusterChannel(string projectId, string locationId, string clusterId, string channelId) =>
            new ChannelName(ResourceNameType.ProjectLocationClusterChannel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), channelId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChannelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/channels/{channel}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChannelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/channels/{channel}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string clusterId, string channelId) =>
            FormatProjectLocationClusterChannel(projectId, locationId, clusterId, channelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChannelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/channels/{channel}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChannelName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/channels/{channel}</c>.
        /// </returns>
        public static string FormatProjectLocationClusterChannel(string projectId, string locationId, string clusterId, string channelId) =>
            s_projectLocationClusterChannel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)));

        /// <summary>Parses the given resource name string into a new <see cref="ChannelName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/channels/{channel}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="channelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ChannelName"/> if successful.</returns>
        public static ChannelName Parse(string channelName) => Parse(channelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ChannelName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/channels/{channel}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="channelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ChannelName"/> if successful.</returns>
        public static ChannelName Parse(string channelName, bool allowUnparsed) =>
            TryParse(channelName, allowUnparsed, out ChannelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChannelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/channels/{channel}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="channelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChannelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string channelName, out ChannelName result) => TryParse(channelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChannelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/channels/{channel}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="channelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChannelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string channelName, bool allowUnparsed, out ChannelName result)
        {
            gax::GaxPreconditions.CheckNotNull(channelName, nameof(channelName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationClusterChannel.TryParseName(channelName, out resourceName))
            {
                result = FromProjectLocationClusterChannel(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(channelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ChannelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string channelId = null, string clusterId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ChannelId = channelId;
            ClusterId = clusterId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ChannelName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/clusters/{cluster}/channels/{channel}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clusterId">The <c>Cluster</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        public ChannelName(string projectId, string locationId, string clusterId, string channelId) : this(ResourceNameType.ProjectLocationClusterChannel, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clusterId: gax::GaxPreconditions.CheckNotNullOrEmpty(clusterId, nameof(clusterId)), channelId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Channel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ChannelId { get; }

        /// <summary>
        /// The <c>Cluster</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ClusterId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationClusterChannel: return s_projectLocationClusterChannel.Expand(ProjectId, LocationId, ClusterId, ChannelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ChannelName);

        /// <inheritdoc/>
        public bool Equals(ChannelName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ChannelName a, ChannelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ChannelName a, ChannelName b) => !(a == b);
    }

    public partial class Stream
    {
        /// <summary>
        /// <see cref="gcvv::StreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::StreamName StreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::StreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Event
    {
        /// <summary>
        /// <see cref="gcvv::EventName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::EventName EventName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::EventName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Series
    {
        /// <summary>
        /// <see cref="gcvv::SeriesName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::SeriesName SeriesName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::SeriesName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="StreamName"/>-typed view over the <see cref="Stream"/> resource name property.</summary>
        public StreamName StreamAsStreamName
        {
            get => string.IsNullOrEmpty(Stream) ? null : StreamName.Parse(Stream, allowUnparsed: true);
            set => Stream = value?.ToString() ?? "";
        }

        /// <summary><see cref="EventName"/>-typed view over the <see cref="Event"/> resource name property.</summary>
        public EventName EventAsEventName
        {
            get => string.IsNullOrEmpty(Event) ? null : EventName.Parse(Event, allowUnparsed: true);
            set => Event = value?.ToString() ?? "";
        }
    }

    public partial class Channel
    {
        /// <summary>
        /// <see cref="gcvv::ChannelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ChannelName ChannelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ChannelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="StreamName"/>-typed view over the <see cref="Stream"/> resource name property.</summary>
        public StreamName StreamAsStreamName
        {
            get => string.IsNullOrEmpty(Stream) ? null : StreamName.Parse(Stream, allowUnparsed: true);
            set => Stream = value?.ToString() ?? "";
        }

        /// <summary><see cref="EventName"/>-typed view over the <see cref="Event"/> resource name property.</summary>
        public EventName EventAsEventName
        {
            get => string.IsNullOrEmpty(Event) ? null : EventName.Parse(Event, allowUnparsed: true);
            set => Event = value?.ToString() ?? "";
        }
    }
}
