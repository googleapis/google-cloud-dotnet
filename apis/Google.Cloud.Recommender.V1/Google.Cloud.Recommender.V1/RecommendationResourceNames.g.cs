// Copyright 2020 Google LLC
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

using gax = Google.Api.Gax;
using gcrv = Google.Cloud.Recommender.V1;
using sys = System;

namespace Google.Cloud.Recommender.V1
{
    /// <summary>Resource name for the <c>Recommendation</c> resource.</summary>
    public sealed partial class RecommendationName : gax::IResourceName, sys::IEquatable<RecommendationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/recommenders/{recommender}/recommendations/{recommendation}");

        /// <summary>
        /// Parses the given <c>Recommendation</c> resource name in string form into a new
        /// <see cref="RecommendationName"/> instance.
        /// </summary>
        /// <param name="recommendationName">
        /// The <c>Recommendation</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="RecommendationName"/> if successful.</returns>
        public static RecommendationName Parse(string recommendationName)
        {
            gax::GaxPreconditions.CheckNotNull(recommendationName, nameof(recommendationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(recommendationName);
            return new RecommendationName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="RecommendationName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="recommendationName"/>
        /// is <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="recommendationName">
        /// The <c>Recommendation</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RecommendationName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string recommendationName, out RecommendationName result)
        {
            gax::GaxPreconditions.CheckNotNull(recommendationName, nameof(recommendationName));
            if (s_template.TryParseName(recommendationName, out gax::TemplatedResourceName resourceName))
            {
                result = new RecommendationName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="RecommendationName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c>.</param>
        /// <param name="recommendationId">The <c>Recommendation</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="RecommendationName"/>.</returns>
        public static string Format(string projectId, string locationId, string recommenderId, string recommendationId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(recommenderId, nameof(recommenderId)), gax::GaxPreconditions.CheckNotNull(recommendationId, nameof(recommendationId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="RecommendationName"/> resource name class from its component
        /// parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c>.</param>
        /// <param name="recommendationId">The <c>Recommendation</c> ID. Must not be <c>null</c>.</param>
        public RecommendationName(string projectId, string locationId, string recommenderId, string recommendationId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            RecommenderId = gax::GaxPreconditions.CheckNotNull(recommenderId, nameof(recommenderId));
            RecommendationId = gax::GaxPreconditions.CheckNotNull(recommendationId, nameof(recommendationId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Location</c> ID. Never <c>null</c>.</summary>
        public string LocationId { get; }

        /// <summary>The <c>Recommender</c> ID. Never <c>null</c>.</summary>
        public string RecommenderId { get; }

        /// <summary>The <c>Recommendation</c> ID. Never <c>null</c>.</summary>
        public string RecommendationId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, LocationId, RecommenderId, RecommendationId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RecommendationName);

        /// <inheritdoc/>
        public bool Equals(RecommendationName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(RecommendationName a, RecommendationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(RecommendationName a, RecommendationName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Recommender</c> resource.</summary>
    public sealed partial class RecommenderName : gax::IResourceName, sys::IEquatable<RecommenderName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/recommenders/{recommender}");

        /// <summary>
        /// Parses the given <c>Recommender</c> resource name in string form into a new <see cref="RecommenderName"/>
        /// instance.
        /// </summary>
        /// <param name="recommenderName">
        /// The <c>Recommender</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="RecommenderName"/> if successful.</returns>
        public static RecommenderName Parse(string recommenderName)
        {
            gax::GaxPreconditions.CheckNotNull(recommenderName, nameof(recommenderName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(recommenderName);
            return new RecommenderName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="RecommenderName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="recommenderName"/> is
        /// <c>null</c>, as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="recommenderName">
        /// The <c>Recommender</c> resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RecommenderName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string recommenderName, out RecommenderName result)
        {
            gax::GaxPreconditions.CheckNotNull(recommenderName, nameof(recommenderName));
            if (s_template.TryParseName(recommenderName, out gax::TemplatedResourceName resourceName))
            {
                result = new RecommenderName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="RecommenderName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="RecommenderName"/>.</returns>
        public static string Format(string projectId, string locationId, string recommenderId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(recommenderId, nameof(recommenderId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="RecommenderName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="recommenderId">The <c>Recommender</c> ID. Must not be <c>null</c>.</param>
        public RecommenderName(string projectId, string locationId, string recommenderId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            RecommenderId = gax::GaxPreconditions.CheckNotNull(recommenderId, nameof(recommenderId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Location</c> ID. Never <c>null</c>.</summary>
        public string LocationId { get; }

        /// <summary>The <c>Recommender</c> ID. Never <c>null</c>.</summary>
        public string RecommenderId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, LocationId, RecommenderId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RecommenderName);

        /// <inheritdoc/>
        public bool Equals(RecommenderName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(RecommenderName a, RecommenderName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(RecommenderName a, RecommenderName b) => !(a == b);
    }

    public partial class Recommendation
    {
        /// <summary>
        /// <see cref="gcrv::RecommendationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::RecommendationName RecommendationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::RecommendationName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
