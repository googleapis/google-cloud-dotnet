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
using gcav = Google.Cloud.AIPlatform.V1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Resource name for the <c>Artifact</c> resource.</summary>
    public sealed partial class ArtifactName : gax::IResourceName, sys::IEquatable<ArtifactName>
    {
        /// <summary>The possible contents of <see cref="ArtifactName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/artifacts/{artifact}</c>.
            /// </summary>
            ProjectLocationMetadataStoreArtifact = 1,
        }

        private static gax::PathTemplate s_projectLocationMetadataStoreArtifact = new gax::PathTemplate("projects/{project}/locations/{location}/metadataStores/{metadata_store}/artifacts/{artifact}");

        /// <summary>Creates a <see cref="ArtifactName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ArtifactName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static ArtifactName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ArtifactName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ArtifactName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/artifacts/{artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metadataStoreId">The <c>MetadataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ArtifactName"/> constructed from the provided ids.</returns>
        public static ArtifactName FromProjectLocationMetadataStoreArtifact(string projectId, string locationId, string metadataStoreId, string artifactId) =>
            new ArtifactName(ResourceNameType.ProjectLocationMetadataStoreArtifact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), metadataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(metadataStoreId, nameof(metadataStoreId)), artifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/artifacts/{artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metadataStoreId">The <c>MetadataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/artifacts/{artifact}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string metadataStoreId, string artifactId) =>
            FormatProjectLocationMetadataStoreArtifact(projectId, locationId, metadataStoreId, artifactId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/artifacts/{artifact}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metadataStoreId">The <c>MetadataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ArtifactName"/> with pattern
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/artifacts/{artifact}</c>.
        /// </returns>
        public static string FormatProjectLocationMetadataStoreArtifact(string projectId, string locationId, string metadataStoreId, string artifactId) =>
            s_projectLocationMetadataStoreArtifact.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(metadataStoreId, nameof(metadataStoreId)), gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)));

        /// <summary>Parses the given resource name string into a new <see cref="ArtifactName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="artifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ArtifactName"/> if successful.</returns>
        public static ArtifactName Parse(string artifactName) => Parse(artifactName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ArtifactName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="artifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ArtifactName"/> if successful.</returns>
        public static ArtifactName Parse(string artifactName, bool allowUnparsed) =>
            TryParse(artifactName, allowUnparsed, out ArtifactName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ArtifactName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="artifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ArtifactName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string artifactName, out ArtifactName result) => TryParse(artifactName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ArtifactName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/artifacts/{artifact}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="artifactName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ArtifactName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string artifactName, bool allowUnparsed, out ArtifactName result)
        {
            gax::GaxPreconditions.CheckNotNull(artifactName, nameof(artifactName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMetadataStoreArtifact.TryParseName(artifactName, out resourceName))
            {
                result = FromProjectLocationMetadataStoreArtifact(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(artifactName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ArtifactName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string artifactId = null, string locationId = null, string metadataStoreId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ArtifactId = artifactId;
            LocationId = locationId;
            MetadataStoreId = metadataStoreId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ArtifactName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/metadataStores/{metadata_store}/artifacts/{artifact}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="metadataStoreId">The <c>MetadataStore</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="artifactId">The <c>Artifact</c> ID. Must not be <c>null</c> or empty.</param>
        public ArtifactName(string projectId, string locationId, string metadataStoreId, string artifactId) : this(ResourceNameType.ProjectLocationMetadataStoreArtifact, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), metadataStoreId: gax::GaxPreconditions.CheckNotNullOrEmpty(metadataStoreId, nameof(metadataStoreId)), artifactId: gax::GaxPreconditions.CheckNotNullOrEmpty(artifactId, nameof(artifactId)))
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
        /// The <c>Artifact</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ArtifactId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>MetadataStore</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string MetadataStoreId { get; }

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
                case ResourceNameType.ProjectLocationMetadataStoreArtifact: return s_projectLocationMetadataStoreArtifact.Expand(ProjectId, LocationId, MetadataStoreId, ArtifactId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ArtifactName);

        /// <inheritdoc/>
        public bool Equals(ArtifactName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ArtifactName a, ArtifactName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ArtifactName a, ArtifactName b) => !(a == b);
    }

    public partial class Artifact
    {
        /// <summary>
        /// <see cref="gcav::ArtifactName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ArtifactName ArtifactName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ArtifactName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
