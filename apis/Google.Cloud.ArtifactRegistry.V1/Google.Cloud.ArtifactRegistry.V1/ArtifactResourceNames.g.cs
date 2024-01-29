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

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DockerImageName a, DockerImageName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DockerImageName a, DockerImageName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>MavenArtifact</c> resource.</summary>
    public sealed partial class MavenArtifactName : gax::IResourceName, sys::IEquatable<MavenArtifactName>
    {
        /// <summary>The possible contents of <see cref="MavenArtifactName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/repositories/{repository}/mavenArtifacts/{maven_artifact}</c>
            /// .
            /// </summary>
            ProjectLocationRepositoryMavenArtifact = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryMavenArtifact = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/mavenArtifacts/{maven_artifact}");

        /// <summary>Creates a <see cref="MavenArtifactName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MavenArtifactName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MavenArtifactName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MavenArtifactName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MavenArtifactName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/mavenArtifacts/{maven_artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mavenArtifactId">The <c>MavenArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MavenArtifactName"/> constructed from the provided ids.</returns>
        public static MavenArtifactName FromProjectLocationRepositoryMavenArtifact(string projectId, string locationId, string repositoryId, string mavenArtifactId) =>
            new MavenArtifactName(ResourceNameType.ProjectLocationRepositoryMavenArtifact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), mavenArtifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(mavenArtifactId, nameof(mavenArtifactId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MavenArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/mavenArtifacts/{maven_artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mavenArtifactId">The <c>MavenArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MavenArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/mavenArtifacts/{maven_artifact}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string mavenArtifactId) =>
            FormatProjectLocationRepositoryMavenArtifact(projectId, locationId, repositoryId, mavenArtifactId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MavenArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/mavenArtifacts/{maven_artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mavenArtifactId">The <c>MavenArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MavenArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/mavenArtifacts/{maven_artifact}</c>.
        /// </returns>
        public static string FormatProjectLocationRepositoryMavenArtifact(string projectId, string locationId, string repositoryId, string mavenArtifactId) =>
            s_projectLocationRepositoryMavenArtifact.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(mavenArtifactId, nameof(mavenArtifactId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MavenArtifactName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/mavenArtifacts/{maven_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="mavenArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MavenArtifactName"/> if successful.</returns>
        public static MavenArtifactName Parse(string mavenArtifactName) => Parse(mavenArtifactName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MavenArtifactName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/mavenArtifacts/{maven_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mavenArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MavenArtifactName"/> if successful.</returns>
        public static MavenArtifactName Parse(string mavenArtifactName, bool allowUnparsed) =>
            TryParse(mavenArtifactName, allowUnparsed, out MavenArtifactName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MavenArtifactName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/mavenArtifacts/{maven_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="mavenArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MavenArtifactName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mavenArtifactName, out MavenArtifactName result) =>
            TryParse(mavenArtifactName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MavenArtifactName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/mavenArtifacts/{maven_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mavenArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MavenArtifactName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mavenArtifactName, bool allowUnparsed, out MavenArtifactName result)
        {
            gax::GaxPreconditions.CheckNotNull(mavenArtifactName, nameof(mavenArtifactName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryMavenArtifact.TryParseName(mavenArtifactName, out resourceName))
            {
                result = FromProjectLocationRepositoryMavenArtifact(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(mavenArtifactName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MavenArtifactName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string mavenArtifactId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MavenArtifactId = mavenArtifactId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MavenArtifactName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/mavenArtifacts/{maven_artifact}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mavenArtifactId">The <c>MavenArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        public MavenArtifactName(string projectId, string locationId, string repositoryId, string mavenArtifactId) : this(ResourceNameType.ProjectLocationRepositoryMavenArtifact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), mavenArtifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(mavenArtifactId, nameof(mavenArtifactId)))
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
        /// The <c>MavenArtifact</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string MavenArtifactId { get; }

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
                case ResourceNameType.ProjectLocationRepositoryMavenArtifact: return s_projectLocationRepositoryMavenArtifact.Expand(ProjectId, LocationId, RepositoryId, MavenArtifactId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MavenArtifactName);

        /// <inheritdoc/>
        public bool Equals(MavenArtifactName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MavenArtifactName a, MavenArtifactName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MavenArtifactName a, MavenArtifactName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>NpmPackage</c> resource.</summary>
    public sealed partial class NpmPackageName : gax::IResourceName, sys::IEquatable<NpmPackageName>
    {
        /// <summary>The possible contents of <see cref="NpmPackageName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/repositories/{repository}/npmPackages/{npm_package}</c>.
            /// </summary>
            ProjectLocationRepositoryNpmPackage = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryNpmPackage = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/npmPackages/{npm_package}");

        /// <summary>Creates a <see cref="NpmPackageName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NpmPackageName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NpmPackageName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NpmPackageName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NpmPackageName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/npmPackages/{npm_package}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="npmPackageId">The <c>NpmPackage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NpmPackageName"/> constructed from the provided ids.</returns>
        public static NpmPackageName FromProjectLocationRepositoryNpmPackage(string projectId, string locationId, string repositoryId, string npmPackageId) =>
            new NpmPackageName(ResourceNameType.ProjectLocationRepositoryNpmPackage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), npmPackageId: gax::GaxPreconditions.CheckNotNullOrEmpty(npmPackageId, nameof(npmPackageId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NpmPackageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/npmPackages/{npm_package}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="npmPackageId">The <c>NpmPackage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NpmPackageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/npmPackages/{npm_package}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string npmPackageId) =>
            FormatProjectLocationRepositoryNpmPackage(projectId, locationId, repositoryId, npmPackageId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NpmPackageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/npmPackages/{npm_package}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="npmPackageId">The <c>NpmPackage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NpmPackageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/npmPackages/{npm_package}</c>.
        /// </returns>
        public static string FormatProjectLocationRepositoryNpmPackage(string projectId, string locationId, string repositoryId, string npmPackageId) =>
            s_projectLocationRepositoryNpmPackage.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(npmPackageId, nameof(npmPackageId)));

        /// <summary>Parses the given resource name string into a new <see cref="NpmPackageName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/npmPackages/{npm_package}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="npmPackageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NpmPackageName"/> if successful.</returns>
        public static NpmPackageName Parse(string npmPackageName) => Parse(npmPackageName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NpmPackageName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/npmPackages/{npm_package}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="npmPackageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NpmPackageName"/> if successful.</returns>
        public static NpmPackageName Parse(string npmPackageName, bool allowUnparsed) =>
            TryParse(npmPackageName, allowUnparsed, out NpmPackageName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NpmPackageName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/npmPackages/{npm_package}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="npmPackageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NpmPackageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string npmPackageName, out NpmPackageName result) =>
            TryParse(npmPackageName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NpmPackageName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/npmPackages/{npm_package}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="npmPackageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NpmPackageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string npmPackageName, bool allowUnparsed, out NpmPackageName result)
        {
            gax::GaxPreconditions.CheckNotNull(npmPackageName, nameof(npmPackageName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryNpmPackage.TryParseName(npmPackageName, out resourceName))
            {
                result = FromProjectLocationRepositoryNpmPackage(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(npmPackageName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NpmPackageName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string npmPackageId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            NpmPackageId = npmPackageId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NpmPackageName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/npmPackages/{npm_package}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="npmPackageId">The <c>NpmPackage</c> ID. Must not be <c>null</c> or empty.</param>
        public NpmPackageName(string projectId, string locationId, string repositoryId, string npmPackageId) : this(ResourceNameType.ProjectLocationRepositoryNpmPackage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), npmPackageId: gax::GaxPreconditions.CheckNotNullOrEmpty(npmPackageId, nameof(npmPackageId)))
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
        /// The <c>NpmPackage</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NpmPackageId { get; }

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
                case ResourceNameType.ProjectLocationRepositoryNpmPackage: return s_projectLocationRepositoryNpmPackage.Expand(ProjectId, LocationId, RepositoryId, NpmPackageId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NpmPackageName);

        /// <inheritdoc/>
        public bool Equals(NpmPackageName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NpmPackageName a, NpmPackageName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NpmPackageName a, NpmPackageName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>PythonPackage</c> resource.</summary>
    public sealed partial class PythonPackageName : gax::IResourceName, sys::IEquatable<PythonPackageName>
    {
        /// <summary>The possible contents of <see cref="PythonPackageName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/repositories/{repository}/pythonPackages/{python_package}</c>
            /// .
            /// </summary>
            ProjectLocationRepositoryPythonPackage = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryPythonPackage = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/pythonPackages/{python_package}");

        /// <summary>Creates a <see cref="PythonPackageName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PythonPackageName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PythonPackageName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PythonPackageName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PythonPackageName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pythonPackages/{python_package}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pythonPackageId">The <c>PythonPackage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PythonPackageName"/> constructed from the provided ids.</returns>
        public static PythonPackageName FromProjectLocationRepositoryPythonPackage(string projectId, string locationId, string repositoryId, string pythonPackageId) =>
            new PythonPackageName(ResourceNameType.ProjectLocationRepositoryPythonPackage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), pythonPackageId: gax::GaxPreconditions.CheckNotNullOrEmpty(pythonPackageId, nameof(pythonPackageId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PythonPackageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pythonPackages/{python_package}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pythonPackageId">The <c>PythonPackage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PythonPackageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pythonPackages/{python_package}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string pythonPackageId) =>
            FormatProjectLocationRepositoryPythonPackage(projectId, locationId, repositoryId, pythonPackageId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PythonPackageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pythonPackages/{python_package}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pythonPackageId">The <c>PythonPackage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PythonPackageName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pythonPackages/{python_package}</c>.
        /// </returns>
        public static string FormatProjectLocationRepositoryPythonPackage(string projectId, string locationId, string repositoryId, string pythonPackageId) =>
            s_projectLocationRepositoryPythonPackage.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(pythonPackageId, nameof(pythonPackageId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PythonPackageName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pythonPackages/{python_package}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="pythonPackageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PythonPackageName"/> if successful.</returns>
        public static PythonPackageName Parse(string pythonPackageName) => Parse(pythonPackageName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PythonPackageName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pythonPackages/{python_package}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="pythonPackageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PythonPackageName"/> if successful.</returns>
        public static PythonPackageName Parse(string pythonPackageName, bool allowUnparsed) =>
            TryParse(pythonPackageName, allowUnparsed, out PythonPackageName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PythonPackageName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pythonPackages/{python_package}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="pythonPackageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PythonPackageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string pythonPackageName, out PythonPackageName result) =>
            TryParse(pythonPackageName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PythonPackageName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pythonPackages/{python_package}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="pythonPackageName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PythonPackageName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string pythonPackageName, bool allowUnparsed, out PythonPackageName result)
        {
            gax::GaxPreconditions.CheckNotNull(pythonPackageName, nameof(pythonPackageName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryPythonPackage.TryParseName(pythonPackageName, out resourceName))
            {
                result = FromProjectLocationRepositoryPythonPackage(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(pythonPackageName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PythonPackageName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string pythonPackageId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            PythonPackageId = pythonPackageId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PythonPackageName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/pythonPackages/{python_package}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="pythonPackageId">The <c>PythonPackage</c> ID. Must not be <c>null</c> or empty.</param>
        public PythonPackageName(string projectId, string locationId, string repositoryId, string pythonPackageId) : this(ResourceNameType.ProjectLocationRepositoryPythonPackage, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), pythonPackageId: gax::GaxPreconditions.CheckNotNullOrEmpty(pythonPackageId, nameof(pythonPackageId)))
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
        /// The <c>PythonPackage</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PythonPackageId { get; }

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
                case ResourceNameType.ProjectLocationRepositoryPythonPackage: return s_projectLocationRepositoryPythonPackage.Expand(ProjectId, LocationId, RepositoryId, PythonPackageId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PythonPackageName);

        /// <inheritdoc/>
        public bool Equals(PythonPackageName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PythonPackageName a, PythonPackageName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PythonPackageName a, PythonPackageName b) => !(a == b);
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

    public partial class MavenArtifact
    {
        /// <summary>
        /// <see cref="gcav::MavenArtifactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::MavenArtifactName MavenArtifactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::MavenArtifactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMavenArtifactsRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetMavenArtifactRequest
    {
        /// <summary>
        /// <see cref="gcav::MavenArtifactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::MavenArtifactName MavenArtifactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::MavenArtifactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class NpmPackage
    {
        /// <summary>
        /// <see cref="gcav::NpmPackageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::NpmPackageName NpmPackageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NpmPackageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListNpmPackagesRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetNpmPackageRequest
    {
        /// <summary>
        /// <see cref="gcav::NpmPackageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::NpmPackageName NpmPackageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NpmPackageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PythonPackage
    {
        /// <summary>
        /// <see cref="gcav::PythonPackageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PythonPackageName PythonPackageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PythonPackageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPythonPackagesRequest
    {
        /// <summary>
        /// <see cref="RepositoryName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public RepositoryName ParentAsRepositoryName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RepositoryName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetPythonPackageRequest
    {
        /// <summary>
        /// <see cref="gcav::PythonPackageName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PythonPackageName PythonPackageName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PythonPackageName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
