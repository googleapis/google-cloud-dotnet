// Copyright 2017, Google Inc. All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using Google.Api.Gax;
using System;
using System.Linq;

namespace Google.Cloud.Spanner.V1
{
    /// <summary>
    /// Resource name for the 'database' resource.
    /// </summary>
    public sealed partial class DatabaseName : IResourceName, IEquatable<DatabaseName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/instances/{instance}/databases/{database}");

        /// <summary>
        /// Parses the given database resource name in string form into a new
        /// <see cref="DatabaseName"/> instance.
        /// </summary>
        /// <param name="databaseName">The database resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatabaseName"/> if successful.</returns>
        public static DatabaseName Parse(string databaseName)
        {
            GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
            TemplatedResourceName resourceName = s_template.ParseName(databaseName);
            return new DatabaseName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given database resource name in string form into a new
        /// <see cref="DatabaseName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="databaseName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="databaseName">The database resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DatabaseName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string databaseName, out DatabaseName result)
        {
            GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(databaseName, out resourceName))
            {
                result = new DatabaseName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="DatabaseName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="instanceId">The instance ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The database ID. Must not be <c>null</c>.</param>
        public DatabaseName(string projectId, string instanceId, string databaseId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            InstanceId = GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId));
            DatabaseId = GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The instance ID. Never <c>null</c>.
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// The database ID. Never <c>null</c>.
        /// </summary>
        public string DatabaseId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, InstanceId, DatabaseId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DatabaseName);

        /// <inheritdoc />
        public bool Equals(DatabaseName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DatabaseName a, DatabaseName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DatabaseName a, DatabaseName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'session' resource.
    /// </summary>
    public sealed partial class SessionName : IResourceName, IEquatable<SessionName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/instances/{instance}/databases/{database}/sessions/{session}");

        /// <summary>
        /// Parses the given session resource name in string form into a new
        /// <see cref="SessionName"/> instance.
        /// </summary>
        /// <param name="sessionName">The session resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SessionName"/> if successful.</returns>
        public static SessionName Parse(string sessionName)
        {
            GaxPreconditions.CheckNotNull(sessionName, nameof(sessionName));
            TemplatedResourceName resourceName = s_template.ParseName(sessionName);
            return new SessionName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new
        /// <see cref="SessionName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="sessionName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="sessionName">The session resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="SessionName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sessionName, out SessionName result)
        {
            GaxPreconditions.CheckNotNull(sessionName, nameof(sessionName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(sessionName, out resourceName))
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

        /// <summary>
        /// Constructs a new instance of the <see cref="SessionName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="instanceId">The instance ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The database ID. Must not be <c>null</c>.</param>
        /// <param name="sessionId">The session ID. Must not be <c>null</c>.</param>
        public SessionName(string projectId, string instanceId, string databaseId, string sessionId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            InstanceId = GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId));
            DatabaseId = GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId));
            SessionId = GaxPreconditions.CheckNotNull(sessionId, nameof(sessionId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The instance ID. Never <c>null</c>.
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// The database ID. Never <c>null</c>.
        /// </summary>
        public string DatabaseId { get; }

        /// <summary>
        /// The session ID. Never <c>null</c>.
        /// </summary>
        public string SessionId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, InstanceId, DatabaseId, SessionId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as SessionName);

        /// <inheritdoc />
        public bool Equals(SessionName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(SessionName a, SessionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(SessionName a, SessionName b) => !(a == b);
    }


    public partial class BeginTransactionRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get { return string.IsNullOrEmpty(Session) ? null : Google.Cloud.Spanner.V1.SessionName.Parse(Session); }
            set { Session = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CommitRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get { return string.IsNullOrEmpty(Session) ? null : Google.Cloud.Spanner.V1.SessionName.Parse(Session); }
            set { Session = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateSessionRequest
    {
        /// <summary>
        /// <see cref="DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public DatabaseName DatabaseAsDatabaseName
        {
            get { return string.IsNullOrEmpty(Database) ? null : Google.Cloud.Spanner.V1.DatabaseName.Parse(Database); }
            set { Database = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteSessionRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public SessionName SessionName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Spanner.V1.SessionName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ExecuteSqlRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get { return string.IsNullOrEmpty(Session) ? null : Google.Cloud.Spanner.V1.SessionName.Parse(Session); }
            set { Session = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetSessionRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public SessionName SessionName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Spanner.V1.SessionName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ReadRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get { return string.IsNullOrEmpty(Session) ? null : Google.Cloud.Spanner.V1.SessionName.Parse(Session); }
            set { Session = value != null ? value.ToString() : ""; }
        }

    }

    public partial class RollbackRequest
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Session"/> resource name property.
        /// </summary>
        public SessionName SessionAsSessionName
        {
            get { return string.IsNullOrEmpty(Session) ? null : Google.Cloud.Spanner.V1.SessionName.Parse(Session); }
            set { Session = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Session
    {
        /// <summary>
        /// <see cref="SessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public SessionName SessionName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Spanner.V1.SessionName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}