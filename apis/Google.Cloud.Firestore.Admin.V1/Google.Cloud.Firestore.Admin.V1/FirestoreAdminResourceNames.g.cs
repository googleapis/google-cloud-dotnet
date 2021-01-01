// Copyright 2021 Google LLC
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

        /// <inheritdoc/>
        public static bool operator ==(DatabaseName a, DatabaseName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(DatabaseName a, DatabaseName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CollectionGroup</c> resource.</summary>
    public sealed partial class CollectionGroupName : gax::IResourceName, sys::IEquatable<CollectionGroupName>
    {
        /// <summary>The possible contents of <see cref="CollectionGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/databases/{database}/collectionGroups/{collection}</c>
            /// .
            /// </summary>
            ProjectDatabaseCollection = 1,
        }

        private static gax::PathTemplate s_projectDatabaseCollection = new gax::PathTemplate("projects/{project}/databases/{database}/collectionGroups/{collection}");

        /// <summary>Creates a <see cref="CollectionGroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CollectionGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CollectionGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CollectionGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CollectionGroupName"/> with the pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CollectionGroupName"/> constructed from the provided ids.</returns>
        public static CollectionGroupName FromProjectDatabaseCollection(string projectId, string databaseId, string collectionId) =>
            new CollectionGroupName(ResourceNameType.ProjectDatabaseCollection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CollectionGroupName"/> with pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CollectionGroupName"/> with pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}</c>.
        /// </returns>
        public static string Format(string projectId, string databaseId, string collectionId) =>
            FormatProjectDatabaseCollection(projectId, databaseId, collectionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CollectionGroupName"/> with pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CollectionGroupName"/> with pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}</c>.
        /// </returns>
        public static string FormatProjectDatabaseCollection(string projectId, string databaseId, string collectionId) =>
            s_projectDatabaseCollection.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CollectionGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/databases/{database}/collectionGroups/{collection}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="collectionGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CollectionGroupName"/> if successful.</returns>
        public static CollectionGroupName Parse(string collectionGroupName) => Parse(collectionGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CollectionGroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/databases/{database}/collectionGroups/{collection}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="collectionGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CollectionGroupName"/> if successful.</returns>
        public static CollectionGroupName Parse(string collectionGroupName, bool allowUnparsed) =>
            TryParse(collectionGroupName, allowUnparsed, out CollectionGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CollectionGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/databases/{database}/collectionGroups/{collection}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="collectionGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CollectionGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string collectionGroupName, out CollectionGroupName result) =>
            TryParse(collectionGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CollectionGroupName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/databases/{database}/collectionGroups/{collection}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="collectionGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CollectionGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string collectionGroupName, bool allowUnparsed, out CollectionGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(collectionGroupName, nameof(collectionGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectDatabaseCollection.TryParseName(collectionGroupName, out resourceName))
            {
                result = FromProjectDatabaseCollection(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(collectionGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CollectionGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string collectionId = null, string databaseId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CollectionId = collectionId;
            DatabaseId = databaseId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CollectionGroupName"/> class from the component parts of pattern
        /// <c>projects/{project}/databases/{database}/collectionGroups/{collection}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="databaseId">The <c>Database</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        public CollectionGroupName(string projectId, string databaseId, string collectionId) : this(ResourceNameType.ProjectDatabaseCollection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), databaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(databaseId, nameof(databaseId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)))
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
        /// The <c>Collection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CollectionId { get; }

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
                case ResourceNameType.ProjectDatabaseCollection: return s_projectDatabaseCollection.Expand(ProjectId, DatabaseId, CollectionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CollectionGroupName);

        /// <inheritdoc/>
        public bool Equals(CollectionGroupName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CollectionGroupName a, CollectionGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CollectionGroupName a, CollectionGroupName b) => !(a == b);
    }

    public partial class CreateIndexRequest
    {
        /// <summary>
        /// <see cref="CollectionGroupName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CollectionGroupName ParentAsCollectionGroupName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CollectionGroupName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListIndexesRequest
    {
        /// <summary>
        /// <see cref="CollectionGroupName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CollectionGroupName ParentAsCollectionGroupName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CollectionGroupName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetIndexRequest
    {
        /// <summary>
        /// <see cref="gcfav::IndexName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::IndexName IndexName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::IndexName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteIndexRequest
    {
        /// <summary>
        /// <see cref="gcfav::IndexName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::IndexName IndexName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::IndexName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetFieldRequest
    {
        /// <summary>
        /// <see cref="gcfav::FieldName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::FieldName FieldName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::FieldName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFieldsRequest
    {
        /// <summary>
        /// <see cref="CollectionGroupName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CollectionGroupName ParentAsCollectionGroupName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CollectionGroupName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ExportDocumentsRequest
    {
        /// <summary>
        /// <see cref="gcfav::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::DatabaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportDocumentsRequest
    {
        /// <summary>
        /// <see cref="gcfav::DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcfav::DatabaseName DatabaseName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcfav::DatabaseName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
