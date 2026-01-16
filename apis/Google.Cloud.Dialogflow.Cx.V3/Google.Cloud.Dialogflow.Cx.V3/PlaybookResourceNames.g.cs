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
using gcdcv = Google.Cloud.Dialogflow.Cx.V3;
using sys = System;

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Resource name for the <c>Playbook</c> resource.</summary>
    public sealed partial class PlaybookName : gax::IResourceName, sys::IEquatable<PlaybookName>
    {
        /// <summary>The possible contents of <see cref="PlaybookName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}</c>.
            /// </summary>
            ProjectLocationAgentPlaybook = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentPlaybook = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}");

        /// <summary>Creates a <see cref="PlaybookName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PlaybookName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static PlaybookName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PlaybookName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PlaybookName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="playbookId">The <c>Playbook</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PlaybookName"/> constructed from the provided ids.</returns>
        public static PlaybookName FromProjectLocationAgentPlaybook(string projectId, string locationId, string agentId, string playbookId) =>
            new PlaybookName(ResourceNameType.ProjectLocationAgentPlaybook, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), playbookId: gax::GaxPreconditions.CheckNotNullOrEmpty(playbookId, nameof(playbookId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PlaybookName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="playbookId">The <c>Playbook</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PlaybookName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId, string playbookId) =>
            FormatProjectLocationAgentPlaybook(projectId, locationId, agentId, playbookId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PlaybookName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="playbookId">The <c>Playbook</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PlaybookName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}</c>.
        /// </returns>
        public static string FormatProjectLocationAgentPlaybook(string projectId, string locationId, string agentId, string playbookId) =>
            s_projectLocationAgentPlaybook.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(playbookId, nameof(playbookId)));

        /// <summary>Parses the given resource name string into a new <see cref="PlaybookName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="playbookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PlaybookName"/> if successful.</returns>
        public static PlaybookName Parse(string playbookName) => Parse(playbookName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PlaybookName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="playbookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PlaybookName"/> if successful.</returns>
        public static PlaybookName Parse(string playbookName, bool allowUnparsed) =>
            TryParse(playbookName, allowUnparsed, out PlaybookName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PlaybookName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="playbookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PlaybookName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string playbookName, out PlaybookName result) => TryParse(playbookName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PlaybookName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="playbookName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PlaybookName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string playbookName, bool allowUnparsed, out PlaybookName result)
        {
            gax::GaxPreconditions.CheckNotNull(playbookName, nameof(playbookName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentPlaybook.TryParseName(playbookName, out resourceName))
            {
                result = FromProjectLocationAgentPlaybook(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(playbookName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PlaybookName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string locationId = null, string playbookId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            LocationId = locationId;
            PlaybookId = playbookId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PlaybookName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="playbookId">The <c>Playbook</c> ID. Must not be <c>null</c> or empty.</param>
        public PlaybookName(string projectId, string locationId, string agentId, string playbookId) : this(ResourceNameType.ProjectLocationAgentPlaybook, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), playbookId: gax::GaxPreconditions.CheckNotNullOrEmpty(playbookId, nameof(playbookId)))
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
        /// The <c>Agent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AgentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Playbook</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PlaybookId { get; }

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
                case ResourceNameType.ProjectLocationAgentPlaybook: return s_projectLocationAgentPlaybook.Expand(ProjectId, LocationId, AgentId, PlaybookId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PlaybookName);

        /// <inheritdoc/>
        public bool Equals(PlaybookName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PlaybookName a, PlaybookName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PlaybookName a, PlaybookName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>PlaybookVersion</c> resource.</summary>
    public sealed partial class PlaybookVersionName : gax::IResourceName, sys::IEquatable<PlaybookVersionName>
    {
        /// <summary>The possible contents of <see cref="PlaybookVersionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}/versions/{version}</c>.
            /// </summary>
            ProjectLocationAgentPlaybookVersion = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentPlaybookVersion = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}/versions/{version}");

        /// <summary>Creates a <see cref="PlaybookVersionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PlaybookVersionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PlaybookVersionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PlaybookVersionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PlaybookVersionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="playbookId">The <c>Playbook</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PlaybookVersionName"/> constructed from the provided ids.</returns>
        public static PlaybookVersionName FromProjectLocationAgentPlaybookVersion(string projectId, string locationId, string agentId, string playbookId, string versionId) =>
            new PlaybookVersionName(ResourceNameType.ProjectLocationAgentPlaybookVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), playbookId: gax::GaxPreconditions.CheckNotNullOrEmpty(playbookId, nameof(playbookId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PlaybookVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="playbookId">The <c>Playbook</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PlaybookVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}/versions/{version}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId, string playbookId, string versionId) =>
            FormatProjectLocationAgentPlaybookVersion(projectId, locationId, agentId, playbookId, versionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PlaybookVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="playbookId">The <c>Playbook</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PlaybookVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}/versions/{version}</c>.
        /// </returns>
        public static string FormatProjectLocationAgentPlaybookVersion(string projectId, string locationId, string agentId, string playbookId, string versionId) =>
            s_projectLocationAgentPlaybookVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(playbookId, nameof(playbookId)), gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PlaybookVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}/versions/{version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="playbookVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PlaybookVersionName"/> if successful.</returns>
        public static PlaybookVersionName Parse(string playbookVersionName) => Parse(playbookVersionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PlaybookVersionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}/versions/{version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="playbookVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PlaybookVersionName"/> if successful.</returns>
        public static PlaybookVersionName Parse(string playbookVersionName, bool allowUnparsed) =>
            TryParse(playbookVersionName, allowUnparsed, out PlaybookVersionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PlaybookVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}/versions/{version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="playbookVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PlaybookVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string playbookVersionName, out PlaybookVersionName result) =>
            TryParse(playbookVersionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PlaybookVersionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}/versions/{version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="playbookVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PlaybookVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string playbookVersionName, bool allowUnparsed, out PlaybookVersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(playbookVersionName, nameof(playbookVersionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentPlaybookVersion.TryParseName(playbookVersionName, out resourceName))
            {
                result = FromProjectLocationAgentPlaybookVersion(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(playbookVersionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PlaybookVersionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string locationId = null, string playbookId = null, string projectId = null, string versionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            LocationId = locationId;
            PlaybookId = playbookId;
            ProjectId = projectId;
            VersionId = versionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PlaybookVersionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/playbooks/{playbook}/versions/{version}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="playbookId">The <c>Playbook</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        public PlaybookVersionName(string projectId, string locationId, string agentId, string playbookId, string versionId) : this(ResourceNameType.ProjectLocationAgentPlaybookVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), playbookId: gax::GaxPreconditions.CheckNotNullOrEmpty(playbookId, nameof(playbookId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)))
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
        /// The <c>Agent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AgentId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Playbook</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string PlaybookId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Version</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string VersionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationAgentPlaybookVersion: return s_projectLocationAgentPlaybookVersion.Expand(ProjectId, LocationId, AgentId, PlaybookId, VersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PlaybookVersionName);

        /// <inheritdoc/>
        public bool Equals(PlaybookVersionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PlaybookVersionName a, PlaybookVersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PlaybookVersionName a, PlaybookVersionName b) => !(a == b);
    }

    public partial class CreatePlaybookRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeletePlaybookRequest
    {
        /// <summary>
        /// <see cref="gcdcv::PlaybookName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::PlaybookName PlaybookName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::PlaybookName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPlaybooksRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetPlaybookRequest
    {
        /// <summary>
        /// <see cref="gcdcv::PlaybookName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::PlaybookName PlaybookName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::PlaybookName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Playbook
    {
        /// <summary>
        /// <see cref="gcdcv::PlaybookName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::PlaybookName PlaybookName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::PlaybookName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gcdcv::PlaybookName"/>-typed view over the <see cref="ReferencedPlaybooks"/> resource name
        /// property.
        /// </summary>
        public gax::ResourceNameList<gcdcv::PlaybookName> ReferencedPlaybooksAsPlaybookNames
        {
            get => new gax::ResourceNameList<gcdcv::PlaybookName>(ReferencedPlaybooks, s => string.IsNullOrEmpty(s) ? null : gcdcv::PlaybookName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="FlowName"/>-typed view over the <see cref="ReferencedFlows"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<FlowName> ReferencedFlowsAsFlowNames
        {
            get => new gax::ResourceNameList<FlowName>(ReferencedFlows, s => string.IsNullOrEmpty(s) ? null : FlowName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="ToolName"/>-typed view over the <see cref="ReferencedTools"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<ToolName> ReferencedToolsAsToolNames
        {
            get => new gax::ResourceNameList<ToolName>(ReferencedTools, s => string.IsNullOrEmpty(s) ? null : ToolName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class CreatePlaybookVersionRequest
    {
        /// <summary>
        /// <see cref="PlaybookName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PlaybookName ParentAsPlaybookName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PlaybookName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class PlaybookVersion
    {
        /// <summary>
        /// <see cref="gcdcv::PlaybookVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::PlaybookVersionName PlaybookVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::PlaybookVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetPlaybookVersionRequest
    {
        /// <summary>
        /// <see cref="gcdcv::PlaybookVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::PlaybookVersionName PlaybookVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::PlaybookVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RestorePlaybookVersionRequest
    {
        /// <summary>
        /// <see cref="gcdcv::PlaybookVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::PlaybookVersionName PlaybookVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::PlaybookVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPlaybookVersionsRequest
    {
        /// <summary>
        /// <see cref="PlaybookName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public PlaybookName ParentAsPlaybookName
        {
            get => string.IsNullOrEmpty(Parent) ? null : PlaybookName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeletePlaybookVersionRequest
    {
        /// <summary>
        /// <see cref="gcdcv::PlaybookVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::PlaybookVersionName PlaybookVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::PlaybookVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExportPlaybookRequest
    {
        /// <summary>
        /// <see cref="gcdcv::PlaybookName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::PlaybookName PlaybookName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::PlaybookName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportPlaybookRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ImportPlaybookResponse
    {
        /// <summary>
        /// <see cref="PlaybookName"/>-typed view over the <see cref="Playbook"/> resource name property.
        /// </summary>
        public PlaybookName PlaybookAsPlaybookName
        {
            get => string.IsNullOrEmpty(Playbook) ? null : PlaybookName.Parse(Playbook, allowUnparsed: true);
            set => Playbook = value?.ToString() ?? "";
        }
    }
}
