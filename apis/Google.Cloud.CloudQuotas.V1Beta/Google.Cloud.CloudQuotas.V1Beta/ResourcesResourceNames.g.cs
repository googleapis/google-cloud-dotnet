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
using gccv = Google.Cloud.CloudQuotas.V1Beta;
using sys = System;

namespace Google.Cloud.CloudQuotas.V1Beta
{
    /// <summary>Resource name for the <c>QuotaInfo</c> resource.</summary>
    public sealed partial class QuotaInfoName : gax::IResourceName, sys::IEquatable<QuotaInfoName>
    {
        /// <summary>The possible contents of <see cref="QuotaInfoName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>.
            /// </summary>
            ProjectLocationServiceQuotaInfo = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>folders/{folder}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>.
            /// </summary>
            FolderLocationServiceQuotaInfo = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>.
            /// </summary>
            OrganizationLocationServiceQuotaInfo = 3,
        }

        private static gax::PathTemplate s_projectLocationServiceQuotaInfo = new gax::PathTemplate("projects/{project}/locations/{location}/services/{service}/quotaInfos/{quota_info}");

        private static gax::PathTemplate s_folderLocationServiceQuotaInfo = new gax::PathTemplate("folders/{folder}/locations/{location}/services/{service}/quotaInfos/{quota_info}");

        private static gax::PathTemplate s_organizationLocationServiceQuotaInfo = new gax::PathTemplate("organizations/{organization}/locations/{location}/services/{service}/quotaInfos/{quota_info}");

