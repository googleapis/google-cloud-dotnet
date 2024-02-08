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

    public partial class ServingConfig
    {
        /// <summary>
        /// <see cref="gcdv::ServingConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ServingConfigName ServingConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ServingConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
