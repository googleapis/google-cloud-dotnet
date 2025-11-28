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
    /// <summary>Resource name for the <c>ServiceLbPolicy</c> resource.</summary>
    public sealed partial class ServiceLbPolicyName : gax::IResourceName, sys::IEquatable<ServiceLbPolicyName>
    {
        /// <summary>The possible contents of <see cref="ServiceLbPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy}</c>.
            /// </summary>
            ProjectLocationServiceLbPolicy = 1,
        }

        private static gax::PathTemplate s_projectLocationServiceLbPolicy = new gax::PathTemplate("projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy}");

        /// <summary>Creates a <see cref="ServiceLbPolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceLbPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceLbPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceLbPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceLbPolicyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceLbPolicyId">The <c>ServiceLbPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceLbPolicyName"/> constructed from the provided ids.</returns>
        public static ServiceLbPolicyName FromProjectLocationServiceLbPolicy(string projectId, string locationId, string serviceLbPolicyId) =>
            new ServiceLbPolicyName(ResourceNameType.ProjectLocationServiceLbPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceLbPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceLbPolicyId, nameof(serviceLbPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceLbPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceLbPolicyId">The <c>ServiceLbPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceLbPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string serviceLbPolicyId) =>
            FormatProjectLocationServiceLbPolicy(projectId, locationId, serviceLbPolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceLbPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceLbPolicyId">The <c>ServiceLbPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceLbPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy}</c>.
        /// </returns>
        public static string FormatProjectLocationServiceLbPolicy(string projectId, string locationId, string serviceLbPolicyId) =>
            s_projectLocationServiceLbPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceLbPolicyId, nameof(serviceLbPolicyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceLbPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceLbPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceLbPolicyName"/> if successful.</returns>
        public static ServiceLbPolicyName Parse(string serviceLbPolicyName) => Parse(serviceLbPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceLbPolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceLbPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceLbPolicyName"/> if successful.</returns>
        public static ServiceLbPolicyName Parse(string serviceLbPolicyName, bool allowUnparsed) =>
            TryParse(serviceLbPolicyName, allowUnparsed, out ServiceLbPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceLbPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceLbPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceLbPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceLbPolicyName, out ServiceLbPolicyName result) =>
            TryParse(serviceLbPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceLbPolicyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceLbPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceLbPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceLbPolicyName, bool allowUnparsed, out ServiceLbPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceLbPolicyName, nameof(serviceLbPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationServiceLbPolicy.TryParseName(serviceLbPolicyName, out resourceName))
            {
                result = FromProjectLocationServiceLbPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceLbPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceLbPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string serviceLbPolicyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ServiceLbPolicyId = serviceLbPolicyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceLbPolicyName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/serviceLbPolicies/{service_lb_policy}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceLbPolicyId">The <c>ServiceLbPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        public ServiceLbPolicyName(string projectId, string locationId, string serviceLbPolicyId) : this(ResourceNameType.ProjectLocationServiceLbPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceLbPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceLbPolicyId, nameof(serviceLbPolicyId)))
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
        /// The <c>ServiceLbPolicy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ServiceLbPolicyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationServiceLbPolicy: return s_projectLocationServiceLbPolicy.Expand(ProjectId, LocationId, ServiceLbPolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceLbPolicyName);

        /// <inheritdoc/>
        public bool Equals(ServiceLbPolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServiceLbPolicyName a, ServiceLbPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServiceLbPolicyName a, ServiceLbPolicyName b) => !(a == b);
    }

    public partial class ServiceLbPolicy
    {
        /// <summary>
        /// <see cref="gcnv::ServiceLbPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ServiceLbPolicyName ServiceLbPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ServiceLbPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListServiceLbPoliciesRequest
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

    public partial class GetServiceLbPolicyRequest
    {
        /// <summary>
        /// <see cref="gcnv::ServiceLbPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ServiceLbPolicyName ServiceLbPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ServiceLbPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateServiceLbPolicyRequest
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

    public partial class DeleteServiceLbPolicyRequest
    {
        /// <summary>
        /// <see cref="gcnv::ServiceLbPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ServiceLbPolicyName ServiceLbPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ServiceLbPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
