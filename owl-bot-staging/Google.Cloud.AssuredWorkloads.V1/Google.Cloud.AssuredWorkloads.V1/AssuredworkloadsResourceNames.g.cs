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
using gcav = Google.Cloud.AssuredWorkloads.V1;
using sys = System;

namespace Google.Cloud.AssuredWorkloads.V1
{
    /// <summary>Resource name for the <c>Workload</c> resource.</summary>
    public sealed partial class WorkloadName : gax::IResourceName, sys::IEquatable<WorkloadName>
    {
        /// <summary>The possible contents of <see cref="WorkloadName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/locations/{location}/workloads/{workload}</c>
            /// .
            /// </summary>
            OrganizationLocationWorkload = 1,
        }

        private static gax::PathTemplate s_organizationLocationWorkload = new gax::PathTemplate("organizations/{organization}/locations/{location}/workloads/{workload}");

        /// <summary>Creates a <see cref="WorkloadName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="WorkloadName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static WorkloadName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new WorkloadName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="WorkloadName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/workloads/{workload}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="WorkloadName"/> constructed from the provided ids.</returns>
        public static WorkloadName FromOrganizationLocationWorkload(string organizationId, string locationId, string workloadId) =>
            new WorkloadName(ResourceNameType.OrganizationLocationWorkload, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workloadId: gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkloadName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/workloads/{workload}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkloadName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/workloads/{workload}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId, string workloadId) =>
            FormatOrganizationLocationWorkload(organizationId, locationId, workloadId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="WorkloadName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/workloads/{workload}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="WorkloadName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/workloads/{workload}</c>.
        /// </returns>
        public static string FormatOrganizationLocationWorkload(string organizationId, string locationId, string workloadId) =>
            s_organizationLocationWorkload.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)));

        /// <summary>Parses the given resource name string into a new <see cref="WorkloadName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/workloads/{workload}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workloadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="WorkloadName"/> if successful.</returns>
        public static WorkloadName Parse(string workloadName) => Parse(workloadName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="WorkloadName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/workloads/{workload}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workloadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="WorkloadName"/> if successful.</returns>
        public static WorkloadName Parse(string workloadName, bool allowUnparsed) =>
            TryParse(workloadName, allowUnparsed, out WorkloadName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkloadName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/workloads/{workload}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="workloadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkloadName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workloadName, out WorkloadName result) => TryParse(workloadName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="WorkloadName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/workloads/{workload}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="workloadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="WorkloadName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string workloadName, bool allowUnparsed, out WorkloadName result)
        {
            gax::GaxPreconditions.CheckNotNull(workloadName, nameof(workloadName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationWorkload.TryParseName(workloadName, out resourceName))
            {
                result = FromOrganizationLocationWorkload(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(workloadName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private WorkloadName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string organizationId = null, string workloadId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OrganizationId = organizationId;
            WorkloadId = workloadId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="WorkloadName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/locations/{location}/workloads/{workload}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        public WorkloadName(string organizationId, string locationId, string workloadId) : this(ResourceNameType.OrganizationLocationWorkload, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workloadId: gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)))
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
                case ResourceNameType.OrganizationLocationWorkload: return s_organizationLocationWorkload.Expand(OrganizationId, LocationId, WorkloadId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as WorkloadName);

        /// <inheritdoc/>
        public bool Equals(WorkloadName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(WorkloadName a, WorkloadName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(WorkloadName a, WorkloadName b) => !(a == b);
    }

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
            /// <c>organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}</c>.
            /// </summary>
            OrganizationLocationWorkloadViolation = 1,
        }

        private static gax::PathTemplate s_organizationLocationWorkloadViolation = new gax::PathTemplate("organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}");

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
        /// <c>organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="violationId">The <c>Violation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ViolationName"/> constructed from the provided ids.</returns>
        public static ViolationName FromOrganizationLocationWorkloadViolation(string organizationId, string locationId, string workloadId, string violationId) =>
            new ViolationName(ResourceNameType.OrganizationLocationWorkloadViolation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workloadId: gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)), violationId: gax::GaxPreconditions.CheckNotNullOrEmpty(violationId, nameof(violationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ViolationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="violationId">The <c>Violation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ViolationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId, string workloadId, string violationId) =>
            FormatOrganizationLocationWorkloadViolation(organizationId, locationId, workloadId, violationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ViolationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="violationId">The <c>Violation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ViolationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}</c>.
        /// </returns>
        public static string FormatOrganizationLocationWorkloadViolation(string organizationId, string locationId, string workloadId, string violationId) =>
            s_organizationLocationWorkloadViolation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)), gax::GaxPreconditions.CheckNotNullOrEmpty(violationId, nameof(violationId)));

        /// <summary>Parses the given resource name string into a new <see cref="ViolationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}</c>
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
        /// <c>organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}</c>
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
        /// <c>organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}</c>
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
        /// <c>organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}</c>
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
            if (s_organizationLocationWorkloadViolation.TryParseName(violationName, out resourceName))
            {
                result = FromOrganizationLocationWorkloadViolation(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
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

        private ViolationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string organizationId = null, string violationId = null, string workloadId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OrganizationId = organizationId;
            ViolationId = violationId;
            WorkloadId = workloadId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ViolationName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/locations/{location}/workloads/{workload}/violations/{violation}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="workloadId">The <c>Workload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="violationId">The <c>Violation</c> ID. Must not be <c>null</c> or empty.</param>
        public ViolationName(string organizationId, string locationId, string workloadId, string violationId) : this(ResourceNameType.OrganizationLocationWorkloadViolation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), workloadId: gax::GaxPreconditions.CheckNotNullOrEmpty(workloadId, nameof(workloadId)), violationId: gax::GaxPreconditions.CheckNotNullOrEmpty(violationId, nameof(violationId)))
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
                case ResourceNameType.OrganizationLocationWorkloadViolation: return s_organizationLocationWorkloadViolation.Expand(OrganizationId, LocationId, WorkloadId, ViolationId);
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

    /// <summary>Resource name for the <c>Location</c> resource.</summary>
    public sealed partial class LocationName : gax::IResourceName, sys::IEquatable<LocationName>
    {
        /// <summary>The possible contents of <see cref="LocationName"/>.</summary>
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

        /// <summary>Creates a <see cref="LocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LocationName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static LocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LocationName"/> with the pattern <c>organizations/{organization}/locations/{location}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LocationName"/> constructed from the provided ids.</returns>
        public static LocationName FromOrganizationLocation(string organizationId, string locationId) =>
            new LocationName(ResourceNameType.OrganizationLocation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId) =>
            FormatOrganizationLocation(organizationId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </returns>
        public static string FormatOrganizationLocation(string organizationId, string locationId) =>
            s_organizationLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>Parses the given resource name string into a new <see cref="LocationName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="locationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationName"/> if successful.</returns>
        public static LocationName Parse(string locationName) => Parse(locationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LocationName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="locationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LocationName"/> if successful.</returns>
        public static LocationName Parse(string locationName, bool allowUnparsed) =>
            TryParse(locationName, allowUnparsed, out LocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="locationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationName, out LocationName result) => TryParse(locationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="locationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationName, bool allowUnparsed, out LocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocation.TryParseName(locationName, out resourceName))
            {
                result = FromOrganizationLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(locationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string organizationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LocationName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/locations/{location}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public LocationName(string organizationId, string locationId) : this(ResourceNameType.OrganizationLocation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
        public override bool Equals(object obj) => Equals(obj as LocationName);

        /// <inheritdoc/>
        public bool Equals(LocationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LocationName a, LocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LocationName a, LocationName b) => !(a == b);
    }

    public partial class CreateWorkloadRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteWorkloadRequest
    {
        /// <summary>
        /// <see cref="gcav::WorkloadName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::WorkloadName WorkloadName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::WorkloadName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetWorkloadRequest
    {
        /// <summary>
        /// <see cref="gcav::WorkloadName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::WorkloadName WorkloadName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::WorkloadName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListWorkloadsRequest
    {
        /// <summary>
        /// <see cref="LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class Workload
    {
        /// <summary>
        /// <see cref="gcav::WorkloadName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::WorkloadName WorkloadName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::WorkloadName.Parse(Name, allowUnparsed: true);
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
        /// <see cref="gcav::ViolationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ViolationName ViolationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ViolationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Violation
    {
        /// <summary>
        /// <see cref="gcav::ViolationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ViolationName ViolationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ViolationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
