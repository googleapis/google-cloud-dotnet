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
using gcnv = Google.Cloud.NetworkConnectivity.V1;
using sys = System;

namespace Google.Cloud.NetworkConnectivity.V1
{
    /// <summary>Resource name for the <c>PolicyBasedRoute</c> resource.</summary>
    public sealed partial class PolicyBasedRouteName : gax::IResourceName, sys::IEquatable<PolicyBasedRouteName>
    {
        /// <summary>The possible contents of <see cref="PolicyBasedRouteName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/global/PolicyBasedRoutes/{policy_based_route}</c>.
            /// </summary>
            ProjectPolicyBasedRoute = 1,
        }

        private static gax::PathTemplate s_projectPolicyBasedRoute = new gax::PathTemplate("projects/{project}/locations/global/PolicyBasedRoutes/{policy_based_route}");

        /// <summary>Creates a <see cref="PolicyBasedRouteName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PolicyBasedRouteName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PolicyBasedRouteName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PolicyBasedRouteName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PolicyBasedRouteName"/> with the pattern
        /// <c>projects/{project}/locations/global/PolicyBasedRoutes/{policy_based_route}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyBasedRouteId">The <c>PolicyBasedRoute</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PolicyBasedRouteName"/> constructed from the provided ids.</returns>
        public static PolicyBasedRouteName FromProjectPolicyBasedRoute(string projectId, string policyBasedRouteId) =>
            new PolicyBasedRouteName(ResourceNameType.ProjectPolicyBasedRoute, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), policyBasedRouteId: gax::GaxPreconditions.CheckNotNullOrEmpty(policyBasedRouteId, nameof(policyBasedRouteId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyBasedRouteName"/> with pattern
        /// <c>projects/{project}/locations/global/PolicyBasedRoutes/{policy_based_route}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyBasedRouteId">The <c>PolicyBasedRoute</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyBasedRouteName"/> with pattern
        /// <c>projects/{project}/locations/global/PolicyBasedRoutes/{policy_based_route}</c>.
        /// </returns>
        public static string Format(string projectId, string policyBasedRouteId) =>
            FormatProjectPolicyBasedRoute(projectId, policyBasedRouteId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PolicyBasedRouteName"/> with pattern
        /// <c>projects/{project}/locations/global/PolicyBasedRoutes/{policy_based_route}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyBasedRouteId">The <c>PolicyBasedRoute</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PolicyBasedRouteName"/> with pattern
        /// <c>projects/{project}/locations/global/PolicyBasedRoutes/{policy_based_route}</c>.
        /// </returns>
        public static string FormatProjectPolicyBasedRoute(string projectId, string policyBasedRouteId) =>
            s_projectPolicyBasedRoute.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(policyBasedRouteId, nameof(policyBasedRouteId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PolicyBasedRouteName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/global/PolicyBasedRoutes/{policy_based_route}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="policyBasedRouteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PolicyBasedRouteName"/> if successful.</returns>
        public static PolicyBasedRouteName Parse(string policyBasedRouteName) => Parse(policyBasedRouteName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PolicyBasedRouteName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/global/PolicyBasedRoutes/{policy_based_route}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="policyBasedRouteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PolicyBasedRouteName"/> if successful.</returns>
        public static PolicyBasedRouteName Parse(string policyBasedRouteName, bool allowUnparsed) =>
            TryParse(policyBasedRouteName, allowUnparsed, out PolicyBasedRouteName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PolicyBasedRouteName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/global/PolicyBasedRoutes/{policy_based_route}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="policyBasedRouteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PolicyBasedRouteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string policyBasedRouteName, out PolicyBasedRouteName result) =>
            TryParse(policyBasedRouteName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PolicyBasedRouteName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/global/PolicyBasedRoutes/{policy_based_route}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="policyBasedRouteName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PolicyBasedRouteName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string policyBasedRouteName, bool allowUnparsed, out PolicyBasedRouteName result)
        {
            gax::GaxPreconditions.CheckNotNull(policyBasedRouteName, nameof(policyBasedRouteName));
            gax::TemplatedResourceName resourceName;
            if (s_projectPolicyBasedRoute.TryParseName(policyBasedRouteName, out resourceName))
            {
                result = FromProjectPolicyBasedRoute(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(policyBasedRouteName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PolicyBasedRouteName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string policyBasedRouteId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            PolicyBasedRouteId = policyBasedRouteId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PolicyBasedRouteName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/global/PolicyBasedRoutes/{policy_based_route}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="policyBasedRouteId">The <c>PolicyBasedRoute</c> ID. Must not be <c>null</c> or empty.</param>
        public PolicyBasedRouteName(string projectId, string policyBasedRouteId) : this(ResourceNameType.ProjectPolicyBasedRoute, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), policyBasedRouteId: gax::GaxPreconditions.CheckNotNullOrEmpty(policyBasedRouteId, nameof(policyBasedRouteId)))
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
        /// The <c>PolicyBasedRoute</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PolicyBasedRouteId { get; }

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
                case ResourceNameType.ProjectPolicyBasedRoute: return s_projectPolicyBasedRoute.Expand(ProjectId, PolicyBasedRouteId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PolicyBasedRouteName);

        /// <inheritdoc/>
        public bool Equals(PolicyBasedRouteName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PolicyBasedRouteName a, PolicyBasedRouteName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PolicyBasedRouteName a, PolicyBasedRouteName b) => !(a == b);
    }

    public partial class PolicyBasedRoute
    {
        /// <summary>
        /// <see cref="gcnv::PolicyBasedRouteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::PolicyBasedRouteName PolicyBasedRouteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::PolicyBasedRouteName.Parse(Name, allowUnparsed: true);
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

    public partial class ListPolicyBasedRoutesRequest
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

    public partial class GetPolicyBasedRouteRequest
    {
        /// <summary>
        /// <see cref="gcnv::PolicyBasedRouteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::PolicyBasedRouteName PolicyBasedRouteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::PolicyBasedRouteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreatePolicyBasedRouteRequest
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

    public partial class DeletePolicyBasedRouteRequest
    {
        /// <summary>
        /// <see cref="gcnv::PolicyBasedRouteName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::PolicyBasedRouteName PolicyBasedRouteName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::PolicyBasedRouteName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
