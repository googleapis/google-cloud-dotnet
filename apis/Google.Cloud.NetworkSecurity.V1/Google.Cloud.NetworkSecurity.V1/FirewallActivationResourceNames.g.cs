// Copyright 2026 Google LLC
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
using gcnv = Google.Cloud.NetworkSecurity.V1;
using sys = System;

namespace Google.Cloud.NetworkSecurity.V1
{
    /// <summary>Resource name for the <c>FirewallEndpoint</c> resource.</summary>
    public sealed partial class FirewallEndpointName : gax::IResourceName, sys::IEquatable<FirewallEndpointName>
    {
        /// <summary>The possible contents of <see cref="FirewallEndpointName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>.
            /// </summary>
            OrganizationLocationFirewallEndpoint = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>.
            /// </summary>
            ProjectLocationFirewallEndpoint = 2,
        }

        private static gax::PathTemplate s_organizationLocationFirewallEndpoint = new gax::PathTemplate("organizations/{organization}/locations/{location}/firewallEndpoints/{firewall_endpoint}");

        private static gax::PathTemplate s_projectLocationFirewallEndpoint = new gax::PathTemplate("projects/{project}/locations/{location}/firewallEndpoints/{firewall_endpoint}");

        /// <summary>Creates a <see cref="FirewallEndpointName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FirewallEndpointName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FirewallEndpointName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FirewallEndpointName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FirewallEndpointName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="firewallEndpointId">The <c>FirewallEndpoint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FirewallEndpointName"/> constructed from the provided ids.</returns>
        public static FirewallEndpointName FromOrganizationLocationFirewallEndpoint(string organizationId, string locationId, string firewallEndpointId) =>
            new FirewallEndpointName(ResourceNameType.OrganizationLocationFirewallEndpoint, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), firewallEndpointId: gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointId, nameof(firewallEndpointId)));

        /// <summary>
        /// Creates a <see cref="FirewallEndpointName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="firewallEndpointId">The <c>FirewallEndpoint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FirewallEndpointName"/> constructed from the provided ids.</returns>
        public static FirewallEndpointName FromProjectLocationFirewallEndpoint(string projectId, string locationId, string firewallEndpointId) =>
            new FirewallEndpointName(ResourceNameType.ProjectLocationFirewallEndpoint, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), firewallEndpointId: gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointId, nameof(firewallEndpointId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FirewallEndpointName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="firewallEndpointId">The <c>FirewallEndpoint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FirewallEndpointName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId, string firewallEndpointId) =>
            FormatOrganizationLocationFirewallEndpoint(organizationId, locationId, firewallEndpointId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FirewallEndpointName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="firewallEndpointId">The <c>FirewallEndpoint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FirewallEndpointName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>.
        /// </returns>
        public static string FormatOrganizationLocationFirewallEndpoint(string organizationId, string locationId, string firewallEndpointId) =>
            s_organizationLocationFirewallEndpoint.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointId, nameof(firewallEndpointId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FirewallEndpointName"/> with pattern
        /// <c>projects/{project}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="firewallEndpointId">The <c>FirewallEndpoint</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FirewallEndpointName"/> with pattern
        /// <c>projects/{project}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>.
        /// </returns>
        public static string FormatProjectLocationFirewallEndpoint(string projectId, string locationId, string firewallEndpointId) =>
            s_projectLocationFirewallEndpoint.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointId, nameof(firewallEndpointId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FirewallEndpointName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="firewallEndpointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FirewallEndpointName"/> if successful.</returns>
        public static FirewallEndpointName Parse(string firewallEndpointName) => Parse(firewallEndpointName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FirewallEndpointName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="firewallEndpointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FirewallEndpointName"/> if successful.</returns>
        public static FirewallEndpointName Parse(string firewallEndpointName, bool allowUnparsed) =>
            TryParse(firewallEndpointName, allowUnparsed, out FirewallEndpointName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FirewallEndpointName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="firewallEndpointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FirewallEndpointName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string firewallEndpointName, out FirewallEndpointName result) =>
            TryParse(firewallEndpointName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FirewallEndpointName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="firewallEndpointName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FirewallEndpointName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string firewallEndpointName, bool allowUnparsed, out FirewallEndpointName result)
        {
            gax::GaxPreconditions.CheckNotNull(firewallEndpointName, nameof(firewallEndpointName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationFirewallEndpoint.TryParseName(firewallEndpointName, out resourceName))
            {
                result = FromOrganizationLocationFirewallEndpoint(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationFirewallEndpoint.TryParseName(firewallEndpointName, out resourceName))
            {
                result = FromProjectLocationFirewallEndpoint(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(firewallEndpointName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FirewallEndpointName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string firewallEndpointId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FirewallEndpointId = firewallEndpointId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FirewallEndpointName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/locations/{location}/firewallEndpoints/{firewall_endpoint}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="firewallEndpointId">The <c>FirewallEndpoint</c> ID. Must not be <c>null</c> or empty.</param>
        public FirewallEndpointName(string organizationId, string locationId, string firewallEndpointId) : this(ResourceNameType.OrganizationLocationFirewallEndpoint, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), firewallEndpointId: gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointId, nameof(firewallEndpointId)))
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
        /// The <c>FirewallEndpoint</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string FirewallEndpointId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.OrganizationLocationFirewallEndpoint: return s_organizationLocationFirewallEndpoint.Expand(OrganizationId, LocationId, FirewallEndpointId);
                case ResourceNameType.ProjectLocationFirewallEndpoint: return s_projectLocationFirewallEndpoint.Expand(ProjectId, LocationId, FirewallEndpointId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FirewallEndpointName);

        /// <inheritdoc/>
        public bool Equals(FirewallEndpointName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FirewallEndpointName a, FirewallEndpointName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FirewallEndpointName a, FirewallEndpointName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FirewallEndpointAssociation</c> resource.</summary>
    public sealed partial class FirewallEndpointAssociationName : gax::IResourceName, sys::IEquatable<FirewallEndpointAssociationName>
    {
        /// <summary>The possible contents of <see cref="FirewallEndpointAssociationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/firewallEndpointAssociations/{firewall_endpoint_association}</c>
            /// .
            /// </summary>
            ProjectLocationFirewallEndpointAssociation = 1,
        }

        private static gax::PathTemplate s_projectLocationFirewallEndpointAssociation = new gax::PathTemplate("projects/{project}/locations/{location}/firewallEndpointAssociations/{firewall_endpoint_association}");

        /// <summary>
        /// Creates a <see cref="FirewallEndpointAssociationName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FirewallEndpointAssociationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FirewallEndpointAssociationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FirewallEndpointAssociationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FirewallEndpointAssociationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/firewallEndpointAssociations/{firewall_endpoint_association}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="firewallEndpointAssociationId">
        /// The <c>FirewallEndpointAssociation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="FirewallEndpointAssociationName"/> constructed from the provided ids.
        /// </returns>
        public static FirewallEndpointAssociationName FromProjectLocationFirewallEndpointAssociation(string projectId, string locationId, string firewallEndpointAssociationId) =>
            new FirewallEndpointAssociationName(ResourceNameType.ProjectLocationFirewallEndpointAssociation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), firewallEndpointAssociationId: gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointAssociationId, nameof(firewallEndpointAssociationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FirewallEndpointAssociationName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/firewallEndpointAssociations/{firewall_endpoint_association}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="firewallEndpointAssociationId">
        /// The <c>FirewallEndpointAssociation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FirewallEndpointAssociationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/firewallEndpointAssociations/{firewall_endpoint_association}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string firewallEndpointAssociationId) =>
            FormatProjectLocationFirewallEndpointAssociation(projectId, locationId, firewallEndpointAssociationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FirewallEndpointAssociationName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/firewallEndpointAssociations/{firewall_endpoint_association}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="firewallEndpointAssociationId">
        /// The <c>FirewallEndpointAssociation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FirewallEndpointAssociationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/firewallEndpointAssociations/{firewall_endpoint_association}</c>.
        /// </returns>
        public static string FormatProjectLocationFirewallEndpointAssociation(string projectId, string locationId, string firewallEndpointAssociationId) =>
            s_projectLocationFirewallEndpointAssociation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointAssociationId, nameof(firewallEndpointAssociationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FirewallEndpointAssociationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/firewallEndpointAssociations/{firewall_endpoint_association}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="firewallEndpointAssociationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="FirewallEndpointAssociationName"/> if successful.</returns>
        public static FirewallEndpointAssociationName Parse(string firewallEndpointAssociationName) =>
            Parse(firewallEndpointAssociationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FirewallEndpointAssociationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/firewallEndpointAssociations/{firewall_endpoint_association}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="firewallEndpointAssociationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FirewallEndpointAssociationName"/> if successful.</returns>
        public static FirewallEndpointAssociationName Parse(string firewallEndpointAssociationName, bool allowUnparsed) =>
            TryParse(firewallEndpointAssociationName, allowUnparsed, out FirewallEndpointAssociationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FirewallEndpointAssociationName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/firewallEndpointAssociations/{firewall_endpoint_association}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="firewallEndpointAssociationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FirewallEndpointAssociationName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string firewallEndpointAssociationName, out FirewallEndpointAssociationName result) =>
            TryParse(firewallEndpointAssociationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FirewallEndpointAssociationName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/firewallEndpointAssociations/{firewall_endpoint_association}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="firewallEndpointAssociationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FirewallEndpointAssociationName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string firewallEndpointAssociationName, bool allowUnparsed, out FirewallEndpointAssociationName result)
        {
            gax::GaxPreconditions.CheckNotNull(firewallEndpointAssociationName, nameof(firewallEndpointAssociationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationFirewallEndpointAssociation.TryParseName(firewallEndpointAssociationName, out resourceName))
            {
                result = FromProjectLocationFirewallEndpointAssociation(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(firewallEndpointAssociationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FirewallEndpointAssociationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string firewallEndpointAssociationId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FirewallEndpointAssociationId = firewallEndpointAssociationId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FirewallEndpointAssociationName"/> class from the component parts
        /// of pattern
        /// <c>projects/{project}/locations/{location}/firewallEndpointAssociations/{firewall_endpoint_association}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="firewallEndpointAssociationId">
        /// The <c>FirewallEndpointAssociation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public FirewallEndpointAssociationName(string projectId, string locationId, string firewallEndpointAssociationId) : this(ResourceNameType.ProjectLocationFirewallEndpointAssociation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), firewallEndpointAssociationId: gax::GaxPreconditions.CheckNotNullOrEmpty(firewallEndpointAssociationId, nameof(firewallEndpointAssociationId)))
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
        /// The <c>FirewallEndpointAssociation</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string FirewallEndpointAssociationId { get; }

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
                case ResourceNameType.ProjectLocationFirewallEndpointAssociation: return s_projectLocationFirewallEndpointAssociation.Expand(ProjectId, LocationId, FirewallEndpointAssociationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FirewallEndpointAssociationName);

        /// <inheritdoc/>
        public bool Equals(FirewallEndpointAssociationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FirewallEndpointAssociationName a, FirewallEndpointAssociationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FirewallEndpointAssociationName a, FirewallEndpointAssociationName b) => !(a == b);
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

    public partial class FirewallEndpoint
    {
        /// <summary>
        /// <see cref="gcnv::FirewallEndpointName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::FirewallEndpointName FirewallEndpointName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::FirewallEndpointName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class AssociationReference
            {
                /// <summary>
                /// <see cref="gcnv::FirewallEndpointAssociationName"/>-typed view over the <see cref="Name"/> resource
                /// name property.
                /// </summary>
                public gcnv::FirewallEndpointAssociationName FirewallEndpointAssociationName
                {
                    get => string.IsNullOrEmpty(Name) ? null : gcnv::FirewallEndpointAssociationName.Parse(Name, allowUnparsed: true);
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
    }

    public partial class ListFirewallEndpointsRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetFirewallEndpointRequest
    {
        /// <summary>
        /// <see cref="gcnv::FirewallEndpointName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::FirewallEndpointName FirewallEndpointName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::FirewallEndpointName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateFirewallEndpointRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteFirewallEndpointRequest
    {
        /// <summary>
        /// <see cref="gcnv::FirewallEndpointName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::FirewallEndpointName FirewallEndpointName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::FirewallEndpointName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FirewallEndpointAssociation
    {
        /// <summary>
        /// <see cref="gcnv::FirewallEndpointAssociationName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::FirewallEndpointAssociationName FirewallEndpointAssociationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::FirewallEndpointAssociationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="TlsInspectionPolicyName"/>-typed view over the <see cref="TlsInspectionPolicy"/> resource name
        /// property.
        /// </summary>
        public TlsInspectionPolicyName TlsInspectionPolicyAsTlsInspectionPolicyName
        {
            get => string.IsNullOrEmpty(TlsInspectionPolicy) ? null : TlsInspectionPolicyName.Parse(TlsInspectionPolicy, allowUnparsed: true);
            set => TlsInspectionPolicy = value?.ToString() ?? "";
        }
    }

    public partial class ListFirewallEndpointAssociationsRequest
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

    public partial class GetFirewallEndpointAssociationRequest
    {
        /// <summary>
        /// <see cref="gcnv::FirewallEndpointAssociationName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::FirewallEndpointAssociationName FirewallEndpointAssociationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::FirewallEndpointAssociationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateFirewallEndpointAssociationRequest
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

    public partial class DeleteFirewallEndpointAssociationRequest
    {
        /// <summary>
        /// <see cref="gcnv::FirewallEndpointAssociationName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::FirewallEndpointAssociationName FirewallEndpointAssociationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::FirewallEndpointAssociationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
