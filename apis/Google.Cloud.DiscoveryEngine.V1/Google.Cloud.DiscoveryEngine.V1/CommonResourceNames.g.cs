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

    /// <summary>Resource name for the <c>ServingConfig</c> resource.</summary>
    public sealed partial class ServingConfigName : gax::IResourceName, sys::IEquatable<ServingConfigName>
    {
        /// <summary>The possible contents of <see cref="ServingConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/servingConfigs/{serving_config}</c>.
            /// </summary>
            ProjectLocationDataStoreServingConfig = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/servingConfigs/{serving_config}</c>
            /// .
            /// </summary>
            ProjectLocationCollectionDataStoreServingConfig = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/servingConfigs/{serving_config}</c>
            /// .
            /// </summary>
            ProjectLocationCollectionEngineServingConfig = 3,
        }

        private static gax::PathTemplate s_projectLocationDataStoreServingConfig = new gax::PathTemplate("projects/{project}/locations/{location}/dataStores/{data_store}/servingConfigs/{serving_config}");

        private static gax::PathTemplate s_projectLocationCollectionDataStoreServingConfig = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/servingConfigs/{serving_config}");

        private static gax::PathTemplate s_projectLocationCollectionEngineServingConfig = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/servingConfigs/{serving_config}");

        /// <summary>Creates a <see cref="ServingConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServingConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServingConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServingConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServingConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/servingConfigs/{serving_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="servingConfigId">The <c>ServingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServingConfigName"/> constructed from the provided ids.</returns>
        public static ServingConfigName FromProjectLocationDataStoreServingConfig(string projectId, string locationId, string dataStoreId, string servingConfigId) =>
            new ServingConfigName(ResourceNameType.ProjectLocationDataStoreServingConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), servingConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(servingConfigId, nameof(servingConfigId)));

        /// <summary>
        /// Creates a <see cref="ServingConfigName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/servingConfigs/{serving_config}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="servingConfigId">The <c>ServingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServingConfigName"/> constructed from the provided ids.</returns>
        public static ServingConfigName FromProjectLocationCollectionDataStoreServingConfig(string projectId, string locationId, string collectionId, string dataStoreId, string servingConfigId) =>
            new ServingConfigName(ResourceNameType.ProjectLocationCollectionDataStoreServingConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), servingConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(servingConfigId, nameof(servingConfigId)));

        /// <summary>
        /// Creates a <see cref="ServingConfigName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/servingConfigs/{serving_config}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineId">The <c>Engine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="servingConfigId">The <c>ServingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServingConfigName"/> constructed from the provided ids.</returns>
        public static ServingConfigName FromProjectLocationCollectionEngineServingConfig(string projectId, string locationId, string collectionId, string engineId, string servingConfigId) =>
            new ServingConfigName(ResourceNameType.ProjectLocationCollectionEngineServingConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), engineId: gax::GaxPreconditions.CheckNotNullOrEmpty(engineId, nameof(engineId)), servingConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(servingConfigId, nameof(servingConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServingConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/servingConfigs/{serving_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="servingConfigId">The <c>ServingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServingConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/servingConfigs/{serving_config}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataStoreId, string servingConfigId) =>
            FormatProjectLocationDataStoreServingConfig(projectId, locationId, dataStoreId, servingConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServingConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/servingConfigs/{serving_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="servingConfigId">The <c>ServingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServingConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/servingConfigs/{serving_config}</c>.
        /// </returns>
        public static string FormatProjectLocationDataStoreServingConfig(string projectId, string locationId, string dataStoreId, string servingConfigId) =>
            s_projectLocationDataStoreServingConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(servingConfigId, nameof(servingConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServingConfigName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/servingConfigs/{serving_config}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="servingConfigId">The <c>ServingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServingConfigName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/servingConfigs/{serving_config}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCollectionDataStoreServingConfig(string projectId, string locationId, string collectionId, string dataStoreId, string servingConfigId) =>
            s_projectLocationCollectionDataStoreServingConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(servingConfigId, nameof(servingConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServingConfigName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/servingConfigs/{serving_config}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineId">The <c>Engine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="servingConfigId">The <c>ServingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServingConfigName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/servingConfigs/{serving_config}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCollectionEngineServingConfig(string projectId, string locationId, string collectionId, string engineId, string servingConfigId) =>
            s_projectLocationCollectionEngineServingConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(engineId, nameof(engineId)), gax::GaxPreconditions.CheckNotNullOrEmpty(servingConfigId, nameof(servingConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServingConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/servingConfigs/{serving_config}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/servingConfigs/{serving_config}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/servingConfigs/{serving_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="servingConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServingConfigName"/> if successful.</returns>
        public static ServingConfigName Parse(string servingConfigName) => Parse(servingConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServingConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/servingConfigs/{serving_config}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/servingConfigs/{serving_config}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/servingConfigs/{serving_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="servingConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServingConfigName"/> if successful.</returns>
        public static ServingConfigName Parse(string servingConfigName, bool allowUnparsed) =>
            TryParse(servingConfigName, allowUnparsed, out ServingConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServingConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/servingConfigs/{serving_config}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/servingConfigs/{serving_config}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/servingConfigs/{serving_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="servingConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServingConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string servingConfigName, out ServingConfigName result) =>
            TryParse(servingConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServingConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/servingConfigs/{serving_config}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/servingConfigs/{serving_config}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/servingConfigs/{serving_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="servingConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServingConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string servingConfigName, bool allowUnparsed, out ServingConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(servingConfigName, nameof(servingConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataStoreServingConfig.TryParseName(servingConfigName, out resourceName))
            {
                result = FromProjectLocationDataStoreServingConfig(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectLocationCollectionDataStoreServingConfig.TryParseName(servingConfigName, out resourceName))
            {
                result = FromProjectLocationCollectionDataStoreServingConfig(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (s_projectLocationCollectionEngineServingConfig.TryParseName(servingConfigName, out resourceName))
            {
                result = FromProjectLocationCollectionEngineServingConfig(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(servingConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServingConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string collectionId = null, string dataStoreId = null, string engineId = null, string locationId = null, string projectId = null, string servingConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CollectionId = collectionId;
            DataStoreId = dataStoreId;
            EngineId = engineId;
            LocationId = locationId;
            ProjectId = projectId;
            ServingConfigId = servingConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServingConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/servingConfigs/{serving_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="servingConfigId">The <c>ServingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public ServingConfigName(string projectId, string locationId, string dataStoreId, string servingConfigId) : this(ResourceNameType.ProjectLocationDataStoreServingConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), servingConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(servingConfigId, nameof(servingConfigId)))
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
        /// The <c>Collection</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string CollectionId { get; }

        /// <summary>
        /// The <c>DataStore</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string DataStoreId { get; }

        /// <summary>
        /// The <c>Engine</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string EngineId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>ServingConfig</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ServingConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationDataStoreServingConfig: return s_projectLocationDataStoreServingConfig.Expand(ProjectId, LocationId, DataStoreId, ServingConfigId);
                case ResourceNameType.ProjectLocationCollectionDataStoreServingConfig: return s_projectLocationCollectionDataStoreServingConfig.Expand(ProjectId, LocationId, CollectionId, DataStoreId, ServingConfigId);
                case ResourceNameType.ProjectLocationCollectionEngineServingConfig: return s_projectLocationCollectionEngineServingConfig.Expand(ProjectId, LocationId, CollectionId, EngineId, ServingConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServingConfigName);

        /// <inheritdoc/>
        public bool Equals(ServingConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServingConfigName a, ServingConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServingConfigName a, ServingConfigName b) => !(a == b);
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
}
