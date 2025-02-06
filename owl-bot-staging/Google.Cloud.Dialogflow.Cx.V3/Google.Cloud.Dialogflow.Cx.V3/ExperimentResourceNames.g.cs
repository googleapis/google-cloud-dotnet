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
    /// <summary>Resource name for the <c>Experiment</c> resource.</summary>
    public sealed partial class ExperimentName : gax::IResourceName, sys::IEquatable<ExperimentName>
    {
        /// <summary>The possible contents of <see cref="ExperimentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/experiments/{experiment}</c>
            /// .
            /// </summary>
            ProjectLocationAgentEnvironmentExperiment = 1,
        }

        private static gax::PathTemplate s_projectLocationAgentEnvironmentExperiment = new gax::PathTemplate("projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/experiments/{experiment}");

        /// <summary>Creates a <see cref="ExperimentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ExperimentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ExperimentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ExperimentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ExperimentName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/experiments/{experiment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="experimentId">The <c>Experiment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExperimentName"/> constructed from the provided ids.</returns>
        public static ExperimentName FromProjectLocationAgentEnvironmentExperiment(string projectId, string locationId, string agentId, string environmentId, string experimentId) =>
            new ExperimentName(ResourceNameType.ProjectLocationAgentEnvironmentExperiment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), experimentId: gax::GaxPreconditions.CheckNotNullOrEmpty(experimentId, nameof(experimentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExperimentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/experiments/{experiment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="experimentId">The <c>Experiment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExperimentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/experiments/{experiment}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string agentId, string environmentId, string experimentId) =>
            FormatProjectLocationAgentEnvironmentExperiment(projectId, locationId, agentId, environmentId, experimentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExperimentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/experiments/{experiment}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="experimentId">The <c>Experiment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExperimentName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/experiments/{experiment}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationAgentEnvironmentExperiment(string projectId, string locationId, string agentId, string environmentId, string experimentId) =>
            s_projectLocationAgentEnvironmentExperiment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), gax::GaxPreconditions.CheckNotNullOrEmpty(experimentId, nameof(experimentId)));

        /// <summary>Parses the given resource name string into a new <see cref="ExperimentName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/experiments/{experiment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="experimentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExperimentName"/> if successful.</returns>
        public static ExperimentName Parse(string experimentName) => Parse(experimentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExperimentName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/experiments/{experiment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="experimentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ExperimentName"/> if successful.</returns>
        public static ExperimentName Parse(string experimentName, bool allowUnparsed) =>
            TryParse(experimentName, allowUnparsed, out ExperimentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExperimentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/experiments/{experiment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="experimentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExperimentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string experimentName, out ExperimentName result) =>
            TryParse(experimentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExperimentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/experiments/{experiment}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="experimentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExperimentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string experimentName, bool allowUnparsed, out ExperimentName result)
        {
            gax::GaxPreconditions.CheckNotNull(experimentName, nameof(experimentName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationAgentEnvironmentExperiment.TryParseName(experimentName, out resourceName))
            {
                result = FromProjectLocationAgentEnvironmentExperiment(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(experimentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ExperimentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string agentId = null, string environmentId = null, string experimentId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AgentId = agentId;
            EnvironmentId = environmentId;
            ExperimentId = experimentId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ExperimentName"/> class from the component parts of pattern
        /// <c>
        /// projects/{project}/locations/{location}/agents/{agent}/environments/{environment}/experiments/{experiment}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="agentId">The <c>Agent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="environmentId">The <c>Environment</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="experimentId">The <c>Experiment</c> ID. Must not be <c>null</c> or empty.</param>
        public ExperimentName(string projectId, string locationId, string agentId, string environmentId, string experimentId) : this(ResourceNameType.ProjectLocationAgentEnvironmentExperiment, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), agentId: gax::GaxPreconditions.CheckNotNullOrEmpty(agentId, nameof(agentId)), environmentId: gax::GaxPreconditions.CheckNotNullOrEmpty(environmentId, nameof(environmentId)), experimentId: gax::GaxPreconditions.CheckNotNullOrEmpty(experimentId, nameof(experimentId)))
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
        /// The <c>Experiment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ExperimentId { get; }

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
                case ResourceNameType.ProjectLocationAgentEnvironmentExperiment: return s_projectLocationAgentEnvironmentExperiment.Expand(ProjectId, LocationId, AgentId, EnvironmentId, ExperimentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ExperimentName);

        /// <inheritdoc/>
        public bool Equals(ExperimentName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ExperimentName a, ExperimentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ExperimentName a, ExperimentName b) => !(a == b);
    }

    public partial class Experiment
    {
        /// <summary>
        /// <see cref="gcdcv::ExperimentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::ExperimentName ExperimentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::ExperimentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        public partial class Types
        {
            public partial class Result
            {
                public partial class Types
                {
                    public partial class VersionMetrics
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
                }
            }
        }
    }

    public partial class ListExperimentsRequest
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

    public partial class GetExperimentRequest
    {
        /// <summary>
        /// <see cref="gcdcv::ExperimentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::ExperimentName ExperimentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::ExperimentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateExperimentRequest
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

    public partial class DeleteExperimentRequest
    {
        /// <summary>
        /// <see cref="gcdcv::ExperimentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::ExperimentName ExperimentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::ExperimentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StartExperimentRequest
    {
        /// <summary>
        /// <see cref="gcdcv::ExperimentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::ExperimentName ExperimentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::ExperimentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class StopExperimentRequest
    {
        /// <summary>
        /// <see cref="gcdcv::ExperimentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdcv::ExperimentName ExperimentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdcv::ExperimentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
