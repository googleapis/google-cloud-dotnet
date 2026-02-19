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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcvv = Google.Cloud.VectorSearch.V1;
using sys = System;

namespace Google.Cloud.VectorSearch.V1
{
    /// <summary>Resource name for the <c>Collection</c> resource.</summary>
    public sealed partial class CollectionName : gax::IResourceName, sys::IEquatable<CollectionName>
    {
        /// <summary>The possible contents of <see cref="CollectionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/collections/{collection}</c>.
            /// </summary>
            ProjectLocationCollection = 1,
        }

        private static gax::PathTemplate s_projectLocationCollection = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}");

        /// <summary>Creates a <see cref="CollectionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CollectionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CollectionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CollectionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CollectionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CollectionName"/> constructed from the provided ids.</returns>
        public static CollectionName FromProjectLocationCollection(string projectId, string locationId, string collectionId) =>
            new CollectionName(ResourceNameType.ProjectLocationCollection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CollectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CollectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string collectionId) =>
            FormatProjectLocationCollection(projectId, locationId, collectionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CollectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CollectionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}</c>.
        /// </returns>
        public static string FormatProjectLocationCollection(string projectId, string locationId, string collectionId) =>
            s_projectLocationCollection.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)));

        /// <summary>Parses the given resource name string into a new <see cref="CollectionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/collections/{collection}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="collectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CollectionName"/> if successful.</returns>
        public static CollectionName Parse(string collectionName) => Parse(collectionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CollectionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/collections/{collection}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="collectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CollectionName"/> if successful.</returns>
        public static CollectionName Parse(string collectionName, bool allowUnparsed) =>
            TryParse(collectionName, allowUnparsed, out CollectionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CollectionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/collections/{collection}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="collectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CollectionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string collectionName, out CollectionName result) =>
            TryParse(collectionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CollectionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/collections/{collection}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="collectionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CollectionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string collectionName, bool allowUnparsed, out CollectionName result)
        {
            gax::GaxPreconditions.CheckNotNull(collectionName, nameof(collectionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCollection.TryParseName(collectionName, out resourceName))
            {
                result = FromProjectLocationCollection(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(collectionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CollectionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string collectionId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CollectionId = collectionId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CollectionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        public CollectionName(string projectId, string locationId, string collectionId) : this(ResourceNameType.ProjectLocationCollection, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationCollection: return s_projectLocationCollection.Expand(ProjectId, LocationId, CollectionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CollectionName);

        /// <inheritdoc/>
        public bool Equals(CollectionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CollectionName a, CollectionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CollectionName a, CollectionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Index</c> resource.</summary>
    public sealed partial class IndexName : gax::IResourceName, sys::IEquatable<IndexName>
    {
        /// <summary>The possible contents of <see cref="IndexName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/collections/{collection}/indexes/{index}</c>.
            /// </summary>
            ProjectLocationCollectionIndex = 1,
        }

        private static gax::PathTemplate s_projectLocationCollectionIndex = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/indexes/{index}");

        /// <summary>Creates a <see cref="IndexName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="IndexName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static IndexName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new IndexName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="IndexName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/indexes/{index}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="indexId">The <c>Index</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="IndexName"/> constructed from the provided ids.</returns>
        public static IndexName FromProjectLocationCollectionIndex(string projectId, string locationId, string collectionId, string indexId) =>
            new IndexName(ResourceNameType.ProjectLocationCollectionIndex, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), indexId: gax::GaxPreconditions.CheckNotNullOrEmpty(indexId, nameof(indexId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IndexName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/indexes/{index}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="indexId">The <c>Index</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IndexName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/indexes/{index}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string collectionId, string indexId) =>
            FormatProjectLocationCollectionIndex(projectId, locationId, collectionId, indexId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="IndexName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/indexes/{index}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="indexId">The <c>Index</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="IndexName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/indexes/{index}</c>.
        /// </returns>
        public static string FormatProjectLocationCollectionIndex(string projectId, string locationId, string collectionId, string indexId) =>
            s_projectLocationCollectionIndex.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(indexId, nameof(indexId)));

        /// <summary>Parses the given resource name string into a new <see cref="IndexName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/indexes/{index}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="indexName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="IndexName"/> if successful.</returns>
        public static IndexName Parse(string indexName) => Parse(indexName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="IndexName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/indexes/{index}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="indexName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="IndexName"/> if successful.</returns>
        public static IndexName Parse(string indexName, bool allowUnparsed) =>
            TryParse(indexName, allowUnparsed, out IndexName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IndexName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/indexes/{index}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="indexName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IndexName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string indexName, out IndexName result) => TryParse(indexName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="IndexName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/indexes/{index}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="indexName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="IndexName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string indexName, bool allowUnparsed, out IndexName result)
        {
            gax::GaxPreconditions.CheckNotNull(indexName, nameof(indexName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCollectionIndex.TryParseName(indexName, out resourceName))
            {
                result = FromProjectLocationCollectionIndex(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(indexName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private IndexName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string collectionId = null, string indexId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CollectionId = collectionId;
            IndexId = indexId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="IndexName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/indexes/{index}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="indexId">The <c>Index</c> ID. Must not be <c>null</c> or empty.</param>
        public IndexName(string projectId, string locationId, string collectionId, string indexId) : this(ResourceNameType.ProjectLocationCollectionIndex, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), indexId: gax::GaxPreconditions.CheckNotNullOrEmpty(indexId, nameof(indexId)))
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
        /// The <c>Index</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string IndexId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

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
                case ResourceNameType.ProjectLocationCollectionIndex: return s_projectLocationCollectionIndex.Expand(ProjectId, LocationId, CollectionId, IndexId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as IndexName);

        /// <inheritdoc/>
        public bool Equals(IndexName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(IndexName a, IndexName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(IndexName a, IndexName b) => !(a == b);
    }

    public partial class Collection
    {
        /// <summary>
        /// <see cref="gcvv::CollectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::CollectionName CollectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::CollectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCollectionsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetCollectionRequest
    {
        /// <summary>
        /// <see cref="gcvv::CollectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::CollectionName CollectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::CollectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateCollectionRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteCollectionRequest
    {
        /// <summary>
        /// <see cref="gcvv::CollectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::CollectionName CollectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::CollectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Index
    {
        /// <summary>
        /// <see cref="gcvv::IndexName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::IndexName IndexName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::IndexName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateIndexRequest
    {
        /// <summary>
        /// <see cref="CollectionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CollectionName ParentAsCollectionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CollectionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteIndexRequest
    {
        /// <summary>
        /// <see cref="gcvv::IndexName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::IndexName IndexName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::IndexName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListIndexesRequest
    {
        /// <summary>
        /// <see cref="CollectionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public CollectionName ParentAsCollectionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : CollectionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetIndexRequest
    {
        /// <summary>
        /// <see cref="gcvv::IndexName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::IndexName IndexName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::IndexName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportDataObjectsRequest
    {
        /// <summary>
        /// <see cref="gcvv::CollectionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::CollectionName CollectionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::CollectionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
