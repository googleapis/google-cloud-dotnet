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
using gcbsv = Google.Cloud.BigQuery.Storage.V1;
using sys = System;

namespace Google.Cloud.BigQuery.Storage.V1
{
    /// <summary>Resource name for the <c>ReadSession</c> resource.</summary>
    public sealed partial class ReadSessionName : gax::IResourceName, sys::IEquatable<ReadSessionName>
    {
        /// <summary>The possible contents of <see cref="ReadSessionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/sessions/{session}</c>.
            /// </summary>
            ProjectLocationSession = 1,
        }

        private static gax::PathTemplate s_projectLocationSession = new gax::PathTemplate("projects/{project}/locations/{location}/sessions/{session}");

        /// <summary>Creates a <see cref="ReadSessionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReadSessionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReadSessionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReadSessionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReadSessionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReadSessionName"/> constructed from the provided ids.</returns>
        public static ReadSessionName FromProjectLocationSession(string projectId, string locationId, string sessionId) =>
            new ReadSessionName(ResourceNameType.ProjectLocationSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReadSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReadSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string sessionId) =>
            FormatProjectLocationSession(projectId, locationId, sessionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReadSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReadSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}</c>.
        /// </returns>
        public static string FormatProjectLocationSession(string projectId, string locationId, string sessionId) =>
            s_projectLocationSession.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)));

        /// <summary>Parses the given resource name string into a new <see cref="ReadSessionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sessions/{session}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="readSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReadSessionName"/> if successful.</returns>
        public static ReadSessionName Parse(string readSessionName) => Parse(readSessionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReadSessionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sessions/{session}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="readSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReadSessionName"/> if successful.</returns>
        public static ReadSessionName Parse(string readSessionName, bool allowUnparsed) =>
            TryParse(readSessionName, allowUnparsed, out ReadSessionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReadSessionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sessions/{session}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="readSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReadSessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string readSessionName, out ReadSessionName result) =>
            TryParse(readSessionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReadSessionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/sessions/{session}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="readSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReadSessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string readSessionName, bool allowUnparsed, out ReadSessionName result)
        {
            gax::GaxPreconditions.CheckNotNull(readSessionName, nameof(readSessionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSession.TryParseName(readSessionName, out resourceName))
            {
                result = FromProjectLocationSession(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(readSessionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReadSessionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string sessionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SessionId = sessionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReadSessionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        public ReadSessionName(string projectId, string locationId, string sessionId) : this(ResourceNameType.ProjectLocationSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Session</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
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
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReadSessionName);

        /// <inheritdoc/>
        public bool Equals(ReadSessionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReadSessionName a, ReadSessionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReadSessionName a, ReadSessionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ReadStream</c> resource.</summary>
    public sealed partial class ReadStreamName : gax::IResourceName, sys::IEquatable<ReadStreamName>
    {
        /// <summary>The possible contents of <see cref="ReadStreamName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/sessions/{session}/streams/{stream}</c>.
            /// </summary>
            ProjectLocationSessionStream = 1,
        }

        private static gax::PathTemplate s_projectLocationSessionStream = new gax::PathTemplate("projects/{project}/locations/{location}/sessions/{session}/streams/{stream}");

        /// <summary>Creates a <see cref="ReadStreamName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReadStreamName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReadStreamName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReadStreamName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReadStreamName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}/streams/{stream}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReadStreamName"/> constructed from the provided ids.</returns>
        public static ReadStreamName FromProjectLocationSessionStream(string projectId, string locationId, string sessionId, string streamId) =>
            new ReadStreamName(ResourceNameType.ProjectLocationSessionStream, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), streamId: gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReadStreamName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}/streams/{stream}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReadStreamName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}/streams/{stream}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string sessionId, string streamId) =>
            FormatProjectLocationSessionStream(projectId, locationId, sessionId, streamId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReadStreamName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}/streams/{stream}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReadStreamName"/> with pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}/streams/{stream}</c>.
        /// </returns>
        public static string FormatProjectLocationSessionStream(string projectId, string locationId, string sessionId, string streamId) =>
            s_projectLocationSessionStream.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)));

        /// <summary>Parses the given resource name string into a new <see cref="ReadStreamName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sessions/{session}/streams/{stream}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="readStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReadStreamName"/> if successful.</returns>
        public static ReadStreamName Parse(string readStreamName) => Parse(readStreamName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReadStreamName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sessions/{session}/streams/{stream}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="readStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReadStreamName"/> if successful.</returns>
        public static ReadStreamName Parse(string readStreamName, bool allowUnparsed) =>
            TryParse(readStreamName, allowUnparsed, out ReadStreamName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReadStreamName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sessions/{session}/streams/{stream}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="readStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReadStreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string readStreamName, out ReadStreamName result) =>
            TryParse(readStreamName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReadStreamName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/sessions/{session}/streams/{stream}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="readStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReadStreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string readStreamName, bool allowUnparsed, out ReadStreamName result)
        {
            gax::GaxPreconditions.CheckNotNull(readStreamName, nameof(readStreamName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSessionStream.TryParseName(readStreamName, out resourceName))
            {
                result = FromProjectLocationSessionStream(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(readStreamName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReadStreamName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string sessionId = null, string streamId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SessionId = sessionId;
            StreamId = streamId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReadStreamName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/sessions/{session}/streams/{stream}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        public ReadStreamName(string projectId, string locationId, string sessionId, string streamId) : this(ResourceNameType.ProjectLocationSessionStream, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)), streamId: gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Session</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SessionId { get; }

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
                case ResourceNameType.ProjectLocationSessionStream: return s_projectLocationSessionStream.Expand(ProjectId, LocationId, SessionId, StreamId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReadStreamName);

        /// <inheritdoc/>
        public bool Equals(ReadStreamName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReadStreamName a, ReadStreamName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReadStreamName a, ReadStreamName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>WriteStream</c> resource.</summary>
    public sealed partial class WriteStreamName : gax::IResourceName, sys::IEquatable<WriteStreamName>
    {
        /// <summary>The possible contents of <see cref="WriteStreamName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}</c>
            /// .
            /// </summary>
            ProjectDatasetTableStream = 1,
        }

        private static gax::PathTemplate s_projectDatasetTableStream = new gax::PathTemplate("projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}");

        /// <summary>Creates a <see cref="WriteStreamName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WriteStreamName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static WriteStreamName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WriteStreamName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WriteStreamName"/> with the pattern
        /// <c>projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WriteStreamName"/> constructed from the provided ids.</returns>
        public static WriteStreamName FromProjectDatasetTableStream(string projectId, string datasetId, string tableId, string streamId) =>
            new WriteStreamName(ResourceNameType.ProjectDatasetTableStream, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), tableId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)), streamId: gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WriteStreamName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WriteStreamName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}</c>.
        /// </returns>
        public static string Format(string projectId, string datasetId, string tableId, string streamId) =>
            FormatProjectDatasetTableStream(projectId, datasetId, tableId, streamId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WriteStreamName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WriteStreamName"/> with pattern
        /// <c>projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}</c>.
        /// </returns>
        public static string FormatProjectDatasetTableStream(string projectId, string datasetId, string tableId, string streamId) =>
            s_projectDatasetTableStream.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)), gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)));

        /// <summary>Parses the given resource name string into a new <see cref="WriteStreamName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="writeStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WriteStreamName"/> if successful.</returns>
        public static WriteStreamName Parse(string writeStreamName) => Parse(writeStreamName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WriteStreamName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="writeStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WriteStreamName"/> if successful.</returns>
        public static WriteStreamName Parse(string writeStreamName, bool allowUnparsed) =>
            TryParse(writeStreamName, allowUnparsed, out WriteStreamName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WriteStreamName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="writeStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WriteStreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string writeStreamName, out WriteStreamName result) =>
            TryParse(writeStreamName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WriteStreamName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="writeStreamName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WriteStreamName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string writeStreamName, bool allowUnparsed, out WriteStreamName result)
        {
            gax::GaxPreconditions.CheckNotNull(writeStreamName, nameof(writeStreamName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDatasetTableStream.TryParseName(writeStreamName, out resourceName))
            {
                result = FromProjectDatasetTableStream(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(writeStreamName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WriteStreamName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string datasetId = null, string projectId = null, string streamId = null, string tableId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatasetId = datasetId;
            ProjectId = projectId;
            StreamId = streamId;
            TableId = tableId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WriteStreamName"/> class from the component parts of pattern
        /// <c>projects/{project}/datasets/{dataset}/tables/{table}/streams/{stream}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tableId">The <c>Table</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c> or empty.</param>
        public WriteStreamName(string projectId, string datasetId, string tableId, string streamId) : this(ResourceNameType.ProjectDatasetTableStream, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), tableId: gax::GaxPreconditions.CheckNotNullOrEmpty(tableId, nameof(tableId)), streamId: gax::GaxPreconditions.CheckNotNullOrEmpty(streamId, nameof(streamId)))
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
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Stream</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string StreamId { get; }

        /// <summary>
        /// The <c>Table</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TableId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectDatasetTableStream: return s_projectDatasetTableStream.Expand(ProjectId, DatasetId, TableId, StreamId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WriteStreamName);

        /// <inheritdoc/>
        public bool Equals(WriteStreamName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WriteStreamName a, WriteStreamName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(WriteStreamName a, WriteStreamName b) => !(a == b);
    }

    public partial class ReadSession
    {
        /// <summary>
        /// <see cref="gcbsv::ReadSessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbsv::ReadSessionName ReadSessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbsv::ReadSessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="TableName"/>-typed view over the <see cref="Table"/> resource name property.</summary>
        public TableName TableAsTableName
        {
            get => string.IsNullOrEmpty(Table) ? null : TableName.Parse(Table, allowUnparsed: true);
            set => Table = value?.ToString() ?? "";
        }
    }

    public partial class ReadStream
    {
        /// <summary>
        /// <see cref="gcbsv::ReadStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbsv::ReadStreamName ReadStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbsv::ReadStreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class WriteStream
    {
        /// <summary>
        /// <see cref="gcbsv::WriteStreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbsv::WriteStreamName WriteStreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbsv::WriteStreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
