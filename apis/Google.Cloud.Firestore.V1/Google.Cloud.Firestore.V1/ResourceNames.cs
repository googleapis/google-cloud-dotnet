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

namespace Google.Cloud.Firestore.V1
{
    /// <summary>
    /// Resource name for the 'any_path' resource.
    /// </summary>
    public sealed partial class AnyPathName : gax::IResourceName, sys::IEquatable<AnyPathName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/databases/{database}/documents/{document}/{any_path=**}");

        /// <summary>
        /// Parses the given any_path resource name in string form into a new
        /// <see cref="AnyPathName"/> instance.
        /// </summary>
        /// <param name="anyPathName">The any_path resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AnyPathName"/> if successful.</returns>
        public static AnyPathName Parse(string anyPathName)
        {
            gax::GaxPreconditions.CheckNotNull(anyPathName, nameof(anyPathName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(anyPathName);
            return new AnyPathName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given any_path resource name in string form into a new
        /// <see cref="AnyPathName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="anyPathName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="anyPathName">The any_path resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AnyPathName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string anyPathName, out AnyPathName result)
        {
            gax::GaxPreconditions.CheckNotNull(anyPathName, nameof(anyPathName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(anyPathName, out resourceName))
            {
                result = new AnyPathName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="AnyPathName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The <c>database</c> ID. Must not be <c>null</c>.</param>
        /// <param name="documentId">The <c>document</c> ID. Must not be <c>null</c>.</param>
        /// <param name="anyPathId">The <c>anyPath</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="AnyPathName"/>.</returns>
        public static string Format(string projectId, string databaseId, string documentId, string anyPathId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId)), gax::GaxPreconditions.CheckNotNull(documentId, nameof(documentId)), gax::GaxPreconditions.CheckNotNull(anyPathId, nameof(anyPathId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="AnyPathName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The database ID. Must not be <c>null</c>.</param>
        /// <param name="documentId">The document ID. Must not be <c>null</c>.</param>
        /// <param name="anyPathId">The anyPath ID. Must not be <c>null</c>.</param>
        public AnyPathName(string projectId, string databaseId, string documentId, string anyPathId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            DatabaseId = gax::GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId));
            DocumentId = gax::GaxPreconditions.CheckNotNull(documentId, nameof(documentId));
            AnyPathId = gax::GaxPreconditions.CheckNotNull(anyPathId, nameof(anyPathId));
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
        /// The document ID. Never <c>null</c>.
        /// </summary>
        public string DocumentId { get; }

        /// <summary>
        /// The anyPath ID. Never <c>null</c>.
        /// </summary>
        public string AnyPathId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, DatabaseId, DocumentId, AnyPathId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AnyPathName);

        /// <inheritdoc />
        public bool Equals(AnyPathName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AnyPathName a, AnyPathName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AnyPathName a, AnyPathName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'database_root' resource.
    /// </summary>
    public sealed partial class DatabaseRootName : gax::IResourceName, sys::IEquatable<DatabaseRootName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/databases/{database}");

        /// <summary>
        /// Parses the given database_root resource name in string form into a new
        /// <see cref="DatabaseRootName"/> instance.
        /// </summary>
        /// <param name="databaseRootName">The database_root resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DatabaseRootName"/> if successful.</returns>
        public static DatabaseRootName Parse(string databaseRootName)
        {
            gax::GaxPreconditions.CheckNotNull(databaseRootName, nameof(databaseRootName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(databaseRootName);
            return new DatabaseRootName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given database_root resource name in string form into a new
        /// <see cref="DatabaseRootName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="databaseRootName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="databaseRootName">The database_root resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DatabaseRootName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string databaseRootName, out DatabaseRootName result)
        {
            gax::GaxPreconditions.CheckNotNull(databaseRootName, nameof(databaseRootName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(databaseRootName, out resourceName))
            {
                result = new DatabaseRootName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="DatabaseRootName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The <c>database</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="DatabaseRootName"/>.</returns>
        public static string Format(string projectId, string databaseId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="DatabaseRootName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The database ID. Must not be <c>null</c>.</param>
        public DatabaseRootName(string projectId, string databaseId)
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
        public override bool Equals(object obj) => Equals(obj as DatabaseRootName);

        /// <inheritdoc />
        public bool Equals(DatabaseRootName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DatabaseRootName a, DatabaseRootName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DatabaseRootName a, DatabaseRootName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'document_path' resource.
    /// </summary>
    public sealed partial class DocumentPathName : gax::IResourceName, sys::IEquatable<DocumentPathName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/databases/{database}/documents/{document_path=**}");

        /// <summary>
        /// Parses the given document_path resource name in string form into a new
        /// <see cref="DocumentPathName"/> instance.
        /// </summary>
        /// <param name="documentPathName">The document_path resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DocumentPathName"/> if successful.</returns>
        public static DocumentPathName Parse(string documentPathName)
        {
            gax::GaxPreconditions.CheckNotNull(documentPathName, nameof(documentPathName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(documentPathName);
            return new DocumentPathName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given document_path resource name in string form into a new
        /// <see cref="DocumentPathName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="documentPathName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="documentPathName">The document_path resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DocumentPathName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string documentPathName, out DocumentPathName result)
        {
            gax::GaxPreconditions.CheckNotNull(documentPathName, nameof(documentPathName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(documentPathName, out resourceName))
            {
                result = new DocumentPathName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="DocumentPathName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The <c>database</c> ID. Must not be <c>null</c>.</param>
        /// <param name="documentPathId">The <c>documentPath</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="DocumentPathName"/>.</returns>
        public static string Format(string projectId, string databaseId, string documentPathId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId)), gax::GaxPreconditions.CheckNotNull(documentPathId, nameof(documentPathId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="DocumentPathName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The database ID. Must not be <c>null</c>.</param>
        /// <param name="documentPathId">The documentPath ID. Must not be <c>null</c>.</param>
        public DocumentPathName(string projectId, string databaseId, string documentPathId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            DatabaseId = gax::GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId));
            DocumentPathId = gax::GaxPreconditions.CheckNotNull(documentPathId, nameof(documentPathId));
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
        /// The documentPath ID. Never <c>null</c>.
        /// </summary>
        public string DocumentPathId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, DatabaseId, DocumentPathId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DocumentPathName);

        /// <inheritdoc />
        public bool Equals(DocumentPathName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DocumentPathName a, DocumentPathName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DocumentPathName a, DocumentPathName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'document_root' resource.
    /// </summary>
    public sealed partial class DocumentRootName : gax::IResourceName, sys::IEquatable<DocumentRootName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/databases/{database}/documents");

        /// <summary>
        /// Parses the given document_root resource name in string form into a new
        /// <see cref="DocumentRootName"/> instance.
        /// </summary>
        /// <param name="documentRootName">The document_root resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DocumentRootName"/> if successful.</returns>
        public static DocumentRootName Parse(string documentRootName)
        {
            gax::GaxPreconditions.CheckNotNull(documentRootName, nameof(documentRootName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(documentRootName);
            return new DocumentRootName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given document_root resource name in string form into a new
        /// <see cref="DocumentRootName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="documentRootName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="documentRootName">The document_root resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DocumentRootName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string documentRootName, out DocumentRootName result)
        {
            gax::GaxPreconditions.CheckNotNull(documentRootName, nameof(documentRootName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(documentRootName, out resourceName))
            {
                result = new DocumentRootName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="DocumentRootName"/>.</summary>
        /// <param name="projectId">The <c>project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The <c>database</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="DocumentRootName"/>.</returns>
        public static string Format(string projectId, string databaseId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(databaseId, nameof(databaseId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="DocumentRootName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="databaseId">The database ID. Must not be <c>null</c>.</param>
        public DocumentRootName(string projectId, string databaseId)
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
        public override bool Equals(object obj) => Equals(obj as DocumentRootName);

        /// <inheritdoc />
        public bool Equals(DocumentRootName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DocumentRootName a, DocumentRootName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DocumentRootName a, DocumentRootName b) => !(a == b);
    }


    public partial class DeleteDocumentRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Firestore.V1.AnyPathName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Firestore.V1.AnyPathName AnyPathName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Firestore.V1.AnyPathName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetDocumentRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Firestore.V1.AnyPathName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Firestore.V1.AnyPathName AnyPathName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Firestore.V1.AnyPathName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}