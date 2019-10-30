// Copyright 2019 Google LLC
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
using gcscv = Google.Cloud.Spanner.Common.V1;
using gcsv = Google.Cloud.Spanner.V1;
using sys = System;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>Resource name for the <c>Session</c> resource.</summary>
    public sealed partial class SessionName : gax::IResourceName, sys::IEquatable<SessionName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/instances/{instance}/databases/{database}/sessions/{session}");

        /// <summary>
        /// Parses the given <c>Session</c> resource name in string form into a new <see cref="SessionName"/> instance.
        /// </summary>
        /// <param name="sessionName">The <c>Session</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SessionName"/> if successful.</returns>
        public static SessionName Parse(string sessionName)
        {
            gax::GaxPreconditions.CheckNotNull(sessionName, nameof(sessionName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(sessionName);
            return new SessionName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="SessionName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="sessionName"/> is
        /// <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="sessionName">The <c>Session</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SessionName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sessionName, out SessionName result)
        {
            gax::GaxPreconditions.CheckNotNull(sessionName, nameof(sessionName));
            if (s_template.TryParseName(sessionName, out gax::TemplatedResourceName resourceName))
            {
                result = new SessionName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="SessionName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c>.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="SessionName"/>.</returns>
        public static string Format(string projectId, string instanceId, string databaseId, string sessionId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId)), gax::GaxPreconditions.CheckNotNull(sessionId, nameof(sessionId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="SessionName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c>.</param>
        /// <param name="sessionId">The <c>Session</c> ID. Must not be <c>null</c>.</param>
        public SessionName(string projectId, string instanceId, string databaseId, string sessionId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            InstanceId = gax::GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId));
            DatabaseId = gax::GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId));
            SessionId = gax::GaxPreconditions.CheckNotNull(sessionId, nameof(sessionId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Instance</c> ID. Never <c>null</c>.</summary>
        public string InstanceId { get; }

        /// <summary>The <c>Database</c> ID. Never <c>null</c>.</summary>
        public string DatabaseId { get; }

        /// <summary>The <c>Session</c> ID. Never <c>null</c>.</summary>
        public string SessionId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, InstanceId, DatabaseId, SessionId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SessionName);

        /// <inheritdoc/>
        public bool Equals(SessionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SessionName a, SessionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SessionName a, SessionName b) => !(a == b);
    }

    public partial class CreateSessionRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseAsDatabaseName
        {
            get => string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database);
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
            get => string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database);
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
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SessionName.Parse(Name);
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
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SessionName.Parse(Name);
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
            get => string.IsNullOrEmpty(Database) ? null : gcscv::DatabaseName.Parse(Database);
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
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SessionName.Parse(Name);
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
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session);
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
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session);
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
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session);
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
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session);
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
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session);
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
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session);
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
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session);
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
            get => string.IsNullOrEmpty(Session) ? null : SessionName.Parse(Session);
            set => Session = value?.ToString() ?? "";
        }
    }
}
