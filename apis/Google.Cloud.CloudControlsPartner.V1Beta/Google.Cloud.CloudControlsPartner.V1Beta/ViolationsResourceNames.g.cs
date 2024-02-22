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
using gccv = Google.Cloud.CloudControlsPartner.V1Beta;
using sys = System;

namespace Google.Cloud.CloudControlsPartner.V1Beta
{
    /// <summary>Resource name for the <c>Violation</c> resource.</summary>
    public sealed partial class ViolationName : gax::IResourceName, sys::IEquatable<ViolationName>
    {
        /// <summary>The possible contents of <see cref="ViolationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}</c>
            /// .
            /// </summary>
            OrganizationLocationCustomerWorkloadViolation = 1,
        }

        private static gax::PathTemplate s_organizationLocationCustomerWorkloadViolation = new gax::PathTemplate("organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}");

        /// <summary>Creates a <see cref="ViolationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ViolationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ViolationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ViolationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ViolationName"/> with the pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="violationId">The <c>Violation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ViolationName"/> constructed from the provided ids.</returns>
        public static ViolationName FromOrganizationLocationCustomerWorkloadViolation(string organizationId, string locationId, string customerId, string workloadId, string violationId) =>
            new ViolationName(ResourceNameType.OrganizationLocationCustomerWorkloadViolation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), workloadId: gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)), violationId: gax::GaxPreconditions.CheckNotNullOrEmpty(violationId, nameof(violationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ViolationName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="violationId">The <c>Violation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ViolationName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}</c>
        /// .
        /// </returns>
        public static string Format(string organizationId, string locationId, string customerId, string workloadId, string violationId) =>
            FormatOrganizationLocationCustomerWorkloadViolation(organizationId, locationId, customerId, workloadId, violationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ViolationName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="violationId">The <c>Violation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ViolationName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationLocationCustomerWorkloadViolation(string organizationId, string locationId, string customerId, string workloadId, string violationId) =>
            s_organizationLocationCustomerWorkloadViolation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)), gax::GaxPreconditions.CheckNotNullOrEmpty(violationId, nameof(violationId)));

        /// <summary>Parses the given resource name string into a new <see cref="ViolationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="violationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ViolationName"/> if successful.</returns>
        public static ViolationName Parse(string violationName) => Parse(violationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ViolationName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="violationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ViolationName"/> if successful.</returns>
        public static ViolationName Parse(string violationName, bool allowUnparsed) =>
            TryParse(violationName, allowUnparsed, out ViolationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ViolationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="violationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ViolationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string violationName, out ViolationName result) => TryParse(violationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ViolationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="violationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ViolationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string violationName, bool allowUnparsed, out ViolationName result)
        {
            gax::GaxPreconditions.CheckNotNull(violationName, nameof(violationName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationCustomerWorkloadViolation.TryParseName(violationName, out resourceName))
            {
                result = FromOrganizationLocationCustomerWorkloadViolation(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(violationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ViolationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string locationId = null, string organizationId = null, string violationId = null, string workloadId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ViolationId = violationId;
            WorkloadId = workloadId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ViolationName"/> class from the component parts of pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/customers/{customer}/workloads/{workload}/violations/{violation}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="violationId">The <c>Violation</c> ID. Must not be <c>null</c> or empty.</param>
        public ViolationName(string organizationId, string locationId, string customerId, string workloadId, string violationId) : this(ResourceNameType.OrganizationLocationCustomerWorkloadViolation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), workloadId: gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)), violationId: gax::GaxPreconditions.CheckNotNullOrEmpty(violationId, nameof(violationId)))
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
        /// The <c>Violation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ViolationId { get; }

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
                case ResourceNameType.OrganizationLocationCustomerWorkloadViolation: return s_organizationLocationCustomerWorkloadViolation.Expand(OrganizationId, LocationId, CustomerId, WorkloadId, ViolationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ViolationName);

        /// <inheritdoc/>
        public bool Equals(ViolationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ViolationName a, ViolationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ViolationName a, ViolationName b) => !(a == b);
    }

    public partial class Violation
    {
        /// <summary>
        /// <see cref="gccv::ViolationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ViolationName ViolationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ViolationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListViolationsRequest
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

    public partial class GetViolationRequest
    {
        /// <summary>
        /// <see cref="gccv::ViolationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ViolationName ViolationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ViolationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
