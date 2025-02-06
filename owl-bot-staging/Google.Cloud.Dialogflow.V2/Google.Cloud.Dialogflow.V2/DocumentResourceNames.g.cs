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
using gcdv = Google.Cloud.Dialogflow.V2;
using sys = System;

namespace Google.Cloud.Dialogflow.V2
{
    /// <summary>Resource name for the <c>Document</c> resource.</summary>
    public sealed partial class DocumentName : gax::IResourceName, sys::IEquatable<DocumentName>
    {
        /// <summary>The possible contents of <see cref="DocumentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/knowledgeBases/{knowledge_base}/documents/{document}</c>
            /// .
            /// </summary>
            ProjectKnowledgeBaseDocument = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/knowledgeBases/{knowledge_base}/documents/{document}</c>.
            /// </summary>
            ProjectLocationKnowledgeBaseDocument = 2,
        }

        private static gax::PathTemplate s_projectKnowledgeBaseDocument = new gax::PathTemplate("projects/{project}/knowledgeBases/{knowledge_base}/documents/{document}");

        private static gax::PathTemplate s_projectLocationKnowledgeBaseDocument = new gax::PathTemplate("projects/{project}/locations/{location}/knowledgeBases/{knowledge_base}/documents/{document}");

        /// <summary>Creates a <see cref="DocumentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DocumentName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static DocumentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DocumentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DocumentName"/> with the pattern
        /// <c>projects/{project}/knowledgeBases/{knowledge_base}/documents/{document}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="knowledgeBaseId">The <c>KnowledgeBase</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DocumentName"/> constructed from the provided ids.</returns>
        public static DocumentName FromProjectKnowledgeBaseDocument(string projectId, string knowledgeBaseId, string documentId) =>
            new DocumentName(ResourceNameType.ProjectKnowledgeBaseDocument, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), knowledgeBaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(knowledgeBaseId, nameof(knowledgeBaseId)), documentId: gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)));

        /// <summary>
        /// Creates a <see cref="DocumentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/knowledgeBases/{knowledge_base}/documents/{document}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="knowledgeBaseId">The <c>KnowledgeBase</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DocumentName"/> constructed from the provided ids.</returns>
        public static DocumentName FromProjectLocationKnowledgeBaseDocument(string projectId, string locationId, string knowledgeBaseId, string documentId) =>
            new DocumentName(ResourceNameType.ProjectLocationKnowledgeBaseDocument, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), knowledgeBaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(knowledgeBaseId, nameof(knowledgeBaseId)), documentId: gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DocumentName"/> with pattern
        /// <c>projects/{project}/knowledgeBases/{knowledge_base}/documents/{document}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="knowledgeBaseId">The <c>KnowledgeBase</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DocumentName"/> with pattern
        /// <c>projects/{project}/knowledgeBases/{knowledge_base}/documents/{document}</c>.
        /// </returns>
        public static string Format(string projectId, string knowledgeBaseId, string documentId) =>
            FormatProjectKnowledgeBaseDocument(projectId, knowledgeBaseId, documentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DocumentName"/> with pattern
        /// <c>projects/{project}/knowledgeBases/{knowledge_base}/documents/{document}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="knowledgeBaseId">The <c>KnowledgeBase</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DocumentName"/> with pattern
        /// <c>projects/{project}/knowledgeBases/{knowledge_base}/documents/{document}</c>.
        /// </returns>
        public static string FormatProjectKnowledgeBaseDocument(string projectId, string knowledgeBaseId, string documentId) =>
            s_projectKnowledgeBaseDocument.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(knowledgeBaseId, nameof(knowledgeBaseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DocumentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/knowledgeBases/{knowledge_base}/documents/{document}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="knowledgeBaseId">The <c>KnowledgeBase</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DocumentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/knowledgeBases/{knowledge_base}/documents/{document}</c>.
        /// </returns>
        public static string FormatProjectLocationKnowledgeBaseDocument(string projectId, string locationId, string knowledgeBaseId, string documentId) =>
            s_projectLocationKnowledgeBaseDocument.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(knowledgeBaseId, nameof(knowledgeBaseId)), gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)));

        /// <summary>Parses the given resource name string into a new <see cref="DocumentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/knowledgeBases/{knowledge_base}/documents/{document}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/knowledgeBases/{knowledge_base}/documents/{document}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="documentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DocumentName"/> if successful.</returns>
        public static DocumentName Parse(string documentName) => Parse(documentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DocumentName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/knowledgeBases/{knowledge_base}/documents/{document}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/knowledgeBases/{knowledge_base}/documents/{document}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="documentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DocumentName"/> if successful.</returns>
        public static DocumentName Parse(string documentName, bool allowUnparsed) =>
            TryParse(documentName, allowUnparsed, out DocumentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DocumentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/knowledgeBases/{knowledge_base}/documents/{document}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/knowledgeBases/{knowledge_base}/documents/{document}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="documentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DocumentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string documentName, out DocumentName result) => TryParse(documentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DocumentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/knowledgeBases/{knowledge_base}/documents/{document}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/knowledgeBases/{knowledge_base}/documents/{document}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="documentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DocumentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string documentName, bool allowUnparsed, out DocumentName result)
        {
            gax::GaxPreconditions.CheckNotNull(documentName, nameof(documentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectKnowledgeBaseDocument.TryParseName(documentName, out resourceName))
            {
                result = FromProjectKnowledgeBaseDocument(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationKnowledgeBaseDocument.TryParseName(documentName, out resourceName))
            {
                result = FromProjectLocationKnowledgeBaseDocument(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(documentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DocumentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string documentId = null, string knowledgeBaseId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DocumentId = documentId;
            KnowledgeBaseId = knowledgeBaseId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DocumentName"/> class from the component parts of pattern
        /// <c>projects/{project}/knowledgeBases/{knowledge_base}/documents/{document}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="knowledgeBaseId">The <c>KnowledgeBase</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        public DocumentName(string projectId, string knowledgeBaseId, string documentId) : this(ResourceNameType.ProjectKnowledgeBaseDocument, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), knowledgeBaseId: gax::GaxPreconditions.CheckNotNullOrEmpty(knowledgeBaseId, nameof(knowledgeBaseId)), documentId: gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)))
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
        /// The <c>Document</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string DocumentId { get; }

        /// <summary>
        /// The <c>KnowledgeBase</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string KnowledgeBaseId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.ProjectKnowledgeBaseDocument: return s_projectKnowledgeBaseDocument.Expand(ProjectId, KnowledgeBaseId, DocumentId);
                case ResourceNameType.ProjectLocationKnowledgeBaseDocument: return s_projectLocationKnowledgeBaseDocument.Expand(ProjectId, LocationId, KnowledgeBaseId, DocumentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DocumentName);

        /// <inheritdoc/>
        public bool Equals(DocumentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DocumentName a, DocumentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DocumentName a, DocumentName b) => !(a == b);
    }

    public partial class Document
    {
        /// <summary>
        /// <see cref="gcdv::DocumentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DocumentName DocumentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DocumentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDocumentRequest
    {
        /// <summary>
        /// <see cref="gcdv::DocumentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DocumentName DocumentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DocumentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDocumentsRequest
    {
        /// <summary>
        /// <see cref="KnowledgeBaseName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public KnowledgeBaseName ParentAsKnowledgeBaseName
        {
            get => string.IsNullOrEmpty(Parent) ? null : KnowledgeBaseName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateDocumentRequest
    {
        /// <summary>
        /// <see cref="KnowledgeBaseName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public KnowledgeBaseName ParentAsKnowledgeBaseName
        {
            get => string.IsNullOrEmpty(Parent) ? null : KnowledgeBaseName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ImportDocumentsRequest
    {
        /// <summary>
        /// <see cref="KnowledgeBaseName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public KnowledgeBaseName ParentAsKnowledgeBaseName
        {
            get => string.IsNullOrEmpty(Parent) ? null : KnowledgeBaseName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDocumentRequest
    {
        /// <summary>
        /// <see cref="gcdv::DocumentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DocumentName DocumentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DocumentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReloadDocumentRequest
    {
        /// <summary>
        /// <see cref="gcdv::DocumentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DocumentName DocumentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DocumentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExportDocumentRequest
    {
        /// <summary>
        /// <see cref="gcdv::DocumentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DocumentName DocumentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DocumentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
