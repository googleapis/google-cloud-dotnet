// Copyright 2026 Google LLC
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
using gdkv = Google.Developers.Knowledge.V1;
using sys = System;

namespace Google.Developers.Knowledge.V1
{
    /// <summary>Resource name for the <c>Document</c> resource.</summary>
    public sealed partial class DocumentName : gax::IResourceName, sys::IEquatable<DocumentName>
    {
        /// <summary>The possible contents of <see cref="DocumentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>documents/{document}</c>.</summary>
            Document = 1,
        }

        private static gax::PathTemplate s_document = new gax::PathTemplate("documents/{document}");

        /// <summary>Creates a <see cref="DocumentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DocumentName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static DocumentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DocumentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="DocumentName"/> with the pattern <c>documents/{document}</c>.</summary>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DocumentName"/> constructed from the provided ids.</returns>
        public static DocumentName FromDocument(string documentId) =>
            new DocumentName(ResourceNameType.Document, documentId: gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DocumentName"/> with pattern
        /// <c>documents/{document}</c>.
        /// </summary>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DocumentName"/> with pattern <c>documents/{document}</c>.
        /// </returns>
        public static string Format(string documentId) => FormatDocument(documentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DocumentName"/> with pattern
        /// <c>documents/{document}</c>.
        /// </summary>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DocumentName"/> with pattern <c>documents/{document}</c>.
        /// </returns>
        public static string FormatDocument(string documentId) =>
            s_document.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)));

        /// <summary>Parses the given resource name string into a new <see cref="DocumentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>documents/{document}</c></description></item></list>
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
        /// <list type="bullet"><item><description><c>documents/{document}</c></description></item></list>
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
        /// <list type="bullet"><item><description><c>documents/{document}</c></description></item></list>
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
        /// <list type="bullet"><item><description><c>documents/{document}</c></description></item></list>
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
            if (s_document.TryParseName(documentName, out resourceName))
            {
                result = FromDocument(resourceName[0]);
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

        private DocumentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string documentId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DocumentId = documentId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DocumentName"/> class from the component parts of pattern
        /// <c>documents/{document}</c>
        /// </summary>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        public DocumentName(string documentId) : this(ResourceNameType.Document, documentId: gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)))
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
        /// The <c>Document</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DocumentId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Document: return s_document.Expand(DocumentId);
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
        /// <see cref="gdkv::DocumentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdkv::DocumentName DocumentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdkv::DocumentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDocumentRequest
    {
        /// <summary>
        /// <see cref="gdkv::DocumentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gdkv::DocumentName DocumentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gdkv::DocumentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchGetDocumentsRequest
    {
        /// <summary>
        /// <see cref="DocumentName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<DocumentName> DocumentNames
        {
            get => new gax::ResourceNameList<DocumentName>(Names, s => string.IsNullOrEmpty(s) ? null : DocumentName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class DocumentChunk
    {
        /// <summary>
        /// <see cref="DocumentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DocumentName ParentAsDocumentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DocumentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
