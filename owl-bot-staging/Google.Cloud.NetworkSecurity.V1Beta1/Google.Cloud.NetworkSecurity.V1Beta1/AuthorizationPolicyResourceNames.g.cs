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
using gcnv = Google.Cloud.NetworkSecurity.V1Beta1;
using sys = System;

namespace Google.Cloud.NetworkSecurity.V1Beta1
{
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

    public partial class AuthorizationPolicy
    {
        /// <summary>
        /// <see cref="gcnv::AuthorizationPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::AuthorizationPolicyName AuthorizationPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::AuthorizationPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAuthorizationPoliciesRequest
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

    public partial class GetAuthorizationPolicyRequest
    {
        /// <summary>
        /// <see cref="gcnv::AuthorizationPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::AuthorizationPolicyName AuthorizationPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::AuthorizationPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAuthorizationPolicyRequest
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

    public partial class DeleteAuthorizationPolicyRequest
    {
        /// <summary>
        /// <see cref="gcnv::AuthorizationPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::AuthorizationPolicyName AuthorizationPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::AuthorizationPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
