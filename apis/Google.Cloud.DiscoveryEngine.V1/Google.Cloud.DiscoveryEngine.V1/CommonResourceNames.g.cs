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

    /// <summary>Resource name for the <c>CompletionConfig</c> resource.</summary>
    public sealed partial class CompletionConfigName : gax::IResourceName, sys::IEquatable<CompletionConfigName>
    {
        /// <summary>The possible contents of <see cref="CompletionConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/completionConfig</c>.
            /// </summary>
            ProjectLocationDataStore = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/completionConfig</c>
            /// .
            /// </summary>
            ProjectLocationCollectionDataStore = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/completionConfig</c>
            /// .
            /// </summary>
            ProjectLocationCollectionEngine = 3,
        }

        private static gax::PathTemplate s_projectLocationDataStore = new gax::PathTemplate("projects/{project}/locations/{location}/dataStores/{data_store}/completionConfig");

        private static gax::PathTemplate s_projectLocationCollectionDataStore = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/completionConfig");

        private static gax::PathTemplate s_projectLocationCollectionEngine = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/completionConfig");

        /// <summary>Creates a <see cref="CompletionConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CompletionConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CompletionConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CompletionConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CompletionConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/completionConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CompletionConfigName"/> constructed from the provided ids.</returns>
        public static CompletionConfigName FromProjectLocationDataStore(string projectId, string locationId, string dataStoreId) =>
            new CompletionConfigName(ResourceNameType.ProjectLocationDataStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)));

        /// <summary>
        /// Creates a <see cref="CompletionConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/completionConfig</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CompletionConfigName"/> constructed from the provided ids.</returns>
        public static CompletionConfigName FromProjectLocationCollectionDataStore(string projectId, string locationId, string collectionId, string dataStoreId) =>
            new CompletionConfigName(ResourceNameType.ProjectLocationCollectionDataStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)));

        /// <summary>
        /// Creates a <see cref="CompletionConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/completionConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineId">The <c>Engine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CompletionConfigName"/> constructed from the provided ids.</returns>
        public static CompletionConfigName FromProjectLocationCollectionEngine(string projectId, string locationId, string collectionId, string engineId) =>
            new CompletionConfigName(ResourceNameType.ProjectLocationCollectionEngine, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), engineId: gax::GaxPreconditions.CheckNotNullOrEmpty(engineId, nameof(engineId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CompletionConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/completionConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CompletionConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/completionConfig</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataStoreId) =>
            FormatProjectLocationDataStore(projectId, locationId, dataStoreId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CompletionConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/completionConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CompletionConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/completionConfig</c>.
        /// </returns>
        public static string FormatProjectLocationDataStore(string projectId, string locationId, string dataStoreId) =>
            s_projectLocationDataStore.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CompletionConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/completionConfig</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CompletionConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/completionConfig</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCollectionDataStore(string projectId, string locationId, string collectionId, string dataStoreId) =>
            s_projectLocationCollectionDataStore.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CompletionConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/completionConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineId">The <c>Engine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CompletionConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/completionConfig</c>.
        /// </returns>
        public static string FormatProjectLocationCollectionEngine(string projectId, string locationId, string collectionId, string engineId) =>
            s_projectLocationCollectionEngine.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(engineId, nameof(engineId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CompletionConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/completionConfig</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/completionConfig</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/completionConfig</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="completionConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CompletionConfigName"/> if successful.</returns>
        public static CompletionConfigName Parse(string completionConfigName) => Parse(completionConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CompletionConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/completionConfig</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/completionConfig</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/completionConfig</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="completionConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CompletionConfigName"/> if successful.</returns>
        public static CompletionConfigName Parse(string completionConfigName, bool allowUnparsed) =>
            TryParse(completionConfigName, allowUnparsed, out CompletionConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CompletionConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/completionConfig</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/completionConfig</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/completionConfig</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="completionConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CompletionConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string completionConfigName, out CompletionConfigName result) =>
            TryParse(completionConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CompletionConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/completionConfig</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/completionConfig</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}/completionConfig</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="completionConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CompletionConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string completionConfigName, bool allowUnparsed, out CompletionConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(completionConfigName, nameof(completionConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataStore.TryParseName(completionConfigName, out resourceName))
            {
                result = FromProjectLocationDataStore(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationCollectionDataStore.TryParseName(completionConfigName, out resourceName))
            {
                result = FromProjectLocationCollectionDataStore(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectLocationCollectionEngine.TryParseName(completionConfigName, out resourceName))
            {
                result = FromProjectLocationCollectionEngine(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(completionConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CompletionConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string collectionId = null, string dataStoreId = null, string engineId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CollectionId = collectionId;
            DataStoreId = dataStoreId;
            EngineId = engineId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CompletionConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/completionConfig</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        public CompletionConfigName(string projectId, string locationId, string dataStoreId) : this(ResourceNameType.ProjectLocationDataStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationDataStore: return s_projectLocationDataStore.Expand(ProjectId, LocationId, DataStoreId);
                case ResourceNameType.ProjectLocationCollectionDataStore: return s_projectLocationCollectionDataStore.Expand(ProjectId, LocationId, CollectionId, DataStoreId);
                case ResourceNameType.ProjectLocationCollectionEngine: return s_projectLocationCollectionEngine.Expand(ProjectId, LocationId, CollectionId, EngineId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CompletionConfigName);

        /// <inheritdoc/>
        public bool Equals(CompletionConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CompletionConfigName a, CompletionConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CompletionConfigName a, CompletionConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>BillingAccountLicenseConfig</c> resource.</summary>
    public sealed partial class BillingAccountLicenseConfigName : gax::IResourceName, sys::IEquatable<BillingAccountLicenseConfigName>
    {
        /// <summary>The possible contents of <see cref="BillingAccountLicenseConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>billingAccounts/{billing_account}/billingAccountLicenseConfigs/{billing_account_license_config}</c>.
            /// </summary>
            BillingAccountBillingAccountLicenseConfig = 1,
        }

        private static gax::PathTemplate s_billingAccountBillingAccountLicenseConfig = new gax::PathTemplate("billingAccounts/{billing_account}/billingAccountLicenseConfigs/{billing_account_license_config}");

        /// <summary>
        /// Creates a <see cref="BillingAccountLicenseConfigName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BillingAccountLicenseConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BillingAccountLicenseConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BillingAccountLicenseConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BillingAccountLicenseConfigName"/> with the pattern
        /// <c>billingAccounts/{billing_account}/billingAccountLicenseConfigs/{billing_account_license_config}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="billingAccountLicenseConfigId">
        /// The <c>BillingAccountLicenseConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="BillingAccountLicenseConfigName"/> constructed from the provided ids.
        /// </returns>
        public static BillingAccountLicenseConfigName FromBillingAccountBillingAccountLicenseConfig(string billingAccountId, string billingAccountLicenseConfigId) =>
            new BillingAccountLicenseConfigName(ResourceNameType.BillingAccountBillingAccountLicenseConfig, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), billingAccountLicenseConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountLicenseConfigId, nameof(billingAccountLicenseConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BillingAccountLicenseConfigName"/> with
        /// pattern <c>billingAccounts/{billing_account}/billingAccountLicenseConfigs/{billing_account_license_config}</c>
        /// .
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="billingAccountLicenseConfigId">
        /// The <c>BillingAccountLicenseConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="BillingAccountLicenseConfigName"/> with pattern
        /// <c>billingAccounts/{billing_account}/billingAccountLicenseConfigs/{billing_account_license_config}</c>.
        /// </returns>
        public static string Format(string billingAccountId, string billingAccountLicenseConfigId) =>
            FormatBillingAccountBillingAccountLicenseConfig(billingAccountId, billingAccountLicenseConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BillingAccountLicenseConfigName"/> with
        /// pattern <c>billingAccounts/{billing_account}/billingAccountLicenseConfigs/{billing_account_license_config}</c>
        /// .
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="billingAccountLicenseConfigId">
        /// The <c>BillingAccountLicenseConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="BillingAccountLicenseConfigName"/> with pattern
        /// <c>billingAccounts/{billing_account}/billingAccountLicenseConfigs/{billing_account_license_config}</c>.
        /// </returns>
        public static string FormatBillingAccountBillingAccountLicenseConfig(string billingAccountId, string billingAccountLicenseConfigId) =>
            s_billingAccountBillingAccountLicenseConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountLicenseConfigId, nameof(billingAccountLicenseConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BillingAccountLicenseConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/billingAccountLicenseConfigs/{billing_account_license_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="billingAccountLicenseConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="BillingAccountLicenseConfigName"/> if successful.</returns>
        public static BillingAccountLicenseConfigName Parse(string billingAccountLicenseConfigName) =>
            Parse(billingAccountLicenseConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BillingAccountLicenseConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/billingAccountLicenseConfigs/{billing_account_license_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="billingAccountLicenseConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BillingAccountLicenseConfigName"/> if successful.</returns>
        public static BillingAccountLicenseConfigName Parse(string billingAccountLicenseConfigName, bool allowUnparsed) =>
            TryParse(billingAccountLicenseConfigName, allowUnparsed, out BillingAccountLicenseConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BillingAccountLicenseConfigName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/billingAccountLicenseConfigs/{billing_account_license_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="billingAccountLicenseConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BillingAccountLicenseConfigName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string billingAccountLicenseConfigName, out BillingAccountLicenseConfigName result) =>
            TryParse(billingAccountLicenseConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BillingAccountLicenseConfigName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/billingAccountLicenseConfigs/{billing_account_license_config}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="billingAccountLicenseConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BillingAccountLicenseConfigName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string billingAccountLicenseConfigName, bool allowUnparsed, out BillingAccountLicenseConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(billingAccountLicenseConfigName, nameof(billingAccountLicenseConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_billingAccountBillingAccountLicenseConfig.TryParseName(billingAccountLicenseConfigName, out resourceName))
            {
                result = FromBillingAccountBillingAccountLicenseConfig(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(billingAccountLicenseConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BillingAccountLicenseConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string billingAccountLicenseConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            BillingAccountLicenseConfigId = billingAccountLicenseConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BillingAccountLicenseConfigName"/> class from the component parts
        /// of pattern
        /// <c>billingAccounts/{billing_account}/billingAccountLicenseConfigs/{billing_account_license_config}</c>
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="billingAccountLicenseConfigId">
        /// The <c>BillingAccountLicenseConfig</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public BillingAccountLicenseConfigName(string billingAccountId, string billingAccountLicenseConfigId) : this(ResourceNameType.BillingAccountBillingAccountLicenseConfig, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), billingAccountLicenseConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountLicenseConfigId, nameof(billingAccountLicenseConfigId)))
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
        /// The <c>BillingAccount</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string BillingAccountId { get; }

        /// <summary>
        /// The <c>BillingAccountLicenseConfig</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string BillingAccountLicenseConfigId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.BillingAccountBillingAccountLicenseConfig: return s_billingAccountBillingAccountLicenseConfig.Expand(BillingAccountId, BillingAccountLicenseConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BillingAccountLicenseConfigName);

        /// <inheritdoc/>
        public bool Equals(BillingAccountLicenseConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(BillingAccountLicenseConfigName a, BillingAccountLicenseConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(BillingAccountLicenseConfigName a, BillingAccountLicenseConfigName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Notebook</c> resource.</summary>
    public sealed partial class NotebookName : gax::IResourceName, sys::IEquatable<NotebookName>
    {
        /// <summary>The possible contents of <see cref="NotebookName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/notebooks/{notebook}</c>.
            /// </summary>
            ProjectLocationNotebook = 1,
        }

        private static gax::PathTemplate s_projectLocationNotebook = new gax::PathTemplate("projects/{project}/locations/{location}/notebooks/{notebook}");

        /// <summary>Creates a <see cref="NotebookName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NotebookName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static NotebookName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NotebookName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NotebookName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/notebooks/{notebook}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notebookId">The <c>Notebook</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NotebookName"/> constructed from the provided ids.</returns>
        public static NotebookName FromProjectLocationNotebook(string projectId, string locationId, string notebookId) =>
            new NotebookName(ResourceNameType.ProjectLocationNotebook, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), notebookId: gax::GaxPreconditions.CheckNotNullOrEmpty(notebookId, nameof(notebookId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotebookName"/> with pattern
        /// <c>projects/{project}/locations/{location}/notebooks/{notebook}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notebookId">The <c>Notebook</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NotebookName"/> with pattern
        /// <c>projects/{project}/locations/{location}/notebooks/{notebook}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string notebookId) =>
            FormatProjectLocationNotebook(projectId, locationId, notebookId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NotebookName"/> with pattern
        /// <c>projects/{project}/locations/{location}/notebooks/{notebook}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notebookId">The <c>Notebook</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NotebookName"/> with pattern
        /// <c>projects/{project}/locations/{location}/notebooks/{notebook}</c>.
        /// </returns>
        public static string FormatProjectLocationNotebook(string projectId, string locationId, string notebookId) =>
            s_projectLocationNotebook.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(notebookId, nameof(notebookId)));

        /// <summary>Parses the given resource name string into a new <see cref="NotebookName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/notebooks/{notebook}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="notebookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NotebookName"/> if successful.</returns>
        public static NotebookName Parse(string notebookName) => Parse(notebookName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NotebookName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/notebooks/{notebook}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="notebookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NotebookName"/> if successful.</returns>
        public static NotebookName Parse(string notebookName, bool allowUnparsed) =>
            TryParse(notebookName, allowUnparsed, out NotebookName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NotebookName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/notebooks/{notebook}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="notebookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NotebookName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string notebookName, out NotebookName result) => TryParse(notebookName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NotebookName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/notebooks/{notebook}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="notebookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NotebookName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string notebookName, bool allowUnparsed, out NotebookName result)
        {
            gax::GaxPreconditions.CheckNotNull(notebookName, nameof(notebookName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationNotebook.TryParseName(notebookName, out resourceName))
            {
                result = FromProjectLocationNotebook(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(notebookName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NotebookName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string notebookId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            NotebookId = notebookId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NotebookName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/notebooks/{notebook}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="notebookId">The <c>Notebook</c> ID. Must not be <c>null</c> or empty.</param>
        public NotebookName(string projectId, string locationId, string notebookId) : this(ResourceNameType.ProjectLocationNotebook, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), notebookId: gax::GaxPreconditions.CheckNotNullOrEmpty(notebookId, nameof(notebookId)))
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
        /// The <c>Notebook</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NotebookId { get; }

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
                case ResourceNameType.ProjectLocationNotebook: return s_projectLocationNotebook.Expand(ProjectId, LocationId, NotebookId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NotebookName);

        /// <inheritdoc/>
        public bool Equals(NotebookName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NotebookName a, NotebookName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NotebookName a, NotebookName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AgentGateway</c> resource.</summary>
    public sealed partial class AgentGatewayName : gax::IResourceName, sys::IEquatable<AgentGatewayName>
    {
        /// <summary>The possible contents of <see cref="AgentGatewayName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c>
            /// .
            /// </summary>
            ProjectLocationAgentGateway = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentGateway = new gax::PathTemplate("projects/{project}/locations/{location}/agentGateways/{agent_gateway}");

        /// <summary>Creates a <see cref="AgentGatewayName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AgentGatewayName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AgentGatewayName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AgentGatewayName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AgentGatewayName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentGatewayId">The <c>AgentGateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AgentGatewayName"/> constructed from the provided ids.</returns>
        public static AgentGatewayName FromProjectLocationAgentGateway(string projectId, string locationId, string agentGatewayId) =>
            new AgentGatewayName(ResourceNameType.ProjectLocationAgentGateway, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentGatewayId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentGatewayId, nameof(agentGatewayId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AgentGatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentGatewayId">The <c>AgentGateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AgentGatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentGatewayId) =>
            FormatProjectLocationAgentGateway(projectId, locationId, agentGatewayId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AgentGatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentGatewayId">The <c>AgentGateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AgentGatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c>.
        /// </returns>
        public static string FormatProjectLocationAgentGateway(string projectId, string locationId, string agentGatewayId) =>
            s_projectLocationAgentGateway.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentGatewayId, nameof(agentGatewayId)));

        /// <summary>Parses the given resource name string into a new <see cref="AgentGatewayName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="agentGatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AgentGatewayName"/> if successful.</returns>
        public static AgentGatewayName Parse(string agentGatewayName) => Parse(agentGatewayName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AgentGatewayName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="agentGatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AgentGatewayName"/> if successful.</returns>
        public static AgentGatewayName Parse(string agentGatewayName, bool allowUnparsed) =>
            TryParse(agentGatewayName, allowUnparsed, out AgentGatewayName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AgentGatewayName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="agentGatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AgentGatewayName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string agentGatewayName, out AgentGatewayName result) =>
            TryParse(agentGatewayName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AgentGatewayName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="agentGatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AgentGatewayName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string agentGatewayName, bool allowUnparsed, out AgentGatewayName result)
        {
            gax::GaxPreconditions.CheckNotNull(agentGatewayName, nameof(agentGatewayName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentGateway.TryParseName(agentGatewayName, out resourceName))
            {
                result = FromProjectLocationAgentGateway(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(agentGatewayName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AgentGatewayName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentGatewayId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentGatewayId = agentGatewayId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AgentGatewayName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/agentGateways/{agent_gateway}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentGatewayId">The <c>AgentGateway</c> ID. Must not be <c>null</c> or empty.</param>
        public AgentGatewayName(string projectId, string locationId, string agentGatewayId) : this(ResourceNameType.ProjectLocationAgentGateway, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentGatewayId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentGatewayId, nameof(agentGatewayId)))
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
        /// The <c>AgentGateway</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AgentGatewayId { get; }

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
                case ResourceNameType.ProjectLocationAgentGateway: return s_projectLocationAgentGateway.Expand(ProjectId, LocationId, AgentGatewayId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AgentGatewayName);

        /// <inheritdoc/>
        public bool Equals(AgentGatewayName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AgentGatewayName a, AgentGatewayName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AgentGatewayName a, AgentGatewayName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Template</c> resource.</summary>
    public sealed partial class TemplateName : gax::IResourceName, sys::IEquatable<TemplateName>
    {
        /// <summary>The possible contents of <see cref="TemplateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/templates/{template}</c>.
            /// </summary>
            ProjectLocationTemplate = 1,
        }

        private static gax::PathTemplate s_projectLocationTemplate = new gax::PathTemplate("projects/{project}/locations/{location}/templates/{template}");

        /// <summary>Creates a <see cref="TemplateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TemplateName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static TemplateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TemplateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TemplateName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/templates/{template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="templateId">The <c>Template</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TemplateName"/> constructed from the provided ids.</returns>
        public static TemplateName FromProjectLocationTemplate(string projectId, string locationId, string templateId) =>
            new TemplateName(ResourceNameType.ProjectLocationTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), templateId: gax::GaxPreconditions.CheckNotNullOrEmpty(templateId, nameof(templateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/templates/{template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="templateId">The <c>Template</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/templates/{template}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string templateId) =>
            FormatProjectLocationTemplate(projectId, locationId, templateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/templates/{template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="templateId">The <c>Template</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/templates/{template}</c>.
        /// </returns>
        public static string FormatProjectLocationTemplate(string projectId, string locationId, string templateId) =>
            s_projectLocationTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(templateId, nameof(templateId)));

        /// <summary>Parses the given resource name string into a new <see cref="TemplateName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/templates/{template}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="templateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TemplateName"/> if successful.</returns>
        public static TemplateName Parse(string templateName) => Parse(templateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TemplateName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/templates/{template}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="templateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TemplateName"/> if successful.</returns>
        public static TemplateName Parse(string templateName, bool allowUnparsed) =>
            TryParse(templateName, allowUnparsed, out TemplateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/templates/{template}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="templateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string templateName, out TemplateName result) => TryParse(templateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TemplateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/templates/{template}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="templateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string templateName, bool allowUnparsed, out TemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(templateName, nameof(templateName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationTemplate.TryParseName(templateName, out resourceName))
            {
                result = FromProjectLocationTemplate(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(templateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TemplateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string templateId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            TemplateId = templateId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TemplateName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/templates/{template}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="templateId">The <c>Template</c> ID. Must not be <c>null</c> or empty.</param>
        public TemplateName(string projectId, string locationId, string templateId) : this(ResourceNameType.ProjectLocationTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), templateId: gax::GaxPreconditions.CheckNotNullOrEmpty(templateId, nameof(templateId)))
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
        /// The <c>Template</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TemplateId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationTemplate: return s_projectLocationTemplate.Expand(ProjectId, LocationId, TemplateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TemplateName);

        /// <inheritdoc/>
        public bool Equals(TemplateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TemplateName a, TemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TemplateName a, TemplateName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ContentPolicy</c> resource.</summary>
    public sealed partial class ContentPolicyName : gax::IResourceName, sys::IEquatable<ContentPolicyName>
    {
        /// <summary>The possible contents of <see cref="ContentPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/contentPolicies/{content_policy}</c>.
            /// </summary>
            OrganizationLocationContentPolicy = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/contentPolicies/{content_policy}</c>
            /// .
            /// </summary>
            ProjectLocationContentPolicy = 2,
        }

        private static gax::PathTemplate s_organizationLocationContentPolicy = new gax::PathTemplate("organizations/{organization}/locations/{location}/contentPolicies/{content_policy}");

        private static gax::PathTemplate s_projectLocationContentPolicy = new gax::PathTemplate("projects/{project}/locations/{location}/contentPolicies/{content_policy}");

        /// <summary>Creates a <see cref="ContentPolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ContentPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ContentPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ContentPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ContentPolicyName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/contentPolicies/{content_policy}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contentPolicyId">The <c>ContentPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ContentPolicyName"/> constructed from the provided ids.</returns>
        public static ContentPolicyName FromOrganizationLocationContentPolicy(string organizationId, string locationId, string contentPolicyId) =>
            new ContentPolicyName(ResourceNameType.OrganizationLocationContentPolicy, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), contentPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(contentPolicyId, nameof(contentPolicyId)));

        /// <summary>
        /// Creates a <see cref="ContentPolicyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/contentPolicies/{content_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contentPolicyId">The <c>ContentPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ContentPolicyName"/> constructed from the provided ids.</returns>
        public static ContentPolicyName FromProjectLocationContentPolicy(string projectId, string locationId, string contentPolicyId) =>
            new ContentPolicyName(ResourceNameType.ProjectLocationContentPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), contentPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(contentPolicyId, nameof(contentPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContentPolicyName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/contentPolicies/{content_policy}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contentPolicyId">The <c>ContentPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContentPolicyName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/contentPolicies/{content_policy}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId, string contentPolicyId) =>
            FormatOrganizationLocationContentPolicy(organizationId, locationId, contentPolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContentPolicyName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/contentPolicies/{content_policy}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contentPolicyId">The <c>ContentPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContentPolicyName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/contentPolicies/{content_policy}</c>.
        /// </returns>
        public static string FormatOrganizationLocationContentPolicy(string organizationId, string locationId, string contentPolicyId) =>
            s_organizationLocationContentPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(contentPolicyId, nameof(contentPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContentPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/contentPolicies/{content_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contentPolicyId">The <c>ContentPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContentPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/contentPolicies/{content_policy}</c>.
        /// </returns>
        public static string FormatProjectLocationContentPolicy(string projectId, string locationId, string contentPolicyId) =>
            s_projectLocationContentPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(contentPolicyId, nameof(contentPolicyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ContentPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/contentPolicies/{content_policy}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/contentPolicies/{content_policy}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="contentPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ContentPolicyName"/> if successful.</returns>
        public static ContentPolicyName Parse(string contentPolicyName) => Parse(contentPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ContentPolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/contentPolicies/{content_policy}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/contentPolicies/{content_policy}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="contentPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ContentPolicyName"/> if successful.</returns>
        public static ContentPolicyName Parse(string contentPolicyName, bool allowUnparsed) =>
            TryParse(contentPolicyName, allowUnparsed, out ContentPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ContentPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/contentPolicies/{content_policy}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/contentPolicies/{content_policy}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="contentPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ContentPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string contentPolicyName, out ContentPolicyName result) =>
            TryParse(contentPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ContentPolicyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/contentPolicies/{content_policy}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/contentPolicies/{content_policy}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="contentPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ContentPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string contentPolicyName, bool allowUnparsed, out ContentPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(contentPolicyName, nameof(contentPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationContentPolicy.TryParseName(contentPolicyName, out resourceName))
            {
                result = FromOrganizationLocationContentPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationContentPolicy.TryParseName(contentPolicyName, out resourceName))
            {
                result = FromProjectLocationContentPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(contentPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ContentPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string contentPolicyId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ContentPolicyId = contentPolicyId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ContentPolicyName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/locations/{location}/contentPolicies/{content_policy}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="contentPolicyId">The <c>ContentPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        public ContentPolicyName(string organizationId, string locationId, string contentPolicyId) : this(ResourceNameType.OrganizationLocationContentPolicy, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), contentPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(contentPolicyId, nameof(contentPolicyId)))
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
        /// The <c>ContentPolicy</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ContentPolicyId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

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
                case ResourceNameType.OrganizationLocationContentPolicy: return s_organizationLocationContentPolicy.Expand(OrganizationId, LocationId, ContentPolicyId);
                case ResourceNameType.ProjectLocationContentPolicy: return s_projectLocationContentPolicy.Expand(ProjectId, LocationId, ContentPolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ContentPolicyName);

        /// <inheritdoc/>
        public bool Equals(ContentPolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ContentPolicyName a, ContentPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ContentPolicyName a, ContentPolicyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Service</c> resource.</summary>
    public sealed partial class ServiceName : gax::IResourceName, sys::IEquatable<ServiceName>
    {
        /// <summary>The possible contents of <see cref="ServiceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>.
            /// </summary>
            ProjectLocationNamespaceService = 1,
        }

        private static gax::PathTemplate s_projectLocationNamespaceService = new gax::PathTemplate("projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}");

        /// <summary>Creates a <see cref="ServiceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceName"/> constructed from the provided ids.</returns>
        public static ServiceName FromProjectLocationNamespaceService(string projectId, string locationId, string namespaceId, string serviceId) =>
            new ServiceName(ResourceNameType.ProjectLocationNamespaceService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), namespaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string namespaceId, string serviceId) =>
            FormatProjectLocationNamespaceService(projectId, locationId, namespaceId, serviceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>.
        /// </returns>
        public static string FormatProjectLocationNamespaceService(string projectId, string locationId, string namespaceId, string serviceId) =>
            s_projectLocationNamespaceService.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>Parses the given resource name string into a new <see cref="ServiceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceName"/> if successful.</returns>
        public static ServiceName Parse(string serviceName) => Parse(serviceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceName"/> if successful.</returns>
        public static ServiceName Parse(string serviceName, bool allowUnparsed) =>
            TryParse(serviceName, allowUnparsed, out ServiceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceName, out ServiceName result) => TryParse(serviceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceName, bool allowUnparsed, out ServiceName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceName, nameof(serviceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationNamespaceService.TryParseName(serviceName, out resourceName))
            {
                result = FromProjectLocationNamespaceService(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string namespaceId = null, string projectId = null, string serviceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            NamespaceId = namespaceId;
            ProjectId = projectId;
            ServiceId = serviceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/namespaces/{namespace}/services/{service}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="namespaceId">The <c>Namespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        public ServiceName(string projectId, string locationId, string namespaceId, string serviceId) : this(ResourceNameType.ProjectLocationNamespaceService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), namespaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(namespaceId, nameof(namespaceId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)))
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
        /// The <c>Namespace</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NamespaceId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Service</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ServiceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationNamespaceService: return s_projectLocationNamespaceService.Expand(ProjectId, LocationId, NamespaceId, ServiceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceName);

        /// <inheritdoc/>
        public bool Equals(ServiceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServiceName a, ServiceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServiceName a, ServiceName b) => !(a == b);
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

    public partial class DataProtectionPolicy
    {
        public partial class Types
        {
            public partial class SensitiveDataProtectionPolicy
            {
                /// <summary>
                /// <see cref="ContentPolicyName"/>-typed view over the <see cref="Policy"/> resource name property.
                /// </summary>
                public ContentPolicyName PolicyAsContentPolicyName
                {
                    get => string.IsNullOrEmpty(Policy) ? null : ContentPolicyName.Parse(Policy, allowUnparsed: true);
                    set => Policy = value?.ToString() ?? "";
                }
            }
        }
    }
}
