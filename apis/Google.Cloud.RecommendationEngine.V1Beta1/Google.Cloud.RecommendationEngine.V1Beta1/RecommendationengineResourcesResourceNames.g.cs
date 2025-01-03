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

namespace Google.Cloud.RecommendationEngine.V1Beta1
{
    /// <summary>Resource name for the <c>Catalog</c> resource.</summary>
    public sealed partial class CatalogName : gax::IResourceName, sys::IEquatable<CatalogName>
    {
        /// <summary>The possible contents of <see cref="CatalogName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/catalogs/{catalog}</c>.
            /// </summary>
            ProjectLocationCatalog = 1,
        }

        private static gax::PathTemplate s_projectLocationCatalog = new gax::PathTemplate("projects/{project}/locations/{location}/catalogs/{catalog}");

        /// <summary>Creates a <see cref="CatalogName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CatalogName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CatalogName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CatalogName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CatalogName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CatalogName"/> constructed from the provided ids.</returns>
        public static CatalogName FromProjectLocationCatalog(string projectId, string locationId, string catalogId) =>
            new CatalogName(ResourceNameType.ProjectLocationCatalog, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CatalogName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CatalogName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string catalogId) =>
            FormatProjectLocationCatalog(projectId, locationId, catalogId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CatalogName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CatalogName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}</c>.
        /// </returns>
        public static string FormatProjectLocationCatalog(string projectId, string locationId, string catalogId) =>
            s_projectLocationCatalog.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)));

        /// <summary>Parses the given resource name string into a new <see cref="CatalogName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/catalogs/{catalog}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="catalogName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CatalogName"/> if successful.</returns>
        public static CatalogName Parse(string catalogName) => Parse(catalogName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CatalogName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/catalogs/{catalog}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="catalogName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CatalogName"/> if successful.</returns>
        public static CatalogName Parse(string catalogName, bool allowUnparsed) =>
            TryParse(catalogName, allowUnparsed, out CatalogName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CatalogName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/catalogs/{catalog}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="catalogName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CatalogName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string catalogName, out CatalogName result) => TryParse(catalogName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CatalogName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/catalogs/{catalog}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="catalogName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CatalogName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string catalogName, bool allowUnparsed, out CatalogName result)
        {
            gax::GaxPreconditions.CheckNotNull(catalogName, nameof(catalogName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCatalog.TryParseName(catalogName, out resourceName))
            {
                result = FromProjectLocationCatalog(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(catalogName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CatalogName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string catalogId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CatalogId = catalogId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CatalogName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        public CatalogName(string projectId, string locationId, string catalogId) : this(ResourceNameType.ProjectLocationCatalog, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationCatalog: return s_projectLocationCatalog.Expand(ProjectId, LocationId, CatalogId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CatalogName);

        /// <inheritdoc/>
        public bool Equals(CatalogName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CatalogName a, CatalogName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CatalogName a, CatalogName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CatalogItemPath</c> resource.</summary>
    public sealed partial class CatalogItemPathName : gax::IResourceName, sys::IEquatable<CatalogItemPathName>
    {
        /// <summary>The possible contents of <see cref="CatalogItemPathName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/catalogItems/{catalog_item_path}</c>.
            /// </summary>
            ProjectLocationCatalogCatalogItemPath = 1,
        }

        private static gax::PathTemplate s_projectLocationCatalogCatalogItemPath = new gax::PathTemplate("projects/{project}/locations/{location}/catalogs/{catalog}/catalogItems/{catalog_item_path}");

        /// <summary>Creates a <see cref="CatalogItemPathName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CatalogItemPathName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CatalogItemPathName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CatalogItemPathName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CatalogItemPathName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/catalogItems/{catalog_item_path}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogItemPathId">The <c>CatalogItemPath</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CatalogItemPathName"/> constructed from the provided ids.</returns>
        public static CatalogItemPathName FromProjectLocationCatalogCatalogItemPath(string projectId, string locationId, string catalogId, string catalogItemPathId) =>
            new CatalogItemPathName(ResourceNameType.ProjectLocationCatalogCatalogItemPath, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), catalogItemPathId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogItemPathId, nameof(catalogItemPathId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CatalogItemPathName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/catalogItems/{catalog_item_path}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogItemPathId">The <c>CatalogItemPath</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CatalogItemPathName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/catalogItems/{catalog_item_path}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string catalogId, string catalogItemPathId) =>
            FormatProjectLocationCatalogCatalogItemPath(projectId, locationId, catalogId, catalogItemPathId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CatalogItemPathName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/catalogItems/{catalog_item_path}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogItemPathId">The <c>CatalogItemPath</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CatalogItemPathName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/catalogItems/{catalog_item_path}</c>.
        /// </returns>
        public static string FormatProjectLocationCatalogCatalogItemPath(string projectId, string locationId, string catalogId, string catalogItemPathId) =>
            s_projectLocationCatalogCatalogItemPath.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), gax::GaxPreconditions.CheckNotNullOrEmpty(catalogItemPathId, nameof(catalogItemPathId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CatalogItemPathName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/catalogItems/{catalog_item_path}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="catalogItemPathName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CatalogItemPathName"/> if successful.</returns>
        public static CatalogItemPathName Parse(string catalogItemPathName) => Parse(catalogItemPathName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CatalogItemPathName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/catalogItems/{catalog_item_path}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="catalogItemPathName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CatalogItemPathName"/> if successful.</returns>
        public static CatalogItemPathName Parse(string catalogItemPathName, bool allowUnparsed) =>
            TryParse(catalogItemPathName, allowUnparsed, out CatalogItemPathName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CatalogItemPathName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/catalogItems/{catalog_item_path}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="catalogItemPathName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CatalogItemPathName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string catalogItemPathName, out CatalogItemPathName result) =>
            TryParse(catalogItemPathName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CatalogItemPathName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/catalogItems/{catalog_item_path}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="catalogItemPathName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CatalogItemPathName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string catalogItemPathName, bool allowUnparsed, out CatalogItemPathName result)
        {
            gax::GaxPreconditions.CheckNotNull(catalogItemPathName, nameof(catalogItemPathName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCatalogCatalogItemPath.TryParseName(catalogItemPathName, out resourceName))
            {
                result = FromProjectLocationCatalogCatalogItemPath(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(catalogItemPathName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CatalogItemPathName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string catalogId = null, string catalogItemPathId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CatalogId = catalogId;
            CatalogItemPathId = catalogItemPathId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CatalogItemPathName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/catalogItems/{catalog_item_path}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogItemPathId">The <c>CatalogItemPath</c> ID. Must not be <c>null</c> or empty.</param>
        public CatalogItemPathName(string projectId, string locationId, string catalogId, string catalogItemPathId) : this(ResourceNameType.ProjectLocationCatalogCatalogItemPath, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), catalogItemPathId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogItemPathId, nameof(catalogItemPathId)))
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
        /// The <c>CatalogItemPath</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CatalogItemPathId { get; }

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
                case ResourceNameType.ProjectLocationCatalogCatalogItemPath: return s_projectLocationCatalogCatalogItemPath.Expand(ProjectId, LocationId, CatalogId, CatalogItemPathId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CatalogItemPathName);

        /// <inheritdoc/>
        public bool Equals(CatalogItemPathName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CatalogItemPathName a, CatalogItemPathName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CatalogItemPathName a, CatalogItemPathName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>EventStore</c> resource.</summary>
    public sealed partial class EventStoreName : gax::IResourceName, sys::IEquatable<EventStoreName>
    {
        /// <summary>The possible contents of <see cref="EventStoreName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}</c>.
            /// </summary>
            ProjectLocationCatalogEventStore = 1,
        }

        private static gax::PathTemplate s_projectLocationCatalogEventStore = new gax::PathTemplate("projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}");

        /// <summary>Creates a <see cref="EventStoreName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EventStoreName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EventStoreName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EventStoreName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EventStoreName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventStoreId">The <c>EventStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EventStoreName"/> constructed from the provided ids.</returns>
        public static EventStoreName FromProjectLocationCatalogEventStore(string projectId, string locationId, string catalogId, string eventStoreId) =>
            new EventStoreName(ResourceNameType.ProjectLocationCatalogEventStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), eventStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventStoreId, nameof(eventStoreId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EventStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventStoreId">The <c>EventStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EventStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string catalogId, string eventStoreId) =>
            FormatProjectLocationCatalogEventStore(projectId, locationId, catalogId, eventStoreId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EventStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventStoreId">The <c>EventStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EventStoreName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}</c>.
        /// </returns>
        public static string FormatProjectLocationCatalogEventStore(string projectId, string locationId, string catalogId, string eventStoreId) =>
            s_projectLocationCatalogEventStore.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), gax::GaxPreconditions.CheckNotNullOrEmpty(eventStoreId, nameof(eventStoreId)));

        /// <summary>Parses the given resource name string into a new <see cref="EventStoreName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="eventStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EventStoreName"/> if successful.</returns>
        public static EventStoreName Parse(string eventStoreName) => Parse(eventStoreName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EventStoreName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="eventStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EventStoreName"/> if successful.</returns>
        public static EventStoreName Parse(string eventStoreName, bool allowUnparsed) =>
            TryParse(eventStoreName, allowUnparsed, out EventStoreName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EventStoreName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="eventStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EventStoreName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string eventStoreName, out EventStoreName result) =>
            TryParse(eventStoreName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EventStoreName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="eventStoreName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EventStoreName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string eventStoreName, bool allowUnparsed, out EventStoreName result)
        {
            gax::GaxPreconditions.CheckNotNull(eventStoreName, nameof(eventStoreName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCatalogEventStore.TryParseName(eventStoreName, out resourceName))
            {
                result = FromProjectLocationCatalogEventStore(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(eventStoreName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EventStoreName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string catalogId = null, string eventStoreId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CatalogId = catalogId;
            EventStoreId = eventStoreId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EventStoreName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventStoreId">The <c>EventStore</c> ID. Must not be <c>null</c> or empty.</param>
        public EventStoreName(string projectId, string locationId, string catalogId, string eventStoreId) : this(ResourceNameType.ProjectLocationCatalogEventStore, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), eventStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventStoreId, nameof(eventStoreId)))
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
        /// The <c>EventStore</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EventStoreId { get; }

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
                case ResourceNameType.ProjectLocationCatalogEventStore: return s_projectLocationCatalogEventStore.Expand(ProjectId, LocationId, CatalogId, EventStoreId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EventStoreName);

        /// <inheritdoc/>
        public bool Equals(EventStoreName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EventStoreName a, EventStoreName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EventStoreName a, EventStoreName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>PredictionApiKeyRegistration</c> resource.</summary>
    public sealed partial class PredictionApiKeyRegistrationName : gax::IResourceName, sys::IEquatable<PredictionApiKeyRegistrationName>
    {
        /// <summary>The possible contents of <see cref="PredictionApiKeyRegistrationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/predictionApiKeyRegistrations/{prediction_api_key_registration}</c>
            /// .
            /// </summary>
            ProjectLocationCatalogEventStorePredictionApiKeyRegistration = 1,
        }

        private static gax::PathTemplate s_projectLocationCatalogEventStorePredictionApiKeyRegistration = new gax::PathTemplate("projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/predictionApiKeyRegistrations/{prediction_api_key_registration}");

        /// <summary>
        /// Creates a <see cref="PredictionApiKeyRegistrationName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PredictionApiKeyRegistrationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PredictionApiKeyRegistrationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PredictionApiKeyRegistrationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PredictionApiKeyRegistrationName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/predictionApiKeyRegistrations/{prediction_api_key_registration}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventStoreId">The <c>EventStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="predictionApiKeyRegistrationId">
        /// The <c>PredictionApiKeyRegistration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="PredictionApiKeyRegistrationName"/> constructed from the provided ids.
        /// </returns>
        public static PredictionApiKeyRegistrationName FromProjectLocationCatalogEventStorePredictionApiKeyRegistration(string projectId, string locationId, string catalogId, string eventStoreId, string predictionApiKeyRegistrationId) =>
            new PredictionApiKeyRegistrationName(ResourceNameType.ProjectLocationCatalogEventStorePredictionApiKeyRegistration, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), eventStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventStoreId, nameof(eventStoreId)), predictionApiKeyRegistrationId: gax::GaxPreconditions.CheckNotNullOrEmpty(predictionApiKeyRegistrationId, nameof(predictionApiKeyRegistrationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PredictionApiKeyRegistrationName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/predictionApiKeyRegistrations/{prediction_api_key_registration}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventStoreId">The <c>EventStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="predictionApiKeyRegistrationId">
        /// The <c>PredictionApiKeyRegistration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="PredictionApiKeyRegistrationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/predictionApiKeyRegistrations/{prediction_api_key_registration}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string catalogId, string eventStoreId, string predictionApiKeyRegistrationId) =>
            FormatProjectLocationCatalogEventStorePredictionApiKeyRegistration(projectId, locationId, catalogId, eventStoreId, predictionApiKeyRegistrationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PredictionApiKeyRegistrationName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/predictionApiKeyRegistrations/{prediction_api_key_registration}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventStoreId">The <c>EventStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="predictionApiKeyRegistrationId">
        /// The <c>PredictionApiKeyRegistration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="PredictionApiKeyRegistrationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/predictionApiKeyRegistrations/{prediction_api_key_registration}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCatalogEventStorePredictionApiKeyRegistration(string projectId, string locationId, string catalogId, string eventStoreId, string predictionApiKeyRegistrationId) =>
            s_projectLocationCatalogEventStorePredictionApiKeyRegistration.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), gax::GaxPreconditions.CheckNotNullOrEmpty(eventStoreId, nameof(eventStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(predictionApiKeyRegistrationId, nameof(predictionApiKeyRegistrationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PredictionApiKeyRegistrationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/predictionApiKeyRegistrations/{prediction_api_key_registration}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="predictionApiKeyRegistrationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="PredictionApiKeyRegistrationName"/> if successful.</returns>
        public static PredictionApiKeyRegistrationName Parse(string predictionApiKeyRegistrationName) =>
            Parse(predictionApiKeyRegistrationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PredictionApiKeyRegistrationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/predictionApiKeyRegistrations/{prediction_api_key_registration}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="predictionApiKeyRegistrationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PredictionApiKeyRegistrationName"/> if successful.</returns>
        public static PredictionApiKeyRegistrationName Parse(string predictionApiKeyRegistrationName, bool allowUnparsed) =>
            TryParse(predictionApiKeyRegistrationName, allowUnparsed, out PredictionApiKeyRegistrationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PredictionApiKeyRegistrationName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/predictionApiKeyRegistrations/{prediction_api_key_registration}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="predictionApiKeyRegistrationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PredictionApiKeyRegistrationName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string predictionApiKeyRegistrationName, out PredictionApiKeyRegistrationName result) =>
            TryParse(predictionApiKeyRegistrationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PredictionApiKeyRegistrationName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/predictionApiKeyRegistrations/{prediction_api_key_registration}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="predictionApiKeyRegistrationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PredictionApiKeyRegistrationName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string predictionApiKeyRegistrationName, bool allowUnparsed, out PredictionApiKeyRegistrationName result)
        {
            gax::GaxPreconditions.CheckNotNull(predictionApiKeyRegistrationName, nameof(predictionApiKeyRegistrationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCatalogEventStorePredictionApiKeyRegistration.TryParseName(predictionApiKeyRegistrationName, out resourceName))
            {
                result = FromProjectLocationCatalogEventStorePredictionApiKeyRegistration(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(predictionApiKeyRegistrationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PredictionApiKeyRegistrationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string catalogId = null, string eventStoreId = null, string locationId = null, string predictionApiKeyRegistrationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CatalogId = catalogId;
            EventStoreId = eventStoreId;
            LocationId = locationId;
            PredictionApiKeyRegistrationId = predictionApiKeyRegistrationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PredictionApiKeyRegistrationName"/> class from the component parts
        /// of pattern
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/predictionApiKeyRegistrations/{prediction_api_key_registration}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventStoreId">The <c>EventStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="predictionApiKeyRegistrationId">
        /// The <c>PredictionApiKeyRegistration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public PredictionApiKeyRegistrationName(string projectId, string locationId, string catalogId, string eventStoreId, string predictionApiKeyRegistrationId) : this(ResourceNameType.ProjectLocationCatalogEventStorePredictionApiKeyRegistration, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), eventStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventStoreId, nameof(eventStoreId)), predictionApiKeyRegistrationId: gax::GaxPreconditions.CheckNotNullOrEmpty(predictionApiKeyRegistrationId, nameof(predictionApiKeyRegistrationId)))
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
        /// The <c>EventStore</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EventStoreId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>PredictionApiKeyRegistration</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string PredictionApiKeyRegistrationId { get; }

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
                case ResourceNameType.ProjectLocationCatalogEventStorePredictionApiKeyRegistration: return s_projectLocationCatalogEventStorePredictionApiKeyRegistration.Expand(ProjectId, LocationId, CatalogId, EventStoreId, PredictionApiKeyRegistrationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PredictionApiKeyRegistrationName);

        /// <inheritdoc/>
        public bool Equals(PredictionApiKeyRegistrationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PredictionApiKeyRegistrationName a, PredictionApiKeyRegistrationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PredictionApiKeyRegistrationName a, PredictionApiKeyRegistrationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Placement</c> resource.</summary>
    public sealed partial class PlacementName : gax::IResourceName, sys::IEquatable<PlacementName>
    {
        /// <summary>The possible contents of <see cref="PlacementName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/placements/{placement}</c>
            /// .
            /// </summary>
            ProjectLocationCatalogEventStorePlacement = 1,
        }

        private static gax::PathTemplate s_projectLocationCatalogEventStorePlacement = new gax::PathTemplate("projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/placements/{placement}");

        /// <summary>Creates a <see cref="PlacementName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PlacementName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PlacementName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PlacementName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PlacementName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/placements/{placement}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventStoreId">The <c>EventStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="placementId">The <c>Placement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PlacementName"/> constructed from the provided ids.</returns>
        public static PlacementName FromProjectLocationCatalogEventStorePlacement(string projectId, string locationId, string catalogId, string eventStoreId, string placementId) =>
            new PlacementName(ResourceNameType.ProjectLocationCatalogEventStorePlacement, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), eventStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventStoreId, nameof(eventStoreId)), placementId: gax::GaxPreconditions.CheckNotNullOrEmpty(placementId, nameof(placementId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PlacementName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/placements/{placement}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventStoreId">The <c>EventStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="placementId">The <c>Placement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PlacementName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/placements/{placement}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string catalogId, string eventStoreId, string placementId) =>
            FormatProjectLocationCatalogEventStorePlacement(projectId, locationId, catalogId, eventStoreId, placementId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PlacementName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/placements/{placement}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventStoreId">The <c>EventStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="placementId">The <c>Placement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PlacementName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/placements/{placement}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationCatalogEventStorePlacement(string projectId, string locationId, string catalogId, string eventStoreId, string placementId) =>
            s_projectLocationCatalogEventStorePlacement.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), gax::GaxPreconditions.CheckNotNullOrEmpty(eventStoreId, nameof(eventStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(placementId, nameof(placementId)));

        /// <summary>Parses the given resource name string into a new <see cref="PlacementName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/placements/{placement}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="placementName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PlacementName"/> if successful.</returns>
        public static PlacementName Parse(string placementName) => Parse(placementName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PlacementName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/placements/{placement}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="placementName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PlacementName"/> if successful.</returns>
        public static PlacementName Parse(string placementName, bool allowUnparsed) =>
            TryParse(placementName, allowUnparsed, out PlacementName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PlacementName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/placements/{placement}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="placementName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PlacementName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string placementName, out PlacementName result) => TryParse(placementName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PlacementName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/placements/{placement}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="placementName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PlacementName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string placementName, bool allowUnparsed, out PlacementName result)
        {
            gax::GaxPreconditions.CheckNotNull(placementName, nameof(placementName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCatalogEventStorePlacement.TryParseName(placementName, out resourceName))
            {
                result = FromProjectLocationCatalogEventStorePlacement(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(placementName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PlacementName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string catalogId = null, string eventStoreId = null, string locationId = null, string placementId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CatalogId = catalogId;
            EventStoreId = eventStoreId;
            LocationId = locationId;
            PlacementId = placementId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PlacementName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/catalogs/{catalog}/eventStores/{event_store}/placements/{placement}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventStoreId">The <c>EventStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="placementId">The <c>Placement</c> ID. Must not be <c>null</c> or empty.</param>
        public PlacementName(string projectId, string locationId, string catalogId, string eventStoreId, string placementId) : this(ResourceNameType.ProjectLocationCatalogEventStorePlacement, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), eventStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventStoreId, nameof(eventStoreId)), placementId: gax::GaxPreconditions.CheckNotNullOrEmpty(placementId, nameof(placementId)))
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
        /// The <c>EventStore</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EventStoreId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Placement</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PlacementId { get; }

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
                case ResourceNameType.ProjectLocationCatalogEventStorePlacement: return s_projectLocationCatalogEventStorePlacement.Expand(ProjectId, LocationId, CatalogId, EventStoreId, PlacementId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PlacementName);

        /// <inheritdoc/>
        public bool Equals(PlacementName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PlacementName a, PlacementName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PlacementName a, PlacementName b) => !(a == b);
    }
}
