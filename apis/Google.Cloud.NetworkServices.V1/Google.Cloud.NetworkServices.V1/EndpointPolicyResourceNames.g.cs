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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcnv = Google.Cloud.NetworkServices.V1;
using sys = System;

namespace Google.Cloud.NetworkServices.V1
{
    /// <summary>Resource name for the <c>EndpointPolicy</c> resource.</summary>
    public sealed partial class EndpointPolicyName : gax::IResourceName, sys::IEquatable<EndpointPolicyName>
    {
        /// <summary>The possible contents of <see cref="EndpointPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/endpointPolicies/{endpoint_policy}</c>.
            /// </summary>
            ProjectLocationEndpointPolicy = 1,
        }

        private static gax::PathTemplate s_projectLocationEndpointPolicy = new gax::PathTemplate("projects/{project}/locations/{location}/endpointPolicies/{endpoint_policy}");

        /// <summary>Creates a <see cref="EndpointPolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EndpointPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EndpointPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EndpointPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EndpointPolicyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/endpointPolicies/{endpoint_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endpointPolicyId">The <c>EndpointPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EndpointPolicyName"/> constructed from the provided ids.</returns>
        public static EndpointPolicyName FromProjectLocationEndpointPolicy(string projectId, string locationId, string endpointPolicyId) =>
            new EndpointPolicyName(ResourceNameType.ProjectLocationEndpointPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), endpointPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(endpointPolicyId, nameof(endpointPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EndpointPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/endpointPolicies/{endpoint_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endpointPolicyId">The <c>EndpointPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EndpointPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/endpointPolicies/{endpoint_policy}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string endpointPolicyId) =>
            FormatProjectLocationEndpointPolicy(projectId, locationId, endpointPolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EndpointPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/endpointPolicies/{endpoint_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endpointPolicyId">The <c>EndpointPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EndpointPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/endpointPolicies/{endpoint_policy}</c>.
        /// </returns>
        public static string FormatProjectLocationEndpointPolicy(string projectId, string locationId, string endpointPolicyId) =>
            s_projectLocationEndpointPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(endpointPolicyId, nameof(endpointPolicyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EndpointPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/endpointPolicies/{endpoint_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="endpointPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EndpointPolicyName"/> if successful.</returns>
        public static EndpointPolicyName Parse(string endpointPolicyName) => Parse(endpointPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EndpointPolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/endpointPolicies/{endpoint_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="endpointPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EndpointPolicyName"/> if successful.</returns>
        public static EndpointPolicyName Parse(string endpointPolicyName, bool allowUnparsed) =>
            TryParse(endpointPolicyName, allowUnparsed, out EndpointPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EndpointPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/endpointPolicies/{endpoint_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="endpointPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EndpointPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string endpointPolicyName, out EndpointPolicyName result) =>
            TryParse(endpointPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EndpointPolicyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/endpointPolicies/{endpoint_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="endpointPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EndpointPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string endpointPolicyName, bool allowUnparsed, out EndpointPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(endpointPolicyName, nameof(endpointPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationEndpointPolicy.TryParseName(endpointPolicyName, out resourceName))
            {
                result = FromProjectLocationEndpointPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(endpointPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EndpointPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string endpointPolicyId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EndpointPolicyId = endpointPolicyId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EndpointPolicyName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/endpointPolicies/{endpoint_policy}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endpointPolicyId">The <c>EndpointPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        public EndpointPolicyName(string projectId, string locationId, string endpointPolicyId) : this(ResourceNameType.ProjectLocationEndpointPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), endpointPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(endpointPolicyId, nameof(endpointPolicyId)))
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
        /// The <c>EndpointPolicy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string EndpointPolicyId { get; }

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
                case ResourceNameType.ProjectLocationEndpointPolicy: return s_projectLocationEndpointPolicy.Expand(ProjectId, LocationId, EndpointPolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EndpointPolicyName);

        /// <inheritdoc/>
        public bool Equals(EndpointPolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EndpointPolicyName a, EndpointPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EndpointPolicyName a, EndpointPolicyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AuthorizationPolicy</c> resource.</summary>
    public sealed partial class AuthorizationPolicyName : gax::IResourceName, sys::IEquatable<AuthorizationPolicyName>
    {
        /// <summary>The possible contents of <see cref="AuthorizationPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/authorizationPolicies/{authorization_policy}</c>.
            /// </summary>
            ProjectLocationAuthorizationPolicy = 1,
        }

        private static gax::PathTemplate s_projectLocationAuthorizationPolicy = new gax::PathTemplate("projects/{project}/locations/{location}/authorizationPolicies/{authorization_policy}");

        /// <summary>Creates a <see cref="AuthorizationPolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AuthorizationPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AuthorizationPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AuthorizationPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AuthorizationPolicyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/authorizationPolicies/{authorization_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="authorizationPolicyId">
        /// The <c>AuthorizationPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="AuthorizationPolicyName"/> constructed from the provided ids.
        /// </returns>
        public static AuthorizationPolicyName FromProjectLocationAuthorizationPolicy(string projectId, string locationId, string authorizationPolicyId) =>
            new AuthorizationPolicyName(ResourceNameType.ProjectLocationAuthorizationPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), authorizationPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(authorizationPolicyId, nameof(authorizationPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AuthorizationPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/authorizationPolicies/{authorization_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="authorizationPolicyId">
        /// The <c>AuthorizationPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AuthorizationPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/authorizationPolicies/{authorization_policy}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string authorizationPolicyId) =>
            FormatProjectLocationAuthorizationPolicy(projectId, locationId, authorizationPolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AuthorizationPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/authorizationPolicies/{authorization_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="authorizationPolicyId">
        /// The <c>AuthorizationPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AuthorizationPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/authorizationPolicies/{authorization_policy}</c>.
        /// </returns>
        public static string FormatProjectLocationAuthorizationPolicy(string projectId, string locationId, string authorizationPolicyId) =>
            s_projectLocationAuthorizationPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(authorizationPolicyId, nameof(authorizationPolicyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AuthorizationPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/authorizationPolicies/{authorization_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="authorizationPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AuthorizationPolicyName"/> if successful.</returns>
        public static AuthorizationPolicyName Parse(string authorizationPolicyName) => Parse(authorizationPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AuthorizationPolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/authorizationPolicies/{authorization_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="authorizationPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AuthorizationPolicyName"/> if successful.</returns>
        public static AuthorizationPolicyName Parse(string authorizationPolicyName, bool allowUnparsed) =>
            TryParse(authorizationPolicyName, allowUnparsed, out AuthorizationPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AuthorizationPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/authorizationPolicies/{authorization_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="authorizationPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AuthorizationPolicyName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string authorizationPolicyName, out AuthorizationPolicyName result) =>
            TryParse(authorizationPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AuthorizationPolicyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/authorizationPolicies/{authorization_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="authorizationPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AuthorizationPolicyName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string authorizationPolicyName, bool allowUnparsed, out AuthorizationPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(authorizationPolicyName, nameof(authorizationPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAuthorizationPolicy.TryParseName(authorizationPolicyName, out resourceName))
            {
                result = FromProjectLocationAuthorizationPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(authorizationPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AuthorizationPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string authorizationPolicyId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AuthorizationPolicyId = authorizationPolicyId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AuthorizationPolicyName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/authorizationPolicies/{authorization_policy}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="authorizationPolicyId">
        /// The <c>AuthorizationPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public AuthorizationPolicyName(string projectId, string locationId, string authorizationPolicyId) : this(ResourceNameType.ProjectLocationAuthorizationPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), authorizationPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(authorizationPolicyId, nameof(authorizationPolicyId)))
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
        /// The <c>AuthorizationPolicy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string AuthorizationPolicyId { get; }

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
                case ResourceNameType.ProjectLocationAuthorizationPolicy: return s_projectLocationAuthorizationPolicy.Expand(ProjectId, LocationId, AuthorizationPolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AuthorizationPolicyName);

        /// <inheritdoc/>
        public bool Equals(AuthorizationPolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AuthorizationPolicyName a, AuthorizationPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AuthorizationPolicyName a, AuthorizationPolicyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ServerTlsPolicy</c> resource.</summary>
    public sealed partial class ServerTlsPolicyName : gax::IResourceName, sys::IEquatable<ServerTlsPolicyName>
    {
        /// <summary>The possible contents of <see cref="ServerTlsPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/serverTlsPolicies/{server_tls_policy}</c>.
            /// </summary>
            ProjectLocationServerTlsPolicy = 1,
        }

        private static gax::PathTemplate s_projectLocationServerTlsPolicy = new gax::PathTemplate("projects/{project}/locations/{location}/serverTlsPolicies/{server_tls_policy}");

        /// <summary>Creates a <see cref="ServerTlsPolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServerTlsPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServerTlsPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServerTlsPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServerTlsPolicyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/serverTlsPolicies/{server_tls_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serverTlsPolicyId">The <c>ServerTlsPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServerTlsPolicyName"/> constructed from the provided ids.</returns>
        public static ServerTlsPolicyName FromProjectLocationServerTlsPolicy(string projectId, string locationId, string serverTlsPolicyId) =>
            new ServerTlsPolicyName(ResourceNameType.ProjectLocationServerTlsPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serverTlsPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(serverTlsPolicyId, nameof(serverTlsPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServerTlsPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serverTlsPolicies/{server_tls_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serverTlsPolicyId">The <c>ServerTlsPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServerTlsPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serverTlsPolicies/{server_tls_policy}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string serverTlsPolicyId) =>
            FormatProjectLocationServerTlsPolicy(projectId, locationId, serverTlsPolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServerTlsPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serverTlsPolicies/{server_tls_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serverTlsPolicyId">The <c>ServerTlsPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServerTlsPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serverTlsPolicies/{server_tls_policy}</c>.
        /// </returns>
        public static string FormatProjectLocationServerTlsPolicy(string projectId, string locationId, string serverTlsPolicyId) =>
            s_projectLocationServerTlsPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serverTlsPolicyId, nameof(serverTlsPolicyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServerTlsPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serverTlsPolicies/{server_tls_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serverTlsPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServerTlsPolicyName"/> if successful.</returns>
        public static ServerTlsPolicyName Parse(string serverTlsPolicyName) => Parse(serverTlsPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServerTlsPolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serverTlsPolicies/{server_tls_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serverTlsPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServerTlsPolicyName"/> if successful.</returns>
        public static ServerTlsPolicyName Parse(string serverTlsPolicyName, bool allowUnparsed) =>
            TryParse(serverTlsPolicyName, allowUnparsed, out ServerTlsPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServerTlsPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serverTlsPolicies/{server_tls_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serverTlsPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServerTlsPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serverTlsPolicyName, out ServerTlsPolicyName result) =>
            TryParse(serverTlsPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServerTlsPolicyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serverTlsPolicies/{server_tls_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serverTlsPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServerTlsPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serverTlsPolicyName, bool allowUnparsed, out ServerTlsPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(serverTlsPolicyName, nameof(serverTlsPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationServerTlsPolicy.TryParseName(serverTlsPolicyName, out resourceName))
            {
                result = FromProjectLocationServerTlsPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serverTlsPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServerTlsPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string serverTlsPolicyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ServerTlsPolicyId = serverTlsPolicyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServerTlsPolicyName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/serverTlsPolicies/{server_tls_policy}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serverTlsPolicyId">The <c>ServerTlsPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        public ServerTlsPolicyName(string projectId, string locationId, string serverTlsPolicyId) : this(ResourceNameType.ProjectLocationServerTlsPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serverTlsPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(serverTlsPolicyId, nameof(serverTlsPolicyId)))
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
        /// The <c>ServerTlsPolicy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ServerTlsPolicyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationServerTlsPolicy: return s_projectLocationServerTlsPolicy.Expand(ProjectId, LocationId, ServerTlsPolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServerTlsPolicyName);

        /// <inheritdoc/>
        public bool Equals(ServerTlsPolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServerTlsPolicyName a, ServerTlsPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServerTlsPolicyName a, ServerTlsPolicyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ClientTlsPolicy</c> resource.</summary>
    public sealed partial class ClientTlsPolicyName : gax::IResourceName, sys::IEquatable<ClientTlsPolicyName>
    {
        /// <summary>The possible contents of <see cref="ClientTlsPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/clientTlsPolicies/{client_tls_policy}</c>.
            /// </summary>
            ProjectLocationClientTlsPolicy = 1,
        }

        private static gax::PathTemplate s_projectLocationClientTlsPolicy = new gax::PathTemplate("projects/{project}/locations/{location}/clientTlsPolicies/{client_tls_policy}");

        /// <summary>Creates a <see cref="ClientTlsPolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ClientTlsPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ClientTlsPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ClientTlsPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ClientTlsPolicyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/clientTlsPolicies/{client_tls_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientTlsPolicyId">The <c>ClientTlsPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ClientTlsPolicyName"/> constructed from the provided ids.</returns>
        public static ClientTlsPolicyName FromProjectLocationClientTlsPolicy(string projectId, string locationId, string clientTlsPolicyId) =>
            new ClientTlsPolicyName(ResourceNameType.ProjectLocationClientTlsPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clientTlsPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(clientTlsPolicyId, nameof(clientTlsPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ClientTlsPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clientTlsPolicies/{client_tls_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientTlsPolicyId">The <c>ClientTlsPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ClientTlsPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clientTlsPolicies/{client_tls_policy}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string clientTlsPolicyId) =>
            FormatProjectLocationClientTlsPolicy(projectId, locationId, clientTlsPolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ClientTlsPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clientTlsPolicies/{client_tls_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientTlsPolicyId">The <c>ClientTlsPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ClientTlsPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/clientTlsPolicies/{client_tls_policy}</c>.
        /// </returns>
        public static string FormatProjectLocationClientTlsPolicy(string projectId, string locationId, string clientTlsPolicyId) =>
            s_projectLocationClientTlsPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clientTlsPolicyId, nameof(clientTlsPolicyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ClientTlsPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clientTlsPolicies/{client_tls_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="clientTlsPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ClientTlsPolicyName"/> if successful.</returns>
        public static ClientTlsPolicyName Parse(string clientTlsPolicyName) => Parse(clientTlsPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ClientTlsPolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clientTlsPolicies/{client_tls_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="clientTlsPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ClientTlsPolicyName"/> if successful.</returns>
        public static ClientTlsPolicyName Parse(string clientTlsPolicyName, bool allowUnparsed) =>
            TryParse(clientTlsPolicyName, allowUnparsed, out ClientTlsPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ClientTlsPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clientTlsPolicies/{client_tls_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="clientTlsPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ClientTlsPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string clientTlsPolicyName, out ClientTlsPolicyName result) =>
            TryParse(clientTlsPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ClientTlsPolicyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/clientTlsPolicies/{client_tls_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="clientTlsPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ClientTlsPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string clientTlsPolicyName, bool allowUnparsed, out ClientTlsPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(clientTlsPolicyName, nameof(clientTlsPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationClientTlsPolicy.TryParseName(clientTlsPolicyName, out resourceName))
            {
                result = FromProjectLocationClientTlsPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(clientTlsPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ClientTlsPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clientTlsPolicyId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClientTlsPolicyId = clientTlsPolicyId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ClientTlsPolicyName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/clientTlsPolicies/{client_tls_policy}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientTlsPolicyId">The <c>ClientTlsPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        public ClientTlsPolicyName(string projectId, string locationId, string clientTlsPolicyId) : this(ResourceNameType.ProjectLocationClientTlsPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), clientTlsPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(clientTlsPolicyId, nameof(clientTlsPolicyId)))
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
        /// The <c>ClientTlsPolicy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ClientTlsPolicyId { get; }

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
                case ResourceNameType.ProjectLocationClientTlsPolicy: return s_projectLocationClientTlsPolicy.Expand(ProjectId, LocationId, ClientTlsPolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ClientTlsPolicyName);

        /// <inheritdoc/>
        public bool Equals(ClientTlsPolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ClientTlsPolicyName a, ClientTlsPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ClientTlsPolicyName a, ClientTlsPolicyName b) => !(a == b);
    }

    public partial class EndpointPolicy
    {
        /// <summary>
        /// <see cref="gcnv::EndpointPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::EndpointPolicyName EndpointPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::EndpointPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AuthorizationPolicyName"/>-typed view over the <see cref="AuthorizationPolicy"/> resource name
        /// property.
        /// </summary>
        public AuthorizationPolicyName AuthorizationPolicyAsAuthorizationPolicyName
        {
            get => string.IsNullOrEmpty(AuthorizationPolicy) ? null : AuthorizationPolicyName.Parse(AuthorizationPolicy, allowUnparsed: true);
            set => AuthorizationPolicy = value?.ToString() ?? "";
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
        /// <see cref="ClientTlsPolicyName"/>-typed view over the <see cref="ClientTlsPolicy"/> resource name property.
        /// </summary>
        public ClientTlsPolicyName ClientTlsPolicyAsClientTlsPolicyName
        {
            get => string.IsNullOrEmpty(ClientTlsPolicy) ? null : ClientTlsPolicyName.Parse(ClientTlsPolicy, allowUnparsed: true);
            set => ClientTlsPolicy = value?.ToString() ?? "";
        }
    }

    public partial class ListEndpointPoliciesRequest
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

    public partial class GetEndpointPolicyRequest
    {
        /// <summary>
        /// <see cref="gcnv::EndpointPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::EndpointPolicyName EndpointPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::EndpointPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateEndpointPolicyRequest
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

    public partial class DeleteEndpointPolicyRequest
    {
        /// <summary>
        /// <see cref="gcnv::EndpointPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::EndpointPolicyName EndpointPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::EndpointPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
