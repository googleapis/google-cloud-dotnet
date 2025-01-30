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
using gcgv = Google.Cloud.GkeHub.V1Beta1;
using sys = System;

namespace Google.Cloud.GkeHub.V1Beta1
{
    /// <summary>Resource name for the <c>Membership</c> resource.</summary>
    public sealed partial class MembershipName : gax::IResourceName, sys::IEquatable<MembershipName>
    {
        /// <summary>The possible contents of <see cref="MembershipName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/memberships/{membership}</c>.
            /// </summary>
            ProjectLocationMembership = 1,
        }

        private static gax::PathTemplate s_projectLocationMembership = new gax::PathTemplate("projects/{project}/locations/{location}/memberships/{membership}");

        /// <summary>Creates a <see cref="MembershipName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MembershipName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MembershipName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MembershipName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MembershipName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MembershipName"/> constructed from the provided ids.</returns>
        public static MembershipName FromProjectLocationMembership(string projectId, string locationId, string membershipId) =>
            new MembershipName(ResourceNameType.ProjectLocationMembership, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), membershipId: gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MembershipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MembershipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string membershipId) =>
            FormatProjectLocationMembership(projectId, locationId, membershipId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MembershipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MembershipName"/> with pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}</c>.
        /// </returns>
        public static string FormatProjectLocationMembership(string projectId, string locationId, string membershipId) =>
            s_projectLocationMembership.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)));

        /// <summary>Parses the given resource name string into a new <see cref="MembershipName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/memberships/{membership}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="membershipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MembershipName"/> if successful.</returns>
        public static MembershipName Parse(string membershipName) => Parse(membershipName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MembershipName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/memberships/{membership}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="membershipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MembershipName"/> if successful.</returns>
        public static MembershipName Parse(string membershipName, bool allowUnparsed) =>
            TryParse(membershipName, allowUnparsed, out MembershipName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MembershipName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/memberships/{membership}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="membershipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MembershipName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string membershipName, out MembershipName result) =>
            TryParse(membershipName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MembershipName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/memberships/{membership}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="membershipName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MembershipName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string membershipName, bool allowUnparsed, out MembershipName result)
        {
            gax::GaxPreconditions.CheckNotNull(membershipName, nameof(membershipName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMembership.TryParseName(membershipName, out resourceName))
            {
                result = FromProjectLocationMembership(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(membershipName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MembershipName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string membershipId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MembershipId = membershipId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MembershipName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/memberships/{membership}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="membershipId">The <c>Membership</c> ID. Must not be <c>null</c> or empty.</param>
        public MembershipName(string projectId, string locationId, string membershipId) : this(ResourceNameType.ProjectLocationMembership, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), membershipId: gax::GaxPreconditions.CheckNotNullOrEmpty(membershipId, nameof(membershipId)))
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
        /// The <c>Membership</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MembershipId { get; }

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
                case ResourceNameType.ProjectLocationMembership: return s_projectLocationMembership.Expand(ProjectId, LocationId, MembershipId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MembershipName);

        /// <inheritdoc/>
        public bool Equals(MembershipName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MembershipName a, MembershipName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MembershipName a, MembershipName b) => !(a == b);
    }

    public partial class Membership
    {
        /// <summary>
        /// <see cref="gcgv::MembershipName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::MembershipName MembershipName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::MembershipName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMembershipsRequest
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

    public partial class GetMembershipRequest
    {
        /// <summary>
        /// <see cref="gcgv::MembershipName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::MembershipName MembershipName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::MembershipName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateMembershipRequest
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

    public partial class DeleteMembershipRequest
    {
        /// <summary>
        /// <see cref="gcgv::MembershipName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::MembershipName MembershipName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::MembershipName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UpdateMembershipRequest
    {
        /// <summary>
        /// <see cref="gcgv::MembershipName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::MembershipName MembershipName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::MembershipName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GenerateConnectManifestRequest
    {
        /// <summary>
        /// <see cref="gcgv::MembershipName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::MembershipName MembershipName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::MembershipName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ValidateExclusivityRequest
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

    public partial class GenerateExclusivityManifestRequest
    {
        /// <summary>
        /// <see cref="gcgv::MembershipName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::MembershipName MembershipName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::MembershipName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
