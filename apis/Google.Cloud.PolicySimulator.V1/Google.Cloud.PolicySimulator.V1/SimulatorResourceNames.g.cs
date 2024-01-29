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
using gcpv = Google.Cloud.PolicySimulator.V1;
using sys = System;

namespace Google.Cloud.PolicySimulator.V1
{
    /// <summary>Resource name for the <c>Replay</c> resource.</summary>
    public sealed partial class ReplayName : gax::IResourceName, sys::IEquatable<ReplayName>
    {
        /// <summary>The possible contents of <see cref="ReplayName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/replays/{replay}</c>.
            /// </summary>
            ProjectLocationReplay = 1,

            /// <summary>
            /// A resource name with pattern <c>folders/{folder}/locations/{location}/replays/{replay}</c>.
            /// </summary>
            FolderLocationReplay = 2,

            /// <summary>
            /// A resource name with pattern <c>organizations/{organization}/locations/{location}/replays/{replay}</c>.
            /// </summary>
            OrganizationLocationReplay = 3,
        }

        private static gax::PathTemplate s_projectLocationReplay = new gax::PathTemplate("projects/{project}/locations/{location}/replays/{replay}");

        private static gax::PathTemplate s_folderLocationReplay = new gax::PathTemplate("folders/{folder}/locations/{location}/replays/{replay}");

        private static gax::PathTemplate s_organizationLocationReplay = new gax::PathTemplate("organizations/{organization}/locations/{location}/replays/{replay}");

