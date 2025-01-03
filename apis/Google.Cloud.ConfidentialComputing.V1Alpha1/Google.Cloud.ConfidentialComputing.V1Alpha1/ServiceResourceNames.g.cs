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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gccv = Google.Cloud.ConfidentialComputing.V1Alpha1;
using sys = System;

namespace Google.Cloud.ConfidentialComputing.V1Alpha1
{
    /// <summary>Resource name for the <c>Challenge</c> resource.</summary>
    public sealed partial class ChallengeName : gax::IResourceName, sys::IEquatable<ChallengeName>
    {
        /// <summary>The possible contents of <see cref="ChallengeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/challenges/{uuid}</c>.
            /// </summary>
            ProjectLocationUuid = 1,
        }

        private static gax::PathTemplate s_projectLocationUuid = new gax::PathTemplate("projects/{project}/locations/{location}/challenges/{uuid}");

        /// <summary>Creates a <see cref="ChallengeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ChallengeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ChallengeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ChallengeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ChallengeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/challenges/{uuid}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="uuidId">The <c>Uuid</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ChallengeName"/> constructed from the provided ids.</returns>
        public static ChallengeName FromProjectLocationUuid(string projectId, string locationId, string uuidId) =>
            new ChallengeName(ResourceNameType.ProjectLocationUuid, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), uuidId: gax::GaxPreconditions.CheckNotNullOrEmpty(uuidId, nameof(uuidId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChallengeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/challenges/{uuid}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="uuidId">The <c>Uuid</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChallengeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/challenges/{uuid}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string uuidId) =>
            FormatProjectLocationUuid(projectId, locationId, uuidId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChallengeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/challenges/{uuid}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="uuidId">The <c>Uuid</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChallengeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/challenges/{uuid}</c>.
        /// </returns>
        public static string FormatProjectLocationUuid(string projectId, string locationId, string uuidId) =>
            s_projectLocationUuid.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(uuidId, nameof(uuidId)));

        /// <summary>Parses the given resource name string into a new <see cref="ChallengeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/challenges/{uuid}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="challengeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ChallengeName"/> if successful.</returns>
        public static ChallengeName Parse(string challengeName) => Parse(challengeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ChallengeName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/challenges/{uuid}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="challengeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ChallengeName"/> if successful.</returns>
        public static ChallengeName Parse(string challengeName, bool allowUnparsed) =>
            TryParse(challengeName, allowUnparsed, out ChallengeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChallengeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/challenges/{uuid}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="challengeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChallengeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string challengeName, out ChallengeName result) => TryParse(challengeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChallengeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/challenges/{uuid}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="challengeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChallengeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string challengeName, bool allowUnparsed, out ChallengeName result)
        {
            gax::GaxPreconditions.CheckNotNull(challengeName, nameof(challengeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationUuid.TryParseName(challengeName, out resourceName))
            {
                result = FromProjectLocationUuid(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(challengeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ChallengeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string uuidId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            UuidId = uuidId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ChallengeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/challenges/{uuid}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="uuidId">The <c>Uuid</c> ID. Must not be <c>null</c> or empty.</param>
        public ChallengeName(string projectId, string locationId, string uuidId) : this(ResourceNameType.ProjectLocationUuid, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), uuidId: gax::GaxPreconditions.CheckNotNullOrEmpty(uuidId, nameof(uuidId)))
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
        /// The <c>Uuid</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string UuidId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationUuid: return s_projectLocationUuid.Expand(ProjectId, LocationId, UuidId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ChallengeName);

        /// <inheritdoc/>
        public bool Equals(ChallengeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ChallengeName a, ChallengeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ChallengeName a, ChallengeName b) => !(a == b);
    }

    public partial class Challenge
    {
        /// <summary>
        /// <see cref="gccv::ChallengeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ChallengeName ChallengeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ChallengeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateChallengeRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class VerifyAttestationRequest
    {
        /// <summary>
        /// <see cref="ChallengeName"/>-typed view over the <see cref="Challenge"/> resource name property.
        /// </summary>
        public ChallengeName ChallengeAsChallengeName
        {
            get => string.IsNullOrEmpty(Challenge) ? null : ChallengeName.Parse(Challenge, allowUnparsed: true);
            set => Challenge = value?.ToString() ?? "";
        }
    }
}
