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
    /// <summary>Resource name for the <c>PersistentResource</c> resource.</summary>
    public sealed partial class PersistentResourceName : gax::IResourceName, sys::IEquatable<PersistentResourceName>
    {
        /// <summary>The possible contents of <see cref="PersistentResourceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/persistentResources/{persistent_resource}</c>.
            /// </summary>
            ProjectLocationPersistentResource = 1,
        }

        private static gax::PathTemplate s_projectLocationPersistentResource = new gax::PathTemplate("projects/{project}/locations/{location}/persistentResources/{persistent_resource}");

        /// <summary>Creates a <see cref="PersistentResourceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PersistentResourceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PersistentResourceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PersistentResourceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PersistentResourceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/persistentResources/{persistent_resource}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="persistentResourceId">
        /// The <c>PersistentResource</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="PersistentResourceName"/> constructed from the provided ids.</returns>
        public static PersistentResourceName FromProjectLocationPersistentResource(string projectId, string locationId, string persistentResourceId) =>
            new PersistentResourceName(ResourceNameType.ProjectLocationPersistentResource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), persistentResourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(persistentResourceId, nameof(persistentResourceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PersistentResourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/persistentResources/{persistent_resource}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="persistentResourceId">
        /// The <c>PersistentResource</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="PersistentResourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/persistentResources/{persistent_resource}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string persistentResourceId) =>
            FormatProjectLocationPersistentResource(projectId, locationId, persistentResourceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PersistentResourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/persistentResources/{persistent_resource}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="persistentResourceId">
        /// The <c>PersistentResource</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="PersistentResourceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/persistentResources/{persistent_resource}</c>.
        /// </returns>
        public static string FormatProjectLocationPersistentResource(string projectId, string locationId, string persistentResourceId) =>
            s_projectLocationPersistentResource.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(persistentResourceId, nameof(persistentResourceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PersistentResourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/persistentResources/{persistent_resource}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="persistentResourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PersistentResourceName"/> if successful.</returns>
        public static PersistentResourceName Parse(string persistentResourceName) => Parse(persistentResourceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PersistentResourceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/persistentResources/{persistent_resource}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="persistentResourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PersistentResourceName"/> if successful.</returns>
        public static PersistentResourceName Parse(string persistentResourceName, bool allowUnparsed) =>
            TryParse(persistentResourceName, allowUnparsed, out PersistentResourceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PersistentResourceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/persistentResources/{persistent_resource}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="persistentResourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PersistentResourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string persistentResourceName, out PersistentResourceName result) =>
            TryParse(persistentResourceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PersistentResourceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/persistentResources/{persistent_resource}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="persistentResourceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PersistentResourceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string persistentResourceName, bool allowUnparsed, out PersistentResourceName result)
        {
            gax::GaxPreconditions.CheckNotNull(persistentResourceName, nameof(persistentResourceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationPersistentResource.TryParseName(persistentResourceName, out resourceName))
            {
                result = FromProjectLocationPersistentResource(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(persistentResourceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PersistentResourceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string persistentResourceId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            PersistentResourceId = persistentResourceId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PersistentResourceName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/persistentResources/{persistent_resource}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="persistentResourceId">
        /// The <c>PersistentResource</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public PersistentResourceName(string projectId, string locationId, string persistentResourceId) : this(ResourceNameType.ProjectLocationPersistentResource, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), persistentResourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(persistentResourceId, nameof(persistentResourceId)))
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
        /// The <c>PersistentResource</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string PersistentResourceId { get; }

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
                case ResourceNameType.ProjectLocationPersistentResource: return s_projectLocationPersistentResource.Expand(ProjectId, LocationId, PersistentResourceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PersistentResourceName);

        /// <inheritdoc/>
        public bool Equals(PersistentResourceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PersistentResourceName a, PersistentResourceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PersistentResourceName a, PersistentResourceName b) => !(a == b);
    }

    public partial class PersistentResource
    {
        /// <summary>
        /// <see cref="gcav::PersistentResourceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PersistentResourceName PersistentResourceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PersistentResourceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
        /// </summary>
        public NetworkName NetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
            set => Network = value?.ToString() ?? "";
        }
    }
}