        /// <summary>Creates a <see cref="ReplayName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReplayName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReplayName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReplayName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReplayName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/replays/{replay}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayId">The <c>Replay</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReplayName"/> constructed from the provided ids.</returns>
        public static ReplayName FromProjectLocationReplay(string projectId, string locationId, string replayId) =>
            new ReplayName(ResourceNameType.ProjectLocationReplay, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), replayId: gax::GaxPreconditions.CheckNotNullOrEmpty(replayId, nameof(replayId)));

        /// <summary>
        /// Creates a <see cref="ReplayName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/replays/{replay}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayId">The <c>Replay</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReplayName"/> constructed from the provided ids.</returns>
        public static ReplayName FromFolderLocationReplay(string folderId, string locationId, string replayId) =>
            new ReplayName(ResourceNameType.FolderLocationReplay, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), replayId: gax::GaxPreconditions.CheckNotNullOrEmpty(replayId, nameof(replayId)));

        /// <summary>
        /// Creates a <see cref="ReplayName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/replays/{replay}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayId">The <c>Replay</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReplayName"/> constructed from the provided ids.</returns>
        public static ReplayName FromOrganizationLocationReplay(string organizationId, string locationId, string replayId) =>
            new ReplayName(ResourceNameType.OrganizationLocationReplay, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), replayId: gax::GaxPreconditions.CheckNotNullOrEmpty(replayId, nameof(replayId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReplayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/replays/{replay}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayId">The <c>Replay</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReplayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/replays/{replay}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string replayId) =>
            FormatProjectLocationReplay(projectId, locationId, replayId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReplayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/replays/{replay}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayId">The <c>Replay</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReplayName"/> with pattern
        /// <c>projects/{project}/locations/{location}/replays/{replay}</c>.
        /// </returns>
        public static string FormatProjectLocationReplay(string projectId, string locationId, string replayId) =>
            s_projectLocationReplay.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(replayId, nameof(replayId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReplayName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/replays/{replay}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayId">The <c>Replay</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReplayName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/replays/{replay}</c>.
        /// </returns>
        public static string FormatFolderLocationReplay(string folderId, string locationId, string replayId) =>
            s_folderLocationReplay.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(replayId, nameof(replayId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReplayName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/replays/{replay}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayId">The <c>Replay</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReplayName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/replays/{replay}</c>.
        /// </returns>
        public static string FormatOrganizationLocationReplay(string organizationId, string locationId, string replayId) =>
            s_organizationLocationReplay.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(replayId, nameof(replayId)));

        /// <summary>Parses the given resource name string into a new <see cref="ReplayName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/replays/{replay}</c></description></item>
        /// <item><description><c>folders/{folder}/locations/{location}/replays/{replay}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/replays/{replay}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="replayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReplayName"/> if successful.</returns>
        public static ReplayName Parse(string replayName) => Parse(replayName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReplayName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/replays/{replay}</c></description></item>
        /// <item><description><c>folders/{folder}/locations/{location}/replays/{replay}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/replays/{replay}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="replayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReplayName"/> if successful.</returns>
        public static ReplayName Parse(string replayName, bool allowUnparsed) =>
            TryParse(replayName, allowUnparsed, out ReplayName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReplayName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/replays/{replay}</c></description></item>
        /// <item><description><c>folders/{folder}/locations/{location}/replays/{replay}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/replays/{replay}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="replayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReplayName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string replayName, out ReplayName result) => TryParse(replayName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReplayName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/replays/{replay}</c></description></item>
        /// <item><description><c>folders/{folder}/locations/{location}/replays/{replay}</c></description></item>
        /// <item>
        /// <description><c>organizations/{organization}/locations/{location}/replays/{replay}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="replayName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReplayName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string replayName, bool allowUnparsed, out ReplayName result)
        {
            gax::GaxPreconditions.CheckNotNull(replayName, nameof(replayName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationReplay.TryParseName(replayName, out resourceName))
            {
                result = FromProjectLocationReplay(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_folderLocationReplay.TryParseName(replayName, out resourceName))
            {
                result = FromFolderLocationReplay(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (s_organizationLocationReplay.TryParseName(replayName, out resourceName))
            {
                result = FromOrganizationLocationReplay(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(replayName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReplayName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null, string replayId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            ReplayId = replayId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReplayName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/replays/{replay}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayId">The <c>Replay</c> ID. Must not be <c>null</c> or empty.</param>
        public ReplayName(string projectId, string locationId, string replayId) : this(ResourceNameType.ProjectLocationReplay, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), replayId: gax::GaxPreconditions.CheckNotNullOrEmpty(replayId, nameof(replayId)))
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
        /// The <c>Replay</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ReplayId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationReplay: return s_projectLocationReplay.Expand(ProjectId, LocationId, ReplayId);
                case ResourceNameType.FolderLocationReplay: return s_folderLocationReplay.Expand(FolderId, LocationId, ReplayId);
                case ResourceNameType.OrganizationLocationReplay: return s_organizationLocationReplay.Expand(OrganizationId, LocationId, ReplayId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReplayName);

        /// <inheritdoc/>
        public bool Equals(ReplayName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReplayName a, ReplayName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReplayName a, ReplayName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ReplayResult</c> resource.</summary>
    public sealed partial class ReplayResultName : gax::IResourceName, sys::IEquatable<ReplayResultName>
    {
        /// <summary>The possible contents of <see cref="ReplayResultName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/replays/{replay}/results/{replay_result}</c>.
            /// </summary>
            ProjectLocationReplayReplayResult = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>folders/{folder}/locations/{location}/replays/{replay}/results/{replay_result}</c>.
            /// </summary>
            FolderLocationReplayReplayResult = 2,

            /// <summary>
            /// A resource name with pattern
            /// <c>organizations/{organization}/locations/{location}/replays/{replay}/results/{replay_result}</c>.
            /// </summary>
            OrganizationLocationReplayReplayResult = 3,
        }

        private static gax::PathTemplate s_projectLocationReplayReplayResult = new gax::PathTemplate("projects/{project}/locations/{location}/replays/{replay}/results/{replay_result}");

        private static gax::PathTemplate s_folderLocationReplayReplayResult = new gax::PathTemplate("folders/{folder}/locations/{location}/replays/{replay}/results/{replay_result}");

        private static gax::PathTemplate s_organizationLocationReplayReplayResult = new gax::PathTemplate("organizations/{organization}/locations/{location}/replays/{replay}/results/{replay_result}");

        /// <summary>Creates a <see cref="ReplayResultName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReplayResultName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReplayResultName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReplayResultName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReplayResultName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/replays/{replay}/results/{replay_result}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayId">The <c>Replay</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayResultId">The <c>ReplayResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReplayResultName"/> constructed from the provided ids.</returns>
        public static ReplayResultName FromProjectLocationReplayReplayResult(string projectId, string locationId, string replayId, string replayResultId) =>
            new ReplayResultName(ResourceNameType.ProjectLocationReplayReplayResult, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), replayId: gax::GaxPreconditions.CheckNotNullOrEmpty(replayId, nameof(replayId)), replayResultId: gax::GaxPreconditions.CheckNotNullOrEmpty(replayResultId, nameof(replayResultId)));

        /// <summary>
        /// Creates a <see cref="ReplayResultName"/> with the pattern
        /// <c>folders/{folder}/locations/{location}/replays/{replay}/results/{replay_result}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayId">The <c>Replay</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayResultId">The <c>ReplayResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReplayResultName"/> constructed from the provided ids.</returns>
        public static ReplayResultName FromFolderLocationReplayReplayResult(string folderId, string locationId, string replayId, string replayResultId) =>
            new ReplayResultName(ResourceNameType.FolderLocationReplayReplayResult, folderId: gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), replayId: gax::GaxPreconditions.CheckNotNullOrEmpty(replayId, nameof(replayId)), replayResultId: gax::GaxPreconditions.CheckNotNullOrEmpty(replayResultId, nameof(replayResultId)));

        /// <summary>
        /// Creates a <see cref="ReplayResultName"/> with the pattern
        /// <c>organizations/{organization}/locations/{location}/replays/{replay}/results/{replay_result}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayId">The <c>Replay</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayResultId">The <c>ReplayResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReplayResultName"/> constructed from the provided ids.</returns>
        public static ReplayResultName FromOrganizationLocationReplayReplayResult(string organizationId, string locationId, string replayId, string replayResultId) =>
            new ReplayResultName(ResourceNameType.OrganizationLocationReplayReplayResult, organizationId: gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), replayId: gax::GaxPreconditions.CheckNotNullOrEmpty(replayId, nameof(replayId)), replayResultId: gax::GaxPreconditions.CheckNotNullOrEmpty(replayResultId, nameof(replayResultId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReplayResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/replays/{replay}/results/{replay_result}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayId">The <c>Replay</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayResultId">The <c>ReplayResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReplayResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/replays/{replay}/results/{replay_result}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string replayId, string replayResultId) =>
            FormatProjectLocationReplayReplayResult(projectId, locationId, replayId, replayResultId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReplayResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/replays/{replay}/results/{replay_result}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayId">The <c>Replay</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayResultId">The <c>ReplayResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReplayResultName"/> with pattern
        /// <c>projects/{project}/locations/{location}/replays/{replay}/results/{replay_result}</c>.
        /// </returns>
        public static string FormatProjectLocationReplayReplayResult(string projectId, string locationId, string replayId, string replayResultId) =>
            s_projectLocationReplayReplayResult.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(replayId, nameof(replayId)), gax::GaxPreconditions.CheckNotNullOrEmpty(replayResultId, nameof(replayResultId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReplayResultName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/replays/{replay}/results/{replay_result}</c>.
        /// </summary>
        /// <param name="folderId">The <c>Folder</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayId">The <c>Replay</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayResultId">The <c>ReplayResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReplayResultName"/> with pattern
        /// <c>folders/{folder}/locations/{location}/replays/{replay}/results/{replay_result}</c>.
        /// </returns>
        public static string FormatFolderLocationReplayReplayResult(string folderId, string locationId, string replayId, string replayResultId) =>
            s_folderLocationReplayReplayResult.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(folderId, nameof(folderId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(replayId, nameof(replayId)), gax::GaxPreconditions.CheckNotNullOrEmpty(replayResultId, nameof(replayResultId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReplayResultName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/replays/{replay}/results/{replay_result}</c>.
        /// </summary>
        /// <param name="organizationId">The <c>Organization</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayId">The <c>Replay</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayResultId">The <c>ReplayResult</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReplayResultName"/> with pattern
        /// <c>organizations/{organization}/locations/{location}/replays/{replay}/results/{replay_result}</c>.
        /// </returns>
        public static string FormatOrganizationLocationReplayReplayResult(string organizationId, string locationId, string replayId, string replayResultId) =>
            s_organizationLocationReplayReplayResult.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(organizationId, nameof(organizationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(replayId, nameof(replayId)), gax::GaxPreconditions.CheckNotNullOrEmpty(replayResultId, nameof(replayResultId)));

        /// <summary>Parses the given resource name string into a new <see cref="ReplayResultName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/replays/{replay}/results/{replay_result}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/replays/{replay}/results/{replay_result}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/replays/{replay}/results/{replay_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="replayResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReplayResultName"/> if successful.</returns>
        public static ReplayResultName Parse(string replayResultName) => Parse(replayResultName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReplayResultName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/replays/{replay}/results/{replay_result}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/replays/{replay}/results/{replay_result}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/replays/{replay}/results/{replay_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="replayResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReplayResultName"/> if successful.</returns>
        public static ReplayResultName Parse(string replayResultName, bool allowUnparsed) =>
            TryParse(replayResultName, allowUnparsed, out ReplayResultName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReplayResultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/replays/{replay}/results/{replay_result}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/replays/{replay}/results/{replay_result}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/replays/{replay}/results/{replay_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="replayResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReplayResultName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string replayResultName, out ReplayResultName result) =>
            TryParse(replayResultName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReplayResultName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/replays/{replay}/results/{replay_result}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>folders/{folder}/locations/{location}/replays/{replay}/results/{replay_result}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>organizations/{organization}/locations/{location}/replays/{replay}/results/{replay_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="replayResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReplayResultName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string replayResultName, bool allowUnparsed, out ReplayResultName result)
        {
            gax::GaxPreconditions.CheckNotNull(replayResultName, nameof(replayResultName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationReplayReplayResult.TryParseName(replayResultName, out resourceName))
            {
                result = FromProjectLocationReplayReplayResult(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_folderLocationReplayReplayResult.TryParseName(replayResultName, out resourceName))
            {
                result = FromFolderLocationReplayReplayResult(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_organizationLocationReplayReplayResult.TryParseName(replayResultName, out resourceName))
            {
                result = FromOrganizationLocationReplayReplayResult(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(replayResultName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReplayResultName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string folderId = null, string locationId = null, string organizationId = null, string projectId = null, string replayId = null, string replayResultId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            FolderId = folderId;
            LocationId = locationId;
            OrganizationId = organizationId;
            ProjectId = projectId;
            ReplayId = replayId;
            ReplayResultId = replayResultId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReplayResultName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/replays/{replay}/results/{replay_result}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayId">The <c>Replay</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="replayResultId">The <c>ReplayResult</c> ID. Must not be <c>null</c> or empty.</param>
        public ReplayResultName(string projectId, string locationId, string replayId, string replayResultId) : this(ResourceNameType.ProjectLocationReplayReplayResult, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), replayId: gax::GaxPreconditions.CheckNotNullOrEmpty(replayId, nameof(replayId)), replayResultId: gax::GaxPreconditions.CheckNotNullOrEmpty(replayResultId, nameof(replayResultId)))
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
        /// The <c>Replay</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string ReplayId { get; }

        /// <summary>
        /// The <c>ReplayResult</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ReplayResultId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationReplayReplayResult: return s_projectLocationReplayReplayResult.Expand(ProjectId, LocationId, ReplayId, ReplayResultId);
                case ResourceNameType.FolderLocationReplayReplayResult: return s_folderLocationReplayReplayResult.Expand(FolderId, LocationId, ReplayId, ReplayResultId);
                case ResourceNameType.OrganizationLocationReplayReplayResult: return s_organizationLocationReplayReplayResult.Expand(OrganizationId, LocationId, ReplayId, ReplayResultId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReplayResultName);

        /// <inheritdoc/>
        public bool Equals(ReplayResultName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReplayResultName a, ReplayResultName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReplayResultName a, ReplayResultName b) => !(a == b);
    }

    public partial class Replay
    {
        /// <summary>
        /// <see cref="gcpv::ReplayName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::ReplayName ReplayName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::ReplayName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReplayResult
    {
        /// <summary>
        /// <see cref="gcpv::ReplayResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::ReplayResultName ReplayResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::ReplayResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="ReplayName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ReplayName ParentAsReplayName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ReplayName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetReplayRequest
    {
        /// <summary>
        /// <see cref="gcpv::ReplayName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcpv::ReplayName ReplayName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcpv::ReplayName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListReplayResultsRequest
    {
        /// <summary><see cref="ReplayName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ReplayName ParentAsReplayName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ReplayName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
