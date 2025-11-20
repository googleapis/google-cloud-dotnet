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
using gcav = Google.Cloud.AIPlatform.V1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Resource name for the <c>ReasoningEngine</c> resource.</summary>
    public sealed partial class ReasoningEngineName : gax::IResourceName, sys::IEquatable<ReasoningEngineName>
    {
        /// <summary>The possible contents of <see cref="ReasoningEngineName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}</c>.
            /// </summary>
            ProjectLocationReasoningEngine = 1,
        }

        private static gax::PathTemplate s_projectLocationReasoningEngine = new gax::PathTemplate("projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}");

        /// <summary>Creates a <see cref="ReasoningEngineName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ReasoningEngineName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ReasoningEngineName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ReasoningEngineName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ReasoningEngineName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reasoningEngineId">The <c>ReasoningEngine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ReasoningEngineName"/> constructed from the provided ids.</returns>
        public static ReasoningEngineName FromProjectLocationReasoningEngine(string projectId, string locationId, string reasoningEngineId) =>
            new ReasoningEngineName(ResourceNameType.ProjectLocationReasoningEngine, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reasoningEngineId: gax::GaxPreconditions.CheckNotNullOrEmpty(reasoningEngineId, nameof(reasoningEngineId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReasoningEngineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reasoningEngineId">The <c>ReasoningEngine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReasoningEngineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string reasoningEngineId) =>
            FormatProjectLocationReasoningEngine(projectId, locationId, reasoningEngineId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ReasoningEngineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reasoningEngineId">The <c>ReasoningEngine</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ReasoningEngineName"/> with pattern
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}</c>.
        /// </returns>
        public static string FormatProjectLocationReasoningEngine(string projectId, string locationId, string reasoningEngineId) =>
            s_projectLocationReasoningEngine.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(reasoningEngineId, nameof(reasoningEngineId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReasoningEngineName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="reasoningEngineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ReasoningEngineName"/> if successful.</returns>
        public static ReasoningEngineName Parse(string reasoningEngineName) => Parse(reasoningEngineName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ReasoningEngineName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reasoningEngineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ReasoningEngineName"/> if successful.</returns>
        public static ReasoningEngineName Parse(string reasoningEngineName, bool allowUnparsed) =>
            TryParse(reasoningEngineName, allowUnparsed, out ReasoningEngineName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReasoningEngineName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="reasoningEngineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReasoningEngineName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reasoningEngineName, out ReasoningEngineName result) =>
            TryParse(reasoningEngineName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ReasoningEngineName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="reasoningEngineName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ReasoningEngineName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string reasoningEngineName, bool allowUnparsed, out ReasoningEngineName result)
        {
            gax::GaxPreconditions.CheckNotNull(reasoningEngineName, nameof(reasoningEngineName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationReasoningEngine.TryParseName(reasoningEngineName, out resourceName))
            {
                result = FromProjectLocationReasoningEngine(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(reasoningEngineName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ReasoningEngineName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string projectId = null, string reasoningEngineId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ProjectId = projectId;
            ReasoningEngineId = reasoningEngineId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ReasoningEngineName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/reasoningEngines/{reasoning_engine}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="reasoningEngineId">The <c>ReasoningEngine</c> ID. Must not be <c>null</c> or empty.</param>
        public ReasoningEngineName(string projectId, string locationId, string reasoningEngineId) : this(ResourceNameType.ProjectLocationReasoningEngine, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), reasoningEngineId: gax::GaxPreconditions.CheckNotNullOrEmpty(reasoningEngineId, nameof(reasoningEngineId)))
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
        /// The <c>ReasoningEngine</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ReasoningEngineId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationReasoningEngine: return s_projectLocationReasoningEngine.Expand(ProjectId, LocationId, ReasoningEngineId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ReasoningEngineName);

        /// <inheritdoc/>
        public bool Equals(ReasoningEngineName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ReasoningEngineName a, ReasoningEngineName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ReasoningEngineName a, ReasoningEngineName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>GitRepositoryLink</c> resource.</summary>
    public sealed partial class GitRepositoryLinkName : gax::IResourceName, sys::IEquatable<GitRepositoryLinkName>
    {
        /// <summary>The possible contents of <see cref="GitRepositoryLinkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/connections/{connection}/gitRepositoryLinks/{git_repository_link}</c>
            /// .
            /// </summary>
            ProjectLocationConnectionGitRepositoryLink = 1,
        }

        private static gax::PathTemplate s_projectLocationConnectionGitRepositoryLink = new gax::PathTemplate("projects/{project}/locations/{location}/connections/{connection}/gitRepositoryLinks/{git_repository_link}");

        /// <summary>Creates a <see cref="GitRepositoryLinkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GitRepositoryLinkName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GitRepositoryLinkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GitRepositoryLinkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GitRepositoryLinkName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/gitRepositoryLinks/{git_repository_link}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gitRepositoryLinkId">The <c>GitRepositoryLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GitRepositoryLinkName"/> constructed from the provided ids.</returns>
        public static GitRepositoryLinkName FromProjectLocationConnectionGitRepositoryLink(string projectId, string locationId, string connectionId, string gitRepositoryLinkId) =>
            new GitRepositoryLinkName(ResourceNameType.ProjectLocationConnectionGitRepositoryLink, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), connectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)), gitRepositoryLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(gitRepositoryLinkId, nameof(gitRepositoryLinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GitRepositoryLinkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/gitRepositoryLinks/{git_repository_link}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gitRepositoryLinkId">The <c>GitRepositoryLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GitRepositoryLinkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/gitRepositoryLinks/{git_repository_link}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string connectionId, string gitRepositoryLinkId) =>
            FormatProjectLocationConnectionGitRepositoryLink(projectId, locationId, connectionId, gitRepositoryLinkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GitRepositoryLinkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/gitRepositoryLinks/{git_repository_link}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gitRepositoryLinkId">The <c>GitRepositoryLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GitRepositoryLinkName"/> with pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/gitRepositoryLinks/{git_repository_link}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationConnectionGitRepositoryLink(string projectId, string locationId, string connectionId, string gitRepositoryLinkId) =>
            s_projectLocationConnectionGitRepositoryLink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(gitRepositoryLinkId, nameof(gitRepositoryLinkId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GitRepositoryLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/gitRepositoryLinks/{git_repository_link}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="gitRepositoryLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GitRepositoryLinkName"/> if successful.</returns>
        public static GitRepositoryLinkName Parse(string gitRepositoryLinkName) => Parse(gitRepositoryLinkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GitRepositoryLinkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/gitRepositoryLinks/{git_repository_link}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gitRepositoryLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GitRepositoryLinkName"/> if successful.</returns>
        public static GitRepositoryLinkName Parse(string gitRepositoryLinkName, bool allowUnparsed) =>
            TryParse(gitRepositoryLinkName, allowUnparsed, out GitRepositoryLinkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GitRepositoryLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/gitRepositoryLinks/{git_repository_link}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="gitRepositoryLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GitRepositoryLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gitRepositoryLinkName, out GitRepositoryLinkName result) =>
            TryParse(gitRepositoryLinkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GitRepositoryLinkName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/connections/{connection}/gitRepositoryLinks/{git_repository_link}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="gitRepositoryLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GitRepositoryLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string gitRepositoryLinkName, bool allowUnparsed, out GitRepositoryLinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(gitRepositoryLinkName, nameof(gitRepositoryLinkName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationConnectionGitRepositoryLink.TryParseName(gitRepositoryLinkName, out resourceName))
            {
                result = FromProjectLocationConnectionGitRepositoryLink(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(gitRepositoryLinkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GitRepositoryLinkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string connectionId = null, string gitRepositoryLinkId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConnectionId = connectionId;
            GitRepositoryLinkId = gitRepositoryLinkId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GitRepositoryLinkName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/connections/{connection}/gitRepositoryLinks/{git_repository_link}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="connectionId">The <c>Connection</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="gitRepositoryLinkId">The <c>GitRepositoryLink</c> ID. Must not be <c>null</c> or empty.</param>
        public GitRepositoryLinkName(string projectId, string locationId, string connectionId, string gitRepositoryLinkId) : this(ResourceNameType.ProjectLocationConnectionGitRepositoryLink, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), connectionId: gax::GaxPreconditions.CheckNotNullOrEmpty(connectionId, nameof(connectionId)), gitRepositoryLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(gitRepositoryLinkId, nameof(gitRepositoryLinkId)))
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
        /// The <c>Connection</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ConnectionId { get; }

        /// <summary>
        /// The <c>GitRepositoryLink</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string GitRepositoryLinkId { get; }

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
                case ResourceNameType.ProjectLocationConnectionGitRepositoryLink: return s_projectLocationConnectionGitRepositoryLink.Expand(ProjectId, LocationId, ConnectionId, GitRepositoryLinkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GitRepositoryLinkName);

        /// <inheritdoc/>
        public bool Equals(GitRepositoryLinkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GitRepositoryLinkName a, GitRepositoryLinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GitRepositoryLinkName a, GitRepositoryLinkName b) => !(a == b);
    }

    public partial class ReasoningEngineSpec
    {
        public partial class Types
        {
            public partial class SourceCodeSpec
            {
                public partial class Types
                {
                    public partial class DeveloperConnectConfig
                    {
                        /// <summary>
                        /// <see cref="GitRepositoryLinkName"/>-typed view over the <see cref="GitRepositoryLink"/>
                        /// resource name property.
                        /// </summary>
                        public GitRepositoryLinkName GitRepositoryLinkAsGitRepositoryLinkName
                        {
                            get => string.IsNullOrEmpty(GitRepositoryLink) ? null : GitRepositoryLinkName.Parse(GitRepositoryLink, allowUnparsed: true);
                            set => GitRepositoryLink = value?.ToString() ?? "";
                        }
                    }
                }
            }
        }
    }

    public partial class ReasoningEngine
    {
        /// <summary>
        /// <see cref="gcav::ReasoningEngineName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ReasoningEngineName ReasoningEngineName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ReasoningEngineName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
