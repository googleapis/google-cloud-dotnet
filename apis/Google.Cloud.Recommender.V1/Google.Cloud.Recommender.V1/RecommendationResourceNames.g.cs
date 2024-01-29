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
using gcrv = Google.Cloud.Recommender.V1;
using sys = System;

namespace Google.Cloud.Recommender.V1
{
    /// <summary>Resource name for the <c>Recommendation</c> resource.</summary>
    public sealed partial class RecommendationName : gax::IResourceName, sys::IEquatable<RecommendationName>
    {
        /// <summary>The possible contents of <see cref="RecommendationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
            /// .
            /// </summary>
            ProjectLocationRecommenderRecommendation = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
            /// .
            /// </summary>
            BillingAccountLocationRecommenderRecommendation = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>folders/{folder}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
            /// .
            /// </summary>
            FolderLocationRecommenderRecommendation = 3,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// organizations/{organization}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
            /// .
            /// </summary>
            OrganizationLocationRecommenderRecommendation = 4,
        }

        private static gax::PathTemplate s_projectLocationRecommenderRecommendation = new gax::PathTemplate("projects/{project}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}");

        private static gax::PathTemplate s_billingAccountLocationRecommenderRecommendation = new gax::PathTemplate("billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}");

        private static gax::PathTemplate s_folderLocationRecommenderRecommendation = new gax::PathTemplate("folders/{folder}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}");

        private static gax::PathTemplate s_organizationLocationRecommenderRecommendation = new gax::PathTemplate("organizations/{organization}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}");

