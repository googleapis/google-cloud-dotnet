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
using sys = System;

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Resource name for the <c>Branch</c> resource.</summary>
    public sealed partial class BranchName : gax::IResourceName, sys::IEquatable<BranchName>
    {
        /// <summary>The possible contents of <see cref="BranchName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}</c>.
            /// </summary>
            ProjectLocationDataStoreBranch = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}</c>
            /// .
            /// </summary>
            ProjectLocationCollectionDataStoreBranch = 2,
        }

        private static gax::PathTemplate s_projectLocationDataStoreBranch = new gax::PathTemplate("projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}");

        private static gax::PathTemplate s_projectLocationCollectionDataStoreBranch = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}");

        /// <summary>Creates a <see cref="BranchName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BranchName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BranchName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BranchName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BranchName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="branchId">The <c>Branch</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BranchName"/> constructed from the provided ids.</returns>
        public static BranchName FromProjectLocationDataStoreBranch(string projectId, string locationId, string dataStoreId, string branchId) =>
            new BranchName(ResourceNameType.ProjectLocationDataStoreBranch, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), branchId: gax::GaxPreconditions.CheckNotNullOrEmpty(branchId, nameof(branchId)));

        /// <summary>
        /// Creates a <see cref="BranchName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="branchId">The <c>Branch</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="BranchName"/> constructed from the provided ids.</returns>
        public static BranchName FromProjectLocationCollectionDataStoreBranch(string projectId, string locationId, string collectionId, string dataStoreId, string branchId) =>
            new BranchName(ResourceNameType.ProjectLocationCollectionDataStoreBranch, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), branchId: gax::GaxPreconditions.CheckNotNullOrEmpty(branchId, nameof(branchId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BranchName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="branchId">The <c>Branch</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BranchName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataStoreId, string branchId) =>
            FormatProjectLocationDataStoreBranch(projectId, locationId, dataStoreId, branchId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BranchName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="branchId">The <c>Branch</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BranchName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}</c>.
        /// </returns>
        public static string FormatProjectLocationDataStoreBranch(string projectId, string locationId, string dataStoreId, string branchId) =>
            s_projectLocationDataStoreBranch.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(branchId, nameof(branchId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BranchName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="branchId">The <c>Branch</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BranchName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCollectionDataStoreBranch(string projectId, string locationId, string collectionId, string dataStoreId, string branchId) =>
            s_projectLocationCollectionDataStoreBranch.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(branchId, nameof(branchId)));

        /// <summary>Parses the given resource name string into a new <see cref="BranchName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="branchName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BranchName"/> if successful.</returns>
        public static BranchName Parse(string branchName) => Parse(branchName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BranchName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="branchName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BranchName"/> if successful.</returns>
        public static BranchName Parse(string branchName, bool allowUnparsed) =>
            TryParse(branchName, allowUnparsed, out BranchName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BranchName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="branchName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BranchName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string branchName, out BranchName result) => TryParse(branchName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BranchName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/branches/{branch}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="branchName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BranchName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string branchName, bool allowUnparsed, out BranchName result)
        {
            gax::GaxPreconditions.CheckNotNull(branchName, nameof(branchName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataStoreBranch.TryParseName(branchName, out resourceName))
            {
                result = FromProjectLocationDataStoreBranch(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectLocationCollectionDataStoreBranch.TryParseName(branchName, out resourceName))
            {
                result = FromProjectLocationCollectionDataStoreBranch(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(branchName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BranchName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string branchId = null, string collectionId = null, string dataStoreId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BranchId = branchId;
            CollectionId = collectionId;
            DataStoreId = dataStoreId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BranchName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/branches/{branch}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="branchId">The <c>Branch</c> ID. Must not be <c>null</c> or empty.</param>
        public BranchName(string projectId, string locationId, string dataStoreId, string branchId) : this(ResourceNameType.ProjectLocationDataStoreBranch, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), branchId: gax::GaxPreconditions.CheckNotNullOrEmpty(branchId, nameof(branchId)))
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
        /// The <c>Collection</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string CollectionId { get; }

        /// <summary>
        /// The <c>DataStore</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string DataStoreId { get; }

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
                case ResourceNameType.ProjectLocationDataStoreBranch: return s_projectLocationDataStoreBranch.Expand(ProjectId, LocationId, DataStoreId, BranchId);
                case ResourceNameType.ProjectLocationCollectionDataStoreBranch: return s_projectLocationCollectionDataStoreBranch.Expand(ProjectId, LocationId, CollectionId, DataStoreId, BranchId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BranchName);

        /// <inheritdoc/>
        public bool Equals(BranchName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BranchName a, BranchName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BranchName a, BranchName b) => !(a == b);
    }

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

    /// <summary>Resource name for the <c>Location</c> resource.</summary>
    public sealed partial class LocationName : gax::IResourceName, sys::IEquatable<LocationName>
    {
        /// <summary>The possible contents of <see cref="LocationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/locations/{location}</c>.</summary>
            ProjectLocation = 1,
        }

        private static gax::PathTemplate s_projectLocation = new gax::PathTemplate("projects/{project}/locations/{location}");

        /// <summary>Creates a <see cref="LocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LocationName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static LocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LocationName"/> with the pattern <c>projects/{project}/locations/{location}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LocationName"/> constructed from the provided ids.</returns>
        public static LocationName FromProjectLocation(string projectId, string locationId) =>
            new LocationName(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LocationName"/> with pattern
        /// <c>projects/{project}/locations/{location}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LocationName"/> with pattern
        /// <c>projects/{project}/locations/{location}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId) => FormatProjectLocation(projectId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LocationName"/> with pattern
        /// <c>projects/{project}/locations/{location}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LocationName"/> with pattern
        /// <c>projects/{project}/locations/{location}</c>.
        /// </returns>
        public static string FormatProjectLocation(string projectId, string locationId) =>
            s_projectLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>Parses the given resource name string into a new <see cref="LocationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="locationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationName"/> if successful.</returns>
        public static LocationName Parse(string locationName) => Parse(locationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LocationName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="locationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LocationName"/> if successful.</returns>
        public static LocationName Parse(string locationName, bool allowUnparsed) =>
            TryParse(locationName, allowUnparsed, out LocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="locationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationName, out LocationName result) => TryParse(locationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="locationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationName, bool allowUnparsed, out LocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocation.TryParseName(locationName, out resourceName))
            {
                result = FromProjectLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(locationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LocationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public LocationName(string projectId, string locationId) : this(ResourceNameType.ProjectLocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
                case ResourceNameType.ProjectLocation: return s_projectLocation.Expand(ProjectId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LocationName);

        /// <inheritdoc/>
        public bool Equals(LocationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LocationName a, LocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LocationName a, LocationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>GroundingConfig</c> resource.</summary>
    public sealed partial class GroundingConfigName : gax::IResourceName, sys::IEquatable<GroundingConfigName>
    {
        /// <summary>The possible contents of <see cref="GroundingConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/groundingConfigs/{grounding_config}</c>.
            /// </summary>
            ProjectLocationGroundingConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationGroundingConfig = new gax::PathTemplate("projects/{project}/locations/{location}/groundingConfigs/{grounding_config}");

        /// <summary>Creates a <see cref="GroundingConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GroundingConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GroundingConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GroundingConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GroundingConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/groundingConfigs/{grounding_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groundingConfigId">The <c>GroundingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GroundingConfigName"/> constructed from the provided ids.</returns>
        public static GroundingConfigName FromProjectLocationGroundingConfig(string projectId, string locationId, string groundingConfigId) =>
            new GroundingConfigName(ResourceNameType.ProjectLocationGroundingConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), groundingConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(groundingConfigId, nameof(groundingConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GroundingConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/groundingConfigs/{grounding_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groundingConfigId">The <c>GroundingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GroundingConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/groundingConfigs/{grounding_config}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string groundingConfigId) =>
            FormatProjectLocationGroundingConfig(projectId, locationId, groundingConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GroundingConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/groundingConfigs/{grounding_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groundingConfigId">The <c>GroundingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GroundingConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/groundingConfigs/{grounding_config}</c>.
        /// </returns>
        public static string FormatProjectLocationGroundingConfig(string projectId, string locationId, string groundingConfigId) =>
            s_projectLocationGroundingConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(groundingConfigId, nameof(groundingConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GroundingConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/groundingConfigs/{grounding_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="groundingConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GroundingConfigName"/> if successful.</returns>
        public static GroundingConfigName Parse(string groundingConfigName) => Parse(groundingConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GroundingConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/groundingConfigs/{grounding_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="groundingConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GroundingConfigName"/> if successful.</returns>
        public static GroundingConfigName Parse(string groundingConfigName, bool allowUnparsed) =>
            TryParse(groundingConfigName, allowUnparsed, out GroundingConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GroundingConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/groundingConfigs/{grounding_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="groundingConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GroundingConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string groundingConfigName, out GroundingConfigName result) =>
            TryParse(groundingConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GroundingConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/groundingConfigs/{grounding_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="groundingConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GroundingConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string groundingConfigName, bool allowUnparsed, out GroundingConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(groundingConfigName, nameof(groundingConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGroundingConfig.TryParseName(groundingConfigName, out resourceName))
            {
                result = FromProjectLocationGroundingConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(groundingConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GroundingConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string groundingConfigId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GroundingConfigId = groundingConfigId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GroundingConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/groundingConfigs/{grounding_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="groundingConfigId">The <c>GroundingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public GroundingConfigName(string projectId, string locationId, string groundingConfigId) : this(ResourceNameType.ProjectLocationGroundingConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), groundingConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(groundingConfigId, nameof(groundingConfigId)))
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
        /// The <c>GroundingConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string GroundingConfigId { get; }

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
                case ResourceNameType.ProjectLocationGroundingConfig: return s_projectLocationGroundingConfig.Expand(ProjectId, LocationId, GroundingConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GroundingConfigName);

        /// <inheritdoc/>
        public bool Equals(GroundingConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GroundingConfigName a, GroundingConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GroundingConfigName a, GroundingConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>RankingConfig</c> resource.</summary>
    public sealed partial class RankingConfigName : gax::IResourceName, sys::IEquatable<RankingConfigName>
    {
        /// <summary>The possible contents of <see cref="RankingConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/rankingConfigs/{ranking_config}</c>
            /// .
            /// </summary>
            ProjectLocationRankingConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationRankingConfig = new gax::PathTemplate("projects/{project}/locations/{location}/rankingConfigs/{ranking_config}");

        /// <summary>Creates a <see cref="RankingConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RankingConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RankingConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RankingConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RankingConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/rankingConfigs/{ranking_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rankingConfigId">The <c>RankingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RankingConfigName"/> constructed from the provided ids.</returns>
        public static RankingConfigName FromProjectLocationRankingConfig(string projectId, string locationId, string rankingConfigId) =>
            new RankingConfigName(ResourceNameType.ProjectLocationRankingConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), rankingConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(rankingConfigId, nameof(rankingConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RankingConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/rankingConfigs/{ranking_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rankingConfigId">The <c>RankingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RankingConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/rankingConfigs/{ranking_config}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string rankingConfigId) =>
            FormatProjectLocationRankingConfig(projectId, locationId, rankingConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RankingConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/rankingConfigs/{ranking_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rankingConfigId">The <c>RankingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RankingConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/rankingConfigs/{ranking_config}</c>.
        /// </returns>
        public static string FormatProjectLocationRankingConfig(string projectId, string locationId, string rankingConfigId) =>
            s_projectLocationRankingConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(rankingConfigId, nameof(rankingConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RankingConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/rankingConfigs/{ranking_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="rankingConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RankingConfigName"/> if successful.</returns>
        public static RankingConfigName Parse(string rankingConfigName) => Parse(rankingConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RankingConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/rankingConfigs/{ranking_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="rankingConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RankingConfigName"/> if successful.</returns>
        public static RankingConfigName Parse(string rankingConfigName, bool allowUnparsed) =>
            TryParse(rankingConfigName, allowUnparsed, out RankingConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RankingConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/rankingConfigs/{ranking_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="rankingConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RankingConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string rankingConfigName, out RankingConfigName result) =>
            TryParse(rankingConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RankingConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/rankingConfigs/{ranking_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="rankingConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RankingConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string rankingConfigName, bool allowUnparsed, out RankingConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(rankingConfigName, nameof(rankingConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRankingConfig.TryParseName(rankingConfigName, out resourceName))
            {
                result = FromProjectLocationRankingConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(rankingConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RankingConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string rankingConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RankingConfigId = rankingConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RankingConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/rankingConfigs/{ranking_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="rankingConfigId">The <c>RankingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public RankingConfigName(string projectId, string locationId, string rankingConfigId) : this(ResourceNameType.ProjectLocationRankingConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), rankingConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(rankingConfigId, nameof(rankingConfigId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>RankingConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string RankingConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRankingConfig: return s_projectLocationRankingConfig.Expand(ProjectId, LocationId, RankingConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RankingConfigName);

        /// <inheritdoc/>
        public bool Equals(RankingConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RankingConfigName a, RankingConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RankingConfigName a, RankingConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>LicenseConfig</c> resource.</summary>
    public sealed partial class LicenseConfigName : gax::IResourceName, sys::IEquatable<LicenseConfigName>
    {
        /// <summary>The possible contents of <see cref="LicenseConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/licenseConfigs/{license_config}</c>
            /// .
            /// </summary>
            ProjectLocationLicenseConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationLicenseConfig = new gax::PathTemplate("projects/{project}/locations/{location}/licenseConfigs/{license_config}");

        /// <summary>Creates a <see cref="LicenseConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LicenseConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LicenseConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LicenseConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LicenseConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/licenseConfigs/{license_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="licenseConfigId">The <c>LicenseConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LicenseConfigName"/> constructed from the provided ids.</returns>
        public static LicenseConfigName FromProjectLocationLicenseConfig(string projectId, string locationId, string licenseConfigId) =>
            new LicenseConfigName(ResourceNameType.ProjectLocationLicenseConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), licenseConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(licenseConfigId, nameof(licenseConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LicenseConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/licenseConfigs/{license_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="licenseConfigId">The <c>LicenseConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LicenseConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/licenseConfigs/{license_config}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string licenseConfigId) =>
            FormatProjectLocationLicenseConfig(projectId, locationId, licenseConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LicenseConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/licenseConfigs/{license_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="licenseConfigId">The <c>LicenseConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LicenseConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/licenseConfigs/{license_config}</c>.
        /// </returns>
        public static string FormatProjectLocationLicenseConfig(string projectId, string locationId, string licenseConfigId) =>
            s_projectLocationLicenseConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(licenseConfigId, nameof(licenseConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LicenseConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/licenseConfigs/{license_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="licenseConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LicenseConfigName"/> if successful.</returns>
        public static LicenseConfigName Parse(string licenseConfigName) => Parse(licenseConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LicenseConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/licenseConfigs/{license_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="licenseConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LicenseConfigName"/> if successful.</returns>
        public static LicenseConfigName Parse(string licenseConfigName, bool allowUnparsed) =>
            TryParse(licenseConfigName, allowUnparsed, out LicenseConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LicenseConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/licenseConfigs/{license_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="licenseConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LicenseConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string licenseConfigName, out LicenseConfigName result) =>
            TryParse(licenseConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LicenseConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/licenseConfigs/{license_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="licenseConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LicenseConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string licenseConfigName, bool allowUnparsed, out LicenseConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(licenseConfigName, nameof(licenseConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationLicenseConfig.TryParseName(licenseConfigName, out resourceName))
            {
                result = FromProjectLocationLicenseConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(licenseConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LicenseConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string licenseConfigId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LicenseConfigId = licenseConfigId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LicenseConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/licenseConfigs/{license_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="licenseConfigId">The <c>LicenseConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public LicenseConfigName(string projectId, string locationId, string licenseConfigId) : this(ResourceNameType.ProjectLocationLicenseConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), licenseConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(licenseConfigId, nameof(licenseConfigId)))
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
        /// The <c>LicenseConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string LicenseConfigId { get; }

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
                case ResourceNameType.ProjectLocationLicenseConfig: return s_projectLocationLicenseConfig.Expand(ProjectId, LocationId, LicenseConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LicenseConfigName);

        /// <inheritdoc/>
        public bool Equals(LicenseConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LicenseConfigName a, LicenseConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LicenseConfigName a, LicenseConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>UserStore</c> resource.</summary>
    public sealed partial class UserStoreName : gax::IResourceName, sys::IEquatable<UserStoreName>
    {
        /// <summary>The possible contents of <see cref="UserStoreName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/userStores/{user_store}</c>.
            /// </summary>
            ProjectLocationUserStore = 1,
        }

        private static gax::PathTemplate s_projectLocationUserStore = new gax::PathTemplate("projects/{project}/locations/{location}/userStores/{user_store}");

        /// <summary>Creates a <see cref="UserStoreName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UserStoreName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static UserStoreName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UserStoreName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="UserStoreName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/userStores/{user_store}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userStoreId">The <c>UserStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="UserStoreName"/> constructed from the provided ids.</returns>
        public static UserStoreName FromProjectLocationUserStore(string projectId, string locationId, string userStoreId) =>
            new UserStoreName(ResourceNameType.ProjectLocationUserStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), userStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(userStoreId, nameof(userStoreId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/userStores/{user_store}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userStoreId">The <c>UserStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/userStores/{user_store}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string userStoreId) =>
            FormatProjectLocationUserStore(projectId, locationId, userStoreId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/userStores/{user_store}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userStoreId">The <c>UserStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/userStores/{user_store}</c>.
        /// </returns>
        public static string FormatProjectLocationUserStore(string projectId, string locationId, string userStoreId) =>
            s_projectLocationUserStore.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(userStoreId, nameof(userStoreId)));

        /// <summary>Parses the given resource name string into a new <see cref="UserStoreName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/userStores/{user_store}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="userStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserStoreName"/> if successful.</returns>
        public static UserStoreName Parse(string userStoreName) => Parse(userStoreName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserStoreName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/userStores/{user_store}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UserStoreName"/> if successful.</returns>
        public static UserStoreName Parse(string userStoreName, bool allowUnparsed) =>
            TryParse(userStoreName, allowUnparsed, out UserStoreName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserStoreName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/userStores/{user_store}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="userStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserStoreName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userStoreName, out UserStoreName result) => TryParse(userStoreName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserStoreName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/userStores/{user_store}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserStoreName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userStoreName, bool allowUnparsed, out UserStoreName result)
        {
            gax::GaxPreconditions.CheckNotNull(userStoreName, nameof(userStoreName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationUserStore.TryParseName(userStoreName, out resourceName))
            {
                result = FromProjectLocationUserStore(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(userStoreName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UserStoreName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string userStoreId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            UserStoreId = userStoreId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UserStoreName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/userStores/{user_store}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userStoreId">The <c>UserStore</c> ID. Must not be <c>null</c> or empty.</param>
        public UserStoreName(string projectId, string locationId, string userStoreId) : this(ResourceNameType.ProjectLocationUserStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), userStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(userStoreId, nameof(userStoreId)))
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
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>UserStore</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string UserStoreId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationUserStore: return s_projectLocationUserStore.Expand(ProjectId, LocationId, UserStoreId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UserStoreName);

        /// <inheritdoc/>
        public bool Equals(UserStoreName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(UserStoreName a, UserStoreName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(UserStoreName a, UserStoreName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FhirStore</c> resource.</summary>
    public sealed partial class FhirStoreName : gax::IResourceName, sys::IEquatable<FhirStoreName>
    {
        /// <summary>The possible contents of <see cref="FhirStoreName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}</c>.
            /// </summary>
            ProjectLocationDatasetFhirStore = 1,
        }

        private static gax::PathTemplate s_projectLocationDatasetFhirStore = new gax::PathTemplate("projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}");

        /// <summary>Creates a <see cref="FhirStoreName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FhirStoreName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FhirStoreName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FhirStoreName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FhirStoreName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fhirStoreId">The <c>FhirStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FhirStoreName"/> constructed from the provided ids.</returns>
        public static FhirStoreName FromProjectLocationDatasetFhirStore(string projectId, string locationId, string datasetId, string fhirStoreId) =>
            new FhirStoreName(ResourceNameType.ProjectLocationDatasetFhirStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), fhirStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(fhirStoreId, nameof(fhirStoreId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FhirStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fhirStoreId">The <c>FhirStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FhirStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string datasetId, string fhirStoreId) =>
            FormatProjectLocationDatasetFhirStore(projectId, locationId, datasetId, fhirStoreId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FhirStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fhirStoreId">The <c>FhirStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FhirStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}</c>.
        /// </returns>
        public static string FormatProjectLocationDatasetFhirStore(string projectId, string locationId, string datasetId, string fhirStoreId) =>
            s_projectLocationDatasetFhirStore.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(fhirStoreId, nameof(fhirStoreId)));

        /// <summary>Parses the given resource name string into a new <see cref="FhirStoreName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="fhirStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FhirStoreName"/> if successful.</returns>
        public static FhirStoreName Parse(string fhirStoreName) => Parse(fhirStoreName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FhirStoreName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="fhirStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FhirStoreName"/> if successful.</returns>
        public static FhirStoreName Parse(string fhirStoreName, bool allowUnparsed) =>
            TryParse(fhirStoreName, allowUnparsed, out FhirStoreName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FhirStoreName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="fhirStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FhirStoreName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fhirStoreName, out FhirStoreName result) => TryParse(fhirStoreName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FhirStoreName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="fhirStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FhirStoreName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fhirStoreName, bool allowUnparsed, out FhirStoreName result)
        {
            gax::GaxPreconditions.CheckNotNull(fhirStoreName, nameof(fhirStoreName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDatasetFhirStore.TryParseName(fhirStoreName, out resourceName))
            {
                result = FromProjectLocationDatasetFhirStore(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(fhirStoreName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FhirStoreName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string datasetId = null, string fhirStoreId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatasetId = datasetId;
            FhirStoreId = fhirStoreId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FhirStoreName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fhirStoreId">The <c>FhirStore</c> ID. Must not be <c>null</c> or empty.</param>
        public FhirStoreName(string projectId, string locationId, string datasetId, string fhirStoreId) : this(ResourceNameType.ProjectLocationDatasetFhirStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), fhirStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(fhirStoreId, nameof(fhirStoreId)))
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
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

        /// <summary>
        /// The <c>FhirStore</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FhirStoreId { get; }

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
                case ResourceNameType.ProjectLocationDatasetFhirStore: return s_projectLocationDatasetFhirStore.Expand(ProjectId, LocationId, DatasetId, FhirStoreId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FhirStoreName);

        /// <inheritdoc/>
        public bool Equals(FhirStoreName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FhirStoreName a, FhirStoreName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FhirStoreName a, FhirStoreName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FhirResource</c> resource.</summary>
    public sealed partial class FhirResourceName : gax::IResourceName, sys::IEquatable<FhirResourceName>
    {
        /// <summary>The possible contents of <see cref="FhirResourceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}/fhir/{resource_type}/{fhir_resource_id}</c>
            /// .
            /// </summary>
            ProjectLocationDatasetFhirStoreResourceTypeFhirResource = 1,
        }

        private static gax::PathTemplate s_projectLocationDatasetFhirStoreResourceTypeFhirResource = new gax::PathTemplate("projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}/fhir/{resource_type}/{fhir_resource_id}");

        /// <summary>Creates a <see cref="FhirResourceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FhirResourceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FhirResourceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FhirResourceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FhirResourceName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}/fhir/{resource_type}/{fhir_resource_id}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fhirStoreId">The <c>FhirStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceTypeId">The <c>ResourceType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fhirResourceId">The <c>FhirResource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FhirResourceName"/> constructed from the provided ids.</returns>
        public static FhirResourceName FromProjectLocationDatasetFhirStoreResourceTypeFhirResource(string projectId, string locationId, string datasetId, string fhirStoreId, string resourceTypeId, string fhirResourceId) =>
            new FhirResourceName(ResourceNameType.ProjectLocationDatasetFhirStoreResourceTypeFhirResource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), fhirStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(fhirStoreId, nameof(fhirStoreId)), resourceTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceTypeId, nameof(resourceTypeId)), fhirResourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(fhirResourceId, nameof(fhirResourceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FhirResourceName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}/fhir/{resource_type}/{fhir_resource_id}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fhirStoreId">The <c>FhirStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceTypeId">The <c>ResourceType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fhirResourceId">The <c>FhirResource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FhirResourceName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}/fhir/{resource_type}/{fhir_resource_id}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string datasetId, string fhirStoreId, string resourceTypeId, string fhirResourceId) =>
            FormatProjectLocationDatasetFhirStoreResourceTypeFhirResource(projectId, locationId, datasetId, fhirStoreId, resourceTypeId, fhirResourceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FhirResourceName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}/fhir/{resource_type}/{fhir_resource_id}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fhirStoreId">The <c>FhirStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceTypeId">The <c>ResourceType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fhirResourceId">The <c>FhirResource</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FhirResourceName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}/fhir/{resource_type}/{fhir_resource_id}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationDatasetFhirStoreResourceTypeFhirResource(string projectId, string locationId, string datasetId, string fhirStoreId, string resourceTypeId, string fhirResourceId) =>
            s_projectLocationDatasetFhirStoreResourceTypeFhirResource.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), gax::GaxPreconditions.CheckNotNullOrEmpty(fhirStoreId, nameof(fhirStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(resourceTypeId, nameof(resourceTypeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(fhirResourceId, nameof(fhirResourceId)));

        /// <summary>Parses the given resource name string into a new <see cref="FhirResourceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}/fhir/{resource_type}/{fhir_resource_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="fhirResourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FhirResourceName"/> if successful.</returns>
        public static FhirResourceName Parse(string fhirResourceName) => Parse(fhirResourceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FhirResourceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}/fhir/{resource_type}/{fhir_resource_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="fhirResourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FhirResourceName"/> if successful.</returns>
        public static FhirResourceName Parse(string fhirResourceName, bool allowUnparsed) =>
            TryParse(fhirResourceName, allowUnparsed, out FhirResourceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FhirResourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}/fhir/{resource_type}/{fhir_resource_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="fhirResourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FhirResourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fhirResourceName, out FhirResourceName result) =>
            TryParse(fhirResourceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FhirResourceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}/fhir/{resource_type}/{fhir_resource_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="fhirResourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FhirResourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string fhirResourceName, bool allowUnparsed, out FhirResourceName result)
        {
            gax::GaxPreconditions.CheckNotNull(fhirResourceName, nameof(fhirResourceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDatasetFhirStoreResourceTypeFhirResource.TryParseName(fhirResourceName, out resourceName))
            {
                result = FromProjectLocationDatasetFhirStoreResourceTypeFhirResource(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4], resourceName[5]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(fhirResourceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FhirResourceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string datasetId = null, string fhirResourceId = null, string fhirStoreId = null, string locationId = null, string projectId = null, string resourceTypeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DatasetId = datasetId;
            FhirResourceId = fhirResourceId;
            FhirStoreId = fhirStoreId;
            LocationId = locationId;
            ProjectId = projectId;
            ResourceTypeId = resourceTypeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FhirResourceName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/datasets/{dataset}/fhirStores/{fhir_store}/fhir/{resource_type}/{fhir_resource_id}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="datasetId">The <c>Dataset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fhirStoreId">The <c>FhirStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="resourceTypeId">The <c>ResourceType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fhirResourceId">The <c>FhirResource</c> ID. Must not be <c>null</c> or empty.</param>
        public FhirResourceName(string projectId, string locationId, string datasetId, string fhirStoreId, string resourceTypeId, string fhirResourceId) : this(ResourceNameType.ProjectLocationDatasetFhirStoreResourceTypeFhirResource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), datasetId: gax::GaxPreconditions.CheckNotNullOrEmpty(datasetId, nameof(datasetId)), fhirStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(fhirStoreId, nameof(fhirStoreId)), resourceTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(resourceTypeId, nameof(resourceTypeId)), fhirResourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(fhirResourceId, nameof(fhirResourceId)))
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
        /// The <c>Dataset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DatasetId { get; }

        /// <summary>
        /// The <c>FhirResource</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string FhirResourceId { get; }

        /// <summary>
        /// The <c>FhirStore</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FhirStoreId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>ResourceType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ResourceTypeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationDatasetFhirStoreResourceTypeFhirResource: return s_projectLocationDatasetFhirStoreResourceTypeFhirResource.Expand(ProjectId, LocationId, DatasetId, FhirStoreId, ResourceTypeId, FhirResourceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FhirResourceName);

        /// <inheritdoc/>
        public bool Equals(FhirResourceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FhirResourceName a, FhirResourceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FhirResourceName a, FhirResourceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CryptoKeys</c> resource.</summary>
    public sealed partial class CryptoKeysName : gax::IResourceName, sys::IEquatable<CryptoKeysName>
    {
        /// <summary>The possible contents of <see cref="CryptoKeysName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>.
            /// </summary>
            ProjectLocationKeyRingCryptoKey = 1,
        }

        private static gax::PathTemplate s_projectLocationKeyRingCryptoKey = new gax::PathTemplate("projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}");

        /// <summary>Creates a <see cref="CryptoKeysName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CryptoKeysName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CryptoKeysName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CryptoKeysName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CryptoKeysName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CryptoKeysName"/> constructed from the provided ids.</returns>
        public static CryptoKeysName FromProjectLocationKeyRingCryptoKey(string projectId, string locationId, string keyRingId, string cryptoKeyId) =>
            new CryptoKeysName(ResourceNameType.ProjectLocationKeyRingCryptoKey, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), keyRingId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), cryptoKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CryptoKeysName"/> with pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CryptoKeysName"/> with pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string keyRingId, string cryptoKeyId) =>
            FormatProjectLocationKeyRingCryptoKey(projectId, locationId, keyRingId, cryptoKeyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CryptoKeysName"/> with pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CryptoKeysName"/> with pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>.
        /// </returns>
        public static string FormatProjectLocationKeyRingCryptoKey(string projectId, string locationId, string keyRingId, string cryptoKeyId) =>
            s_projectLocationKeyRingCryptoKey.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)));

        /// <summary>Parses the given resource name string into a new <see cref="CryptoKeysName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cryptoKeysName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CryptoKeysName"/> if successful.</returns>
        public static CryptoKeysName Parse(string cryptoKeysName) => Parse(cryptoKeysName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CryptoKeysName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cryptoKeysName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CryptoKeysName"/> if successful.</returns>
        public static CryptoKeysName Parse(string cryptoKeysName, bool allowUnparsed) =>
            TryParse(cryptoKeysName, allowUnparsed, out CryptoKeysName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CryptoKeysName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cryptoKeysName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CryptoKeysName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cryptoKeysName, out CryptoKeysName result) =>
            TryParse(cryptoKeysName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CryptoKeysName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cryptoKeysName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CryptoKeysName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cryptoKeysName, bool allowUnparsed, out CryptoKeysName result)
        {
            gax::GaxPreconditions.CheckNotNull(cryptoKeysName, nameof(cryptoKeysName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationKeyRingCryptoKey.TryParseName(cryptoKeysName, out resourceName))
            {
                result = FromProjectLocationKeyRingCryptoKey(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cryptoKeysName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CryptoKeysName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string cryptoKeyId = null, string keyRingId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CryptoKeyId = cryptoKeyId;
            KeyRingId = keyRingId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CryptoKeysName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        public CryptoKeysName(string projectId, string locationId, string keyRingId, string cryptoKeyId) : this(ResourceNameType.ProjectLocationKeyRingCryptoKey, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), keyRingId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), cryptoKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)))
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
        /// The <c>CryptoKey</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CryptoKeyId { get; }

        /// <summary>
        /// The <c>KeyRing</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string KeyRingId { get; }

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
                case ResourceNameType.ProjectLocationKeyRingCryptoKey: return s_projectLocationKeyRingCryptoKey.Expand(ProjectId, LocationId, KeyRingId, CryptoKeyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CryptoKeysName);

        /// <inheritdoc/>
        public bool Equals(CryptoKeysName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CryptoKeysName a, CryptoKeysName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CryptoKeysName a, CryptoKeysName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CryptoKeyVersions</c> resource.</summary>
    public sealed partial class CryptoKeyVersionsName : gax::IResourceName, sys::IEquatable<CryptoKeyVersionsName>
    {
        /// <summary>The possible contents of <see cref="CryptoKeyVersionsName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
            /// .
            /// </summary>
            ProjectLocationKeyRingCryptoKeyCryptoKeyVersion = 1,
        }

        private static gax::PathTemplate s_projectLocationKeyRingCryptoKeyCryptoKeyVersion = new gax::PathTemplate("projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}");

        /// <summary>Creates a <see cref="CryptoKeyVersionsName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CryptoKeyVersionsName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CryptoKeyVersionsName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CryptoKeyVersionsName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CryptoKeyVersionsName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyVersionId">The <c>CryptoKeyVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CryptoKeyVersionsName"/> constructed from the provided ids.</returns>
        public static CryptoKeyVersionsName FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion(string projectId, string locationId, string keyRingId, string cryptoKeyId, string cryptoKeyVersionId) =>
            new CryptoKeyVersionsName(ResourceNameType.ProjectLocationKeyRingCryptoKeyCryptoKeyVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), keyRingId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), cryptoKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)), cryptoKeyVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyVersionId, nameof(cryptoKeyVersionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CryptoKeyVersionsName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyVersionId">The <c>CryptoKeyVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CryptoKeyVersionsName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string keyRingId, string cryptoKeyId, string cryptoKeyVersionId) =>
            FormatProjectLocationKeyRingCryptoKeyCryptoKeyVersion(projectId, locationId, keyRingId, cryptoKeyId, cryptoKeyVersionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CryptoKeyVersionsName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyVersionId">The <c>CryptoKeyVersion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CryptoKeyVersionsName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationKeyRingCryptoKeyCryptoKeyVersion(string projectId, string locationId, string keyRingId, string cryptoKeyId, string cryptoKeyVersionId) =>
            s_projectLocationKeyRingCryptoKeyCryptoKeyVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyVersionId, nameof(cryptoKeyVersionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CryptoKeyVersionsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cryptoKeyVersionsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CryptoKeyVersionsName"/> if successful.</returns>
        public static CryptoKeyVersionsName Parse(string cryptoKeyVersionsName) => Parse(cryptoKeyVersionsName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CryptoKeyVersionsName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cryptoKeyVersionsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CryptoKeyVersionsName"/> if successful.</returns>
        public static CryptoKeyVersionsName Parse(string cryptoKeyVersionsName, bool allowUnparsed) =>
            TryParse(cryptoKeyVersionsName, allowUnparsed, out CryptoKeyVersionsName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CryptoKeyVersionsName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cryptoKeyVersionsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CryptoKeyVersionsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cryptoKeyVersionsName, out CryptoKeyVersionsName result) =>
            TryParse(cryptoKeyVersionsName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CryptoKeyVersionsName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cryptoKeyVersionsName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CryptoKeyVersionsName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cryptoKeyVersionsName, bool allowUnparsed, out CryptoKeyVersionsName result)
        {
            gax::GaxPreconditions.CheckNotNull(cryptoKeyVersionsName, nameof(cryptoKeyVersionsName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationKeyRingCryptoKeyCryptoKeyVersion.TryParseName(cryptoKeyVersionsName, out resourceName))
            {
                result = FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cryptoKeyVersionsName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CryptoKeyVersionsName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string cryptoKeyId = null, string cryptoKeyVersionId = null, string keyRingId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CryptoKeyId = cryptoKeyId;
            CryptoKeyVersionId = cryptoKeyVersionId;
            KeyRingId = keyRingId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CryptoKeyVersionsName"/> class from the component parts of pattern
        /// 
        /// <c>
        /// projects/{project}/locations/{location}/keyRings/{key_ring}/cryptoKeys/{crypto_key}/cryptoKeyVersions/{crypto_key_version}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keyRingId">The <c>KeyRing</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyId">The <c>CryptoKey</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cryptoKeyVersionId">The <c>CryptoKeyVersion</c> ID. Must not be <c>null</c> or empty.</param>
        public CryptoKeyVersionsName(string projectId, string locationId, string keyRingId, string cryptoKeyId, string cryptoKeyVersionId) : this(ResourceNameType.ProjectLocationKeyRingCryptoKeyCryptoKeyVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), keyRingId: gax::GaxPreconditions.CheckNotNullOrEmpty(keyRingId, nameof(keyRingId)), cryptoKeyId: gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyId, nameof(cryptoKeyId)), cryptoKeyVersionId: gax::GaxPreconditions.CheckNotNullOrEmpty(cryptoKeyVersionId, nameof(cryptoKeyVersionId)))
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
        /// The <c>CryptoKey</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CryptoKeyId { get; }

        /// <summary>
        /// The <c>CryptoKeyVersion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CryptoKeyVersionId { get; }

        /// <summary>
        /// The <c>KeyRing</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string KeyRingId { get; }

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
                case ResourceNameType.ProjectLocationKeyRingCryptoKeyCryptoKeyVersion: return s_projectLocationKeyRingCryptoKeyCryptoKeyVersion.Expand(ProjectId, LocationId, KeyRingId, CryptoKeyId, CryptoKeyVersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CryptoKeyVersionsName);

        /// <inheritdoc/>
        public bool Equals(CryptoKeyVersionsName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CryptoKeyVersionsName a, CryptoKeyVersionsName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CryptoKeyVersionsName a, CryptoKeyVersionsName b) => !(a == b);
    }

    public partial class SearchLinkPromotion
    {
        /// <summary>
        /// <see cref="DocumentName"/>-typed view over the <see cref="Document"/> resource name property.
        /// </summary>
        public DocumentName DocumentAsDocumentName
        {
            get => string.IsNullOrEmpty(Document) ? null : DocumentName.Parse(Document, allowUnparsed: true);
            set => Document = value?.ToString() ?? "";
        }
    }
}