        /// <summary>Creates a <see cref="QuotaInfoName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="QuotaInfoName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static QuotaInfoName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new QuotaInfoName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="QuotaInfoName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaInfoId">The <c>QuotaInfo</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="QuotaInfoName"/> constructed from the provided ids.</returns>
        public static QuotaInfoName FromProjectLocationServiceQuotaInfo(string projectId, string locationId, string serviceId, string quotaInfoId) =>
            new QuotaInfoName(ResourceNameType.ProjectLocationServiceQuotaInfo, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), quotaInfoId: gax::GaxPreconditions.CheckNotNullOrEmpty(quotaInfoId, nameof(quotaInfoId)));

        /// <summary>
        /// Creates a <see cref="QuotaInfoName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaInfoId">The <c>QuotaInfo</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="QuotaInfoName"/> constructed from the provided ids.</returns>
        public static QuotaInfoName FromFolderLocationServiceQuotaInfo(string folderId, string locationId, string serviceId, string quotaInfoId) =>
            new QuotaInfoName(ResourceNameType.FolderLocationServiceQuotaInfo, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), quotaInfoId: gax::GaxPreconditions.CheckNotNullOrEmpty(quotaInfoId, nameof(quotaInfoId)));

        /// <summary>
        /// Creates a <see cref="QuotaInfoName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaInfoId">The <c>QuotaInfo</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="QuotaInfoName"/> constructed from the provided ids.</returns>
        public static QuotaInfoName FromOrganizationLocationServiceQuotaInfo(string organizationId, string locationId, string serviceId, string quotaInfoId) =>
            new QuotaInfoName(ResourceNameType.OrganizationLocationServiceQuotaInfo, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), quotaInfoId: gax::GaxPreconditions.CheckNotNullOrEmpty(quotaInfoId, nameof(quotaInfoId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QuotaInfoName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaInfoId">The <c>QuotaInfo</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QuotaInfoName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string serviceId, string quotaInfoId) =>
            FormatProjectLocationServiceQuotaInfo(projectId, locationId, serviceId, quotaInfoId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QuotaInfoName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaInfoId">The <c>QuotaInfo</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QuotaInfoName"/> with pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>.
        /// </returns>
        public static string FormatProjectLocationServiceQuotaInfo(string projectId, string locationId, string serviceId, string quotaInfoId) =>
            s_projectLocationServiceQuotaInfo.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(quotaInfoId, nameof(quotaInfoId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QuotaInfoName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaInfoId">The <c>QuotaInfo</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QuotaInfoName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>.
        /// </returns>
        public static string FormatFolderLocationServiceQuotaInfo(string folderId, string locationId, string serviceId, string quotaInfoId) =>
            s_folderLocationServiceQuotaInfo.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(quotaInfoId, nameof(quotaInfoId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QuotaInfoName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaInfoId">The <c>QuotaInfo</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QuotaInfoName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>.
        /// </returns>
        public static string FormatOrganizationLocationServiceQuotaInfo(string organizationId, string locationId, string serviceId, string quotaInfoId) =>
            s_organizationLocationServiceQuotaInfo.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(quotaInfoId, nameof(quotaInfoId)));

        /// <summary>Parses the given resource name string into a new <see cref="QuotaInfoName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="quotaInfoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="QuotaInfoName"/> if successful.</returns>
        public static QuotaInfoName Parse(string quotaInfoName) => Parse(quotaInfoName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="QuotaInfoName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="quotaInfoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="QuotaInfoName"/> if successful.</returns>
        public static QuotaInfoName Parse(string quotaInfoName, bool allowUnparsed) =>
            TryParse(quotaInfoName, allowUnparsed, out QuotaInfoName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QuotaInfoName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="quotaInfoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QuotaInfoName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string quotaInfoName, out QuotaInfoName result) => TryParse(quotaInfoName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QuotaInfoName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="quotaInfoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QuotaInfoName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string quotaInfoName, bool allowUnparsed, out QuotaInfoName result)
        {
            gax::GaxPreconditions.CheckNotNull(quotaInfoName, nameof(quotaInfoName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationServiceQuotaInfo.TryParseName(quotaInfoName, out resourceName))
            {
                result = FromProjectLocationServiceQuotaInfo(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_folderLocationServiceQuotaInfo.TryParseName(quotaInfoName, out resourceName))
            {
                result = FromFolderLocationServiceQuotaInfo(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_organizationLocationServiceQuotaInfo.TryParseName(quotaInfoName, out resourceName))
            {
                result = FromOrganizationLocationServiceQuotaInfo(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(quotaInfoName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private QuotaInfoName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null, string quotaInfoId = null, string serviceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            QuotaInfoId = quotaInfoId;
            ServiceId = serviceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="QuotaInfoName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/services/{service}/quotaInfos/{quota_info}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="serviceId">The <c>Service</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaInfoId">The <c>QuotaInfo</c> ID. Must not be <c>null</c> or empty.</param>
        public QuotaInfoName(string projectId, string locationId, string serviceId, string quotaInfoId) : this(ResourceNameType.ProjectLocationServiceQuotaInfo, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), serviceId: gax::GaxPreconditions.CheckNotNullOrEmpty(serviceId, nameof(serviceId)), quotaInfoId: gax::GaxPreconditions.CheckNotNullOrEmpty(quotaInfoId, nameof(quotaInfoId)))
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
        /// The <c>QuotaInfo</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string QuotaInfoId { get; }

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
                case ResourceNameType.ProjectLocationServiceQuotaInfo: return s_projectLocationServiceQuotaInfo.Expand(ProjectId, LocationId, ServiceId, QuotaInfoId);
                case ResourceNameType.FolderLocationServiceQuotaInfo: return s_folderLocationServiceQuotaInfo.Expand(FolderId, LocationId, ServiceId, QuotaInfoId);
                case ResourceNameType.OrganizationLocationServiceQuotaInfo: return s_organizationLocationServiceQuotaInfo.Expand(OrganizationId, LocationId, ServiceId, QuotaInfoId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as QuotaInfoName);

        /// <inheritdoc/>
        public bool Equals(QuotaInfoName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(QuotaInfoName a, QuotaInfoName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(QuotaInfoName a, QuotaInfoName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>QuotaPreference</c> resource.</summary>
    public sealed partial class QuotaPreferenceName : gax::IResourceName, sys::IEquatable<QuotaPreferenceName>
    {
        /// <summary>The possible contents of <see cref="QuotaPreferenceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/quotaPreferences/{quota_preference}</c>.
            /// </summary>
            ProjectLocationQuotaPreference = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>folders/{folder}/locations/{location}/quotaPreferences/{quota_preference}</c>.
            /// </summary>
            FolderLocationQuotaPreference = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/quotaPreferences/{quota_preference}</c>.
            /// </summary>
            OrganizationLocationQuotaPreference = 3,
        }

        private static gax::PathTemplate s_projectLocationQuotaPreference = new gax::PathTemplate("projects/{project}/locations/{location}/quotaPreferences/{quota_preference}");

        private static gax::PathTemplate s_folderLocationQuotaPreference = new gax::PathTemplate("folders/{folder}/locations/{location}/quotaPreferences/{quota_preference}");

        private static gax::PathTemplate s_organizationLocationQuotaPreference = new gax::PathTemplate("organizations/{organization}/locations/{location}/quotaPreferences/{quota_preference}");

        /// <summary>Creates a <see cref="QuotaPreferenceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="QuotaPreferenceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static QuotaPreferenceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new QuotaPreferenceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="QuotaPreferenceName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/quotaPreferences/{quota_preference}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaPreferenceId">The <c>QuotaPreference</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="QuotaPreferenceName"/> constructed from the provided ids.</returns>
        public static QuotaPreferenceName FromProjectLocationQuotaPreference(string projectId, string locationId, string quotaPreferenceId) =>
            new QuotaPreferenceName(ResourceNameType.ProjectLocationQuotaPreference, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), quotaPreferenceId: gax::GaxPreconditions.CheckNotNullOrEmpty(quotaPreferenceId, nameof(quotaPreferenceId)));

        /// <summary>
        /// Creates a <see cref="QuotaPreferenceName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/quotaPreferences/{quota_preference}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaPreferenceId">The <c>QuotaPreference</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="QuotaPreferenceName"/> constructed from the provided ids.</returns>
        public static QuotaPreferenceName FromFolderLocationQuotaPreference(string folderId, string locationId, string quotaPreferenceId) =>
            new QuotaPreferenceName(ResourceNameType.FolderLocationQuotaPreference, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), quotaPreferenceId: gax::GaxPreconditions.CheckNotNullOrEmpty(quotaPreferenceId, nameof(quotaPreferenceId)));

        /// <summary>
        /// Creates a <see cref="QuotaPreferenceName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/quotaPreferences/{quota_preference}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaPreferenceId">The <c>QuotaPreference</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="QuotaPreferenceName"/> constructed from the provided ids.</returns>
        public static QuotaPreferenceName FromOrganizationLocationQuotaPreference(string organizationId, string locationId, string quotaPreferenceId) =>
            new QuotaPreferenceName(ResourceNameType.OrganizationLocationQuotaPreference, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), quotaPreferenceId: gax::GaxPreconditions.CheckNotNullOrEmpty(quotaPreferenceId, nameof(quotaPreferenceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QuotaPreferenceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/quotaPreferences/{quota_preference}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaPreferenceId">The <c>QuotaPreference</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QuotaPreferenceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/quotaPreferences/{quota_preference}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string quotaPreferenceId) =>
            FormatProjectLocationQuotaPreference(projectId, locationId, quotaPreferenceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QuotaPreferenceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/quotaPreferences/{quota_preference}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaPreferenceId">The <c>QuotaPreference</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QuotaPreferenceName"/> with pattern
        /// <c>projects/{project}/locations/{location}/quotaPreferences/{quota_preference}</c>.
        /// </returns>
        public static string FormatProjectLocationQuotaPreference(string projectId, string locationId, string quotaPreferenceId) =>
            s_projectLocationQuotaPreference.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(quotaPreferenceId, nameof(quotaPreferenceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QuotaPreferenceName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/quotaPreferences/{quota_preference}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaPreferenceId">The <c>QuotaPreference</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QuotaPreferenceName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/quotaPreferences/{quota_preference}</c>.
        /// </returns>
        public static string FormatFolderLocationQuotaPreference(string folderId, string locationId, string quotaPreferenceId) =>
            s_folderLocationQuotaPreference.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(quotaPreferenceId, nameof(quotaPreferenceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QuotaPreferenceName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/quotaPreferences/{quota_preference}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaPreferenceId">The <c>QuotaPreference</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="QuotaPreferenceName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/quotaPreferences/{quota_preference}</c>.
        /// </returns>
        public static string FormatOrganizationLocationQuotaPreference(string organizationId, string locationId, string quotaPreferenceId) =>
            s_organizationLocationQuotaPreference.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(quotaPreferenceId, nameof(quotaPreferenceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="QuotaPreferenceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/quotaPreferences/{quota_preference}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/quotaPreferences/{quota_preference}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/quotaPreferences/{quota_preference}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="quotaPreferenceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="QuotaPreferenceName"/> if successful.</returns>
        public static QuotaPreferenceName Parse(string quotaPreferenceName) => Parse(quotaPreferenceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="QuotaPreferenceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/quotaPreferences/{quota_preference}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/quotaPreferences/{quota_preference}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/quotaPreferences/{quota_preference}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="quotaPreferenceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="QuotaPreferenceName"/> if successful.</returns>
        public static QuotaPreferenceName Parse(string quotaPreferenceName, bool allowUnparsed) =>
            TryParse(quotaPreferenceName, allowUnparsed, out QuotaPreferenceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QuotaPreferenceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/quotaPreferences/{quota_preference}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/quotaPreferences/{quota_preference}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/quotaPreferences/{quota_preference}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="quotaPreferenceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QuotaPreferenceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string quotaPreferenceName, out QuotaPreferenceName result) =>
            TryParse(quotaPreferenceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QuotaPreferenceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/quotaPreferences/{quota_preference}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/quotaPreferences/{quota_preference}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/quotaPreferences/{quota_preference}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="quotaPreferenceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QuotaPreferenceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string quotaPreferenceName, bool allowUnparsed, out QuotaPreferenceName result)
        {
            gax::GaxPreconditions.CheckNotNull(quotaPreferenceName, nameof(quotaPreferenceName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationQuotaPreference.TryParseName(quotaPreferenceName, out resourceName))
            {
                result = FromProjectLocationQuotaPreference(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationQuotaPreference.TryParseName(quotaPreferenceName, out resourceName))
            {
                result = FromFolderLocationQuotaPreference(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationQuotaPreference.TryParseName(quotaPreferenceName, out resourceName))
            {
                result = FromOrganizationLocationQuotaPreference(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(quotaPreferenceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private QuotaPreferenceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null, string quotaPreferenceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            QuotaPreferenceId = quotaPreferenceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="QuotaPreferenceName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/quotaPreferences/{quota_preference}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="quotaPreferenceId">The <c>QuotaPreference</c> ID. Must not be <c>null</c> or empty.</param>
        public QuotaPreferenceName(string projectId, string locationId, string quotaPreferenceId) : this(ResourceNameType.ProjectLocationQuotaPreference, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), quotaPreferenceId: gax::GaxPreconditions.CheckNotNullOrEmpty(quotaPreferenceId, nameof(quotaPreferenceId)))
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
        /// The <c>QuotaPreference</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string QuotaPreferenceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationQuotaPreference: return s_projectLocationQuotaPreference.Expand(ProjectId, LocationId, QuotaPreferenceId);
                case ResourceNameType.FolderLocationQuotaPreference: return s_folderLocationQuotaPreference.Expand(FolderId, LocationId, QuotaPreferenceId);
                case ResourceNameType.OrganizationLocationQuotaPreference: return s_organizationLocationQuotaPreference.Expand(OrganizationId, LocationId, QuotaPreferenceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as QuotaPreferenceName);

        /// <inheritdoc/>
        public bool Equals(QuotaPreferenceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(QuotaPreferenceName a, QuotaPreferenceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(QuotaPreferenceName a, QuotaPreferenceName b) => !(a == b);
    }

    public partial class QuotaInfo
    {
        /// <summary>
        /// <see cref="gccv::QuotaInfoName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::QuotaInfoName QuotaInfoName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::QuotaInfoName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class QuotaPreference
    {
        /// <summary>
        /// <see cref="gccv::QuotaPreferenceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::QuotaPreferenceName QuotaPreferenceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::QuotaPreferenceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
