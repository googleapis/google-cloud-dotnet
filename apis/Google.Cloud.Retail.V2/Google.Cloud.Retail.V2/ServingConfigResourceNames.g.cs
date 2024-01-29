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
using gcrv = Google.Cloud.Retail.V2;
using sys = System;

namespace Google.Cloud.Retail.V2
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
            /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/servingConfigs/{serving_config}</c>.
            /// </summary>
            ProjectLocationCatalogServingConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationCatalogServingConfig = new gax::PathTemplate("projects/{project}/locations/{location}/catalogs/{catalog}/servingConfigs/{serving_config}");

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
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/servingConfigs/{serving_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="servingConfigId">The <c>ServingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServingConfigName"/> constructed from the provided ids.</returns>
        public static ServingConfigName FromProjectLocationCatalogServingConfig(string projectId, string locationId, string catalogId, string servingConfigId) =>
            new ServingConfigName(ResourceNameType.ProjectLocationCatalogServingConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), servingConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(servingConfigId, nameof(servingConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServingConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/servingConfigs/{serving_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="servingConfigId">The <c>ServingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServingConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/servingConfigs/{serving_config}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string catalogId, string servingConfigId) =>
            FormatProjectLocationCatalogServingConfig(projectId, locationId, catalogId, servingConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServingConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/servingConfigs/{serving_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="servingConfigId">The <c>ServingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServingConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/servingConfigs/{serving_config}</c>.
        /// </returns>
        public static string FormatProjectLocationCatalogServingConfig(string projectId, string locationId, string catalogId, string servingConfigId) =>
            s_projectLocationCatalogServingConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), gax::GaxPreconditions.CheckNotNullOrEmpty(servingConfigId, nameof(servingConfigId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServingConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/servingConfigs/{serving_config}</c>
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
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/servingConfigs/{serving_config}</c>
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
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/servingConfigs/{serving_config}</c>
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
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/servingConfigs/{serving_config}</c>
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
            if (s_projectLocationCatalogServingConfig.TryParseName(servingConfigName, out resourceName))
            {
                result = FromProjectLocationCatalogServingConfig(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
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

        private ServingConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string catalogId = null, string locationId = null, string projectId = null, string servingConfigId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CatalogId = catalogId;
            LocationId = locationId;
            ProjectId = projectId;
            ServingConfigId = servingConfigId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServingConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/servingConfigs/{serving_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="servingConfigId">The <c>ServingConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public ServingConfigName(string projectId, string locationId, string catalogId, string servingConfigId) : this(ResourceNameType.ProjectLocationCatalogServingConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), servingConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(servingConfigId, nameof(servingConfigId)))
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
        /// The <c>Catalog</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CatalogId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>ServingConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
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
                case ResourceNameType.ProjectLocationCatalogServingConfig: return s_projectLocationCatalogServingConfig.Expand(ProjectId, LocationId, CatalogId, ServingConfigId);
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
        /// <see cref="gcrv::ServingConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::ServingConfigName ServingConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::ServingConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
