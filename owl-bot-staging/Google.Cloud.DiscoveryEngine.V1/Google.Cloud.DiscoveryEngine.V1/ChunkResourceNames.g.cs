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
using gcdv = Google.Cloud.DiscoveryEngine.V1;
using sys = System;

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Resource name for the <c>Chunk</c> resource.</summary>
    public sealed partial class ChunkName : gax::IResourceName, sys::IEquatable<ChunkName>
    {
        /// <summary>The possible contents of <see cref="ChunkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
            /// .
            /// </summary>
            ProjectLocationDataStoreBranchDocumentChunk = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
            /// .
            /// </summary>
            ProjectLocationCollectionDataStoreBranchDocumentChunk = 2,
        }

        private static gax::PathTemplate s_projectLocationDataStoreBranchDocumentChunk = new gax::PathTemplate("projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}");

        private static gax::PathTemplate s_projectLocationCollectionDataStoreBranchDocumentChunk = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}");

        /// <summary>Creates a <see cref="ChunkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ChunkName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ChunkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ChunkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ChunkName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="branchId">The <c>Branch</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="chunkId">The <c>Chunk</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ChunkName"/> constructed from the provided ids.</returns>
        public static ChunkName FromProjectLocationDataStoreBranchDocumentChunk(string projectId, string locationId, string dataStoreId, string branchId, string documentId, string chunkId) =>
            new ChunkName(ResourceNameType.ProjectLocationDataStoreBranchDocumentChunk, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), branchId: gax::GaxPreconditions.CheckNotNullOrEmpty(branchId, nameof(branchId)), documentId: gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)), chunkId: gax::GaxPreconditions.CheckNotNullOrEmpty(chunkId, nameof(chunkId)));

        /// <summary>
        /// Creates a <see cref="ChunkName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="branchId">The <c>Branch</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="chunkId">The <c>Chunk</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ChunkName"/> constructed from the provided ids.</returns>
        public static ChunkName FromProjectLocationCollectionDataStoreBranchDocumentChunk(string projectId, string locationId, string collectionId, string dataStoreId, string branchId, string documentId, string chunkId) =>
            new ChunkName(ResourceNameType.ProjectLocationCollectionDataStoreBranchDocumentChunk, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), branchId: gax::GaxPreconditions.CheckNotNullOrEmpty(branchId, nameof(branchId)), documentId: gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)), chunkId: gax::GaxPreconditions.CheckNotNullOrEmpty(chunkId, nameof(chunkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChunkName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="branchId">The <c>Branch</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="chunkId">The <c>Chunk</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChunkName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string dataStoreId, string branchId, string documentId, string chunkId) =>
            FormatProjectLocationDataStoreBranchDocumentChunk(projectId, locationId, dataStoreId, branchId, documentId, chunkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChunkName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="branchId">The <c>Branch</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="chunkId">The <c>Chunk</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChunkName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationDataStoreBranchDocumentChunk(string projectId, string locationId, string dataStoreId, string branchId, string documentId, string chunkId) =>
            s_projectLocationDataStoreBranchDocumentChunk.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(branchId, nameof(branchId)), gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(chunkId, nameof(chunkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChunkName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="branchId">The <c>Branch</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="chunkId">The <c>Chunk</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChunkName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCollectionDataStoreBranchDocumentChunk(string projectId, string locationId, string collectionId, string dataStoreId, string branchId, string documentId, string chunkId) =>
            s_projectLocationCollectionDataStoreBranchDocumentChunk.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(branchId, nameof(branchId)), gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(chunkId, nameof(chunkId)));

        /// <summary>Parses the given resource name string into a new <see cref="ChunkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="chunkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ChunkName"/> if successful.</returns>
        public static ChunkName Parse(string chunkName) => Parse(chunkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ChunkName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="chunkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ChunkName"/> if successful.</returns>
        public static ChunkName Parse(string chunkName, bool allowUnparsed) =>
            TryParse(chunkName, allowUnparsed, out ChunkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChunkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="chunkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChunkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string chunkName, out ChunkName result) => TryParse(chunkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChunkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="chunkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChunkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string chunkName, bool allowUnparsed, out ChunkName result)
        {
            gax::GaxPreconditions.CheckNotNull(chunkName, nameof(chunkName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataStoreBranchDocumentChunk.TryParseName(chunkName, out resourceName))
            {
                result = FromProjectLocationDataStoreBranchDocumentChunk(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4], resourceName[5]);
                return true;
            }
            if (s_projectLocationCollectionDataStoreBranchDocumentChunk.TryParseName(chunkName, out resourceName))
            {
                result = FromProjectLocationCollectionDataStoreBranchDocumentChunk(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4], resourceName[5], resourceName[6]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(chunkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ChunkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string branchId = null, string chunkId = null, string collectionId = null, string dataStoreId = null, string documentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BranchId = branchId;
            ChunkId = chunkId;
            CollectionId = collectionId;
            DataStoreId = dataStoreId;
            DocumentId = documentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ChunkName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}/documents/{document}/chunks/{chunk}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="branchId">The <c>Branch</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="documentId">The <c>Document</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="chunkId">The <c>Chunk</c> ID. Must not be <c>null</c> or empty.</param>
        public ChunkName(string projectId, string locationId, string dataStoreId, string branchId, string documentId, string chunkId) : this(ResourceNameType.ProjectLocationDataStoreBranchDocumentChunk, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), branchId: gax::GaxPreconditions.CheckNotNullOrEmpty(branchId, nameof(branchId)), documentId: gax::GaxPreconditions.CheckNotNullOrEmpty(documentId, nameof(documentId)), chunkId: gax::GaxPreconditions.CheckNotNullOrEmpty(chunkId, nameof(chunkId)))
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
        /// The <c>Branch</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string BranchId { get; }

        /// <summary>
        /// The <c>Chunk</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ChunkId { get; }

        /// <summary>
        /// The <c>Collection</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string CollectionId { get; }

        /// <summary>
        /// The <c>DataStore</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string DataStoreId { get; }

        /// <summary>
        /// The <c>Document</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string DocumentId { get; }

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
                case ResourceNameType.ProjectLocationDataStoreBranchDocumentChunk: return s_projectLocationDataStoreBranchDocumentChunk.Expand(ProjectId, LocationId, DataStoreId, BranchId, DocumentId, ChunkId);
                case ResourceNameType.ProjectLocationCollectionDataStoreBranchDocumentChunk: return s_projectLocationCollectionDataStoreBranchDocumentChunk.Expand(ProjectId, LocationId, CollectionId, DataStoreId, BranchId, DocumentId, ChunkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ChunkName);

        /// <inheritdoc/>
        public bool Equals(ChunkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ChunkName a, ChunkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ChunkName a, ChunkName b) => !(a == b);
    }

    public partial class Chunk
    {
        /// <summary>
        /// <see cref="gcdv::ChunkName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ChunkName ChunkName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ChunkName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
