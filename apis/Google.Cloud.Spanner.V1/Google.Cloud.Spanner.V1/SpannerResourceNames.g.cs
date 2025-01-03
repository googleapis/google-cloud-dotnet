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
using gcscv = Google.Cloud.Spanner.Common.V1;
using gcsv = Google.Cloud.Spanner.V1;
using sys = System;

namespace Google.Cloud.Spanner.V1
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
            /// A resource name with pattern
            /// <c>projects/{project}/instances/{instance}/databases/{database}/sessions/{session}</c>.
            /// </summary>
            ProjectInstanceDatabaseSession = 1,
        }

        private static gax::PathTemplate s_projectInstanceDatabaseSession = new gax::PathTemplate("projects/{project}/instances/{instance}/databases/{database}/sessions/{session}");

        /// <summary>Creates a <see cref="SessionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SessionName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SessionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SessionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SessionName"/> with the pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SessionName"/> constructed from the provided ids.</returns>
        public static SessionName FromProjectInstanceDatabaseSession(string projectId, string instanceId, string databaseId, string sessionId) =>
            new SessionName(ResourceNameType.ProjectInstanceDatabaseSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}/sessions/{session}</c>.
        /// </returns>
        public static string Format(string projectId, string instanceId, string databaseId, string sessionId) =>
            FormatProjectInstanceDatabaseSession(projectId, instanceId, databaseId, sessionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}/sessions/{session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SessionName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}/sessions/{session}</c>.
        /// </returns>
        public static string FormatProjectInstanceDatabaseSession(string projectId, string instanceId, string databaseId, string sessionId) =>
            s_projectInstanceDatabaseSession.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)));

        /// <summary>Parses the given resource name string into a new <see cref="SessionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/databases/{database}/sessions/{session}</c>
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
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/databases/{database}/sessions/{session}</c>
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
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/databases/{database}/sessions/{session}</c>
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
        /// <item>
        /// <description>
        /// <c>projects/{project}/instances/{instance}/databases/{database}/sessions/{session}</c>
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
            if (s_projectInstanceDatabaseSession.TryParseName(sessionName, out resourceName))
            {
                result = FromProjectInstanceDatabaseSession(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
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

        private SessionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string databaseId = null, string instanceId = null, string projectId = null, string sessionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatabaseId = databaseId;
            InstanceId = instanceId;
            ProjectId = projectId;
            SessionId = sessionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SessionName"/> class from the component parts of pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}/sessions/{session}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c> or empty.</param>
        public SessionName(string projectId, string instanceId, string databaseId, string sessionId) : this(ResourceNameType.ProjectInstanceDatabaseSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), sessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(sessionId, nameof(sessionId)))
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
        /// The <c>Database</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatabaseId { get; }

        /// <summary>
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

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
                case ResourceNameType.ProjectInstanceDatabaseSession: return s_projectInstanceDatabaseSession.Expand(ProjectId, InstanceId, DatabaseId, SessionId);
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

    public partial class CreateSessionRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get => string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database, allowUnparsed: true);
            set => Database = value?.ToString() ?? "";
        }
    }

    public partial class BatchCreateSessionsRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get => string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database, allowUnparsed: true);
            set => Database = value?.ToString() ?? "";
        }
    }

    public partial class Session
    {
        /// <summary>
        /// <see cref="gcsv::SessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SessionName SessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetSessionRequest
    {
        /// <summary>
        /// <see cref="gcsv::SessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SessionName SessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSessionsRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get => string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database, allowUnparsed: true);
            set => Database = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSessionRequest
    {
        /// <summary>
        /// <see cref="gcsv::SessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SessionName SessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExecuteSqlRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session, allowUnparsed: true);
            set => Session = value?.ToString() ?? "";
        }
    }

    public partial class ExecuteBatchDmlRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session, allowUnparsed: true);
            set => Session = value?.ToString() ?? "";
        }
    }

    public partial class PartitionQueryRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session, allowUnparsed: true);
            set => Session = value?.ToString() ?? "";
        }
    }

    public partial class PartitionReadRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session, allowUnparsed: true);
            set => Session = value?.ToString() ?? "";
        }
    }

    public partial class ReadRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session, allowUnparsed: true);
            set => Session = value?.ToString() ?? "";
        }
    }

    public partial class BeginTransactionRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session, allowUnparsed: true);
            set => Session = value?.ToString() ?? "";
        }
    }

    public partial class CommitRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session, allowUnparsed: true);
            set => Session = value?.ToString() ?? "";
        }
    }

    public partial class RollbackRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session, allowUnparsed: true);
            set => Session = value?.ToString() ?? "";
        }
    }

    public partial class BatchWriteRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session, allowUnparsed: true);
            set => Session = value?.ToString() ?? "";
        }
    }
}
