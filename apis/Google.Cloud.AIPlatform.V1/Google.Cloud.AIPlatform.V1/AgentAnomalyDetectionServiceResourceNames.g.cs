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
using gagr = Google.Api.Gax.ResourceNames;
using gax = Google.Api.Gax;
using gcav = Google.Cloud.AIPlatform.V1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Resource name for the <c>AgentAnomalyDetectionScope</c> resource.</summary>
    public sealed partial class AgentAnomalyDetectionScopeName : gax::IResourceName, sys::IEquatable<AgentAnomalyDetectionScopeName>
    {
        /// <summary>The possible contents of <see cref="AgentAnomalyDetectionScopeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}</c>
            /// .
            /// </summary>
            ProjectLocationAgentAnomalyDetectionScope = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentAnomalyDetectionScope = new gax::PathTemplate("projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}");

        /// <summary>
        /// Creates a <see cref="AgentAnomalyDetectionScopeName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AgentAnomalyDetectionScopeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AgentAnomalyDetectionScopeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AgentAnomalyDetectionScopeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AgentAnomalyDetectionScopeName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentAnomalyDetectionScopeId">
        /// The <c>AgentAnomalyDetectionScope</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="AgentAnomalyDetectionScopeName"/> constructed from the provided ids.
        /// </returns>
        public static AgentAnomalyDetectionScopeName FromProjectLocationAgentAnomalyDetectionScope(string projectId, string locationId, string agentAnomalyDetectionScopeId) =>
            new AgentAnomalyDetectionScopeName(ResourceNameType.ProjectLocationAgentAnomalyDetectionScope, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentAnomalyDetectionScopeId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentAnomalyDetectionScopeId, nameof(agentAnomalyDetectionScopeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AgentAnomalyDetectionScopeName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentAnomalyDetectionScopeId">
        /// The <c>AgentAnomalyDetectionScope</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AgentAnomalyDetectionScopeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentAnomalyDetectionScopeId) =>
            FormatProjectLocationAgentAnomalyDetectionScope(projectId, locationId, agentAnomalyDetectionScopeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AgentAnomalyDetectionScopeName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentAnomalyDetectionScopeId">
        /// The <c>AgentAnomalyDetectionScope</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AgentAnomalyDetectionScopeName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}</c>.
        /// </returns>
        public static string FormatProjectLocationAgentAnomalyDetectionScope(string projectId, string locationId, string agentAnomalyDetectionScopeId) =>
            s_projectLocationAgentAnomalyDetectionScope.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentAnomalyDetectionScopeId, nameof(agentAnomalyDetectionScopeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AgentAnomalyDetectionScopeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="agentAnomalyDetectionScopeName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="AgentAnomalyDetectionScopeName"/> if successful.</returns>
        public static AgentAnomalyDetectionScopeName Parse(string agentAnomalyDetectionScopeName) =>
            Parse(agentAnomalyDetectionScopeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AgentAnomalyDetectionScopeName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="agentAnomalyDetectionScopeName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AgentAnomalyDetectionScopeName"/> if successful.</returns>
        public static AgentAnomalyDetectionScopeName Parse(string agentAnomalyDetectionScopeName, bool allowUnparsed) =>
            TryParse(agentAnomalyDetectionScopeName, allowUnparsed, out AgentAnomalyDetectionScopeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AgentAnomalyDetectionScopeName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="agentAnomalyDetectionScopeName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AgentAnomalyDetectionScopeName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string agentAnomalyDetectionScopeName, out AgentAnomalyDetectionScopeName result) =>
            TryParse(agentAnomalyDetectionScopeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AgentAnomalyDetectionScopeName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="agentAnomalyDetectionScopeName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AgentAnomalyDetectionScopeName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string agentAnomalyDetectionScopeName, bool allowUnparsed, out AgentAnomalyDetectionScopeName result)
        {
            gax::GaxPreconditions.CheckNotNull(agentAnomalyDetectionScopeName, nameof(agentAnomalyDetectionScopeName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentAnomalyDetectionScope.TryParseName(agentAnomalyDetectionScopeName, out resourceName))
            {
                result = FromProjectLocationAgentAnomalyDetectionScope(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(agentAnomalyDetectionScopeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AgentAnomalyDetectionScopeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentAnomalyDetectionScopeId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentAnomalyDetectionScopeId = agentAnomalyDetectionScopeId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AgentAnomalyDetectionScopeName"/> class from the component parts
        /// of pattern
        /// <c>projects/{project}/locations/{location}/agentAnomalyDetectionScopes/{agent_anomaly_detection_scope}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentAnomalyDetectionScopeId">
        /// The <c>AgentAnomalyDetectionScope</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public AgentAnomalyDetectionScopeName(string projectId, string locationId, string agentAnomalyDetectionScopeId) : this(ResourceNameType.ProjectLocationAgentAnomalyDetectionScope, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentAnomalyDetectionScopeId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentAnomalyDetectionScopeId, nameof(agentAnomalyDetectionScopeId)))
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
        /// The <c>AgentAnomalyDetectionScope</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string AgentAnomalyDetectionScopeId { get; }

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
                case ResourceNameType.ProjectLocationAgentAnomalyDetectionScope: return s_projectLocationAgentAnomalyDetectionScope.Expand(ProjectId, LocationId, AgentAnomalyDetectionScopeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AgentAnomalyDetectionScopeName);

        /// <inheritdoc/>
        public bool Equals(AgentAnomalyDetectionScopeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AgentAnomalyDetectionScopeName a, AgentAnomalyDetectionScopeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AgentAnomalyDetectionScopeName a, AgentAnomalyDetectionScopeName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>MonitoredAgent</c> resource.</summary>
    public sealed partial class MonitoredAgentName : gax::IResourceName, sys::IEquatable<MonitoredAgentName>
    {
        /// <summary>The possible contents of <see cref="MonitoredAgentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}</c>.
            /// </summary>
            ProjectLocationMonitoredAgent = 1,
        }

        private static gax::PathTemplate s_projectLocationMonitoredAgent = new gax::PathTemplate("projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}");

        /// <summary>Creates a <see cref="MonitoredAgentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MonitoredAgentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MonitoredAgentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MonitoredAgentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MonitoredAgentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredAgentId">The <c>MonitoredAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MonitoredAgentName"/> constructed from the provided ids.</returns>
        public static MonitoredAgentName FromProjectLocationMonitoredAgent(string projectId, string locationId, string monitoredAgentId) =>
            new MonitoredAgentName(ResourceNameType.ProjectLocationMonitoredAgent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), monitoredAgentId: gax::GaxPreconditions.CheckNotNullOrEmpty(monitoredAgentId, nameof(monitoredAgentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MonitoredAgentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredAgentId">The <c>MonitoredAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MonitoredAgentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string monitoredAgentId) =>
            FormatProjectLocationMonitoredAgent(projectId, locationId, monitoredAgentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MonitoredAgentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredAgentId">The <c>MonitoredAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MonitoredAgentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}</c>.
        /// </returns>
        public static string FormatProjectLocationMonitoredAgent(string projectId, string locationId, string monitoredAgentId) =>
            s_projectLocationMonitoredAgent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(monitoredAgentId, nameof(monitoredAgentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MonitoredAgentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="monitoredAgentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MonitoredAgentName"/> if successful.</returns>
        public static MonitoredAgentName Parse(string monitoredAgentName) => Parse(monitoredAgentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MonitoredAgentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="monitoredAgentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MonitoredAgentName"/> if successful.</returns>
        public static MonitoredAgentName Parse(string monitoredAgentName, bool allowUnparsed) =>
            TryParse(monitoredAgentName, allowUnparsed, out MonitoredAgentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MonitoredAgentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="monitoredAgentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MonitoredAgentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string monitoredAgentName, out MonitoredAgentName result) =>
            TryParse(monitoredAgentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MonitoredAgentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="monitoredAgentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MonitoredAgentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string monitoredAgentName, bool allowUnparsed, out MonitoredAgentName result)
        {
            gax::GaxPreconditions.CheckNotNull(monitoredAgentName, nameof(monitoredAgentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMonitoredAgent.TryParseName(monitoredAgentName, out resourceName))
            {
                result = FromProjectLocationMonitoredAgent(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(monitoredAgentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MonitoredAgentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string monitoredAgentId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            MonitoredAgentId = monitoredAgentId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MonitoredAgentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredAgentId">The <c>MonitoredAgent</c> ID. Must not be <c>null</c> or empty.</param>
        public MonitoredAgentName(string projectId, string locationId, string monitoredAgentId) : this(ResourceNameType.ProjectLocationMonitoredAgent, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), monitoredAgentId: gax::GaxPreconditions.CheckNotNullOrEmpty(monitoredAgentId, nameof(monitoredAgentId)))
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
        /// The <c>MonitoredAgent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string MonitoredAgentId { get; }

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
                case ResourceNameType.ProjectLocationMonitoredAgent: return s_projectLocationMonitoredAgent.Expand(ProjectId, LocationId, MonitoredAgentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MonitoredAgentName);

        /// <inheritdoc/>
        public bool Equals(MonitoredAgentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MonitoredAgentName a, MonitoredAgentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MonitoredAgentName a, MonitoredAgentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AnalyzedSession</c> resource.</summary>
    public sealed partial class AnalyzedSessionName : gax::IResourceName, sys::IEquatable<AnalyzedSessionName>
    {
        /// <summary>The possible contents of <see cref="AnalyzedSessionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}</c>
            /// .
            /// </summary>
            ProjectLocationMonitoredAgentAnalyzedSession = 1,
        }

        private static gax::PathTemplate s_projectLocationMonitoredAgentAnalyzedSession = new gax::PathTemplate("projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}");

        /// <summary>Creates a <see cref="AnalyzedSessionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AnalyzedSessionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AnalyzedSessionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AnalyzedSessionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AnalyzedSessionName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredAgentId">The <c>MonitoredAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analyzedSessionId">The <c>AnalyzedSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AnalyzedSessionName"/> constructed from the provided ids.</returns>
        public static AnalyzedSessionName FromProjectLocationMonitoredAgentAnalyzedSession(string projectId, string locationId, string monitoredAgentId, string analyzedSessionId) =>
            new AnalyzedSessionName(ResourceNameType.ProjectLocationMonitoredAgentAnalyzedSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), monitoredAgentId: gax::GaxPreconditions.CheckNotNullOrEmpty(monitoredAgentId, nameof(monitoredAgentId)), analyzedSessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(analyzedSessionId, nameof(analyzedSessionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnalyzedSessionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredAgentId">The <c>MonitoredAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analyzedSessionId">The <c>AnalyzedSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnalyzedSessionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string monitoredAgentId, string analyzedSessionId) =>
            FormatProjectLocationMonitoredAgentAnalyzedSession(projectId, locationId, monitoredAgentId, analyzedSessionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnalyzedSessionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredAgentId">The <c>MonitoredAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analyzedSessionId">The <c>AnalyzedSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AnalyzedSessionName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationMonitoredAgentAnalyzedSession(string projectId, string locationId, string monitoredAgentId, string analyzedSessionId) =>
            s_projectLocationMonitoredAgentAnalyzedSession.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(monitoredAgentId, nameof(monitoredAgentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(analyzedSessionId, nameof(analyzedSessionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnalyzedSessionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="analyzedSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AnalyzedSessionName"/> if successful.</returns>
        public static AnalyzedSessionName Parse(string analyzedSessionName) => Parse(analyzedSessionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnalyzedSessionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="analyzedSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AnalyzedSessionName"/> if successful.</returns>
        public static AnalyzedSessionName Parse(string analyzedSessionName, bool allowUnparsed) =>
            TryParse(analyzedSessionName, allowUnparsed, out AnalyzedSessionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnalyzedSessionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="analyzedSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnalyzedSessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string analyzedSessionName, out AnalyzedSessionName result) =>
            TryParse(analyzedSessionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnalyzedSessionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="analyzedSessionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnalyzedSessionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string analyzedSessionName, bool allowUnparsed, out AnalyzedSessionName result)
        {
            gax::GaxPreconditions.CheckNotNull(analyzedSessionName, nameof(analyzedSessionName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMonitoredAgentAnalyzedSession.TryParseName(analyzedSessionName, out resourceName))
            {
                result = FromProjectLocationMonitoredAgentAnalyzedSession(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(analyzedSessionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AnalyzedSessionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string analyzedSessionId = null, string locationId = null, string monitoredAgentId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AnalyzedSessionId = analyzedSessionId;
            LocationId = locationId;
            MonitoredAgentId = monitoredAgentId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AnalyzedSessionName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredAgentId">The <c>MonitoredAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analyzedSessionId">The <c>AnalyzedSession</c> ID. Must not be <c>null</c> or empty.</param>
        public AnalyzedSessionName(string projectId, string locationId, string monitoredAgentId, string analyzedSessionId) : this(ResourceNameType.ProjectLocationMonitoredAgentAnalyzedSession, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), monitoredAgentId: gax::GaxPreconditions.CheckNotNullOrEmpty(monitoredAgentId, nameof(monitoredAgentId)), analyzedSessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(analyzedSessionId, nameof(analyzedSessionId)))
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
        /// The <c>AnalyzedSession</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AnalyzedSessionId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>MonitoredAgent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string MonitoredAgentId { get; }

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
                case ResourceNameType.ProjectLocationMonitoredAgentAnalyzedSession: return s_projectLocationMonitoredAgentAnalyzedSession.Expand(ProjectId, LocationId, MonitoredAgentId, AnalyzedSessionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AnalyzedSessionName);

        /// <inheritdoc/>
        public bool Equals(AnalyzedSessionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AnalyzedSessionName a, AnalyzedSessionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AnalyzedSessionName a, AnalyzedSessionName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>AnalyzedInvocation</c> resource.</summary>
    public sealed partial class AnalyzedInvocationName : gax::IResourceName, sys::IEquatable<AnalyzedInvocationName>
    {
        /// <summary>The possible contents of <see cref="AnalyzedInvocationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}/analyzedInvocations/{analyzed_invocation}</c>
            /// .
            /// </summary>
            ProjectLocationMonitoredAgentAnalyzedSessionAnalyzedInvocation = 1,
        }

        private static gax::PathTemplate s_projectLocationMonitoredAgentAnalyzedSessionAnalyzedInvocation = new gax::PathTemplate("projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}/analyzedInvocations/{analyzed_invocation}");

        /// <summary>Creates a <see cref="AnalyzedInvocationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AnalyzedInvocationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AnalyzedInvocationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AnalyzedInvocationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AnalyzedInvocationName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}/analyzedInvocations/{analyzed_invocation}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredAgentId">The <c>MonitoredAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analyzedSessionId">The <c>AnalyzedSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analyzedInvocationId">
        /// The <c>AnalyzedInvocation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="AnalyzedInvocationName"/> constructed from the provided ids.</returns>
        public static AnalyzedInvocationName FromProjectLocationMonitoredAgentAnalyzedSessionAnalyzedInvocation(string projectId, string locationId, string monitoredAgentId, string analyzedSessionId, string analyzedInvocationId) =>
            new AnalyzedInvocationName(ResourceNameType.ProjectLocationMonitoredAgentAnalyzedSessionAnalyzedInvocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), monitoredAgentId: gax::GaxPreconditions.CheckNotNullOrEmpty(monitoredAgentId, nameof(monitoredAgentId)), analyzedSessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(analyzedSessionId, nameof(analyzedSessionId)), analyzedInvocationId: gax::GaxPreconditions.CheckNotNullOrEmpty(analyzedInvocationId, nameof(analyzedInvocationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnalyzedInvocationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}/analyzedInvocations/{analyzed_invocation}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredAgentId">The <c>MonitoredAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analyzedSessionId">The <c>AnalyzedSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analyzedInvocationId">
        /// The <c>AnalyzedInvocation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AnalyzedInvocationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}/analyzedInvocations/{analyzed_invocation}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string monitoredAgentId, string analyzedSessionId, string analyzedInvocationId) =>
            FormatProjectLocationMonitoredAgentAnalyzedSessionAnalyzedInvocation(projectId, locationId, monitoredAgentId, analyzedSessionId, analyzedInvocationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AnalyzedInvocationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}/analyzedInvocations/{analyzed_invocation}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredAgentId">The <c>MonitoredAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analyzedSessionId">The <c>AnalyzedSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analyzedInvocationId">
        /// The <c>AnalyzedInvocation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AnalyzedInvocationName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}/analyzedInvocations/{analyzed_invocation}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationMonitoredAgentAnalyzedSessionAnalyzedInvocation(string projectId, string locationId, string monitoredAgentId, string analyzedSessionId, string analyzedInvocationId) =>
            s_projectLocationMonitoredAgentAnalyzedSessionAnalyzedInvocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(monitoredAgentId, nameof(monitoredAgentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(analyzedSessionId, nameof(analyzedSessionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(analyzedInvocationId, nameof(analyzedInvocationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnalyzedInvocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}/analyzedInvocations/{analyzed_invocation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="analyzedInvocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AnalyzedInvocationName"/> if successful.</returns>
        public static AnalyzedInvocationName Parse(string analyzedInvocationName) => Parse(analyzedInvocationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AnalyzedInvocationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}/analyzedInvocations/{analyzed_invocation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="analyzedInvocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AnalyzedInvocationName"/> if successful.</returns>
        public static AnalyzedInvocationName Parse(string analyzedInvocationName, bool allowUnparsed) =>
            TryParse(analyzedInvocationName, allowUnparsed, out AnalyzedInvocationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnalyzedInvocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}/analyzedInvocations/{analyzed_invocation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="analyzedInvocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnalyzedInvocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string analyzedInvocationName, out AnalyzedInvocationName result) =>
            TryParse(analyzedInvocationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AnalyzedInvocationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}/analyzedInvocations/{analyzed_invocation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="analyzedInvocationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AnalyzedInvocationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string analyzedInvocationName, bool allowUnparsed, out AnalyzedInvocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(analyzedInvocationName, nameof(analyzedInvocationName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationMonitoredAgentAnalyzedSessionAnalyzedInvocation.TryParseName(analyzedInvocationName, out resourceName))
            {
                result = FromProjectLocationMonitoredAgentAnalyzedSessionAnalyzedInvocation(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(analyzedInvocationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AnalyzedInvocationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string analyzedInvocationId = null, string analyzedSessionId = null, string locationId = null, string monitoredAgentId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AnalyzedInvocationId = analyzedInvocationId;
            AnalyzedSessionId = analyzedSessionId;
            LocationId = locationId;
            MonitoredAgentId = monitoredAgentId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AnalyzedInvocationName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/monitoredAgents/{monitored_agent}/analyzedSessions/{analyzed_session}/analyzedInvocations/{analyzed_invocation}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="monitoredAgentId">The <c>MonitoredAgent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analyzedSessionId">The <c>AnalyzedSession</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="analyzedInvocationId">
        /// The <c>AnalyzedInvocation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public AnalyzedInvocationName(string projectId, string locationId, string monitoredAgentId, string analyzedSessionId, string analyzedInvocationId) : this(ResourceNameType.ProjectLocationMonitoredAgentAnalyzedSessionAnalyzedInvocation, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), monitoredAgentId: gax::GaxPreconditions.CheckNotNullOrEmpty(monitoredAgentId, nameof(monitoredAgentId)), analyzedSessionId: gax::GaxPreconditions.CheckNotNullOrEmpty(analyzedSessionId, nameof(analyzedSessionId)), analyzedInvocationId: gax::GaxPreconditions.CheckNotNullOrEmpty(analyzedInvocationId, nameof(analyzedInvocationId)))
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
        /// The <c>AnalyzedInvocation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string AnalyzedInvocationId { get; }

        /// <summary>
        /// The <c>AnalyzedSession</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AnalyzedSessionId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>MonitoredAgent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string MonitoredAgentId { get; }

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
                case ResourceNameType.ProjectLocationMonitoredAgentAnalyzedSessionAnalyzedInvocation: return s_projectLocationMonitoredAgentAnalyzedSessionAnalyzedInvocation.Expand(ProjectId, LocationId, MonitoredAgentId, AnalyzedSessionId, AnalyzedInvocationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AnalyzedInvocationName);

        /// <inheritdoc/>
        public bool Equals(AnalyzedInvocationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AnalyzedInvocationName a, AnalyzedInvocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AnalyzedInvocationName a, AnalyzedInvocationName b) => !(a == b);
    }

    public partial class AgentAnomalyDetectionScope
    {
        /// <summary>
        /// <see cref="gcav::AgentAnomalyDetectionScopeName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::AgentAnomalyDetectionScopeName AgentAnomalyDetectionScopeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AgentAnomalyDetectionScopeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MonitoredAgent
    {
        /// <summary>
        /// <see cref="gcav::MonitoredAgentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::MonitoredAgentName MonitoredAgentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::MonitoredAgentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AgentResource
    {
        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="Agent"/> resource name property.
        /// </summary>
        public gax::IResourceName AgentAsResourceName
        {
            get => string.IsNullOrEmpty(Agent) ? null : gax::UnparsedResourceName.Parse(Agent);
            set => Agent = value?.ToString() ?? "";
        }
    }

    public partial class CreateAgentAnomalyDetectionScopeRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAgentAnomalyDetectionScopeRequest
    {
        /// <summary>
        /// <see cref="gcav::AgentAnomalyDetectionScopeName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::AgentAnomalyDetectionScopeName AgentAnomalyDetectionScopeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AgentAnomalyDetectionScopeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAgentAnomalyDetectionScopeRequest
    {
        /// <summary>
        /// <see cref="gcav::AgentAnomalyDetectionScopeName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::AgentAnomalyDetectionScopeName AgentAnomalyDetectionScopeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AgentAnomalyDetectionScopeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAgentAnomalyDetectionScopesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetMonitoredAgentRequest
    {
        /// <summary>
        /// <see cref="gcav::MonitoredAgentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::MonitoredAgentName MonitoredAgentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::MonitoredAgentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMonitoredAgentsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class EnableMonitoredAgentRequest
    {
        /// <summary>
        /// <see cref="gcav::MonitoredAgentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::MonitoredAgentName MonitoredAgentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::MonitoredAgentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DisableMonitoredAgentRequest
    {
        /// <summary>
        /// <see cref="gcav::MonitoredAgentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::MonitoredAgentName MonitoredAgentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::MonitoredAgentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ClearTrainingDataRequest
    {
        /// <summary>
        /// <see cref="gcav::MonitoredAgentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::MonitoredAgentName MonitoredAgentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::MonitoredAgentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AnalyzedSession
    {
        /// <summary>
        /// <see cref="gcav::AnalyzedSessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::AnalyzedSessionName AnalyzedSessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AnalyzedSessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gax::IResourceName"/>-typed view over the <see cref="AgentResourceName"/> resource name property.
        /// </summary>
        public gax::IResourceName AgentResourceNameAsResourceName
        {
            get => string.IsNullOrEmpty(AgentResourceName) ? null : gax::UnparsedResourceName.Parse(AgentResourceName);
            set => AgentResourceName = value?.ToString() ?? "";
        }
    }

    public partial class ListAnalyzedSessionsRequest
    {
        /// <summary>
        /// <see cref="MonitoredAgentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MonitoredAgentName ParentAsMonitoredAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MonitoredAgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAnalyzedSessionRequest
    {
        /// <summary>
        /// <see cref="gcav::AnalyzedSessionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::AnalyzedSessionName AnalyzedSessionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AnalyzedSessionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class AnalyzedInvocation
    {
        /// <summary>
        /// <see cref="gcav::AnalyzedInvocationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::AnalyzedInvocationName AnalyzedInvocationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AnalyzedInvocationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAnalyzedInvocationRequest
    {
        /// <summary>
        /// <see cref="gcav::AnalyzedInvocationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::AnalyzedInvocationName AnalyzedInvocationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AnalyzedInvocationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAnalyzedInvocationsRequest
    {
        /// <summary>
        /// <see cref="AnalyzedSessionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AnalyzedSessionName ParentAsAnalyzedSessionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AnalyzedSessionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AggregateAnalyzedSessionsRequest
    {
        /// <summary>
        /// <see cref="MonitoredAgentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public MonitoredAgentName ParentAsMonitoredAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : MonitoredAgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class AggregateAnalyzedSessionsResponse
    {
        public partial class Types
        {
            public partial class AgentAggregate
            {
                /// <summary>
                /// <see cref="gax::IResourceName"/>-typed view over the <see cref="AgentResourceName"/> resource name
                /// property.
                /// </summary>
                public gax::IResourceName AgentResourceNameAsResourceName
                {
                    get => string.IsNullOrEmpty(AgentResourceName) ? null : gax::UnparsedResourceName.Parse(AgentResourceName);
                    set => AgentResourceName = value?.ToString() ?? "";
                }
            }
        }
    }
}
