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
using gcdv = Google.Cloud.Dataproc.V1;
using sys = System;

namespace Google.Cloud.Dataproc.V1
{
    /// <summary>Resource name for the <c>AutoscalingPolicy</c> resource.</summary>
    public sealed partial class AutoscalingPolicyName : gax::IResourceName, sys::IEquatable<AutoscalingPolicyName>
    {
        /// <summary>The possible contents of <see cref="AutoscalingPolicyName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>.
            /// </summary>
            ProjectLocationAutoscalingPolicy = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>.
            /// </summary>
            ProjectRegionAutoscalingPolicy = 2,
        }

        private static gax::PathTemplate s_projectLocationAutoscalingPolicy = new gax::PathTemplate("projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}");

        private static gax::PathTemplate s_projectRegionAutoscalingPolicy = new gax::PathTemplate("projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}");

        /// <summary>Creates a <see cref="AutoscalingPolicyName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AutoscalingPolicyName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AutoscalingPolicyName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AutoscalingPolicyName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AutoscalingPolicyName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoscalingPolicyId">The <c>AutoscalingPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AutoscalingPolicyName"/> constructed from the provided ids.</returns>
        public static AutoscalingPolicyName FromProjectLocationAutoscalingPolicy(string projectId, string locationId, string autoscalingPolicyId) =>
            new AutoscalingPolicyName(ResourceNameType.ProjectLocationAutoscalingPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), autoscalingPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(autoscalingPolicyId, nameof(autoscalingPolicyId)));

        /// <summary>
        /// Creates a <see cref="AutoscalingPolicyName"/> with the pattern
        /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoscalingPolicyId">The <c>AutoscalingPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AutoscalingPolicyName"/> constructed from the provided ids.</returns>
        public static AutoscalingPolicyName FromProjectRegionAutoscalingPolicy(string projectId, string regionId, string autoscalingPolicyId) =>
            new AutoscalingPolicyName(ResourceNameType.ProjectRegionAutoscalingPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), autoscalingPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(autoscalingPolicyId, nameof(autoscalingPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AutoscalingPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoscalingPolicyId">The <c>AutoscalingPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AutoscalingPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string autoscalingPolicyId) =>
            FormatProjectLocationAutoscalingPolicy(projectId, locationId, autoscalingPolicyId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AutoscalingPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoscalingPolicyId">The <c>AutoscalingPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AutoscalingPolicyName"/> with pattern
        /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>.
        /// </returns>
        public static string FormatProjectLocationAutoscalingPolicy(string projectId, string locationId, string autoscalingPolicyId) =>
            s_projectLocationAutoscalingPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(autoscalingPolicyId, nameof(autoscalingPolicyId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AutoscalingPolicyName"/> with pattern
        /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoscalingPolicyId">The <c>AutoscalingPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AutoscalingPolicyName"/> with pattern
        /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>.
        /// </returns>
        public static string FormatProjectRegionAutoscalingPolicy(string projectId, string regionId, string autoscalingPolicyId) =>
            s_projectRegionAutoscalingPolicy.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(autoscalingPolicyId, nameof(autoscalingPolicyId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AutoscalingPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="autoscalingPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AutoscalingPolicyName"/> if successful.</returns>
        public static AutoscalingPolicyName Parse(string autoscalingPolicyName) => Parse(autoscalingPolicyName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AutoscalingPolicyName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="autoscalingPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AutoscalingPolicyName"/> if successful.</returns>
        public static AutoscalingPolicyName Parse(string autoscalingPolicyName, bool allowUnparsed) =>
            TryParse(autoscalingPolicyName, allowUnparsed, out AutoscalingPolicyName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AutoscalingPolicyName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="autoscalingPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AutoscalingPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string autoscalingPolicyName, out AutoscalingPolicyName result) =>
            TryParse(autoscalingPolicyName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AutoscalingPolicyName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/regions/{region}/autoscalingPolicies/{autoscaling_policy}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="autoscalingPolicyName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AutoscalingPolicyName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string autoscalingPolicyName, bool allowUnparsed, out AutoscalingPolicyName result)
        {
            gax::GaxPreconditions.CheckNotNull(autoscalingPolicyName, nameof(autoscalingPolicyName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAutoscalingPolicy.TryParseName(autoscalingPolicyName, out resourceName))
            {
                result = FromProjectLocationAutoscalingPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_projectRegionAutoscalingPolicy.TryParseName(autoscalingPolicyName, out resourceName))
            {
                result = FromProjectRegionAutoscalingPolicy(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(autoscalingPolicyName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AutoscalingPolicyName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string autoscalingPolicyId = null, string locationId = null, string projectId = null, string regionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AutoscalingPolicyId = autoscalingPolicyId;
            LocationId = locationId;
            ProjectId = projectId;
            RegionId = regionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AutoscalingPolicyName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/autoscalingPolicies/{autoscaling_policy}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="autoscalingPolicyId">The <c>AutoscalingPolicy</c> ID. Must not be <c>null</c> or empty.</param>
        public AutoscalingPolicyName(string projectId, string locationId, string autoscalingPolicyId) : this(ResourceNameType.ProjectLocationAutoscalingPolicy, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), autoscalingPolicyId: gax::GaxPreconditions.CheckNotNullOrEmpty(autoscalingPolicyId, nameof(autoscalingPolicyId)))
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
        /// The <c>AutoscalingPolicy</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string AutoscalingPolicyId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Region</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string RegionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationAutoscalingPolicy: return s_projectLocationAutoscalingPolicy.Expand(ProjectId, LocationId, AutoscalingPolicyId);
                case ResourceNameType.ProjectRegionAutoscalingPolicy: return s_projectRegionAutoscalingPolicy.Expand(ProjectId, RegionId, AutoscalingPolicyId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AutoscalingPolicyName);

        /// <inheritdoc/>
        public bool Equals(AutoscalingPolicyName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AutoscalingPolicyName a, AutoscalingPolicyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AutoscalingPolicyName a, AutoscalingPolicyName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Region</c> resource.</summary>
    public sealed partial class RegionName : gax::IResourceName, sys::IEquatable<RegionName>
    {
        /// <summary>The possible contents of <see cref="RegionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>projects/{project}/regions/{region}</c>.</summary>
            ProjectRegion = 1,
        }

        private static gax::PathTemplate s_projectRegion = new gax::PathTemplate("projects/{project}/regions/{region}");

        /// <summary>Creates a <see cref="RegionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RegionName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RegionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RegionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RegionName"/> with the pattern <c>projects/{project}/regions/{region}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RegionName"/> constructed from the provided ids.</returns>
        public static RegionName FromProjectRegion(string projectId, string regionId) =>
            new RegionName(ResourceNameType.ProjectRegion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RegionName"/> with pattern
        /// <c>projects/{project}/regions/{region}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RegionName"/> with pattern
        /// <c>projects/{project}/regions/{region}</c>.
        /// </returns>
        public static string Format(string projectId, string regionId) => FormatProjectRegion(projectId, regionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RegionName"/> with pattern
        /// <c>projects/{project}/regions/{region}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RegionName"/> with pattern
        /// <c>projects/{project}/regions/{region}</c>.
        /// </returns>
        public static string FormatProjectRegion(string projectId, string regionId) =>
            s_projectRegion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)));

        /// <summary>Parses the given resource name string into a new <see cref="RegionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="regionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RegionName"/> if successful.</returns>
        public static RegionName Parse(string regionName) => Parse(regionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RegionName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="regionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RegionName"/> if successful.</returns>
        public static RegionName Parse(string regionName, bool allowUnparsed) =>
            TryParse(regionName, allowUnparsed, out RegionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RegionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="regionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RegionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string regionName, out RegionName result) => TryParse(regionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RegionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/regions/{region}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="regionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RegionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string regionName, bool allowUnparsed, out RegionName result)
        {
            gax::GaxPreconditions.CheckNotNull(regionName, nameof(regionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectRegion.TryParseName(regionName, out resourceName))
            {
                result = FromProjectRegion(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(regionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RegionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string projectId = null, string regionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ProjectId = projectId;
            RegionId = regionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RegionName"/> class from the component parts of pattern
        /// <c>projects/{project}/regions/{region}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="regionId">The <c>Region</c> ID. Must not be <c>null</c> or empty.</param>
        public RegionName(string projectId, string regionId) : this(ResourceNameType.ProjectRegion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), regionId: gax::GaxPreconditions.CheckNotNullOrEmpty(regionId, nameof(regionId)))
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

        /// <summary>
        /// The <c>Region</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string RegionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectRegion: return s_projectRegion.Expand(ProjectId, RegionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RegionName);

        /// <inheritdoc/>
        public bool Equals(RegionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(RegionName a, RegionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(RegionName a, RegionName b) => !(a == b);
    }

    public partial class AutoscalingPolicy
    {
        /// <summary>
        /// <see cref="gcdv::AutoscalingPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AutoscalingPolicyName AutoscalingPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AutoscalingPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAutoscalingPolicyRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="RegionName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public RegionName ParentAsRegionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RegionName.Parse(Parent, allowUnparsed: true);
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
                if (RegionName.TryParse(Parent, out RegionName region))
                {
                    return region;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAutoscalingPolicyRequest
    {
        /// <summary>
        /// <see cref="gcdv::AutoscalingPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AutoscalingPolicyName AutoscalingPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AutoscalingPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAutoscalingPolicyRequest
    {
        /// <summary>
        /// <see cref="gcdv::AutoscalingPolicyName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AutoscalingPolicyName AutoscalingPolicyName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AutoscalingPolicyName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAutoscalingPoliciesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="RegionName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public RegionName ParentAsRegionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : RegionName.Parse(Parent, allowUnparsed: true);
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
                if (RegionName.TryParse(Parent, out RegionName region))
                {
                    return region;
                }
                return gax::UnparsedResourceName.Parse(Parent);
            }
            set => Parent = value?.ToString() ?? "";
        }
    }
}
