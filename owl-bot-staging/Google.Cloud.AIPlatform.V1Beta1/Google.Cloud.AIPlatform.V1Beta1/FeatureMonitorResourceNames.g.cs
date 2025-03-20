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
using gcav = Google.Cloud.AIPlatform.V1Beta1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Resource name for the <c>FeatureMonitor</c> resource.</summary>
    public sealed partial class FeatureMonitorName : gax::IResourceName, sys::IEquatable<FeatureMonitorName>
    {
        /// <summary>The possible contents of <see cref="FeatureMonitorName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/featureGroups/{feature_group}/featureMonitors/{feature_monitor}</c>
            /// .
            /// </summary>
            ProjectLocationFeatureGroupFeatureMonitor = 1,
        }

        private static gax::PathTemplate s_projectLocationFeatureGroupFeatureMonitor = new gax::PathTemplate("projects/{project}/locations/{location}/featureGroups/{feature_group}/featureMonitors/{feature_monitor}");

        /// <summary>Creates a <see cref="FeatureMonitorName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FeatureMonitorName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FeatureMonitorName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FeatureMonitorName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FeatureMonitorName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/featureGroups/{feature_group}/featureMonitors/{feature_monitor}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureGroupId">The <c>FeatureGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureMonitorId">The <c>FeatureMonitor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FeatureMonitorName"/> constructed from the provided ids.</returns>
        public static FeatureMonitorName FromProjectLocationFeatureGroupFeatureMonitor(string projectId, string locationId, string featureGroupId, string featureMonitorId) =>
            new FeatureMonitorName(ResourceNameType.ProjectLocationFeatureGroupFeatureMonitor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), featureGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(featureGroupId, nameof(featureGroupId)), featureMonitorId: gax::GaxPreconditions.CheckNotNullOrEmpty(featureMonitorId, nameof(featureMonitorId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeatureMonitorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/featureGroups/{feature_group}/featureMonitors/{feature_monitor}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureGroupId">The <c>FeatureGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureMonitorId">The <c>FeatureMonitor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeatureMonitorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/featureGroups/{feature_group}/featureMonitors/{feature_monitor}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string featureGroupId, string featureMonitorId) =>
            FormatProjectLocationFeatureGroupFeatureMonitor(projectId, locationId, featureGroupId, featureMonitorId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeatureMonitorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/featureGroups/{feature_group}/featureMonitors/{feature_monitor}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureGroupId">The <c>FeatureGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureMonitorId">The <c>FeatureMonitor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeatureMonitorName"/> with pattern
        /// <c>projects/{project}/locations/{location}/featureGroups/{feature_group}/featureMonitors/{feature_monitor}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationFeatureGroupFeatureMonitor(string projectId, string locationId, string featureGroupId, string featureMonitorId) =>
            s_projectLocationFeatureGroupFeatureMonitor.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(featureGroupId, nameof(featureGroupId)), gax::GaxPreconditions.CheckNotNullOrEmpty(featureMonitorId, nameof(featureMonitorId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeatureMonitorName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/featureGroups/{feature_group}/featureMonitors/{feature_monitor}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="featureMonitorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeatureMonitorName"/> if successful.</returns>
        public static FeatureMonitorName Parse(string featureMonitorName) => Parse(featureMonitorName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeatureMonitorName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/featureGroups/{feature_group}/featureMonitors/{feature_monitor}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="featureMonitorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FeatureMonitorName"/> if successful.</returns>
        public static FeatureMonitorName Parse(string featureMonitorName, bool allowUnparsed) =>
            TryParse(featureMonitorName, allowUnparsed, out FeatureMonitorName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeatureMonitorName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/featureGroups/{feature_group}/featureMonitors/{feature_monitor}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="featureMonitorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeatureMonitorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string featureMonitorName, out FeatureMonitorName result) =>
            TryParse(featureMonitorName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeatureMonitorName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/featureGroups/{feature_group}/featureMonitors/{feature_monitor}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="featureMonitorName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeatureMonitorName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string featureMonitorName, bool allowUnparsed, out FeatureMonitorName result)
        {
            gax::GaxPreconditions.CheckNotNull(featureMonitorName, nameof(featureMonitorName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationFeatureGroupFeatureMonitor.TryParseName(featureMonitorName, out resourceName))
            {
                result = FromProjectLocationFeatureGroupFeatureMonitor(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(featureMonitorName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FeatureMonitorName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string featureGroupId = null, string featureMonitorId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FeatureGroupId = featureGroupId;
            FeatureMonitorId = featureMonitorId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FeatureMonitorName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/featureGroups/{feature_group}/featureMonitors/{feature_monitor}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureGroupId">The <c>FeatureGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="featureMonitorId">The <c>FeatureMonitor</c> ID. Must not be <c>null</c> or empty.</param>
        public FeatureMonitorName(string projectId, string locationId, string featureGroupId, string featureMonitorId) : this(ResourceNameType.ProjectLocationFeatureGroupFeatureMonitor, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), featureGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(featureGroupId, nameof(featureGroupId)), featureMonitorId: gax::GaxPreconditions.CheckNotNullOrEmpty(featureMonitorId, nameof(featureMonitorId)))
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
        /// The <c>FeatureGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string FeatureGroupId { get; }

        /// <summary>
        /// The <c>FeatureMonitor</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string FeatureMonitorId { get; }

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
                case ResourceNameType.ProjectLocationFeatureGroupFeatureMonitor: return s_projectLocationFeatureGroupFeatureMonitor.Expand(ProjectId, LocationId, FeatureGroupId, FeatureMonitorId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FeatureMonitorName);

        /// <inheritdoc/>
        public bool Equals(FeatureMonitorName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FeatureMonitorName a, FeatureMonitorName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FeatureMonitorName a, FeatureMonitorName b) => !(a == b);
    }

    public partial class FeatureMonitor
    {
        /// <summary>
        /// <see cref="gcav::FeatureMonitorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FeatureMonitorName FeatureMonitorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FeatureMonitorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
