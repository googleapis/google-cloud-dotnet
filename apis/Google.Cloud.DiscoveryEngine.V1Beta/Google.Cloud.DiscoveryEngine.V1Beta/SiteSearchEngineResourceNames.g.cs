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
using gcdv = Google.Cloud.DiscoveryEngine.V1Beta;
using sys = System;

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    /// <summary>Resource name for the <c>SiteSearchEngine</c> resource.</summary>
    public sealed partial class SiteSearchEngineName : gax::IResourceName, sys::IEquatable<SiteSearchEngineName>
    {
        /// <summary>The possible contents of <see cref="SiteSearchEngineName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine</c>.
            /// </summary>
            ProjectLocationDataStore = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine</c>
            /// .
            /// </summary>
            ProjectLocationCollectionDataStore = 2,
        }

        private static gax::PathTemplate s_projectLocationDataStore = new gax::PathTemplate("projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine");

        private static gax::PathTemplate s_projectLocationCollectionDataStore = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine");

        /// <summary>Creates a <see cref="SiteSearchEngineName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SiteSearchEngineName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SiteSearchEngineName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SiteSearchEngineName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SiteSearchEngineName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SiteSearchEngineName"/> constructed from the provided ids.</returns>
        public static SiteSearchEngineName FromProjectLocationDataStore(string projectId, string locationId, string dataStoreId) =>
            new SiteSearchEngineName(ResourceNameType.ProjectLocationDataStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)));

        /// <summary>
        /// Creates a <see cref="SiteSearchEngineName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SiteSearchEngineName"/> constructed from the provided ids.</returns>
        public static SiteSearchEngineName FromProjectLocationCollectionDataStore(string projectId, string locationId, string collectionId, string dataStoreId) =>
            new SiteSearchEngineName(ResourceNameType.ProjectLocationCollectionDataStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SiteSearchEngineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SiteSearchEngineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataStoreId) =>
            FormatProjectLocationDataStore(projectId, locationId, dataStoreId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SiteSearchEngineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SiteSearchEngineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine</c>.
        /// </returns>
        public static string FormatProjectLocationDataStore(string projectId, string locationId, string dataStoreId) =>
            s_projectLocationDataStore.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SiteSearchEngineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SiteSearchEngineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCollectionDataStore(string projectId, string locationId, string collectionId, string dataStoreId) =>
            s_projectLocationCollectionDataStore.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SiteSearchEngineName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="siteSearchEngineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SiteSearchEngineName"/> if successful.</returns>
        public static SiteSearchEngineName Parse(string siteSearchEngineName) => Parse(siteSearchEngineName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SiteSearchEngineName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="siteSearchEngineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SiteSearchEngineName"/> if successful.</returns>
        public static SiteSearchEngineName Parse(string siteSearchEngineName, bool allowUnparsed) =>
            TryParse(siteSearchEngineName, allowUnparsed, out SiteSearchEngineName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SiteSearchEngineName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="siteSearchEngineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SiteSearchEngineName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string siteSearchEngineName, out SiteSearchEngineName result) =>
            TryParse(siteSearchEngineName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SiteSearchEngineName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="siteSearchEngineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SiteSearchEngineName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string siteSearchEngineName, bool allowUnparsed, out SiteSearchEngineName result)
        {
            gax::GaxPreconditions.CheckNotNull(siteSearchEngineName, nameof(siteSearchEngineName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataStore.TryParseName(siteSearchEngineName, out resourceName))
            {
                result = FromProjectLocationDataStore(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationCollectionDataStore.TryParseName(siteSearchEngineName, out resourceName))
            {
                result = FromProjectLocationCollectionDataStore(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(siteSearchEngineName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SiteSearchEngineName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string collectionId = null, string dataStoreId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CollectionId = collectionId;
            DataStoreId = dataStoreId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SiteSearchEngineName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        public SiteSearchEngineName(string projectId, string locationId, string dataStoreId) : this(ResourceNameType.ProjectLocationDataStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)))
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
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SiteSearchEngineName);

        /// <inheritdoc/>
        public bool Equals(SiteSearchEngineName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SiteSearchEngineName a, SiteSearchEngineName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SiteSearchEngineName a, SiteSearchEngineName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>TargetSite</c> resource.</summary>
    public sealed partial class TargetSiteName : gax::IResourceName, sys::IEquatable<TargetSiteName>
    {
        /// <summary>The possible contents of <see cref="TargetSiteName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
            /// .
            /// </summary>
            ProjectLocationDataStoreTargetSite = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
            /// .
            /// </summary>
            ProjectLocationCollectionDataStoreTargetSite = 2,
        }

        private static gax::PathTemplate s_projectLocationDataStoreTargetSite = new gax::PathTemplate("projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}");

        private static gax::PathTemplate s_projectLocationCollectionDataStoreTargetSite = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}");

        /// <summary>Creates a <see cref="TargetSiteName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TargetSiteName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TargetSiteName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TargetSiteName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TargetSiteName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetSiteId">The <c>TargetSite</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TargetSiteName"/> constructed from the provided ids.</returns>
        public static TargetSiteName FromProjectLocationDataStoreTargetSite(string projectId, string locationId, string dataStoreId, string targetSiteId) =>
            new TargetSiteName(ResourceNameType.ProjectLocationDataStoreTargetSite, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), targetSiteId: gax::GaxPreconditions.CheckNotNullOrEmpty(targetSiteId, nameof(targetSiteId)));

        /// <summary>
        /// Creates a <see cref="TargetSiteName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetSiteId">The <c>TargetSite</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TargetSiteName"/> constructed from the provided ids.</returns>
        public static TargetSiteName FromProjectLocationCollectionDataStoreTargetSite(string projectId, string locationId, string collectionId, string dataStoreId, string targetSiteId) =>
            new TargetSiteName(ResourceNameType.ProjectLocationCollectionDataStoreTargetSite, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), targetSiteId: gax::GaxPreconditions.CheckNotNullOrEmpty(targetSiteId, nameof(targetSiteId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TargetSiteName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetSiteId">The <c>TargetSite</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TargetSiteName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string dataStoreId, string targetSiteId) =>
            FormatProjectLocationDataStoreTargetSite(projectId, locationId, dataStoreId, targetSiteId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TargetSiteName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetSiteId">The <c>TargetSite</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TargetSiteName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationDataStoreTargetSite(string projectId, string locationId, string dataStoreId, string targetSiteId) =>
            s_projectLocationDataStoreTargetSite.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(targetSiteId, nameof(targetSiteId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TargetSiteName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetSiteId">The <c>TargetSite</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TargetSiteName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCollectionDataStoreTargetSite(string projectId, string locationId, string collectionId, string dataStoreId, string targetSiteId) =>
            s_projectLocationCollectionDataStoreTargetSite.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(targetSiteId, nameof(targetSiteId)));

        /// <summary>Parses the given resource name string into a new <see cref="TargetSiteName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="targetSiteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TargetSiteName"/> if successful.</returns>
        public static TargetSiteName Parse(string targetSiteName) => Parse(targetSiteName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TargetSiteName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="targetSiteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TargetSiteName"/> if successful.</returns>
        public static TargetSiteName Parse(string targetSiteName, bool allowUnparsed) =>
            TryParse(targetSiteName, allowUnparsed, out TargetSiteName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TargetSiteName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="targetSiteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TargetSiteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string targetSiteName, out TargetSiteName result) =>
            TryParse(targetSiteName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TargetSiteName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="targetSiteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TargetSiteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string targetSiteName, bool allowUnparsed, out TargetSiteName result)
        {
            gax::GaxPreconditions.CheckNotNull(targetSiteName, nameof(targetSiteName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataStoreTargetSite.TryParseName(targetSiteName, out resourceName))
            {
                result = FromProjectLocationDataStoreTargetSite(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectLocationCollectionDataStoreTargetSite.TryParseName(targetSiteName, out resourceName))
            {
                result = FromProjectLocationCollectionDataStoreTargetSite(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(targetSiteName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TargetSiteName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string collectionId = null, string dataStoreId = null, string locationId = null, string projectId = null, string targetSiteId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CollectionId = collectionId;
            DataStoreId = dataStoreId;
            LocationId = locationId;
            ProjectId = projectId;
            TargetSiteId = targetSiteId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TargetSiteName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/targetSites/{target_site}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="targetSiteId">The <c>TargetSite</c> ID. Must not be <c>null</c> or empty.</param>
        public TargetSiteName(string projectId, string locationId, string dataStoreId, string targetSiteId) : this(ResourceNameType.ProjectLocationDataStoreTargetSite, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), targetSiteId: gax::GaxPreconditions.CheckNotNullOrEmpty(targetSiteId, nameof(targetSiteId)))
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
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>TargetSite</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string TargetSiteId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationDataStoreTargetSite: return s_projectLocationDataStoreTargetSite.Expand(ProjectId, LocationId, DataStoreId, TargetSiteId);
                case ResourceNameType.ProjectLocationCollectionDataStoreTargetSite: return s_projectLocationCollectionDataStoreTargetSite.Expand(ProjectId, LocationId, CollectionId, DataStoreId, TargetSiteId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TargetSiteName);

        /// <inheritdoc/>
        public bool Equals(TargetSiteName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TargetSiteName a, TargetSiteName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TargetSiteName a, TargetSiteName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Sitemap</c> resource.</summary>
    public sealed partial class SitemapName : gax::IResourceName, sys::IEquatable<SitemapName>
    {
        /// <summary>The possible contents of <see cref="SitemapName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>
            /// .
            /// </summary>
            ProjectLocationDataStoreSitemap = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>
            /// .
            /// </summary>
            ProjectLocationCollectionDataStoreSitemap = 2,
        }

        private static gax::PathTemplate s_projectLocationDataStoreSitemap = new gax::PathTemplate("projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}");

        private static gax::PathTemplate s_projectLocationCollectionDataStoreSitemap = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}");

        /// <summary>Creates a <see cref="SitemapName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SitemapName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SitemapName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SitemapName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SitemapName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sitemapId">The <c>Sitemap</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SitemapName"/> constructed from the provided ids.</returns>
        public static SitemapName FromProjectLocationDataStoreSitemap(string projectId, string locationId, string dataStoreId, string sitemapId) =>
            new SitemapName(ResourceNameType.ProjectLocationDataStoreSitemap, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), sitemapId: gax::GaxPreconditions.CheckNotNullOrEmpty(sitemapId, nameof(sitemapId)));

        /// <summary>
        /// Creates a <see cref="SitemapName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sitemapId">The <c>Sitemap</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SitemapName"/> constructed from the provided ids.</returns>
        public static SitemapName FromProjectLocationCollectionDataStoreSitemap(string projectId, string locationId, string collectionId, string dataStoreId, string sitemapId) =>
            new SitemapName(ResourceNameType.ProjectLocationCollectionDataStoreSitemap, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), sitemapId: gax::GaxPreconditions.CheckNotNullOrEmpty(sitemapId, nameof(sitemapId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SitemapName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sitemapId">The <c>Sitemap</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SitemapName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataStoreId, string sitemapId) =>
            FormatProjectLocationDataStoreSitemap(projectId, locationId, dataStoreId, sitemapId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SitemapName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sitemapId">The <c>Sitemap</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SitemapName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>.
        /// </returns>
        public static string FormatProjectLocationDataStoreSitemap(string projectId, string locationId, string dataStoreId, string sitemapId) =>
            s_projectLocationDataStoreSitemap.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sitemapId, nameof(sitemapId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SitemapName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sitemapId">The <c>Sitemap</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SitemapName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCollectionDataStoreSitemap(string projectId, string locationId, string collectionId, string dataStoreId, string sitemapId) =>
            s_projectLocationCollectionDataStoreSitemap.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sitemapId, nameof(sitemapId)));

        /// <summary>Parses the given resource name string into a new <see cref="SitemapName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sitemapName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SitemapName"/> if successful.</returns>
        public static SitemapName Parse(string sitemapName) => Parse(sitemapName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SitemapName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sitemapName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SitemapName"/> if successful.</returns>
        public static SitemapName Parse(string sitemapName, bool allowUnparsed) =>
            TryParse(sitemapName, allowUnparsed, out SitemapName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SitemapName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sitemapName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SitemapName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sitemapName, out SitemapName result) => TryParse(sitemapName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SitemapName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sitemapName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SitemapName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sitemapName, bool allowUnparsed, out SitemapName result)
        {
            gax::GaxPreconditions.CheckNotNull(sitemapName, nameof(sitemapName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataStoreSitemap.TryParseName(sitemapName, out resourceName))
            {
                result = FromProjectLocationDataStoreSitemap(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectLocationCollectionDataStoreSitemap.TryParseName(sitemapName, out resourceName))
            {
                result = FromProjectLocationCollectionDataStoreSitemap(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sitemapName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SitemapName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string collectionId = null, string dataStoreId = null, string locationId = null, string projectId = null, string sitemapId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CollectionId = collectionId;
            DataStoreId = dataStoreId;
            LocationId = locationId;
            ProjectId = projectId;
            SitemapId = sitemapId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SitemapName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/siteSearchEngine/sitemaps/{sitemap}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sitemapId">The <c>Sitemap</c> ID. Must not be <c>null</c> or empty.</param>
        public SitemapName(string projectId, string locationId, string dataStoreId, string sitemapId) : this(ResourceNameType.ProjectLocationDataStoreSitemap, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), sitemapId: gax::GaxPreconditions.CheckNotNullOrEmpty(sitemapId, nameof(sitemapId)))
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
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Sitemap</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string SitemapId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationDataStoreSitemap: return s_projectLocationDataStoreSitemap.Expand(ProjectId, LocationId, DataStoreId, SitemapId);
                case ResourceNameType.ProjectLocationCollectionDataStoreSitemap: return s_projectLocationCollectionDataStoreSitemap.Expand(ProjectId, LocationId, CollectionId, DataStoreId, SitemapId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SitemapName);

        /// <inheritdoc/>
        public bool Equals(SitemapName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SitemapName a, SitemapName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SitemapName a, SitemapName b) => !(a == b);
    }

    public partial class SiteSearchEngine
    {
        /// <summary>
        /// <see cref="gcdv::SiteSearchEngineName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SiteSearchEngineName SiteSearchEngineName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SiteSearchEngineName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TargetSite
    {
        /// <summary>
        /// <see cref="gcdv::TargetSiteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TargetSiteName TargetSiteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TargetSiteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Sitemap
    {
        /// <summary>
        /// <see cref="gcdv::SitemapName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SitemapName SitemapName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SitemapName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
