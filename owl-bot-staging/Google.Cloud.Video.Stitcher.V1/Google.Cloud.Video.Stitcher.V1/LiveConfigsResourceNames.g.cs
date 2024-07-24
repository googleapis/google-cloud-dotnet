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
using gcvsv = Google.Cloud.Video.Stitcher.V1;
using sys = System;

namespace Google.Cloud.Video.Stitcher.V1
{
    /// <summary>Resource name for the <c>LiveConfig</c> resource.</summary>
    public sealed partial class LiveConfigName : gax::IResourceName, sys::IEquatable<LiveConfigName>
    {
        /// <summary>The possible contents of <see cref="LiveConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/liveConfigs/{live_config}</c>.
            /// </summary>
            ProjectLocationLiveConfig = 1,
        }

        private static gax::PathTemplate s_projectLocationLiveConfig = new gax::PathTemplate("projects/{project}/locations/{location}/liveConfigs/{live_config}");

        /// <summary>Creates a <see cref="LiveConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LiveConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LiveConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LiveConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LiveConfigName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/liveConfigs/{live_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveConfigId">The <c>LiveConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LiveConfigName"/> constructed from the provided ids.</returns>
        public static LiveConfigName FromProjectLocationLiveConfig(string projectId, string locationId, string liveConfigId) =>
            new LiveConfigName(ResourceNameType.ProjectLocationLiveConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), liveConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(liveConfigId, nameof(liveConfigId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LiveConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/liveConfigs/{live_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveConfigId">The <c>LiveConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LiveConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/liveConfigs/{live_config}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string liveConfigId) =>
            FormatProjectLocationLiveConfig(projectId, locationId, liveConfigId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LiveConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/liveConfigs/{live_config}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveConfigId">The <c>LiveConfig</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LiveConfigName"/> with pattern
        /// <c>projects/{project}/locations/{location}/liveConfigs/{live_config}</c>.
        /// </returns>
        public static string FormatProjectLocationLiveConfig(string projectId, string locationId, string liveConfigId) =>
            s_projectLocationLiveConfig.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(liveConfigId, nameof(liveConfigId)));

        /// <summary>Parses the given resource name string into a new <see cref="LiveConfigName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/liveConfigs/{live_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="liveConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LiveConfigName"/> if successful.</returns>
        public static LiveConfigName Parse(string liveConfigName) => Parse(liveConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LiveConfigName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/liveConfigs/{live_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="liveConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LiveConfigName"/> if successful.</returns>
        public static LiveConfigName Parse(string liveConfigName, bool allowUnparsed) =>
            TryParse(liveConfigName, allowUnparsed, out LiveConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LiveConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/liveConfigs/{live_config}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="liveConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LiveConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string liveConfigName, out LiveConfigName result) =>
            TryParse(liveConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LiveConfigName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/liveConfigs/{live_config}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="liveConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LiveConfigName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string liveConfigName, bool allowUnparsed, out LiveConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(liveConfigName, nameof(liveConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationLiveConfig.TryParseName(liveConfigName, out resourceName))
            {
                result = FromProjectLocationLiveConfig(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(liveConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LiveConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string liveConfigId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LiveConfigId = liveConfigId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LiveConfigName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/liveConfigs/{live_config}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveConfigId">The <c>LiveConfig</c> ID. Must not be <c>null</c> or empty.</param>
        public LiveConfigName(string projectId, string locationId, string liveConfigId) : this(ResourceNameType.ProjectLocationLiveConfig, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), liveConfigId: gax::GaxPreconditions.CheckNotNullOrEmpty(liveConfigId, nameof(liveConfigId)))
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
        /// The <c>LiveConfig</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LiveConfigId { get; }

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
                case ResourceNameType.ProjectLocationLiveConfig: return s_projectLocationLiveConfig.Expand(ProjectId, LocationId, LiveConfigId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LiveConfigName);

        /// <inheritdoc/>
        public bool Equals(LiveConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LiveConfigName a, LiveConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LiveConfigName a, LiveConfigName b) => !(a == b);
    }

    public partial class LiveConfig
    {
        /// <summary>
        /// <see cref="gcvsv::LiveConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::LiveConfigName LiveConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::LiveConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SlateName"/>-typed view over the <see cref="DefaultSlate"/> resource name property.
        /// </summary>
        public SlateName DefaultSlateAsSlateName
        {
            get => string.IsNullOrEmpty(DefaultSlate) ? null : SlateName.Parse(DefaultSlate, allowUnparsed: true);
            set => DefaultSlate = value?.ToString() ?? "";
        }
    }
}
