// Copyright 2020 Google LLC
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

using gax = Google.Api.Gax;
using gcbsv = Google.Cloud.BigQuery.Storage.V1;
using sys = System;

namespace Google.Cloud.BigQuery.Storage.V1
{
    /// <summary>Resource name for the <c>ReadSession</c> resource.</summary>
    public sealed partial class ReadSessionName : gax::IResourceName, sys::IEquatable<ReadSessionName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/sessions/{session}");

        /// <summary>
        /// Parses the given <c>ReadSession</c> resource name in string form into a new <see cref="ReadSessionName"/>
        /// instance.
        /// </summary>
        /// <param name="readSessionName">
        /// The <c>ReadSession</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ReadSessionName"/> if successful.</returns>
        public static ReadSessionName Parse(string readSessionName)
        {
            gax::GaxPreconditions.CheckNotNull(readSessionName, nameof(readSessionName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(readSessionName);
            return new ReadSessionName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="ReadSessionName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="readSessionName"/> is
        /// <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="readSessionName">
        /// The <c>ReadSession</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReadSessionName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string readSessionName, out ReadSessionName result)
        {
            gax::GaxPreconditions.CheckNotNull(readSessionName, nameof(readSessionName));
            if (s_template.TryParseName(readSessionName, out gax::TemplatedResourceName resourceName))
            {
                result = new ReadSessionName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ReadSessionName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ReadSessionName"/>.</returns>
        public static string Format(string projectId, string locationId, string sessionId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(sessionId, nameof(sessionId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ReadSessionName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c>.</param>
        public ReadSessionName(string projectId, string locationId, string sessionId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            SessionId = gax::GaxPreconditions.CheckNotNull(sessionId, nameof(sessionId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Location</c> ID. Never <c>null</c>.</summary>
        public string LocationId { get; }

        /// <summary>The <c>Session</c> ID. Never <c>null</c>.</summary>
        public string SessionId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, LocationId, SessionId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReadSessionName);

        /// <inheritdoc/>
        public bool Equals(ReadSessionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ReadSessionName a, ReadSessionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ReadSessionName a, ReadSessionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ReadStream</c> resource.</summary>
    public sealed partial class ReadStreamName : gax::IResourceName, sys::IEquatable<ReadStreamName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/sessions/{session}/streams/{stream}");

        /// <summary>
        /// Parses the given <c>ReadStream</c> resource name in string form into a new <see cref="ReadStreamName"/>
        /// instance.
        /// </summary>
        /// <param name="readStreamName">
        /// The <c>ReadStream</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ReadStreamName"/> if successful.</returns>
        public static ReadStreamName Parse(string readStreamName)
        {
            gax::GaxPreconditions.CheckNotNull(readStreamName, nameof(readStreamName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(readStreamName);
            return new ReadStreamName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="ReadStreamName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="readStreamName"/> is
        /// <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="readStreamName">
        /// The <c>ReadStream</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReadStreamName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string readStreamName, out ReadStreamName result)
        {
            gax::GaxPreconditions.CheckNotNull(readStreamName, nameof(readStreamName));
            if (s_template.TryParseName(readStreamName, out gax::TemplatedResourceName resourceName))
            {
                result = new ReadStreamName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ReadStreamName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c>.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ReadStreamName"/>.</returns>
        public static string Format(string projectId, string locationId, string sessionId, string streamId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(sessionId, nameof(sessionId)), gax::GaxPreconditions.CheckNotNull(streamId, nameof(streamId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ReadStreamName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c>.</param>
        /// <param name="streamId">The <c>Stream</c> ID. Must not be <c>null</c>.</param>
        public ReadStreamName(string projectId, string locationId, string sessionId, string streamId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            SessionId = gax::GaxPreconditions.CheckNotNull(sessionId, nameof(sessionId));
            StreamId = gax::GaxPreconditions.CheckNotNull(streamId, nameof(streamId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Location</c> ID. Never <c>null</c>.</summary>
        public string LocationId { get; }

        /// <summary>The <c>Session</c> ID. Never <c>null</c>.</summary>
        public string SessionId { get; }

        /// <summary>The <c>Stream</c> ID. Never <c>null</c>.</summary>
        public string StreamId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, LocationId, SessionId, StreamId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReadStreamName);

        /// <inheritdoc/>
        public bool Equals(ReadStreamName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ReadStreamName a, ReadStreamName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ReadStreamName a, ReadStreamName b) => !(a == b);
    }

    public partial class ReadSession
    {
        /// <summary>
        /// <see cref="gcbsv::ReadSessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbsv::ReadSessionName ReadSessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbsv::ReadSessionName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="TableName"/>-typed view over the <see cref="Table"/> resource name property.</summary>
        public TableName TableAsTableName
        {
            get => string.IsNullOrEmpty(Table) ? null : TableName.Parse(Table);
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
            get => string.IsNullOrEmpty(Name) ? null : gcbsv::ReadStreamName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
