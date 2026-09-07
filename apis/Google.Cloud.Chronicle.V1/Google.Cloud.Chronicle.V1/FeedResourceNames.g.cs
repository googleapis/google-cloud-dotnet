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
    /// <summary>Resource name for the <c>FeedPack</c> resource.</summary>
    public sealed partial class FeedPackName : gax::IResourceName, sys::IEquatable<FeedPackName>
    {
        /// <summary>The possible contents of <see cref="FeedPackName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instances/{instance}/feedPacks/{feed_pack}</c>.
            /// </summary>
            ProjectLocationInstanceFeedPack = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceFeedPack = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/feedPacks/{feed_pack}");

        /// <summary>Creates a <see cref="FeedPackName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FeedPackName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static FeedPackName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FeedPackName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FeedPackName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedPacks/{feed_pack}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedPackId">The <c>FeedPack</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FeedPackName"/> constructed from the provided ids.</returns>
        public static FeedPackName FromProjectLocationInstanceFeedPack(string projectId, string locationId, string instanceId, string feedPackId) =>
            new FeedPackName(ResourceNameType.ProjectLocationInstanceFeedPack, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), feedPackId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedPackId, nameof(feedPackId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedPackName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedPacks/{feed_pack}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedPackId">The <c>FeedPack</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeedPackName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedPacks/{feed_pack}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string feedPackId) =>
            FormatProjectLocationInstanceFeedPack(projectId, locationId, instanceId, feedPackId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedPackName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedPacks/{feed_pack}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedPackId">The <c>FeedPack</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeedPackName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedPacks/{feed_pack}</c>.
        /// </returns>
        public static string FormatProjectLocationInstanceFeedPack(string projectId, string locationId, string instanceId, string feedPackId) =>
            s_projectLocationInstanceFeedPack.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(feedPackId, nameof(feedPackId)));

        /// <summary>Parses the given resource name string into a new <see cref="FeedPackName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedPacks/{feed_pack}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="feedPackName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeedPackName"/> if successful.</returns>
        public static FeedPackName Parse(string feedPackName) => Parse(feedPackName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeedPackName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedPacks/{feed_pack}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedPackName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FeedPackName"/> if successful.</returns>
        public static FeedPackName Parse(string feedPackName, bool allowUnparsed) =>
            TryParse(feedPackName, allowUnparsed, out FeedPackName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedPackName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedPacks/{feed_pack}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="feedPackName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedPackName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedPackName, out FeedPackName result) => TryParse(feedPackName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedPackName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedPacks/{feed_pack}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedPackName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedPackName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedPackName, bool allowUnparsed, out FeedPackName result)
        {
            gax::GaxPreconditions.CheckNotNull(feedPackName, nameof(feedPackName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceFeedPack.TryParseName(feedPackName, out resourceName))
            {
                result = FromProjectLocationInstanceFeedPack(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(feedPackName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FeedPackName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string feedPackId = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FeedPackId = feedPackId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FeedPackName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedPacks/{feed_pack}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedPackId">The <c>FeedPack</c> ID. Must not be <c>null</c> or empty.</param>
        public FeedPackName(string projectId, string locationId, string instanceId, string feedPackId) : this(ResourceNameType.ProjectLocationInstanceFeedPack, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), feedPackId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedPackId, nameof(feedPackId)))
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
        /// The <c>FeedPack</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FeedPackId { get; }

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
                case ResourceNameType.ProjectLocationInstanceFeedPack: return s_projectLocationInstanceFeedPack.Expand(ProjectId, LocationId, InstanceId, FeedPackId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FeedPackName);

        /// <inheritdoc/>
        public bool Equals(FeedPackName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FeedPackName a, FeedPackName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FeedPackName a, FeedPackName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>Feed</c> resource.</summary>
    public sealed partial class FeedName : gax::IResourceName, sys::IEquatable<FeedName>
    {
        /// <summary>The possible contents of <see cref="FeedName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}</c>.
            /// </summary>
            ProjectLocationInstanceFeed = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceFeed = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}");

        /// <summary>Creates a <see cref="FeedName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FeedName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FeedName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FeedName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FeedName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FeedName"/> constructed from the provided ids.</returns>
        public static FeedName FromProjectLocationInstanceFeed(string projectId, string locationId, string instanceId, string feedId) =>
            new FeedName(ResourceNameType.ProjectLocationInstanceFeed, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), feedId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedId, nameof(feedId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeedName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string feedId) =>
            FormatProjectLocationInstanceFeed(projectId, locationId, instanceId, feedId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeedName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}</c>.
        /// </returns>
        public static string FormatProjectLocationInstanceFeed(string projectId, string locationId, string instanceId, string feedId) =>
            s_projectLocationInstanceFeed.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(feedId, nameof(feedId)));

        /// <summary>Parses the given resource name string into a new <see cref="FeedName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="feedName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeedName"/> if successful.</returns>
        public static FeedName Parse(string feedName) => Parse(feedName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeedName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FeedName"/> if successful.</returns>
        public static FeedName Parse(string feedName, bool allowUnparsed) =>
            TryParse(feedName, allowUnparsed, out FeedName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="FeedName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="feedName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedName, out FeedName result) => TryParse(feedName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedName, bool allowUnparsed, out FeedName result)
        {
            gax::GaxPreconditions.CheckNotNull(feedName, nameof(feedName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceFeed.TryParseName(feedName, out resourceName))
            {
                result = FromProjectLocationInstanceFeed(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(feedName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FeedName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string feedId = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FeedId = feedId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FeedName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feeds/{feed}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        public FeedName(string projectId, string locationId, string instanceId, string feedId) : this(ResourceNameType.ProjectLocationInstanceFeed, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), feedId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedId, nameof(feedId)))
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
        /// The <c>Feed</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FeedId { get; }

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
                case ResourceNameType.ProjectLocationInstanceFeed: return s_projectLocationInstanceFeed.Expand(ProjectId, LocationId, InstanceId, FeedId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FeedName);

        /// <inheritdoc/>
        public bool Equals(FeedName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FeedName a, FeedName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FeedName a, FeedName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FeedServiceAccount</c> resource.</summary>
    public sealed partial class FeedServiceAccountName : gax::IResourceName, sys::IEquatable<FeedServiceAccountName>
    {
        /// <summary>The possible contents of <see cref="FeedServiceAccountName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/instances/{instance}/feedServiceAccounts/{feed_service_account}</c>
            /// .
            /// </summary>
            ProjectLocationInstanceFeedServiceAccount = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceFeedServiceAccount = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/feedServiceAccounts/{feed_service_account}");

        /// <summary>Creates a <see cref="FeedServiceAccountName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FeedServiceAccountName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FeedServiceAccountName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FeedServiceAccountName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FeedServiceAccountName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedServiceAccounts/{feed_service_account}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedServiceAccountId">
        /// The <c>FeedServiceAccount</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="FeedServiceAccountName"/> constructed from the provided ids.</returns>
        public static FeedServiceAccountName FromProjectLocationInstanceFeedServiceAccount(string projectId, string locationId, string instanceId, string feedServiceAccountId) =>
            new FeedServiceAccountName(ResourceNameType.ProjectLocationInstanceFeedServiceAccount, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), feedServiceAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedServiceAccountId, nameof(feedServiceAccountId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedServiceAccountName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedServiceAccounts/{feed_service_account}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedServiceAccountId">
        /// The <c>FeedServiceAccount</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FeedServiceAccountName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedServiceAccounts/{feed_service_account}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string feedServiceAccountId) =>
            FormatProjectLocationInstanceFeedServiceAccount(projectId, locationId, instanceId, feedServiceAccountId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedServiceAccountName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedServiceAccounts/{feed_service_account}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedServiceAccountId">
        /// The <c>FeedServiceAccount</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FeedServiceAccountName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedServiceAccounts/{feed_service_account}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationInstanceFeedServiceAccount(string projectId, string locationId, string instanceId, string feedServiceAccountId) =>
            s_projectLocationInstanceFeedServiceAccount.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(feedServiceAccountId, nameof(feedServiceAccountId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeedServiceAccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedServiceAccounts/{feed_service_account}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="feedServiceAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeedServiceAccountName"/> if successful.</returns>
        public static FeedServiceAccountName Parse(string feedServiceAccountName) => Parse(feedServiceAccountName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeedServiceAccountName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedServiceAccounts/{feed_service_account}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedServiceAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FeedServiceAccountName"/> if successful.</returns>
        public static FeedServiceAccountName Parse(string feedServiceAccountName, bool allowUnparsed) =>
            TryParse(feedServiceAccountName, allowUnparsed, out FeedServiceAccountName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedServiceAccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedServiceAccounts/{feed_service_account}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="feedServiceAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedServiceAccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedServiceAccountName, out FeedServiceAccountName result) =>
            TryParse(feedServiceAccountName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedServiceAccountName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedServiceAccounts/{feed_service_account}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedServiceAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedServiceAccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedServiceAccountName, bool allowUnparsed, out FeedServiceAccountName result)
        {
            gax::GaxPreconditions.CheckNotNull(feedServiceAccountName, nameof(feedServiceAccountName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceFeedServiceAccount.TryParseName(feedServiceAccountName, out resourceName))
            {
                result = FromProjectLocationInstanceFeedServiceAccount(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(feedServiceAccountName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FeedServiceAccountName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string feedServiceAccountId = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FeedServiceAccountId = feedServiceAccountId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FeedServiceAccountName"/> class from the component parts of
        /// pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedServiceAccounts/{feed_service_account}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedServiceAccountId">
        /// The <c>FeedServiceAccount</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public FeedServiceAccountName(string projectId, string locationId, string instanceId, string feedServiceAccountId) : this(ResourceNameType.ProjectLocationInstanceFeedServiceAccount, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), feedServiceAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedServiceAccountId, nameof(feedServiceAccountId)))
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
        /// The <c>FeedServiceAccount</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string FeedServiceAccountId { get; }

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
                case ResourceNameType.ProjectLocationInstanceFeedServiceAccount: return s_projectLocationInstanceFeedServiceAccount.Expand(ProjectId, LocationId, InstanceId, FeedServiceAccountId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FeedServiceAccountName);

        /// <inheritdoc/>
        public bool Equals(FeedServiceAccountName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FeedServiceAccountName a, FeedServiceAccountName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FeedServiceAccountName a, FeedServiceAccountName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>FeedSourceTypeSchema</c> resource.</summary>
    public sealed partial class FeedSourceTypeSchemaName : gax::IResourceName, sys::IEquatable<FeedSourceTypeSchemaName>
    {
        /// <summary>The possible contents of <see cref="FeedSourceTypeSchemaName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}</c>
            /// .
            /// </summary>
            ProjectLocationInstanceFeedSourceType = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceFeedSourceType = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}");

        /// <summary>Creates a <see cref="FeedSourceTypeSchemaName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FeedSourceTypeSchemaName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FeedSourceTypeSchemaName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FeedSourceTypeSchemaName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FeedSourceTypeSchemaName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedSourceTypeId">The <c>FeedSourceType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="FeedSourceTypeSchemaName"/> constructed from the provided ids.
        /// </returns>
        public static FeedSourceTypeSchemaName FromProjectLocationInstanceFeedSourceType(string projectId, string locationId, string instanceId, string feedSourceTypeId) =>
            new FeedSourceTypeSchemaName(ResourceNameType.ProjectLocationInstanceFeedSourceType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), feedSourceTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedSourceTypeId, nameof(feedSourceTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedSourceTypeSchemaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedSourceTypeId">The <c>FeedSourceType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeedSourceTypeSchemaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string feedSourceTypeId) =>
            FormatProjectLocationInstanceFeedSourceType(projectId, locationId, instanceId, feedSourceTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedSourceTypeSchemaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedSourceTypeId">The <c>FeedSourceType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeedSourceTypeSchemaName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationInstanceFeedSourceType(string projectId, string locationId, string instanceId, string feedSourceTypeId) =>
            s_projectLocationInstanceFeedSourceType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(feedSourceTypeId, nameof(feedSourceTypeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeedSourceTypeSchemaName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="feedSourceTypeSchemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeedSourceTypeSchemaName"/> if successful.</returns>
        public static FeedSourceTypeSchemaName Parse(string feedSourceTypeSchemaName) =>
            Parse(feedSourceTypeSchemaName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeedSourceTypeSchemaName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedSourceTypeSchemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FeedSourceTypeSchemaName"/> if successful.</returns>
        public static FeedSourceTypeSchemaName Parse(string feedSourceTypeSchemaName, bool allowUnparsed) =>
            TryParse(feedSourceTypeSchemaName, allowUnparsed, out FeedSourceTypeSchemaName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedSourceTypeSchemaName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="feedSourceTypeSchemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedSourceTypeSchemaName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedSourceTypeSchemaName, out FeedSourceTypeSchemaName result) =>
            TryParse(feedSourceTypeSchemaName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedSourceTypeSchemaName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedSourceTypeSchemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedSourceTypeSchemaName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedSourceTypeSchemaName, bool allowUnparsed, out FeedSourceTypeSchemaName result)
        {
            gax::GaxPreconditions.CheckNotNull(feedSourceTypeSchemaName, nameof(feedSourceTypeSchemaName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceFeedSourceType.TryParseName(feedSourceTypeSchemaName, out resourceName))
            {
                result = FromProjectLocationInstanceFeedSourceType(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(feedSourceTypeSchemaName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FeedSourceTypeSchemaName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string feedSourceTypeId = null, string instanceId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FeedSourceTypeId = feedSourceTypeId;
            InstanceId = instanceId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FeedSourceTypeSchemaName"/> class from the component parts of
        /// pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedSourceTypeId">The <c>FeedSourceType</c> ID. Must not be <c>null</c> or empty.</param>
        public FeedSourceTypeSchemaName(string projectId, string locationId, string instanceId, string feedSourceTypeId) : this(ResourceNameType.ProjectLocationInstanceFeedSourceType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), feedSourceTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedSourceTypeId, nameof(feedSourceTypeId)))
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
        /// The <c>FeedSourceType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string FeedSourceTypeId { get; }

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
                case ResourceNameType.ProjectLocationInstanceFeedSourceType: return s_projectLocationInstanceFeedSourceType.Expand(ProjectId, LocationId, InstanceId, FeedSourceTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FeedSourceTypeSchemaName);

        /// <inheritdoc/>
        public bool Equals(FeedSourceTypeSchemaName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FeedSourceTypeSchemaName a, FeedSourceTypeSchemaName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FeedSourceTypeSchemaName a, FeedSourceTypeSchemaName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>LogTypeSchema</c> resource.</summary>
    public sealed partial class LogTypeSchemaName : gax::IResourceName, sys::IEquatable<LogTypeSchemaName>
    {
        /// <summary>The possible contents of <see cref="LogTypeSchemaName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}/logTypeSchemas/{log_type}</c>
            /// .
            /// </summary>
            ProjectLocationInstanceFeedSourceTypeLogType = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceFeedSourceTypeLogType = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}/logTypeSchemas/{log_type}");

        /// <summary>Creates a <see cref="LogTypeSchemaName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LogTypeSchemaName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LogTypeSchemaName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LogTypeSchemaName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LogTypeSchemaName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}/logTypeSchemas/{log_type}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedSourceTypeId">The <c>FeedSourceType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="logTypeId">The <c>LogType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogTypeSchemaName"/> constructed from the provided ids.</returns>
        public static LogTypeSchemaName FromProjectLocationInstanceFeedSourceTypeLogType(string projectId, string locationId, string instanceId, string feedSourceTypeId, string logTypeId) =>
            new LogTypeSchemaName(ResourceNameType.ProjectLocationInstanceFeedSourceTypeLogType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), feedSourceTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedSourceTypeId, nameof(feedSourceTypeId)), logTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(logTypeId, nameof(logTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogTypeSchemaName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}/logTypeSchemas/{log_type}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedSourceTypeId">The <c>FeedSourceType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="logTypeId">The <c>LogType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogTypeSchemaName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}/logTypeSchemas/{log_type}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string feedSourceTypeId, string logTypeId) =>
            FormatProjectLocationInstanceFeedSourceTypeLogType(projectId, locationId, instanceId, feedSourceTypeId, logTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogTypeSchemaName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}/logTypeSchemas/{log_type}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedSourceTypeId">The <c>FeedSourceType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="logTypeId">The <c>LogType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogTypeSchemaName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}/logTypeSchemas/{log_type}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationInstanceFeedSourceTypeLogType(string projectId, string locationId, string instanceId, string feedSourceTypeId, string logTypeId) =>
            s_projectLocationInstanceFeedSourceTypeLogType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(feedSourceTypeId, nameof(feedSourceTypeId)), gax::GaxPreconditions.CheckNotNullOrEmpty(logTypeId, nameof(logTypeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LogTypeSchemaName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}/logTypeSchemas/{log_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="logTypeSchemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LogTypeSchemaName"/> if successful.</returns>
        public static LogTypeSchemaName Parse(string logTypeSchemaName) => Parse(logTypeSchemaName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LogTypeSchemaName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}/logTypeSchemas/{log_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="logTypeSchemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LogTypeSchemaName"/> if successful.</returns>
        public static LogTypeSchemaName Parse(string logTypeSchemaName, bool allowUnparsed) =>
            TryParse(logTypeSchemaName, allowUnparsed, out LogTypeSchemaName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LogTypeSchemaName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}/logTypeSchemas/{log_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="logTypeSchemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LogTypeSchemaName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logTypeSchemaName, out LogTypeSchemaName result) =>
            TryParse(logTypeSchemaName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LogTypeSchemaName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}/logTypeSchemas/{log_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="logTypeSchemaName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LogTypeSchemaName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logTypeSchemaName, bool allowUnparsed, out LogTypeSchemaName result)
        {
            gax::GaxPreconditions.CheckNotNull(logTypeSchemaName, nameof(logTypeSchemaName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceFeedSourceTypeLogType.TryParseName(logTypeSchemaName, out resourceName))
            {
                result = FromProjectLocationInstanceFeedSourceTypeLogType(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(logTypeSchemaName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LogTypeSchemaName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string feedSourceTypeId = null, string instanceId = null, string locationId = null, string logTypeId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FeedSourceTypeId = feedSourceTypeId;
            InstanceId = instanceId;
            LocationId = locationId;
            LogTypeId = logTypeId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LogTypeSchemaName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/instances/{instance}/feedSourceTypeSchemas/{feed_source_type}/logTypeSchemas/{log_type}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedSourceTypeId">The <c>FeedSourceType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="logTypeId">The <c>LogType</c> ID. Must not be <c>null</c> or empty.</param>
        public LogTypeSchemaName(string projectId, string locationId, string instanceId, string feedSourceTypeId, string logTypeId) : this(ResourceNameType.ProjectLocationInstanceFeedSourceTypeLogType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), feedSourceTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedSourceTypeId, nameof(feedSourceTypeId)), logTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(logTypeId, nameof(logTypeId)))
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
        /// The <c>FeedSourceType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string FeedSourceTypeId { get; }

        /// <summary>
        /// The <c>Instance</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InstanceId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>LogType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LogTypeId { get; }

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
                case ResourceNameType.ProjectLocationInstanceFeedSourceTypeLogType: return s_projectLocationInstanceFeedSourceTypeLogType.Expand(ProjectId, LocationId, InstanceId, FeedSourceTypeId, LogTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LogTypeSchemaName);

        /// <inheritdoc/>
        public bool Equals(LogTypeSchemaName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LogTypeSchemaName a, LogTypeSchemaName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LogTypeSchemaName a, LogTypeSchemaName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>LogType</c> resource.</summary>
    public sealed partial class LogTypeName : gax::IResourceName, sys::IEquatable<LogTypeName>
    {
        /// <summary>The possible contents of <see cref="LogTypeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/instances/{instance}/logTypes/{log_type}</c>.
            /// </summary>
            ProjectLocationInstanceLogType = 1,
        }

        private static gax::PathTemplate s_projectLocationInstanceLogType = new gax::PathTemplate("projects/{project}/locations/{location}/instances/{instance}/logTypes/{log_type}");

        /// <summary>Creates a <see cref="LogTypeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LogTypeName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LogTypeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LogTypeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LogTypeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/logTypes/{log_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="logTypeId">The <c>LogType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LogTypeName"/> constructed from the provided ids.</returns>
        public static LogTypeName FromProjectLocationInstanceLogType(string projectId, string locationId, string instanceId, string logTypeId) =>
            new LogTypeName(ResourceNameType.ProjectLocationInstanceLogType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), logTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(logTypeId, nameof(logTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/logTypes/{log_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="logTypeId">The <c>LogType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/logTypes/{log_type}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string instanceId, string logTypeId) =>
            FormatProjectLocationInstanceLogType(projectId, locationId, instanceId, logTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LogTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/logTypes/{log_type}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="logTypeId">The <c>LogType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LogTypeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/logTypes/{log_type}</c>.
        /// </returns>
        public static string FormatProjectLocationInstanceLogType(string projectId, string locationId, string instanceId, string logTypeId) =>
            s_projectLocationInstanceLogType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(logTypeId, nameof(logTypeId)));

        /// <summary>Parses the given resource name string into a new <see cref="LogTypeName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/logTypes/{log_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="logTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LogTypeName"/> if successful.</returns>
        public static LogTypeName Parse(string logTypeName) => Parse(logTypeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LogTypeName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/logTypes/{log_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="logTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LogTypeName"/> if successful.</returns>
        public static LogTypeName Parse(string logTypeName, bool allowUnparsed) =>
            TryParse(logTypeName, allowUnparsed, out LogTypeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LogTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/logTypes/{log_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="logTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LogTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logTypeName, out LogTypeName result) => TryParse(logTypeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LogTypeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/instances/{instance}/logTypes/{log_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="logTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LogTypeName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string logTypeName, bool allowUnparsed, out LogTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(logTypeName, nameof(logTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationInstanceLogType.TryParseName(logTypeName, out resourceName))
            {
                result = FromProjectLocationInstanceLogType(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(logTypeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LogTypeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string instanceId = null, string locationId = null, string logTypeId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            InstanceId = instanceId;
            LocationId = locationId;
            LogTypeId = logTypeId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LogTypeName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/instances/{instance}/logTypes/{log_type}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="instanceId">The <c>Instance</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="logTypeId">The <c>LogType</c> ID. Must not be <c>null</c> or empty.</param>
        public LogTypeName(string projectId, string locationId, string instanceId, string logTypeId) : this(ResourceNameType.ProjectLocationInstanceLogType, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), instanceId: gax::GaxPreconditions.CheckNotNullOrEmpty(instanceId, nameof(instanceId)), logTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(logTypeId, nameof(logTypeId)))
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
        /// The <c>LogType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LogTypeId { get; }

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
                case ResourceNameType.ProjectLocationInstanceLogType: return s_projectLocationInstanceLogType.Expand(ProjectId, LocationId, InstanceId, LogTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LogTypeName);

        /// <inheritdoc/>
        public bool Equals(LogTypeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LogTypeName a, LogTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LogTypeName a, LogTypeName b) => !(a == b);
    }

    public partial class FeedPack
    {
        /// <summary>
        /// <see cref="gccv::FeedPackName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FeedPackName FeedPackName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FeedPackName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Feed
    {
        /// <summary>
        /// <see cref="gccv::FeedName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FeedName FeedName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FeedName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FeedServiceAccount
    {
        /// <summary>
        /// <see cref="gccv::FeedServiceAccountName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FeedServiceAccountName FeedServiceAccountName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FeedServiceAccountName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FeedDetails
    {
        /// <summary>
        /// <see cref="LogTypeName"/>-typed view over the <see cref="LogType"/> resource name property.
        /// </summary>
        public LogTypeName LogTypeAsLogTypeName
        {
            get => string.IsNullOrEmpty(LogType) ? null : LogTypeName.Parse(LogType, allowUnparsed: true);
            set => LogType = value?.ToString() ?? "";
        }
    }

    public partial class FeedSourceTypeSchema
    {
        /// <summary>
        /// <see cref="gccv::FeedSourceTypeSchemaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FeedSourceTypeSchemaName FeedSourceTypeSchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FeedSourceTypeSchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class LogTypeSchema
    {
        /// <summary>
        /// <see cref="gccv::LogTypeSchemaName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::LogTypeSchemaName LogTypeSchemaName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::LogTypeSchemaName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class FetchServiceAccountForCustomerRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListFeedSourceTypeSchemasRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListLogTypeSchemasRequest
    {
        /// <summary>
        /// <see cref="FeedSourceTypeSchemaName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FeedSourceTypeSchemaName ParentAsFeedSourceTypeSchemaName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FeedSourceTypeSchemaName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ImportPushLogsRequest
    {
        /// <summary><see cref="FeedName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public FeedName ParentAsFeedName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FeedName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListFeedsRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListFeedPacksRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetFeedPackRequest
    {
        /// <summary>
        /// <see cref="gccv::FeedPackName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FeedPackName FeedPackName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FeedPackName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateFeedRequest
    {
        /// <summary>
        /// <see cref="InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetFeedRequest
    {
        /// <summary>
        /// <see cref="gccv::FeedName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FeedName FeedName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FeedName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteFeedRequest
    {
        /// <summary>
        /// <see cref="gccv::FeedName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FeedName FeedName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FeedName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class EnableFeedRequest
    {
        /// <summary>
        /// <see cref="gccv::FeedName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FeedName FeedName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FeedName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GenerateSecretRequest
    {
        /// <summary>
        /// <see cref="gccv::FeedName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FeedName FeedName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FeedName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DisableFeedRequest
    {
        /// <summary>
        /// <see cref="gccv::FeedName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::FeedName FeedName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::FeedName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
