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
using gciv = Google.Cloud.Iam.V3Beta;
using sys = System;

namespace Google.Cloud.Iam.V3Beta
{
    /// <summary>Resource name for the <c>PrincipalAccessBoundaryPolicy</c> resource.</summary>
    public sealed partial class PrincipalAccessBoundaryPolicyName : gax::IResourceName, sys::IEquatable<PrincipalAccessBoundaryPolicyName>
    {
        /// <summary>The possible contents of <see cref="PrincipalAccessBoundaryPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy}</c>
            /// .
            /// </summary>
            OrganizationLocationPrincipalAccessBoundaryPolicy = 1,
        }

        private static gax::PathTemplate s_organizationLocationPrincipalAccessBoundaryPolicy = new gax::PathTemplate("organizations/{organization}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy}");

        /// <summary>
        /// Creates a <see cref="PrincipalAccessBoundaryPolicyName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PrincipalAccessBoundaryPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PrincipalAccessBoundaryPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PrincipalAccessBoundaryPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PrincipalAccessBoundaryPolicyName"/> with the pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="principalAccessBoundaryPolicyId">
        /// The <c>PrincipalAccessBoundaryPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="PrincipalAccessBoundaryPolicyName"/> constructed from the provided ids.
        /// </returns>
        public static PrincipalAccessBoundaryPolicyName FromOrganizationLocationPrincipalAccessBoundaryPolicy(string organizationId, string locationId, string principalAccessBoundaryPolicyId) =>
            new PrincipalAccessBoundaryPolicyName(ResourceNameType.OrganizationLocationPrincipalAccessBoundaryPolicy, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), principalAccessBoundaryPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(principalAccessBoundaryPolicyId, nameof(principalAccessBoundaryPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PrincipalAccessBoundaryPolicyName"/> with
        /// pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="principalAccessBoundaryPolicyId">
        /// The <c>PrincipalAccessBoundaryPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="PrincipalAccessBoundaryPolicyName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy}</c>
        /// .
        /// </returns>
        public static string Format(string organizationId, string locationId, string principalAccessBoundaryPolicyId) =>
            FormatOrganizationLocationPrincipalAccessBoundaryPolicy(organizationId, locationId, principalAccessBoundaryPolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PrincipalAccessBoundaryPolicyName"/> with
        /// pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="principalAccessBoundaryPolicyId">
        /// The <c>PrincipalAccessBoundaryPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="PrincipalAccessBoundaryPolicyName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationLocationPrincipalAccessBoundaryPolicy(string organizationId, string locationId, string principalAccessBoundaryPolicyId) =>
            s_organizationLocationPrincipalAccessBoundaryPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(principalAccessBoundaryPolicyId, nameof(principalAccessBoundaryPolicyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PrincipalAccessBoundaryPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="principalAccessBoundaryPolicyName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="PrincipalAccessBoundaryPolicyName"/> if successful.</returns>
        public static PrincipalAccessBoundaryPolicyName Parse(string principalAccessBoundaryPolicyName) =>
            Parse(principalAccessBoundaryPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PrincipalAccessBoundaryPolicyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="principalAccessBoundaryPolicyName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PrincipalAccessBoundaryPolicyName"/> if successful.</returns>
        public static PrincipalAccessBoundaryPolicyName Parse(string principalAccessBoundaryPolicyName, bool allowUnparsed) =>
            TryParse(principalAccessBoundaryPolicyName, allowUnparsed, out PrincipalAccessBoundaryPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PrincipalAccessBoundaryPolicyName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="principalAccessBoundaryPolicyName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PrincipalAccessBoundaryPolicyName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string principalAccessBoundaryPolicyName, out PrincipalAccessBoundaryPolicyName result) =>
            TryParse(principalAccessBoundaryPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PrincipalAccessBoundaryPolicyName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="principalAccessBoundaryPolicyName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PrincipalAccessBoundaryPolicyName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string principalAccessBoundaryPolicyName, bool allowUnparsed, out PrincipalAccessBoundaryPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(principalAccessBoundaryPolicyName, nameof(principalAccessBoundaryPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationPrincipalAccessBoundaryPolicy.TryParseName(principalAccessBoundaryPolicyName, out resourceName))
            {
                result = FromOrganizationLocationPrincipalAccessBoundaryPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(principalAccessBoundaryPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PrincipalAccessBoundaryPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string organizationId = null, string principalAccessBoundaryPolicyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OrganizationId = organizationId;
            PrincipalAccessBoundaryPolicyId = principalAccessBoundaryPolicyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PrincipalAccessBoundaryPolicyName"/> class from the component
        /// parts of pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/principalAccessBoundaryPolicies/{principal_access_boundary_policy}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="principalAccessBoundaryPolicyId">
        /// The <c>PrincipalAccessBoundaryPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public PrincipalAccessBoundaryPolicyName(string organizationId, string locationId, string principalAccessBoundaryPolicyId) : this(ResourceNameType.OrganizationLocationPrincipalAccessBoundaryPolicy, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), principalAccessBoundaryPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(principalAccessBoundaryPolicyId, nameof(principalAccessBoundaryPolicyId)))
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
        /// The <c>Organization</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>PrincipalAccessBoundaryPolicy</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string PrincipalAccessBoundaryPolicyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationLocationPrincipalAccessBoundaryPolicy: return s_organizationLocationPrincipalAccessBoundaryPolicy.Expand(OrganizationId, LocationId, PrincipalAccessBoundaryPolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PrincipalAccessBoundaryPolicyName);

        /// <inheritdoc/>
        public bool Equals(PrincipalAccessBoundaryPolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PrincipalAccessBoundaryPolicyName a, PrincipalAccessBoundaryPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PrincipalAccessBoundaryPolicyName a, PrincipalAccessBoundaryPolicyName b) => !(a == b);
    }

    public partial class PrincipalAccessBoundaryPolicy
    {
        /// <summary>
        /// <see cref="gciv::PrincipalAccessBoundaryPolicyName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gciv::PrincipalAccessBoundaryPolicyName PrincipalAccessBoundaryPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gciv::PrincipalAccessBoundaryPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
