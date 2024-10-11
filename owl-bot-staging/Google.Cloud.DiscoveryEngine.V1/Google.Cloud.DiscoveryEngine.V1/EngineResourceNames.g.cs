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
using gcdv = Google.Cloud.DiscoveryEngine.V1;
using sys = System;

namespace Google.Cloud.DiscoveryEngine.V1
{
    /// <summary>Resource name for the <c>Engine</c> resource.</summary>
    public sealed partial class EngineName : gax::IResourceName, sys::IEquatable<EngineName>
    {
        /// <summary>The possible contents of <see cref="EngineName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}</c>.
            /// </summary>
            ProjectLocationCollectionEngine = 1,
        }

        private static gax::PathTemplate s_projectLocationCollectionEngine = new gax::PathTemplate("projects/{project}/locations/{location}/collections/{collection}/engines/{engine}");

        /// <summary>Creates a <see cref="EngineName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EngineName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EngineName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EngineName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EngineName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineId">The <c>Engine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EngineName"/> constructed from the provided ids.</returns>
        public static EngineName FromProjectLocationCollectionEngine(string projectId, string locationId, string collectionId, string engineId) =>
            new EngineName(ResourceNameType.ProjectLocationCollectionEngine, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), engineId: gax::GaxPreconditions.CheckNotNullOrEmpty(engineId, nameof(engineId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EngineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineId">The <c>Engine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EngineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string collectionId, string engineId) =>
            FormatProjectLocationCollectionEngine(projectId, locationId, collectionId, engineId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EngineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineId">The <c>Engine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EngineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}</c>.
        /// </returns>
        public static string FormatProjectLocationCollectionEngine(string projectId, string locationId, string collectionId, string engineId) =>
            s_projectLocationCollectionEngine.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(engineId, nameof(engineId)));

        /// <summary>Parses the given resource name string into a new <see cref="EngineName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="engineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EngineName"/> if successful.</returns>
        public static EngineName Parse(string engineName) => Parse(engineName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EngineName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="engineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EngineName"/> if successful.</returns>
        public static EngineName Parse(string engineName, bool allowUnparsed) =>
            TryParse(engineName, allowUnparsed, out EngineName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EngineName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="engineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EngineName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string engineName, out EngineName result) => TryParse(engineName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EngineName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="engineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EngineName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string engineName, bool allowUnparsed, out EngineName result)
        {
            gax::GaxPreconditions.CheckNotNull(engineName, nameof(engineName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCollectionEngine.TryParseName(engineName, out resourceName))
            {
                result = FromProjectLocationCollectionEngine(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(engineName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EngineName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string collectionId = null, string engineId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CollectionId = collectionId;
            EngineId = engineId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EngineName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/collections/{collection}/engines/{engine}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="collectionId">The <c>Collection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="engineId">The <c>Engine</c> ID. Must not be <c>null</c> or empty.</param>
        public EngineName(string projectId, string locationId, string collectionId, string engineId) : this(ResourceNameType.ProjectLocationCollectionEngine, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), collectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(collectionId, nameof(collectionId)), engineId: gax::GaxPreconditions.CheckNotNullOrEmpty(engineId, nameof(engineId)))
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
        /// The <c>Collection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CollectionId { get; }

        /// <summary>
        /// The <c>Engine</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EngineId { get; }

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
                case ResourceNameType.ProjectLocationCollectionEngine: return s_projectLocationCollectionEngine.Expand(ProjectId, LocationId, CollectionId, EngineId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EngineName);

        /// <inheritdoc/>
        public bool Equals(EngineName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EngineName a, EngineName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EngineName a, EngineName b) => !(a == b);
    }

    public partial class Engine
    {
        /// <summary>
        /// <see cref="gcdv::EngineName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EngineName EngineName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EngineName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
