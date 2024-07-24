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
using gcav = Google.Cloud.AppHub.V1;
using sys = System;

namespace Google.Cloud.AppHub.V1
{
    /// <summary>Resource name for the <c>Service</c> resource.</summary>
    public sealed partial class ServiceName : gax::IResourceName, sys::IEquatable<ServiceName>
    {
        /// <summary>The possible contents of <see cref="ServiceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/applications/{application}/services/{service}</c>.
            /// </summary>
            ProjectLocationApplicationService = 1,
        }

        private static gax::PathTemplate s_projectLocationApplicationService = new gax::PathTemplate("projects/{project}/locations/{location}/applications/{application}/services/{service}");

        /// <summary>Creates a <see cref="ServiceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ServiceName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ServiceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ServiceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ServiceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/services/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ServiceName"/> constructed from the provided ids.</returns>
        public static ServiceName FromProjectLocationApplicationService(string projectId, string locationId, string applicationId, string serviceId) =>
            new ServiceName(ResourceNameType.ProjectLocationApplicationService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), applicationId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/services/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/services/{service}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string applicationId, string serviceId) =>
            FormatProjectLocationApplicationService(projectId, locationId, applicationId, serviceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/services/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/services/{service}</c>.
        /// </returns>
        public static string FormatProjectLocationApplicationService(string projectId, string locationId, string applicationId, string serviceId) =>
            s_projectLocationApplicationService.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>Parses the given resource name string into a new <see cref="ServiceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/applications/{application}/services/{service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ServiceName"/> if successful.</returns>
        public static ServiceName Parse(string serviceName) => Parse(serviceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ServiceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/applications/{application}/services/{service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ServiceName"/> if successful.</returns>
        public static ServiceName Parse(string serviceName, bool allowUnparsed) =>
            TryParse(serviceName, allowUnparsed, out ServiceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/applications/{application}/services/{service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceName, out ServiceName result) => TryParse(serviceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ServiceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/applications/{application}/services/{service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="serviceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string serviceName, bool allowUnparsed, out ServiceName result)
        {
            gax::GaxPreconditions.CheckNotNull(serviceName, nameof(serviceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationApplicationService.TryParseName(serviceName, out resourceName))
            {
                result = FromProjectLocationApplicationService(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(serviceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ServiceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string applicationId = null, string locationId = null, string projectId = null, string serviceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApplicationId = applicationId;
            LocationId = locationId;
            ProjectId = projectId;
            ServiceId = serviceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ServiceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/applications/{application}/services/{service}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="applicationId">The <c>Application</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        public ServiceName(string projectId, string locationId, string applicationId, string serviceId) : this(ResourceNameType.ProjectLocationApplicationService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), applicationId: gax::GaxPreconditions.CheckNotNullOrEmpty(applicationId, nameof(applicationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)))
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
        /// The <c>Application</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ApplicationId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Service</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ServiceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationApplicationService: return s_projectLocationApplicationService.Expand(ProjectId, LocationId, ApplicationId, ServiceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ServiceName);

        /// <inheritdoc/>
        public bool Equals(ServiceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ServiceName a, ServiceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ServiceName a, ServiceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>DiscoveredService</c> resource.</summary>
    public sealed partial class DiscoveredServiceName : gax::IResourceName, sys::IEquatable<DiscoveredServiceName>
    {
        /// <summary>The possible contents of <see cref="DiscoveredServiceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/discoveredServices/{discovered_service}</c>.
            /// </summary>
            ProjectLocationDiscoveredService = 1,
        }

        private static gax::PathTemplate s_projectLocationDiscoveredService = new gax::PathTemplate("projects/{project}/locations/{location}/discoveredServices/{discovered_service}");

        /// <summary>Creates a <see cref="DiscoveredServiceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DiscoveredServiceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DiscoveredServiceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DiscoveredServiceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DiscoveredServiceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/discoveredServices/{discovered_service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="discoveredServiceId">The <c>DiscoveredService</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DiscoveredServiceName"/> constructed from the provided ids.</returns>
        public static DiscoveredServiceName FromProjectLocationDiscoveredService(string projectId, string locationId, string discoveredServiceId) =>
            new DiscoveredServiceName(ResourceNameType.ProjectLocationDiscoveredService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), discoveredServiceId: gax::GaxPreconditions.CheckNotNullOrEmpty(discoveredServiceId, nameof(discoveredServiceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DiscoveredServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/discoveredServices/{discovered_service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="discoveredServiceId">The <c>DiscoveredService</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DiscoveredServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/discoveredServices/{discovered_service}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string discoveredServiceId) =>
            FormatProjectLocationDiscoveredService(projectId, locationId, discoveredServiceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DiscoveredServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/discoveredServices/{discovered_service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="discoveredServiceId">The <c>DiscoveredService</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DiscoveredServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/discoveredServices/{discovered_service}</c>.
        /// </returns>
        public static string FormatProjectLocationDiscoveredService(string projectId, string locationId, string discoveredServiceId) =>
            s_projectLocationDiscoveredService.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(discoveredServiceId, nameof(discoveredServiceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DiscoveredServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/discoveredServices/{discovered_service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="discoveredServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DiscoveredServiceName"/> if successful.</returns>
        public static DiscoveredServiceName Parse(string discoveredServiceName) => Parse(discoveredServiceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DiscoveredServiceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/discoveredServices/{discovered_service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="discoveredServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DiscoveredServiceName"/> if successful.</returns>
        public static DiscoveredServiceName Parse(string discoveredServiceName, bool allowUnparsed) =>
            TryParse(discoveredServiceName, allowUnparsed, out DiscoveredServiceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DiscoveredServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/discoveredServices/{discovered_service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="discoveredServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DiscoveredServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string discoveredServiceName, out DiscoveredServiceName result) =>
            TryParse(discoveredServiceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DiscoveredServiceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/discoveredServices/{discovered_service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="discoveredServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DiscoveredServiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string discoveredServiceName, bool allowUnparsed, out DiscoveredServiceName result)
        {
            gax::GaxPreconditions.CheckNotNull(discoveredServiceName, nameof(discoveredServiceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationDiscoveredService.TryParseName(discoveredServiceName, out resourceName))
            {
                result = FromProjectLocationDiscoveredService(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(discoveredServiceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DiscoveredServiceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string discoveredServiceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            DiscoveredServiceId = discoveredServiceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DiscoveredServiceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/discoveredServices/{discovered_service}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="discoveredServiceId">The <c>DiscoveredService</c> ID. Must not be <c>null</c> or empty.</param>
        public DiscoveredServiceName(string projectId, string locationId, string discoveredServiceId) : this(ResourceNameType.ProjectLocationDiscoveredService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), discoveredServiceId: gax::GaxPreconditions.CheckNotNullOrEmpty(discoveredServiceId, nameof(discoveredServiceId)))
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
        /// The <c>DiscoveredService</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string DiscoveredServiceId { get; }

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
                case ResourceNameType.ProjectLocationDiscoveredService: return s_projectLocationDiscoveredService.Expand(ProjectId, LocationId, DiscoveredServiceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DiscoveredServiceName);

        /// <inheritdoc/>
        public bool Equals(DiscoveredServiceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DiscoveredServiceName a, DiscoveredServiceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DiscoveredServiceName a, DiscoveredServiceName b) => !(a == b);
    }

    public partial class Service
    {
        /// <summary>
        /// <see cref="gcav::ServiceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ServiceName ServiceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ServiceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="DiscoveredService"/> resource name property.
        /// </summary>
        public gagr::LocationName DiscoveredServiceAsLocationName
        {
            get => string.IsNullOrEmpty(DiscoveredService) ? null : gagr::LocationName.Parse(DiscoveredService, allowUnparsed: true);
            set => DiscoveredService = value?.ToString() ?? "";
        }
    }

    public partial class DiscoveredService
    {
        /// <summary>
        /// <see cref="gcav::DiscoveredServiceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DiscoveredServiceName DiscoveredServiceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DiscoveredServiceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
