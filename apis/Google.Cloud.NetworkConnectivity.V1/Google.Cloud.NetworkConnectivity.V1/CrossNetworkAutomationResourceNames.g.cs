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
using gcnv = Google.Cloud.NetworkConnectivity.V1;
using sys = System;

namespace Google.Cloud.NetworkConnectivity.V1
{
    /// <summary>Resource name for the <c>ServiceConnectionMap</c> resource.</summary>
    public sealed partial class ServiceConnectionMapName : gax::IResourceName, sys::IEquatable<ServiceConnectionMapName>
    {
        /// <summary>The possible contents of <see cref="ServiceConnectionMapName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/serviceConnectionMaps/{service_connection_map}</c>.
            /// </summary>
            ProjectLocationServiceConnectionMap = 1,
        }

        private static gax::PathTemplate s_projectLocationServiceConnectionMap = new gax::PathTemplate("projects/{project}/locations/{location}/serviceConnectionMaps/{service_connection_map}");

        /// <summary>Creates a <see cref="ServiceConnectionMapName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceConnectionMapName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceConnectionMapName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceConnectionMapName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceConnectionMapName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/serviceConnectionMaps/{service_connection_map}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceConnectionMapId">
        /// The <c>ServiceConnectionMap</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ServiceConnectionMapName"/> constructed from the provided ids.
        /// </returns>
        public static ServiceConnectionMapName FromProjectLocationServiceConnectionMap(string projectId, string locationId, string serviceConnectionMapId) =>
            new ServiceConnectionMapName(ResourceNameType.ProjectLocationServiceConnectionMap, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceConnectionMapId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceConnectionMapId, nameof(serviceConnectionMapId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceConnectionMapName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceConnectionMaps/{service_connection_map}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceConnectionMapId">
        /// The <c>ServiceConnectionMap</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ServiceConnectionMapName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceConnectionMaps/{service_connection_map}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string serviceConnectionMapId) =>
            FormatProjectLocationServiceConnectionMap(projectId, locationId, serviceConnectionMapId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceConnectionMapName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceConnectionMaps/{service_connection_map}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceConnectionMapId">
        /// The <c>ServiceConnectionMap</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ServiceConnectionMapName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceConnectionMaps/{service_connection_map}</c>.
        /// </returns>
        public static string FormatProjectLocationServiceConnectionMap(string projectId, string locationId, string serviceConnectionMapId) =>
            s_projectLocationServiceConnectionMap.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceConnectionMapId, nameof(serviceConnectionMapId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceConnectionMapName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceConnectionMaps/{service_connection_map}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceConnectionMapName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceConnectionMapName"/> if successful.</returns>
        public static ServiceConnectionMapName Parse(string serviceConnectionMapName) =>
            Parse(serviceConnectionMapName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceConnectionMapName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceConnectionMaps/{service_connection_map}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceConnectionMapName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceConnectionMapName"/> if successful.</returns>
        public static ServiceConnectionMapName Parse(string serviceConnectionMapName, bool allowUnparsed) =>
            TryParse(serviceConnectionMapName, allowUnparsed, out ServiceConnectionMapName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceConnectionMapName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceConnectionMaps/{service_connection_map}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceConnectionMapName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceConnectionMapName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceConnectionMapName, out ServiceConnectionMapName result) =>
            TryParse(serviceConnectionMapName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceConnectionMapName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceConnectionMaps/{service_connection_map}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceConnectionMapName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceConnectionMapName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceConnectionMapName, bool allowUnparsed, out ServiceConnectionMapName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceConnectionMapName, nameof(serviceConnectionMapName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationServiceConnectionMap.TryParseName(serviceConnectionMapName, out resourceName))
            {
                result = FromProjectLocationServiceConnectionMap(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceConnectionMapName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceConnectionMapName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string serviceConnectionMapId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ServiceConnectionMapId = serviceConnectionMapId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceConnectionMapName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/serviceConnectionMaps/{service_connection_map}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceConnectionMapId">
        /// The <c>ServiceConnectionMap</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ServiceConnectionMapName(string projectId, string locationId, string serviceConnectionMapId) : this(ResourceNameType.ProjectLocationServiceConnectionMap, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceConnectionMapId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceConnectionMapId, nameof(serviceConnectionMapId)))
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
        /// The <c>ServiceConnectionMap</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ServiceConnectionMapId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationServiceConnectionMap: return s_projectLocationServiceConnectionMap.Expand(ProjectId, LocationId, ServiceConnectionMapId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceConnectionMapName);

        /// <inheritdoc/>
        public bool Equals(ServiceConnectionMapName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServiceConnectionMapName a, ServiceConnectionMapName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServiceConnectionMapName a, ServiceConnectionMapName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ServiceConnectionPolicy</c> resource.</summary>
    public sealed partial class ServiceConnectionPolicyName : gax::IResourceName, sys::IEquatable<ServiceConnectionPolicyName>
    {
        /// <summary>The possible contents of <see cref="ServiceConnectionPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/serviceConnectionPolicies/{service_connection_policy}</c>.
            /// </summary>
            ProjectLocationServiceConnectionPolicy = 1,
        }

        private static gax::PathTemplate s_projectLocationServiceConnectionPolicy = new gax::PathTemplate("projects/{project}/locations/{location}/serviceConnectionPolicies/{service_connection_policy}");

        /// <summary>Creates a <see cref="ServiceConnectionPolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceConnectionPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceConnectionPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceConnectionPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceConnectionPolicyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/serviceConnectionPolicies/{service_connection_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceConnectionPolicyId">
        /// The <c>ServiceConnectionPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ServiceConnectionPolicyName"/> constructed from the provided ids.
        /// </returns>
        public static ServiceConnectionPolicyName FromProjectLocationServiceConnectionPolicy(string projectId, string locationId, string serviceConnectionPolicyId) =>
            new ServiceConnectionPolicyName(ResourceNameType.ProjectLocationServiceConnectionPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceConnectionPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceConnectionPolicyId, nameof(serviceConnectionPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceConnectionPolicyName"/> with
        /// pattern <c>projects/{project}/locations/{location}/serviceConnectionPolicies/{service_connection_policy}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceConnectionPolicyId">
        /// The <c>ServiceConnectionPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ServiceConnectionPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceConnectionPolicies/{service_connection_policy}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string serviceConnectionPolicyId) =>
            FormatProjectLocationServiceConnectionPolicy(projectId, locationId, serviceConnectionPolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceConnectionPolicyName"/> with
        /// pattern <c>projects/{project}/locations/{location}/serviceConnectionPolicies/{service_connection_policy}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceConnectionPolicyId">
        /// The <c>ServiceConnectionPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ServiceConnectionPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceConnectionPolicies/{service_connection_policy}</c>.
        /// </returns>
        public static string FormatProjectLocationServiceConnectionPolicy(string projectId, string locationId, string serviceConnectionPolicyId) =>
            s_projectLocationServiceConnectionPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceConnectionPolicyId, nameof(serviceConnectionPolicyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceConnectionPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceConnectionPolicies/{service_connection_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceConnectionPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceConnectionPolicyName"/> if successful.</returns>
        public static ServiceConnectionPolicyName Parse(string serviceConnectionPolicyName) =>
            Parse(serviceConnectionPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceConnectionPolicyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceConnectionPolicies/{service_connection_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceConnectionPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceConnectionPolicyName"/> if successful.</returns>
        public static ServiceConnectionPolicyName Parse(string serviceConnectionPolicyName, bool allowUnparsed) =>
            TryParse(serviceConnectionPolicyName, allowUnparsed, out ServiceConnectionPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceConnectionPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceConnectionPolicies/{service_connection_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceConnectionPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceConnectionPolicyName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceConnectionPolicyName, out ServiceConnectionPolicyName result) =>
            TryParse(serviceConnectionPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceConnectionPolicyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceConnectionPolicies/{service_connection_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceConnectionPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceConnectionPolicyName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceConnectionPolicyName, bool allowUnparsed, out ServiceConnectionPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceConnectionPolicyName, nameof(serviceConnectionPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationServiceConnectionPolicy.TryParseName(serviceConnectionPolicyName, out resourceName))
            {
                result = FromProjectLocationServiceConnectionPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceConnectionPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceConnectionPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string serviceConnectionPolicyId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ServiceConnectionPolicyId = serviceConnectionPolicyId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceConnectionPolicyName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/serviceConnectionPolicies/{service_connection_policy}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceConnectionPolicyId">
        /// The <c>ServiceConnectionPolicy</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ServiceConnectionPolicyName(string projectId, string locationId, string serviceConnectionPolicyId) : this(ResourceNameType.ProjectLocationServiceConnectionPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceConnectionPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceConnectionPolicyId, nameof(serviceConnectionPolicyId)))
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
        /// The <c>ServiceConnectionPolicy</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ServiceConnectionPolicyId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationServiceConnectionPolicy: return s_projectLocationServiceConnectionPolicy.Expand(ProjectId, LocationId, ServiceConnectionPolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceConnectionPolicyName);

        /// <inheritdoc/>
        public bool Equals(ServiceConnectionPolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServiceConnectionPolicyName a, ServiceConnectionPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServiceConnectionPolicyName a, ServiceConnectionPolicyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ServiceClass</c> resource.</summary>
    public sealed partial class ServiceClassName : gax::IResourceName, sys::IEquatable<ServiceClassName>
    {
        /// <summary>The possible contents of <see cref="ServiceClassName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/serviceClasses/{service_class}</c>
            /// .
            /// </summary>
            ProjectLocationServiceClass = 1,
        }

        private static gax::PathTemplate s_projectLocationServiceClass = new gax::PathTemplate("projects/{project}/locations/{location}/serviceClasses/{service_class}");

        /// <summary>Creates a <see cref="ServiceClassName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceClassName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceClassName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceClassName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceClassName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/serviceClasses/{service_class}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceClassId">The <c>ServiceClass</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceClassName"/> constructed from the provided ids.</returns>
        public static ServiceClassName FromProjectLocationServiceClass(string projectId, string locationId, string serviceClassId) =>
            new ServiceClassName(ResourceNameType.ProjectLocationServiceClass, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceClassId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceClassId, nameof(serviceClassId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceClassName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceClasses/{service_class}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceClassId">The <c>ServiceClass</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceClassName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceClasses/{service_class}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string serviceClassId) =>
            FormatProjectLocationServiceClass(projectId, locationId, serviceClassId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceClassName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceClasses/{service_class}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceClassId">The <c>ServiceClass</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceClassName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceClasses/{service_class}</c>.
        /// </returns>
        public static string FormatProjectLocationServiceClass(string projectId, string locationId, string serviceClassId) =>
            s_projectLocationServiceClass.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceClassId, nameof(serviceClassId)));

        /// <summary>Parses the given resource name string into a new <see cref="ServiceClassName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/serviceClasses/{service_class}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceClassName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceClassName"/> if successful.</returns>
        public static ServiceClassName Parse(string serviceClassName) => Parse(serviceClassName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceClassName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/serviceClasses/{service_class}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceClassName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceClassName"/> if successful.</returns>
        public static ServiceClassName Parse(string serviceClassName, bool allowUnparsed) =>
            TryParse(serviceClassName, allowUnparsed, out ServiceClassName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceClassName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/serviceClasses/{service_class}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceClassName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceClassName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceClassName, out ServiceClassName result) =>
            TryParse(serviceClassName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceClassName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/serviceClasses/{service_class}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceClassName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceClassName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceClassName, bool allowUnparsed, out ServiceClassName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceClassName, nameof(serviceClassName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationServiceClass.TryParseName(serviceClassName, out resourceName))
            {
                result = FromProjectLocationServiceClass(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceClassName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceClassName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string serviceClassId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ServiceClassId = serviceClassId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceClassName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/serviceClasses/{service_class}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceClassId">The <c>ServiceClass</c> ID. Must not be <c>null</c> or empty.</param>
        public ServiceClassName(string projectId, string locationId, string serviceClassId) : this(ResourceNameType.ProjectLocationServiceClass, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceClassId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceClassId, nameof(serviceClassId)))
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
        /// The <c>ServiceClass</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ServiceClassId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationServiceClass: return s_projectLocationServiceClass.Expand(ProjectId, LocationId, ServiceClassId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceClassName);

        /// <inheritdoc/>
        public bool Equals(ServiceClassName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServiceClassName a, ServiceClassName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServiceClassName a, ServiceClassName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ServiceConnectionToken</c> resource.</summary>
    public sealed partial class ServiceConnectionTokenName : gax::IResourceName, sys::IEquatable<ServiceConnectionTokenName>
    {
        /// <summary>The possible contents of <see cref="ServiceConnectionTokenName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/serviceConnectionTokens/{service_connection_token}</c>.
            /// </summary>
            ProjectLocationServiceConnectionToken = 1,
        }

        private static gax::PathTemplate s_projectLocationServiceConnectionToken = new gax::PathTemplate("projects/{project}/locations/{location}/serviceConnectionTokens/{service_connection_token}");

        /// <summary>Creates a <see cref="ServiceConnectionTokenName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceConnectionTokenName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceConnectionTokenName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceConnectionTokenName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceConnectionTokenName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/serviceConnectionTokens/{service_connection_token}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceConnectionTokenId">
        /// The <c>ServiceConnectionToken</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ServiceConnectionTokenName"/> constructed from the provided ids.
        /// </returns>
        public static ServiceConnectionTokenName FromProjectLocationServiceConnectionToken(string projectId, string locationId, string serviceConnectionTokenId) =>
            new ServiceConnectionTokenName(ResourceNameType.ProjectLocationServiceConnectionToken, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceConnectionTokenId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceConnectionTokenId, nameof(serviceConnectionTokenId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceConnectionTokenName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceConnectionTokens/{service_connection_token}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceConnectionTokenId">
        /// The <c>ServiceConnectionToken</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ServiceConnectionTokenName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceConnectionTokens/{service_connection_token}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string serviceConnectionTokenId) =>
            FormatProjectLocationServiceConnectionToken(projectId, locationId, serviceConnectionTokenId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceConnectionTokenName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceConnectionTokens/{service_connection_token}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceConnectionTokenId">
        /// The <c>ServiceConnectionToken</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ServiceConnectionTokenName"/> with pattern
        /// <c>projects/{project}/locations/{location}/serviceConnectionTokens/{service_connection_token}</c>.
        /// </returns>
        public static string FormatProjectLocationServiceConnectionToken(string projectId, string locationId, string serviceConnectionTokenId) =>
            s_projectLocationServiceConnectionToken.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceConnectionTokenId, nameof(serviceConnectionTokenId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceConnectionTokenName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceConnectionTokens/{service_connection_token}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceConnectionTokenName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceConnectionTokenName"/> if successful.</returns>
        public static ServiceConnectionTokenName Parse(string serviceConnectionTokenName) =>
            Parse(serviceConnectionTokenName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceConnectionTokenName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceConnectionTokens/{service_connection_token}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceConnectionTokenName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceConnectionTokenName"/> if successful.</returns>
        public static ServiceConnectionTokenName Parse(string serviceConnectionTokenName, bool allowUnparsed) =>
            TryParse(serviceConnectionTokenName, allowUnparsed, out ServiceConnectionTokenName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceConnectionTokenName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceConnectionTokens/{service_connection_token}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceConnectionTokenName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceConnectionTokenName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceConnectionTokenName, out ServiceConnectionTokenName result) =>
            TryParse(serviceConnectionTokenName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceConnectionTokenName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/serviceConnectionTokens/{service_connection_token}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceConnectionTokenName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceConnectionTokenName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceConnectionTokenName, bool allowUnparsed, out ServiceConnectionTokenName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceConnectionTokenName, nameof(serviceConnectionTokenName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationServiceConnectionToken.TryParseName(serviceConnectionTokenName, out resourceName))
            {
                result = FromProjectLocationServiceConnectionToken(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceConnectionTokenName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceConnectionTokenName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string serviceConnectionTokenId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ServiceConnectionTokenId = serviceConnectionTokenId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceConnectionTokenName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/serviceConnectionTokens/{service_connection_token}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceConnectionTokenId">
        /// The <c>ServiceConnectionToken</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ServiceConnectionTokenName(string projectId, string locationId, string serviceConnectionTokenId) : this(ResourceNameType.ProjectLocationServiceConnectionToken, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceConnectionTokenId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceConnectionTokenId, nameof(serviceConnectionTokenId)))
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
        /// The <c>ServiceConnectionToken</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ServiceConnectionTokenId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationServiceConnectionToken: return s_projectLocationServiceConnectionToken.Expand(ProjectId, LocationId, ServiceConnectionTokenId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceConnectionTokenName);

        /// <inheritdoc/>
        public bool Equals(ServiceConnectionTokenName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServiceConnectionTokenName a, ServiceConnectionTokenName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServiceConnectionTokenName a, ServiceConnectionTokenName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Project</c> resource.</summary>
    public sealed partial class ProjectName : gax::IResourceName, sys::IEquatable<ProjectName>
    {
        /// <summary>The possible contents of <see cref="ProjectName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}</c>.</summary>
            Project = 1,
        }

        private static gax::PathTemplate s_project = new gax::PathTemplate("projects/{project}");

        /// <summary>Creates a <see cref="ProjectName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProjectName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProjectName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProjectName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="ProjectName"/> with the pattern <c>projects/{project}</c>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProjectName"/> constructed from the provided ids.</returns>
        public static ProjectName FromProject(string projectId) =>
            new ProjectName(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProjectName"/> with pattern
        /// <c>projects/{project}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProjectName"/> with pattern <c>projects/{project}</c>.
        /// </returns>
        public static string Format(string projectId) => FormatProject(projectId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProjectName"/> with pattern
        /// <c>projects/{project}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProjectName"/> with pattern <c>projects/{project}</c>.
        /// </returns>
        public static string FormatProject(string projectId) =>
            s_project.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)));

        /// <summary>Parses the given resource name string into a new <see cref="ProjectName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}</c></description></item></list>
        /// </remarks>
        /// <param name="projectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProjectName"/> if successful.</returns>
        public static ProjectName Parse(string projectName) => Parse(projectName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProjectName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="projectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProjectName"/> if successful.</returns>
        public static ProjectName Parse(string projectName, bool allowUnparsed) =>
            TryParse(projectName, allowUnparsed, out ProjectName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProjectName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}</c></description></item></list>
        /// </remarks>
        /// <param name="projectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProjectName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectName, out ProjectName result) => TryParse(projectName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProjectName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>projects/{project}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="projectName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProjectName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string projectName, bool allowUnparsed, out ProjectName result)
        {
            gax::GaxPreconditions.CheckNotNull(projectName, nameof(projectName));
            gax::TemplatedResourceName resourceName;
            if (s_project.TryParseName(projectName, out resourceName))
            {
                result = FromProject(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(projectName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProjectName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProjectName"/> class from the component parts of pattern
        /// <c>projects/{project}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        public ProjectName(string projectId) : this(ResourceNameType.Project, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Project: return s_project.Expand(ProjectId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProjectName);

        /// <inheritdoc/>
        public bool Equals(ProjectName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProjectName a, ProjectName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProjectName a, ProjectName b) => !(a == b);
    }

    public partial class ServiceConnectionMap
    {
        /// <summary>
        /// <see cref="gcnv::ServiceConnectionMapName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ServiceConnectionMapName ServiceConnectionMapName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ServiceConnectionMapName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class ProducerPscConfig
            {
                /// <summary>
                /// <see cref="ServiceAttachmentName"/>-typed view over the <see cref="ServiceAttachmentUri"/> resource
                /// name property.
                /// </summary>
                public ServiceAttachmentName ServiceAttachmentUriAsServiceAttachmentName
                {
                    get => string.IsNullOrEmpty(ServiceAttachmentUri) ? null : ServiceAttachmentName.Parse(ServiceAttachmentUri, allowUnparsed: true);
                    set => ServiceAttachmentUri = value?.ToString() ?? "";
                }
            }

            public partial class ConsumerPscConfig
            {
                /// <summary>
                /// <see cref="NetworkName"/>-typed view over the <see cref="Network"/> resource name property.
                /// </summary>
                public NetworkName NetworkAsNetworkName
                {
                    get => string.IsNullOrEmpty(Network) ? null : NetworkName.Parse(Network, allowUnparsed: true);
                    set => Network = value?.ToString() ?? "";
                }

                /// <summary>
                /// <see cref="ProjectName"/>-typed view over the <see cref="ConsumerInstanceProject"/> resource name
                /// property.
                /// </summary>
                public ProjectName ConsumerInstanceProjectAsProjectName
                {
                    get => string.IsNullOrEmpty(ConsumerInstanceProject) ? null : ProjectName.Parse(ConsumerInstanceProject, allowUnparsed: true);
                    set => ConsumerInstanceProject = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class ListServiceConnectionMapsRequest
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

    public partial class GetServiceConnectionMapRequest
    {
        /// <summary>
        /// <see cref="gcnv::ServiceConnectionMapName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ServiceConnectionMapName ServiceConnectionMapName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ServiceConnectionMapName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateServiceConnectionMapRequest
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

    public partial class DeleteServiceConnectionMapRequest
    {
        /// <summary>
        /// <see cref="gcnv::ServiceConnectionMapName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ServiceConnectionMapName ServiceConnectionMapName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ServiceConnectionMapName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ServiceConnectionPolicy
    {
        /// <summary>
        /// <see cref="gcnv::ServiceConnectionPolicyName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::ServiceConnectionPolicyName ServiceConnectionPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ServiceConnectionPolicyName.Parse(Name, allowUnparsed: true);
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

        public partial class Types
        {
            public partial class PscConfig
            {
                /// <summary>
                /// <see cref="SubnetworkName"/>-typed view over the <see cref="Subnetworks"/> resource name property.
                /// </summary>
                public gax::ResourceNameList<SubnetworkName> SubnetworksAsSubnetworkNames
                {
                    get => new gax::ResourceNameList<SubnetworkName>(Subnetworks, s => string.IsNullOrEmpty(s) ? null : SubnetworkName.Parse(s, allowUnparsed: true));
                }
            }
        }
    }

    public partial class ListServiceConnectionPoliciesRequest
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

    public partial class GetServiceConnectionPolicyRequest
    {
        /// <summary>
        /// <see cref="gcnv::ServiceConnectionPolicyName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::ServiceConnectionPolicyName ServiceConnectionPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ServiceConnectionPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateServiceConnectionPolicyRequest
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

    public partial class DeleteServiceConnectionPolicyRequest
    {
        /// <summary>
        /// <see cref="gcnv::ServiceConnectionPolicyName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::ServiceConnectionPolicyName ServiceConnectionPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ServiceConnectionPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ServiceClass
    {
        /// <summary>
        /// <see cref="gcnv::ServiceClassName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ServiceClassName ServiceClassName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ServiceClassName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListServiceClassesRequest
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

    public partial class GetServiceClassRequest
    {
        /// <summary>
        /// <see cref="gcnv::ServiceClassName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ServiceClassName ServiceClassName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ServiceClassName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteServiceClassRequest
    {
        /// <summary>
        /// <see cref="gcnv::ServiceClassName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ServiceClassName ServiceClassName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ServiceClassName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ServiceConnectionToken
    {
        /// <summary>
        /// <see cref="gcnv::ServiceConnectionTokenName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::ServiceConnectionTokenName ServiceConnectionTokenName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ServiceConnectionTokenName.Parse(Name, allowUnparsed: true);
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

    public partial class ListServiceConnectionTokensRequest
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

    public partial class GetServiceConnectionTokenRequest
    {
        /// <summary>
        /// <see cref="gcnv::ServiceConnectionTokenName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::ServiceConnectionTokenName ServiceConnectionTokenName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ServiceConnectionTokenName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateServiceConnectionTokenRequest
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

    public partial class DeleteServiceConnectionTokenRequest
    {
        /// <summary>
        /// <see cref="gcnv::ServiceConnectionTokenName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcnv::ServiceConnectionTokenName ServiceConnectionTokenName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ServiceConnectionTokenName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
