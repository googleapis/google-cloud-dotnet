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
using gcvsv = Google.Cloud.Video.Stitcher.V1;
using sys = System;

namespace Google.Cloud.Video.Stitcher.V1
{
    /// <summary>Resource name for the <c>LiveAdTagDetail</c> resource.</summary>
    public sealed partial class LiveAdTagDetailName : gax::IResourceName, sys::IEquatable<LiveAdTagDetailName>
    {
        /// <summary>The possible contents of <see cref="LiveAdTagDetailName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/liveSessions/{live_session}/liveAdTagDetails/{live_ad_tag_detail}</c>
            /// .
            /// </summary>
            ProjectLocationLiveSessionLiveAdTagDetail = 1,
        }

        private static gax::PathTemplate s_projectLocationLiveSessionLiveAdTagDetail = new gax::PathTemplate("projects/{project}/locations/{location}/liveSessions/{live_session}/liveAdTagDetails/{live_ad_tag_detail}");

        /// <summary>Creates a <see cref="LiveAdTagDetailName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LiveAdTagDetailName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LiveAdTagDetailName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LiveAdTagDetailName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LiveAdTagDetailName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/liveSessions/{live_session}/liveAdTagDetails/{live_ad_tag_detail}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveSessionId">The <c>LiveSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveAdTagDetailId">The <c>LiveAdTagDetail</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LiveAdTagDetailName"/> constructed from the provided ids.</returns>
        public static LiveAdTagDetailName FromProjectLocationLiveSessionLiveAdTagDetail(string projectId, string locationId, string liveSessionId, string liveAdTagDetailId) =>
            new LiveAdTagDetailName(ResourceNameType.ProjectLocationLiveSessionLiveAdTagDetail, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), liveSessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(liveSessionId, nameof(liveSessionId)), liveAdTagDetailId: gax::GaxPreconditions.CheckNotNullOrEmpty(liveAdTagDetailId, nameof(liveAdTagDetailId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LiveAdTagDetailName"/> with pattern
        /// <c>projects/{project}/locations/{location}/liveSessions/{live_session}/liveAdTagDetails/{live_ad_tag_detail}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveSessionId">The <c>LiveSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveAdTagDetailId">The <c>LiveAdTagDetail</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LiveAdTagDetailName"/> with pattern
        /// <c>projects/{project}/locations/{location}/liveSessions/{live_session}/liveAdTagDetails/{live_ad_tag_detail}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string liveSessionId, string liveAdTagDetailId) =>
            FormatProjectLocationLiveSessionLiveAdTagDetail(projectId, locationId, liveSessionId, liveAdTagDetailId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LiveAdTagDetailName"/> with pattern
        /// <c>projects/{project}/locations/{location}/liveSessions/{live_session}/liveAdTagDetails/{live_ad_tag_detail}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveSessionId">The <c>LiveSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveAdTagDetailId">The <c>LiveAdTagDetail</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LiveAdTagDetailName"/> with pattern
        /// <c>projects/{project}/locations/{location}/liveSessions/{live_session}/liveAdTagDetails/{live_ad_tag_detail}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationLiveSessionLiveAdTagDetail(string projectId, string locationId, string liveSessionId, string liveAdTagDetailId) =>
            s_projectLocationLiveSessionLiveAdTagDetail.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(liveSessionId, nameof(liveSessionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(liveAdTagDetailId, nameof(liveAdTagDetailId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LiveAdTagDetailName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/liveSessions/{live_session}/liveAdTagDetails/{live_ad_tag_detail}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="liveAdTagDetailName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LiveAdTagDetailName"/> if successful.</returns>
        public static LiveAdTagDetailName Parse(string liveAdTagDetailName) => Parse(liveAdTagDetailName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LiveAdTagDetailName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/liveSessions/{live_session}/liveAdTagDetails/{live_ad_tag_detail}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="liveAdTagDetailName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LiveAdTagDetailName"/> if successful.</returns>
        public static LiveAdTagDetailName Parse(string liveAdTagDetailName, bool allowUnparsed) =>
            TryParse(liveAdTagDetailName, allowUnparsed, out LiveAdTagDetailName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LiveAdTagDetailName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/liveSessions/{live_session}/liveAdTagDetails/{live_ad_tag_detail}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="liveAdTagDetailName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LiveAdTagDetailName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string liveAdTagDetailName, out LiveAdTagDetailName result) =>
            TryParse(liveAdTagDetailName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LiveAdTagDetailName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/liveSessions/{live_session}/liveAdTagDetails/{live_ad_tag_detail}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="liveAdTagDetailName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LiveAdTagDetailName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string liveAdTagDetailName, bool allowUnparsed, out LiveAdTagDetailName result)
        {
            gax::GaxPreconditions.CheckNotNull(liveAdTagDetailName, nameof(liveAdTagDetailName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationLiveSessionLiveAdTagDetail.TryParseName(liveAdTagDetailName, out resourceName))
            {
                result = FromProjectLocationLiveSessionLiveAdTagDetail(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(liveAdTagDetailName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LiveAdTagDetailName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string liveAdTagDetailId = null, string liveSessionId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LiveAdTagDetailId = liveAdTagDetailId;
            LiveSessionId = liveSessionId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LiveAdTagDetailName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/liveSessions/{live_session}/liveAdTagDetails/{live_ad_tag_detail}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveSessionId">The <c>LiveSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveAdTagDetailId">The <c>LiveAdTagDetail</c> ID. Must not be <c>null</c> or empty.</param>
        public LiveAdTagDetailName(string projectId, string locationId, string liveSessionId, string liveAdTagDetailId) : this(ResourceNameType.ProjectLocationLiveSessionLiveAdTagDetail, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), liveSessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(liveSessionId, nameof(liveSessionId)), liveAdTagDetailId: gax::GaxPreconditions.CheckNotNullOrEmpty(liveAdTagDetailId, nameof(liveAdTagDetailId)))
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
        /// The <c>LiveAdTagDetail</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string LiveAdTagDetailId { get; }

        /// <summary>
        /// The <c>LiveSession</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LiveSessionId { get; }

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
                case ResourceNameType.ProjectLocationLiveSessionLiveAdTagDetail: return s_projectLocationLiveSessionLiveAdTagDetail.Expand(ProjectId, LocationId, LiveSessionId, LiveAdTagDetailId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LiveAdTagDetailName);

        /// <inheritdoc/>
        public bool Equals(LiveAdTagDetailName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LiveAdTagDetailName a, LiveAdTagDetailName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LiveAdTagDetailName a, LiveAdTagDetailName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>VodAdTagDetail</c> resource.</summary>
    public sealed partial class VodAdTagDetailName : gax::IResourceName, sys::IEquatable<VodAdTagDetailName>
    {
        /// <summary>The possible contents of <see cref="VodAdTagDetailName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/vodSessions/{vod_session}/vodAdTagDetails/{vod_ad_tag_detail}</c>
            /// .
            /// </summary>
            ProjectLocationVodSessionVodAdTagDetail = 1,
        }

        private static gax::PathTemplate s_projectLocationVodSessionVodAdTagDetail = new gax::PathTemplate("projects/{project}/locations/{location}/vodSessions/{vod_session}/vodAdTagDetails/{vod_ad_tag_detail}");

        /// <summary>Creates a <see cref="VodAdTagDetailName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="VodAdTagDetailName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static VodAdTagDetailName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new VodAdTagDetailName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="VodAdTagDetailName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/vodSessions/{vod_session}/vodAdTagDetails/{vod_ad_tag_detail}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vodSessionId">The <c>VodSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vodAdTagDetailId">The <c>VodAdTagDetail</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="VodAdTagDetailName"/> constructed from the provided ids.</returns>
        public static VodAdTagDetailName FromProjectLocationVodSessionVodAdTagDetail(string projectId, string locationId, string vodSessionId, string vodAdTagDetailId) =>
            new VodAdTagDetailName(ResourceNameType.ProjectLocationVodSessionVodAdTagDetail, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), vodSessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(vodSessionId, nameof(vodSessionId)), vodAdTagDetailId: gax::GaxPreconditions.CheckNotNullOrEmpty(vodAdTagDetailId, nameof(vodAdTagDetailId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VodAdTagDetailName"/> with pattern
        /// <c>projects/{project}/locations/{location}/vodSessions/{vod_session}/vodAdTagDetails/{vod_ad_tag_detail}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vodSessionId">The <c>VodSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vodAdTagDetailId">The <c>VodAdTagDetail</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VodAdTagDetailName"/> with pattern
        /// <c>projects/{project}/locations/{location}/vodSessions/{vod_session}/vodAdTagDetails/{vod_ad_tag_detail}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string vodSessionId, string vodAdTagDetailId) =>
            FormatProjectLocationVodSessionVodAdTagDetail(projectId, locationId, vodSessionId, vodAdTagDetailId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VodAdTagDetailName"/> with pattern
        /// <c>projects/{project}/locations/{location}/vodSessions/{vod_session}/vodAdTagDetails/{vod_ad_tag_detail}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vodSessionId">The <c>VodSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vodAdTagDetailId">The <c>VodAdTagDetail</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VodAdTagDetailName"/> with pattern
        /// <c>projects/{project}/locations/{location}/vodSessions/{vod_session}/vodAdTagDetails/{vod_ad_tag_detail}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationVodSessionVodAdTagDetail(string projectId, string locationId, string vodSessionId, string vodAdTagDetailId) =>
            s_projectLocationVodSessionVodAdTagDetail.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(vodSessionId, nameof(vodSessionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(vodAdTagDetailId, nameof(vodAdTagDetailId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VodAdTagDetailName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/vodSessions/{vod_session}/vodAdTagDetails/{vod_ad_tag_detail}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="vodAdTagDetailName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="VodAdTagDetailName"/> if successful.</returns>
        public static VodAdTagDetailName Parse(string vodAdTagDetailName) => Parse(vodAdTagDetailName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VodAdTagDetailName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/vodSessions/{vod_session}/vodAdTagDetails/{vod_ad_tag_detail}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="vodAdTagDetailName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="VodAdTagDetailName"/> if successful.</returns>
        public static VodAdTagDetailName Parse(string vodAdTagDetailName, bool allowUnparsed) =>
            TryParse(vodAdTagDetailName, allowUnparsed, out VodAdTagDetailName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VodAdTagDetailName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/vodSessions/{vod_session}/vodAdTagDetails/{vod_ad_tag_detail}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="vodAdTagDetailName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VodAdTagDetailName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string vodAdTagDetailName, out VodAdTagDetailName result) =>
            TryParse(vodAdTagDetailName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VodAdTagDetailName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/vodSessions/{vod_session}/vodAdTagDetails/{vod_ad_tag_detail}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="vodAdTagDetailName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VodAdTagDetailName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string vodAdTagDetailName, bool allowUnparsed, out VodAdTagDetailName result)
        {
            gax::GaxPreconditions.CheckNotNull(vodAdTagDetailName, nameof(vodAdTagDetailName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationVodSessionVodAdTagDetail.TryParseName(vodAdTagDetailName, out resourceName))
            {
                result = FromProjectLocationVodSessionVodAdTagDetail(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(vodAdTagDetailName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private VodAdTagDetailName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string vodAdTagDetailId = null, string vodSessionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            VodAdTagDetailId = vodAdTagDetailId;
            VodSessionId = vodSessionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="VodAdTagDetailName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/vodSessions/{vod_session}/vodAdTagDetails/{vod_ad_tag_detail}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vodSessionId">The <c>VodSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vodAdTagDetailId">The <c>VodAdTagDetail</c> ID. Must not be <c>null</c> or empty.</param>
        public VodAdTagDetailName(string projectId, string locationId, string vodSessionId, string vodAdTagDetailId) : this(ResourceNameType.ProjectLocationVodSessionVodAdTagDetail, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), vodSessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(vodSessionId, nameof(vodSessionId)), vodAdTagDetailId: gax::GaxPreconditions.CheckNotNullOrEmpty(vodAdTagDetailId, nameof(vodAdTagDetailId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>VodAdTagDetail</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string VodAdTagDetailId { get; }

        /// <summary>
        /// The <c>VodSession</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string VodSessionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationVodSessionVodAdTagDetail: return s_projectLocationVodSessionVodAdTagDetail.Expand(ProjectId, LocationId, VodSessionId, VodAdTagDetailId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as VodAdTagDetailName);

        /// <inheritdoc/>
        public bool Equals(VodAdTagDetailName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(VodAdTagDetailName a, VodAdTagDetailName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(VodAdTagDetailName a, VodAdTagDetailName b) => !(a == b);
    }

    public partial class LiveAdTagDetail
    {
        /// <summary>
        /// <see cref="gcvsv::LiveAdTagDetailName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::LiveAdTagDetailName LiveAdTagDetailName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::LiveAdTagDetailName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class VodAdTagDetail
    {
        /// <summary>
        /// <see cref="gcvsv::VodAdTagDetailName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::VodAdTagDetailName VodAdTagDetailName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::VodAdTagDetailName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
