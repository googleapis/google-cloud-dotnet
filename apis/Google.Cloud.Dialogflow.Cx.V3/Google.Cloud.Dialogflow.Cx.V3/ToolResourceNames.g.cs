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
    /// <summary>Resource name for the <c>Tool</c> resource.</summary>
    public sealed partial class ToolName : gax::IResourceName, sys::IEquatable<ToolName>
    {
        /// <summary>The possible contents of <see cref="ToolName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}</c>.
            /// </summary>
            ProjectLocationAgentTool = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentTool = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/tools/{tool}");

        /// <summary>Creates a <see cref="ToolName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ToolName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ToolName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ToolName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ToolName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolId">The <c>Tool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ToolName"/> constructed from the provided ids.</returns>
        public static ToolName FromProjectLocationAgentTool(string projectId, string locationId, string agentId, string toolId) =>
            new ToolName(ResourceNameType.ProjectLocationAgentTool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), toolId: gax::GaxPreconditions.CheckNotNullOrEmpty(toolId, nameof(toolId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ToolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolId">The <c>Tool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ToolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId, string toolId) =>
            FormatProjectLocationAgentTool(projectId, locationId, agentId, toolId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ToolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolId">The <c>Tool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ToolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}</c>.
        /// </returns>
        public static string FormatProjectLocationAgentTool(string projectId, string locationId, string agentId, string toolId) =>
            s_projectLocationAgentTool.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(toolId, nameof(toolId)));

        /// <summary>Parses the given resource name string into a new <see cref="ToolName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="toolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ToolName"/> if successful.</returns>
        public static ToolName Parse(string toolName) => Parse(toolName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ToolName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="toolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ToolName"/> if successful.</returns>
        public static ToolName Parse(string toolName, bool allowUnparsed) =>
            TryParse(toolName, allowUnparsed, out ToolName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="ToolName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="toolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ToolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string toolName, out ToolName result) => TryParse(toolName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ToolName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="toolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ToolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string toolName, bool allowUnparsed, out ToolName result)
        {
            gax::GaxPreconditions.CheckNotNull(toolName, nameof(toolName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentTool.TryParseName(toolName, out resourceName))
            {
                result = FromProjectLocationAgentTool(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(toolName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ToolName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string locationId = null, string projectId = null, string toolId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            LocationId = locationId;
            ProjectId = projectId;
            ToolId = toolId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ToolName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolId">The <c>Tool</c> ID. Must not be <c>null</c> or empty.</param>
        public ToolName(string projectId, string locationId, string agentId, string toolId) : this(ResourceNameType.ProjectLocationAgentTool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), toolId: gax::GaxPreconditions.CheckNotNullOrEmpty(toolId, nameof(toolId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Tool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ToolId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationAgentTool: return s_projectLocationAgentTool.Expand(ProjectId, LocationId, AgentId, ToolId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ToolName);

        /// <inheritdoc/>
        public bool Equals(ToolName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ToolName a, ToolName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ToolName a, ToolName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ToolVersion</c> resource.</summary>
    public sealed partial class ToolVersionName : gax::IResourceName, sys::IEquatable<ToolVersionName>
    {
        /// <summary>The possible contents of <see cref="ToolVersionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}/versions/{version}</c>.
            /// </summary>
            ProjectLocationAgentToolVersion = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentToolVersion = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/tools/{tool}/versions/{version}");

        /// <summary>Creates a <see cref="ToolVersionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ToolVersionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ToolVersionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ToolVersionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ToolVersionName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolId">The <c>Tool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ToolVersionName"/> constructed from the provided ids.</returns>
        public static ToolVersionName FromProjectLocationAgentToolVersion(string projectId, string locationId, string agentId, string toolId, string versionId) =>
            new ToolVersionName(ResourceNameType.ProjectLocationAgentToolVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), toolId: gax::GaxPreconditions.CheckNotNullOrEmpty(toolId, nameof(toolId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ToolVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolId">The <c>Tool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ToolVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}/versions/{version}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId, string toolId, string versionId) =>
            FormatProjectLocationAgentToolVersion(projectId, locationId, agentId, toolId, versionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ToolVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}/versions/{version}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolId">The <c>Tool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ToolVersionName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}/versions/{version}</c>.
        /// </returns>
        public static string FormatProjectLocationAgentToolVersion(string projectId, string locationId, string agentId, string toolId, string versionId) =>
            s_projectLocationAgentToolVersion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(toolId, nameof(toolId)), gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)));

        /// <summary>Parses the given resource name string into a new <see cref="ToolVersionName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}/versions/{version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="toolVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ToolVersionName"/> if successful.</returns>
        public static ToolVersionName Parse(string toolVersionName) => Parse(toolVersionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ToolVersionName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}/versions/{version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="toolVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ToolVersionName"/> if successful.</returns>
        public static ToolVersionName Parse(string toolVersionName, bool allowUnparsed) =>
            TryParse(toolVersionName, allowUnparsed, out ToolVersionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ToolVersionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}/versions/{version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="toolVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ToolVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string toolVersionName, out ToolVersionName result) =>
            TryParse(toolVersionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ToolVersionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}/versions/{version}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="toolVersionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ToolVersionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string toolVersionName, bool allowUnparsed, out ToolVersionName result)
        {
            gax::GaxPreconditions.CheckNotNull(toolVersionName, nameof(toolVersionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentToolVersion.TryParseName(toolVersionName, out resourceName))
            {
                result = FromProjectLocationAgentToolVersion(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(toolVersionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ToolVersionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string locationId = null, string projectId = null, string toolId = null, string versionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            LocationId = locationId;
            ProjectId = projectId;
            ToolId = toolId;
            VersionId = versionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ToolVersionName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/tools/{tool}/versions/{version}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="toolId">The <c>Tool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="versionId">The <c>Version</c> ID. Must not be <c>null</c> or empty.</param>
        public ToolVersionName(string projectId, string locationId, string agentId, string toolId, string versionId) : this(ResourceNameType.ProjectLocationAgentToolVersion, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), toolId: gax::GaxPreconditions.CheckNotNullOrEmpty(toolId, nameof(toolId)), versionId: gax::GaxPreconditions.CheckNotNullOrEmpty(versionId, nameof(versionId)))
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
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>Tool</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ToolId { get; }

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
                case ResourceNameType.ProjectLocationAgentToolVersion: return s_projectLocationAgentToolVersion.Expand(ProjectId, LocationId, AgentId, ToolId, VersionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ToolVersionName);

        /// <inheritdoc/>
        public bool Equals(ToolVersionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ToolVersionName a, ToolVersionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ToolVersionName a, ToolVersionName b) => !(a == b);
    }

    public partial class CreateToolRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListToolsRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetToolRequest
    {
        /// <summary>
        /// <see cref="gcdcv::ToolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::ToolName ToolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::ToolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteToolRequest
    {
        /// <summary>
        /// <see cref="gcdcv::ToolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::ToolName ToolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::ToolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class Tool
    {
        /// <summary>
        /// <see cref="gcdcv::ToolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::ToolName ToolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::ToolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class Authentication
            {
                public partial class Types
                {
                    public partial class ApiKeyConfig
                    {
                        /// <summary>
                        /// <see cref="SecretVersionName"/>-typed view over the <see cref="SecretVersionForApiKey"/>
                        /// resource name property.
                        /// </summary>
                        public SecretVersionName SecretVersionForApiKeyAsSecretVersionName
                        {
                            get => string.IsNullOrEmpty(SecretVersionForApiKey) ? null : SecretVersionName.Parse(SecretVersionForApiKey, allowUnparsed: true);
                            set => SecretVersionForApiKey = value?.ToString() ?? "";
                        }
                    }

                    public partial class OAuthConfig
                    {
                        /// <summary>
                        /// <see cref="SecretVersionName"/>-typed view over the
                        /// <see cref="SecretVersionForClientSecret"/> resource name property.
                        /// </summary>
                        public SecretVersionName SecretVersionForClientSecretAsSecretVersionName
                        {
                            get => string.IsNullOrEmpty(SecretVersionForClientSecret) ? null : SecretVersionName.Parse(SecretVersionForClientSecret, allowUnparsed: true);
                            set => SecretVersionForClientSecret = value?.ToString() ?? "";
                        }
                    }

                    public partial class BearerTokenConfig
                    {
                        /// <summary>
                        /// <see cref="SecretVersionName"/>-typed view over the <see cref="SecretVersionForToken"/>
                        /// resource name property.
                        /// </summary>
                        public SecretVersionName SecretVersionForTokenAsSecretVersionName
                        {
                            get => string.IsNullOrEmpty(SecretVersionForToken) ? null : SecretVersionName.Parse(SecretVersionForToken, allowUnparsed: true);
                            set => SecretVersionForToken = value?.ToString() ?? "";
                        }
                    }
                }
            }

            public partial class ServiceDirectoryConfig
            {
                /// <summary>
                /// <see cref="ServiceName"/>-typed view over the <see cref="Service"/> resource name property.
                /// </summary>
                public ServiceName ServiceAsServiceName
                {
                    get => string.IsNullOrEmpty(Service) ? null : ServiceName.Parse(Service, allowUnparsed: true);
                    set => Service = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class ListToolVersionsRequest
    {
        /// <summary><see cref="ToolName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ToolName ParentAsToolName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ToolName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateToolVersionRequest
    {
        /// <summary><see cref="ToolName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ToolName ParentAsToolName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ToolName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetToolVersionRequest
    {
        /// <summary>
        /// <see cref="gcdcv::ToolVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::ToolVersionName ToolVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::ToolVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteToolVersionRequest
    {
        /// <summary>
        /// <see cref="gcdcv::ToolVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::ToolVersionName ToolVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::ToolVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RestoreToolVersionRequest
    {
        /// <summary>
        /// <see cref="gcdcv::ToolVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::ToolVersionName ToolVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::ToolVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ToolVersion
    {
        /// <summary>
        /// <see cref="gcdcv::ToolVersionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::ToolVersionName ToolVersionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::ToolVersionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
