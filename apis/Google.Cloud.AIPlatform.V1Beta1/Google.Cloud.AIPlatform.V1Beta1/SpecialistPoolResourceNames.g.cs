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
using gcav = Google.Cloud.AIPlatform.V1Beta1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Resource name for the <c>SpecialistPool</c> resource.</summary>
    public sealed partial class SpecialistPoolName : gax::IResourceName, sys::IEquatable<SpecialistPoolName>
    {
        /// <summary>The possible contents of <see cref="SpecialistPoolName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/specialistPools/{specialist_pool}</c>.
            /// </summary>
            ProjectLocationSpecialistPool = 1,
        }

        private static gax::PathTemplate s_projectLocationSpecialistPool = new gax::PathTemplate("projects/{project}/locations/{location}/specialistPools/{specialist_pool}");

        /// <summary>Creates a <see cref="SpecialistPoolName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SpecialistPoolName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SpecialistPoolName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SpecialistPoolName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SpecialistPoolName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/specialistPools/{specialist_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="specialistPoolId">The <c>SpecialistPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SpecialistPoolName"/> constructed from the provided ids.</returns>
        public static SpecialistPoolName FromProjectLocationSpecialistPool(string projectId, string locationId, string specialistPoolId) =>
            new SpecialistPoolName(ResourceNameType.ProjectLocationSpecialistPool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), specialistPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(specialistPoolId, nameof(specialistPoolId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SpecialistPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/specialistPools/{specialist_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="specialistPoolId">The <c>SpecialistPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SpecialistPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/specialistPools/{specialist_pool}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string specialistPoolId) =>
            FormatProjectLocationSpecialistPool(projectId, locationId, specialistPoolId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SpecialistPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/specialistPools/{specialist_pool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="specialistPoolId">The <c>SpecialistPool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SpecialistPoolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/specialistPools/{specialist_pool}</c>.
        /// </returns>
        public static string FormatProjectLocationSpecialistPool(string projectId, string locationId, string specialistPoolId) =>
            s_projectLocationSpecialistPool.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(specialistPoolId, nameof(specialistPoolId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SpecialistPoolName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/specialistPools/{specialist_pool}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="specialistPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SpecialistPoolName"/> if successful.</returns>
        public static SpecialistPoolName Parse(string specialistPoolName) => Parse(specialistPoolName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SpecialistPoolName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/specialistPools/{specialist_pool}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="specialistPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SpecialistPoolName"/> if successful.</returns>
        public static SpecialistPoolName Parse(string specialistPoolName, bool allowUnparsed) =>
            TryParse(specialistPoolName, allowUnparsed, out SpecialistPoolName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SpecialistPoolName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/specialistPools/{specialist_pool}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="specialistPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SpecialistPoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string specialistPoolName, out SpecialistPoolName result) =>
            TryParse(specialistPoolName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SpecialistPoolName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/specialistPools/{specialist_pool}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="specialistPoolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SpecialistPoolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string specialistPoolName, bool allowUnparsed, out SpecialistPoolName result)
        {
            gax::GaxPreconditions.CheckNotNull(specialistPoolName, nameof(specialistPoolName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationSpecialistPool.TryParseName(specialistPoolName, out resourceName))
            {
                result = FromProjectLocationSpecialistPool(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(specialistPoolName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SpecialistPoolName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string specialistPoolId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            SpecialistPoolId = specialistPoolId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SpecialistPoolName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/specialistPools/{specialist_pool}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="specialistPoolId">The <c>SpecialistPool</c> ID. Must not be <c>null</c> or empty.</param>
        public SpecialistPoolName(string projectId, string locationId, string specialistPoolId) : this(ResourceNameType.ProjectLocationSpecialistPool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), specialistPoolId: gax::GaxPreconditions.CheckNotNullOrEmpty(specialistPoolId, nameof(specialistPoolId)))
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
        /// The <c>SpecialistPool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string SpecialistPoolId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationSpecialistPool: return s_projectLocationSpecialistPool.Expand(ProjectId, LocationId, SpecialistPoolId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SpecialistPoolName);

        /// <inheritdoc/>
        public bool Equals(SpecialistPoolName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SpecialistPoolName a, SpecialistPoolName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SpecialistPoolName a, SpecialistPoolName b) => !(a == b);
    }

    public partial class SpecialistPool
    {
        /// <summary>
        /// <see cref="gcav::SpecialistPoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::SpecialistPoolName SpecialistPoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::SpecialistPoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
