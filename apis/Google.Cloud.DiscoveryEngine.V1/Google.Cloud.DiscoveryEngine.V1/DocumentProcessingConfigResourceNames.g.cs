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
    /// <summary>Resource name for the <c>DocumentProcessingConfig</c> resource.</summary>
    public sealed partial class DocumentProcessingConfigName : gax::IResourceName, sys::IEquatable<DocumentProcessingConfigName>
    {
        /// <summary>The possible contents of <see cref="DocumentProcessingConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/documentProcessingConfig</c>.
            /// </summary>
            ProjectLocationDataStore = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/documentProcessingConfig</c>
            /// .
            /// </summary>
            ProjectLocationCollectionDataStore = 2,
        }

        private static gax::PathTemplate s_projectLocationDataStore = new gax::PathTemplate("projects/{project}/locations/{location}/dataStores/{data_store}/documentProcessingConfig");

        private static gax::PathTemplate s_projectLocationCollectionDataStore = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/documentProcessingConfig");

        /// <summary>
        /// Creates a <see cref="DocumentProcessingConfigName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DocumentProcessingConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DocumentProcessingConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DocumentProcessingConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DocumentProcessingConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/documentProcessingConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="DocumentProcessingConfigName"/> constructed from the provided ids.
        /// </returns>
        public static DocumentProcessingConfigName FromProjectLocationDataStore(string projectId, string locationId, string dataStoreId) =>
            new DocumentProcessingConfigName(ResourceNameType.ProjectLocationDataStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)));

        /// <summary>
        /// Creates a <see cref="DocumentProcessingConfigName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/documentProcessingConfig</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="DocumentProcessingConfigName"/> constructed from the provided ids.
        /// </returns>
        public static DocumentProcessingConfigName FromProjectLocationCollectionDataStore(string projectId, string locationId, string collectionId, string dataStoreId) =>
            new DocumentProcessingConfigName(ResourceNameType.ProjectLocationCollectionDataStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DocumentProcessingConfigName"/> with
        /// pattern <c>projects/{project}/locations/{location}/dataStores/{data_store}/documentProcessingConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DocumentProcessingConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/documentProcessingConfig</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataStoreId) =>
            FormatProjectLocationDataStore(projectId, locationId, dataStoreId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DocumentProcessingConfigName"/> with
        /// pattern <c>projects/{project}/locations/{location}/dataStores/{data_store}/documentProcessingConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DocumentProcessingConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/documentProcessingConfig</c>.
        /// </returns>
        public static string FormatProjectLocationDataStore(string projectId, string locationId, string dataStoreId) =>
            s_projectLocationDataStore.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DocumentProcessingConfigName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/documentProcessingConfig</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DocumentProcessingConfigName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/documentProcessingConfig</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCollectionDataStore(string projectId, string locationId, string collectionId, string dataStoreId) =>
            s_projectLocationCollectionDataStore.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DocumentProcessingConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/documentProcessingConfig</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/documentProcessingConfig</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="documentProcessingConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="DocumentProcessingConfigName"/> if successful.</returns>
        public static DocumentProcessingConfigName Parse(string documentProcessingConfigName) =>
            Parse(documentProcessingConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DocumentProcessingConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/documentProcessingConfig</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/documentProcessingConfig</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="documentProcessingConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DocumentProcessingConfigName"/> if successful.</returns>
        public static DocumentProcessingConfigName Parse(string documentProcessingConfigName, bool allowUnparsed) =>
            TryParse(documentProcessingConfigName, allowUnparsed, out DocumentProcessingConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DocumentProcessingConfigName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/documentProcessingConfig</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/documentProcessingConfig</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="documentProcessingConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DocumentProcessingConfigName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string documentProcessingConfigName, out DocumentProcessingConfigName result) =>
            TryParse(documentProcessingConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DocumentProcessingConfigName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/documentProcessingConfig</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/documentProcessingConfig</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="documentProcessingConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DocumentProcessingConfigName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string documentProcessingConfigName, bool allowUnparsed, out DocumentProcessingConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(documentProcessingConfigName, nameof(documentProcessingConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataStore.TryParseName(documentProcessingConfigName, out resourceName))
            {
                result = FromProjectLocationDataStore(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationCollectionDataStore.TryParseName(documentProcessingConfigName, out resourceName))
            {
                result = FromProjectLocationCollectionDataStore(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(documentProcessingConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DocumentProcessingConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string collectionId = null, string dataStoreId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CollectionId = collectionId;
            DataStoreId = dataStoreId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DocumentProcessingConfigName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/dataStores/{data_store}/documentProcessingConfig</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        public DocumentProcessingConfigName(string projectId, string locationId, string dataStoreId) : this(ResourceNameType.ProjectLocationDataStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)))
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
        public override bool Equals(object obj) => Equals(obj as DocumentProcessingConfigName);

        /// <inheritdoc/>
        public bool Equals(DocumentProcessingConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DocumentProcessingConfigName a, DocumentProcessingConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DocumentProcessingConfigName a, DocumentProcessingConfigName b) => !(a == b);
    }

    public partial class DocumentProcessingConfig
    {
        /// <summary>
        /// <see cref="gcdv::DocumentProcessingConfigName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdv::DocumentProcessingConfigName DocumentProcessingConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DocumentProcessingConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
