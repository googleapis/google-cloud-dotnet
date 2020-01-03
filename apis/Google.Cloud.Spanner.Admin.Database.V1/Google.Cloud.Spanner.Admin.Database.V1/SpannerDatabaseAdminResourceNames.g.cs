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
using gcscv = Google.Cloud.Spanner.Common.V1;
using sys = System;

namespace Google.Cloud.Spanner.Admin.Database.V1
{
    /// <summary>Resource name for the <c>Database</c> resource.</summary>
    public sealed partial class DatabaseName : gax::IResourceName, sys::IEquatable<gcscv::DatabaseName>
    {
        /// <summary>The possible contents of <see cref="gcscv::DatabaseName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/instances/{instance}/databases/{database}</c>.
            /// </summary>
            ProjectInstanceDatabase = 1
        }

        private static gax::PathTemplate s_projectInstanceDatabase = new gax::PathTemplate("projects/{project}/instances/{instance}/databases/{database}");

        /// <summary>Creates a <see cref="gcscv::DatabaseName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="gcscv::DatabaseName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static gcscv::DatabaseName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new gcscv::DatabaseName(gcscv::DatabaseName.ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="gcscv::DatabaseName"/> with the pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="gcscv::DatabaseName"/> constructed from the provided ids.</returns>
        public static gcscv::DatabaseName FromProjectInstanceDatabase(string projectId, string instanceId, string databaseId) =>
            new gcscv::DatabaseName(gcscv::DatabaseName.ResourceNameType.ProjectInstanceDatabase, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="gcscv::DatabaseName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="gcscv::DatabaseName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}</c>.
        /// </returns>
        public static string Format(string projectId, string instanceId, string databaseId) =>
            FormatProjectInstanceDatabase(projectId, instanceId, databaseId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="gcscv::DatabaseName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="gcscv::DatabaseName"/> with pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}</c>.
        /// </returns>
        public static string FormatProjectInstanceDatabase(string projectId, string instanceId, string databaseId) =>
            s_projectInstanceDatabase.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="gcscv::DatabaseName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instances/{instance}/databases/{database}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="databaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="gcscv::DatabaseName"/> if successful.</returns>
        public static gcscv::DatabaseName Parse(string databaseName) => Parse(databaseName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="gcscv::DatabaseName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instances/{instance}/databases/{database}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="databaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="gcscv::DatabaseName"/> if successful.</returns>
        public static gcscv::DatabaseName Parse(string databaseName, bool allowUnparsed) =>
            TryParse(databaseName, allowUnparsed, out gcscv::DatabaseName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="gcscv::DatabaseName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instances/{instance}/databases/{database}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="databaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="gcscv::DatabaseName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string databaseName, out gcscv::DatabaseName result) =>
            TryParse(databaseName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="gcscv::DatabaseName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instances/{instance}/databases/{database}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="databaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="gcscv::DatabaseName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string databaseName, bool allowUnparsed, out gcscv::DatabaseName result)
        {
            gax::GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
            gax::TemplatedResourceName resourceName;
            if (s_projectInstanceDatabase.TryParseName(databaseName, out resourceName))
            {
                result = FromProjectInstanceDatabase(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(databaseName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DatabaseName(gcscv::DatabaseName.ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string databaseId = null, string instanceId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatabaseId = databaseId;
            InstanceId = instanceId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="gcscv::DatabaseName"/> class from the component parts of pattern
        /// <c>projects/{project}/instances/{instance}/databases/{database}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        public DatabaseName(string projectId, string instanceId, string databaseId) : this(gcscv::DatabaseName.ResourceNameType.ProjectInstanceDatabase, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)))
        {
        }

        /// <summary>The <see cref="gcscv::DatabaseName.ResourceNameType"/> of the contained resource name.</summary>
        public gcscv::DatabaseName.ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c>if this instance contains an
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

        /// <inheritdoc/>
        public bool IsKnownPattern => Type != gcscv::DatabaseName.ResourceNameType.Unparsed;

        /// <inheritdoc/>
        public override string ToString()
        {
            switch (Type)
            {
                case gcscv::DatabaseName.ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case gcscv::DatabaseName.ResourceNameType.ProjectInstanceDatabase: return s_projectInstanceDatabase.Expand(ProjectId, InstanceId, DatabaseId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as gcscv::DatabaseName);

        /// <inheritdoc/>
        public bool Equals(gcscv::DatabaseName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(gcscv::DatabaseName a, gcscv::DatabaseName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(gcscv::DatabaseName a, gcscv::DatabaseName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Instance</c> resource.</summary>
    public sealed partial class InstanceName : gax::IResourceName, sys::IEquatable<gcscv::InstanceName>
    {
        /// <summary>The possible contents of <see cref="gcscv::InstanceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/instances/{instance}</c>.</summary>
            ProjectInstance = 1
        }

        private static gax::PathTemplate s_projectInstance = new gax::PathTemplate("projects/{project}/instances/{instance}");

        /// <summary>Creates a <see cref="gcscv::InstanceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="gcscv::InstanceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static gcscv::InstanceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new gcscv::InstanceName(gcscv::InstanceName.ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="gcscv::InstanceName"/> with the pattern <c>projects/{project}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="gcscv::InstanceName"/> constructed from the provided ids.</returns>
        public static gcscv::InstanceName FromProjectInstance(string projectId, string instanceId) =>
            new gcscv::InstanceName(gcscv::InstanceName.ResourceNameType.ProjectInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="gcscv::InstanceName"/> with pattern
        /// <c>projects/{project}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="gcscv::InstanceName"/> with pattern
        /// <c>projects/{project}/instances/{instance}</c>.
        /// </returns>
        public static string Format(string projectId, string instanceId) => FormatProjectInstance(projectId, instanceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="gcscv::InstanceName"/> with pattern
        /// <c>projects/{project}/instances/{instance}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="gcscv::InstanceName"/> with pattern
        /// <c>projects/{project}/instances/{instance}</c>.
        /// </returns>
        public static string FormatProjectInstance(string projectId, string instanceId) =>
            s_projectInstance.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="gcscv::InstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instances/{instance}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="gcscv::InstanceName"/> if successful.</returns>
        public static gcscv::InstanceName Parse(string instanceName) => Parse(instanceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="gcscv::InstanceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instances/{instance}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="gcscv::InstanceName"/> if successful.</returns>
        public static gcscv::InstanceName Parse(string instanceName, bool allowUnparsed) =>
            TryParse(instanceName, allowUnparsed, out gcscv::InstanceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="gcscv::InstanceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instances/{instance}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="gcscv::InstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceName, out gcscv::InstanceName result) =>
            TryParse(instanceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="gcscv::InstanceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/instances/{instance}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="instanceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="gcscv::InstanceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string instanceName, bool allowUnparsed, out gcscv::InstanceName result)
        {
            gax::GaxPreconditions.CheckNotNull(instanceName, nameof(instanceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectInstance.TryParseName(instanceName, out resourceName))
            {
                result = FromProjectInstance(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(instanceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InstanceName(gcscv::InstanceName.ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="gcscv::InstanceName"/> class from the component parts of pattern
        /// <c>projects/{project}/instances/{instance}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        public InstanceName(string projectId, string instanceId) : this(gcscv::InstanceName.ResourceNameType.ProjectInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)))
        {
        }

        /// <summary>The <see cref="gcscv::InstanceName.ResourceNameType"/> of the contained resource name.</summary>
        public gcscv::InstanceName.ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c>if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <inheritdoc/>
        public bool IsKnownPattern => Type != gcscv::InstanceName.ResourceNameType.Unparsed;

        /// <inheritdoc/>
        public override string ToString()
        {
            switch (Type)
            {
                case gcscv::InstanceName.ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case gcscv::InstanceName.ResourceNameType.ProjectInstance: return s_projectInstance.Expand(ProjectId, InstanceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as gcscv::InstanceName);

        /// <inheritdoc/>
        public bool Equals(gcscv::InstanceName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(gcscv::InstanceName a, gcscv::InstanceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(gcscv::InstanceName a, gcscv::InstanceName b) => !(a == b);
    }

    public partial class Database
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::DatabaseName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDatabasesRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcscv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcscv::InstanceName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateDatabaseRequest
    {
        /// <summary>
        /// <see cref="gcscv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcscv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcscv::InstanceName.Parse(Parent);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateDatabaseMetadata
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

    public partial class GetDatabaseRequest
    {
        /// <summary>
        /// <see cref="gcscv::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcscv::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcscv::DatabaseName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UpdateDatabaseDdlRequest
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

    public partial class UpdateDatabaseDdlMetadata
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

    public partial class DropDatabaseRequest
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

    public partial class GetDatabaseDdlRequest
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
}
