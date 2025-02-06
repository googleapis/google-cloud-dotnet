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
using gcdcv = Google.Cloud.Dialogflow.Cx.V3;
using sys = System;

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Resource name for the <c>Environment</c> resource.</summary>
    public sealed partial class EnvironmentName : gax::IResourceName, sys::IEquatable<EnvironmentName>
    {
        /// <summary>The possible contents of <see cref="EnvironmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}</c>.
            /// </summary>
            ProjectLocationAgentEnvironment = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentEnvironment = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/environments/{environment}");

        /// <summary>Creates a <see cref="EnvironmentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="EnvironmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static EnvironmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new EnvironmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="EnvironmentName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="EnvironmentName"/> constructed from the provided ids.</returns>
        public static EnvironmentName FromProjectLocationAgentEnvironment(string projectId, string locationId, string agentId, string environmentId) =>
            new EnvironmentName(ResourceNameType.ProjectLocationAgentEnvironment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnvironmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnvironmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId, string environmentId) =>
            FormatProjectLocationAgentEnvironment(projectId, locationId, agentId, environmentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="EnvironmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="EnvironmentName"/> with pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}</c>.
        /// </returns>
        public static string FormatProjectLocationAgentEnvironment(string projectId, string locationId, string agentId, string environmentId) =>
            s_projectLocationAgentEnvironment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)));

        /// <summary>Parses the given resource name string into a new <see cref="EnvironmentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="environmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="EnvironmentName"/> if successful.</returns>
        public static EnvironmentName Parse(string environmentName) => Parse(environmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="EnvironmentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="environmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="EnvironmentName"/> if successful.</returns>
        public static EnvironmentName Parse(string environmentName, bool allowUnparsed) =>
            TryParse(environmentName, allowUnparsed, out EnvironmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EnvironmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="environmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EnvironmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string environmentName, out EnvironmentName result) =>
            TryParse(environmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="EnvironmentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="environmentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="EnvironmentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string environmentName, bool allowUnparsed, out EnvironmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(environmentName, nameof(environmentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentEnvironment.TryParseName(environmentName, out resourceName))
            {
                result = FromProjectLocationAgentEnvironment(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(environmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private EnvironmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string environmentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            EnvironmentId = environmentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="EnvironmentName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/agents/{agent}/environments/{environment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        public EnvironmentName(string projectId, string locationId, string agentId, string environmentId) : this(ResourceNameType.ProjectLocationAgentEnvironment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)))
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
        /// The <c>Environment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EnvironmentId { get; }

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
                case ResourceNameType.ProjectLocationAgentEnvironment: return s_projectLocationAgentEnvironment.Expand(ProjectId, LocationId, AgentId, EnvironmentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as EnvironmentName);

        /// <inheritdoc/>
        public bool Equals(EnvironmentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(EnvironmentName a, EnvironmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(EnvironmentName a, EnvironmentName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>ContinuousTestResult</c> resource.</summary>
    public sealed partial class ContinuousTestResultName : gax::IResourceName, sys::IEquatable<ContinuousTestResultName>
    {
        /// <summary>The possible contents of <see cref="ContinuousTestResultName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/continuousTestResults/{continuous_test_result}</c>
            /// .
            /// </summary>
            ProjectLocationAgentEnvironmentContinuousTestResult = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentEnvironmentContinuousTestResult = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/continuousTestResults/{continuous_test_result}");

        /// <summary>Creates a <see cref="ContinuousTestResultName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ContinuousTestResultName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ContinuousTestResultName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ContinuousTestResultName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ContinuousTestResultName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/continuousTestResults/{continuous_test_result}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="continuousTestResultId">
        /// The <c>ContinuousTestResult</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ContinuousTestResultName"/> constructed from the provided ids.
        /// </returns>
        public static ContinuousTestResultName FromProjectLocationAgentEnvironmentContinuousTestResult(string projectId, string locationId, string agentId, string environmentId, string continuousTestResultId) =>
            new ContinuousTestResultName(ResourceNameType.ProjectLocationAgentEnvironmentContinuousTestResult, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), continuousTestResultId: gax::GaxPreconditions.CheckNotNullOrEmpty(continuousTestResultId, nameof(continuousTestResultId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContinuousTestResultName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/continuousTestResults/{continuous_test_result}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="continuousTestResultId">
        /// The <c>ContinuousTestResult</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ContinuousTestResultName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/continuousTestResults/{continuous_test_result}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId, string environmentId, string continuousTestResultId) =>
            FormatProjectLocationAgentEnvironmentContinuousTestResult(projectId, locationId, agentId, environmentId, continuousTestResultId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ContinuousTestResultName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/continuousTestResults/{continuous_test_result}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="continuousTestResultId">
        /// The <c>ContinuousTestResult</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ContinuousTestResultName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/continuousTestResults/{continuous_test_result}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationAgentEnvironmentContinuousTestResult(string projectId, string locationId, string agentId, string environmentId, string continuousTestResultId) =>
            s_projectLocationAgentEnvironmentContinuousTestResult.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(continuousTestResultId, nameof(continuousTestResultId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ContinuousTestResultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/continuousTestResults/{continuous_test_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="continuousTestResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ContinuousTestResultName"/> if successful.</returns>
        public static ContinuousTestResultName Parse(string continuousTestResultName) =>
            Parse(continuousTestResultName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ContinuousTestResultName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/continuousTestResults/{continuous_test_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="continuousTestResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ContinuousTestResultName"/> if successful.</returns>
        public static ContinuousTestResultName Parse(string continuousTestResultName, bool allowUnparsed) =>
            TryParse(continuousTestResultName, allowUnparsed, out ContinuousTestResultName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ContinuousTestResultName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/continuousTestResults/{continuous_test_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="continuousTestResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ContinuousTestResultName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string continuousTestResultName, out ContinuousTestResultName result) =>
            TryParse(continuousTestResultName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ContinuousTestResultName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/continuousTestResults/{continuous_test_result}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="continuousTestResultName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ContinuousTestResultName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string continuousTestResultName, bool allowUnparsed, out ContinuousTestResultName result)
        {
            gax::GaxPreconditions.CheckNotNull(continuousTestResultName, nameof(continuousTestResultName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentEnvironmentContinuousTestResult.TryParseName(continuousTestResultName, out resourceName))
            {
                result = FromProjectLocationAgentEnvironmentContinuousTestResult(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(continuousTestResultName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ContinuousTestResultName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string continuousTestResultId = null, string environmentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            ContinuousTestResultId = continuousTestResultId;
            EnvironmentId = environmentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ContinuousTestResultName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/continuousTestResults/{continuous_test_result}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="continuousTestResultId">
        /// The <c>ContinuousTestResult</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ContinuousTestResultName(string projectId, string locationId, string agentId, string environmentId, string continuousTestResultId) : this(ResourceNameType.ProjectLocationAgentEnvironmentContinuousTestResult, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), continuousTestResultId: gax::GaxPreconditions.CheckNotNullOrEmpty(continuousTestResultId, nameof(continuousTestResultId)))
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
        /// The <c>ContinuousTestResult</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ContinuousTestResultId { get; }

        /// <summary>
        /// The <c>Environment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EnvironmentId { get; }

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
                case ResourceNameType.ProjectLocationAgentEnvironmentContinuousTestResult: return s_projectLocationAgentEnvironmentContinuousTestResult.Expand(ProjectId, LocationId, AgentId, EnvironmentId, ContinuousTestResultId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ContinuousTestResultName);

        /// <inheritdoc/>
        public bool Equals(ContinuousTestResultName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ContinuousTestResultName a, ContinuousTestResultName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ContinuousTestResultName a, ContinuousTestResultName b) => !(a == b);
    }

    public partial class Environment
    {
        /// <summary>
        /// <see cref="gcdcv::EnvironmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::EnvironmentName EnvironmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::EnvironmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class VersionConfig
            {
                /// <summary>
                /// <see cref="VersionName"/>-typed view over the <see cref="Version"/> resource name property.
                /// </summary>
                public VersionName VersionAsVersionName
                {
                    get => string.IsNullOrEmpty(Version) ? null : VersionName.Parse(Version, allowUnparsed: true);
                    set => Version = value?.ToString() ?? "";
                }
            }

            public partial class TestCasesConfig
            {
                /// <summary>
                /// <see cref="TestCaseName"/>-typed view over the <see cref="TestCases"/> resource name property.
                /// </summary>
                public gax::ResourceNameList<TestCaseName> TestCasesAsTestCaseNames
                {
                    get => new gax::ResourceNameList<TestCaseName>(TestCases, s => string.IsNullOrEmpty(s) ? null : TestCaseName.Parse(s, allowUnparsed: true));
                }
            }
        }
    }

    public partial class ListEnvironmentsRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetEnvironmentRequest
    {
        /// <summary>
        /// <see cref="gcdcv::EnvironmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::EnvironmentName EnvironmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::EnvironmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateEnvironmentRequest
    {
        /// <summary><see cref="AgentName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AgentName ParentAsAgentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AgentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEnvironmentRequest
    {
        /// <summary>
        /// <see cref="gcdcv::EnvironmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::EnvironmentName EnvironmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::EnvironmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class LookupEnvironmentHistoryRequest
    {
        /// <summary>
        /// <see cref="gcdcv::EnvironmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::EnvironmentName EnvironmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::EnvironmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ContinuousTestResult
    {
        /// <summary>
        /// <see cref="gcdcv::ContinuousTestResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::ContinuousTestResultName ContinuousTestResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::ContinuousTestResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="TestCaseResultName"/>-typed view over the <see cref="TestCaseResults"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<TestCaseResultName> TestCaseResultsAsTestCaseResultNames
        {
            get => new gax::ResourceNameList<TestCaseResultName>(TestCaseResults, s => string.IsNullOrEmpty(s) ? null : TestCaseResultName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class RunContinuousTestRequest
    {
        /// <summary>
        /// <see cref="EnvironmentName"/>-typed view over the <see cref="Environment"/> resource name property.
        /// </summary>
        public EnvironmentName EnvironmentAsEnvironmentName
        {
            get => string.IsNullOrEmpty(Environment) ? null : EnvironmentName.Parse(Environment, allowUnparsed: true);
            set => Environment = value?.ToString() ?? "";
        }
    }

    public partial class ListContinuousTestResultsRequest
    {
        /// <summary>
        /// <see cref="EnvironmentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EnvironmentName ParentAsEnvironmentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EnvironmentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeployFlowRequest
    {
        /// <summary>
        /// <see cref="EnvironmentName"/>-typed view over the <see cref="Environment"/> resource name property.
        /// </summary>
        public EnvironmentName EnvironmentAsEnvironmentName
        {
            get => string.IsNullOrEmpty(Environment) ? null : EnvironmentName.Parse(Environment, allowUnparsed: true);
            set => Environment = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VersionName"/>-typed view over the <see cref="FlowVersion"/> resource name property.
        /// </summary>
        public VersionName FlowVersionAsVersionName
        {
            get => string.IsNullOrEmpty(FlowVersion) ? null : VersionName.Parse(FlowVersion, allowUnparsed: true);
            set => FlowVersion = value?.ToString() ?? "";
        }
    }
}
