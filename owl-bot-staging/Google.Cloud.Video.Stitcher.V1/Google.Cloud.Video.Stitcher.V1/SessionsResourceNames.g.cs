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
    /// <summary>Resource name for the <c>VodSession</c> resource.</summary>
    public sealed partial class VodSessionName : gax::IResourceName, sys::IEquatable<VodSessionName>
    {
        /// <summary>The possible contents of <see cref="VodSessionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/vodSessions/{vod_session}</c>.
            /// </summary>
            ProjectLocationVodSession = 1,
        }

        private static gax::PathTemplate s_projectLocationVodSession = new gax::PathTemplate("projects/{project}/locations/{location}/vodSessions/{vod_session}");

        /// <summary>Creates a <see cref="VodSessionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="VodSessionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static VodSessionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new VodSessionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="VodSessionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/vodSessions/{vod_session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vodSessionId">The <c>VodSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="VodSessionName"/> constructed from the provided ids.</returns>
        public static VodSessionName FromProjectLocationVodSession(string projectId, string locationId, string vodSessionId) =>
            new VodSessionName(ResourceNameType.ProjectLocationVodSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), vodSessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(vodSessionId, nameof(vodSessionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VodSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/vodSessions/{vod_session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vodSessionId">The <c>VodSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VodSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/vodSessions/{vod_session}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string vodSessionId) =>
            FormatProjectLocationVodSession(projectId, locationId, vodSessionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VodSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/vodSessions/{vod_session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vodSessionId">The <c>VodSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VodSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/vodSessions/{vod_session}</c>.
        /// </returns>
        public static string FormatProjectLocationVodSession(string projectId, string locationId, string vodSessionId) =>
            s_projectLocationVodSession.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(vodSessionId, nameof(vodSessionId)));

        /// <summary>Parses the given resource name string into a new <see cref="VodSessionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/vodSessions/{vod_session}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="vodSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="VodSessionName"/> if successful.</returns>
        public static VodSessionName Parse(string vodSessionName) => Parse(vodSessionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VodSessionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/vodSessions/{vod_session}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="vodSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="VodSessionName"/> if successful.</returns>
        public static VodSessionName Parse(string vodSessionName, bool allowUnparsed) =>
            TryParse(vodSessionName, allowUnparsed, out VodSessionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VodSessionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/vodSessions/{vod_session}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="vodSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VodSessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string vodSessionName, out VodSessionName result) =>
            TryParse(vodSessionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VodSessionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/vodSessions/{vod_session}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="vodSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VodSessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string vodSessionName, bool allowUnparsed, out VodSessionName result)
        {
            gax::GaxPreconditions.CheckNotNull(vodSessionName, nameof(vodSessionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationVodSession.TryParseName(vodSessionName, out resourceName))
            {
                result = FromProjectLocationVodSession(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(vodSessionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private VodSessionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string vodSessionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            VodSessionId = vodSessionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="VodSessionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/vodSessions/{vod_session}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="vodSessionId">The <c>VodSession</c> ID. Must not be <c>null</c> or empty.</param>
        public VodSessionName(string projectId, string locationId, string vodSessionId) : this(ResourceNameType.ProjectLocationVodSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), vodSessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(vodSessionId, nameof(vodSessionId)))
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
                case ResourceNameType.ProjectLocationVodSession: return s_projectLocationVodSession.Expand(ProjectId, LocationId, VodSessionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as VodSessionName);

        /// <inheritdoc/>
        public bool Equals(VodSessionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(VodSessionName a, VodSessionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(VodSessionName a, VodSessionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>LiveSession</c> resource.</summary>
    public sealed partial class LiveSessionName : gax::IResourceName, sys::IEquatable<LiveSessionName>
    {
        /// <summary>The possible contents of <see cref="LiveSessionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/liveSessions/{live_session}</c>.
            /// </summary>
            ProjectLocationLiveSession = 1,
        }

        private static gax::PathTemplate s_projectLocationLiveSession = new gax::PathTemplate("projects/{project}/locations/{location}/liveSessions/{live_session}");

        /// <summary>Creates a <see cref="LiveSessionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LiveSessionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LiveSessionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LiveSessionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LiveSessionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/liveSessions/{live_session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveSessionId">The <c>LiveSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LiveSessionName"/> constructed from the provided ids.</returns>
        public static LiveSessionName FromProjectLocationLiveSession(string projectId, string locationId, string liveSessionId) =>
            new LiveSessionName(ResourceNameType.ProjectLocationLiveSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), liveSessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(liveSessionId, nameof(liveSessionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LiveSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/liveSessions/{live_session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveSessionId">The <c>LiveSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LiveSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/liveSessions/{live_session}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string liveSessionId) =>
            FormatProjectLocationLiveSession(projectId, locationId, liveSessionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LiveSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/liveSessions/{live_session}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveSessionId">The <c>LiveSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LiveSessionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/liveSessions/{live_session}</c>.
        /// </returns>
        public static string FormatProjectLocationLiveSession(string projectId, string locationId, string liveSessionId) =>
            s_projectLocationLiveSession.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(liveSessionId, nameof(liveSessionId)));

        /// <summary>Parses the given resource name string into a new <see cref="LiveSessionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/liveSessions/{live_session}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="liveSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LiveSessionName"/> if successful.</returns>
        public static LiveSessionName Parse(string liveSessionName) => Parse(liveSessionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LiveSessionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/liveSessions/{live_session}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="liveSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LiveSessionName"/> if successful.</returns>
        public static LiveSessionName Parse(string liveSessionName, bool allowUnparsed) =>
            TryParse(liveSessionName, allowUnparsed, out LiveSessionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LiveSessionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/liveSessions/{live_session}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="liveSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LiveSessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string liveSessionName, out LiveSessionName result) =>
            TryParse(liveSessionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LiveSessionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/liveSessions/{live_session}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="liveSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LiveSessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string liveSessionName, bool allowUnparsed, out LiveSessionName result)
        {
            gax::GaxPreconditions.CheckNotNull(liveSessionName, nameof(liveSessionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationLiveSession.TryParseName(liveSessionName, out resourceName))
            {
                result = FromProjectLocationLiveSession(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(liveSessionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LiveSessionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string liveSessionId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LiveSessionId = liveSessionId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LiveSessionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/liveSessions/{live_session}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liveSessionId">The <c>LiveSession</c> ID. Must not be <c>null</c> or empty.</param>
        public LiveSessionName(string projectId, string locationId, string liveSessionId) : this(ResourceNameType.ProjectLocationLiveSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), liveSessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(liveSessionId, nameof(liveSessionId)))
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
                case ResourceNameType.ProjectLocationLiveSession: return s_projectLocationLiveSession.Expand(ProjectId, LocationId, LiveSessionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LiveSessionName);

        /// <inheritdoc/>
        public bool Equals(LiveSessionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LiveSessionName a, LiveSessionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LiveSessionName a, LiveSessionName b) => !(a == b);
    }

    public partial class VodSession
    {
        /// <summary>
        /// <see cref="gcvsv::VodSessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::VodSessionName VodSessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::VodSessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VodConfigName"/>-typed view over the <see cref="VodConfig"/> resource name property.
        /// </summary>
        public VodConfigName VodConfigAsVodConfigName
        {
            get => string.IsNullOrEmpty(VodConfig) ? null : VodConfigName.Parse(VodConfig, allowUnparsed: true);
            set => VodConfig = value?.ToString() ?? "";
        }
    }

    public partial class LiveSession
    {
        /// <summary>
        /// <see cref="gcvsv::LiveSessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvsv::LiveSessionName LiveSessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvsv::LiveSessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="LiveConfigName"/>-typed view over the <see cref="LiveConfig"/> resource name property.
        /// </summary>
        public LiveConfigName LiveConfigAsLiveConfigName
        {
            get => string.IsNullOrEmpty(LiveConfig) ? null : LiveConfigName.Parse(LiveConfig, allowUnparsed: true);
            set => LiveConfig = value?.ToString() ?? "";
        }
    }
}
