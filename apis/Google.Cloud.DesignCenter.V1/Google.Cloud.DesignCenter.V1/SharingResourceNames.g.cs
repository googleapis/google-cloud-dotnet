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
    /// <summary>Resource name for the <c>Share</c> resource.</summary>
    public sealed partial class ShareName : gax::IResourceName, sys::IEquatable<ShareName>
    {
        /// <summary>The possible contents of <see cref="ShareName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/shares/{share}</c>.
            /// </summary>
            ProjectLocationSpaceCatalogShare = 1,
        }

        private static gax::PathTemplate s_projectLocationSpaceCatalogShare = new gax::PathTemplate("projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/shares/{share}");

        /// <summary>Creates a <see cref="ShareName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ShareName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ShareName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ShareName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ShareName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/shares/{share}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="shareId">The <c>Share</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ShareName"/> constructed from the provided ids.</returns>
        public static ShareName FromProjectLocationSpaceCatalogShare(string projectId, string locationId, string spaceId, string catalogId, string shareId) =>
            new ShareName(ResourceNameType.ProjectLocationSpaceCatalogShare, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), shareId: gax::GaxPreconditions.CheckNotNullOrEmpty(shareId, nameof(shareId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ShareName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/shares/{share}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="shareId">The <c>Share</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ShareName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/shares/{share}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string spaceId, string catalogId, string shareId) =>
            FormatProjectLocationSpaceCatalogShare(projectId, locationId, spaceId, catalogId, shareId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ShareName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/shares/{share}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="shareId">The <c>Share</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ShareName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/shares/{share}</c>.
        /// </returns>
        public static string FormatProjectLocationSpaceCatalogShare(string projectId, string locationId, string spaceId, string catalogId, string shareId) =>
            s_projectLocationSpaceCatalogShare.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), gax::GaxPreconditions.CheckNotNullOrEmpty(shareId, nameof(shareId)));

        /// <summary>Parses the given resource name string into a new <see cref="ShareName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/shares/{share}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="shareName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ShareName"/> if successful.</returns>
        public static ShareName Parse(string shareName) => Parse(shareName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ShareName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/shares/{share}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="shareName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ShareName"/> if successful.</returns>
        public static ShareName Parse(string shareName, bool allowUnparsed) =>
            TryParse(shareName, allowUnparsed, out ShareName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ShareName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/shares/{share}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="shareName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ShareName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string shareName, out ShareName result) => TryParse(shareName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ShareName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/shares/{share}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="shareName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ShareName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string shareName, bool allowUnparsed, out ShareName result)
        {
            gax::GaxPreconditions.CheckNotNull(shareName, nameof(shareName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSpaceCatalogShare.TryParseName(shareName, out resourceName))
            {
                result = FromProjectLocationSpaceCatalogShare(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(shareName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ShareName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string catalogId = null, string locationId = null, string projectId = null, string shareId = null, string spaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CatalogId = catalogId;
            LocationId = locationId;
            ProjectId = projectId;
            ShareId = shareId;
            SpaceId = spaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ShareName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/catalogs/{catalog}/shares/{share}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="catalogId">The <c>Catalog</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="shareId">The <c>Share</c> ID. Must not be <c>null</c> or empty.</param>
        public ShareName(string projectId, string locationId, string spaceId, string catalogId, string shareId) : this(ResourceNameType.ProjectLocationSpaceCatalogShare, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), catalogId: gax::GaxPreconditions.CheckNotNullOrEmpty(catalogId, nameof(catalogId)), shareId: gax::GaxPreconditions.CheckNotNullOrEmpty(shareId, nameof(shareId)))
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
        /// The <c>Share</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ShareId { get; }

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
                case ResourceNameType.ProjectLocationSpaceCatalogShare: return s_projectLocationSpaceCatalogShare.Expand(ProjectId, LocationId, SpaceId, CatalogId, ShareId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ShareName);

        /// <inheritdoc/>
        public bool Equals(ShareName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ShareName a, ShareName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ShareName a, ShareName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>SharedTemplate</c> resource.</summary>
    public sealed partial class SharedTemplateName : gax::IResourceName, sys::IEquatable<SharedTemplateName>
    {
        /// <summary>The possible contents of <see cref="SharedTemplateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}</c>.
            /// </summary>
            ProjectLocationSpaceSharedTemplate = 1,
        }

        private static gax::PathTemplate s_projectLocationSpaceSharedTemplate = new gax::PathTemplate("projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}");

        /// <summary>Creates a <see cref="SharedTemplateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SharedTemplateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SharedTemplateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SharedTemplateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SharedTemplateName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sharedTemplateId">The <c>SharedTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SharedTemplateName"/> constructed from the provided ids.</returns>
        public static SharedTemplateName FromProjectLocationSpaceSharedTemplate(string projectId, string locationId, string spaceId, string sharedTemplateId) =>
            new SharedTemplateName(ResourceNameType.ProjectLocationSpaceSharedTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), sharedTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(sharedTemplateId, nameof(sharedTemplateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SharedTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sharedTemplateId">The <c>SharedTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SharedTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string spaceId, string sharedTemplateId) =>
            FormatProjectLocationSpaceSharedTemplate(projectId, locationId, spaceId, sharedTemplateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SharedTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sharedTemplateId">The <c>SharedTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SharedTemplateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}</c>.
        /// </returns>
        public static string FormatProjectLocationSpaceSharedTemplate(string projectId, string locationId, string spaceId, string sharedTemplateId) =>
            s_projectLocationSpaceSharedTemplate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sharedTemplateId, nameof(sharedTemplateId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SharedTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sharedTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SharedTemplateName"/> if successful.</returns>
        public static SharedTemplateName Parse(string sharedTemplateName) => Parse(sharedTemplateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SharedTemplateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sharedTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SharedTemplateName"/> if successful.</returns>
        public static SharedTemplateName Parse(string sharedTemplateName, bool allowUnparsed) =>
            TryParse(sharedTemplateName, allowUnparsed, out SharedTemplateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SharedTemplateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sharedTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SharedTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sharedTemplateName, out SharedTemplateName result) =>
            TryParse(sharedTemplateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SharedTemplateName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sharedTemplateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SharedTemplateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sharedTemplateName, bool allowUnparsed, out SharedTemplateName result)
        {
            gax::GaxPreconditions.CheckNotNull(sharedTemplateName, nameof(sharedTemplateName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSpaceSharedTemplate.TryParseName(sharedTemplateName, out resourceName))
            {
                result = FromProjectLocationSpaceSharedTemplate(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sharedTemplateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SharedTemplateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string sharedTemplateId = null, string spaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SharedTemplateId = sharedTemplateId;
            SpaceId = spaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SharedTemplateName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sharedTemplateId">The <c>SharedTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        public SharedTemplateName(string projectId, string locationId, string spaceId, string sharedTemplateId) : this(ResourceNameType.ProjectLocationSpaceSharedTemplate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), sharedTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(sharedTemplateId, nameof(sharedTemplateId)))
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
        /// The <c>SharedTemplate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string SharedTemplateId { get; }

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
                case ResourceNameType.ProjectLocationSpaceSharedTemplate: return s_projectLocationSpaceSharedTemplate.Expand(ProjectId, LocationId, SpaceId, SharedTemplateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SharedTemplateName);

        /// <inheritdoc/>
        public bool Equals(SharedTemplateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SharedTemplateName a, SharedTemplateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SharedTemplateName a, SharedTemplateName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>SharedTemplateRevision</c> resource.</summary>
    public sealed partial class SharedTemplateRevisionName : gax::IResourceName, sys::IEquatable<SharedTemplateRevisionName>
    {
        /// <summary>The possible contents of <see cref="SharedTemplateRevisionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}/revisions/{revision}</c>
            /// .
            /// </summary>
            ProjectLocationSpaceSharedTemplateRevision = 1,
        }

        private static gax::PathTemplate s_projectLocationSpaceSharedTemplateRevision = new gax::PathTemplate("projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}/revisions/{revision}");

        /// <summary>Creates a <see cref="SharedTemplateRevisionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SharedTemplateRevisionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SharedTemplateRevisionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SharedTemplateRevisionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SharedTemplateRevisionName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}/revisions/{revision}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sharedTemplateId">The <c>SharedTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="SharedTemplateRevisionName"/> constructed from the provided ids.
        /// </returns>
        public static SharedTemplateRevisionName FromProjectLocationSpaceSharedTemplateRevision(string projectId, string locationId, string spaceId, string sharedTemplateId, string revisionId) =>
            new SharedTemplateRevisionName(ResourceNameType.ProjectLocationSpaceSharedTemplateRevision, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), sharedTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(sharedTemplateId, nameof(sharedTemplateId)), revisionId: gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SharedTemplateRevisionName"/> with pattern
        /// 
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}/revisions/{revision}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sharedTemplateId">The <c>SharedTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SharedTemplateRevisionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}/revisions/{revision}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string spaceId, string sharedTemplateId, string revisionId) =>
            FormatProjectLocationSpaceSharedTemplateRevision(projectId, locationId, spaceId, sharedTemplateId, revisionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SharedTemplateRevisionName"/> with pattern
        /// 
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}/revisions/{revision}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sharedTemplateId">The <c>SharedTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SharedTemplateRevisionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}/revisions/{revision}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationSpaceSharedTemplateRevision(string projectId, string locationId, string spaceId, string sharedTemplateId, string revisionId) =>
            s_projectLocationSpaceSharedTemplateRevision.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sharedTemplateId, nameof(sharedTemplateId)), gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SharedTemplateRevisionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sharedTemplateRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SharedTemplateRevisionName"/> if successful.</returns>
        public static SharedTemplateRevisionName Parse(string sharedTemplateRevisionName) =>
            Parse(sharedTemplateRevisionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SharedTemplateRevisionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sharedTemplateRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SharedTemplateRevisionName"/> if successful.</returns>
        public static SharedTemplateRevisionName Parse(string sharedTemplateRevisionName, bool allowUnparsed) =>
            TryParse(sharedTemplateRevisionName, allowUnparsed, out SharedTemplateRevisionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SharedTemplateRevisionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="sharedTemplateRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SharedTemplateRevisionName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sharedTemplateRevisionName, out SharedTemplateRevisionName result) =>
            TryParse(sharedTemplateRevisionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SharedTemplateRevisionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}/revisions/{revision}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sharedTemplateRevisionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SharedTemplateRevisionName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sharedTemplateRevisionName, bool allowUnparsed, out SharedTemplateRevisionName result)
        {
            gax::GaxPreconditions.CheckNotNull(sharedTemplateRevisionName, nameof(sharedTemplateRevisionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSpaceSharedTemplateRevision.TryParseName(sharedTemplateRevisionName, out resourceName))
            {
                result = FromProjectLocationSpaceSharedTemplateRevision(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sharedTemplateRevisionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SharedTemplateRevisionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string revisionId = null, string sharedTemplateId = null, string spaceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            RevisionId = revisionId;
            SharedTemplateId = sharedTemplateId;
            SpaceId = spaceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SharedTemplateRevisionName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/spaces/{space}/sharedTemplates/{shared_template}/revisions/{revision}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="spaceId">The <c>Space</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sharedTemplateId">The <c>SharedTemplate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="revisionId">The <c>Revision</c> ID. Must not be <c>null</c> or empty.</param>
        public SharedTemplateRevisionName(string projectId, string locationId, string spaceId, string sharedTemplateId, string revisionId) : this(ResourceNameType.ProjectLocationSpaceSharedTemplateRevision, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), spaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(spaceId, nameof(spaceId)), sharedTemplateId: gax::GaxPreconditions.CheckNotNullOrEmpty(sharedTemplateId, nameof(sharedTemplateId)), revisionId: gax::GaxPreconditions.CheckNotNullOrEmpty(revisionId, nameof(revisionId)))
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
        /// The <c>Revision</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RevisionId { get; }

        /// <summary>
        /// The <c>SharedTemplate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string SharedTemplateId { get; }

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
                case ResourceNameType.ProjectLocationSpaceSharedTemplateRevision: return s_projectLocationSpaceSharedTemplateRevision.Expand(ProjectId, LocationId, SpaceId, SharedTemplateId, RevisionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SharedTemplateRevisionName);

        /// <inheritdoc/>
        public bool Equals(SharedTemplateRevisionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SharedTemplateRevisionName a, SharedTemplateRevisionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SharedTemplateRevisionName a, SharedTemplateRevisionName b) => !(a == b);
    }

    public partial class Share
    {
        /// <summary>
        /// <see cref="gcdv::ShareName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ShareName ShareName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ShareName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SpaceName"/>-typed view over the <see cref="DestinationSpace"/> resource name property.
        /// </summary>
        public SpaceName DestinationSpaceAsSpaceName
        {
            get => string.IsNullOrEmpty(DestinationSpace) ? null : SpaceName.Parse(DestinationSpace, allowUnparsed: true);
            set => DestinationSpace = value?.ToString() ?? "";
        }
    }

    public partial class SharedTemplate
    {
        /// <summary>
        /// <see cref="gcdv::SharedTemplateName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::SharedTemplateName SharedTemplateName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SharedTemplateName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CatalogTemplateName"/>-typed view over the <see cref="OriginTemplate"/> resource name property.
        /// </summary>
        public CatalogTemplateName OriginTemplateAsCatalogTemplateName
        {
            get => string.IsNullOrEmpty(OriginTemplate) ? null : CatalogTemplateName.Parse(OriginTemplate, allowUnparsed: true);
            set => OriginTemplate = value?.ToString() ?? "";
        }
    }

    public partial class SharedTemplateRevision
    {
        /// <summary>
        /// <see cref="gcdv::SharedTemplateRevisionName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcdv::SharedTemplateRevisionName SharedTemplateRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::SharedTemplateRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CatalogTemplateRevisionName"/>-typed view over the <see cref="OriginTemplateRevision"/> resource
        /// name property.
        /// </summary>
        public CatalogTemplateRevisionName OriginTemplateRevisionAsCatalogTemplateRevisionName
        {
            get => string.IsNullOrEmpty(OriginTemplateRevision) ? null : CatalogTemplateRevisionName.Parse(OriginTemplateRevision, allowUnparsed: true);
            set => OriginTemplateRevision = value?.ToString() ?? "";
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
