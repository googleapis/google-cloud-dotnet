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
using gcdv = Google.Cloud.Dataplex.V1;
using sys = System;

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Resource name for the <c>DataProduct</c> resource.</summary>
    public sealed partial class DataProductName : gax::IResourceName, sys::IEquatable<DataProductName>
    {
        /// <summary>The possible contents of <see cref="DataProductName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/dataProducts/{data_product}</c>.
            /// </summary>
            ProjectLocationDataProduct = 1,
        }

        private static gax::PathTemplate s_projectLocationDataProduct = new gax::PathTemplate("projects/{project}/locations/{location}/dataProducts/{data_product}");

        /// <summary>Creates a <see cref="DataProductName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataProductName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataProductName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataProductName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataProductName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataProducts/{data_product}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataProductId">The <c>DataProduct</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataProductName"/> constructed from the provided ids.</returns>
        public static DataProductName FromProjectLocationDataProduct(string projectId, string locationId, string dataProductId) =>
            new DataProductName(ResourceNameType.ProjectLocationDataProduct, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataProductId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataProductId, nameof(dataProductId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataProductName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataProducts/{data_product}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataProductId">The <c>DataProduct</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataProductName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataProducts/{data_product}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataProductId) =>
            FormatProjectLocationDataProduct(projectId, locationId, dataProductId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataProductName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataProducts/{data_product}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataProductId">The <c>DataProduct</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataProductName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataProducts/{data_product}</c>.
        /// </returns>
        public static string FormatProjectLocationDataProduct(string projectId, string locationId, string dataProductId) =>
            s_projectLocationDataProduct.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataProductId, nameof(dataProductId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataProductName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataProducts/{data_product}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataProductName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataProductName"/> if successful.</returns>
        public static DataProductName Parse(string dataProductName) => Parse(dataProductName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataProductName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataProducts/{data_product}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataProductName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataProductName"/> if successful.</returns>
        public static DataProductName Parse(string dataProductName, bool allowUnparsed) =>
            TryParse(dataProductName, allowUnparsed, out DataProductName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataProductName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataProducts/{data_product}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataProductName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataProductName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataProductName, out DataProductName result) =>
            TryParse(dataProductName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataProductName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataProducts/{data_product}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataProductName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataProductName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataProductName, bool allowUnparsed, out DataProductName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataProductName, nameof(dataProductName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataProduct.TryParseName(dataProductName, out resourceName))
            {
                result = FromProjectLocationDataProduct(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataProductName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataProductName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataProductId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataProductId = dataProductId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataProductName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataProducts/{data_product}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataProductId">The <c>DataProduct</c> ID. Must not be <c>null</c> or empty.</param>
        public DataProductName(string projectId, string locationId, string dataProductId) : this(ResourceNameType.ProjectLocationDataProduct, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataProductId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataProductId, nameof(dataProductId)))
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
        /// The <c>DataProduct</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataProductId { get; }

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
                case ResourceNameType.ProjectLocationDataProduct: return s_projectLocationDataProduct.Expand(ProjectId, LocationId, DataProductId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataProductName);

        /// <inheritdoc/>
        public bool Equals(DataProductName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataProductName a, DataProductName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataProductName a, DataProductName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DataAsset</c> resource.</summary>
    public sealed partial class DataAssetName : gax::IResourceName, sys::IEquatable<DataAssetName>
    {
        /// <summary>The possible contents of <see cref="DataAssetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/dataProducts/{data_product}/dataAssets/{data_asset}</c>.
            /// </summary>
            ProjectLocationDataProductDataAsset = 1,
        }

        private static gax::PathTemplate s_projectLocationDataProductDataAsset = new gax::PathTemplate("projects/{project}/locations/{location}/dataProducts/{data_product}/dataAssets/{data_asset}");

        /// <summary>Creates a <see cref="DataAssetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataAssetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataAssetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataAssetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataAssetName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataProducts/{data_product}/dataAssets/{data_asset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataProductId">The <c>DataProduct</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAssetId">The <c>DataAsset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataAssetName"/> constructed from the provided ids.</returns>
        public static DataAssetName FromProjectLocationDataProductDataAsset(string projectId, string locationId, string dataProductId, string dataAssetId) =>
            new DataAssetName(ResourceNameType.ProjectLocationDataProductDataAsset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataProductId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataProductId, nameof(dataProductId)), dataAssetId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataAssetId, nameof(dataAssetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataAssetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataProducts/{data_product}/dataAssets/{data_asset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataProductId">The <c>DataProduct</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAssetId">The <c>DataAsset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataAssetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataProducts/{data_product}/dataAssets/{data_asset}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataProductId, string dataAssetId) =>
            FormatProjectLocationDataProductDataAsset(projectId, locationId, dataProductId, dataAssetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataAssetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataProducts/{data_product}/dataAssets/{data_asset}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataProductId">The <c>DataProduct</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAssetId">The <c>DataAsset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataAssetName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataProducts/{data_product}/dataAssets/{data_asset}</c>.
        /// </returns>
        public static string FormatProjectLocationDataProductDataAsset(string projectId, string locationId, string dataProductId, string dataAssetId) =>
            s_projectLocationDataProductDataAsset.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataProductId, nameof(dataProductId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataAssetId, nameof(dataAssetId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataAssetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataProducts/{data_product}/dataAssets/{data_asset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataAssetName"/> if successful.</returns>
        public static DataAssetName Parse(string dataAssetName) => Parse(dataAssetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataAssetName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataProducts/{data_product}/dataAssets/{data_asset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataAssetName"/> if successful.</returns>
        public static DataAssetName Parse(string dataAssetName, bool allowUnparsed) =>
            TryParse(dataAssetName, allowUnparsed, out DataAssetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataAssetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataProducts/{data_product}/dataAssets/{data_asset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataAssetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataAssetName, out DataAssetName result) => TryParse(dataAssetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataAssetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataProducts/{data_product}/dataAssets/{data_asset}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataAssetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataAssetName, bool allowUnparsed, out DataAssetName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataAssetName, nameof(dataAssetName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataProductDataAsset.TryParseName(dataAssetName, out resourceName))
            {
                result = FromProjectLocationDataProductDataAsset(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataAssetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataAssetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataAssetId = null, string dataProductId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataAssetId = dataAssetId;
            DataProductId = dataProductId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataAssetName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataProducts/{data_product}/dataAssets/{data_asset}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataProductId">The <c>DataProduct</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAssetId">The <c>DataAsset</c> ID. Must not be <c>null</c> or empty.</param>
        public DataAssetName(string projectId, string locationId, string dataProductId, string dataAssetId) : this(ResourceNameType.ProjectLocationDataProductDataAsset, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataProductId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataProductId, nameof(dataProductId)), dataAssetId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataAssetId, nameof(dataAssetId)))
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
        /// The <c>DataAsset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataAssetId { get; }

        /// <summary>
        /// The <c>DataProduct</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataProductId { get; }

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
                case ResourceNameType.ProjectLocationDataProductDataAsset: return s_projectLocationDataProductDataAsset.Expand(ProjectId, LocationId, DataProductId, DataAssetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataAssetName);

        /// <inheritdoc/>
        public bool Equals(DataAssetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataAssetName a, DataAssetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataAssetName a, DataAssetName b) => !(a == b);
    }

    public partial class DataProduct
    {
        /// <summary>
        /// <see cref="gcdv::DataProductName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DataProductName DataProductName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataProductName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DataAsset
    {
        /// <summary>
        /// <see cref="gcdv::DataAssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DataAssetName DataAssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataAssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDataProductRequest
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

    public partial class DeleteDataProductRequest
    {
        /// <summary>
        /// <see cref="gcdv::DataProductName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DataProductName DataProductName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataProductName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDataProductRequest
    {
        /// <summary>
        /// <see cref="gcdv::DataProductName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DataProductName DataProductName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataProductName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataProductsRequest
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

    public partial class CreateDataAssetRequest
    {
        /// <summary>
        /// <see cref="DataProductName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataProductName ParentAsDataProductName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataProductName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDataAssetRequest
    {
        /// <summary>
        /// <see cref="gcdv::DataAssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DataAssetName DataAssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataAssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDataAssetRequest
    {
        /// <summary>
        /// <see cref="gcdv::DataAssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DataAssetName DataAssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataAssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataAssetsRequest
    {
        /// <summary>
        /// <see cref="DataProductName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataProductName ParentAsDataProductName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataProductName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
