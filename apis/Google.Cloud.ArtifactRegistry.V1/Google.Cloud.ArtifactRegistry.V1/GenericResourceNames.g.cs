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
    /// <summary>Resource name for the <c>GenericArtifact</c> resource.</summary>
    public sealed partial class GenericArtifactName : gax::IResourceName, sys::IEquatable<GenericArtifactName>
    {
        /// <summary>The possible contents of <see cref="GenericArtifactName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/repositories/{repository}/genericArtifacts/{generic_artifact}</c>
            /// .
            /// </summary>
            ProjectLocationRepositoryGenericArtifact = 1,
        }

        private static gax::PathTemplate s_projectLocationRepositoryGenericArtifact = new gax::PathTemplate("projects/{project}/locations/{location}/repositories/{repository}/genericArtifacts/{generic_artifact}");

        /// <summary>Creates a <see cref="GenericArtifactName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GenericArtifactName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GenericArtifactName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GenericArtifactName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GenericArtifactName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/genericArtifacts/{generic_artifact}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="genericArtifactId">The <c>GenericArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GenericArtifactName"/> constructed from the provided ids.</returns>
        public static GenericArtifactName FromProjectLocationRepositoryGenericArtifact(string projectId, string locationId, string repositoryId, string genericArtifactId) =>
            new GenericArtifactName(ResourceNameType.ProjectLocationRepositoryGenericArtifact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), genericArtifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(genericArtifactId, nameof(genericArtifactId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GenericArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/genericArtifacts/{generic_artifact}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="genericArtifactId">The <c>GenericArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GenericArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/genericArtifacts/{generic_artifact}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string repositoryId, string genericArtifactId) =>
            FormatProjectLocationRepositoryGenericArtifact(projectId, locationId, repositoryId, genericArtifactId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GenericArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/genericArtifacts/{generic_artifact}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="genericArtifactId">The <c>GenericArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GenericArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/genericArtifacts/{generic_artifact}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationRepositoryGenericArtifact(string projectId, string locationId, string repositoryId, string genericArtifactId) =>
            s_projectLocationRepositoryGenericArtifact.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), gax::GaxPreconditions.CheckNotNullOrEmpty(genericArtifactId, nameof(genericArtifactId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GenericArtifactName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/genericArtifacts/{generic_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="genericArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GenericArtifactName"/> if successful.</returns>
        public static GenericArtifactName Parse(string genericArtifactName) => Parse(genericArtifactName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GenericArtifactName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/genericArtifacts/{generic_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="genericArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GenericArtifactName"/> if successful.</returns>
        public static GenericArtifactName Parse(string genericArtifactName, bool allowUnparsed) =>
            TryParse(genericArtifactName, allowUnparsed, out GenericArtifactName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GenericArtifactName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/genericArtifacts/{generic_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="genericArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GenericArtifactName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string genericArtifactName, out GenericArtifactName result) =>
            TryParse(genericArtifactName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GenericArtifactName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/genericArtifacts/{generic_artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="genericArtifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GenericArtifactName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string genericArtifactName, bool allowUnparsed, out GenericArtifactName result)
        {
            gax::GaxPreconditions.CheckNotNull(genericArtifactName, nameof(genericArtifactName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRepositoryGenericArtifact.TryParseName(genericArtifactName, out resourceName))
            {
                result = FromProjectLocationRepositoryGenericArtifact(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(genericArtifactName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GenericArtifactName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string genericArtifactId = null, string locationId = null, string projectId = null, string repositoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GenericArtifactId = genericArtifactId;
            LocationId = locationId;
            ProjectId = projectId;
            RepositoryId = repositoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GenericArtifactName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/repositories/{repository}/genericArtifacts/{generic_artifact}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="repositoryId">The <c>Repository</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="genericArtifactId">The <c>GenericArtifact</c> ID. Must not be <c>null</c> or empty.</param>
        public GenericArtifactName(string projectId, string locationId, string repositoryId, string genericArtifactId) : this(ResourceNameType.ProjectLocationRepositoryGenericArtifact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), repositoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(repositoryId, nameof(repositoryId)), genericArtifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(genericArtifactId, nameof(genericArtifactId)))
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
        /// The <c>GenericArtifact</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string GenericArtifactId { get; }

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
                case ResourceNameType.ProjectLocationRepositoryGenericArtifact: return s_projectLocationRepositoryGenericArtifact.Expand(ProjectId, LocationId, RepositoryId, GenericArtifactId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GenericArtifactName);

        /// <inheritdoc/>
        public bool Equals(GenericArtifactName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GenericArtifactName a, GenericArtifactName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GenericArtifactName a, GenericArtifactName b) => !(a == b);
    }

    public partial class GenericArtifact
    {
        /// <summary>
        /// <see cref="gcav::GenericArtifactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::GenericArtifactName GenericArtifactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::GenericArtifactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
