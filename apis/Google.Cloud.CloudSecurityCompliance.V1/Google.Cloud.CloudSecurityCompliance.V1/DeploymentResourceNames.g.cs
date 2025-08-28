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
using gccv = Google.Cloud.CloudSecurityCompliance.V1;
using sys = System;

namespace Google.Cloud.CloudSecurityCompliance.V1
{
    /// <summary>Resource name for the <c>FrameworkDeployment</c> resource.</summary>
    public sealed partial class FrameworkDeploymentName : gax::IResourceName, sys::IEquatable<FrameworkDeploymentName>
    {
        /// <summary>The possible contents of <see cref="FrameworkDeploymentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment}</c>.
            /// </summary>
            OrganizationLocationFrameworkDeployment = 1,
        }

        private static gax::PathTemplate s_organizationLocationFrameworkDeployment = new gax::PathTemplate("organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment}");

        /// <summary>Creates a <see cref="FrameworkDeploymentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FrameworkDeploymentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FrameworkDeploymentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FrameworkDeploymentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FrameworkDeploymentName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkDeploymentId">
        /// The <c>FrameworkDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="FrameworkDeploymentName"/> constructed from the provided ids.
        /// </returns>
        public static FrameworkDeploymentName FromOrganizationLocationFrameworkDeployment(string organizationId, string locationId, string frameworkDeploymentId) =>
            new FrameworkDeploymentName(ResourceNameType.OrganizationLocationFrameworkDeployment, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), frameworkDeploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkDeploymentId, nameof(frameworkDeploymentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FrameworkDeploymentName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkDeploymentId">
        /// The <c>FrameworkDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FrameworkDeploymentName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId, string frameworkDeploymentId) =>
            FormatOrganizationLocationFrameworkDeployment(organizationId, locationId, frameworkDeploymentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FrameworkDeploymentName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkDeploymentId">
        /// The <c>FrameworkDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FrameworkDeploymentName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment}</c>.
        /// </returns>
        public static string FormatOrganizationLocationFrameworkDeployment(string organizationId, string locationId, string frameworkDeploymentId) =>
            s_organizationLocationFrameworkDeployment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkDeploymentId, nameof(frameworkDeploymentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FrameworkDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="frameworkDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FrameworkDeploymentName"/> if successful.</returns>
        public static FrameworkDeploymentName Parse(string frameworkDeploymentName) => Parse(frameworkDeploymentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FrameworkDeploymentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="frameworkDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FrameworkDeploymentName"/> if successful.</returns>
        public static FrameworkDeploymentName Parse(string frameworkDeploymentName, bool allowUnparsed) =>
            TryParse(frameworkDeploymentName, allowUnparsed, out FrameworkDeploymentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FrameworkDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="frameworkDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FrameworkDeploymentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string frameworkDeploymentName, out FrameworkDeploymentName result) =>
            TryParse(frameworkDeploymentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FrameworkDeploymentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="frameworkDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FrameworkDeploymentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string frameworkDeploymentName, bool allowUnparsed, out FrameworkDeploymentName result)
        {
            gax::GaxPreconditions.CheckNotNull(frameworkDeploymentName, nameof(frameworkDeploymentName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationFrameworkDeployment.TryParseName(frameworkDeploymentName, out resourceName))
            {
                result = FromOrganizationLocationFrameworkDeployment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(frameworkDeploymentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FrameworkDeploymentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string frameworkDeploymentId = null, string locationId = null, string organizationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FrameworkDeploymentId = frameworkDeploymentId;
            LocationId = locationId;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FrameworkDeploymentName"/> class from the component parts of
        /// pattern <c>organizations/{organization}/locations/{location}/frameworkDeployments/{framework_deployment}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="frameworkDeploymentId">
        /// The <c>FrameworkDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public FrameworkDeploymentName(string organizationId, string locationId, string frameworkDeploymentId) : this(ResourceNameType.OrganizationLocationFrameworkDeployment, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), frameworkDeploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(frameworkDeploymentId, nameof(frameworkDeploymentId)))
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
        /// The <c>FrameworkDeployment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string FrameworkDeploymentId { get; }

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
                case ResourceNameType.OrganizationLocationFrameworkDeployment: return s_organizationLocationFrameworkDeployment.Expand(OrganizationId, LocationId, FrameworkDeploymentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FrameworkDeploymentName);

        /// <inheritdoc/>
        public bool Equals(FrameworkDeploymentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FrameworkDeploymentName a, FrameworkDeploymentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FrameworkDeploymentName a, FrameworkDeploymentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>CloudControlDeployment</c> resource.</summary>
    public sealed partial class CloudControlDeploymentName : gax::IResourceName, sys::IEquatable<CloudControlDeploymentName>
    {
        /// <summary>The possible contents of <see cref="CloudControlDeploymentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/cloudControlDeployments/{cloud_control_deployment}</c>
            /// .
            /// </summary>
            OrganizationLocationCloudControlDeployment = 1,
        }

        private static gax::PathTemplate s_organizationLocationCloudControlDeployment = new gax::PathTemplate("organizations/{organization}/locations/{location}/cloudControlDeployments/{cloud_control_deployment}");

        /// <summary>Creates a <see cref="CloudControlDeploymentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CloudControlDeploymentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CloudControlDeploymentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CloudControlDeploymentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CloudControlDeploymentName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/cloudControlDeployments/{cloud_control_deployment}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudControlDeploymentId">
        /// The <c>CloudControlDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="CloudControlDeploymentName"/> constructed from the provided ids.
        /// </returns>
        public static CloudControlDeploymentName FromOrganizationLocationCloudControlDeployment(string organizationId, string locationId, string cloudControlDeploymentId) =>
            new CloudControlDeploymentName(ResourceNameType.OrganizationLocationCloudControlDeployment, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), cloudControlDeploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(cloudControlDeploymentId, nameof(cloudControlDeploymentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CloudControlDeploymentName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/cloudControlDeployments/{cloud_control_deployment}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudControlDeploymentId">
        /// The <c>CloudControlDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CloudControlDeploymentName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/cloudControlDeployments/{cloud_control_deployment}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId, string cloudControlDeploymentId) =>
            FormatOrganizationLocationCloudControlDeployment(organizationId, locationId, cloudControlDeploymentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CloudControlDeploymentName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/cloudControlDeployments/{cloud_control_deployment}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudControlDeploymentId">
        /// The <c>CloudControlDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CloudControlDeploymentName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/cloudControlDeployments/{cloud_control_deployment}</c>.
        /// </returns>
        public static string FormatOrganizationLocationCloudControlDeployment(string organizationId, string locationId, string cloudControlDeploymentId) =>
            s_organizationLocationCloudControlDeployment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(cloudControlDeploymentId, nameof(cloudControlDeploymentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CloudControlDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/cloudControlDeployments/{cloud_control_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cloudControlDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CloudControlDeploymentName"/> if successful.</returns>
        public static CloudControlDeploymentName Parse(string cloudControlDeploymentName) =>
            Parse(cloudControlDeploymentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CloudControlDeploymentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/cloudControlDeployments/{cloud_control_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cloudControlDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CloudControlDeploymentName"/> if successful.</returns>
        public static CloudControlDeploymentName Parse(string cloudControlDeploymentName, bool allowUnparsed) =>
            TryParse(cloudControlDeploymentName, allowUnparsed, out CloudControlDeploymentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CloudControlDeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/cloudControlDeployments/{cloud_control_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="cloudControlDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CloudControlDeploymentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cloudControlDeploymentName, out CloudControlDeploymentName result) =>
            TryParse(cloudControlDeploymentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CloudControlDeploymentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/cloudControlDeployments/{cloud_control_deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="cloudControlDeploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CloudControlDeploymentName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string cloudControlDeploymentName, bool allowUnparsed, out CloudControlDeploymentName result)
        {
            gax::GaxPreconditions.CheckNotNull(cloudControlDeploymentName, nameof(cloudControlDeploymentName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationCloudControlDeployment.TryParseName(cloudControlDeploymentName, out resourceName))
            {
                result = FromOrganizationLocationCloudControlDeployment(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(cloudControlDeploymentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CloudControlDeploymentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string cloudControlDeploymentId = null, string locationId = null, string organizationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CloudControlDeploymentId = cloudControlDeploymentId;
            LocationId = locationId;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CloudControlDeploymentName"/> class from the component parts of
        /// pattern
        /// <c>organizations/{organization}/locations/{location}/cloudControlDeployments/{cloud_control_deployment}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="cloudControlDeploymentId">
        /// The <c>CloudControlDeployment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public CloudControlDeploymentName(string organizationId, string locationId, string cloudControlDeploymentId) : this(ResourceNameType.OrganizationLocationCloudControlDeployment, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), cloudControlDeploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(cloudControlDeploymentId, nameof(cloudControlDeploymentId)))
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
        /// The <c>CloudControlDeployment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string CloudControlDeploymentId { get; }

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
                case ResourceNameType.OrganizationLocationCloudControlDeployment: return s_organizationLocationCloudControlDeployment.Expand(OrganizationId, LocationId, CloudControlDeploymentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CloudControlDeploymentName);

        /// <inheritdoc/>
        public bool Equals(CloudControlDeploymentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CloudControlDeploymentName a, CloudControlDeploymentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CloudControlDeploymentName a, CloudControlDeploymentName b) => !(a == b);
    }

    public partial class FrameworkDeployment
    {
        /// <summary>
        /// <see cref="gccv::FrameworkDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FrameworkDeploymentName FrameworkDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FrameworkDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CloudControlDeployment
    {
        /// <summary>
        /// <see cref="gccv::CloudControlDeploymentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::CloudControlDeploymentName CloudControlDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::CloudControlDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateFrameworkDeploymentRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteFrameworkDeploymentRequest
    {
        /// <summary>
        /// <see cref="gccv::FrameworkDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FrameworkDeploymentName FrameworkDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FrameworkDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetFrameworkDeploymentRequest
    {
        /// <summary>
        /// <see cref="gccv::FrameworkDeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FrameworkDeploymentName FrameworkDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FrameworkDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFrameworkDeploymentsRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetCloudControlDeploymentRequest
    {
        /// <summary>
        /// <see cref="gccv::CloudControlDeploymentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::CloudControlDeploymentName CloudControlDeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::CloudControlDeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCloudControlDeploymentsRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CloudControlDeploymentReference
    {
        /// <summary>
        /// <see cref="CloudControlDeploymentName"/>-typed view over the <see cref="CloudControlDeployment"/> resource
        /// name property.
        /// </summary>
        public CloudControlDeploymentName CloudControlDeploymentAsCloudControlDeploymentName
        {
            get => string.IsNullOrEmpty(CloudControlDeployment) ? null : CloudControlDeploymentName.Parse(CloudControlDeployment, allowUnparsed: true);
            set => CloudControlDeployment = value?.ToString() ?? "";
        }
    }

    public partial class FrameworkDeploymentReference
    {
        /// <summary>
        /// <see cref="FrameworkDeploymentName"/>-typed view over the <see cref="FrameworkDeployment"/> resource name
        /// property.
        /// </summary>
        public FrameworkDeploymentName FrameworkDeploymentAsFrameworkDeploymentName
        {
            get => string.IsNullOrEmpty(FrameworkDeployment) ? null : FrameworkDeploymentName.Parse(FrameworkDeployment, allowUnparsed: true);
            set => FrameworkDeployment = value?.ToString() ?? "";
        }
    }
}
