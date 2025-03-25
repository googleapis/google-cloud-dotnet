// Copyright 2025 Google LLC
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
using gcav = Google.Cloud.AIPlatform.V1Beta1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Resource name for the <c>Session</c> resource.</summary>
    public sealed partial class SessionName : gax::IResourceName, sys::IEquatable<SessionName>
    {
        /// <summary>The possible contents of <see cref="SessionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/sessions/{session}</c>.
            /// </summary>
            ProjectLocationSession = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}</c>.
            /// </summary>
            ProjectLocationReasoningEngineSession = 2,
        }

        private static gax::PathTemplate s_projectLocationSession = new gax::PathTemplate("projects/{project}/locations/{location}/sessions/{session}");

        private static gax::PathTemplate s_projectLocationReasoningEngineSession = new gax::PathTemplate("projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}");

        /// <summary>Creates a <see cref="SessionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SessionName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SessionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SessionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SessionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SessionName"/> constructed from the provided ids.</returns>
        public static SessionName FromProjectLocationSession(string projectId, string locationId, string sessionId) =>
            new SessionName(ResourceNameType.ProjectLocationSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)));

        /// <summary>
        /// Creates a <see cref="SessionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reasoningEngineId">The <c>ReasoningEngine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SessionName"/> constructed from the provided ids.</returns>
        public static SessionName FromProjectLocationReasoningEngineSession(string projectId, string locationId, string reasoningEngineId, string sessionId) =>
            new SessionName(ResourceNameType.ProjectLocationReasoningEngineSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reasoningEngineId: gax::GaxPreconditions.CheckNotNullOrEmpty(reasoningEngineId, nameof(reasoningEngineId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string sessionId) =>
            FormatProjectLocationSession(projectId, locationId, sessionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}</c>.
        /// </returns>
        public static string FormatProjectLocationSession(string projectId, string locationId, string sessionId) =>
            s_projectLocationSession.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reasoningEngineId">The <c>ReasoningEngine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}</c>.
        /// </returns>
        public static string FormatProjectLocationReasoningEngineSession(string projectId, string locationId, string reasoningEngineId, string sessionId) =>
            s_projectLocationReasoningEngineSession.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reasoningEngineId, nameof(reasoningEngineId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)));

        /// <summary>Parses the given resource name string into a new <see cref="SessionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sessions/{session}</c></description></item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SessionName"/> if successful.</returns>
        public static SessionName Parse(string sessionName) => Parse(sessionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SessionName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sessions/{session}</c></description></item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SessionName"/> if successful.</returns>
        public static SessionName Parse(string sessionName, bool allowUnparsed) =>
            TryParse(sessionName, allowUnparsed, out SessionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SessionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sessions/{session}</c></description></item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sessionName, out SessionName result) => TryParse(sessionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SessionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sessions/{session}</c></description></item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sessionName, bool allowUnparsed, out SessionName result)
        {
            gax::GaxPreconditions.CheckNotNull(sessionName, nameof(sessionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSession.TryParseName(sessionName, out resourceName))
            {
                result = FromProjectLocationSession(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationReasoningEngineSession.TryParseName(sessionName, out resourceName))
            {
                result = FromProjectLocationReasoningEngineSession(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sessionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SessionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string reasoningEngineId = null, string sessionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ReasoningEngineId = reasoningEngineId;
            SessionId = sessionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SessionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        public SessionName(string projectId, string locationId, string sessionId) : this(ResourceNameType.ProjectLocationSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)))
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
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>ReasoningEngine</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ReasoningEngineId { get; }

        /// <summary>
        /// The <c>Session</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string SessionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSession: return s_projectLocationSession.Expand(ProjectId, LocationId, SessionId);
                case ResourceNameType.ProjectLocationReasoningEngineSession: return s_projectLocationReasoningEngineSession.Expand(ProjectId, LocationId, ReasoningEngineId, SessionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SessionName);

        /// <inheritdoc/>
        public bool Equals(SessionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SessionName a, SessionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SessionName a, SessionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>SessionEvent</c> resource.</summary>
    public sealed partial class SessionEventName : gax::IResourceName, sys::IEquatable<SessionEventName>
    {
        /// <summary>The possible contents of <see cref="SessionEventName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/sessions/{session}/events/{event}</c>.
            /// </summary>
            ProjectLocationSessionEvent = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}/events/{event}</c>
            /// .
            /// </summary>
            ProjectLocationReasoningEngineSessionEvent = 2,
        }

        private static gax::PathTemplate s_projectLocationSessionEvent = new gax::PathTemplate("projects/{project}/locations/{location}/sessions/{session}/events/{event}");

        private static gax::PathTemplate s_projectLocationReasoningEngineSessionEvent = new gax::PathTemplate("projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}/events/{event}");

        /// <summary>Creates a <see cref="SessionEventName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SessionEventName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SessionEventName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SessionEventName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SessionEventName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}/events/{event}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventId">The <c>Event</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SessionEventName"/> constructed from the provided ids.</returns>
        public static SessionEventName FromProjectLocationSessionEvent(string projectId, string locationId, string sessionId, string eventId) =>
            new SessionEventName(ResourceNameType.ProjectLocationSessionEvent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), eventId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventId, nameof(eventId)));

        /// <summary>
        /// Creates a <see cref="SessionEventName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}/events/{event}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reasoningEngineId">The <c>ReasoningEngine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventId">The <c>Event</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SessionEventName"/> constructed from the provided ids.</returns>
        public static SessionEventName FromProjectLocationReasoningEngineSessionEvent(string projectId, string locationId, string reasoningEngineId, string sessionId, string eventId) =>
            new SessionEventName(ResourceNameType.ProjectLocationReasoningEngineSessionEvent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reasoningEngineId: gax::GaxPreconditions.CheckNotNullOrEmpty(reasoningEngineId, nameof(reasoningEngineId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), eventId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventId, nameof(eventId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SessionEventName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}/events/{event}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventId">The <c>Event</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SessionEventName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}/events/{event}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string sessionId, string eventId) =>
            FormatProjectLocationSessionEvent(projectId, locationId, sessionId, eventId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SessionEventName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}/events/{event}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventId">The <c>Event</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SessionEventName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}/events/{event}</c>.
        /// </returns>
        public static string FormatProjectLocationSessionEvent(string projectId, string locationId, string sessionId, string eventId) =>
            s_projectLocationSessionEvent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(eventId, nameof(eventId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SessionEventName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}/events/{event}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reasoningEngineId">The <c>ReasoningEngine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventId">The <c>Event</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SessionEventName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}/events/{event}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationReasoningEngineSessionEvent(string projectId, string locationId, string reasoningEngineId, string sessionId, string eventId) =>
            s_projectLocationReasoningEngineSessionEvent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reasoningEngineId, nameof(reasoningEngineId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(eventId, nameof(eventId)));

        /// <summary>Parses the given resource name string into a new <see cref="SessionEventName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/sessions/{session}/events/{event}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}/events/{event}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sessionEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SessionEventName"/> if successful.</returns>
        public static SessionEventName Parse(string sessionEventName) => Parse(sessionEventName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SessionEventName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/sessions/{session}/events/{event}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}/events/{event}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sessionEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SessionEventName"/> if successful.</returns>
        public static SessionEventName Parse(string sessionEventName, bool allowUnparsed) =>
            TryParse(sessionEventName, allowUnparsed, out SessionEventName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SessionEventName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/sessions/{session}/events/{event}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}/events/{event}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sessionEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SessionEventName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sessionEventName, out SessionEventName result) =>
            TryParse(sessionEventName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SessionEventName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/sessions/{session}/events/{event}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}/sessions/{session}/events/{event}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sessionEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SessionEventName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sessionEventName, bool allowUnparsed, out SessionEventName result)
        {
            gax::GaxPreconditions.CheckNotNull(sessionEventName, nameof(sessionEventName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSessionEvent.TryParseName(sessionEventName, out resourceName))
            {
                result = FromProjectLocationSessionEvent(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectLocationReasoningEngineSessionEvent.TryParseName(sessionEventName, out resourceName))
            {
                result = FromProjectLocationReasoningEngineSessionEvent(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sessionEventName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SessionEventName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string eventId = null, string locationId = null, string projectId = null, string reasoningEngineId = null, string sessionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EventId = eventId;
            LocationId = locationId;
            ProjectId = projectId;
            ReasoningEngineId = reasoningEngineId;
            SessionId = sessionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SessionEventName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}/events/{event}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventId">The <c>Event</c> ID. Must not be <c>null</c> or empty.</param>
        public SessionEventName(string projectId, string locationId, string sessionId, string eventId) : this(ResourceNameType.ProjectLocationSessionEvent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), eventId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventId, nameof(eventId)))
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
        /// The <c>Event</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string EventId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>ReasoningEngine</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ReasoningEngineId { get; }

        /// <summary>
        /// The <c>Session</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string SessionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSessionEvent: return s_projectLocationSessionEvent.Expand(ProjectId, LocationId, SessionId, EventId);
                case ResourceNameType.ProjectLocationReasoningEngineSessionEvent: return s_projectLocationReasoningEngineSessionEvent.Expand(ProjectId, LocationId, ReasoningEngineId, SessionId, EventId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SessionEventName);

        /// <inheritdoc/>
        public bool Equals(SessionEventName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SessionEventName a, SessionEventName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SessionEventName a, SessionEventName b) => !(a == b);
    }

    public partial class Session
    {
        /// <summary>
        /// <see cref="gcav::SessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::SessionName SessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::SessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SessionEvent
    {
        /// <summary>
        /// <see cref="gcav::SessionEventName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::SessionEventName SessionEventName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::SessionEventName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
