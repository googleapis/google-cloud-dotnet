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
using gcov = Google.Cloud.OrgPolicy.V2;
using gcpv = Google.Cloud.PolicySimulator.V1;
using sys = System;

namespace Google.Cloud.PolicySimulator.V1
{
    /// <summary>Resource name for the <c>OrgPolicyViolationsPreview</c> resource.</summary>
    public sealed partial class OrgPolicyViolationsPreviewName : gax::IResourceName, sys::IEquatable<OrgPolicyViolationsPreviewName>
    {
        /// <summary>The possible contents of <see cref="OrgPolicyViolationsPreviewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}</c>
            /// .
            /// </summary>
            OrganizationLocationOrgPolicyViolationsPreview = 1,
        }

        private static gax::PathTemplate s_organizationLocationOrgPolicyViolationsPreview = new gax::PathTemplate("organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}");

        /// <summary>
        /// Creates a <see cref="OrgPolicyViolationsPreviewName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OrgPolicyViolationsPreviewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OrgPolicyViolationsPreviewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OrgPolicyViolationsPreviewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OrgPolicyViolationsPreviewName"/> with the pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orgPolicyViolationsPreviewId">
        /// The <c>OrgPolicyViolationsPreview</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="OrgPolicyViolationsPreviewName"/> constructed from the provided ids.
        /// </returns>
        public static OrgPolicyViolationsPreviewName FromOrganizationLocationOrgPolicyViolationsPreview(string organizationId, string locationId, string orgPolicyViolationsPreviewId) =>
            new OrgPolicyViolationsPreviewName(ResourceNameType.OrganizationLocationOrgPolicyViolationsPreview, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orgPolicyViolationsPreviewId: gax::GaxPreconditions.CheckNotNullOrEmpty(orgPolicyViolationsPreviewId, nameof(orgPolicyViolationsPreviewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrgPolicyViolationsPreviewName"/> with
        /// pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orgPolicyViolationsPreviewId">
        /// The <c>OrgPolicyViolationsPreview</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="OrgPolicyViolationsPreviewName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}</c>
        /// .
        /// </returns>
        public static string Format(string organizationId, string locationId, string orgPolicyViolationsPreviewId) =>
            FormatOrganizationLocationOrgPolicyViolationsPreview(organizationId, locationId, orgPolicyViolationsPreviewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrgPolicyViolationsPreviewName"/> with
        /// pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orgPolicyViolationsPreviewId">
        /// The <c>OrgPolicyViolationsPreview</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="OrgPolicyViolationsPreviewName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationLocationOrgPolicyViolationsPreview(string organizationId, string locationId, string orgPolicyViolationsPreviewId) =>
            s_organizationLocationOrgPolicyViolationsPreview.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(orgPolicyViolationsPreviewId, nameof(orgPolicyViolationsPreviewId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrgPolicyViolationsPreviewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="orgPolicyViolationsPreviewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="OrgPolicyViolationsPreviewName"/> if successful.</returns>
        public static OrgPolicyViolationsPreviewName Parse(string orgPolicyViolationsPreviewName) =>
            Parse(orgPolicyViolationsPreviewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrgPolicyViolationsPreviewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="orgPolicyViolationsPreviewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OrgPolicyViolationsPreviewName"/> if successful.</returns>
        public static OrgPolicyViolationsPreviewName Parse(string orgPolicyViolationsPreviewName, bool allowUnparsed) =>
            TryParse(orgPolicyViolationsPreviewName, allowUnparsed, out OrgPolicyViolationsPreviewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrgPolicyViolationsPreviewName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="orgPolicyViolationsPreviewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrgPolicyViolationsPreviewName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string orgPolicyViolationsPreviewName, out OrgPolicyViolationsPreviewName result) =>
            TryParse(orgPolicyViolationsPreviewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrgPolicyViolationsPreviewName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="orgPolicyViolationsPreviewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrgPolicyViolationsPreviewName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string orgPolicyViolationsPreviewName, bool allowUnparsed, out OrgPolicyViolationsPreviewName result)
        {
            gax::GaxPreconditions.CheckNotNull(orgPolicyViolationsPreviewName, nameof(orgPolicyViolationsPreviewName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationOrgPolicyViolationsPreview.TryParseName(orgPolicyViolationsPreviewName, out resourceName))
            {
                result = FromOrganizationLocationOrgPolicyViolationsPreview(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(orgPolicyViolationsPreviewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OrgPolicyViolationsPreviewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string orgPolicyViolationsPreviewId = null, string organizationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OrgPolicyViolationsPreviewId = orgPolicyViolationsPreviewId;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OrgPolicyViolationsPreviewName"/> class from the component parts
        /// of pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orgPolicyViolationsPreviewId">
        /// The <c>OrgPolicyViolationsPreview</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public OrgPolicyViolationsPreviewName(string organizationId, string locationId, string orgPolicyViolationsPreviewId) : this(ResourceNameType.OrganizationLocationOrgPolicyViolationsPreview, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orgPolicyViolationsPreviewId: gax::GaxPreconditions.CheckNotNullOrEmpty(orgPolicyViolationsPreviewId, nameof(orgPolicyViolationsPreviewId)))
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
        /// The <c>OrgPolicyViolationsPreview</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string OrgPolicyViolationsPreviewId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationLocationOrgPolicyViolationsPreview: return s_organizationLocationOrgPolicyViolationsPreview.Expand(OrganizationId, LocationId, OrgPolicyViolationsPreviewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OrgPolicyViolationsPreviewName);

        /// <inheritdoc/>
        public bool Equals(OrgPolicyViolationsPreviewName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OrgPolicyViolationsPreviewName a, OrgPolicyViolationsPreviewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OrgPolicyViolationsPreviewName a, OrgPolicyViolationsPreviewName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>OrgPolicyViolation</c> resource.</summary>
    public sealed partial class OrgPolicyViolationName : gax::IResourceName, sys::IEquatable<OrgPolicyViolationName>
    {
        /// <summary>The possible contents of <see cref="OrgPolicyViolationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}/orgPolicyViolations/{org_policy_violation}</c>
            /// .
            /// </summary>
            OrganizationLocationOrgPolicyViolationsPreviewOrgPolicyViolation = 1,
        }

        private static gax::PathTemplate s_organizationLocationOrgPolicyViolationsPreviewOrgPolicyViolation = new gax::PathTemplate("organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}/orgPolicyViolations/{org_policy_violation}");

        /// <summary>Creates a <see cref="OrgPolicyViolationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OrgPolicyViolationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OrgPolicyViolationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OrgPolicyViolationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OrgPolicyViolationName"/> with the pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}/orgPolicyViolations/{org_policy_violation}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orgPolicyViolationsPreviewId">
        /// The <c>OrgPolicyViolationsPreview</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="orgPolicyViolationId">
        /// The <c>OrgPolicyViolation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="OrgPolicyViolationName"/> constructed from the provided ids.</returns>
        public static OrgPolicyViolationName FromOrganizationLocationOrgPolicyViolationsPreviewOrgPolicyViolation(string organizationId, string locationId, string orgPolicyViolationsPreviewId, string orgPolicyViolationId) =>
            new OrgPolicyViolationName(ResourceNameType.OrganizationLocationOrgPolicyViolationsPreviewOrgPolicyViolation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orgPolicyViolationsPreviewId: gax::GaxPreconditions.CheckNotNullOrEmpty(orgPolicyViolationsPreviewId, nameof(orgPolicyViolationsPreviewId)), orgPolicyViolationId: gax::GaxPreconditions.CheckNotNullOrEmpty(orgPolicyViolationId, nameof(orgPolicyViolationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrgPolicyViolationName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}/orgPolicyViolations/{org_policy_violation}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orgPolicyViolationsPreviewId">
        /// The <c>OrgPolicyViolationsPreview</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="orgPolicyViolationId">
        /// The <c>OrgPolicyViolation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="OrgPolicyViolationName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}/orgPolicyViolations/{org_policy_violation}</c>
        /// .
        /// </returns>
        public static string Format(string organizationId, string locationId, string orgPolicyViolationsPreviewId, string orgPolicyViolationId) =>
            FormatOrganizationLocationOrgPolicyViolationsPreviewOrgPolicyViolation(organizationId, locationId, orgPolicyViolationsPreviewId, orgPolicyViolationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrgPolicyViolationName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}/orgPolicyViolations/{org_policy_violation}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orgPolicyViolationsPreviewId">
        /// The <c>OrgPolicyViolationsPreview</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="orgPolicyViolationId">
        /// The <c>OrgPolicyViolation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="OrgPolicyViolationName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}/orgPolicyViolations/{org_policy_violation}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationLocationOrgPolicyViolationsPreviewOrgPolicyViolation(string organizationId, string locationId, string orgPolicyViolationsPreviewId, string orgPolicyViolationId) =>
            s_organizationLocationOrgPolicyViolationsPreviewOrgPolicyViolation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(orgPolicyViolationsPreviewId, nameof(orgPolicyViolationsPreviewId)), gax::GaxPreconditions.CheckNotNullOrEmpty(orgPolicyViolationId, nameof(orgPolicyViolationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrgPolicyViolationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}/orgPolicyViolations/{org_policy_violation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="orgPolicyViolationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrgPolicyViolationName"/> if successful.</returns>
        public static OrgPolicyViolationName Parse(string orgPolicyViolationName) => Parse(orgPolicyViolationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrgPolicyViolationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}/orgPolicyViolations/{org_policy_violation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="orgPolicyViolationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OrgPolicyViolationName"/> if successful.</returns>
        public static OrgPolicyViolationName Parse(string orgPolicyViolationName, bool allowUnparsed) =>
            TryParse(orgPolicyViolationName, allowUnparsed, out OrgPolicyViolationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrgPolicyViolationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}/orgPolicyViolations/{org_policy_violation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="orgPolicyViolationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrgPolicyViolationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string orgPolicyViolationName, out OrgPolicyViolationName result) =>
            TryParse(orgPolicyViolationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrgPolicyViolationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}/orgPolicyViolations/{org_policy_violation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="orgPolicyViolationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrgPolicyViolationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string orgPolicyViolationName, bool allowUnparsed, out OrgPolicyViolationName result)
        {
            gax::GaxPreconditions.CheckNotNull(orgPolicyViolationName, nameof(orgPolicyViolationName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationOrgPolicyViolationsPreviewOrgPolicyViolation.TryParseName(orgPolicyViolationName, out resourceName))
            {
                result = FromOrganizationLocationOrgPolicyViolationsPreviewOrgPolicyViolation(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(orgPolicyViolationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OrgPolicyViolationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string orgPolicyViolationId = null, string orgPolicyViolationsPreviewId = null, string organizationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OrgPolicyViolationId = orgPolicyViolationId;
            OrgPolicyViolationsPreviewId = orgPolicyViolationsPreviewId;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OrgPolicyViolationName"/> class from the component parts of
        /// pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/orgPolicyViolationsPreviews/{org_policy_violations_preview}/orgPolicyViolations/{org_policy_violation}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="orgPolicyViolationsPreviewId">
        /// The <c>OrgPolicyViolationsPreview</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="orgPolicyViolationId">
        /// The <c>OrgPolicyViolation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public OrgPolicyViolationName(string organizationId, string locationId, string orgPolicyViolationsPreviewId, string orgPolicyViolationId) : this(ResourceNameType.OrganizationLocationOrgPolicyViolationsPreviewOrgPolicyViolation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), orgPolicyViolationsPreviewId: gax::GaxPreconditions.CheckNotNullOrEmpty(orgPolicyViolationsPreviewId, nameof(orgPolicyViolationsPreviewId)), orgPolicyViolationId: gax::GaxPreconditions.CheckNotNullOrEmpty(orgPolicyViolationId, nameof(orgPolicyViolationId)))
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
        /// The <c>OrgPolicyViolation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string OrgPolicyViolationId { get; }

        /// <summary>
        /// The <c>OrgPolicyViolationsPreview</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string OrgPolicyViolationsPreviewId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationLocationOrgPolicyViolationsPreviewOrgPolicyViolation: return s_organizationLocationOrgPolicyViolationsPreviewOrgPolicyViolation.Expand(OrganizationId, LocationId, OrgPolicyViolationsPreviewId, OrgPolicyViolationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OrgPolicyViolationName);

        /// <inheritdoc/>
        public bool Equals(OrgPolicyViolationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OrgPolicyViolationName a, OrgPolicyViolationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OrgPolicyViolationName a, OrgPolicyViolationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>OrganizationLocation</c> resource.</summary>
    public sealed partial class OrganizationLocationName : gax::IResourceName, sys::IEquatable<OrganizationLocationName>
    {
        /// <summary>The possible contents of <see cref="OrganizationLocationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/locations/{location}</c>.
            /// </summary>
            OrganizationLocation = 1,
        }

        private static gax::PathTemplate s_organizationLocation = new gax::PathTemplate("organizations/{organization}/locations/{location}");

        /// <summary>Creates a <see cref="OrganizationLocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OrganizationLocationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OrganizationLocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OrganizationLocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OrganizationLocationName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="OrganizationLocationName"/> constructed from the provided ids.
        /// </returns>
        public static OrganizationLocationName FromOrganizationLocation(string organizationId, string locationId) =>
            new OrganizationLocationName(ResourceNameType.OrganizationLocation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId) =>
            FormatOrganizationLocation(organizationId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </returns>
        public static string FormatOrganizationLocation(string organizationId, string locationId) =>
            s_organizationLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrganizationLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationLocationName"/> if successful.</returns>
        public static OrganizationLocationName Parse(string organizationLocationName) =>
            Parse(organizationLocationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrganizationLocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OrganizationLocationName"/> if successful.</returns>
        public static OrganizationLocationName Parse(string organizationLocationName, bool allowUnparsed) =>
            TryParse(organizationLocationName, allowUnparsed, out OrganizationLocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrganizationLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationLocationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationLocationName, out OrganizationLocationName result) =>
            TryParse(organizationLocationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrganizationLocationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationLocationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationLocationName, bool allowUnparsed, out OrganizationLocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationLocationName, nameof(organizationLocationName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocation.TryParseName(organizationLocationName, out resourceName))
            {
                result = FromOrganizationLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(organizationLocationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OrganizationLocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string organizationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OrganizationLocationName"/> class from the component parts of
        /// pattern <c>organizations/{organization}/locations/{location}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public OrganizationLocationName(string organizationId, string locationId) : this(ResourceNameType.OrganizationLocation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationLocation: return s_organizationLocation.Expand(OrganizationId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OrganizationLocationName);

        /// <inheritdoc/>
        public bool Equals(OrganizationLocationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OrganizationLocationName a, OrganizationLocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OrganizationLocationName a, OrganizationLocationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FolderLocation</c> resource.</summary>
    public sealed partial class FolderLocationName : gax::IResourceName, sys::IEquatable<FolderLocationName>
    {
        /// <summary>The possible contents of <see cref="FolderLocationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>folders/{folder}/locations/{location}</c>.</summary>
            FolderLocation = 1,
        }

        private static gax::PathTemplate s_folderLocation = new gax::PathTemplate("folders/{folder}/locations/{location}");

        /// <summary>Creates a <see cref="FolderLocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FolderLocationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FolderLocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FolderLocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FolderLocationName"/> with the pattern <c>folders/{folder}/locations/{location}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FolderLocationName"/> constructed from the provided ids.</returns>
        public static FolderLocationName FromFolderLocation(string folderId, string locationId) =>
            new FolderLocationName(ResourceNameType.FolderLocation, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </returns>
        public static string Format(string folderId, string locationId) => FormatFolderLocation(folderId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </returns>
        public static string FormatFolderLocation(string folderId, string locationId) =>
            s_folderLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FolderLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FolderLocationName"/> if successful.</returns>
        public static FolderLocationName Parse(string folderLocationName) => Parse(folderLocationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FolderLocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FolderLocationName"/> if successful.</returns>
        public static FolderLocationName Parse(string folderLocationName, bool allowUnparsed) =>
            TryParse(folderLocationName, allowUnparsed, out FolderLocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FolderLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FolderLocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string folderLocationName, out FolderLocationName result) =>
            TryParse(folderLocationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FolderLocationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FolderLocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string folderLocationName, bool allowUnparsed, out FolderLocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(folderLocationName, nameof(folderLocationName));
            gax::TemplatedResourceName resourceName;
            if (s_folderLocation.TryParseName(folderLocationName, out resourceName))
            {
                result = FromFolderLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(folderLocationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FolderLocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FolderLocationName"/> class from the component parts of pattern
        /// <c>folders/{folder}/locations/{location}</c>
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public FolderLocationName(string folderId, string locationId) : this(ResourceNameType.FolderLocation, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
        /// The <c>Folder</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.FolderLocation: return s_folderLocation.Expand(FolderId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FolderLocationName);

        /// <inheritdoc/>
        public bool Equals(FolderLocationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FolderLocationName a, FolderLocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FolderLocationName a, FolderLocationName b) => !(a == b);
    }

    public partial class OrgPolicyViolationsPreview
    {
        /// <summary>
        /// <see cref="gcpv::OrgPolicyViolationsPreviewName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcpv::OrgPolicyViolationsPreviewName OrgPolicyViolationsPreviewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::OrgPolicyViolationsPreviewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcov::CustomConstraintName"/>-typed view over the <see cref="CustomConstraints"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<gcov::CustomConstraintName> CustomConstraintsAsCustomConstraintNames
        {
            get => new gax::ResourceNameList<gcov::CustomConstraintName>(CustomConstraints, s => string.IsNullOrEmpty(s) ? null : gcov::CustomConstraintName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class OrgPolicyViolation
    {
        /// <summary>
        /// <see cref="gcpv::OrgPolicyViolationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::OrgPolicyViolationName OrgPolicyViolationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::OrgPolicyViolationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListOrgPolicyViolationsPreviewsRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetOrgPolicyViolationsPreviewRequest
    {
        /// <summary>
        /// <see cref="gcpv::OrgPolicyViolationsPreviewName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcpv::OrgPolicyViolationsPreviewName OrgPolicyViolationsPreviewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::OrgPolicyViolationsPreviewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateOrgPolicyViolationsPreviewRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListOrgPolicyViolationsRequest
    {
        /// <summary>
        /// <see cref="OrgPolicyViolationsPreviewName"/>-typed view over the <see cref="Parent"/> resource name
        /// property.
        /// </summary>
        public OrgPolicyViolationsPreviewName ParentAsOrgPolicyViolationsPreviewName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrgPolicyViolationsPreviewName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
