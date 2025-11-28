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
using gcnv = Google.Cloud.NetworkServices.V1;
using sys = System;

namespace Google.Cloud.NetworkServices.V1
{
    /// <summary>Resource name for the <c>Gateway</c> resource.</summary>
    public sealed partial class GatewayName : gax::IResourceName, sys::IEquatable<GatewayName>
    {
        /// <summary>The possible contents of <see cref="GatewayName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/gateways/{gateway}</c>.
            /// </summary>
            ProjectLocationGateway = 1,
        }

        private static gax::PathTemplate s_projectLocationGateway = new gax::PathTemplate("projects/{project}/locations/{location}/gateways/{gateway}");

        /// <summary>Creates a <see cref="GatewayName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GatewayName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GatewayName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GatewayName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GatewayName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewayId">The <c>Gateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GatewayName"/> constructed from the provided ids.</returns>
        public static GatewayName FromProjectLocationGateway(string projectId, string locationId, string gatewayId) =>
            new GatewayName(ResourceNameType.ProjectLocationGateway, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gatewayId: gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewayId">The <c>Gateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string gatewayId) =>
            FormatProjectLocationGateway(projectId, locationId, gatewayId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewayId">The <c>Gateway</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GatewayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}</c>.
        /// </returns>
        public static string FormatProjectLocationGateway(string projectId, string locationId, string gatewayId) =>
            s_projectLocationGateway.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)));

        /// <summary>Parses the given resource name string into a new <see cref="GatewayName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/gateways/{gateway}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="gatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GatewayName"/> if successful.</returns>
        public static GatewayName Parse(string gatewayName) => Parse(gatewayName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GatewayName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/gateways/{gateway}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GatewayName"/> if successful.</returns>
        public static GatewayName Parse(string gatewayName, bool allowUnparsed) =>
            TryParse(gatewayName, allowUnparsed, out GatewayName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GatewayName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/gateways/{gateway}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="gatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GatewayName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gatewayName, out GatewayName result) => TryParse(gatewayName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GatewayName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/gateways/{gateway}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gatewayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GatewayName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gatewayName, bool allowUnparsed, out GatewayName result)
        {
            gax::GaxPreconditions.CheckNotNull(gatewayName, nameof(gatewayName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGateway.TryParseName(gatewayName, out resourceName))
            {
                result = FromProjectLocationGateway(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(gatewayName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GatewayName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string gatewayId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GatewayId = gatewayId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GatewayName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/gateways/{gateway}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewayId">The <c>Gateway</c> ID. Must not be <c>null</c> or empty.</param>
        public GatewayName(string projectId, string locationId, string gatewayId) : this(ResourceNameType.ProjectLocationGateway, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gatewayId: gax::GaxPreconditions.CheckNotNullOrEmpty(gatewayId, nameof(gatewayId)))
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
        /// The <c>Gateway</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string GatewayId { get; }

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
                case ResourceNameType.ProjectLocationGateway: return s_projectLocationGateway.Expand(ProjectId, LocationId, GatewayId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GatewayName);

        /// <inheritdoc/>
        public bool Equals(GatewayName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GatewayName a, GatewayName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GatewayName a, GatewayName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>GatewaySecurityPolicy</c> resource.</summary>
    public sealed partial class GatewaySecurityPolicyName : gax::IResourceName, sys::IEquatable<GatewaySecurityPolicyName>
    {
        /// <summary>The possible contents of <see cref="GatewaySecurityPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}</c>.
            /// </summary>
            ProjectLocationGatewaySecurityPolicy = 1,
        }

        private static gax::PathTemplate s_projectLocationGatewaySecurityPolicy = new gax::PathTemplate("projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}");

        /// <summary>Creates a <see cref="GatewaySecurityPolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GatewaySecurityPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GatewaySecurityPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GatewaySecurityPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GatewaySecurityPolicyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewaySecurityPolicyId">
        /// The <c>GatewaySecurityPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="GatewaySecurityPolicyName"/> constructed from the provided ids.
        /// </returns>
        public static GatewaySecurityPolicyName FromProjectLocationGatewaySecurityPolicy(string projectId, string locationId, string gatewaySecurityPolicyId) =>
            new GatewaySecurityPolicyName(ResourceNameType.ProjectLocationGatewaySecurityPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gatewaySecurityPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(gatewaySecurityPolicyId, nameof(gatewaySecurityPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GatewaySecurityPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewaySecurityPolicyId">
        /// The <c>GatewaySecurityPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="GatewaySecurityPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string gatewaySecurityPolicyId) =>
            FormatProjectLocationGatewaySecurityPolicy(projectId, locationId, gatewaySecurityPolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GatewaySecurityPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewaySecurityPolicyId">
        /// The <c>GatewaySecurityPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="GatewaySecurityPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}</c>.
        /// </returns>
        public static string FormatProjectLocationGatewaySecurityPolicy(string projectId, string locationId, string gatewaySecurityPolicyId) =>
            s_projectLocationGatewaySecurityPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(gatewaySecurityPolicyId, nameof(gatewaySecurityPolicyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GatewaySecurityPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="gatewaySecurityPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GatewaySecurityPolicyName"/> if successful.</returns>
        public static GatewaySecurityPolicyName Parse(string gatewaySecurityPolicyName) =>
            Parse(gatewaySecurityPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GatewaySecurityPolicyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gatewaySecurityPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GatewaySecurityPolicyName"/> if successful.</returns>
        public static GatewaySecurityPolicyName Parse(string gatewaySecurityPolicyName, bool allowUnparsed) =>
            TryParse(gatewaySecurityPolicyName, allowUnparsed, out GatewaySecurityPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GatewaySecurityPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="gatewaySecurityPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GatewaySecurityPolicyName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gatewaySecurityPolicyName, out GatewaySecurityPolicyName result) =>
            TryParse(gatewaySecurityPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GatewaySecurityPolicyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gatewaySecurityPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GatewaySecurityPolicyName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gatewaySecurityPolicyName, bool allowUnparsed, out GatewaySecurityPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(gatewaySecurityPolicyName, nameof(gatewaySecurityPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationGatewaySecurityPolicy.TryParseName(gatewaySecurityPolicyName, out resourceName))
            {
                result = FromProjectLocationGatewaySecurityPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(gatewaySecurityPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GatewaySecurityPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string gatewaySecurityPolicyId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GatewaySecurityPolicyId = gatewaySecurityPolicyId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GatewaySecurityPolicyName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/gatewaySecurityPolicies/{gateway_security_policy}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gatewaySecurityPolicyId">
        /// The <c>GatewaySecurityPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public GatewaySecurityPolicyName(string projectId, string locationId, string gatewaySecurityPolicyId) : this(ResourceNameType.ProjectLocationGatewaySecurityPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gatewaySecurityPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(gatewaySecurityPolicyId, nameof(gatewaySecurityPolicyId)))
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
        /// The <c>GatewaySecurityPolicy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string GatewaySecurityPolicyId { get; }

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
                case ResourceNameType.ProjectLocationGatewaySecurityPolicy: return s_projectLocationGatewaySecurityPolicy.Expand(ProjectId, LocationId, GatewaySecurityPolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GatewaySecurityPolicyName);

        /// <inheritdoc/>
        public bool Equals(GatewaySecurityPolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GatewaySecurityPolicyName a, GatewaySecurityPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GatewaySecurityPolicyName a, GatewaySecurityPolicyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Subnetwork</c> resource.</summary>
    public sealed partial class SubnetworkName : gax::IResourceName, sys::IEquatable<SubnetworkName>
    {
        /// <summary>The possible contents of <see cref="SubnetworkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>.
            /// </summary>
            ProjectRegionSubnetwork = 1,
        }

        private static gax::PathTemplate s_projectRegionSubnetwork = new gax::PathTemplate("projects/{project}/regions/{region}/subnetworks/{subnetwork}");

        /// <summary>Creates a <see cref="SubnetworkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SubnetworkName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SubnetworkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SubnetworkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SubnetworkName"/> with the pattern
        /// <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetworkId">The <c>Subnetwork</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SubnetworkName"/> constructed from the provided ids.</returns>
        public static SubnetworkName FromProjectRegionSubnetwork(string projectId, string regionId, string subnetworkId) =>
            new SubnetworkName(ResourceNameType.ProjectRegionSubnetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), subnetworkId: gax::GaxPreconditions.CheckNotNullOrEmpty(subnetworkId, nameof(subnetworkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubnetworkName"/> with pattern
        /// <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetworkId">The <c>Subnetwork</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SubnetworkName"/> with pattern
        /// <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>.
        /// </returns>
        public static string Format(string projectId, string regionId, string subnetworkId) =>
            FormatProjectRegionSubnetwork(projectId, regionId, subnetworkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SubnetworkName"/> with pattern
        /// <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetworkId">The <c>Subnetwork</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SubnetworkName"/> with pattern
        /// <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>.
        /// </returns>
        public static string FormatProjectRegionSubnetwork(string projectId, string regionId, string subnetworkId) =>
            s_projectRegionSubnetwork.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(subnetworkId, nameof(subnetworkId)));

        /// <summary>Parses the given resource name string into a new <see cref="SubnetworkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="subnetworkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SubnetworkName"/> if successful.</returns>
        public static SubnetworkName Parse(string subnetworkName) => Parse(subnetworkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SubnetworkName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subnetworkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SubnetworkName"/> if successful.</returns>
        public static SubnetworkName Parse(string subnetworkName, bool allowUnparsed) =>
            TryParse(subnetworkName, allowUnparsed, out SubnetworkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubnetworkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="subnetworkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubnetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subnetworkName, out SubnetworkName result) =>
            TryParse(subnetworkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SubnetworkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="subnetworkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SubnetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string subnetworkName, bool allowUnparsed, out SubnetworkName result)
        {
            gax::GaxPreconditions.CheckNotNull(subnetworkName, nameof(subnetworkName));
            gax::TemplatedResourceName resourceName;
            if (s_projectRegionSubnetwork.TryParseName(subnetworkName, out resourceName))
            {
                result = FromProjectRegionSubnetwork(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(subnetworkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SubnetworkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string regionId = null, string subnetworkId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            RegionId = regionId;
            SubnetworkId = subnetworkId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SubnetworkName"/> class from the component parts of pattern
        /// <c>projects/{project}/regions/{region}/subnetworks/{subnetwork}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="subnetworkId">The <c>Subnetwork</c> ID. Must not be <c>null</c> or empty.</param>
        public SubnetworkName(string projectId, string regionId, string subnetworkId) : this(ResourceNameType.ProjectRegionSubnetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), subnetworkId: gax::GaxPreconditions.CheckNotNullOrEmpty(subnetworkId, nameof(subnetworkId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Region</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RegionId { get; }

        /// <summary>
        /// The <c>Subnetwork</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SubnetworkId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRegionSubnetwork: return s_projectRegionSubnetwork.Expand(ProjectId, RegionId, SubnetworkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SubnetworkName);

        /// <inheritdoc/>
        public bool Equals(SubnetworkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SubnetworkName a, SubnetworkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SubnetworkName a, SubnetworkName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Network</c> resource.</summary>
    public sealed partial class NetworkName : gax::IResourceName, sys::IEquatable<NetworkName>
    {
        /// <summary>The possible contents of <see cref="NetworkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/global/networks/{network}</c>.</summary>
            ProjectNetwork = 1,
        }

        private static gax::PathTemplate s_projectNetwork = new gax::PathTemplate("projects/{project}/global/networks/{network}");

        /// <summary>Creates a <see cref="NetworkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="NetworkName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static NetworkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new NetworkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="NetworkName"/> with the pattern <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="NetworkName"/> constructed from the provided ids.</returns>
        public static NetworkName FromProjectNetwork(string projectId, string networkId) =>
            new NetworkName(ResourceNameType.ProjectNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), networkId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </returns>
        public static string Format(string projectId, string networkId) => FormatProjectNetwork(projectId, networkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="NetworkName"/> with pattern
        /// <c>projects/{project}/global/networks/{network}</c>.
        /// </returns>
        public static string FormatProjectNetwork(string projectId, string networkId) =>
            s_projectNetwork.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)));

        /// <summary>Parses the given resource name string into a new <see cref="NetworkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="NetworkName"/> if successful.</returns>
        public static NetworkName Parse(string networkName) => Parse(networkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="NetworkName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="NetworkName"/> if successful.</returns>
        public static NetworkName Parse(string networkName, bool allowUnparsed) =>
            TryParse(networkName, allowUnparsed, out NetworkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkName, out NetworkName result) => TryParse(networkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="NetworkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/global/networks/{network}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="networkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="NetworkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string networkName, bool allowUnparsed, out NetworkName result)
        {
            gax::GaxPreconditions.CheckNotNull(networkName, nameof(networkName));
            gax::TemplatedResourceName resourceName;
            if (s_projectNetwork.TryParseName(networkName, out resourceName))
            {
                result = FromProjectNetwork(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(networkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private NetworkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string networkId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            NetworkId = networkId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="NetworkName"/> class from the component parts of pattern
        /// <c>projects/{project}/global/networks/{network}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="networkId">The <c>Network</c> ID. Must not be <c>null</c> or empty.</param>
        public NetworkName(string projectId, string networkId) : this(ResourceNameType.ProjectNetwork, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), networkId: gax::GaxPreconditions.CheckNotNullOrEmpty(networkId, nameof(networkId)))
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
        /// The <c>Network</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string NetworkId { get; }

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
                case ResourceNameType.ProjectNetwork: return s_projectNetwork.Expand(ProjectId, NetworkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as NetworkName);

        /// <inheritdoc/>
        public bool Equals(NetworkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(NetworkName a, NetworkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(NetworkName a, NetworkName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Address</c> resource.</summary>
    public sealed partial class AddressName : gax::IResourceName, sys::IEquatable<AddressName>
    {
        /// <summary>The possible contents of <see cref="AddressName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/regions/{region}/addresses/{address}</c>.
            /// </summary>
            ProjectRegionAddress = 1,
        }

        private static gax::PathTemplate s_projectRegionAddress = new gax::PathTemplate("projects/{project}/regions/{region}/addresses/{address}");

        /// <summary>Creates a <see cref="AddressName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AddressName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AddressName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AddressName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AddressName"/> with the pattern
        /// <c>projects/{project}/regions/{region}/addresses/{address}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="addressId">The <c>Address</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AddressName"/> constructed from the provided ids.</returns>
        public static AddressName FromProjectRegionAddress(string projectId, string regionId, string addressId) =>
            new AddressName(ResourceNameType.ProjectRegionAddress, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), addressId: gax::GaxPreconditions.CheckNotNullOrEmpty(addressId, nameof(addressId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AddressName"/> with pattern
        /// <c>projects/{project}/regions/{region}/addresses/{address}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="addressId">The <c>Address</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AddressName"/> with pattern
        /// <c>projects/{project}/regions/{region}/addresses/{address}</c>.
        /// </returns>
        public static string Format(string projectId, string regionId, string addressId) =>
            FormatProjectRegionAddress(projectId, regionId, addressId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AddressName"/> with pattern
        /// <c>projects/{project}/regions/{region}/addresses/{address}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="addressId">The <c>Address</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AddressName"/> with pattern
        /// <c>projects/{project}/regions/{region}/addresses/{address}</c>.
        /// </returns>
        public static string FormatProjectRegionAddress(string projectId, string regionId, string addressId) =>
            s_projectRegionAddress.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(addressId, nameof(addressId)));

        /// <summary>Parses the given resource name string into a new <see cref="AddressName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/addresses/{address}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="addressName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AddressName"/> if successful.</returns>
        public static AddressName Parse(string addressName) => Parse(addressName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AddressName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/addresses/{address}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="addressName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AddressName"/> if successful.</returns>
        public static AddressName Parse(string addressName, bool allowUnparsed) =>
            TryParse(addressName, allowUnparsed, out AddressName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AddressName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/addresses/{address}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="addressName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AddressName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string addressName, out AddressName result) => TryParse(addressName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AddressName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}/addresses/{address}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="addressName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AddressName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string addressName, bool allowUnparsed, out AddressName result)
        {
            gax::GaxPreconditions.CheckNotNull(addressName, nameof(addressName));
            gax::TemplatedResourceName resourceName;
            if (s_projectRegionAddress.TryParseName(addressName, out resourceName))
            {
                result = FromProjectRegionAddress(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(addressName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AddressName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string addressId = null, string projectId = null, string regionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AddressId = addressId;
            ProjectId = projectId;
            RegionId = regionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AddressName"/> class from the component parts of pattern
        /// <c>projects/{project}/regions/{region}/addresses/{address}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="addressId">The <c>Address</c> ID. Must not be <c>null</c> or empty.</param>
        public AddressName(string projectId, string regionId, string addressId) : this(ResourceNameType.ProjectRegionAddress, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), addressId: gax::GaxPreconditions.CheckNotNullOrEmpty(addressId, nameof(addressId)))
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
        /// The <c>Address</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AddressId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Region</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RegionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRegionAddress: return s_projectRegionAddress.Expand(ProjectId, RegionId, AddressId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AddressName);

        /// <inheritdoc/>
        public bool Equals(AddressName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AddressName a, AddressName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AddressName a, AddressName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Certificate</c> resource.</summary>
    public sealed partial class CertificateName : gax::IResourceName, sys::IEquatable<CertificateName>
    {
        /// <summary>The possible contents of <see cref="CertificateName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/certificates/{certificate}</c>.
            /// </summary>
            ProjectLocationCertificate = 1,
        }

        private static gax::PathTemplate s_projectLocationCertificate = new gax::PathTemplate("projects/{project}/locations/{location}/certificates/{certificate}");

        /// <summary>Creates a <see cref="CertificateName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CertificateName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CertificateName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CertificateName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CertificateName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/certificates/{certificate}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateId">The <c>Certificate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CertificateName"/> constructed from the provided ids.</returns>
        public static CertificateName FromProjectLocationCertificate(string projectId, string locationId, string certificateId) =>
            new CertificateName(ResourceNameType.ProjectLocationCertificate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), certificateId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateId, nameof(certificateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificates/{certificate}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateId">The <c>Certificate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CertificateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificates/{certificate}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string certificateId) =>
            FormatProjectLocationCertificate(projectId, locationId, certificateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CertificateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificates/{certificate}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateId">The <c>Certificate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CertificateName"/> with pattern
        /// <c>projects/{project}/locations/{location}/certificates/{certificate}</c>.
        /// </returns>
        public static string FormatProjectLocationCertificate(string projectId, string locationId, string certificateId) =>
            s_projectLocationCertificate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(certificateId, nameof(certificateId)));

        /// <summary>Parses the given resource name string into a new <see cref="CertificateName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/certificates/{certificate}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="certificateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CertificateName"/> if successful.</returns>
        public static CertificateName Parse(string certificateName) => Parse(certificateName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CertificateName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/certificates/{certificate}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="certificateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CertificateName"/> if successful.</returns>
        public static CertificateName Parse(string certificateName, bool allowUnparsed) =>
            TryParse(certificateName, allowUnparsed, out CertificateName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CertificateName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/certificates/{certificate}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="certificateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CertificateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string certificateName, out CertificateName result) =>
            TryParse(certificateName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CertificateName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/certificates/{certificate}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="certificateName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CertificateName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string certificateName, bool allowUnparsed, out CertificateName result)
        {
            gax::GaxPreconditions.CheckNotNull(certificateName, nameof(certificateName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationCertificate.TryParseName(certificateName, out resourceName))
            {
                result = FromProjectLocationCertificate(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(certificateName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CertificateName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string certificateId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CertificateId = certificateId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CertificateName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/certificates/{certificate}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="certificateId">The <c>Certificate</c> ID. Must not be <c>null</c> or empty.</param>
        public CertificateName(string projectId, string locationId, string certificateId) : this(ResourceNameType.ProjectLocationCertificate, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), certificateId: gax::GaxPreconditions.CheckNotNullOrEmpty(certificateId, nameof(certificateId)))
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
        /// The <c>Certificate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CertificateId { get; }

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
                case ResourceNameType.ProjectLocationCertificate: return s_projectLocationCertificate.Expand(ProjectId, LocationId, CertificateId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CertificateName);

        /// <inheritdoc/>
        public bool Equals(CertificateName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CertificateName a, CertificateName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CertificateName a, CertificateName b) => !(a == b);
    }

    public partial class Gateway
    {
        /// <summary>
        /// <see cref="gcnv::GatewayName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::GatewayName GatewayName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::GatewayName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AddressName"/>-typed view over the <see cref="Addresses"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<AddressName> AddressesAsAddressNames
        {
            get => new gax::ResourceNameList<AddressName>(Addresses, s => string.IsNullOrEmpty(s) ? null : AddressName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="ServerTlsPolicyName"/>-typed view over the <see cref="ServerTlsPolicy"/> resource name property.
        /// </summary>
        public ServerTlsPolicyName ServerTlsPolicyAsServerTlsPolicyName
        {
            get => string.IsNullOrEmpty(ServerTlsPolicy) ? null : ServerTlsPolicyName.Parse(ServerTlsPolicy, allowUnparsed: true);
            set => ServerTlsPolicy = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CertificateName"/>-typed view over the <see cref="CertificateUrls"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<CertificateName> CertificateUrlsAsCertificateNames
        {
            get => new gax::ResourceNameList<CertificateName>(CertificateUrls, s => string.IsNullOrEmpty(s) ? null : CertificateName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
        /// </summary>
        public NetworkName NetworkAsNetworkName
        {
            get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
            set => Network = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SubnetworkName"/>-typed view over the <see cref="Subnetwork"/> resource name property.
        /// </summary>
        public SubnetworkName SubnetworkAsSubnetworkName
        {
            get => string.IsNullOrEmpty(Subnetwork) ? null : SubnetworkName.Parse(Subnetwork, allowUnparsed: true);
            set => Subnetwork = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="GatewaySecurityPolicyName"/>-typed view over the <see cref="GatewaySecurityPolicy"/> resource
        /// name property.
        /// </summary>
        public GatewaySecurityPolicyName GatewaySecurityPolicyAsGatewaySecurityPolicyName
        {
            get => string.IsNullOrEmpty(GatewaySecurityPolicy) ? null : GatewaySecurityPolicyName.Parse(GatewaySecurityPolicy, allowUnparsed: true);
            set => GatewaySecurityPolicy = value?.ToString() ?? "";
        }
    }

    public partial class ListGatewaysRequest
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

    public partial class GetGatewayRequest
    {
        /// <summary>
        /// <see cref="gcnv::GatewayName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::GatewayName GatewayName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::GatewayName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateGatewayRequest
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

    public partial class DeleteGatewayRequest
    {
        /// <summary>
        /// <see cref="gcnv::GatewayName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::GatewayName GatewayName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::GatewayName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