        /// <summary>Creates a <see cref="RecommendationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RecommendationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RecommendationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RecommendationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RecommendationName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommendationId">The <c>Recommendation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RecommendationName"/> constructed from the provided ids.</returns>
        public static RecommendationName FromProjectLocationRecommenderRecommendation(string projectId, string locationId, string recommenderId, string recommendationId) =>
            new RecommendationName(ResourceNameType.ProjectLocationRecommenderRecommendation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), recommenderId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)), recommendationId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommendationId, nameof(recommendationId)));

        /// <summary>
        /// Creates a <see cref="RecommendationName"/> with the pattern
        /// <c>
        /// billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// .
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommendationId">The <c>Recommendation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RecommendationName"/> constructed from the provided ids.</returns>
        public static RecommendationName FromBillingAccountLocationRecommenderRecommendation(string billingAccountId, string locationId, string recommenderId, string recommendationId) =>
            new RecommendationName(ResourceNameType.BillingAccountLocationRecommenderRecommendation, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), recommenderId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)), recommendationId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommendationId, nameof(recommendationId)));

        /// <summary>
        /// Creates a <see cref="RecommendationName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommendationId">The <c>Recommendation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RecommendationName"/> constructed from the provided ids.</returns>
        public static RecommendationName FromFolderLocationRecommenderRecommendation(string folderId, string locationId, string recommenderId, string recommendationId) =>
            new RecommendationName(ResourceNameType.FolderLocationRecommenderRecommendation, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), recommenderId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)), recommendationId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommendationId, nameof(recommendationId)));

        /// <summary>
        /// Creates a <see cref="RecommendationName"/> with the pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommendationId">The <c>Recommendation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RecommendationName"/> constructed from the provided ids.</returns>
        public static RecommendationName FromOrganizationLocationRecommenderRecommendation(string organizationId, string locationId, string recommenderId, string recommendationId) =>
            new RecommendationName(ResourceNameType.OrganizationLocationRecommenderRecommendation, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), recommenderId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)), recommendationId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommendationId, nameof(recommendationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecommendationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommendationId">The <c>Recommendation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecommendationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string recommenderId, string recommendationId) =>
            FormatProjectLocationRecommenderRecommendation(projectId, locationId, recommenderId, recommendationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecommendationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommendationId">The <c>Recommendation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecommendationName"/> with pattern
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>.
        /// </returns>
        public static string FormatProjectLocationRecommenderRecommendation(string projectId, string locationId, string recommenderId, string recommendationId) =>
            s_projectLocationRecommenderRecommendation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recommendationId, nameof(recommendationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecommendationName"/> with pattern
        /// <c>
        /// billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// .
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommendationId">The <c>Recommendation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecommendationName"/> with pattern
        /// <c>
        /// billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// .
        /// </returns>
        public static string FormatBillingAccountLocationRecommenderRecommendation(string billingAccountId, string locationId, string recommenderId, string recommendationId) =>
            s_billingAccountLocationRecommenderRecommendation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recommendationId, nameof(recommendationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecommendationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommendationId">The <c>Recommendation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecommendationName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>.
        /// </returns>
        public static string FormatFolderLocationRecommenderRecommendation(string folderId, string locationId, string recommenderId, string recommendationId) =>
            s_folderLocationRecommenderRecommendation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recommendationId, nameof(recommendationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecommendationName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// .
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommendationId">The <c>Recommendation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecommendationName"/> with pattern
        /// <c>
        /// organizations/{organization}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// .
        /// </returns>
        public static string FormatOrganizationLocationRecommenderRecommendation(string organizationId, string locationId, string recommenderId, string recommendationId) =>
            s_organizationLocationRecommenderRecommendation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recommendationId, nameof(recommendationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RecommendationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="recommendationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RecommendationName"/> if successful.</returns>
        public static RecommendationName Parse(string recommendationName) => Parse(recommendationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RecommendationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="recommendationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RecommendationName"/> if successful.</returns>
        public static RecommendationName Parse(string recommendationName, bool allowUnparsed) =>
            TryParse(recommendationName, allowUnparsed, out RecommendationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RecommendationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="recommendationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RecommendationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string recommendationName, out RecommendationName result) =>
            TryParse(recommendationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RecommendationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>
        /// organizations/{organization}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="recommendationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RecommendationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string recommendationName, bool allowUnparsed, out RecommendationName result)
        {
            gax::GaxPreconditions.CheckNotNull(recommendationName, nameof(recommendationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRecommenderRecommendation.TryParseName(recommendationName, out resourceName))
            {
                result = FromProjectLocationRecommenderRecommendation(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_billingAccountLocationRecommenderRecommendation.TryParseName(recommendationName, out resourceName))
            {
                result = FromBillingAccountLocationRecommenderRecommendation(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_folderLocationRecommenderRecommendation.TryParseName(recommendationName, out resourceName))
            {
                result = FromFolderLocationRecommenderRecommendation(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_organizationLocationRecommenderRecommendation.TryParseName(recommendationName, out resourceName))
            {
                result = FromOrganizationLocationRecommenderRecommendation(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(recommendationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RecommendationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null, string recommendationId = null, string recommenderId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            RecommendationId = recommendationId;
            RecommenderId = recommenderId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RecommendationName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommendationId">The <c>Recommendation</c> ID. Must not be <c>null</c> or empty.</param>
        public RecommendationName(string projectId, string locationId, string recommenderId, string recommendationId) : this(ResourceNameType.ProjectLocationRecommenderRecommendation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), recommenderId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)), recommendationId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommendationId, nameof(recommendationId)))
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
        /// The <c>Recommendation</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string RecommendationId { get; }

        /// <summary>
        /// The <c>Recommender</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string RecommenderId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRecommenderRecommendation: return s_projectLocationRecommenderRecommendation.Expand(ProjectId, LocationId, RecommenderId, RecommendationId);
                case ResourceNameType.BillingAccountLocationRecommenderRecommendation: return s_billingAccountLocationRecommenderRecommendation.Expand(BillingAccountId, LocationId, RecommenderId, RecommendationId);
                case ResourceNameType.FolderLocationRecommenderRecommendation: return s_folderLocationRecommenderRecommendation.Expand(FolderId, LocationId, RecommenderId, RecommendationId);
                case ResourceNameType.OrganizationLocationRecommenderRecommendation: return s_organizationLocationRecommenderRecommendation.Expand(OrganizationId, LocationId, RecommenderId, RecommendationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RecommendationName);

        /// <inheritdoc/>
        public bool Equals(RecommendationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RecommendationName a, RecommendationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RecommendationName a, RecommendationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Recommender</c> resource.</summary>
    public sealed partial class RecommenderName : gax::IResourceName, sys::IEquatable<RecommenderName>
    {
        /// <summary>The possible contents of <see cref="RecommenderName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/recommenders/{recommender}</c>.
            /// </summary>
            ProjectLocationRecommender = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}</c>.
            /// </summary>
            BillingAccountLocationRecommender = 2,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/locations/{location}/recommenders/{recommender}</c>.
            /// </summary>
            FolderLocationRecommender = 3,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/recommenders/{recommender}</c>.
            /// </summary>
            OrganizationLocationRecommender = 4,
        }

        private static gax::PathTemplate s_projectLocationRecommender = new gax::PathTemplate("projects/{project}/locations/{location}/recommenders/{recommender}");

        private static gax::PathTemplate s_billingAccountLocationRecommender = new gax::PathTemplate("billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}");

        private static gax::PathTemplate s_folderLocationRecommender = new gax::PathTemplate("folders/{folder}/locations/{location}/recommenders/{recommender}");

        private static gax::PathTemplate s_organizationLocationRecommender = new gax::PathTemplate("organizations/{organization}/locations/{location}/recommenders/{recommender}");

        /// <summary>Creates a <see cref="RecommenderName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RecommenderName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RecommenderName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RecommenderName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RecommenderName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RecommenderName"/> constructed from the provided ids.</returns>
        public static RecommenderName FromProjectLocationRecommender(string projectId, string locationId, string recommenderId) =>
            new RecommenderName(ResourceNameType.ProjectLocationRecommender, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), recommenderId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)));

        /// <summary>
        /// Creates a <see cref="RecommenderName"/> with the pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RecommenderName"/> constructed from the provided ids.</returns>
        public static RecommenderName FromBillingAccountLocationRecommender(string billingAccountId, string locationId, string recommenderId) =>
            new RecommenderName(ResourceNameType.BillingAccountLocationRecommender, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), recommenderId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)));

        /// <summary>
        /// Creates a <see cref="RecommenderName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/recommenders/{recommender}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RecommenderName"/> constructed from the provided ids.</returns>
        public static RecommenderName FromFolderLocationRecommender(string folderId, string locationId, string recommenderId) =>
            new RecommenderName(ResourceNameType.FolderLocationRecommender, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), recommenderId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)));

        /// <summary>
        /// Creates a <see cref="RecommenderName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/recommenders/{recommender}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RecommenderName"/> constructed from the provided ids.</returns>
        public static RecommenderName FromOrganizationLocationRecommender(string organizationId, string locationId, string recommenderId) =>
            new RecommenderName(ResourceNameType.OrganizationLocationRecommender, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), recommenderId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecommenderName"/> with pattern
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecommenderName"/> with pattern
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string recommenderId) =>
            FormatProjectLocationRecommender(projectId, locationId, recommenderId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecommenderName"/> with pattern
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecommenderName"/> with pattern
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}</c>.
        /// </returns>
        public static string FormatProjectLocationRecommender(string projectId, string locationId, string recommenderId) =>
            s_projectLocationRecommender.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecommenderName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecommenderName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}</c>.
        /// </returns>
        public static string FormatBillingAccountLocationRecommender(string billingAccountId, string locationId, string recommenderId) =>
            s_billingAccountLocationRecommender.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecommenderName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/recommenders/{recommender}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecommenderName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/recommenders/{recommender}</c>.
        /// </returns>
        public static string FormatFolderLocationRecommender(string folderId, string locationId, string recommenderId) =>
            s_folderLocationRecommender.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecommenderName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/recommenders/{recommender}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecommenderName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/recommenders/{recommender}</c>.
        /// </returns>
        public static string FormatOrganizationLocationRecommender(string organizationId, string locationId, string recommenderId) =>
            s_organizationLocationRecommender.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)));

        /// <summary>Parses the given resource name string into a new <see cref="RecommenderName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/recommenders/{recommender}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/recommenders/{recommender}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/recommenders/{recommender}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="recommenderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RecommenderName"/> if successful.</returns>
        public static RecommenderName Parse(string recommenderName) => Parse(recommenderName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RecommenderName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/recommenders/{recommender}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/recommenders/{recommender}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/recommenders/{recommender}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="recommenderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RecommenderName"/> if successful.</returns>
        public static RecommenderName Parse(string recommenderName, bool allowUnparsed) =>
            TryParse(recommenderName, allowUnparsed, out RecommenderName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RecommenderName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/recommenders/{recommender}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/recommenders/{recommender}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/recommenders/{recommender}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="recommenderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RecommenderName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string recommenderName, out RecommenderName result) =>
            TryParse(recommenderName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RecommenderName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/recommenders/{recommender}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>folders/{folder}/locations/{location}/recommenders/{recommender}</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/recommenders/{recommender}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="recommenderName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RecommenderName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string recommenderName, bool allowUnparsed, out RecommenderName result)
        {
            gax::GaxPreconditions.CheckNotNull(recommenderName, nameof(recommenderName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRecommender.TryParseName(recommenderName, out resourceName))
            {
                result = FromProjectLocationRecommender(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_billingAccountLocationRecommender.TryParseName(recommenderName, out resourceName))
            {
                result = FromBillingAccountLocationRecommender(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationRecommender.TryParseName(recommenderName, out resourceName))
            {
                result = FromFolderLocationRecommender(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationRecommender.TryParseName(recommenderName, out resourceName))
            {
                result = FromOrganizationLocationRecommender(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(recommenderName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RecommenderName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null, string recommenderId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            RecommenderId = recommenderId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RecommenderName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        public RecommenderName(string projectId, string locationId, string recommenderId) : this(ResourceNameType.ProjectLocationRecommender, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), recommenderId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)))
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
        /// The <c>Recommender</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string RecommenderId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationRecommender: return s_projectLocationRecommender.Expand(ProjectId, LocationId, RecommenderId);
                case ResourceNameType.BillingAccountLocationRecommender: return s_billingAccountLocationRecommender.Expand(BillingAccountId, LocationId, RecommenderId);
                case ResourceNameType.FolderLocationRecommender: return s_folderLocationRecommender.Expand(FolderId, LocationId, RecommenderId);
                case ResourceNameType.OrganizationLocationRecommender: return s_organizationLocationRecommender.Expand(OrganizationId, LocationId, RecommenderId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RecommenderName);

        /// <inheritdoc/>
        public bool Equals(RecommenderName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RecommenderName a, RecommenderName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RecommenderName a, RecommenderName b) => !(a == b);
    }

    public partial class Recommendation
    {
        /// <summary>
        /// <see cref="gcrv::RecommendationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::RecommendationName RecommendationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::RecommendationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
