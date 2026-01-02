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
using gcav = Google.Cloud.ApiRegistry.V1Beta;
using sys = System;

namespace Google.Cloud.ApiRegistry.V1Beta
{
    /// <summary>Resource name for the <c>McpServer</c> resource.</summary>
    public sealed partial class McpServerName : gax::IResourceName, sys::IEquatable<McpServerName>
    {
        /// <summary>The possible contents of <see cref="McpServerName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}</c>.
            /// </summary>
            ProjectLocationApiNamespaceMcpServer = 1,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/mcpServers/{mcp_server}</c>.
            /// </summary>
            ProjectLocationMcpServer = 2,
        }

        private static gax::PathTemplate s_projectLocationApiNamespaceMcpServer = new gax::PathTemplate("projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}");

        private static gax::PathTemplate s_projectLocationMcpServer = new gax::PathTemplate("projects/{project}/locations/{location}/mcpServers/{mcp_server}");

        /// <summary>Creates a <see cref="McpServerName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="McpServerName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static McpServerName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new McpServerName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="McpServerName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiNamespaceId">The <c>ApiNamespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mcpServerId">The <c>McpServer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="McpServerName"/> constructed from the provided ids.</returns>
        public static McpServerName FromProjectLocationApiNamespaceMcpServer(string projectId, string locationId, string apiNamespaceId, string mcpServerId) =>
            new McpServerName(ResourceNameType.ProjectLocationApiNamespaceMcpServer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiNamespaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiNamespaceId, nameof(apiNamespaceId)), mcpServerId: gax::GaxPreconditions.CheckNotNullOrEmpty(mcpServerId, nameof(mcpServerId)));

        /// <summary>
        /// Creates a <see cref="McpServerName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/mcpServers/{mcp_server}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mcpServerId">The <c>McpServer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="McpServerName"/> constructed from the provided ids.</returns>
        public static McpServerName FromProjectLocationMcpServer(string projectId, string locationId, string mcpServerId) =>
            new McpServerName(ResourceNameType.ProjectLocationMcpServer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), mcpServerId: gax::GaxPreconditions.CheckNotNullOrEmpty(mcpServerId, nameof(mcpServerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="McpServerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiNamespaceId">The <c>ApiNamespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mcpServerId">The <c>McpServer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="McpServerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string apiNamespaceId, string mcpServerId) =>
            FormatProjectLocationApiNamespaceMcpServer(projectId, locationId, apiNamespaceId, mcpServerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="McpServerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiNamespaceId">The <c>ApiNamespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mcpServerId">The <c>McpServer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="McpServerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}</c>.
        /// </returns>
        public static string FormatProjectLocationApiNamespaceMcpServer(string projectId, string locationId, string apiNamespaceId, string mcpServerId) =>
            s_projectLocationApiNamespaceMcpServer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(apiNamespaceId, nameof(apiNamespaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(mcpServerId, nameof(mcpServerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="McpServerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/mcpServers/{mcp_server}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mcpServerId">The <c>McpServer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="McpServerName"/> with pattern
        /// <c>projects/{project}/locations/{location}/mcpServers/{mcp_server}</c>.
        /// </returns>
        public static string FormatProjectLocationMcpServer(string projectId, string locationId, string mcpServerId) =>
            s_projectLocationMcpServer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(mcpServerId, nameof(mcpServerId)));

        /// <summary>Parses the given resource name string into a new <see cref="McpServerName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/mcpServers/{mcp_server}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="mcpServerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="McpServerName"/> if successful.</returns>
        public static McpServerName Parse(string mcpServerName) => Parse(mcpServerName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="McpServerName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/mcpServers/{mcp_server}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mcpServerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="McpServerName"/> if successful.</returns>
        public static McpServerName Parse(string mcpServerName, bool allowUnparsed) =>
            TryParse(mcpServerName, allowUnparsed, out McpServerName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="McpServerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/mcpServers/{mcp_server}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="mcpServerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="McpServerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mcpServerName, out McpServerName result) => TryParse(mcpServerName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="McpServerName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/mcpServers/{mcp_server}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mcpServerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="McpServerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mcpServerName, bool allowUnparsed, out McpServerName result)
        {
            gax::GaxPreconditions.CheckNotNull(mcpServerName, nameof(mcpServerName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationApiNamespaceMcpServer.TryParseName(mcpServerName, out resourceName))
            {
                result = FromProjectLocationApiNamespaceMcpServer(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (s_projectLocationMcpServer.TryParseName(mcpServerName, out resourceName))
            {
                result = FromProjectLocationMcpServer(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(mcpServerName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private McpServerName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string apiNamespaceId = null, string locationId = null, string mcpServerId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApiNamespaceId = apiNamespaceId;
            LocationId = locationId;
            McpServerId = mcpServerId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="McpServerName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiNamespaceId">The <c>ApiNamespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mcpServerId">The <c>McpServer</c> ID. Must not be <c>null</c> or empty.</param>
        public McpServerName(string projectId, string locationId, string apiNamespaceId, string mcpServerId) : this(ResourceNameType.ProjectLocationApiNamespaceMcpServer, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiNamespaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiNamespaceId, nameof(apiNamespaceId)), mcpServerId: gax::GaxPreconditions.CheckNotNullOrEmpty(mcpServerId, nameof(mcpServerId)))
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
        /// The <c>ApiNamespace</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ApiNamespaceId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>McpServer</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string McpServerId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.ProjectLocationApiNamespaceMcpServer: return s_projectLocationApiNamespaceMcpServer.Expand(ProjectId, LocationId, ApiNamespaceId, McpServerId);
                case ResourceNameType.ProjectLocationMcpServer: return s_projectLocationMcpServer.Expand(ProjectId, LocationId, McpServerId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as McpServerName);

        /// <inheritdoc/>
        public bool Equals(McpServerName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(McpServerName a, McpServerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(McpServerName a, McpServerName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>McpTool</c> resource.</summary>
    public sealed partial class McpToolName : gax::IResourceName, sys::IEquatable<McpToolName>
    {
        /// <summary>The possible contents of <see cref="McpToolName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>
            /// .
            /// </summary>
            ProjectLocationApiNamespaceMcpServerMcpTool = 1,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>.
            /// </summary>
            ProjectLocationMcpServerMcpTool = 2,
        }

        private static gax::PathTemplate s_projectLocationApiNamespaceMcpServerMcpTool = new gax::PathTemplate("projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}");

        private static gax::PathTemplate s_projectLocationMcpServerMcpTool = new gax::PathTemplate("projects/{project}/locations/{location}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}");

        /// <summary>Creates a <see cref="McpToolName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="McpToolName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static McpToolName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new McpToolName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="McpToolName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiNamespaceId">The <c>ApiNamespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mcpServerId">The <c>McpServer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mcpToolId">The <c>McpTool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="McpToolName"/> constructed from the provided ids.</returns>
        public static McpToolName FromProjectLocationApiNamespaceMcpServerMcpTool(string projectId, string locationId, string apiNamespaceId, string mcpServerId, string mcpToolId) =>
            new McpToolName(ResourceNameType.ProjectLocationApiNamespaceMcpServerMcpTool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiNamespaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiNamespaceId, nameof(apiNamespaceId)), mcpServerId: gax::GaxPreconditions.CheckNotNullOrEmpty(mcpServerId, nameof(mcpServerId)), mcpToolId: gax::GaxPreconditions.CheckNotNullOrEmpty(mcpToolId, nameof(mcpToolId)));

        /// <summary>
        /// Creates a <see cref="McpToolName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mcpServerId">The <c>McpServer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mcpToolId">The <c>McpTool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="McpToolName"/> constructed from the provided ids.</returns>
        public static McpToolName FromProjectLocationMcpServerMcpTool(string projectId, string locationId, string mcpServerId, string mcpToolId) =>
            new McpToolName(ResourceNameType.ProjectLocationMcpServerMcpTool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), mcpServerId: gax::GaxPreconditions.CheckNotNullOrEmpty(mcpServerId, nameof(mcpServerId)), mcpToolId: gax::GaxPreconditions.CheckNotNullOrEmpty(mcpToolId, nameof(mcpToolId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="McpToolName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiNamespaceId">The <c>ApiNamespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mcpServerId">The <c>McpServer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mcpToolId">The <c>McpTool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="McpToolName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string apiNamespaceId, string mcpServerId, string mcpToolId) =>
            FormatProjectLocationApiNamespaceMcpServerMcpTool(projectId, locationId, apiNamespaceId, mcpServerId, mcpToolId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="McpToolName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiNamespaceId">The <c>ApiNamespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mcpServerId">The <c>McpServer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mcpToolId">The <c>McpTool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="McpToolName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationApiNamespaceMcpServerMcpTool(string projectId, string locationId, string apiNamespaceId, string mcpServerId, string mcpToolId) =>
            s_projectLocationApiNamespaceMcpServerMcpTool.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(apiNamespaceId, nameof(apiNamespaceId)), gax::GaxPreconditions.CheckNotNullOrEmpty(mcpServerId, nameof(mcpServerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(mcpToolId, nameof(mcpToolId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="McpToolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mcpServerId">The <c>McpServer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mcpToolId">The <c>McpTool</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="McpToolName"/> with pattern
        /// <c>projects/{project}/locations/{location}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>.
        /// </returns>
        public static string FormatProjectLocationMcpServerMcpTool(string projectId, string locationId, string mcpServerId, string mcpToolId) =>
            s_projectLocationMcpServerMcpTool.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(mcpServerId, nameof(mcpServerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(mcpToolId, nameof(mcpToolId)));

        /// <summary>Parses the given resource name string into a new <see cref="McpToolName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="mcpToolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="McpToolName"/> if successful.</returns>
        public static McpToolName Parse(string mcpToolName) => Parse(mcpToolName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="McpToolName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mcpToolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="McpToolName"/> if successful.</returns>
        public static McpToolName Parse(string mcpToolName, bool allowUnparsed) =>
            TryParse(mcpToolName, allowUnparsed, out McpToolName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="McpToolName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="mcpToolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="McpToolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mcpToolName, out McpToolName result) => TryParse(mcpToolName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="McpToolName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>
        /// </description>
        /// </item>
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mcpToolName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="McpToolName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mcpToolName, bool allowUnparsed, out McpToolName result)
        {
            gax::GaxPreconditions.CheckNotNull(mcpToolName, nameof(mcpToolName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationApiNamespaceMcpServerMcpTool.TryParseName(mcpToolName, out resourceName))
            {
                result = FromProjectLocationApiNamespaceMcpServerMcpTool(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (s_projectLocationMcpServerMcpTool.TryParseName(mcpToolName, out resourceName))
            {
                result = FromProjectLocationMcpServerMcpTool(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(mcpToolName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private McpToolName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string apiNamespaceId = null, string locationId = null, string mcpServerId = null, string mcpToolId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ApiNamespaceId = apiNamespaceId;
            LocationId = locationId;
            McpServerId = mcpServerId;
            McpToolId = mcpToolId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="McpToolName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/apiNamespaces/{api_namespace}/mcpServers/{mcp_server}/mcpTools/{mcp_tool}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="apiNamespaceId">The <c>ApiNamespace</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mcpServerId">The <c>McpServer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mcpToolId">The <c>McpTool</c> ID. Must not be <c>null</c> or empty.</param>
        public McpToolName(string projectId, string locationId, string apiNamespaceId, string mcpServerId, string mcpToolId) : this(ResourceNameType.ProjectLocationApiNamespaceMcpServerMcpTool, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), apiNamespaceId: gax::GaxPreconditions.CheckNotNullOrEmpty(apiNamespaceId, nameof(apiNamespaceId)), mcpServerId: gax::GaxPreconditions.CheckNotNullOrEmpty(mcpServerId, nameof(mcpServerId)), mcpToolId: gax::GaxPreconditions.CheckNotNullOrEmpty(mcpToolId, nameof(mcpToolId)))
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
        /// The <c>ApiNamespace</c> ID. May be <c>null</c>, depending on which resource name is contained by this
        /// instance.
        /// </summary>
        public string ApiNamespaceId { get; }

        /// <summary>
        /// The <c>Location</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>McpServer</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string McpServerId { get; }

        /// <summary>
        /// The <c>McpTool</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
        /// </summary>
        public string McpToolId { get; }

        /// <summary>
        /// The <c>Project</c> ID. May be <c>null</c>, depending on which resource name is contained by this instance.
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
                case ResourceNameType.ProjectLocationApiNamespaceMcpServerMcpTool: return s_projectLocationApiNamespaceMcpServerMcpTool.Expand(ProjectId, LocationId, ApiNamespaceId, McpServerId, McpToolId);
                case ResourceNameType.ProjectLocationMcpServerMcpTool: return s_projectLocationMcpServerMcpTool.Expand(ProjectId, LocationId, McpServerId, McpToolId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as McpToolName);

        /// <inheritdoc/>
        public bool Equals(McpToolName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(McpToolName a, McpToolName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(McpToolName a, McpToolName b) => !(a == b);
    }

    public partial class McpServer
    {
        /// <summary>
        /// <see cref="gcav::McpServerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::McpServerName McpServerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::McpServerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class McpTool
    {
        /// <summary>
        /// <see cref="gcav::McpToolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::McpToolName McpToolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::McpToolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
