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

namespace Google.Cloud.Spanner.Admin.Database.V1
{
    /// <summary>
    /// Resource name for the 'instance' resource.
    /// </summary>
    public sealed partial class InstanceName : IResourceName, IEquatable<InstanceName>
    {
        private static readonly PathTemplate s_template = new PathTemplate("projects/{project}/instances/{instance}");

        /// <summary>
        /// Parses the given instance resource name in string form into a new
        /// <see cref="InstanceName"/> instance.
        /// </summary>
        /// <param name="instanceName">The instance resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InstanceName"/> if successful.</returns>
        public static InstanceName Parse(string instanceName)
        {
            GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName));
            TemplatedResourceName resourceName = s_template.ParseName(instanceName);
            return new InstanceName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given instance resource name in string form into a new
        /// <see cref="InstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="ArgumentNullException"/> if <paramref name="instanceName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="instanceName">The instance resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="InstanceName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed succssfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceName, out InstanceName result)
        {
            GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName));
            TemplatedResourceName resourceName;
            if (s_template.TryParseName(instanceName, out resourceName))
            {
                result = new InstanceName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="InstanceName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="instanceId">The instance ID. Must not be <c>null</c>.</param>
        public InstanceName(string projectId, string instanceId)
        {
            ProjectId = GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            InstanceId = GaxPreconditions.CheckNotNull(instanceId, nameof(instanceId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The instance ID. Never <c>null</c>.
        /// </summary>
        public string InstanceId { get; }

        /// <inheritdoc />
        public ResourceNameKind Kind => ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, InstanceId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as InstanceName);

        /// <inheritdoc />
        public bool Equals(InstanceName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(InstanceName a, InstanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(InstanceName a, InstanceName b) => !(a == b);
    }

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


    public partial class CreateDatabaseMetadata
    {
        /// <summary>
        /// <see cref="DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public DatabaseName DatabaseAsDatabaseName
        {
            get { return string.IsNullOrEmpty(Database) ? null : Google.Cloud.Spanner.Admin.Database.V1.DatabaseName.Parse(Database); }
            set { Database = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateDatabaseRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Spanner.Admin.Database.V1.InstanceName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DropDatabaseRequest
    {
        /// <summary>
        /// <see cref="DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public DatabaseName DatabaseAsDatabaseName
        {
            get { return string.IsNullOrEmpty(Database) ? null : Google.Cloud.Spanner.Admin.Database.V1.DatabaseName.Parse(Database); }
            set { Database = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetDatabaseDdlRequest
    {
        /// <summary>
        /// <see cref="DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public DatabaseName DatabaseAsDatabaseName
        {
            get { return string.IsNullOrEmpty(Database) ? null : Google.Cloud.Spanner.Admin.Database.V1.DatabaseName.Parse(Database); }
            set { Database = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetDatabaseRequest
    {
        /// <summary>
        /// <see cref="DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public DatabaseName DatabaseName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Spanner.Admin.Database.V1.DatabaseName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListDatabasesRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Spanner.Admin.Database.V1.InstanceName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateDatabaseDdlMetadata
    {
        /// <summary>
        /// <see cref="DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public DatabaseName DatabaseAsDatabaseName
        {
            get { return string.IsNullOrEmpty(Database) ? null : Google.Cloud.Spanner.Admin.Database.V1.DatabaseName.Parse(Database); }
            set { Database = value != null ? value.ToString() : ""; }
        }

    }

    public partial class UpdateDatabaseDdlRequest
    {
        /// <summary>
        /// <see cref="DatabaseName"/>-typed view over the <see cref="Database"/> resource name property.
        /// </summary>
        public DatabaseName DatabaseAsDatabaseName
        {
            get { return string.IsNullOrEmpty(Database) ? null : Google.Cloud.Spanner.Admin.Database.V1.DatabaseName.Parse(Database); }
            set { Database = value != null ? value.ToString() : ""; }
        }

    }

}