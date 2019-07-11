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
using sys = System;
using linq = System.Linq;

namespace Google.Cloud.Firestore.Admin.V1
{
    /// <summary>
    /// Resource name for the 'database' resource.
    /// </summary>
    public sealed partial class DatabaseName : gax::IResourceName, sys::IEquatable<DatabaseName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/databases/{database}");

        /// <summary>
        /// Parses the given database resource name in string form into a new
        /// <see cref="DatabaseName"/> instance.
        /// </summary>
        /// <param name="databaseName">The database resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatabaseName"/> if successful.</returns>
        public static DatabaseName Parse(string databaseName)
        {
            gax::GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(databaseName);
            return new DatabaseName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given database resource name in string form into a new
        /// <see cref="DatabaseName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="databaseName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="databaseName">The database resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DatabaseName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string databaseName, out DatabaseName result)
        {
            gax::GaxPreconditions.CheckNotNull(databaseName, nameof(databaseName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(databaseName, out resourceName))
            {
                result = new DatabaseName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="DatabaseName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The <c>database</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="DatabaseName"/>.</returns>
        public static string Format(string projectId, string databaseId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="DatabaseName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The database ID. Must not be <c>null</c>.</param>
        public DatabaseName(string projectId, string databaseId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            DatabaseId = gax::GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The database ID. Never <c>null</c>.
        /// </summary>
        public string DatabaseId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, DatabaseId);

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
    /// Resource name for the 'field' resource.
    /// </summary>
    public sealed partial class FieldName : gax::IResourceName, sys::IEquatable<FieldName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/databases/{database}/collectionGroups/{collection_id}/fields/{field_id}");

        /// <summary>
        /// Parses the given field resource name in string form into a new
        /// <see cref="FieldName"/> instance.
        /// </summary>
        /// <param name="fieldName">The field resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FieldName"/> if successful.</returns>
        public static FieldName Parse(string fieldName)
        {
            gax::GaxPreconditions.CheckNotNull(fieldName, nameof(fieldName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(fieldName);
            return new FieldName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given field resource name in string form into a new
        /// <see cref="FieldName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="fieldName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="fieldName">The field resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="FieldName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fieldName, out FieldName result)
        {
            gax::GaxPreconditions.CheckNotNull(fieldName, nameof(fieldName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(fieldName, out resourceName))
            {
                result = new FieldName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="FieldName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The <c>database</c> ID. Must not be <c>null</c>.</param>
        /// <param name="collectionId">The <c>collection</c> ID. Must not be <c>null</c>.</param>
        /// <param name="fieldId">The <c>field</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="FieldName"/>.</returns>
        public static string Format(string projectId, string databaseId, string collectionId, string fieldId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId)), gax::GaxPreconditions.CheckNotNull(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNull(fieldId, nameof(fieldId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="FieldName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The database ID. Must not be <c>null</c>.</param>
        /// <param name="collectionId">The collection ID. Must not be <c>null</c>.</param>
        /// <param name="fieldId">The field ID. Must not be <c>null</c>.</param>
        public FieldName(string projectId, string databaseId, string collectionId, string fieldId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            DatabaseId = gax::GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId));
            CollectionId = gax::GaxPreconditions.CheckNotNull(collectionId, nameof(collectionId));
            FieldId = gax::GaxPreconditions.CheckNotNull(fieldId, nameof(fieldId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The database ID. Never <c>null</c>.
        /// </summary>
        public string DatabaseId { get; }

        /// <summary>
        /// The collection ID. Never <c>null</c>.
        /// </summary>
        public string CollectionId { get; }

        /// <summary>
        /// The field ID. Never <c>null</c>.
        /// </summary>
        public string FieldId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, DatabaseId, CollectionId, FieldId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as FieldName);

        /// <inheritdoc />
        public bool Equals(FieldName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(FieldName a, FieldName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(FieldName a, FieldName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'index' resource.
    /// </summary>
    public sealed partial class IndexName : gax::IResourceName, sys::IEquatable<IndexName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/databases/{database}/collectionGroups/{collection_id}/indexes/{index_id}");

        /// <summary>
        /// Parses the given index resource name in string form into a new
        /// <see cref="IndexName"/> instance.
        /// </summary>
        /// <param name="indexName">The index resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IndexName"/> if successful.</returns>
        public static IndexName Parse(string indexName)
        {
            gax::GaxPreconditions.CheckNotNull(indexName, nameof(indexName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(indexName);
            return new IndexName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given index resource name in string form into a new
        /// <see cref="IndexName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="indexName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="indexName">The index resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="IndexName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string indexName, out IndexName result)
        {
            gax::GaxPreconditions.CheckNotNull(indexName, nameof(indexName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(indexName, out resourceName))
            {
                result = new IndexName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="IndexName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The <c>database</c> ID. Must not be <c>null</c>.</param>
        /// <param name="collectionId">The <c>collection</c> ID. Must not be <c>null</c>.</param>
        /// <param name="indexId">The <c>index</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="IndexName"/>.</returns>
        public static string Format(string projectId, string databaseId, string collectionId, string indexId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId)), gax::GaxPreconditions.CheckNotNull(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNull(indexId, nameof(indexId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="IndexName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The database ID. Must not be <c>null</c>.</param>
        /// <param name="collectionId">The collection ID. Must not be <c>null</c>.</param>
        /// <param name="indexId">The index ID. Must not be <c>null</c>.</param>
        public IndexName(string projectId, string databaseId, string collectionId, string indexId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            DatabaseId = gax::GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId));
            CollectionId = gax::GaxPreconditions.CheckNotNull(collectionId, nameof(collectionId));
            IndexId = gax::GaxPreconditions.CheckNotNull(indexId, nameof(indexId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The database ID. Never <c>null</c>.
        /// </summary>
        public string DatabaseId { get; }

        /// <summary>
        /// The collection ID. Never <c>null</c>.
        /// </summary>
        public string CollectionId { get; }

        /// <summary>
        /// The index ID. Never <c>null</c>.
        /// </summary>
        public string IndexId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, DatabaseId, CollectionId, IndexId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as IndexName);

        /// <inheritdoc />
        public bool Equals(IndexName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(IndexName a, IndexName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(IndexName a, IndexName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'parent' resource.
    /// </summary>
    public sealed partial class ParentName : gax::IResourceName, sys::IEquatable<ParentName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/databases/{database}/collectionGroups/{collection_id}");

        /// <summary>
        /// Parses the given parent resource name in string form into a new
        /// <see cref="ParentName"/> instance.
        /// </summary>
        /// <param name="parentName">The parent resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ParentName"/> if successful.</returns>
        public static ParentName Parse(string parentName)
        {
            gax::GaxPreconditions.CheckNotNull(parentName, nameof(parentName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(parentName);
            return new ParentName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given parent resource name in string form into a new
        /// <see cref="ParentName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="parentName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="parentName">The parent resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ParentName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string parentName, out ParentName result)
        {
            gax::GaxPreconditions.CheckNotNull(parentName, nameof(parentName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(parentName, out resourceName))
            {
                result = new ParentName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="ParentName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The <c>database</c> ID. Must not be <c>null</c>.</param>
        /// <param name="collectionId">The <c>collection</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="ParentName"/>.</returns>
        public static string Format(string projectId, string databaseId, string collectionId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId)), gax::GaxPreconditions.CheckNotNull(collectionId, nameof(collectionId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="ParentName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The database ID. Must not be <c>null</c>.</param>
        /// <param name="collectionId">The collection ID. Must not be <c>null</c>.</param>
        public ParentName(string projectId, string databaseId, string collectionId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            DatabaseId = gax::GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId));
            CollectionId = gax::GaxPreconditions.CheckNotNull(collectionId, nameof(collectionId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The database ID. Never <c>null</c>.
        /// </summary>
        public string DatabaseId { get; }

        /// <summary>
        /// The collection ID. Never <c>null</c>.
        /// </summary>
        public string CollectionId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, DatabaseId, CollectionId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ParentName);

        /// <inheritdoc />
        public bool Equals(ParentName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ParentName a, ParentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ParentName a, ParentName b) => !(a == b);
    }


    public partial class CreateIndexRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Firestore.Admin.V1.ParentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Firestore.Admin.V1.ParentName ParentAsParentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Firestore.Admin.V1.ParentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteIndexRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Firestore.Admin.V1.IndexName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Firestore.Admin.V1.IndexName IndexName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Firestore.Admin.V1.IndexName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ExportDocumentsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Firestore.Admin.V1.DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Firestore.Admin.V1.DatabaseName DatabaseName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Firestore.Admin.V1.DatabaseName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetFieldRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Firestore.Admin.V1.FieldName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Firestore.Admin.V1.FieldName FieldName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Firestore.Admin.V1.FieldName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetIndexRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Firestore.Admin.V1.IndexName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Firestore.Admin.V1.IndexName IndexName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Firestore.Admin.V1.IndexName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ImportDocumentsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Firestore.Admin.V1.DatabaseName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Firestore.Admin.V1.DatabaseName DatabaseName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Firestore.Admin.V1.DatabaseName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListFieldsRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Firestore.Admin.V1.ParentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Firestore.Admin.V1.ParentName ParentAsParentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Firestore.Admin.V1.ParentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListIndexesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Firestore.Admin.V1.ParentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Firestore.Admin.V1.ParentName ParentAsParentName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Firestore.Admin.V1.ParentName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

}