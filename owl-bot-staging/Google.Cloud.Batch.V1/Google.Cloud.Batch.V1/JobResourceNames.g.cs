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
using gcbv = Google.Cloud.Batch.V1;
using sys = System;

namespace Google.Cloud.Batch.V1
{
    /// <summary>Resource name for the <c>Job</c> resource.</summary>
    public sealed partial class JobName : gax::IResourceName, sys::IEquatable<JobName>
    {
        /// <summary>The possible contents of <see cref="JobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>projects/{project}/locations/{location}/jobs/{job}</c>.
            /// </summary>
            ProjectLocationJob = 1,
        }

        private static gax::PathTemplate s_projectLocationJob = new gax::PathTemplate("projects/{project}/locations/{location}/jobs/{job}");

        /// <summary>Creates a <see cref="JobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="JobName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static JobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new JobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="JobName"/> with the pattern <c>projects/{project}/locations/{location}/jobs/{job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="JobName"/> constructed from the provided ids.</returns>
        public static JobName FromProjectLocationJob(string projectId, string locationId, string jobId) =>
            new JobName(ResourceNameType.ProjectLocationJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), jobId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="JobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="JobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string jobId) =>
            FormatProjectLocationJob(projectId, locationId, jobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="JobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="JobName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}</c>.
        /// </returns>
        public static string FormatProjectLocationJob(string projectId, string locationId, string jobId) =>
            s_projectLocationJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)));

        /// <summary>Parses the given resource name string into a new <see cref="JobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/jobs/{job}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="jobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="JobName"/> if successful.</returns>
        public static JobName Parse(string jobName) => Parse(jobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="JobName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/jobs/{job}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="jobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="JobName"/> if successful.</returns>
        public static JobName Parse(string jobName, bool allowUnparsed) =>
            TryParse(jobName, allowUnparsed, out JobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="JobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/jobs/{job}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="jobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="JobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string jobName, out JobName result) => TryParse(jobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="JobName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>projects/{project}/locations/{location}/jobs/{job}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="jobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="JobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string jobName, bool allowUnparsed, out JobName result)
        {
            gax::GaxPreconditions.CheckNotNull(jobName, nameof(jobName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationJob.TryParseName(jobName, out resourceName))
            {
                result = FromProjectLocationJob(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(jobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private JobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string jobId = null, string locationId = null, string projectId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            JobId = jobId;
            LocationId = locationId;
            ProjectId = projectId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="JobName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        public JobName(string projectId, string locationId, string jobId) : this(ResourceNameType.ProjectLocationJob, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), jobId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)))
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
        /// The <c>Job</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string JobId { get; }

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
                case ResourceNameType.ProjectLocationJob: return s_projectLocationJob.Expand(ProjectId, LocationId, JobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as JobName);

        /// <inheritdoc/>
        public bool Equals(JobName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(JobName a, JobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(JobName a, JobName b) => !(a == b);
    }

    /// <summary>Resource name for the <c>TaskGroup</c> resource.</summary>
    public sealed partial class TaskGroupName : gax::IResourceName, sys::IEquatable<TaskGroupName>
    {
        /// <summary>The possible contents of <see cref="TaskGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}</c>.
            /// </summary>
            ProjectLocationJobTaskGroup = 1,
        }

        private static gax::PathTemplate s_projectLocationJobTaskGroup = new gax::PathTemplate("projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}");

        /// <summary>Creates a <see cref="TaskGroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TaskGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TaskGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TaskGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TaskGroupName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taskGroupId">The <c>TaskGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TaskGroupName"/> constructed from the provided ids.</returns>
        public static TaskGroupName FromProjectLocationJobTaskGroup(string projectId, string locationId, string jobId, string taskGroupId) =>
            new TaskGroupName(ResourceNameType.ProjectLocationJobTaskGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), jobId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)), taskGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(taskGroupId, nameof(taskGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TaskGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taskGroupId">The <c>TaskGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TaskGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string jobId, string taskGroupId) =>
            FormatProjectLocationJobTaskGroup(projectId, locationId, jobId, taskGroupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TaskGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taskGroupId">The <c>TaskGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TaskGroupName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}</c>.
        /// </returns>
        public static string FormatProjectLocationJobTaskGroup(string projectId, string locationId, string jobId, string taskGroupId) =>
            s_projectLocationJobTaskGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)), gax::GaxPreconditions.CheckNotNullOrEmpty(taskGroupId, nameof(taskGroupId)));

        /// <summary>Parses the given resource name string into a new <see cref="TaskGroupName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="taskGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TaskGroupName"/> if successful.</returns>
        public static TaskGroupName Parse(string taskGroupName) => Parse(taskGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TaskGroupName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="taskGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TaskGroupName"/> if successful.</returns>
        public static TaskGroupName Parse(string taskGroupName, bool allowUnparsed) =>
            TryParse(taskGroupName, allowUnparsed, out TaskGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TaskGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="taskGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TaskGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string taskGroupName, out TaskGroupName result) => TryParse(taskGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TaskGroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="taskGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TaskGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string taskGroupName, bool allowUnparsed, out TaskGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(taskGroupName, nameof(taskGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationJobTaskGroup.TryParseName(taskGroupName, out resourceName))
            {
                result = FromProjectLocationJobTaskGroup(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(taskGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TaskGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string jobId = null, string locationId = null, string projectId = null, string taskGroupId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            JobId = jobId;
            LocationId = locationId;
            ProjectId = projectId;
            TaskGroupId = taskGroupId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TaskGroupName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taskGroupId">The <c>TaskGroup</c> ID. Must not be <c>null</c> or empty.</param>
        public TaskGroupName(string projectId, string locationId, string jobId, string taskGroupId) : this(ResourceNameType.ProjectLocationJobTaskGroup, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), jobId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)), taskGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(taskGroupId, nameof(taskGroupId)))
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
        /// The <c>Job</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string JobId { get; }

        /// <summary>
        /// The <c>Location</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The <c>Project</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The <c>TaskGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TaskGroupId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationJobTaskGroup: return s_projectLocationJobTaskGroup.Expand(ProjectId, LocationId, JobId, TaskGroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TaskGroupName);

        /// <inheritdoc/>
        public bool Equals(TaskGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TaskGroupName a, TaskGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TaskGroupName a, TaskGroupName b) => !(a == b);
    }

    public partial class Job
    {
        /// <summary>
        /// <see cref="gcbv::JobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::JobName JobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::JobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TaskGroup
    {
        /// <summary>
        /// <see cref="gcbv::TaskGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::TaskGroupName TaskGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::TaskGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
