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
using gcsv = Google.Cloud.SecurityCenterManagement.V1;
using sys = System;

namespace Google.Cloud.SecurityCenterManagement.V1
{
    /// <summary>Resource name for the <c>SecurityCenterService</c> resource.</summary>
    public sealed partial class SecurityCenterServiceName : gax::IResourceName, sys::IEquatable<SecurityCenterServiceName>
    {
        /// <summary>The possible contents of <see cref="SecurityCenterServiceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/securityCenterServices/{service}</c>
            /// .
            /// </summary>
            ProjectLocationService = 1,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/locations/{location}/securityCenterServices/{service}</c>
            /// .
            /// </summary>
            FolderLocationService = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/securityCenterServices/{service}</c>.
            /// </summary>
            OrganizationLocationService = 3,
        }

        private static gax::PathTemplate s_projectLocationService = new gax::PathTemplate("projects/{project}/locations/{location}/securityCenterServices/{service}");

        private static gax::PathTemplate s_folderLocationService = new gax::PathTemplate("folders/{folder}/locations/{location}/securityCenterServices/{service}");

        private static gax::PathTemplate s_organizationLocationService = new gax::PathTemplate("organizations/{organization}/locations/{location}/securityCenterServices/{service}");

        /// <summary>Creates a <see cref="SecurityCenterServiceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SecurityCenterServiceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SecurityCenterServiceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SecurityCenterServiceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SecurityCenterServiceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/securityCenterServices/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="SecurityCenterServiceName"/> constructed from the provided ids.
        /// </returns>
        public static SecurityCenterServiceName FromProjectLocationService(string projectId, string locationId, string serviceId) =>
            new SecurityCenterServiceName(ResourceNameType.ProjectLocationService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Creates a <see cref="SecurityCenterServiceName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/securityCenterServices/{service}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="SecurityCenterServiceName"/> constructed from the provided ids.
        /// </returns>
        public static SecurityCenterServiceName FromFolderLocationService(string folderId, string locationId, string serviceId) =>
            new SecurityCenterServiceName(ResourceNameType.FolderLocationService, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Creates a <see cref="SecurityCenterServiceName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/securityCenterServices/{service}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="SecurityCenterServiceName"/> constructed from the provided ids.
        /// </returns>
        public static SecurityCenterServiceName FromOrganizationLocationService(string organizationId, string locationId, string serviceId) =>
            new SecurityCenterServiceName(ResourceNameType.OrganizationLocationService, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityCenterServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/securityCenterServices/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityCenterServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/securityCenterServices/{service}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string serviceId) =>
            FormatProjectLocationService(projectId, locationId, serviceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityCenterServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/securityCenterServices/{service}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityCenterServiceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/securityCenterServices/{service}</c>.
        /// </returns>
        public static string FormatProjectLocationService(string projectId, string locationId, string serviceId) =>
            s_projectLocationService.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityCenterServiceName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/securityCenterServices/{service}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityCenterServiceName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/securityCenterServices/{service}</c>.
        /// </returns>
        public static string FormatFolderLocationService(string folderId, string locationId, string serviceId) =>
            s_folderLocationService.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityCenterServiceName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/securityCenterServices/{service}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SecurityCenterServiceName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/securityCenterServices/{service}</c>.
        /// </returns>
        public static string FormatOrganizationLocationService(string organizationId, string locationId, string serviceId) =>
            s_organizationLocationService.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecurityCenterServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/securityCenterServices/{service}</c></description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/securityCenterServices/{service}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/securityCenterServices/{service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="securityCenterServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SecurityCenterServiceName"/> if successful.</returns>
        public static SecurityCenterServiceName Parse(string securityCenterServiceName) =>
            Parse(securityCenterServiceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecurityCenterServiceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/securityCenterServices/{service}</c></description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/securityCenterServices/{service}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/securityCenterServices/{service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="securityCenterServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SecurityCenterServiceName"/> if successful.</returns>
        public static SecurityCenterServiceName Parse(string securityCenterServiceName, bool allowUnparsed) =>
            TryParse(securityCenterServiceName, allowUnparsed, out SecurityCenterServiceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecurityCenterServiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/securityCenterServices/{service}</c></description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/securityCenterServices/{service}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/securityCenterServices/{service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="securityCenterServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecurityCenterServiceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string securityCenterServiceName, out SecurityCenterServiceName result) =>
            TryParse(securityCenterServiceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SecurityCenterServiceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/securityCenterServices/{service}</c></description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/securityCenterServices/{service}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/securityCenterServices/{service}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="securityCenterServiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecurityCenterServiceName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string securityCenterServiceName, bool allowUnparsed, out SecurityCenterServiceName result)
        {
            gax::GaxPreconditions.CheckNotNull(securityCenterServiceName, nameof(securityCenterServiceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationService.TryParseName(securityCenterServiceName, out resourceName))
            {
                result = FromProjectLocationService(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationService.TryParseName(securityCenterServiceName, out resourceName))
            {
                result = FromFolderLocationService(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationService.TryParseName(securityCenterServiceName, out resourceName))
            {
                result = FromOrganizationLocationService(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(securityCenterServiceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SecurityCenterServiceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null, string serviceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            ServiceId = serviceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SecurityCenterServiceName"/> class from the component parts of
        /// pattern <c>projects/{project}/locations/{location}/securityCenterServices/{service}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        public SecurityCenterServiceName(string projectId, string locationId, string serviceId) : this(ResourceNameType.ProjectLocationService, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)))
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
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Service</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.ProjectLocationService: return s_projectLocationService.Expand(ProjectId, LocationId, ServiceId);
                case ResourceNameType.FolderLocationService: return s_folderLocationService.Expand(FolderId, LocationId, ServiceId);
                case ResourceNameType.OrganizationLocationService: return s_organizationLocationService.Expand(OrganizationId, LocationId, ServiceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SecurityCenterServiceName);

        /// <inheritdoc/>
        public bool Equals(SecurityCenterServiceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SecurityCenterServiceName a, SecurityCenterServiceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SecurityCenterServiceName a, SecurityCenterServiceName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>EffectiveSecurityHealthAnalyticsCustomModule</c> resource.</summary>
    public sealed partial class EffectiveSecurityHealthAnalyticsCustomModuleName : gax::IResourceName, sys::IEquatable<EffectiveSecurityHealthAnalyticsCustomModuleName>
    {
        /// <summary>The possible contents of <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
            /// .
            /// </summary>
            OrganizationLocationEffectiveSecurityHealthAnalyticsCustomModule = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
            /// .
            /// </summary>
            ProjectLocationEffectiveSecurityHealthAnalyticsCustomModule = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// folders/{folder}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
            /// .
            /// </summary>
            FolderLocationEffectiveSecurityHealthAnalyticsCustomModule = 3,
        }

        private static gax::PathTemplate s_organizationLocationEffectiveSecurityHealthAnalyticsCustomModule = new gax::PathTemplate("organizations/{organization}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}");

        private static gax::PathTemplate s_projectLocationEffectiveSecurityHealthAnalyticsCustomModule = new gax::PathTemplate("projects/{project}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}");

        private static gax::PathTemplate s_folderLocationEffectiveSecurityHealthAnalyticsCustomModule = new gax::PathTemplate("folders/{folder}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}");

        /// <summary>
        /// Creates a <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> containing an unparsed resource
        /// name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EffectiveSecurityHealthAnalyticsCustomModuleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EffectiveSecurityHealthAnalyticsCustomModuleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with the pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveSecurityHealthAnalyticsCustomModuleId">
        /// The <c>EffectiveSecurityHealthAnalyticsCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> constructed from the
        /// provided ids.
        /// </returns>
        public static EffectiveSecurityHealthAnalyticsCustomModuleName FromOrganizationLocationEffectiveSecurityHealthAnalyticsCustomModule(string organizationId, string locationId, string effectiveSecurityHealthAnalyticsCustomModuleId) =>
            new EffectiveSecurityHealthAnalyticsCustomModuleName(ResourceNameType.OrganizationLocationEffectiveSecurityHealthAnalyticsCustomModule, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), effectiveSecurityHealthAnalyticsCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveSecurityHealthAnalyticsCustomModuleId, nameof(effectiveSecurityHealthAnalyticsCustomModuleId)));

        /// <summary>
        /// Creates a <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveSecurityHealthAnalyticsCustomModuleId">
        /// The <c>EffectiveSecurityHealthAnalyticsCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> constructed from the
        /// provided ids.
        /// </returns>
        public static EffectiveSecurityHealthAnalyticsCustomModuleName FromProjectLocationEffectiveSecurityHealthAnalyticsCustomModule(string projectId, string locationId, string effectiveSecurityHealthAnalyticsCustomModuleId) =>
            new EffectiveSecurityHealthAnalyticsCustomModuleName(ResourceNameType.ProjectLocationEffectiveSecurityHealthAnalyticsCustomModule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), effectiveSecurityHealthAnalyticsCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveSecurityHealthAnalyticsCustomModuleId, nameof(effectiveSecurityHealthAnalyticsCustomModuleId)));

        /// <summary>
        /// Creates a <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with the pattern
        /// <c>
        /// folders/{folder}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveSecurityHealthAnalyticsCustomModuleId">
        /// The <c>EffectiveSecurityHealthAnalyticsCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> constructed from the
        /// provided ids.
        /// </returns>
        public static EffectiveSecurityHealthAnalyticsCustomModuleName FromFolderLocationEffectiveSecurityHealthAnalyticsCustomModule(string folderId, string locationId, string effectiveSecurityHealthAnalyticsCustomModuleId) =>
            new EffectiveSecurityHealthAnalyticsCustomModuleName(ResourceNameType.FolderLocationEffectiveSecurityHealthAnalyticsCustomModule, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), effectiveSecurityHealthAnalyticsCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveSecurityHealthAnalyticsCustomModuleId, nameof(effectiveSecurityHealthAnalyticsCustomModuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveSecurityHealthAnalyticsCustomModuleId">
        /// The <c>EffectiveSecurityHealthAnalyticsCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with
        /// pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// .
        /// </returns>
        public static string Format(string organizationId, string locationId, string effectiveSecurityHealthAnalyticsCustomModuleId) =>
            FormatOrganizationLocationEffectiveSecurityHealthAnalyticsCustomModule(organizationId, locationId, effectiveSecurityHealthAnalyticsCustomModuleId);

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveSecurityHealthAnalyticsCustomModuleId">
        /// The <c>EffectiveSecurityHealthAnalyticsCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with
        /// pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationLocationEffectiveSecurityHealthAnalyticsCustomModule(string organizationId, string locationId, string effectiveSecurityHealthAnalyticsCustomModuleId) =>
            s_organizationLocationEffectiveSecurityHealthAnalyticsCustomModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveSecurityHealthAnalyticsCustomModuleId, nameof(effectiveSecurityHealthAnalyticsCustomModuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveSecurityHealthAnalyticsCustomModuleId">
        /// The <c>EffectiveSecurityHealthAnalyticsCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationEffectiveSecurityHealthAnalyticsCustomModule(string projectId, string locationId, string effectiveSecurityHealthAnalyticsCustomModuleId) =>
            s_projectLocationEffectiveSecurityHealthAnalyticsCustomModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveSecurityHealthAnalyticsCustomModuleId, nameof(effectiveSecurityHealthAnalyticsCustomModuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with pattern
        /// <c>
        /// folders/{folder}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveSecurityHealthAnalyticsCustomModuleId">
        /// The <c>EffectiveSecurityHealthAnalyticsCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> with
        /// pattern
        /// <c>
        /// folders/{folder}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// .
        /// </returns>
        public static string FormatFolderLocationEffectiveSecurityHealthAnalyticsCustomModule(string folderId, string locationId, string effectiveSecurityHealthAnalyticsCustomModuleId) =>
            s_folderLocationEffectiveSecurityHealthAnalyticsCustomModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveSecurityHealthAnalyticsCustomModuleId, nameof(effectiveSecurityHealthAnalyticsCustomModuleId)));

        /// <summary>
        /// Parses the given resource name string into a new
        /// <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="effectiveSecurityHealthAnalyticsCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> if successful.</returns>
        public static EffectiveSecurityHealthAnalyticsCustomModuleName Parse(string effectiveSecurityHealthAnalyticsCustomModuleName) =>
            Parse(effectiveSecurityHealthAnalyticsCustomModuleName, false);

        /// <summary>
        /// Parses the given resource name string into a new
        /// <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> instance; optionally allowing an unparseable
        /// resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="effectiveSecurityHealthAnalyticsCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> if successful.</returns>
        public static EffectiveSecurityHealthAnalyticsCustomModuleName Parse(string effectiveSecurityHealthAnalyticsCustomModuleName, bool allowUnparsed) =>
            TryParse(effectiveSecurityHealthAnalyticsCustomModuleName, allowUnparsed, out EffectiveSecurityHealthAnalyticsCustomModuleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="effectiveSecurityHealthAnalyticsCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/>, or
        /// <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string effectiveSecurityHealthAnalyticsCustomModuleName, out EffectiveSecurityHealthAnalyticsCustomModuleName result) =>
            TryParse(effectiveSecurityHealthAnalyticsCustomModuleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> instance; optionally allowing an unparseable
        /// resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="effectiveSecurityHealthAnalyticsCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/>, or
        /// <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string effectiveSecurityHealthAnalyticsCustomModuleName, bool allowUnparsed, out EffectiveSecurityHealthAnalyticsCustomModuleName result)
        {
            gax::GaxPreconditions.CheckNotNull(effectiveSecurityHealthAnalyticsCustomModuleName, nameof(effectiveSecurityHealthAnalyticsCustomModuleName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationEffectiveSecurityHealthAnalyticsCustomModule.TryParseName(effectiveSecurityHealthAnalyticsCustomModuleName, out resourceName))
            {
                result = FromOrganizationLocationEffectiveSecurityHealthAnalyticsCustomModule(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationEffectiveSecurityHealthAnalyticsCustomModule.TryParseName(effectiveSecurityHealthAnalyticsCustomModuleName, out resourceName))
            {
                result = FromProjectLocationEffectiveSecurityHealthAnalyticsCustomModule(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationEffectiveSecurityHealthAnalyticsCustomModule.TryParseName(effectiveSecurityHealthAnalyticsCustomModuleName, out resourceName))
            {
                result = FromFolderLocationEffectiveSecurityHealthAnalyticsCustomModule(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(effectiveSecurityHealthAnalyticsCustomModuleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EffectiveSecurityHealthAnalyticsCustomModuleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string effectiveSecurityHealthAnalyticsCustomModuleId = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EffectiveSecurityHealthAnalyticsCustomModuleId = effectiveSecurityHealthAnalyticsCustomModuleId;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EffectiveSecurityHealthAnalyticsCustomModuleName"/> class from the
        /// component parts of pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveSecurityHealthAnalyticsCustomModules/{effective_security_health_analytics_custom_module}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveSecurityHealthAnalyticsCustomModuleId">
        /// The <c>EffectiveSecurityHealthAnalyticsCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public EffectiveSecurityHealthAnalyticsCustomModuleName(string organizationId, string locationId, string effectiveSecurityHealthAnalyticsCustomModuleId) : this(ResourceNameType.OrganizationLocationEffectiveSecurityHealthAnalyticsCustomModule, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), effectiveSecurityHealthAnalyticsCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveSecurityHealthAnalyticsCustomModuleId, nameof(effectiveSecurityHealthAnalyticsCustomModuleId)))
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
        /// The <c>EffectiveSecurityHealthAnalyticsCustomModule</c> ID. May be <c>null</c>, depending on which resource
        /// name is contained by this instance.
        /// </summary>
        public string EffectiveSecurityHealthAnalyticsCustomModuleId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.OrganizationLocationEffectiveSecurityHealthAnalyticsCustomModule: return s_organizationLocationEffectiveSecurityHealthAnalyticsCustomModule.Expand(OrganizationId, LocationId, EffectiveSecurityHealthAnalyticsCustomModuleId);
                case ResourceNameType.ProjectLocationEffectiveSecurityHealthAnalyticsCustomModule: return s_projectLocationEffectiveSecurityHealthAnalyticsCustomModule.Expand(ProjectId, LocationId, EffectiveSecurityHealthAnalyticsCustomModuleId);
                case ResourceNameType.FolderLocationEffectiveSecurityHealthAnalyticsCustomModule: return s_folderLocationEffectiveSecurityHealthAnalyticsCustomModule.Expand(FolderId, LocationId, EffectiveSecurityHealthAnalyticsCustomModuleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EffectiveSecurityHealthAnalyticsCustomModuleName);

        /// <inheritdoc/>
        public bool Equals(EffectiveSecurityHealthAnalyticsCustomModuleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EffectiveSecurityHealthAnalyticsCustomModuleName a, EffectiveSecurityHealthAnalyticsCustomModuleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EffectiveSecurityHealthAnalyticsCustomModuleName a, EffectiveSecurityHealthAnalyticsCustomModuleName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>SecurityHealthAnalyticsCustomModule</c> resource.</summary>
    public sealed partial class SecurityHealthAnalyticsCustomModuleName : gax::IResourceName, sys::IEquatable<SecurityHealthAnalyticsCustomModuleName>
    {
        /// <summary>The possible contents of <see cref="SecurityHealthAnalyticsCustomModuleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
            /// .
            /// </summary>
            OrganizationLocationSecurityHealthAnalyticsCustomModule = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
            /// .
            /// </summary>
            ProjectLocationSecurityHealthAnalyticsCustomModule = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// folders/{folder}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
            /// .
            /// </summary>
            FolderLocationSecurityHealthAnalyticsCustomModule = 3,
        }

        private static gax::PathTemplate s_organizationLocationSecurityHealthAnalyticsCustomModule = new gax::PathTemplate("organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}");

        private static gax::PathTemplate s_projectLocationSecurityHealthAnalyticsCustomModule = new gax::PathTemplate("projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}");

        private static gax::PathTemplate s_folderLocationSecurityHealthAnalyticsCustomModule = new gax::PathTemplate("folders/{folder}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}");

        /// <summary>
        /// Creates a <see cref="SecurityHealthAnalyticsCustomModuleName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SecurityHealthAnalyticsCustomModuleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SecurityHealthAnalyticsCustomModuleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SecurityHealthAnalyticsCustomModuleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SecurityHealthAnalyticsCustomModuleName"/> with the pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityHealthAnalyticsCustomModuleId">
        /// The <c>SecurityHealthAnalyticsCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="SecurityHealthAnalyticsCustomModuleName"/> constructed from the provided ids.
        /// </returns>
        public static SecurityHealthAnalyticsCustomModuleName FromOrganizationLocationSecurityHealthAnalyticsCustomModule(string organizationId, string locationId, string securityHealthAnalyticsCustomModuleId) =>
            new SecurityHealthAnalyticsCustomModuleName(ResourceNameType.OrganizationLocationSecurityHealthAnalyticsCustomModule, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), securityHealthAnalyticsCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(securityHealthAnalyticsCustomModuleId, nameof(securityHealthAnalyticsCustomModuleId)));

        /// <summary>
        /// Creates a <see cref="SecurityHealthAnalyticsCustomModuleName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityHealthAnalyticsCustomModuleId">
        /// The <c>SecurityHealthAnalyticsCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="SecurityHealthAnalyticsCustomModuleName"/> constructed from the provided ids.
        /// </returns>
        public static SecurityHealthAnalyticsCustomModuleName FromProjectLocationSecurityHealthAnalyticsCustomModule(string projectId, string locationId, string securityHealthAnalyticsCustomModuleId) =>
            new SecurityHealthAnalyticsCustomModuleName(ResourceNameType.ProjectLocationSecurityHealthAnalyticsCustomModule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), securityHealthAnalyticsCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(securityHealthAnalyticsCustomModuleId, nameof(securityHealthAnalyticsCustomModuleId)));

        /// <summary>
        /// Creates a <see cref="SecurityHealthAnalyticsCustomModuleName"/> with the pattern
        /// <c>
        /// folders/{folder}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityHealthAnalyticsCustomModuleId">
        /// The <c>SecurityHealthAnalyticsCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="SecurityHealthAnalyticsCustomModuleName"/> constructed from the provided ids.
        /// </returns>
        public static SecurityHealthAnalyticsCustomModuleName FromFolderLocationSecurityHealthAnalyticsCustomModule(string folderId, string locationId, string securityHealthAnalyticsCustomModuleId) =>
            new SecurityHealthAnalyticsCustomModuleName(ResourceNameType.FolderLocationSecurityHealthAnalyticsCustomModule, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), securityHealthAnalyticsCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(securityHealthAnalyticsCustomModuleId, nameof(securityHealthAnalyticsCustomModuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityHealthAnalyticsCustomModuleName"/>
        /// with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityHealthAnalyticsCustomModuleId">
        /// The <c>SecurityHealthAnalyticsCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="SecurityHealthAnalyticsCustomModuleName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// .
        /// </returns>
        public static string Format(string organizationId, string locationId, string securityHealthAnalyticsCustomModuleId) =>
            FormatOrganizationLocationSecurityHealthAnalyticsCustomModule(organizationId, locationId, securityHealthAnalyticsCustomModuleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityHealthAnalyticsCustomModuleName"/>
        /// with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityHealthAnalyticsCustomModuleId">
        /// The <c>SecurityHealthAnalyticsCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="SecurityHealthAnalyticsCustomModuleName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationLocationSecurityHealthAnalyticsCustomModule(string organizationId, string locationId, string securityHealthAnalyticsCustomModuleId) =>
            s_organizationLocationSecurityHealthAnalyticsCustomModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(securityHealthAnalyticsCustomModuleId, nameof(securityHealthAnalyticsCustomModuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityHealthAnalyticsCustomModuleName"/>
        /// with pattern
        /// <c>
        /// projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityHealthAnalyticsCustomModuleId">
        /// The <c>SecurityHealthAnalyticsCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="SecurityHealthAnalyticsCustomModuleName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationSecurityHealthAnalyticsCustomModule(string projectId, string locationId, string securityHealthAnalyticsCustomModuleId) =>
            s_projectLocationSecurityHealthAnalyticsCustomModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(securityHealthAnalyticsCustomModuleId, nameof(securityHealthAnalyticsCustomModuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SecurityHealthAnalyticsCustomModuleName"/>
        /// with pattern
        /// <c>
        /// folders/{folder}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityHealthAnalyticsCustomModuleId">
        /// The <c>SecurityHealthAnalyticsCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="SecurityHealthAnalyticsCustomModuleName"/> with pattern
        /// <c>
        /// folders/{folder}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// .
        /// </returns>
        public static string FormatFolderLocationSecurityHealthAnalyticsCustomModule(string folderId, string locationId, string securityHealthAnalyticsCustomModuleId) =>
            s_folderLocationSecurityHealthAnalyticsCustomModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(securityHealthAnalyticsCustomModuleId, nameof(securityHealthAnalyticsCustomModuleId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecurityHealthAnalyticsCustomModuleName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="securityHealthAnalyticsCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="SecurityHealthAnalyticsCustomModuleName"/> if successful.</returns>
        public static SecurityHealthAnalyticsCustomModuleName Parse(string securityHealthAnalyticsCustomModuleName) =>
            Parse(securityHealthAnalyticsCustomModuleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SecurityHealthAnalyticsCustomModuleName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="securityHealthAnalyticsCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SecurityHealthAnalyticsCustomModuleName"/> if successful.</returns>
        public static SecurityHealthAnalyticsCustomModuleName Parse(string securityHealthAnalyticsCustomModuleName, bool allowUnparsed) =>
            TryParse(securityHealthAnalyticsCustomModuleName, allowUnparsed, out SecurityHealthAnalyticsCustomModuleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="SecurityHealthAnalyticsCustomModuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="securityHealthAnalyticsCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecurityHealthAnalyticsCustomModuleName"/>, or <c>null</c>
        /// if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string securityHealthAnalyticsCustomModuleName, out SecurityHealthAnalyticsCustomModuleName result) =>
            TryParse(securityHealthAnalyticsCustomModuleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="SecurityHealthAnalyticsCustomModuleName"/> instance; optionally allowing an unparseable resource
        /// name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="securityHealthAnalyticsCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SecurityHealthAnalyticsCustomModuleName"/>, or <c>null</c>
        /// if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string securityHealthAnalyticsCustomModuleName, bool allowUnparsed, out SecurityHealthAnalyticsCustomModuleName result)
        {
            gax::GaxPreconditions.CheckNotNull(securityHealthAnalyticsCustomModuleName, nameof(securityHealthAnalyticsCustomModuleName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationSecurityHealthAnalyticsCustomModule.TryParseName(securityHealthAnalyticsCustomModuleName, out resourceName))
            {
                result = FromOrganizationLocationSecurityHealthAnalyticsCustomModule(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationSecurityHealthAnalyticsCustomModule.TryParseName(securityHealthAnalyticsCustomModuleName, out resourceName))
            {
                result = FromProjectLocationSecurityHealthAnalyticsCustomModule(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationSecurityHealthAnalyticsCustomModule.TryParseName(securityHealthAnalyticsCustomModuleName, out resourceName))
            {
                result = FromFolderLocationSecurityHealthAnalyticsCustomModule(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(securityHealthAnalyticsCustomModuleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SecurityHealthAnalyticsCustomModuleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null, string securityHealthAnalyticsCustomModuleId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            SecurityHealthAnalyticsCustomModuleId = securityHealthAnalyticsCustomModuleId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SecurityHealthAnalyticsCustomModuleName"/> class from the
        /// component parts of pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/securityHealthAnalyticsCustomModules/{security_health_analytics_custom_module}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="securityHealthAnalyticsCustomModuleId">
        /// The <c>SecurityHealthAnalyticsCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public SecurityHealthAnalyticsCustomModuleName(string organizationId, string locationId, string securityHealthAnalyticsCustomModuleId) : this(ResourceNameType.OrganizationLocationSecurityHealthAnalyticsCustomModule, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), securityHealthAnalyticsCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(securityHealthAnalyticsCustomModuleId, nameof(securityHealthAnalyticsCustomModuleId)))
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
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>SecurityHealthAnalyticsCustomModule</c> ID. May be <c>null</c>, depending on which resource name is
        /// contained by this instance.
        /// </summary>
        public string SecurityHealthAnalyticsCustomModuleId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationLocationSecurityHealthAnalyticsCustomModule: return s_organizationLocationSecurityHealthAnalyticsCustomModule.Expand(OrganizationId, LocationId, SecurityHealthAnalyticsCustomModuleId);
                case ResourceNameType.ProjectLocationSecurityHealthAnalyticsCustomModule: return s_projectLocationSecurityHealthAnalyticsCustomModule.Expand(ProjectId, LocationId, SecurityHealthAnalyticsCustomModuleId);
                case ResourceNameType.FolderLocationSecurityHealthAnalyticsCustomModule: return s_folderLocationSecurityHealthAnalyticsCustomModule.Expand(FolderId, LocationId, SecurityHealthAnalyticsCustomModuleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SecurityHealthAnalyticsCustomModuleName);

        /// <inheritdoc/>
        public bool Equals(SecurityHealthAnalyticsCustomModuleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SecurityHealthAnalyticsCustomModuleName a, SecurityHealthAnalyticsCustomModuleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SecurityHealthAnalyticsCustomModuleName a, SecurityHealthAnalyticsCustomModuleName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Finding</c> resource.</summary>
    public sealed partial class FindingName : gax::IResourceName, sys::IEquatable<FindingName>
    {
        /// <summary>The possible contents of <see cref="FindingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/sources/{source}/findings/{finding}</c>.
            /// </summary>
            OrganizationSourceFinding = 1,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/sources/{source}/findings/{finding}</c>.
            /// </summary>
            FolderSourceFinding = 2,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/sources/{source}/findings/{finding}</c>.
            /// </summary>
            ProjectSourceFinding = 3,
        }

        private static gax::PathTemplate s_organizationSourceFinding = new gax::PathTemplate("organizations/{organization}/sources/{source}/findings/{finding}");

        private static gax::PathTemplate s_folderSourceFinding = new gax::PathTemplate("folders/{folder}/sources/{source}/findings/{finding}");

        private static gax::PathTemplate s_projectSourceFinding = new gax::PathTemplate("projects/{project}/sources/{source}/findings/{finding}");

        /// <summary>Creates a <see cref="FindingName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FindingName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FindingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FindingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FindingName"/> with the pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FindingName"/> constructed from the provided ids.</returns>
        public static FindingName FromOrganizationSourceFinding(string organizationId, string sourceId, string findingId) =>
            new FindingName(ResourceNameType.OrganizationSourceFinding, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), findingId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>
        /// Creates a <see cref="FindingName"/> with the pattern <c>folders/{folder}/sources/{source}/findings/{finding}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FindingName"/> constructed from the provided ids.</returns>
        public static FindingName FromFolderSourceFinding(string folderId, string sourceId, string findingId) =>
            new FindingName(ResourceNameType.FolderSourceFinding, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), findingId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>
        /// Creates a <see cref="FindingName"/> with the pattern
        /// <c>projects/{project}/sources/{source}/findings/{finding}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FindingName"/> constructed from the provided ids.</returns>
        public static FindingName FromProjectSourceFinding(string projectId, string sourceId, string findingId) =>
            new FindingName(ResourceNameType.ProjectSourceFinding, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), findingId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FindingName"/> with pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FindingName"/> with pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}</c>.
        /// </returns>
        public static string Format(string organizationId, string sourceId, string findingId) =>
            FormatOrganizationSourceFinding(organizationId, sourceId, findingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FindingName"/> with pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FindingName"/> with pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}</c>.
        /// </returns>
        public static string FormatOrganizationSourceFinding(string organizationId, string sourceId, string findingId) =>
            s_organizationSourceFinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FindingName"/> with pattern
        /// <c>folders/{folder}/sources/{source}/findings/{finding}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FindingName"/> with pattern
        /// <c>folders/{folder}/sources/{source}/findings/{finding}</c>.
        /// </returns>
        public static string FormatFolderSourceFinding(string folderId, string sourceId, string findingId) =>
            s_folderSourceFinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FindingName"/> with pattern
        /// <c>projects/{project}/sources/{source}/findings/{finding}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FindingName"/> with pattern
        /// <c>projects/{project}/sources/{source}/findings/{finding}</c>.
        /// </returns>
        public static string FormatProjectSourceFinding(string projectId, string sourceId, string findingId) =>
            s_projectSourceFinding.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)));

        /// <summary>Parses the given resource name string into a new <see cref="FindingName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/sources/{source}/findings/{finding}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/sources/{source}/findings/{finding}</c></description></item>
        /// <item><description><c>projects/{project}/sources/{source}/findings/{finding}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="findingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FindingName"/> if successful.</returns>
        public static FindingName Parse(string findingName) => Parse(findingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FindingName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/sources/{source}/findings/{finding}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/sources/{source}/findings/{finding}</c></description></item>
        /// <item><description><c>projects/{project}/sources/{source}/findings/{finding}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="findingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FindingName"/> if successful.</returns>
        public static FindingName Parse(string findingName, bool allowUnparsed) =>
            TryParse(findingName, allowUnparsed, out FindingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FindingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/sources/{source}/findings/{finding}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/sources/{source}/findings/{finding}</c></description></item>
        /// <item><description><c>projects/{project}/sources/{source}/findings/{finding}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="findingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FindingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string findingName, out FindingName result) => TryParse(findingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FindingName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>organizations/{organization}/sources/{source}/findings/{finding}</c></description>
        /// </item>
        /// <item><description><c>folders/{folder}/sources/{source}/findings/{finding}</c></description></item>
        /// <item><description><c>projects/{project}/sources/{source}/findings/{finding}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="findingName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FindingName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string findingName, bool allowUnparsed, out FindingName result)
        {
            gax::GaxPreconditions.CheckNotNull(findingName, nameof(findingName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationSourceFinding.TryParseName(findingName, out resourceName))
            {
                result = FromOrganizationSourceFinding(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderSourceFinding.TryParseName(findingName, out resourceName))
            {
                result = FromFolderSourceFinding(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectSourceFinding.TryParseName(findingName, out resourceName))
            {
                result = FromProjectSourceFinding(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(findingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FindingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string findingId = null, string folderId = null, string organizationId = null, string projectId = null, string sourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FindingId = findingId;
            FolderId = folderId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            SourceId = sourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FindingName"/> class from the component parts of pattern
        /// <c>organizations/{organization}/sources/{source}/findings/{finding}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="findingId">The <c>Finding</c> ID. Must not be <c>null</c> or empty.</param>
        public FindingName(string organizationId, string sourceId, string findingId) : this(ResourceNameType.OrganizationSourceFinding, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)), findingId: gax::GaxPreconditions.CheckNotNullOrEmpty(findingId, nameof(findingId)))
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
        /// The <c>Finding</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FindingId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Source</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string SourceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.OrganizationSourceFinding: return s_organizationSourceFinding.Expand(OrganizationId, SourceId, FindingId);
                case ResourceNameType.FolderSourceFinding: return s_folderSourceFinding.Expand(FolderId, SourceId, FindingId);
                case ResourceNameType.ProjectSourceFinding: return s_projectSourceFinding.Expand(ProjectId, SourceId, FindingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FindingName);

        /// <inheritdoc/>
        public bool Equals(FindingName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FindingName a, FindingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FindingName a, FindingName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>EffectiveEventThreatDetectionCustomModule</c> resource.</summary>
    public sealed partial class EffectiveEventThreatDetectionCustomModuleName : gax::IResourceName, sys::IEquatable<EffectiveEventThreatDetectionCustomModuleName>
    {
        /// <summary>The possible contents of <see cref="EffectiveEventThreatDetectionCustomModuleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
            /// .
            /// </summary>
            OrganizationLocationEffectiveEventThreatDetectionCustomModule = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
            /// .
            /// </summary>
            ProjectLocationEffectiveEventThreatDetectionCustomModule = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// folders/{folder}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
            /// .
            /// </summary>
            FolderLocationEffectiveEventThreatDetectionCustomModule = 3,
        }

        private static gax::PathTemplate s_organizationLocationEffectiveEventThreatDetectionCustomModule = new gax::PathTemplate("organizations/{organization}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}");

        private static gax::PathTemplate s_projectLocationEffectiveEventThreatDetectionCustomModule = new gax::PathTemplate("projects/{project}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}");

        private static gax::PathTemplate s_folderLocationEffectiveEventThreatDetectionCustomModule = new gax::PathTemplate("folders/{folder}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}");

        /// <summary>
        /// Creates a <see cref="EffectiveEventThreatDetectionCustomModuleName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EffectiveEventThreatDetectionCustomModuleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EffectiveEventThreatDetectionCustomModuleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EffectiveEventThreatDetectionCustomModuleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EffectiveEventThreatDetectionCustomModuleName"/> with the pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveEventThreatDetectionCustomModuleId">
        /// The <c>EffectiveEventThreatDetectionCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="EffectiveEventThreatDetectionCustomModuleName"/> constructed from the provided
        /// ids.
        /// </returns>
        public static EffectiveEventThreatDetectionCustomModuleName FromOrganizationLocationEffectiveEventThreatDetectionCustomModule(string organizationId, string locationId, string effectiveEventThreatDetectionCustomModuleId) =>
            new EffectiveEventThreatDetectionCustomModuleName(ResourceNameType.OrganizationLocationEffectiveEventThreatDetectionCustomModule, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), effectiveEventThreatDetectionCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveEventThreatDetectionCustomModuleId, nameof(effectiveEventThreatDetectionCustomModuleId)));

        /// <summary>
        /// Creates a <see cref="EffectiveEventThreatDetectionCustomModuleName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveEventThreatDetectionCustomModuleId">
        /// The <c>EffectiveEventThreatDetectionCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="EffectiveEventThreatDetectionCustomModuleName"/> constructed from the provided
        /// ids.
        /// </returns>
        public static EffectiveEventThreatDetectionCustomModuleName FromProjectLocationEffectiveEventThreatDetectionCustomModule(string projectId, string locationId, string effectiveEventThreatDetectionCustomModuleId) =>
            new EffectiveEventThreatDetectionCustomModuleName(ResourceNameType.ProjectLocationEffectiveEventThreatDetectionCustomModule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), effectiveEventThreatDetectionCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveEventThreatDetectionCustomModuleId, nameof(effectiveEventThreatDetectionCustomModuleId)));

        /// <summary>
        /// Creates a <see cref="EffectiveEventThreatDetectionCustomModuleName"/> with the pattern
        /// <c>
        /// folders/{folder}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveEventThreatDetectionCustomModuleId">
        /// The <c>EffectiveEventThreatDetectionCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="EffectiveEventThreatDetectionCustomModuleName"/> constructed from the provided
        /// ids.
        /// </returns>
        public static EffectiveEventThreatDetectionCustomModuleName FromFolderLocationEffectiveEventThreatDetectionCustomModule(string folderId, string locationId, string effectiveEventThreatDetectionCustomModuleId) =>
            new EffectiveEventThreatDetectionCustomModuleName(ResourceNameType.FolderLocationEffectiveEventThreatDetectionCustomModule, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), effectiveEventThreatDetectionCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveEventThreatDetectionCustomModuleId, nameof(effectiveEventThreatDetectionCustomModuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="EffectiveEventThreatDetectionCustomModuleName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveEventThreatDetectionCustomModuleId">
        /// The <c>EffectiveEventThreatDetectionCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EffectiveEventThreatDetectionCustomModuleName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// .
        /// </returns>
        public static string Format(string organizationId, string locationId, string effectiveEventThreatDetectionCustomModuleId) =>
            FormatOrganizationLocationEffectiveEventThreatDetectionCustomModule(organizationId, locationId, effectiveEventThreatDetectionCustomModuleId);

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="EffectiveEventThreatDetectionCustomModuleName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveEventThreatDetectionCustomModuleId">
        /// The <c>EffectiveEventThreatDetectionCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EffectiveEventThreatDetectionCustomModuleName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationLocationEffectiveEventThreatDetectionCustomModule(string organizationId, string locationId, string effectiveEventThreatDetectionCustomModuleId) =>
            s_organizationLocationEffectiveEventThreatDetectionCustomModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveEventThreatDetectionCustomModuleId, nameof(effectiveEventThreatDetectionCustomModuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="EffectiveEventThreatDetectionCustomModuleName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveEventThreatDetectionCustomModuleId">
        /// The <c>EffectiveEventThreatDetectionCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EffectiveEventThreatDetectionCustomModuleName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationEffectiveEventThreatDetectionCustomModule(string projectId, string locationId, string effectiveEventThreatDetectionCustomModuleId) =>
            s_projectLocationEffectiveEventThreatDetectionCustomModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveEventThreatDetectionCustomModuleId, nameof(effectiveEventThreatDetectionCustomModuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="EffectiveEventThreatDetectionCustomModuleName"/> with pattern
        /// <c>
        /// folders/{folder}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveEventThreatDetectionCustomModuleId">
        /// The <c>EffectiveEventThreatDetectionCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EffectiveEventThreatDetectionCustomModuleName"/> with pattern
        /// <c>
        /// folders/{folder}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// .
        /// </returns>
        public static string FormatFolderLocationEffectiveEventThreatDetectionCustomModule(string folderId, string locationId, string effectiveEventThreatDetectionCustomModuleId) =>
            s_folderLocationEffectiveEventThreatDetectionCustomModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveEventThreatDetectionCustomModuleId, nameof(effectiveEventThreatDetectionCustomModuleId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EffectiveEventThreatDetectionCustomModuleName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="effectiveEventThreatDetectionCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="EffectiveEventThreatDetectionCustomModuleName"/> if successful.</returns>
        public static EffectiveEventThreatDetectionCustomModuleName Parse(string effectiveEventThreatDetectionCustomModuleName) =>
            Parse(effectiveEventThreatDetectionCustomModuleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EffectiveEventThreatDetectionCustomModuleName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="effectiveEventThreatDetectionCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EffectiveEventThreatDetectionCustomModuleName"/> if successful.</returns>
        public static EffectiveEventThreatDetectionCustomModuleName Parse(string effectiveEventThreatDetectionCustomModuleName, bool allowUnparsed) =>
            TryParse(effectiveEventThreatDetectionCustomModuleName, allowUnparsed, out EffectiveEventThreatDetectionCustomModuleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="EffectiveEventThreatDetectionCustomModuleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="effectiveEventThreatDetectionCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EffectiveEventThreatDetectionCustomModuleName"/>, or <c>null</c>
        ///  if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string effectiveEventThreatDetectionCustomModuleName, out EffectiveEventThreatDetectionCustomModuleName result) =>
            TryParse(effectiveEventThreatDetectionCustomModuleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="EffectiveEventThreatDetectionCustomModuleName"/> instance; optionally allowing an unparseable
        /// resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="effectiveEventThreatDetectionCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EffectiveEventThreatDetectionCustomModuleName"/>, or <c>null</c>
        ///  if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string effectiveEventThreatDetectionCustomModuleName, bool allowUnparsed, out EffectiveEventThreatDetectionCustomModuleName result)
        {
            gax::GaxPreconditions.CheckNotNull(effectiveEventThreatDetectionCustomModuleName, nameof(effectiveEventThreatDetectionCustomModuleName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationEffectiveEventThreatDetectionCustomModule.TryParseName(effectiveEventThreatDetectionCustomModuleName, out resourceName))
            {
                result = FromOrganizationLocationEffectiveEventThreatDetectionCustomModule(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationEffectiveEventThreatDetectionCustomModule.TryParseName(effectiveEventThreatDetectionCustomModuleName, out resourceName))
            {
                result = FromProjectLocationEffectiveEventThreatDetectionCustomModule(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationEffectiveEventThreatDetectionCustomModule.TryParseName(effectiveEventThreatDetectionCustomModuleName, out resourceName))
            {
                result = FromFolderLocationEffectiveEventThreatDetectionCustomModule(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(effectiveEventThreatDetectionCustomModuleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EffectiveEventThreatDetectionCustomModuleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string effectiveEventThreatDetectionCustomModuleId = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EffectiveEventThreatDetectionCustomModuleId = effectiveEventThreatDetectionCustomModuleId;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EffectiveEventThreatDetectionCustomModuleName"/> class from the
        /// component parts of pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/effectiveEventThreatDetectionCustomModules/{effective_event_threat_detection_custom_module}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="effectiveEventThreatDetectionCustomModuleId">
        /// The <c>EffectiveEventThreatDetectionCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public EffectiveEventThreatDetectionCustomModuleName(string organizationId, string locationId, string effectiveEventThreatDetectionCustomModuleId) : this(ResourceNameType.OrganizationLocationEffectiveEventThreatDetectionCustomModule, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), effectiveEventThreatDetectionCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(effectiveEventThreatDetectionCustomModuleId, nameof(effectiveEventThreatDetectionCustomModuleId)))
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
        /// The <c>EffectiveEventThreatDetectionCustomModule</c> ID. May be <c>null</c>, depending on which resource
        /// name is contained by this instance.
        /// </summary>
        public string EffectiveEventThreatDetectionCustomModuleId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.OrganizationLocationEffectiveEventThreatDetectionCustomModule: return s_organizationLocationEffectiveEventThreatDetectionCustomModule.Expand(OrganizationId, LocationId, EffectiveEventThreatDetectionCustomModuleId);
                case ResourceNameType.ProjectLocationEffectiveEventThreatDetectionCustomModule: return s_projectLocationEffectiveEventThreatDetectionCustomModule.Expand(ProjectId, LocationId, EffectiveEventThreatDetectionCustomModuleId);
                case ResourceNameType.FolderLocationEffectiveEventThreatDetectionCustomModule: return s_folderLocationEffectiveEventThreatDetectionCustomModule.Expand(FolderId, LocationId, EffectiveEventThreatDetectionCustomModuleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EffectiveEventThreatDetectionCustomModuleName);

        /// <inheritdoc/>
        public bool Equals(EffectiveEventThreatDetectionCustomModuleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EffectiveEventThreatDetectionCustomModuleName a, EffectiveEventThreatDetectionCustomModuleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EffectiveEventThreatDetectionCustomModuleName a, EffectiveEventThreatDetectionCustomModuleName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>EventThreatDetectionCustomModule</c> resource.</summary>
    public sealed partial class EventThreatDetectionCustomModuleName : gax::IResourceName, sys::IEquatable<EventThreatDetectionCustomModuleName>
    {
        /// <summary>The possible contents of <see cref="EventThreatDetectionCustomModuleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
            /// .
            /// </summary>
            OrganizationLocationEventThreatDetectionCustomModule = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
            /// .
            /// </summary>
            ProjectLocationEventThreatDetectionCustomModule = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
            /// .
            /// </summary>
            FolderLocationEventThreatDetectionCustomModule = 3,
        }

        private static gax::PathTemplate s_organizationLocationEventThreatDetectionCustomModule = new gax::PathTemplate("organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}");

        private static gax::PathTemplate s_projectLocationEventThreatDetectionCustomModule = new gax::PathTemplate("projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}");

        private static gax::PathTemplate s_folderLocationEventThreatDetectionCustomModule = new gax::PathTemplate("folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}");

        /// <summary>
        /// Creates a <see cref="EventThreatDetectionCustomModuleName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EventThreatDetectionCustomModuleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EventThreatDetectionCustomModuleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EventThreatDetectionCustomModuleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EventThreatDetectionCustomModuleName"/> with the pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventThreatDetectionCustomModuleId">
        /// The <c>EventThreatDetectionCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="EventThreatDetectionCustomModuleName"/> constructed from the provided ids.
        /// </returns>
        public static EventThreatDetectionCustomModuleName FromOrganizationLocationEventThreatDetectionCustomModule(string organizationId, string locationId, string eventThreatDetectionCustomModuleId) =>
            new EventThreatDetectionCustomModuleName(ResourceNameType.OrganizationLocationEventThreatDetectionCustomModule, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), eventThreatDetectionCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventThreatDetectionCustomModuleId, nameof(eventThreatDetectionCustomModuleId)));

        /// <summary>
        /// Creates a <see cref="EventThreatDetectionCustomModuleName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventThreatDetectionCustomModuleId">
        /// The <c>EventThreatDetectionCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="EventThreatDetectionCustomModuleName"/> constructed from the provided ids.
        /// </returns>
        public static EventThreatDetectionCustomModuleName FromProjectLocationEventThreatDetectionCustomModule(string projectId, string locationId, string eventThreatDetectionCustomModuleId) =>
            new EventThreatDetectionCustomModuleName(ResourceNameType.ProjectLocationEventThreatDetectionCustomModule, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), eventThreatDetectionCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventThreatDetectionCustomModuleId, nameof(eventThreatDetectionCustomModuleId)));

        /// <summary>
        /// Creates a <see cref="EventThreatDetectionCustomModuleName"/> with the pattern
        /// <c>
        /// folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventThreatDetectionCustomModuleId">
        /// The <c>EventThreatDetectionCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="EventThreatDetectionCustomModuleName"/> constructed from the provided ids.
        /// </returns>
        public static EventThreatDetectionCustomModuleName FromFolderLocationEventThreatDetectionCustomModule(string folderId, string locationId, string eventThreatDetectionCustomModuleId) =>
            new EventThreatDetectionCustomModuleName(ResourceNameType.FolderLocationEventThreatDetectionCustomModule, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), eventThreatDetectionCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventThreatDetectionCustomModuleId, nameof(eventThreatDetectionCustomModuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EventThreatDetectionCustomModuleName"/>
        /// with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventThreatDetectionCustomModuleId">
        /// The <c>EventThreatDetectionCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EventThreatDetectionCustomModuleName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// .
        /// </returns>
        public static string Format(string organizationId, string locationId, string eventThreatDetectionCustomModuleId) =>
            FormatOrganizationLocationEventThreatDetectionCustomModule(organizationId, locationId, eventThreatDetectionCustomModuleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EventThreatDetectionCustomModuleName"/>
        /// with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventThreatDetectionCustomModuleId">
        /// The <c>EventThreatDetectionCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EventThreatDetectionCustomModuleName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationLocationEventThreatDetectionCustomModule(string organizationId, string locationId, string eventThreatDetectionCustomModuleId) =>
            s_organizationLocationEventThreatDetectionCustomModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(eventThreatDetectionCustomModuleId, nameof(eventThreatDetectionCustomModuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EventThreatDetectionCustomModuleName"/>
        /// with pattern
        /// <c>
        /// projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventThreatDetectionCustomModuleId">
        /// The <c>EventThreatDetectionCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EventThreatDetectionCustomModuleName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationEventThreatDetectionCustomModule(string projectId, string locationId, string eventThreatDetectionCustomModuleId) =>
            s_projectLocationEventThreatDetectionCustomModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(eventThreatDetectionCustomModuleId, nameof(eventThreatDetectionCustomModuleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EventThreatDetectionCustomModuleName"/>
        /// with pattern
        /// <c>
        /// folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// .
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventThreatDetectionCustomModuleId">
        /// The <c>EventThreatDetectionCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="EventThreatDetectionCustomModuleName"/> with pattern
        /// <c>
        /// folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// .
        /// </returns>
        public static string FormatFolderLocationEventThreatDetectionCustomModule(string folderId, string locationId, string eventThreatDetectionCustomModuleId) =>
            s_folderLocationEventThreatDetectionCustomModule.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(eventThreatDetectionCustomModuleId, nameof(eventThreatDetectionCustomModuleId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EventThreatDetectionCustomModuleName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="eventThreatDetectionCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="EventThreatDetectionCustomModuleName"/> if successful.</returns>
        public static EventThreatDetectionCustomModuleName Parse(string eventThreatDetectionCustomModuleName) =>
            Parse(eventThreatDetectionCustomModuleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EventThreatDetectionCustomModuleName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="eventThreatDetectionCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EventThreatDetectionCustomModuleName"/> if successful.</returns>
        public static EventThreatDetectionCustomModuleName Parse(string eventThreatDetectionCustomModuleName, bool allowUnparsed) =>
            TryParse(eventThreatDetectionCustomModuleName, allowUnparsed, out EventThreatDetectionCustomModuleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EventThreatDetectionCustomModuleName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="eventThreatDetectionCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EventThreatDetectionCustomModuleName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string eventThreatDetectionCustomModuleName, out EventThreatDetectionCustomModuleName result) =>
            TryParse(eventThreatDetectionCustomModuleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EventThreatDetectionCustomModuleName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// folders/{folder}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="eventThreatDetectionCustomModuleName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EventThreatDetectionCustomModuleName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string eventThreatDetectionCustomModuleName, bool allowUnparsed, out EventThreatDetectionCustomModuleName result)
        {
            gax::GaxPreconditions.CheckNotNull(eventThreatDetectionCustomModuleName, nameof(eventThreatDetectionCustomModuleName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocationEventThreatDetectionCustomModule.TryParseName(eventThreatDetectionCustomModuleName, out resourceName))
            {
                result = FromOrganizationLocationEventThreatDetectionCustomModule(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectLocationEventThreatDetectionCustomModule.TryParseName(eventThreatDetectionCustomModuleName, out resourceName))
            {
                result = FromProjectLocationEventThreatDetectionCustomModule(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationEventThreatDetectionCustomModule.TryParseName(eventThreatDetectionCustomModuleName, out resourceName))
            {
                result = FromFolderLocationEventThreatDetectionCustomModule(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(eventThreatDetectionCustomModuleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EventThreatDetectionCustomModuleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string eventThreatDetectionCustomModuleId = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            EventThreatDetectionCustomModuleId = eventThreatDetectionCustomModuleId;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EventThreatDetectionCustomModuleName"/> class from the component
        /// parts of pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/eventThreatDetectionCustomModules/{event_threat_detection_custom_module}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="eventThreatDetectionCustomModuleId">
        /// The <c>EventThreatDetectionCustomModule</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public EventThreatDetectionCustomModuleName(string organizationId, string locationId, string eventThreatDetectionCustomModuleId) : this(ResourceNameType.OrganizationLocationEventThreatDetectionCustomModule, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), eventThreatDetectionCustomModuleId: gax::GaxPreconditions.CheckNotNullOrEmpty(eventThreatDetectionCustomModuleId, nameof(eventThreatDetectionCustomModuleId)))
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
        /// The <c>EventThreatDetectionCustomModule</c> ID. May be <c>null</c>, depending on which resource name is
        /// contained by this instance.
        /// </summary>
        public string EventThreatDetectionCustomModuleId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Organization</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string OrganizationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.OrganizationLocationEventThreatDetectionCustomModule: return s_organizationLocationEventThreatDetectionCustomModule.Expand(OrganizationId, LocationId, EventThreatDetectionCustomModuleId);
                case ResourceNameType.ProjectLocationEventThreatDetectionCustomModule: return s_projectLocationEventThreatDetectionCustomModule.Expand(ProjectId, LocationId, EventThreatDetectionCustomModuleId);
                case ResourceNameType.FolderLocationEventThreatDetectionCustomModule: return s_folderLocationEventThreatDetectionCustomModule.Expand(FolderId, LocationId, EventThreatDetectionCustomModuleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EventThreatDetectionCustomModuleName);

        /// <inheritdoc/>
        public bool Equals(EventThreatDetectionCustomModuleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EventThreatDetectionCustomModuleName a, EventThreatDetectionCustomModuleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EventThreatDetectionCustomModuleName a, EventThreatDetectionCustomModuleName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>OrganizationLocation</c> resource.</summary>
    public sealed partial class OrganizationLocationName : gax::IResourceName, sys::IEquatable<OrganizationLocationName>
    {
        /// <summary>The possible contents of <see cref="OrganizationLocationName"/>.</summary>
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

        /// <summary>Creates a <see cref="OrganizationLocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OrganizationLocationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OrganizationLocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OrganizationLocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OrganizationLocationName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="OrganizationLocationName"/> constructed from the provided ids.
        /// </returns>
        public static OrganizationLocationName FromOrganizationLocation(string organizationId, string locationId) =>
            new OrganizationLocationName(ResourceNameType.OrganizationLocation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </returns>
        public static string Format(string organizationId, string locationId) =>
            FormatOrganizationLocation(organizationId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OrganizationLocationName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}</c>.
        /// </returns>
        public static string FormatOrganizationLocation(string organizationId, string locationId) =>
            s_organizationLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrganizationLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OrganizationLocationName"/> if successful.</returns>
        public static OrganizationLocationName Parse(string organizationLocationName) =>
            Parse(organizationLocationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OrganizationLocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OrganizationLocationName"/> if successful.</returns>
        public static OrganizationLocationName Parse(string organizationLocationName, bool allowUnparsed) =>
            TryParse(organizationLocationName, allowUnparsed, out OrganizationLocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrganizationLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationLocationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationLocationName, out OrganizationLocationName result) =>
            TryParse(organizationLocationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OrganizationLocationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>organizations/{organization}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="organizationLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OrganizationLocationName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string organizationLocationName, bool allowUnparsed, out OrganizationLocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(organizationLocationName, nameof(organizationLocationName));
            gax::TemplatedResourceName resourceName;
            if (s_organizationLocation.TryParseName(organizationLocationName, out resourceName))
            {
                result = FromOrganizationLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(organizationLocationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OrganizationLocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string organizationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            OrganizationId = organizationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OrganizationLocationName"/> class from the component parts of
        /// pattern <c>organizations/{organization}/locations/{location}</c>
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public OrganizationLocationName(string organizationId, string locationId) : this(ResourceNameType.OrganizationLocation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
        public override bool Equals(object obj) => Equals(obj as OrganizationLocationName);

        /// <inheritdoc/>
        public bool Equals(OrganizationLocationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OrganizationLocationName a, OrganizationLocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OrganizationLocationName a, OrganizationLocationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FolderLocation</c> resource.</summary>
    public sealed partial class FolderLocationName : gax::IResourceName, sys::IEquatable<FolderLocationName>
    {
        /// <summary>The possible contents of <see cref="FolderLocationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>folders/{folder}/locations/{location}</c>.</summary>
            FolderLocation = 1,
        }

        private static gax::PathTemplate s_folderLocation = new gax::PathTemplate("folders/{folder}/locations/{location}");

        /// <summary>Creates a <see cref="FolderLocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FolderLocationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FolderLocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FolderLocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FolderLocationName"/> with the pattern <c>folders/{folder}/locations/{location}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FolderLocationName"/> constructed from the provided ids.</returns>
        public static FolderLocationName FromFolderLocation(string folderId, string locationId) =>
            new FolderLocationName(ResourceNameType.FolderLocation, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </returns>
        public static string Format(string folderId, string locationId) => FormatFolderLocation(folderId, locationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FolderLocationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}</c>.
        /// </returns>
        public static string FormatFolderLocation(string folderId, string locationId) =>
            s_folderLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FolderLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FolderLocationName"/> if successful.</returns>
        public static FolderLocationName Parse(string folderLocationName) => Parse(folderLocationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FolderLocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FolderLocationName"/> if successful.</returns>
        public static FolderLocationName Parse(string folderLocationName, bool allowUnparsed) =>
            TryParse(folderLocationName, allowUnparsed, out FolderLocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FolderLocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FolderLocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string folderLocationName, out FolderLocationName result) =>
            TryParse(folderLocationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FolderLocationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>folders/{folder}/locations/{location}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="folderLocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FolderLocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string folderLocationName, bool allowUnparsed, out FolderLocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(folderLocationName, nameof(folderLocationName));
            gax::TemplatedResourceName resourceName;
            if (s_folderLocation.TryParseName(folderLocationName, out resourceName))
            {
                result = FromFolderLocation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(folderLocationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FolderLocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FolderLocationName"/> class from the component parts of pattern
        /// <c>folders/{folder}/locations/{location}</c>
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        public FolderLocationName(string folderId, string locationId) : this(ResourceNameType.FolderLocation, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)))
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
        /// The <c>Folder</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.FolderLocation: return s_folderLocation.Expand(FolderId, LocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FolderLocationName);

        /// <inheritdoc/>
        public bool Equals(FolderLocationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FolderLocationName a, FolderLocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FolderLocationName a, FolderLocationName b) => !(a == b);
    }

    public partial class SecurityCenterService
    {
        /// <summary>
        /// <see cref="gcsv::SecurityCenterServiceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SecurityCenterServiceName SecurityCenterServiceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecurityCenterServiceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EffectiveSecurityHealthAnalyticsCustomModule
    {
        /// <summary>
        /// <see cref="gcsv::EffectiveSecurityHealthAnalyticsCustomModuleName"/>-typed view over the <see cref="Name"/>
        /// resource name property.
        /// </summary>
        public gcsv::EffectiveSecurityHealthAnalyticsCustomModuleName EffectiveSecurityHealthAnalyticsCustomModuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::EffectiveSecurityHealthAnalyticsCustomModuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEffectiveSecurityHealthAnalyticsCustomModulesRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetEffectiveSecurityHealthAnalyticsCustomModuleRequest
    {
        /// <summary>
        /// <see cref="gcsv::EffectiveSecurityHealthAnalyticsCustomModuleName"/>-typed view over the <see cref="Name"/>
        /// resource name property.
        /// </summary>
        public gcsv::EffectiveSecurityHealthAnalyticsCustomModuleName EffectiveSecurityHealthAnalyticsCustomModuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::EffectiveSecurityHealthAnalyticsCustomModuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SecurityHealthAnalyticsCustomModule
    {
        /// <summary>
        /// <see cref="gcsv::SecurityHealthAnalyticsCustomModuleName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gcsv::SecurityHealthAnalyticsCustomModuleName SecurityHealthAnalyticsCustomModuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecurityHealthAnalyticsCustomModuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcsv::SecurityHealthAnalyticsCustomModuleName"/>-typed view over the <see cref="AncestorModule"/>
        /// resource name property.
        /// </summary>
        public gcsv::SecurityHealthAnalyticsCustomModuleName AncestorModuleAsSecurityHealthAnalyticsCustomModuleName
        {
            get => string.IsNullOrEmpty(AncestorModule) ? null : gcsv::SecurityHealthAnalyticsCustomModuleName.Parse(AncestorModule, allowUnparsed: true);
            set => AncestorModule = value?.ToString() ?? "";
        }
    }

    public partial class ListSecurityHealthAnalyticsCustomModulesRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListDescendantSecurityHealthAnalyticsCustomModulesRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSecurityHealthAnalyticsCustomModuleRequest
    {
        /// <summary>
        /// <see cref="gcsv::SecurityHealthAnalyticsCustomModuleName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gcsv::SecurityHealthAnalyticsCustomModuleName SecurityHealthAnalyticsCustomModuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecurityHealthAnalyticsCustomModuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSecurityHealthAnalyticsCustomModuleRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSecurityHealthAnalyticsCustomModuleRequest
    {
        /// <summary>
        /// <see cref="gcsv::SecurityHealthAnalyticsCustomModuleName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gcsv::SecurityHealthAnalyticsCustomModuleName SecurityHealthAnalyticsCustomModuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecurityHealthAnalyticsCustomModuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SimulatedFinding
    {
        /// <summary>
        /// <see cref="gcsv::FindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::FindingName FindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::FindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EffectiveEventThreatDetectionCustomModule
    {
        /// <summary>
        /// <see cref="gcsv::EffectiveEventThreatDetectionCustomModuleName"/>-typed view over the <see cref="Name"/>
        /// resource name property.
        /// </summary>
        public gcsv::EffectiveEventThreatDetectionCustomModuleName EffectiveEventThreatDetectionCustomModuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::EffectiveEventThreatDetectionCustomModuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEffectiveEventThreatDetectionCustomModulesRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetEffectiveEventThreatDetectionCustomModuleRequest
    {
        /// <summary>
        /// <see cref="gcsv::EffectiveEventThreatDetectionCustomModuleName"/>-typed view over the <see cref="Name"/>
        /// resource name property.
        /// </summary>
        public gcsv::EffectiveEventThreatDetectionCustomModuleName EffectiveEventThreatDetectionCustomModuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::EffectiveEventThreatDetectionCustomModuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EventThreatDetectionCustomModule
    {
        /// <summary>
        /// <see cref="gcsv::EventThreatDetectionCustomModuleName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gcsv::EventThreatDetectionCustomModuleName EventThreatDetectionCustomModuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::EventThreatDetectionCustomModuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcsv::EventThreatDetectionCustomModuleName"/>-typed view over the <see cref="AncestorModule"/>
        /// resource name property.
        /// </summary>
        public gcsv::EventThreatDetectionCustomModuleName AncestorModuleAsEventThreatDetectionCustomModuleName
        {
            get => string.IsNullOrEmpty(AncestorModule) ? null : gcsv::EventThreatDetectionCustomModuleName.Parse(AncestorModule, allowUnparsed: true);
            set => AncestorModule = value?.ToString() ?? "";
        }
    }

    public partial class ListEventThreatDetectionCustomModulesRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListDescendantEventThreatDetectionCustomModulesRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetEventThreatDetectionCustomModuleRequest
    {
        /// <summary>
        /// <see cref="gcsv::EventThreatDetectionCustomModuleName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gcsv::EventThreatDetectionCustomModuleName EventThreatDetectionCustomModuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::EventThreatDetectionCustomModuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateEventThreatDetectionCustomModuleRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEventThreatDetectionCustomModuleRequest
    {
        /// <summary>
        /// <see cref="gcsv::EventThreatDetectionCustomModuleName"/>-typed view over the <see cref="Name"/> resource
        /// name property.
        /// </summary>
        public gcsv::EventThreatDetectionCustomModuleName EventThreatDetectionCustomModuleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::EventThreatDetectionCustomModuleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ValidateEventThreatDetectionCustomModuleRequest
    {
        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSecurityCenterServiceRequest
    {
        /// <summary>
        /// <see cref="gcsv::SecurityCenterServiceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::SecurityCenterServiceName SecurityCenterServiceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::SecurityCenterServiceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSecurityCenterServicesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FolderLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FolderLocationName ParentAsFolderLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FolderLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="OrganizationLocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public OrganizationLocationName ParentAsOrganizationLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : OrganizationLocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gax::IResourceName ParentAsResourceName
        {
            get
            {
                if (string.IsNullOrEmpty(Parent))
                {
                    return null;
                }
                if (gagr::LocationName.TryParse(Parent, out gagr::LocationName location))
                {
                    return location;
                }
                if (FolderLocationName.TryParse(Parent, out FolderLocationName folderLocation))
                {
                    return folderLocation;
                }
                if (OrganizationLocationName.TryParse(Parent, out OrganizationLocationName organizationLocation))
                {
                    return organizationLocation;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }
}
