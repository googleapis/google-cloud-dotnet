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
using gax = Google.Api.Gax;
using gccv = Google.Cloud.CloudControlsPartner.V1;
using sys = System;

namespace Google.Cloud.CloudControlsPartner.V1
{
    /// <summary>Resource name for the <c>AccessApprovalRequest</c> resource.</summary>
    public sealed partial class AccessApprovalRequestName : gax::IResourceName, sys::IEquatable<AccessApprovalRequestName>
    {
        /// <summary>The possible contents of <see cref="AccessApprovalRequestName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/accessApprovalRequests/{access_approval_request}</c>
            /// .
            /// </summary>
            OrganizationLocationCustomerWorkloadAccessApprovalRequest = 1,
        }

        private static gax::PathTemplate s_organizationLocationCustomerWorkloadAccessApprovalRequest = new gax::PathTemplate("organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/accessApprovalRequests/{access_approval_request}");

        /// <summary>Creates a <see cref="AccessApprovalRequestName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AccessApprovalRequestName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AccessApprovalRequestName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AccessApprovalRequestName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AccessApprovalRequestName"/> with the pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/accessApprovalRequests/{access_approval_request}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accessApprovalRequestId">
        /// The <c>AccessApprovalRequest</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="AccessApprovalRequestName"/> constructed from the provided ids.
        /// </returns>
        public static AccessApprovalRequestName FromOrganizationLocationCustomerWorkloadAccessApprovalRequest(string organizationId, string locationId, string customerId, string workloadId, string accessApprovalRequestId) =>
            new AccessApprovalRequestName(ResourceNameType.OrganizationLocationCustomerWorkloadAccessApprovalRequest, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), workloadId: gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)), accessApprovalRequestId: gax::GaxPreconditions.CheckNotNullOrEmpty(accessApprovalRequestId, nameof(accessApprovalRequestId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessApprovalRequestName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/accessApprovalRequests/{access_approval_request}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accessApprovalRequestId">
        /// The <c>AccessApprovalRequest</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AccessApprovalRequestName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/accessApprovalRequests/{access_approval_request}</c>
        /// .
        /// </returns>
        public static string Format(string organizationId, string locationId, string customerId, string workloadId, string accessApprovalRequestId) =>
            FormatOrganizationLocationCustomerWorkloadAccessApprovalRequest(organizationId, locationId, customerId, workloadId, accessApprovalRequestId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccessApprovalRequestName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/accessApprovalRequests/{access_approval_request}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accessApprovalRequestId">
        /// The <c>AccessApprovalRequest</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AccessApprovalRequestName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/accessApprovalRequests/{access_approval_request}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationLocationCustomerWorkloadAccessApprovalRequest(string organizationId, string locationId, string customerId, string workloadId, string accessApprovalRequestId) =>
            s_organizationLocationCustomerWorkloadAccessApprovalRequest.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)), gax::GaxPreconditions.CheckNotNullOrEmpty(accessApprovalRequestId, nameof(accessApprovalRequestId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccessApprovalRequestName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/accessApprovalRequests/{access_approval_request}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="accessApprovalRequestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AccessApprovalRequestName"/> if successful.</returns>
        public static AccessApprovalRequestName Parse(string accessApprovalRequestName) =>
            Parse(accessApprovalRequestName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccessApprovalRequestName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/accessApprovalRequests/{access_approval_request}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accessApprovalRequestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AccessApprovalRequestName"/> if successful.</returns>
        public static AccessApprovalRequestName Parse(string accessApprovalRequestName, bool allowUnparsed) =>
            TryParse(accessApprovalRequestName, allowUnparsed, out AccessApprovalRequestName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccessApprovalRequestName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/accessApprovalRequests/{access_approval_request}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="accessApprovalRequestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccessApprovalRequestName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accessApprovalRequestName, out AccessApprovalRequestName result) =>
            TryParse(accessApprovalRequestName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccessApprovalRequestName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/accessApprovalRequests/{access_approval_request}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accessApprovalRequestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccessApprovalRequestName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accessApprovalRequestName, bool allowUnparsed, out AccessApprovalRequestName result)
        {
            gax::GaxPreconditions.CheckNotNull(accessApprovalRequestName, nameof(accessApprovalRequestName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationCustomerWorkloadAccessApprovalRequest.TryParseName(accessApprovalRequestName, out resourceName))
            {
                result = FromOrganizationLocationCustomerWorkloadAccessApprovalRequest(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(accessApprovalRequestName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AccessApprovalRequestName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accessApprovalRequestId = null, string customerId = null, string locationId = null, string organizationId = null, string workloadId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccessApprovalRequestId = accessApprovalRequestId;
            CustomerId = customerId;
            LocationId = locationId;
            OrganizationId = organizationId;
            WorkloadId = workloadId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AccessApprovalRequestName"/> class from the component parts of
        /// pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/accessApprovalRequests/{access_approval_request}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accessApprovalRequestId">
        /// The <c>AccessApprovalRequest</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public AccessApprovalRequestName(string organizationId, string locationId, string customerId, string workloadId, string accessApprovalRequestId) : this(ResourceNameType.OrganizationLocationCustomerWorkloadAccessApprovalRequest, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), workloadId: gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)), accessApprovalRequestId: gax::GaxPreconditions.CheckNotNullOrEmpty(accessApprovalRequestId, nameof(accessApprovalRequestId)))
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
        /// The <c>AccessApprovalRequest</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string AccessApprovalRequestId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

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
        /// The <c>Workload</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string WorkloadId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationLocationCustomerWorkloadAccessApprovalRequest: return s_organizationLocationCustomerWorkloadAccessApprovalRequest.Expand(OrganizationId, LocationId, CustomerId, WorkloadId, AccessApprovalRequestId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AccessApprovalRequestName);

        /// <inheritdoc/>
        public bool Equals(AccessApprovalRequestName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AccessApprovalRequestName a, AccessApprovalRequestName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AccessApprovalRequestName a, AccessApprovalRequestName b) => !(a == b);
    }

    public partial class AccessApprovalRequest
    {
        /// <summary>
        /// <see cref="gccv::AccessApprovalRequestName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::AccessApprovalRequestName AccessApprovalRequestName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::AccessApprovalRequestName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAccessApprovalRequestsRequest
    {
        /// <summary>
        /// <see cref="WorkloadName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public WorkloadName ParentAsWorkloadName
        {
            get => string.IsNullOrEmpty(Parent) ? null : WorkloadName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
