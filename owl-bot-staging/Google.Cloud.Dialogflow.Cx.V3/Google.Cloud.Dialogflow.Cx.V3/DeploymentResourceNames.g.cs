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
using gcdcv = Google.Cloud.Dialogflow.Cx.V3;
using sys = System;

namespace Google.Cloud.Dialogflow.Cx.V3
{
    /// <summary>Resource name for the <c>Deployment</c> resource.</summary>
    public sealed partial class DeploymentName : gax::IResourceName, sys::IEquatable<DeploymentName>
    {
        /// <summary>The possible contents of <see cref="DeploymentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/deployments/{deployment}</c>
            /// .
            /// </summary>
            ProjectLocationAgentEnvironmentDeployment = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentEnvironmentDeployment = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/deployments/{deployment}");

        /// <summary>Creates a <see cref="DeploymentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DeploymentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DeploymentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DeploymentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DeploymentName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/deployments/{deployment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DeploymentName"/> constructed from the provided ids.</returns>
        public static DeploymentName FromProjectLocationAgentEnvironmentDeployment(string projectId, string locationId, string agentId, string environmentId, string deploymentId) =>
            new DeploymentName(ResourceNameType.ProjectLocationAgentEnvironmentDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/deployments/{deployment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/deployments/{deployment}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId, string environmentId, string deploymentId) =>
            FormatProjectLocationAgentEnvironmentDeployment(projectId, locationId, agentId, environmentId, deploymentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/deployments/{deployment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DeploymentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/deployments/{deployment}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationAgentEnvironmentDeployment(string projectId, string locationId, string agentId, string environmentId, string deploymentId) =>
            s_projectLocationAgentEnvironmentDeployment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)));

        /// <summary>Parses the given resource name string into a new <see cref="DeploymentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/deployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="deploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DeploymentName"/> if successful.</returns>
        public static DeploymentName Parse(string deploymentName) => Parse(deploymentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DeploymentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/deployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DeploymentName"/> if successful.</returns>
        public static DeploymentName Parse(string deploymentName, bool allowUnparsed) =>
            TryParse(deploymentName, allowUnparsed, out DeploymentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeploymentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/deployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="deploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeploymentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deploymentName, out DeploymentName result) =>
            TryParse(deploymentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DeploymentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/deployments/{deployment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="deploymentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DeploymentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string deploymentName, bool allowUnparsed, out DeploymentName result)
        {
            gax::GaxPreconditions.CheckNotNull(deploymentName, nameof(deploymentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentEnvironmentDeployment.TryParseName(deploymentName, out resourceName))
            {
                result = FromProjectLocationAgentEnvironmentDeployment(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(deploymentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DeploymentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string deploymentId = null, string environmentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            DeploymentId = deploymentId;
            EnvironmentId = environmentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DeploymentName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/deployments/{deployment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="deploymentId">The <c>Deployment</c> ID. Must not be <c>null</c> or empty.</param>
        public DeploymentName(string projectId, string locationId, string agentId, string environmentId, string deploymentId) : this(ResourceNameType.ProjectLocationAgentEnvironmentDeployment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), deploymentId: gax::GaxPreconditions.CheckNotNullOrEmpty(deploymentId, nameof(deploymentId)))
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
        /// The <c>Deployment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DeploymentId { get; }

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
                case ResourceNameType.ProjectLocationAgentEnvironmentDeployment: return s_projectLocationAgentEnvironmentDeployment.Expand(ProjectId, LocationId, AgentId, EnvironmentId, DeploymentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DeploymentName);

        /// <inheritdoc/>
        public bool Equals(DeploymentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DeploymentName a, DeploymentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DeploymentName a, DeploymentName b) => !(a == b);
    }

    public partial class Deployment
    {
        /// <summary>
        /// <see cref="gcdcv::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VersionName"/>-typed view over the <see cref="FlowVersion"/> resource name property.
        /// </summary>
        public VersionName FlowVersionAsVersionName
        {
            get => string.IsNullOrEmpty(FlowVersion) ? null : VersionName.Parse(FlowVersion, allowUnparsed: true);
            set => FlowVersion = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class Result
            {
                /// <summary>
                /// <see cref="TestCaseResultName"/>-typed view over the <see cref="DeploymentTestResults"/> resource
                /// name property.
                /// </summary>
                public gax::ResourceNameList<TestCaseResultName> DeploymentTestResultsAsTestCaseResultNames
                {
                    get => new gax::ResourceNameList<TestCaseResultName>(DeploymentTestResults, s => string.IsNullOrEmpty(s) ? null : TestCaseResultName.Parse(s, allowUnparsed: true));
                }

                /// <summary>
                /// <see cref="ExperimentName"/>-typed view over the <see cref="Experiment"/> resource name property.
                /// </summary>
                public ExperimentName ExperimentAsExperimentName
                {
                    get => string.IsNullOrEmpty(Experiment) ? null : ExperimentName.Parse(Experiment, allowUnparsed: true);
                    set => Experiment = value?.ToString() ?? "";
                }
            }
        }
    }

    public partial class ListDeploymentsRequest
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

    public partial class GetDeploymentRequest
    {
        /// <summary>
        /// <see cref="gcdcv::DeploymentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::DeploymentName DeploymentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::DeploymentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
