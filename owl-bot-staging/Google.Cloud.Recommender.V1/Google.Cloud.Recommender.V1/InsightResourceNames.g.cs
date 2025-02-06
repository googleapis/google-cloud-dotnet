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
using gcrv = Google.Cloud.Recommender.V1;
using sys = System;

namespace Google.Cloud.Recommender.V1
{
    /// <summary>Resource name for the <c>Insight</c> resource.</summary>
    public sealed partial class InsightName : gax::IResourceName, sys::IEquatable<InsightName>
    {
        /// <summary>The possible contents of <see cref="InsightName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>.
            /// </summary>
            ProjectLocationInsightTypeInsight = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
            /// .
            /// </summary>
            BillingAccountLocationInsightTypeInsight = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>folders/{folder}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>.
            /// </summary>
            FolderLocationInsightTypeInsight = 3,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>.
            /// </summary>
            OrganizationLocationInsightTypeInsight = 4,
        }

        private static gax::PathTemplate s_projectLocationInsightTypeInsight = new gax::PathTemplate("projects/{project}/locations/{location}/insightTypes/{insight_type}/insights/{insight}");

        private static gax::PathTemplate s_billingAccountLocationInsightTypeInsight = new gax::PathTemplate("billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}/insights/{insight}");

        private static gax::PathTemplate s_folderLocationInsightTypeInsight = new gax::PathTemplate("folders/{folder}/locations/{location}/insightTypes/{insight_type}/insights/{insight}");

        private static gax::PathTemplate s_organizationLocationInsightTypeInsight = new gax::PathTemplate("organizations/{organization}/locations/{location}/insightTypes/{insight_type}/insights/{insight}");

