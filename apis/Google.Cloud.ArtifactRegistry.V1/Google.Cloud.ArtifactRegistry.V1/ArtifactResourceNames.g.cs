// Copyright 2022 Google LLC
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

using gax = Google.Api.Gax;
using gcav = Google.Cloud.ArtifactRegistry.V1;
using sys = System;

namespace Google.Cloud.ArtifactRegistry.V1
{
    /// <summary>Resource name for the <c>DockerImage</c> resource.</summary>
    public sealed partial class DockerImageName : gax::IResourceName, sys::IEquatable<DockerImageName>
    {
        /// <summary>The possible contents of <see cref="DockerImageName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/repositories/{repository}/dockerImages/{docker_image}</c>.
            /// </summary>
            ProjectLocationRepositoryDockerImage = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryDockerImage = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/dockerImages/{docker_image}");

        /// <summary>Creates a <see cref="DockerImageName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DockerImageName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DockerImageName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DockerImageName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DockerImageName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/dockerImages/{docker_image}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dockerImageId">The <c>DockerImage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DockerImageName"/> constructed from the provided ids.</returns>
        public static DockerImageName FromProjectLocationRepositoryDockerImage(string projectId, string locationId, string repositoryId, string dockerImageId) =>
            new DockerImageName(ResourceNameType.ProjectLocationRepositoryDockerImage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), dockerImageId: gax::GaxPreconditions.CheckNotNullOrEmpty(dockerImageId, nameof(dockerImageId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DockerImageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/dockerImages/{docker_image}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dockerImageId">The <c>DockerImage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DockerImageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/dockerImages/{docker_image}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string dockerImageId) =>
            FormatProjectLocationRepositoryDockerImage(projectId, locationId, repositoryId, dockerImageId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DockerImageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/dockerImages/{docker_image}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dockerImageId">The <c>DockerImage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DockerImageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/dockerImages/{docker_image}</c>.
        /// </returns>
        public static string FormatProjectLocationRepositoryDockerImage(string projectId, string locationId, string repositoryId, string dockerImageId) =>
            s_projectLocationRepositoryDockerImage.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dockerImageId, nameof(dockerImageId)));

        /// <summary>Parses the given resource name string into a new <see cref="DockerImageName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/dockerImages/{docker_image}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dockerImageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DockerImageName"/> if successful.</returns>
        public static DockerImageName Parse(string dockerImageName) => Parse(dockerImageName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DockerImageName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/dockerImages/{docker_image}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dockerImageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DockerImageName"/> if successful.</returns>
        public static DockerImageName Parse(string dockerImageName, bool allowUnparsed) =>
            TryParse(dockerImageName, allowUnparsed, out DockerImageName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DockerImageName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/dockerImages/{docker_image}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dockerImageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DockerImageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dockerImageName, out DockerImageName result) =>
            TryParse(dockerImageName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DockerImageName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/dockerImages/{docker_image}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dockerImageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DockerImageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dockerImageName, bool allowUnparsed, out DockerImageName result)
        {
            gax::GaxPreconditions.CheckNotNull(dockerImageName, nameof(dockerImageName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryDockerImage.TryParseName(dockerImageName, out resourceName))
            {
                result = FromProjectLocationRepositoryDockerImage(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dockerImageName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DockerImageName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string dockerImageId = null, string locationId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DockerImageId = dockerImageId;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DockerImageName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/dockerImages/{docker_image}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dockerImageId">The <c>DockerImage</c> ID. Must not be <c>null</c> or empty.</param>
        public DockerImageName(string projectId, string locationId, string repositoryId, string dockerImageId) : this(ResourceNameType.ProjectLocationRepositoryDockerImage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), dockerImageId: gax::GaxPreconditions.CheckNotNullOrEmpty(dockerImageId, nameof(dockerImageId)))
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
        /// The <c>DockerImage</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DockerImageId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Repository</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RepositoryId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRepositoryDockerImage: return s_projectLocationRepositoryDockerImage.Expand(ProjectId, LocationId, RepositoryId, DockerImageId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DockerImageName);

        /// <inheritdoc/>
        public bool Equals(DockerImageName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(DockerImageName a, DockerImageName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(DockerImageName a, DockerImageName b) => !(a == b);
    }

    public partial class DockerImage
    {
        /// <summary>
        /// <see cref="gcav::DockerImageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DockerImageName DockerImageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DockerImageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDockerImageRequest
    {
        /// <summary>
        /// <see cref="gcav::DockerImageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DockerImageName DockerImageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DockerImageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
