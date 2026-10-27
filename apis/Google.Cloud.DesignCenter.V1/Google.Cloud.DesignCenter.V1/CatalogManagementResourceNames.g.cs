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
using gcdv = Google.Cloud.DesignCenter.V1;
using sys = System;

namespace Google.Cloud.DesignCenter.V1
{
    /// <summary>Resource name for the <c>Space</c> resource.</summary>
    public sealed partial class SpaceName : gax::IResourceName, sys::IEquatable<SpaceName>
    {
        /// <summary>The possible contents of <see cref="SpaceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/spaces/{space}</c>.
            /// </summary>
            ProjectLocationSpace = 1,
        }

        private static gax::PathTemplate s_projectLocationSpace = new gax::PathTemplate("projects/{project}/locations/{location}/spaces/{space}");

        /// <summary>Creates a <see cref="SpaceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SpaceName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SpaceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SpaceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SpaceName"/> with the pattern <c>projects/{project}/locations/{location}/spaces/{space}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SpaceName"/> constructed from the provided ids.</returns>
        public static SpaceName FromProjectLocationSpace(string projectId, string locationId, string spaceId) =>
            new SpaceName(ResourceNameType.ProjectLocationSpace, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SpaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SpaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string spaceId) =>
            FormatProjectLocationSpace(projectId, locationId, spaceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SpaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SpaceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}</c>.
        /// </returns>
        public static string FormatProjectLocationSpace(string projectId, string locationId, string spaceId) =>
            s_projectLocationSpace.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)));

        /// <summary>Parses the given resource name string into a new <see cref="SpaceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/spaces/{space}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="spaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SpaceName"/> if successful.</returns>
        public static SpaceName Parse(string spaceName) => Parse(spaceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SpaceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/spaces/{space}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="spaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SpaceName"/> if successful.</returns>
        public static SpaceName Parse(string spaceName, bool allowUnparsed) =>
            TryParse(spaceName, allowUnparsed, out SpaceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SpaceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/spaces/{space}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="spaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SpaceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string spaceName, out SpaceName result) => TryParse(spaceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SpaceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/spaces/{space}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="spaceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SpaceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string spaceName, bool allowUnparsed, out SpaceName result)
        {
            gax::GaxPreconditions.CheckNotNull(spaceName, nameof(spaceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSpace.TryParseName(spaceName, out resourceName))
            {
                result = FromProjectLocationSpace(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(spaceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SpaceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string spaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SpaceId = spaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SpaceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        public SpaceName(string projectId, string locationId, string spaceId) : this(ResourceNameType.ProjectLocationSpace, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)))
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
        /// The <c>Space</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SpaceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSpace: return s_projectLocationSpace.Expand(ProjectId, LocationId, SpaceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SpaceName);

        /// <inheritdoc/>
        public bool Equals(SpaceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SpaceName a, SpaceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SpaceName a, SpaceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Catalog</c> resource.</summary>
    public sealed partial class CatalogName : gax::IResourceName, sys::IEquatable<CatalogName>
    {
        /// <summary>The possible contents of <see cref="CatalogName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}</c>.
            /// </summary>
            ProjectLocationSpaceCatalog = 1,
        }

        private static gax::PathTemplate s_projectLocationSpaceCatalog = new gax::PathTemplate("projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}");

        /// <summary>Creates a <see cref="CatalogName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CatalogName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CatalogName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CatalogName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CatalogName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CatalogName"/> constructed from the provided ids.</returns>
        public static CatalogName FromProjectLocationSpaceCatalog(string projectId, string locationId, string spaceId, string catalogId) =>
            new CatalogName(ResourceNameType.ProjectLocationSpaceCatalog, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CatalogName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CatalogName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string spaceId, string catalogId) =>
            FormatProjectLocationSpaceCatalog(projectId, locationId, spaceId, catalogId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CatalogName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CatalogName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}</c>.
        /// </returns>
        public static string FormatProjectLocationSpaceCatalog(string projectId, string locationId, string spaceId, string catalogId) =>
            s_projectLocationSpaceCatalog.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)));

        /// <summary>Parses the given resource name string into a new <see cref="CatalogName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}</c></description>
        /// </item>
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
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}</c></description>
        /// </item>
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
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}</c></description>
        /// </item>
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
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}</c></description>
        /// </item>
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
            if (s_projectLocationSpaceCatalog.TryParseName(catalogName, out resourceName))
            {
                result = FromProjectLocationSpaceCatalog(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
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

        private CatalogName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string catalogId = null, string locationId = null, string projectId = null, string spaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CatalogId = catalogId;
            LocationId = locationId;
            ProjectId = projectId;
            SpaceId = spaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CatalogName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        public CatalogName(string projectId, string locationId, string spaceId, string catalogId) : this(ResourceNameType.ProjectLocationSpaceCatalog, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)))
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
        /// The <c>Space</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SpaceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSpaceCatalog: return s_projectLocationSpaceCatalog.Expand(ProjectId, LocationId, SpaceId, CatalogId);
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

    /// <summary>Resource name for the <c>CatalogTemplate</c> resource.</summary>
    public sealed partial class CatalogTemplateName : gax::IResourceName, sys::IEquatable<CatalogTemplateName>
    {
        /// <summary>The possible contents of <see cref="CatalogTemplateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}</c>
            /// .
            /// </summary>
            ProjectLocationSpaceCatalogCatalogTemplate = 1,
        }

        private static gax::PathTemplate s_projectLocationSpaceCatalogCatalogTemplate = new gax::PathTemplate("projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}");

        /// <summary>Creates a <see cref="CatalogTemplateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CatalogTemplateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CatalogTemplateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CatalogTemplateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CatalogTemplateName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogTemplateId">The <c>CatalogTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CatalogTemplateName"/> constructed from the provided ids.</returns>
        public static CatalogTemplateName FromProjectLocationSpaceCatalogCatalogTemplate(string projectId, string locationId, string spaceId, string catalogId, string catalogTemplateId) =>
            new CatalogTemplateName(ResourceNameType.ProjectLocationSpaceCatalogCatalogTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), catalogTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogTemplateId, nameof(catalogTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CatalogTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogTemplateId">The <c>CatalogTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CatalogTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string spaceId, string catalogId, string catalogTemplateId) =>
            FormatProjectLocationSpaceCatalogCatalogTemplate(projectId, locationId, spaceId, catalogId, catalogTemplateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CatalogTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogTemplateId">The <c>CatalogTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CatalogTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationSpaceCatalogCatalogTemplate(string projectId, string locationId, string spaceId, string catalogId, string catalogTemplateId) =>
            s_projectLocationSpaceCatalogCatalogTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), gax::GaxPreconditions.CheckNotNullOrEmpty(catalogTemplateId, nameof(catalogTemplateId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CatalogTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="catalogTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CatalogTemplateName"/> if successful.</returns>
        public static CatalogTemplateName Parse(string catalogTemplateName) => Parse(catalogTemplateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CatalogTemplateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="catalogTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CatalogTemplateName"/> if successful.</returns>
        public static CatalogTemplateName Parse(string catalogTemplateName, bool allowUnparsed) =>
            TryParse(catalogTemplateName, allowUnparsed, out CatalogTemplateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CatalogTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="catalogTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CatalogTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string catalogTemplateName, out CatalogTemplateName result) =>
            TryParse(catalogTemplateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CatalogTemplateName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="catalogTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CatalogTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string catalogTemplateName, bool allowUnparsed, out CatalogTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(catalogTemplateName, nameof(catalogTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSpaceCatalogCatalogTemplate.TryParseName(catalogTemplateName, out resourceName))
            {
                result = FromProjectLocationSpaceCatalogCatalogTemplate(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(catalogTemplateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CatalogTemplateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string catalogId = null, string catalogTemplateId = null, string locationId = null, string projectId = null, string spaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CatalogId = catalogId;
            CatalogTemplateId = catalogTemplateId;
            LocationId = locationId;
            ProjectId = projectId;
            SpaceId = spaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CatalogTemplateName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogTemplateId">The <c>CatalogTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        public CatalogTemplateName(string projectId, string locationId, string spaceId, string catalogId, string catalogTemplateId) : this(ResourceNameType.ProjectLocationSpaceCatalogCatalogTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), catalogTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogTemplateId, nameof(catalogTemplateId)))
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
        /// The <c>CatalogTemplate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CatalogTemplateId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Space</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SpaceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSpaceCatalogCatalogTemplate: return s_projectLocationSpaceCatalogCatalogTemplate.Expand(ProjectId, LocationId, SpaceId, CatalogId, CatalogTemplateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CatalogTemplateName);

        /// <inheritdoc/>
        public bool Equals(CatalogTemplateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CatalogTemplateName a, CatalogTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CatalogTemplateName a, CatalogTemplateName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CatalogTemplateRevision</c> resource.</summary>
    public sealed partial class CatalogTemplateRevisionName : gax::IResourceName, sys::IEquatable<CatalogTemplateRevisionName>
    {
        /// <summary>The possible contents of <see cref="CatalogTemplateRevisionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}/revisions/{revision}</c>
            /// .
            /// </summary>
            ProjectLocationSpaceCatalogCatalogTemplateRevision = 1,
        }

        private static gax::PathTemplate s_projectLocationSpaceCatalogCatalogTemplateRevision = new gax::PathTemplate("projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}/revisions/{revision}");

        /// <summary>Creates a <see cref="CatalogTemplateRevisionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CatalogTemplateRevisionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CatalogTemplateRevisionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CatalogTemplateRevisionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CatalogTemplateRevisionName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}/revisions/{revision}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogTemplateId">The <c>CatalogTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="CatalogTemplateRevisionName"/> constructed from the provided ids.
        /// </returns>
        public static CatalogTemplateRevisionName FromProjectLocationSpaceCatalogCatalogTemplateRevision(string projectId, string locationId, string spaceId, string catalogId, string catalogTemplateId, string revisionId) =>
            new CatalogTemplateRevisionName(ResourceNameType.ProjectLocationSpaceCatalogCatalogTemplateRevision, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), catalogTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogTemplateId, nameof(catalogTemplateId)), revisionId: gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CatalogTemplateRevisionName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}/revisions/{revision}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogTemplateId">The <c>CatalogTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CatalogTemplateRevisionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}/revisions/{revision}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string spaceId, string catalogId, string catalogTemplateId, string revisionId) =>
            FormatProjectLocationSpaceCatalogCatalogTemplateRevision(projectId, locationId, spaceId, catalogId, catalogTemplateId, revisionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CatalogTemplateRevisionName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}/revisions/{revision}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogTemplateId">The <c>CatalogTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CatalogTemplateRevisionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}/revisions/{revision}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationSpaceCatalogCatalogTemplateRevision(string projectId, string locationId, string spaceId, string catalogId, string catalogTemplateId, string revisionId) =>
            s_projectLocationSpaceCatalogCatalogTemplateRevision.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), gax::GaxPreconditions.CheckNotNullOrEmpty(catalogTemplateId, nameof(catalogTemplateId)), gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CatalogTemplateRevisionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="catalogTemplateRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CatalogTemplateRevisionName"/> if successful.</returns>
        public static CatalogTemplateRevisionName Parse(string catalogTemplateRevisionName) =>
            Parse(catalogTemplateRevisionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CatalogTemplateRevisionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="catalogTemplateRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CatalogTemplateRevisionName"/> if successful.</returns>
        public static CatalogTemplateRevisionName Parse(string catalogTemplateRevisionName, bool allowUnparsed) =>
            TryParse(catalogTemplateRevisionName, allowUnparsed, out CatalogTemplateRevisionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CatalogTemplateRevisionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="catalogTemplateRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CatalogTemplateRevisionName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string catalogTemplateRevisionName, out CatalogTemplateRevisionName result) =>
            TryParse(catalogTemplateRevisionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CatalogTemplateRevisionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="catalogTemplateRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CatalogTemplateRevisionName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string catalogTemplateRevisionName, bool allowUnparsed, out CatalogTemplateRevisionName result)
        {
            gax::GaxPreconditions.CheckNotNull(catalogTemplateRevisionName, nameof(catalogTemplateRevisionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSpaceCatalogCatalogTemplateRevision.TryParseName(catalogTemplateRevisionName, out resourceName))
            {
                result = FromProjectLocationSpaceCatalogCatalogTemplateRevision(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4], resourceName[5]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(catalogTemplateRevisionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CatalogTemplateRevisionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string catalogId = null, string catalogTemplateId = null, string locationId = null, string projectId = null, string revisionId = null, string spaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CatalogId = catalogId;
            CatalogTemplateId = catalogTemplateId;
            LocationId = locationId;
            ProjectId = projectId;
            RevisionId = revisionId;
            SpaceId = spaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CatalogTemplateRevisionName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/templates/{catalog_template}/revisions/{revision}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogTemplateId">The <c>CatalogTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        public CatalogTemplateRevisionName(string projectId, string locationId, string spaceId, string catalogId, string catalogTemplateId, string revisionId) : this(ResourceNameType.ProjectLocationSpaceCatalogCatalogTemplateRevision, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), catalogTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogTemplateId, nameof(catalogTemplateId)), revisionId: gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)))
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
        /// The <c>CatalogTemplate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CatalogTemplateId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Revision</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RevisionId { get; }

        /// <summary>
        /// The <c>Space</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SpaceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSpaceCatalogCatalogTemplateRevision: return s_projectLocationSpaceCatalogCatalogTemplateRevision.Expand(ProjectId, LocationId, SpaceId, CatalogId, CatalogTemplateId, RevisionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CatalogTemplateRevisionName);

        /// <inheritdoc/>
        public bool Equals(CatalogTemplateRevisionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CatalogTemplateRevisionName a, CatalogTemplateRevisionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CatalogTemplateRevisionName a, CatalogTemplateRevisionName b) => !(a == b);
    }

    public partial class Space
    {
        /// <summary>
        /// <see cref="gcdv::SpaceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SpaceName SpaceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SpaceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Catalog
    {
        /// <summary>
        /// <see cref="gcdv::CatalogName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::CatalogName CatalogName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CatalogName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CatalogTemplate
    {
        /// <summary>
        /// <see cref="gcdv::CatalogTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::CatalogTemplateName CatalogTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CatalogTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CatalogTemplateRevision
    {
        /// <summary>
        /// <see cref="gcdv::CatalogTemplateRevisionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdv::CatalogTemplateRevisionName CatalogTemplateRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::CatalogTemplateRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ApplicationTemplateRevisionName"/>-typed view over the
        /// <see cref="ApplicationTemplateRevisionSource"/> resource name property.
        /// </summary>
        public ApplicationTemplateRevisionName ApplicationTemplateRevisionSourceAsApplicationTemplateRevisionName
        {
            get => string.IsNullOrEmpty(ApplicationTemplateRevisionSource) ? null : ApplicationTemplateRevisionName.Parse(ApplicationTemplateRevisionSource, allowUnparsed: true);
            set => ApplicationTemplateRevisionSource = value?.ToString() ?? "";
        }
    }
}
