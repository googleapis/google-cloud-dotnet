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
using gcav = Google.Cloud.ArtifactRegistry.V1;
using sys = System;

namespace Google.Cloud.ArtifactRegistry.V1
{
    /// <summary>Resource name for the <c>Tag</c> resource.</summary>
    public sealed partial class TagName : gax::IResourceName, sys::IEquatable<TagName>
    {
        /// <summary>The possible contents of <see cref="TagName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}/tags/{tag}</c>.
            /// </summary>
            ProjectLocationRepositoryPackageTag = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryPackageTag = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/packages/{package}/tags/{tag}");

        /// <summary>Creates a <see cref="TagName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TagName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TagName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TagName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TagName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}/tags/{tag}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="packageId">The <c>Package</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagId">The <c>Tag</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TagName"/> constructed from the provided ids.</returns>
        public static TagName FromProjectLocationRepositoryPackageTag(string projectId, string locationId, string repositoryId, string packageId, string tagId) =>
            new TagName(ResourceNameType.ProjectLocationRepositoryPackageTag, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), packageId: gax::GaxPreconditions.CheckNotNullOrEmpty(packageId, nameof(packageId)), tagId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagId, nameof(tagId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TagName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}/tags/{tag}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="packageId">The <c>Package</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagId">The <c>Tag</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TagName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}/tags/{tag}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string packageId, string tagId) =>
            FormatProjectLocationRepositoryPackageTag(projectId, locationId, repositoryId, packageId, tagId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TagName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}/tags/{tag}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="packageId">The <c>Package</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagId">The <c>Tag</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TagName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}/tags/{tag}</c>.
        /// </returns>
        public static string FormatProjectLocationRepositoryPackageTag(string projectId, string locationId, string repositoryId, string packageId, string tagId) =>
            s_projectLocationRepositoryPackageTag.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(packageId, nameof(packageId)), gax::GaxPreconditions.CheckNotNullOrEmpty(tagId, nameof(tagId)));

        /// <summary>Parses the given resource name string into a new <see cref="TagName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}/tags/{tag}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tagName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TagName"/> if successful.</returns>
        public static TagName Parse(string tagName) => Parse(tagName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TagName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}/tags/{tag}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tagName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TagName"/> if successful.</returns>
        public static TagName Parse(string tagName, bool allowUnparsed) =>
            TryParse(tagName, allowUnparsed, out TagName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="TagName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}/tags/{tag}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="tagName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TagName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagName, out TagName result) => TryParse(tagName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TagName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}/tags/{tag}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="tagName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TagName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string tagName, bool allowUnparsed, out TagName result)
        {
            gax::GaxPreconditions.CheckNotNull(tagName, nameof(tagName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryPackageTag.TryParseName(tagName, out resourceName))
            {
                result = FromProjectLocationRepositoryPackageTag(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(tagName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TagName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string packageId = null, string projectId = null, string repositoryId = null, string tagId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PackageId = packageId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
            TagId = tagId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TagName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/packages/{package}/tags/{tag}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="packageId">The <c>Package</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="tagId">The <c>Tag</c> ID. Must not be <c>null</c> or empty.</param>
        public TagName(string projectId, string locationId, string repositoryId, string packageId, string tagId) : this(ResourceNameType.ProjectLocationRepositoryPackageTag, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), packageId: gax::GaxPreconditions.CheckNotNullOrEmpty(packageId, nameof(packageId)), tagId: gax::GaxPreconditions.CheckNotNullOrEmpty(tagId, nameof(tagId)))
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
        /// The <c>Package</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PackageId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Repository</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RepositoryId { get; }

        /// <summary>
        /// The <c>Tag</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TagId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRepositoryPackageTag: return s_projectLocationRepositoryPackageTag.Expand(ProjectId, LocationId, RepositoryId, PackageId, TagId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TagName);

        /// <inheritdoc/>
        public bool Equals(TagName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TagName a, TagName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TagName a, TagName b) => !(a == b);
    }

    public partial class Tag
    {
        /// <summary>
        /// <see cref="gcav::TagName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TagName TagName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TagName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