        /// <summary>Creates a <see cref="InsightName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InsightName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InsightName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InsightName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InsightName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightId">The <c>Insight</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InsightName"/> constructed from the provided ids.</returns>
        public static InsightName FromProjectLocationInsightTypeInsight(string projectId, string locationId, string insightTypeId, string insightId) =>
            new InsightName(ResourceNameType.ProjectLocationInsightTypeInsight, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), insightTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)), insightId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightId, nameof(insightId)));

        /// <summary>
        /// Creates a <see cref="InsightName"/> with the pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// .
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightId">The <c>Insight</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InsightName"/> constructed from the provided ids.</returns>
        public static InsightName FromBillingAccountLocationInsightTypeInsight(string billingAccountId, string locationId, string insightTypeId, string insightId) =>
            new InsightName(ResourceNameType.BillingAccountLocationInsightTypeInsight, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), insightTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)), insightId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightId, nameof(insightId)));

        /// <summary>
        /// Creates a <see cref="InsightName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightId">The <c>Insight</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InsightName"/> constructed from the provided ids.</returns>
        public static InsightName FromFolderLocationInsightTypeInsight(string folderId, string locationId, string insightTypeId, string insightId) =>
            new InsightName(ResourceNameType.FolderLocationInsightTypeInsight, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), insightTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)), insightId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightId, nameof(insightId)));

        /// <summary>
        /// Creates a <see cref="InsightName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightId">The <c>Insight</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InsightName"/> constructed from the provided ids.</returns>
        public static InsightName FromOrganizationLocationInsightTypeInsight(string organizationId, string locationId, string insightTypeId, string insightId) =>
            new InsightName(ResourceNameType.OrganizationLocationInsightTypeInsight, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), insightTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)), insightId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightId, nameof(insightId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InsightName"/> with pattern
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightId">The <c>Insight</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InsightName"/> with pattern
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string insightTypeId, string insightId) =>
            FormatProjectLocationInsightTypeInsight(projectId, locationId, insightTypeId, insightId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InsightName"/> with pattern
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightId">The <c>Insight</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InsightName"/> with pattern
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>.
        /// </returns>
        public static string FormatProjectLocationInsightTypeInsight(string projectId, string locationId, string insightTypeId, string insightId) =>
            s_projectLocationInsightTypeInsight.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(insightId, nameof(insightId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InsightName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// .
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightId">The <c>Insight</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InsightName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// .
        /// </returns>
        public static string FormatBillingAccountLocationInsightTypeInsight(string billingAccountId, string locationId, string insightTypeId, string insightId) =>
            s_billingAccountLocationInsightTypeInsight.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(insightId, nameof(insightId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InsightName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightId">The <c>Insight</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InsightName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>.
        /// </returns>
        public static string FormatFolderLocationInsightTypeInsight(string folderId, string locationId, string insightTypeId, string insightId) =>
            s_folderLocationInsightTypeInsight.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(insightId, nameof(insightId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InsightName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightId">The <c>Insight</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InsightName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>.
        /// </returns>
        public static string FormatOrganizationLocationInsightTypeInsight(string organizationId, string locationId, string insightTypeId, string insightId) =>
            s_organizationLocationInsightTypeInsight.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(insightId, nameof(insightId)));

        /// <summary>Parses the given resource name string into a new <see cref="InsightName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="insightName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InsightName"/> if successful.</returns>
        public static InsightName Parse(string insightName) => Parse(insightName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InsightName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="insightName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InsightName"/> if successful.</returns>
        public static InsightName Parse(string insightName, bool allowUnparsed) =>
            TryParse(insightName, allowUnparsed, out InsightName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InsightName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="insightName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InsightName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string insightName, out InsightName result) => TryParse(insightName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InsightName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="insightName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InsightName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string insightName, bool allowUnparsed, out InsightName result)
        {
            gax::GaxPreconditions.CheckNotNull(insightName, nameof(insightName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInsightTypeInsight.TryParseName(insightName, out resourceName))
            {
                result = FromProjectLocationInsightTypeInsight(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_billingAccountLocationInsightTypeInsight.TryParseName(insightName, out resourceName))
            {
                result = FromBillingAccountLocationInsightTypeInsight(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_folderLocationInsightTypeInsight.TryParseName(insightName, out resourceName))
            {
                result = FromFolderLocationInsightTypeInsight(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_organizationLocationInsightTypeInsight.TryParseName(insightName, out resourceName))
            {
                result = FromOrganizationLocationInsightTypeInsight(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(insightName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InsightName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string folderId = null, string insightId = null, string insightTypeId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            FolderId = folderId;
            InsightId = insightId;
            InsightTypeId = insightTypeId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InsightName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}/insights/{insight}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightId">The <c>Insight</c> ID. Must not be <c>null</c> or empty.</param>
        public InsightName(string projectId, string locationId, string insightTypeId, string insightId) : this(ResourceNameType.ProjectLocationInsightTypeInsight, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), insightTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)), insightId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightId, nameof(insightId)))
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
        /// The <c>BillingAccount</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string BillingAccountId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>Insight</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string InsightId { get; }

        /// <summary>
        /// The <c>InsightType</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string InsightTypeId { get; }

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
                case ResourceNameType.ProjectLocationInsightTypeInsight: return s_projectLocationInsightTypeInsight.Expand(ProjectId, LocationId, InsightTypeId, InsightId);
                case ResourceNameType.BillingAccountLocationInsightTypeInsight: return s_billingAccountLocationInsightTypeInsight.Expand(BillingAccountId, LocationId, InsightTypeId, InsightId);
                case ResourceNameType.FolderLocationInsightTypeInsight: return s_folderLocationInsightTypeInsight.Expand(FolderId, LocationId, InsightTypeId, InsightId);
                case ResourceNameType.OrganizationLocationInsightTypeInsight: return s_organizationLocationInsightTypeInsight.Expand(OrganizationId, LocationId, InsightTypeId, InsightId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InsightName);

        /// <inheritdoc/>
        public bool Equals(InsightName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InsightName a, InsightName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InsightName a, InsightName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>InsightType</c> resource.</summary>
    public sealed partial class InsightTypeName : gax::IResourceName, sys::IEquatable<InsightTypeName>
    {
        /// <summary>The possible contents of <see cref="InsightTypeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/insightTypes/{insight_type}</c>.
            /// </summary>
            ProjectLocationInsightType = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}</c>.
            /// </summary>
            BillingAccountLocationInsightType = 2,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/locations/{location}/insightTypes/{insight_type}</c>.
            /// </summary>
            FolderLocationInsightType = 3,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}</c>.
            /// </summary>
            OrganizationLocationInsightType = 4,
        }

        private static gax::PathTemplate s_projectLocationInsightType = new gax::PathTemplate("projects/{project}/locations/{location}/insightTypes/{insight_type}");

        private static gax::PathTemplate s_billingAccountLocationInsightType = new gax::PathTemplate("billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}");

        private static gax::PathTemplate s_folderLocationInsightType = new gax::PathTemplate("folders/{folder}/locations/{location}/insightTypes/{insight_type}");

        private static gax::PathTemplate s_organizationLocationInsightType = new gax::PathTemplate("organizations/{organization}/locations/{location}/insightTypes/{insight_type}");

        /// <summary>Creates a <see cref="InsightTypeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InsightTypeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InsightTypeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InsightTypeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InsightTypeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InsightTypeName"/> constructed from the provided ids.</returns>
        public static InsightTypeName FromProjectLocationInsightType(string projectId, string locationId, string insightTypeId) =>
            new InsightTypeName(ResourceNameType.ProjectLocationInsightType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), insightTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)));

        /// <summary>
        /// Creates a <see cref="InsightTypeName"/> with the pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InsightTypeName"/> constructed from the provided ids.</returns>
        public static InsightTypeName FromBillingAccountLocationInsightType(string billingAccountId, string locationId, string insightTypeId) =>
            new InsightTypeName(ResourceNameType.BillingAccountLocationInsightType, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), insightTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)));

        /// <summary>
        /// Creates a <see cref="InsightTypeName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/insightTypes/{insight_type}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InsightTypeName"/> constructed from the provided ids.</returns>
        public static InsightTypeName FromFolderLocationInsightType(string folderId, string locationId, string insightTypeId) =>
            new InsightTypeName(ResourceNameType.FolderLocationInsightType, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), insightTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)));

        /// <summary>
        /// Creates a <see cref="InsightTypeName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InsightTypeName"/> constructed from the provided ids.</returns>
        public static InsightTypeName FromOrganizationLocationInsightType(string organizationId, string locationId, string insightTypeId) =>
            new InsightTypeName(ResourceNameType.OrganizationLocationInsightType, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), insightTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InsightTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InsightTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string insightTypeId) =>
            FormatProjectLocationInsightType(projectId, locationId, insightTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InsightTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InsightTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}</c>.
        /// </returns>
        public static string FormatProjectLocationInsightType(string projectId, string locationId, string insightTypeId) =>
            s_projectLocationInsightType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InsightTypeName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InsightTypeName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}</c>.
        /// </returns>
        public static string FormatBillingAccountLocationInsightType(string billingAccountId, string locationId, string insightTypeId) =>
            s_billingAccountLocationInsightType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InsightTypeName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/insightTypes/{insight_type}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InsightTypeName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/insightTypes/{insight_type}</c>.
        /// </returns>
        public static string FormatFolderLocationInsightType(string folderId, string locationId, string insightTypeId) =>
            s_folderLocationInsightType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InsightTypeName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InsightTypeName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}</c>.
        /// </returns>
        public static string FormatOrganizationLocationInsightType(string organizationId, string locationId, string insightTypeId) =>
            s_organizationLocationInsightType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)));

        /// <summary>Parses the given resource name string into a new <see cref="InsightTypeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/insightTypes/{insight_type}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/insightTypes/{insight_type}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="insightTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InsightTypeName"/> if successful.</returns>
        public static InsightTypeName Parse(string insightTypeName) => Parse(insightTypeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InsightTypeName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/insightTypes/{insight_type}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/insightTypes/{insight_type}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="insightTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InsightTypeName"/> if successful.</returns>
        public static InsightTypeName Parse(string insightTypeName, bool allowUnparsed) =>
            TryParse(insightTypeName, allowUnparsed, out InsightTypeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InsightTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/insightTypes/{insight_type}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/insightTypes/{insight_type}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="insightTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InsightTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string insightTypeName, out InsightTypeName result) =>
            TryParse(insightTypeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InsightTypeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/insightTypes/{insight_type}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/insightTypes/{insight_type}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/insightTypes/{insight_type}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/insightTypes/{insight_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="insightTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InsightTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string insightTypeName, bool allowUnparsed, out InsightTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(insightTypeName, nameof(insightTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInsightType.TryParseName(insightTypeName, out resourceName))
            {
                result = FromProjectLocationInsightType(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_billingAccountLocationInsightType.TryParseName(insightTypeName, out resourceName))
            {
                result = FromBillingAccountLocationInsightType(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationInsightType.TryParseName(insightTypeName, out resourceName))
            {
                result = FromFolderLocationInsightType(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationInsightType.TryParseName(insightTypeName, out resourceName))
            {
                result = FromOrganizationLocationInsightType(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(insightTypeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InsightTypeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string folderId = null, string insightTypeId = null, string locationId = null, string organizationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            FolderId = folderId;
            InsightTypeId = insightTypeId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InsightTypeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/insightTypes/{insight_type}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="insightTypeId">The <c>InsightType</c> ID. Must not be <c>null</c> or empty.</param>
        public InsightTypeName(string projectId, string locationId, string insightTypeId) : this(ResourceNameType.ProjectLocationInsightType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), insightTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(insightTypeId, nameof(insightTypeId)))
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
        /// The <c>BillingAccount</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string BillingAccountId { get; }

        /// <summary>
        /// The <c>Folder</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string FolderId { get; }

        /// <summary>
        /// The <c>InsightType</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string InsightTypeId { get; }

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
                case ResourceNameType.ProjectLocationInsightType: return s_projectLocationInsightType.Expand(ProjectId, LocationId, InsightTypeId);
                case ResourceNameType.BillingAccountLocationInsightType: return s_billingAccountLocationInsightType.Expand(BillingAccountId, LocationId, InsightTypeId);
                case ResourceNameType.FolderLocationInsightType: return s_folderLocationInsightType.Expand(FolderId, LocationId, InsightTypeId);
                case ResourceNameType.OrganizationLocationInsightType: return s_organizationLocationInsightType.Expand(OrganizationId, LocationId, InsightTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InsightTypeName);

        /// <inheritdoc/>
        public bool Equals(InsightTypeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InsightTypeName a, InsightTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InsightTypeName a, InsightTypeName b) => !(a == b);
    }

    public partial class Insight
    {
        /// <summary>
        /// <see cref="gcrv::InsightName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::InsightName InsightName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::InsightName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
