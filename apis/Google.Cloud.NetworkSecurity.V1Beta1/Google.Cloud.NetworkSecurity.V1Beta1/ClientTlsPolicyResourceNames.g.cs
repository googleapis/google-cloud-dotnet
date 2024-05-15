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
using gcnv = Google.Cloud.NetworkSecurity.V1Beta1;
using sys = System;

namespace Google.Cloud.NetworkSecurity.V1Beta1
{
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

    public partial class ClientTlsPolicy
    {
        /// <summary>
        /// <see cref="gcnv::ClientTlsPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ClientTlsPolicyName ClientTlsPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ClientTlsPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListClientTlsPoliciesRequest
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

    public partial class GetClientTlsPolicyRequest
    {
        /// <summary>
        /// <see cref="gcnv::ClientTlsPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ClientTlsPolicyName ClientTlsPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ClientTlsPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateClientTlsPolicyRequest
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

    public partial class DeleteClientTlsPolicyRequest
    {
        /// <summary>
        /// <see cref="gcnv::ClientTlsPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ClientTlsPolicyName ClientTlsPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ClientTlsPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
