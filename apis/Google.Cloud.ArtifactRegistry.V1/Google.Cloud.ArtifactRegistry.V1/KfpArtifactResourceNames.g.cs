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
    /// <summary>Resource name for the <c>KfpArtifact</c> resource.</summary>
    public sealed partial class KfpArtifactName : gax::IResourceName, sys::IEquatable<KfpArtifactName>
    {
        /// <summary>The possible contents of <see cref="KfpArtifactName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/repositories/{repository}/kfpArtifacts/{kfp_artifact}</c>.
            /// </summary>
            ProjectLocationRepositoryKfpArtifact = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryKfpArtifact = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/kfpArtifacts/{kfp_artifact}");

        /// <summary>Creates a <see cref="KfpArtifactName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="KfpArtifactName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static KfpArtifactName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new KfpArtifactName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="KfpArtifactName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/kfpArtifacts/{kfp_artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="kfpArtifactId">The <c>KfpArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="KfpArtifactName"/> constructed from the provided ids.</returns>
        public static KfpArtifactName FromProjectLocationRepositoryKfpArtifact(string projectId, string locationId, string repositoryId, string kfpArtifactId) =>
            new KfpArtifactName(ResourceNameType.ProjectLocationRepositoryKfpArtifact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), kfpArtifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(kfpArtifactId, nameof(kfpArtifactId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KfpArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/kfpArtifacts/{kfp_artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="kfpArtifactId">The <c>KfpArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="KfpArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/kfpArtifacts/{kfp_artifact}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string kfpArtifactId) =>
            FormatProjectLocationRepositoryKfpArtifact(projectId, locationId, repositoryId, kfpArtifactId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KfpArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/kfpArtifacts/{kfp_artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="kfpArtifactId">The <c>KfpArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="KfpArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/kfpArtifacts/{kfp_artifact}</c>.
        /// </returns>
        public static string FormatProjectLocationRepositoryKfpArtifact(string projectId, string locationId, string repositoryId, string kfpArtifactId) =>
            s_projectLocationRepositoryKfpArtifact.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(kfpArtifactId, nameof(kfpArtifactId)));

        /// <summary>Parses the given resource name string into a new <see cref="KfpArtifactName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/kfpArtifacts/{kfp_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="kfpArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="KfpArtifactName"/> if successful.</returns>
        public static KfpArtifactName Parse(string kfpArtifactName) => Parse(kfpArtifactName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KfpArtifactName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/kfpArtifacts/{kfp_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="kfpArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="KfpArtifactName"/> if successful.</returns>
        public static KfpArtifactName Parse(string kfpArtifactName, bool allowUnparsed) =>
            TryParse(kfpArtifactName, allowUnparsed, out KfpArtifactName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KfpArtifactName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/kfpArtifacts/{kfp_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="kfpArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KfpArtifactName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string kfpArtifactName, out KfpArtifactName result) =>
            TryParse(kfpArtifactName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KfpArtifactName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/kfpArtifacts/{kfp_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="kfpArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KfpArtifactName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string kfpArtifactName, bool allowUnparsed, out KfpArtifactName result)
        {
            gax::GaxPreconditions.CheckNotNull(kfpArtifactName, nameof(kfpArtifactName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryKfpArtifact.TryParseName(kfpArtifactName, out resourceName))
            {
                result = FromProjectLocationRepositoryKfpArtifact(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(kfpArtifactName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private KfpArtifactName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string kfpArtifactId = null, string locationId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            KfpArtifactId = kfpArtifactId;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="KfpArtifactName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/kfpArtifacts/{kfp_artifact}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="kfpArtifactId">The <c>KfpArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        public KfpArtifactName(string projectId, string locationId, string repositoryId, string kfpArtifactId) : this(ResourceNameType.ProjectLocationRepositoryKfpArtifact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), kfpArtifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(kfpArtifactId, nameof(kfpArtifactId)))
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
        /// The <c>KfpArtifact</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string KfpArtifactId { get; }

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
                case ResourceNameType.ProjectLocationRepositoryKfpArtifact: return s_projectLocationRepositoryKfpArtifact.Expand(ProjectId, LocationId, RepositoryId, KfpArtifactId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as KfpArtifactName);

        /// <inheritdoc/>
        public bool Equals(KfpArtifactName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(KfpArtifactName a, KfpArtifactName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(KfpArtifactName a, KfpArtifactName b) => !(a == b);
    }

    public partial class KfpArtifact
    {
        /// <summary>
        /// <see cref="gcav::KfpArtifactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::KfpArtifactName KfpArtifactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::KfpArtifactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
