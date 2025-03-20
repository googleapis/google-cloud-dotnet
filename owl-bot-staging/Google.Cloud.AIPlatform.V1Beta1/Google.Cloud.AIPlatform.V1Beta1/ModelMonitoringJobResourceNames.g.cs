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
using gcav = Google.Cloud.AIPlatform.V1Beta1;
using sys = System;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    /// <summary>Resource name for the <c>ModelMonitoringJob</c> resource.</summary>
    public sealed partial class ModelMonitoringJobName : gax::IResourceName, sys::IEquatable<ModelMonitoringJobName>
    {
        /// <summary>The possible contents of <see cref="ModelMonitoringJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}</c>
            /// .
            /// </summary>
            ProjectLocationModelMonitorModelMonitoringJob = 1,
        }

        private static gax::PathTemplate s_projectLocationModelMonitorModelMonitoringJob = new gax::PathTemplate("projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}");

        /// <summary>Creates a <see cref="ModelMonitoringJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ModelMonitoringJobName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ModelMonitoringJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ModelMonitoringJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ModelMonitoringJobName"/> with the pattern
        /// <c>
        /// projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelMonitorId">The <c>ModelMonitor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelMonitoringJobId">
        /// The <c>ModelMonitoringJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="ModelMonitoringJobName"/> constructed from the provided ids.</returns>
        public static ModelMonitoringJobName FromProjectLocationModelMonitorModelMonitoringJob(string projectId, string locationId, string modelMonitorId, string modelMonitoringJobId) =>
            new ModelMonitoringJobName(ResourceNameType.ProjectLocationModelMonitorModelMonitoringJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), modelMonitorId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelMonitorId, nameof(modelMonitorId)), modelMonitoringJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelMonitoringJobId, nameof(modelMonitoringJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ModelMonitoringJobName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelMonitorId">The <c>ModelMonitor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelMonitoringJobId">
        /// The <c>ModelMonitoringJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ModelMonitoringJobName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}</c>
        /// .
        /// </returns>
        public static string Format(string projectId, string locationId, string modelMonitorId, string modelMonitoringJobId) =>
            FormatProjectLocationModelMonitorModelMonitoringJob(projectId, locationId, modelMonitorId, modelMonitoringJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ModelMonitoringJobName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}</c>
        /// .
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelMonitorId">The <c>ModelMonitor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelMonitoringJobId">
        /// The <c>ModelMonitoringJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ModelMonitoringJobName"/> with pattern
        /// <c>
        /// projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}</c>
        /// .
        /// </returns>
        public static string FormatProjectLocationModelMonitorModelMonitoringJob(string projectId, string locationId, string modelMonitorId, string modelMonitoringJobId) =>
            s_projectLocationModelMonitorModelMonitoringJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(modelMonitorId, nameof(modelMonitorId)), gax::GaxPreconditions.CheckNotNullOrEmpty(modelMonitoringJobId, nameof(modelMonitoringJobId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ModelMonitoringJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="modelMonitoringJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ModelMonitoringJobName"/> if successful.</returns>
        public static ModelMonitoringJobName Parse(string modelMonitoringJobName) => Parse(modelMonitoringJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ModelMonitoringJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="modelMonitoringJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ModelMonitoringJobName"/> if successful.</returns>
        public static ModelMonitoringJobName Parse(string modelMonitoringJobName, bool allowUnparsed) =>
            TryParse(modelMonitoringJobName, allowUnparsed, out ModelMonitoringJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ModelMonitoringJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="modelMonitoringJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ModelMonitoringJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string modelMonitoringJobName, out ModelMonitoringJobName result) =>
            TryParse(modelMonitoringJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ModelMonitoringJobName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="modelMonitoringJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ModelMonitoringJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string modelMonitoringJobName, bool allowUnparsed, out ModelMonitoringJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(modelMonitoringJobName, nameof(modelMonitoringJobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationModelMonitorModelMonitoringJob.TryParseName(modelMonitoringJobName, out resourceName))
            {
                result = FromProjectLocationModelMonitorModelMonitoringJob(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(modelMonitoringJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ModelMonitoringJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string locationId = null, string modelMonitorId = null, string modelMonitoringJobId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            LocationId = locationId;
            ModelMonitorId = modelMonitorId;
            ModelMonitoringJobId = modelMonitoringJobId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ModelMonitoringJobName"/> class from the component parts of
        /// pattern
        /// <c>
        /// projects/{project}/locations/{location}/modelMonitors/{model_monitor}/modelMonitoringJobs/{model_monitoring_job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelMonitorId">The <c>ModelMonitor</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modelMonitoringJobId">
        /// The <c>ModelMonitoringJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ModelMonitoringJobName(string projectId, string locationId, string modelMonitorId, string modelMonitoringJobId) : this(ResourceNameType.ProjectLocationModelMonitorModelMonitoringJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), modelMonitorId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelMonitorId, nameof(modelMonitorId)), modelMonitoringJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(modelMonitoringJobId, nameof(modelMonitoringJobId)))
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
        /// The <c>ModelMonitor</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ModelMonitorId { get; }

        /// <summary>
        /// The <c>ModelMonitoringJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ModelMonitoringJobId { get; }

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
                case ResourceNameType.ProjectLocationModelMonitorModelMonitoringJob: return s_projectLocationModelMonitorModelMonitoringJob.Expand(ProjectId, LocationId, ModelMonitorId, ModelMonitoringJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ModelMonitoringJobName);

        /// <inheritdoc/>
        public bool Equals(ModelMonitoringJobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ModelMonitoringJobName a, ModelMonitoringJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ModelMonitoringJobName a, ModelMonitoringJobName b) => !(a == b);
    }

    public partial class ModelMonitoringJob
    {
        /// <summary>
        /// <see cref="gcav::ModelMonitoringJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ModelMonitoringJobName ModelMonitoringJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ModelMonitoringJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ScheduleName"/>-typed view over the <see cref="Schedule"/> resource name property.
        /// </summary>
        public ScheduleName ScheduleAsScheduleName
        {
            get => string.IsNullOrEmpty(Schedule) ? null : ScheduleName.Parse(Schedule, allowUnparsed: true);
            set => Schedule = value?.ToString() ?? "";
        }
    }
}
