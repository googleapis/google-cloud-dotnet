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
    /// <summary>Resource name for the <c>RecommenderConfig</c> resource.</summary>
    public sealed partial class RecommenderConfigName : gax::IResourceName, sys::IEquatable<RecommenderConfigName>
    {
        /// <summary>The possible contents of <see cref="RecommenderConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/recommenders/{recommender}/config</c>.
            /// </summary>
            ProjectLocationRecommender = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/recommenders/{recommender}/config</c>.
            /// </summary>
            OrganizationLocationRecommender = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}/config</c>.
            /// </summary>
            BillingAccountLocationRecommender = 3,
        }

        private static gax::PathTemplate s_projectLocationRecommender = new gax::PathTemplate("projects/{project}/locations/{location}/recommenders/{recommender}/config");

        private static gax::PathTemplate s_organizationLocationRecommender = new gax::PathTemplate("organizations/{organization}/locations/{location}/recommenders/{recommender}/config");

        private static gax::PathTemplate s_billingAccountLocationRecommender = new gax::PathTemplate("billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}/config");

        /// <summary>Creates a <see cref="RecommenderConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RecommenderConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RecommenderConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RecommenderConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RecommenderConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}/config</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RecommenderConfigName"/> constructed from the provided ids.</returns>
        public static RecommenderConfigName FromProjectLocationRecommender(string projectId, string locationId, string recommenderId) =>
            new RecommenderConfigName(ResourceNameType.ProjectLocationRecommender, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), recommenderId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)));

        /// <summary>
        /// Creates a <see cref="RecommenderConfigName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/recommenders/{recommender}/config</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RecommenderConfigName"/> constructed from the provided ids.</returns>
        public static RecommenderConfigName FromOrganizationLocationRecommender(string organizationId, string locationId, string recommenderId) =>
            new RecommenderConfigName(ResourceNameType.OrganizationLocationRecommender, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), recommenderId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)));

        /// <summary>
        /// Creates a <see cref="RecommenderConfigName"/> with the pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}/config</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RecommenderConfigName"/> constructed from the provided ids.</returns>
        public static RecommenderConfigName FromBillingAccountLocationRecommender(string billingAccountId, string locationId, string recommenderId) =>
            new RecommenderConfigName(ResourceNameType.BillingAccountLocationRecommender, billingAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), recommenderId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecommenderConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}/config</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecommenderConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}/config</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string recommenderId) =>
            FormatProjectLocationRecommender(projectId, locationId, recommenderId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecommenderConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}/config</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecommenderConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}/config</c>.
        /// </returns>
        public static string FormatProjectLocationRecommender(string projectId, string locationId, string recommenderId) =>
            s_projectLocationRecommender.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecommenderConfigName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/recommenders/{recommender}/config</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecommenderConfigName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/recommenders/{recommender}/config</c>.
        /// </returns>
        public static string FormatOrganizationLocationRecommender(string organizationId, string locationId, string recommenderId) =>
            s_organizationLocationRecommender.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecommenderConfigName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}/config</c>.
        /// </summary>
        /// <param name="billingAccountId">The <c>BillingAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecommenderConfigName"/> with pattern
        /// <c>billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}/config</c>.
        /// </returns>
        public static string FormatBillingAccountLocationRecommender(string billingAccountId, string locationId, string recommenderId) =>
            s_billingAccountLocationRecommender.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(billingAccountId, nameof(billingAccountId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RecommenderConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/recommenders/{recommender}/config</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/recommenders/{recommender}/config</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}/config</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="recommenderConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RecommenderConfigName"/> if successful.</returns>
        public static RecommenderConfigName Parse(string recommenderConfigName) => Parse(recommenderConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RecommenderConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/recommenders/{recommender}/config</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/recommenders/{recommender}/config</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}/config</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="recommenderConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RecommenderConfigName"/> if successful.</returns>
        public static RecommenderConfigName Parse(string recommenderConfigName, bool allowUnparsed) =>
            TryParse(recommenderConfigName, allowUnparsed, out RecommenderConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RecommenderConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/recommenders/{recommender}/config</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/recommenders/{recommender}/config</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}/config</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="recommenderConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RecommenderConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string recommenderConfigName, out RecommenderConfigName result) =>
            TryParse(recommenderConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RecommenderConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/recommenders/{recommender}/config</c></description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/recommenders/{recommender}/config</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>billingAccounts/{billing_account}/locations/{location}/recommenders/{recommender}/config</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="recommenderConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RecommenderConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string recommenderConfigName, bool allowUnparsed, out RecommenderConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(recommenderConfigName, nameof(recommenderConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationRecommender.TryParseName(recommenderConfigName, out resourceName))
            {
                result = FromProjectLocationRecommender(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationRecommender.TryParseName(recommenderConfigName, out resourceName))
            {
                result = FromOrganizationLocationRecommender(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_billingAccountLocationRecommender.TryParseName(recommenderConfigName, out resourceName))
            {
                result = FromBillingAccountLocationRecommender(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(recommenderConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RecommenderConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string billingAccountId = null, string locationId = null, string organizationId = null, string projectId = null, string recommenderId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BillingAccountId = billingAccountId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            RecommenderId = recommenderId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RecommenderConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/recommenders/{recommender}/config</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c> or empty.</param>
        public RecommenderConfigName(string projectId, string locationId, string recommenderId) : this(ResourceNameType.ProjectLocationRecommender, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), recommenderId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommenderId, nameof(recommenderId)))
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
                case ResourceNameType.OrganizationLocationRecommender: return s_organizationLocationRecommender.Expand(OrganizationId, LocationId, RecommenderId);
                case ResourceNameType.BillingAccountLocationRecommender: return s_billingAccountLocationRecommender.Expand(BillingAccountId, LocationId, RecommenderId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RecommenderConfigName);

        /// <inheritdoc/>
        public bool Equals(RecommenderConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RecommenderConfigName a, RecommenderConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RecommenderConfigName a, RecommenderConfigName b) => !(a == b);
    }

    public partial class RecommenderConfig
    {
        /// <summary>
        /// <see cref="gcrv::RecommenderConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::RecommenderConfigName RecommenderConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::RecommenderConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
