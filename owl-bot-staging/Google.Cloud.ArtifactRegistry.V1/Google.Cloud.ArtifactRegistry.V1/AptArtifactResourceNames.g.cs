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
    /// <summary>Resource name for the <c>AptArtifact</c> resource.</summary>
    public sealed partial class AptArtifactName : gax::IResourceName, sys::IEquatable<AptArtifactName>
    {
        /// <summary>The possible contents of <see cref="AptArtifactName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/repositories/{repository}/aptArtifacts/{apt_artifact}</c>.
            /// </summary>
            ProjectLocationRepositoryAptArtifact = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryAptArtifact = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/aptArtifacts/{apt_artifact}");

        /// <summary>Creates a <see cref="AptArtifactName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AptArtifactName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AptArtifactName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AptArtifactName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AptArtifactName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/aptArtifacts/{apt_artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="aptArtifactId">The <c>AptArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AptArtifactName"/> constructed from the provided ids.</returns>
        public static AptArtifactName FromProjectLocationRepositoryAptArtifact(string projectId, string locationId, string repositoryId, string aptArtifactId) =>
            new AptArtifactName(ResourceNameType.ProjectLocationRepositoryAptArtifact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), aptArtifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(aptArtifactId, nameof(aptArtifactId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AptArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/aptArtifacts/{apt_artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="aptArtifactId">The <c>AptArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AptArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/aptArtifacts/{apt_artifact}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string aptArtifactId) =>
            FormatProjectLocationRepositoryAptArtifact(projectId, locationId, repositoryId, aptArtifactId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AptArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/aptArtifacts/{apt_artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="aptArtifactId">The <c>AptArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AptArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/aptArtifacts/{apt_artifact}</c>.
        /// </returns>
        public static string FormatProjectLocationRepositoryAptArtifact(string projectId, string locationId, string repositoryId, string aptArtifactId) =>
            s_projectLocationRepositoryAptArtifact.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(aptArtifactId, nameof(aptArtifactId)));

        /// <summary>Parses the given resource name string into a new <see cref="AptArtifactName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/aptArtifacts/{apt_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="aptArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AptArtifactName"/> if successful.</returns>
        public static AptArtifactName Parse(string aptArtifactName) => Parse(aptArtifactName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AptArtifactName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/aptArtifacts/{apt_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="aptArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AptArtifactName"/> if successful.</returns>
        public static AptArtifactName Parse(string aptArtifactName, bool allowUnparsed) =>
            TryParse(aptArtifactName, allowUnparsed, out AptArtifactName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AptArtifactName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/aptArtifacts/{apt_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="aptArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AptArtifactName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string aptArtifactName, out AptArtifactName result) =>
            TryParse(aptArtifactName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AptArtifactName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/aptArtifacts/{apt_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="aptArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AptArtifactName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string aptArtifactName, bool allowUnparsed, out AptArtifactName result)
        {
            gax::GaxPreconditions.CheckNotNull(aptArtifactName, nameof(aptArtifactName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryAptArtifact.TryParseName(aptArtifactName, out resourceName))
            {
                result = FromProjectLocationRepositoryAptArtifact(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(aptArtifactName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AptArtifactName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string aptArtifactId = null, string locationId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AptArtifactId = aptArtifactId;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AptArtifactName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/aptArtifacts/{apt_artifact}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="aptArtifactId">The <c>AptArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        public AptArtifactName(string projectId, string locationId, string repositoryId, string aptArtifactId) : this(ResourceNameType.ProjectLocationRepositoryAptArtifact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), aptArtifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(aptArtifactId, nameof(aptArtifactId)))
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
        /// The <c>AptArtifact</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AptArtifactId { get; }

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
                case ResourceNameType.ProjectLocationRepositoryAptArtifact: return s_projectLocationRepositoryAptArtifact.Expand(ProjectId, LocationId, RepositoryId, AptArtifactId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AptArtifactName);

        /// <inheritdoc/>
        public bool Equals(AptArtifactName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AptArtifactName a, AptArtifactName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AptArtifactName a, AptArtifactName b) => !(a == b);
    }

    public partial class AptArtifact
    {
        /// <summary>
        /// <see cref="gcav::AptArtifactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::AptArtifactName AptArtifactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AptArtifactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
