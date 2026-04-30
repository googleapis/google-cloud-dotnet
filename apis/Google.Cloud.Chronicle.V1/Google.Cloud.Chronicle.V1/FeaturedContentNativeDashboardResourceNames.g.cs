// Copyright 2026 Google LLC
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
using gccv = Google.Cloud.Chronicle.V1;
using sys = System;

namespace Google.Cloud.Chronicle.V1
{
    /// <summary>Resource name for the <c>FeaturedContentNativeDashboard</c> resource.</summary>
    public sealed partial class FeaturedContentNativeDashboardName : gax::IResourceName, sys::IEquatable<FeaturedContentNativeDashboardName>
    {
        /// <summary>The possible contents of <see cref="FeaturedContentNativeDashboardName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}</c>
            /// .
            /// </summary>
            ProjectLocationInstanceFeaturedContentNativeDashboard = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceFeaturedContentNativeDashboard = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}");

        /// <summary>
        /// Creates a <see cref="FeaturedContentNativeDashboardName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FeaturedContentNativeDashboardName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FeaturedContentNativeDashboardName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FeaturedContentNativeDashboardName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FeaturedContentNativeDashboardName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featuredContentNativeDashboardId">
        /// The <c>FeaturedContentNativeDashboard</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="FeaturedContentNativeDashboardName"/> constructed from the provided ids.
        /// </returns>
        public static FeaturedContentNativeDashboardName FromProjectLocationInstanceFeaturedContentNativeDashboard(string projectId, string locationId, string instanceId, string featuredContentNativeDashboardId) =>
            new FeaturedContentNativeDashboardName(ResourceNameType.ProjectLocationInstanceFeaturedContentNativeDashboard, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), featuredContentNativeDashboardId: gax::GaxPreconditions.CheckNotNullOrEmpty(featuredContentNativeDashboardId, nameof(featuredContentNativeDashboardId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeaturedContentNativeDashboardName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featuredContentNativeDashboardId">
        /// The <c>FeaturedContentNativeDashboard</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FeaturedContentNativeDashboardName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string featuredContentNativeDashboardId) =>
            FormatProjectLocationInstanceFeaturedContentNativeDashboard(projectId, locationId, instanceId, featuredContentNativeDashboardId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeaturedContentNativeDashboardName"/> with
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featuredContentNativeDashboardId">
        /// The <c>FeaturedContentNativeDashboard</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FeaturedContentNativeDashboardName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationInstanceFeaturedContentNativeDashboard(string projectId, string locationId, string instanceId, string featuredContentNativeDashboardId) =>
            s_projectLocationInstanceFeaturedContentNativeDashboard.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(featuredContentNativeDashboardId, nameof(featuredContentNativeDashboardId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeaturedContentNativeDashboardName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="featuredContentNativeDashboardName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="FeaturedContentNativeDashboardName"/> if successful.</returns>
        public static FeaturedContentNativeDashboardName Parse(string featuredContentNativeDashboardName) =>
            Parse(featuredContentNativeDashboardName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeaturedContentNativeDashboardName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="featuredContentNativeDashboardName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FeaturedContentNativeDashboardName"/> if successful.</returns>
        public static FeaturedContentNativeDashboardName Parse(string featuredContentNativeDashboardName, bool allowUnparsed) =>
            TryParse(featuredContentNativeDashboardName, allowUnparsed, out FeaturedContentNativeDashboardName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeaturedContentNativeDashboardName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="featuredContentNativeDashboardName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeaturedContentNativeDashboardName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string featuredContentNativeDashboardName, out FeaturedContentNativeDashboardName result) =>
            TryParse(featuredContentNativeDashboardName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeaturedContentNativeDashboardName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="featuredContentNativeDashboardName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeaturedContentNativeDashboardName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string featuredContentNativeDashboardName, bool allowUnparsed, out FeaturedContentNativeDashboardName result)
        {
            gax::GaxPreconditions.CheckNotNull(featuredContentNativeDashboardName, nameof(featuredContentNativeDashboardName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceFeaturedContentNativeDashboard.TryParseName(featuredContentNativeDashboardName, out resourceName))
            {
                result = FromProjectLocationInstanceFeaturedContentNativeDashboard(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(featuredContentNativeDashboardName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FeaturedContentNativeDashboardName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string featuredContentNativeDashboardId = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FeaturedContentNativeDashboardId = featuredContentNativeDashboardId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FeaturedContentNativeDashboardName"/> class from the component
        /// parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/contentHub/featuredContentNativeDashboards/{featured_content_native_dashboard}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featuredContentNativeDashboardId">
        /// The <c>FeaturedContentNativeDashboard</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public FeaturedContentNativeDashboardName(string projectId, string locationId, string instanceId, string featuredContentNativeDashboardId) : this(ResourceNameType.ProjectLocationInstanceFeaturedContentNativeDashboard, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), featuredContentNativeDashboardId: gax::GaxPreconditions.CheckNotNullOrEmpty(featuredContentNativeDashboardId, nameof(featuredContentNativeDashboardId)))
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
        /// The <c>FeaturedContentNativeDashboard</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string FeaturedContentNativeDashboardId { get; }

        /// <summary>
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

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
                case ResourceNameType.ProjectLocationInstanceFeaturedContentNativeDashboard: return s_projectLocationInstanceFeaturedContentNativeDashboard.Expand(ProjectId, LocationId, InstanceId, FeaturedContentNativeDashboardId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FeaturedContentNativeDashboardName);

        /// <inheritdoc/>
        public bool Equals(FeaturedContentNativeDashboardName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FeaturedContentNativeDashboardName a, FeaturedContentNativeDashboardName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FeaturedContentNativeDashboardName a, FeaturedContentNativeDashboardName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ContentHub</c> resource.</summary>
    public sealed partial class ContentHubName : gax::IResourceName, sys::IEquatable<ContentHubName>
    {
        /// <summary>The possible contents of <see cref="ContentHubName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/instances/{instance}/contentHub</c>
            /// .
            /// </summary>
            ProjectLocationInstance = 1,
        }

        private static gax::PathTemplate s_projectLocationInstance = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/contentHub");

        /// <summary>Creates a <see cref="ContentHubName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ContentHubName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ContentHubName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ContentHubName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ContentHubName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/contentHub</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ContentHubName"/> constructed from the provided ids.</returns>
        public static ContentHubName FromProjectLocationInstance(string projectId, string locationId, string instanceId) =>
            new ContentHubName(ResourceNameType.ProjectLocationInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContentHubName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/contentHub</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContentHubName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/contentHub</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId) =>
            FormatProjectLocationInstance(projectId, locationId, instanceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContentHubName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/contentHub</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ContentHubName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/contentHub</c>.
        /// </returns>
        public static string FormatProjectLocationInstance(string projectId, string locationId, string instanceId) =>
            s_projectLocationInstance.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)));

        /// <summary>Parses the given resource name string into a new <see cref="ContentHubName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instances/{instance}/contentHub</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="contentHubName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ContentHubName"/> if successful.</returns>
        public static ContentHubName Parse(string contentHubName) => Parse(contentHubName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ContentHubName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instances/{instance}/contentHub</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="contentHubName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ContentHubName"/> if successful.</returns>
        public static ContentHubName Parse(string contentHubName, bool allowUnparsed) =>
            TryParse(contentHubName, allowUnparsed, out ContentHubName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ContentHubName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instances/{instance}/contentHub</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="contentHubName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ContentHubName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string contentHubName, out ContentHubName result) =>
            TryParse(contentHubName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ContentHubName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instances/{instance}/contentHub</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="contentHubName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ContentHubName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string contentHubName, bool allowUnparsed, out ContentHubName result)
        {
            gax::GaxPreconditions.CheckNotNull(contentHubName, nameof(contentHubName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstance.TryParseName(contentHubName, out resourceName))
            {
                result = FromProjectLocationInstance(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(contentHubName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ContentHubName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ContentHubName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/contentHub</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        public ContentHubName(string projectId, string locationId, string instanceId) : this(ResourceNameType.ProjectLocationInstance, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)))
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
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

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
                case ResourceNameType.ProjectLocationInstance: return s_projectLocationInstance.Expand(ProjectId, LocationId, InstanceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ContentHubName);

        /// <inheritdoc/>
        public bool Equals(ContentHubName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ContentHubName a, ContentHubName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ContentHubName a, ContentHubName b) => !(a == b);
    }

    public partial class FeaturedContentNativeDashboard
    {
        /// <summary>
        /// <see cref="gccv::FeaturedContentNativeDashboardName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::FeaturedContentNativeDashboardName FeaturedContentNativeDashboardName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FeaturedContentNativeDashboardName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetFeaturedContentNativeDashboardRequest
    {
        /// <summary>
        /// <see cref="gccv::FeaturedContentNativeDashboardName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::FeaturedContentNativeDashboardName FeaturedContentNativeDashboardName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FeaturedContentNativeDashboardName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFeaturedContentNativeDashboardsRequest
    {
        /// <summary>
        /// <see cref="ContentHubName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ContentHubName ParentAsContentHubName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ContentHubName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class InstallFeaturedContentNativeDashboardRequest
    {
        /// <summary>
        /// <see cref="gccv::FeaturedContentNativeDashboardName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::FeaturedContentNativeDashboardName FeaturedContentNativeDashboardName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FeaturedContentNativeDashboardName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class InstallFeaturedContentNativeDashboardResponse
    {
        /// <summary>
        /// <see cref="NativeDashboardName"/>-typed view over the <see cref="NativeDashboard"/> resource name property.
        /// </summary>
        public NativeDashboardName NativeDashboardAsNativeDashboardName
        {
            get => string.IsNullOrEmpty(NativeDashboard) ? null : NativeDashboardName.Parse(NativeDashboard, allowUnparsed: true);
            set => NativeDashboard = value?.ToString() ?? "";
        }
    }
}
