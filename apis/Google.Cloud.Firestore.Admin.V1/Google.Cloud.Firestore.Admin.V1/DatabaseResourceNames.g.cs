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
using gcfav = Google.Cloud.Firestore.Admin.V1;
using sys = System;

namespace Google.Cloud.Firestore.Admin.V1
{
    /// <summary>Resource name for the <c>Database</c> resource.</summary>
    public sealed partial class DatabaseName : gax::IResourceName, sys::IEquatable<DatabaseName>
    {
        /// <summary>The possible contents of <see cref="DatabaseName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/databases/{database}</c>.</summary>
            ProjectDatabase = 1,
        }

        private static gax::PathTemplate s_projectDatabase = new gax::PathTemplate("projects/{project}/databases/{database}");

        /// <summary>Creates a <see cref="DatabaseName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DatabaseName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static DatabaseName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DatabaseName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DatabaseName"/> with the pattern <c>projects/{project}/databases/{database}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DatabaseName"/> constructed from the provided ids.</returns>
        public static DatabaseName FromProjectDatabase(string projectId, string databaseId) =>
            new DatabaseName(ResourceNameType.ProjectDatabase, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatabaseName"/> with pattern
        /// <c>projects/{project}/databases/{database}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatabaseName"/> with pattern
        /// <c>projects/{project}/databases/{database}</c>.
        /// </returns>
        public static string Format(string projectId, string databaseId) => FormatProjectDatabase(projectId, databaseId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DatabaseName"/> with pattern
        /// <c>projects/{project}/databases/{database}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DatabaseName"/> with pattern
        /// <c>projects/{project}/databases/{database}</c>.
        /// </returns>
        public static string FormatProjectDatabase(string projectId, string databaseId) =>
            s_projectDatabase.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)));

        /// <summary>Parses the given resource name string into a new <see cref="DatabaseName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/databases/{database}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="databaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatabaseName"/> if successful.</returns>
        public static DatabaseName Parse(string databaseName) => Parse(databaseName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DatabaseName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/databases/{database}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="databaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DatabaseName"/> if successful.</returns>
        public static DatabaseName Parse(string databaseName, bool allowUnparsed) =>
            TryParse(databaseName, allowUnparsed, out DatabaseName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatabaseName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/databases/{database}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="databaseName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DatabaseName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string databaseName, out DatabaseName result) => TryParse(databaseName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DatabaseName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/databases/{database}</c></description></item>
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
        /// When this method returns, the parsed <see cref="DatabaseName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string databaseName, bool allowUnparsed, out DatabaseName result)
        {
            gax::GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDatabase.TryParseName(databaseName, out resourceName))
            {
                result = FromProjectDatabase(resourceName[0], resourceName[1]);
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

        private DatabaseName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string databaseId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatabaseId = databaseId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DatabaseName"/> class from the component parts of pattern
        /// <c>projects/{project}/databases/{database}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        public DatabaseName(string projectId, string databaseId) : this(ResourceNameType.ProjectDatabase, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)))
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
                case ResourceNameType.ProjectDatabase: return s_projectDatabase.Expand(ProjectId, DatabaseId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DatabaseName);

        /// <inheritdoc/>
        public bool Equals(DatabaseName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DatabaseName a, DatabaseName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DatabaseName a, DatabaseName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Operation</c> resource.</summary>
    public sealed partial class OperationName : gax::IResourceName, sys::IEquatable<OperationName>
    {
        /// <summary>The possible contents of <see cref="OperationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/databases/{database}/operations/{operation}</c>.
            /// </summary>
            ProjectDatabaseOperation = 1,
        }

        private static gax::PathTemplate s_projectDatabaseOperation = new gax::PathTemplate("projects/{project}/databases/{database}/operations/{operation}");

        /// <summary>Creates a <see cref="OperationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OperationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OperationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OperationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OperationName"/> with the pattern
        /// <c>projects/{project}/databases/{database}/operations/{operation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operationId">The <c>Operation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="OperationName"/> constructed from the provided ids.</returns>
        public static OperationName FromProjectDatabaseOperation(string projectId, string databaseId, string operationId) =>
            new OperationName(ResourceNameType.ProjectDatabaseOperation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), operationId: gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OperationName"/> with pattern
        /// <c>projects/{project}/databases/{database}/operations/{operation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operationId">The <c>Operation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OperationName"/> with pattern
        /// <c>projects/{project}/databases/{database}/operations/{operation}</c>.
        /// </returns>
        public static string Format(string projectId, string databaseId, string operationId) =>
            FormatProjectDatabaseOperation(projectId, databaseId, operationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OperationName"/> with pattern
        /// <c>projects/{project}/databases/{database}/operations/{operation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operationId">The <c>Operation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OperationName"/> with pattern
        /// <c>projects/{project}/databases/{database}/operations/{operation}</c>.
        /// </returns>
        public static string FormatProjectDatabaseOperation(string projectId, string databaseId, string operationId) =>
            s_projectDatabaseOperation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)));

        /// <summary>Parses the given resource name string into a new <see cref="OperationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/databases/{database}/operations/{operation}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="operationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OperationName"/> if successful.</returns>
        public static OperationName Parse(string operationName) => Parse(operationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OperationName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/databases/{database}/operations/{operation}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="operationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OperationName"/> if successful.</returns>
        public static OperationName Parse(string operationName, bool allowUnparsed) =>
            TryParse(operationName, allowUnparsed, out OperationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OperationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/databases/{database}/operations/{operation}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="operationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OperationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string operationName, out OperationName result) => TryParse(operationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OperationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/databases/{database}/operations/{operation}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="operationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OperationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string operationName, bool allowUnparsed, out OperationName result)
        {
            gax::GaxPreconditions.CheckNotNull(operationName, nameof(operationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDatabaseOperation.TryParseName(operationName, out resourceName))
            {
                result = FromProjectDatabaseOperation(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(operationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OperationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string databaseId = null, string operationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatabaseId = databaseId;
            OperationId = operationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OperationName"/> class from the component parts of pattern
        /// <c>projects/{project}/databases/{database}/operations/{operation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="operationId">The <c>Operation</c> ID. Must not be <c>null</c> or empty.</param>
        public OperationName(string projectId, string databaseId, string operationId) : this(ResourceNameType.ProjectDatabaseOperation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), operationId: gax::GaxPreconditions.CheckNotNullOrEmpty(operationId, nameof(operationId)))
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
        /// The <c>Operation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string OperationId { get; }

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
                case ResourceNameType.ProjectDatabaseOperation: return s_projectDatabaseOperation.Expand(ProjectId, DatabaseId, OperationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OperationName);

        /// <inheritdoc/>
        public bool Equals(OperationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OperationName a, OperationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OperationName a, OperationName b) => !(a == b);
    }

    public partial class Database
    {
        /// <summary>
        /// <see cref="gcfav::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::DatabaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class SourceInfo
            {
                /// <summary>
                /// <see cref="OperationName"/>-typed view over the <see cref="Operation"/> resource name property.
                /// </summary>
                public OperationName OperationAsOperationName
                {
                    get => string.IsNullOrEmpty(Operation) ? null : OperationName.Parse(Operation, allowUnparsed: true);
                    set => Operation = value?.ToString() ?? "";
                }

                public partial class Types
                {
                    public partial class BackupSource
                    {
                        /// <summary>
                        /// <see cref="BackupName"/>-typed view over the <see cref="Backup"/> resource name property.
                        /// </summary>
                        public BackupName BackupAsBackupName
                        {
                            get => string.IsNullOrEmpty(Backup) ? null : BackupName.Parse(Backup, allowUnparsed: true);
                            set => Backup = value?.ToString() ?? "";
                        }
                    }
                }
            }
        }
    }
}
