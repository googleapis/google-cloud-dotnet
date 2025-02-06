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
using gcrv = Google.Cloud.Retail.V2;
using sys = System;

namespace Google.Cloud.Retail.V2
{
    /// <summary>Resource name for the <c>AttributesConfig</c> resource.</summary>
    public sealed partial class AttributesConfigName : gax::IResourceName, sys::IEquatable<AttributesConfigName>
    {
        /// <summary>The possible contents of <see cref="AttributesConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/attributesConfig</c>.
            /// </summary>
            ProjectLocationCatalog = 1,
        }

        private static gax::PathTemplate s_projectLocationCatalog = new gax::PathTemplate("projects/{project}/locations/{location}/catalogs/{catalog}/attributesConfig");

        /// <summary>Creates a <see cref="AttributesConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AttributesConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AttributesConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AttributesConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AttributesConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/attributesConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AttributesConfigName"/> constructed from the provided ids.</returns>
        public static AttributesConfigName FromProjectLocationCatalog(string projectId, string locationId, string catalogId) =>
            new AttributesConfigName(ResourceNameType.ProjectLocationCatalog, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AttributesConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/attributesConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AttributesConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/attributesConfig</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string catalogId) =>
            FormatProjectLocationCatalog(projectId, locationId, catalogId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AttributesConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/attributesConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AttributesConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/attributesConfig</c>.
        /// </returns>
        public static string FormatProjectLocationCatalog(string projectId, string locationId, string catalogId) =>
            s_projectLocationCatalog.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AttributesConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/attributesConfig</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="attributesConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AttributesConfigName"/> if successful.</returns>
        public static AttributesConfigName Parse(string attributesConfigName) => Parse(attributesConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AttributesConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/attributesConfig</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="attributesConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AttributesConfigName"/> if successful.</returns>
        public static AttributesConfigName Parse(string attributesConfigName, bool allowUnparsed) =>
            TryParse(attributesConfigName, allowUnparsed, out AttributesConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AttributesConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/attributesConfig</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="attributesConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AttributesConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string attributesConfigName, out AttributesConfigName result) =>
            TryParse(attributesConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AttributesConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/attributesConfig</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="attributesConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AttributesConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string attributesConfigName, bool allowUnparsed, out AttributesConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(attributesConfigName, nameof(attributesConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCatalog.TryParseName(attributesConfigName, out resourceName))
            {
                result = FromProjectLocationCatalog(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(attributesConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AttributesConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string catalogId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CatalogId = catalogId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AttributesConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/attributesConfig</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        public AttributesConfigName(string projectId, string locationId, string catalogId) : this(ResourceNameType.ProjectLocationCatalog, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)))
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
        public override bool Equals(object obj) => Equals(obj as AttributesConfigName);

        /// <inheritdoc/>
        public bool Equals(AttributesConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AttributesConfigName a, AttributesConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AttributesConfigName a, AttributesConfigName b) => !(a == b);
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
            /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/completionConfig</c>.
            /// </summary>
            ProjectLocationCatalog = 1,
        }

        private static gax::PathTemplate s_projectLocationCatalog = new gax::PathTemplate("projects/{project}/locations/{location}/catalogs/{catalog}/completionConfig");

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
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/completionConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CompletionConfigName"/> constructed from the provided ids.</returns>
        public static CompletionConfigName FromProjectLocationCatalog(string projectId, string locationId, string catalogId) =>
            new CompletionConfigName(ResourceNameType.ProjectLocationCatalog, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CompletionConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/completionConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CompletionConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/completionConfig</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string catalogId) =>
            FormatProjectLocationCatalog(projectId, locationId, catalogId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CompletionConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/completionConfig</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CompletionConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/completionConfig</c>.
        /// </returns>
        public static string FormatProjectLocationCatalog(string projectId, string locationId, string catalogId) =>
            s_projectLocationCatalog.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CompletionConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/completionConfig</c>
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
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/completionConfig</c>
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
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/completionConfig</c>
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
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/completionConfig</c>
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
            if (s_projectLocationCatalog.TryParseName(completionConfigName, out resourceName))
            {
                result = FromProjectLocationCatalog(resourceName[0], resourceName[1], resourceName[2]);
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

        private CompletionConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string catalogId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CatalogId = catalogId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CompletionConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/catalogs/{catalog}/completionConfig</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        public CompletionConfigName(string projectId, string locationId, string catalogId) : this(ResourceNameType.ProjectLocationCatalog, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)))
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

    public partial class AttributesConfig
    {
        /// <summary>
        /// <see cref="gcrv::AttributesConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::AttributesConfigName AttributesConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::AttributesConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CompletionConfig
    {
        /// <summary>
        /// <see cref="gcrv::CompletionConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::CompletionConfigName CompletionConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::CompletionConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Catalog
    {
        /// <summary>
        /// <see cref="gcrv::CatalogName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::CatalogName CatalogName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::CatalogName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
