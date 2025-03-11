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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcdv = Google.Cloud.Dataplex.V1;
using sys = System;

namespace Google.Cloud.Dataplex.V1
{
    /// <summary>Resource name for the <c>DataTaxonomy</c> resource.</summary>
    public sealed partial class DataTaxonomyName : gax::IResourceName, sys::IEquatable<DataTaxonomyName>
    {
        /// <summary>The possible contents of <see cref="DataTaxonomyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/dataTaxonomies/{data_taxonomy_id}</c>.
            /// </summary>
            ProjectLocationDataTaxonomy = 1,
        }

        private static gax::PathTemplate s_projectLocationDataTaxonomy = new gax::PathTemplate("projects/{project}/locations/{location}/dataTaxonomies/{data_taxonomy_id}");

        /// <summary>Creates a <see cref="DataTaxonomyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataTaxonomyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataTaxonomyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataTaxonomyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataTaxonomyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataTaxonomies/{data_taxonomy_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTaxonomyId">The <c>DataTaxonomy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataTaxonomyName"/> constructed from the provided ids.</returns>
        public static DataTaxonomyName FromProjectLocationDataTaxonomy(string projectId, string locationId, string dataTaxonomyId) =>
            new DataTaxonomyName(ResourceNameType.ProjectLocationDataTaxonomy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataTaxonomyId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataTaxonomyId, nameof(dataTaxonomyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataTaxonomyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataTaxonomies/{data_taxonomy_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTaxonomyId">The <c>DataTaxonomy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataTaxonomyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataTaxonomies/{data_taxonomy_id}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataTaxonomyId) =>
            FormatProjectLocationDataTaxonomy(projectId, locationId, dataTaxonomyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataTaxonomyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataTaxonomies/{data_taxonomy_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTaxonomyId">The <c>DataTaxonomy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataTaxonomyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataTaxonomies/{data_taxonomy_id}</c>.
        /// </returns>
        public static string FormatProjectLocationDataTaxonomy(string projectId, string locationId, string dataTaxonomyId) =>
            s_projectLocationDataTaxonomy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataTaxonomyId, nameof(dataTaxonomyId)));

        /// <summary>Parses the given resource name string into a new <see cref="DataTaxonomyName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataTaxonomies/{data_taxonomy_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataTaxonomyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataTaxonomyName"/> if successful.</returns>
        public static DataTaxonomyName Parse(string dataTaxonomyName) => Parse(dataTaxonomyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataTaxonomyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataTaxonomies/{data_taxonomy_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataTaxonomyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataTaxonomyName"/> if successful.</returns>
        public static DataTaxonomyName Parse(string dataTaxonomyName, bool allowUnparsed) =>
            TryParse(dataTaxonomyName, allowUnparsed, out DataTaxonomyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataTaxonomyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataTaxonomies/{data_taxonomy_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataTaxonomyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataTaxonomyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataTaxonomyName, out DataTaxonomyName result) =>
            TryParse(dataTaxonomyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataTaxonomyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/dataTaxonomies/{data_taxonomy_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataTaxonomyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataTaxonomyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataTaxonomyName, bool allowUnparsed, out DataTaxonomyName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataTaxonomyName, nameof(dataTaxonomyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataTaxonomy.TryParseName(dataTaxonomyName, out resourceName))
            {
                result = FromProjectLocationDataTaxonomy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataTaxonomyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataTaxonomyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataTaxonomyId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataTaxonomyId = dataTaxonomyId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataTaxonomyName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataTaxonomies/{data_taxonomy_id}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTaxonomyId">The <c>DataTaxonomy</c> ID. Must not be <c>null</c> or empty.</param>
        public DataTaxonomyName(string projectId, string locationId, string dataTaxonomyId) : this(ResourceNameType.ProjectLocationDataTaxonomy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataTaxonomyId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataTaxonomyId, nameof(dataTaxonomyId)))
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
        /// The <c>DataTaxonomy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string DataTaxonomyId { get; }

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
                case ResourceNameType.ProjectLocationDataTaxonomy: return s_projectLocationDataTaxonomy.Expand(ProjectId, LocationId, DataTaxonomyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataTaxonomyName);

        /// <inheritdoc/>
        public bool Equals(DataTaxonomyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataTaxonomyName a, DataTaxonomyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataTaxonomyName a, DataTaxonomyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DataAttribute</c> resource.</summary>
    public sealed partial class DataAttributeName : gax::IResourceName, sys::IEquatable<DataAttributeName>
    {
        /// <summary>The possible contents of <see cref="DataAttributeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}</c>
            /// .
            /// </summary>
            ProjectLocationDataTaxonomyDataAttribute = 1,
        }

        private static gax::PathTemplate s_projectLocationDataTaxonomyDataAttribute = new gax::PathTemplate("projects/{project}/locations/{location}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}");

        /// <summary>Creates a <see cref="DataAttributeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataAttributeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataAttributeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataAttributeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataAttributeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTaxonomyId">The <c>DataTaxonomy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAttributeId">The <c>DataAttribute</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataAttributeName"/> constructed from the provided ids.</returns>
        public static DataAttributeName FromProjectLocationDataTaxonomyDataAttribute(string projectId, string locationId, string dataTaxonomyId, string dataAttributeId) =>
            new DataAttributeName(ResourceNameType.ProjectLocationDataTaxonomyDataAttribute, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataTaxonomyId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataTaxonomyId, nameof(dataTaxonomyId)), dataAttributeId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataAttributeId, nameof(dataAttributeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataAttributeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTaxonomyId">The <c>DataTaxonomy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAttributeId">The <c>DataAttribute</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataAttributeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataTaxonomyId, string dataAttributeId) =>
            FormatProjectLocationDataTaxonomyDataAttribute(projectId, locationId, dataTaxonomyId, dataAttributeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataAttributeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTaxonomyId">The <c>DataTaxonomy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAttributeId">The <c>DataAttribute</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataAttributeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}</c>.
        /// </returns>
        public static string FormatProjectLocationDataTaxonomyDataAttribute(string projectId, string locationId, string dataTaxonomyId, string dataAttributeId) =>
            s_projectLocationDataTaxonomyDataAttribute.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataTaxonomyId, nameof(dataTaxonomyId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataAttributeId, nameof(dataAttributeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataAttributeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataAttributeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataAttributeName"/> if successful.</returns>
        public static DataAttributeName Parse(string dataAttributeName) => Parse(dataAttributeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataAttributeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataAttributeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataAttributeName"/> if successful.</returns>
        public static DataAttributeName Parse(string dataAttributeName, bool allowUnparsed) =>
            TryParse(dataAttributeName, allowUnparsed, out DataAttributeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataAttributeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataAttributeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataAttributeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataAttributeName, out DataAttributeName result) =>
            TryParse(dataAttributeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataAttributeName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataAttributeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataAttributeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataAttributeName, bool allowUnparsed, out DataAttributeName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataAttributeName, nameof(dataAttributeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataTaxonomyDataAttribute.TryParseName(dataAttributeName, out resourceName))
            {
                result = FromProjectLocationDataTaxonomyDataAttribute(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataAttributeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataAttributeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataAttributeId = null, string dataTaxonomyId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataAttributeId = dataAttributeId;
            DataTaxonomyId = dataTaxonomyId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataAttributeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/dataTaxonomies/{dataTaxonomy}/attributes/{data_attribute_id}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataTaxonomyId">The <c>DataTaxonomy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAttributeId">The <c>DataAttribute</c> ID. Must not be <c>null</c> or empty.</param>
        public DataAttributeName(string projectId, string locationId, string dataTaxonomyId, string dataAttributeId) : this(ResourceNameType.ProjectLocationDataTaxonomyDataAttribute, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataTaxonomyId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataTaxonomyId, nameof(dataTaxonomyId)), dataAttributeId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataAttributeId, nameof(dataAttributeId)))
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
        /// The <c>DataAttribute</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string DataAttributeId { get; }

        /// <summary>
        /// The <c>DataTaxonomy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string DataTaxonomyId { get; }

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
                case ResourceNameType.ProjectLocationDataTaxonomyDataAttribute: return s_projectLocationDataTaxonomyDataAttribute.Expand(ProjectId, LocationId, DataTaxonomyId, DataAttributeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataAttributeName);

        /// <inheritdoc/>
        public bool Equals(DataAttributeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataAttributeName a, DataAttributeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataAttributeName a, DataAttributeName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DataAttributeBinding</c> resource.</summary>
    public sealed partial class DataAttributeBindingName : gax::IResourceName, sys::IEquatable<DataAttributeBindingName>
    {
        /// <summary>The possible contents of <see cref="DataAttributeBindingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/dataAttributeBindings/{data_attribute_binding_id}</c>.
            /// </summary>
            ProjectLocationDataAttributeBinding = 1,
        }

        private static gax::PathTemplate s_projectLocationDataAttributeBinding = new gax::PathTemplate("projects/{project}/locations/{location}/dataAttributeBindings/{data_attribute_binding_id}");

        /// <summary>Creates a <see cref="DataAttributeBindingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataAttributeBindingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DataAttributeBindingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataAttributeBindingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataAttributeBindingName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/dataAttributeBindings/{data_attribute_binding_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAttributeBindingId">
        /// The <c>DataAttributeBinding</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="DataAttributeBindingName"/> constructed from the provided ids.
        /// </returns>
        public static DataAttributeBindingName FromProjectLocationDataAttributeBinding(string projectId, string locationId, string dataAttributeBindingId) =>
            new DataAttributeBindingName(ResourceNameType.ProjectLocationDataAttributeBinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataAttributeBindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataAttributeBindingId, nameof(dataAttributeBindingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataAttributeBindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataAttributeBindings/{data_attribute_binding_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAttributeBindingId">
        /// The <c>DataAttributeBinding</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DataAttributeBindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataAttributeBindings/{data_attribute_binding_id}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string dataAttributeBindingId) =>
            FormatProjectLocationDataAttributeBinding(projectId, locationId, dataAttributeBindingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataAttributeBindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataAttributeBindings/{data_attribute_binding_id}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAttributeBindingId">
        /// The <c>DataAttributeBinding</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DataAttributeBindingName"/> with pattern
        /// <c>projects/{project}/locations/{location}/dataAttributeBindings/{data_attribute_binding_id}</c>.
        /// </returns>
        public static string FormatProjectLocationDataAttributeBinding(string projectId, string locationId, string dataAttributeBindingId) =>
            s_projectLocationDataAttributeBinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dataAttributeBindingId, nameof(dataAttributeBindingId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataAttributeBindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataAttributeBindings/{data_attribute_binding_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataAttributeBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataAttributeBindingName"/> if successful.</returns>
        public static DataAttributeBindingName Parse(string dataAttributeBindingName) =>
            Parse(dataAttributeBindingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataAttributeBindingName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataAttributeBindings/{data_attribute_binding_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataAttributeBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataAttributeBindingName"/> if successful.</returns>
        public static DataAttributeBindingName Parse(string dataAttributeBindingName, bool allowUnparsed) =>
            TryParse(dataAttributeBindingName, allowUnparsed, out DataAttributeBindingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataAttributeBindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataAttributeBindings/{data_attribute_binding_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataAttributeBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataAttributeBindingName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataAttributeBindingName, out DataAttributeBindingName result) =>
            TryParse(dataAttributeBindingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataAttributeBindingName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/dataAttributeBindings/{data_attribute_binding_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataAttributeBindingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataAttributeBindingName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataAttributeBindingName, bool allowUnparsed, out DataAttributeBindingName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataAttributeBindingName, nameof(dataAttributeBindingName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDataAttributeBinding.TryParseName(dataAttributeBindingName, out resourceName))
            {
                result = FromProjectLocationDataAttributeBinding(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataAttributeBindingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DataAttributeBindingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dataAttributeBindingId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DataAttributeBindingId = dataAttributeBindingId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataAttributeBindingName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/dataAttributeBindings/{data_attribute_binding_id}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataAttributeBindingId">
        /// The <c>DataAttributeBinding</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public DataAttributeBindingName(string projectId, string locationId, string dataAttributeBindingId) : this(ResourceNameType.ProjectLocationDataAttributeBinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), dataAttributeBindingId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataAttributeBindingId, nameof(dataAttributeBindingId)))
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
        /// The <c>DataAttributeBinding</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string DataAttributeBindingId { get; }

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
                case ResourceNameType.ProjectLocationDataAttributeBinding: return s_projectLocationDataAttributeBinding.Expand(ProjectId, LocationId, DataAttributeBindingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataAttributeBindingName);

        /// <inheritdoc/>
        public bool Equals(DataAttributeBindingName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataAttributeBindingName a, DataAttributeBindingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataAttributeBindingName a, DataAttributeBindingName b) => !(a == b);
    }

    public partial class DataTaxonomy
    {
        /// <summary>
        /// <see cref="gcdv::DataTaxonomyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public gcdv::DataTaxonomyName DataTaxonomyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataTaxonomyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DataAttribute
    {
        /// <summary>
        /// <see cref="gcdv::DataAttributeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public gcdv::DataAttributeName DataAttributeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataAttributeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcdv::DataAttributeName"/>-typed view over the <see cref="ParentId"/> resource name property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public gcdv::DataAttributeName ParentIdAsDataAttributeName
        {
            get => string.IsNullOrEmpty(ParentId) ? null : gcdv::DataAttributeName.Parse(ParentId, allowUnparsed: true);
            set => ParentId = value?.ToString() ?? "";
        }
    }

    public partial class DataAttributeBinding
    {
        /// <summary>
        /// <see cref="gcdv::DataAttributeBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public gcdv::DataAttributeBindingName DataAttributeBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataAttributeBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="DataAttributeName"/>-typed view over the <see cref="Attributes"/> resource name property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public gax::ResourceNameList<DataAttributeName> AttributesAsDataAttributeNames
        {
            get => new gax::ResourceNameList<DataAttributeName>(Attributes, s => string.IsNullOrEmpty(s) ? null : DataAttributeName.Parse(s, allowUnparsed: true));
        }

        public partial class Types
        {
            public partial class Path
            {
                /// <summary>
                /// <see cref="DataAttributeName"/>-typed view over the <see cref="Attributes"/> resource name property.
                /// </summary>
                public gax::ResourceNameList<DataAttributeName> AttributesAsDataAttributeNames
                {
                    get => new gax::ResourceNameList<DataAttributeName>(Attributes, s => string.IsNullOrEmpty(s) ? null : DataAttributeName.Parse(s, allowUnparsed: true));
                }
            }
        }
    }

    public partial class CreateDataTaxonomyRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDataTaxonomyRequest
    {
        /// <summary>
        /// <see cref="gcdv::DataTaxonomyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public gcdv::DataTaxonomyName DataTaxonomyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataTaxonomyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataTaxonomiesRequest
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

    public partial class DeleteDataTaxonomyRequest
    {
        /// <summary>
        /// <see cref="gcdv::DataTaxonomyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        [sys::ObsoleteAttribute]
        public gcdv::DataTaxonomyName DataTaxonomyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataTaxonomyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDataAttributeRequest
    {
        /// <summary>
        /// <see cref="DataTaxonomyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataTaxonomyName ParentAsDataTaxonomyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataTaxonomyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDataAttributeRequest
    {
        /// <summary>
        /// <see cref="gcdv::DataAttributeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DataAttributeName DataAttributeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataAttributeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataAttributesRequest
    {
        /// <summary>
        /// <see cref="DataTaxonomyName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DataTaxonomyName ParentAsDataTaxonomyName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DataTaxonomyName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDataAttributeRequest
    {
        /// <summary>
        /// <see cref="gcdv::DataAttributeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DataAttributeName DataAttributeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataAttributeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDataAttributeBindingRequest
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

    public partial class GetDataAttributeBindingRequest
    {
        /// <summary>
        /// <see cref="gcdv::DataAttributeBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DataAttributeBindingName DataAttributeBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataAttributeBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataAttributeBindingsRequest
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

    public partial class DeleteDataAttributeBindingRequest
    {
        /// <summary>
        /// <see cref="gcdv::DataAttributeBindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DataAttributeBindingName DataAttributeBindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataAttributeBindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
