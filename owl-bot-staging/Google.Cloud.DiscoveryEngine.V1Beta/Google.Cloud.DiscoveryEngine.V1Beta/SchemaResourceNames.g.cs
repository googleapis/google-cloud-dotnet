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
using gcdv = Google.Cloud.DiscoveryEngine.V1Beta;
using sys = System;

namespace Google.Cloud.DiscoveryEngine.V1Beta
{
    /// <summary>Resource name for the <c>Schema</c> resource.</summary>
    public sealed partial class SchemaName : gax::IResourceName, sys::IEquatable<SchemaName>
    {
        /// <summary>The possible contents of <see cref="SchemaName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/schemas/{schema}</c>.
            /// </summary>
            ProjectLocationDataStoreSchema = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}</c>
            /// .
            /// </summary>
            ProjectLocationCollectionDataStoreSchema = 2,
        }

        private static gax::PathTemplate s_projectLocationDataStoreSchema = new gax::PathTemplate("projects/{project}/locations/{location}/dataStores/{data_store}/schemas/{schema}");

        private static gax::PathTemplate s_projectLocationCollectionDataStoreSchema = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}");

        /// <summary>Creates a <see cref="SchemaName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SchemaName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SchemaName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SchemaName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SchemaName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/schemas/{schema}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="schemaId">The <c>Schema</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SchemaName"/> constructed from the provided ids.</returns>
        public static SchemaName FromProjectLocationDataStoreSchema(string projectId, string locationId, string dataStoreId, string schemaId) =>
            new SchemaName(ResourceNameType.ProjectLocationDataStoreSchema, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), schemaId: gax::GaxPreconditions.CheckNotNullOrEmpty(schemaId, nameof(schemaId)));

        /// <summary>
        /// Creates a <see cref="SchemaName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="schemaId">The <c>Schema</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SchemaName"/> constructed from the provided ids.</returns>
        public static SchemaName FromProjectLocationCollectionDataStoreSchema(string projectId, string locationId, string collectionId, string dataStoreId, string schemaId) =>
            new SchemaName(ResourceNameType.ProjectLocationCollectionDataStoreSchema, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), schemaId: gax::GaxPreconditions.CheckNotNullOrEmpty(schemaId, nameof(schemaId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SchemaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/schemas/{schema}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="schemaId">The <c>Schema</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SchemaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/schemas/{schema}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataStoreId, string schemaId) =>
            FormatProjectLocationDataStoreSchema(projectId, locationId, dataStoreId, schemaId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SchemaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/schemas/{schema}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="schemaId">The <c>Schema</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SchemaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/schemas/{schema}</c>.
        /// </returns>
        public static string FormatProjectLocationDataStoreSchema(string projectId, string locationId, string dataStoreId, string schemaId) =>
            s_projectLocationDataStoreSchema.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(schemaId, nameof(schemaId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SchemaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="schemaId">The <c>Schema</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SchemaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCollectionDataStoreSchema(string projectId, string locationId, string collectionId, string dataStoreId, string schemaId) =>
            s_projectLocationCollectionDataStoreSchema.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(schemaId, nameof(schemaId)));

        /// <summary>Parses the given resource name string into a new <see cref="SchemaName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/schemas/{schema}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="schemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SchemaName"/> if successful.</returns>
        public static SchemaName Parse(string schemaName) => Parse(schemaName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SchemaName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/schemas/{schema}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="schemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SchemaName"/> if successful.</returns>
        public static SchemaName Parse(string schemaName, bool allowUnparsed) =>
            TryParse(schemaName, allowUnparsed, out SchemaName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SchemaName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/schemas/{schema}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="schemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SchemaName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string schemaName, out SchemaName result) => TryParse(schemaName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SchemaName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/schemas/{schema}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/dataStores/{data_store}/schemas/{schema}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="schemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SchemaName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string schemaName, bool allowUnparsed, out SchemaName result)
        {
            gax::GaxPreconditions.CheckNotNull(schemaName, nameof(schemaName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataStoreSchema.TryParseName(schemaName, out resourceName))
            {
                result = FromProjectLocationDataStoreSchema(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectLocationCollectionDataStoreSchema.TryParseName(schemaName, out resourceName))
            {
                result = FromProjectLocationCollectionDataStoreSchema(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(schemaName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SchemaName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string collectionId = null, string dataStoreId = null, string locationId = null, string projectId = null, string schemaId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CollectionId = collectionId;
            DataStoreId = dataStoreId;
            LocationId = locationId;
            ProjectId = projectId;
            SchemaId = schemaId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SchemaName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataStores/{data_store}/schemas/{schema}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataStoreId">The <c>DataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="schemaId">The <c>Schema</c> ID. Must not be <c>null</c> or empty.</param>
        public SchemaName(string projectId, string locationId, string dataStoreId, string schemaId) : this(ResourceNameType.ProjectLocationDataStoreSchema, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataStoreId, nameof(dataStoreId)), schemaId: gax::GaxPreconditions.CheckNotNullOrEmpty(schemaId, nameof(schemaId)))
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
        /// The <c>Schema</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string SchemaId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationDataStoreSchema: return s_projectLocationDataStoreSchema.Expand(ProjectId, LocationId, DataStoreId, SchemaId);
                case ResourceNameType.ProjectLocationCollectionDataStoreSchema: return s_projectLocationCollectionDataStoreSchema.Expand(ProjectId, LocationId, CollectionId, DataStoreId, SchemaId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SchemaName);

        /// <inheritdoc/>
        public bool Equals(SchemaName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SchemaName a, SchemaName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SchemaName a, SchemaName b) => !(a == b);
    }

    public partial class Schema
    {
        /// <summary>
        /// <see cref="gcdv::SchemaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SchemaName SchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
