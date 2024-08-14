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
using gcav = Google.Cloud.AIPlatform.V1Beta1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Resource name for the <c>ModelDeploymentMonitoringJob</c> resource.</summary>
    public sealed partial class ModelDeploymentMonitoringJobName : gax::IResourceName, sys::IEquatable<ModelDeploymentMonitoringJobName>
    {
        /// <summary>The possible contents of <see cref="ModelDeploymentMonitoringJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}</c>
            /// .
            /// </summary>
            ProjectLocationModelDeploymentMonitoringJob = 1,
        }

        private static gax::PathTemplate s_projectLocationModelDeploymentMonitoringJob = new gax::PathTemplate("projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}");

        /// <summary>
        /// Creates a <see cref="ModelDeploymentMonitoringJobName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ModelDeploymentMonitoringJobName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ModelDeploymentMonitoringJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ModelDeploymentMonitoringJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ModelDeploymentMonitoringJobName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelDeploymentMonitoringJobId">
        /// The <c>ModelDeploymentMonitoringJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ModelDeploymentMonitoringJobName"/> constructed from the provided ids.
        /// </returns>
        public static ModelDeploymentMonitoringJobName FromProjectLocationModelDeploymentMonitoringJob(string projectId, string locationId, string modelDeploymentMonitoringJobId) =>
            new ModelDeploymentMonitoringJobName(ResourceNameType.ProjectLocationModelDeploymentMonitoringJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), modelDeploymentMonitoringJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelDeploymentMonitoringJobId, nameof(modelDeploymentMonitoringJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ModelDeploymentMonitoringJobName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelDeploymentMonitoringJobId">
        /// The <c>ModelDeploymentMonitoringJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ModelDeploymentMonitoringJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string modelDeploymentMonitoringJobId) =>
            FormatProjectLocationModelDeploymentMonitoringJob(projectId, locationId, modelDeploymentMonitoringJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ModelDeploymentMonitoringJobName"/> with
        /// pattern
        /// <c>projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelDeploymentMonitoringJobId">
        /// The <c>ModelDeploymentMonitoringJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ModelDeploymentMonitoringJobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationModelDeploymentMonitoringJob(string projectId, string locationId, string modelDeploymentMonitoringJobId) =>
            s_projectLocationModelDeploymentMonitoringJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(modelDeploymentMonitoringJobId, nameof(modelDeploymentMonitoringJobId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ModelDeploymentMonitoringJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="modelDeploymentMonitoringJobName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ModelDeploymentMonitoringJobName"/> if successful.</returns>
        public static ModelDeploymentMonitoringJobName Parse(string modelDeploymentMonitoringJobName) =>
            Parse(modelDeploymentMonitoringJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ModelDeploymentMonitoringJobName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="modelDeploymentMonitoringJobName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ModelDeploymentMonitoringJobName"/> if successful.</returns>
        public static ModelDeploymentMonitoringJobName Parse(string modelDeploymentMonitoringJobName, bool allowUnparsed) =>
            TryParse(modelDeploymentMonitoringJobName, allowUnparsed, out ModelDeploymentMonitoringJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ModelDeploymentMonitoringJobName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="modelDeploymentMonitoringJobName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ModelDeploymentMonitoringJobName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string modelDeploymentMonitoringJobName, out ModelDeploymentMonitoringJobName result) =>
            TryParse(modelDeploymentMonitoringJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ModelDeploymentMonitoringJobName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="modelDeploymentMonitoringJobName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ModelDeploymentMonitoringJobName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string modelDeploymentMonitoringJobName, bool allowUnparsed, out ModelDeploymentMonitoringJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(modelDeploymentMonitoringJobName, nameof(modelDeploymentMonitoringJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationModelDeploymentMonitoringJob.TryParseName(modelDeploymentMonitoringJobName, out resourceName))
            {
                result = FromProjectLocationModelDeploymentMonitoringJob(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(modelDeploymentMonitoringJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ModelDeploymentMonitoringJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string modelDeploymentMonitoringJobId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ModelDeploymentMonitoringJobId = modelDeploymentMonitoringJobId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ModelDeploymentMonitoringJobName"/> class from the component parts
        /// of pattern
        /// <c>projects/{project}/locations/{location}/modelDeploymentMonitoringJobs/{model_deployment_monitoring_job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelDeploymentMonitoringJobId">
        /// The <c>ModelDeploymentMonitoringJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ModelDeploymentMonitoringJobName(string projectId, string locationId, string modelDeploymentMonitoringJobId) : this(ResourceNameType.ProjectLocationModelDeploymentMonitoringJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), modelDeploymentMonitoringJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelDeploymentMonitoringJobId, nameof(modelDeploymentMonitoringJobId)))
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
        /// The <c>ModelDeploymentMonitoringJob</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string ModelDeploymentMonitoringJobId { get; }

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
                case ResourceNameType.ProjectLocationModelDeploymentMonitoringJob: return s_projectLocationModelDeploymentMonitoringJob.Expand(ProjectId, LocationId, ModelDeploymentMonitoringJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ModelDeploymentMonitoringJobName);

        /// <inheritdoc/>
        public bool Equals(ModelDeploymentMonitoringJobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ModelDeploymentMonitoringJobName a, ModelDeploymentMonitoringJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ModelDeploymentMonitoringJobName a, ModelDeploymentMonitoringJobName b) => !(a == b);
    }

    public partial class ModelDeploymentMonitoringJob
    {
        /// <summary>
        /// <see cref="gcav::ModelDeploymentMonitoringJobName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::ModelDeploymentMonitoringJobName ModelDeploymentMonitoringJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ModelDeploymentMonitoringJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="EndpointName"/>-typed view over the <see cref="Endpoint"/> resource name property.
        /// </summary>
        public EndpointName EndpointAsEndpointName
        {
            get => string.IsNullOrEmpty(Endpoint) ? null : EndpointName.Parse(Endpoint, allowUnparsed: true);
            set => Endpoint = value?.ToString() ?? "";
        }
    }
}
