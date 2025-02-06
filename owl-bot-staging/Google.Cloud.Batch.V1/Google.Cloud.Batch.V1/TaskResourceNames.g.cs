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
    /// <summary>Resource name for the <c>Task</c> resource.</summary>
    public sealed partial class TaskName : gax::IResourceName, sys::IEquatable<TaskName>
    {
        /// <summary>The possible contents of <see cref="TaskName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}/tasks/{task}</c>.
            /// </summary>
            ProjectLocationJobTaskGroupTask = 1,
        }

        private static gax::PathTemplate s_projectLocationJobTaskGroupTask = new gax::PathTemplate("projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}/tasks/{task}");

        /// <summary>Creates a <see cref="TaskName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TaskName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TaskName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TaskName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TaskName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}/tasks/{task}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taskGroupId">The <c>TaskGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taskId">The <c>Task</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TaskName"/> constructed from the provided ids.</returns>
        public static TaskName FromProjectLocationJobTaskGroupTask(string projectId, string locationId, string jobId, string taskGroupId, string taskId) =>
            new TaskName(ResourceNameType.ProjectLocationJobTaskGroupTask, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), jobId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)), taskGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(taskGroupId, nameof(taskGroupId)), taskId: gax::GaxPreconditions.CheckNotNullOrEmpty(taskId, nameof(taskId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TaskName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}/tasks/{task}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taskGroupId">The <c>TaskGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taskId">The <c>Task</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TaskName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}/tasks/{task}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string jobId, string taskGroupId, string taskId) =>
            FormatProjectLocationJobTaskGroupTask(projectId, locationId, jobId, taskGroupId, taskId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TaskName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}/tasks/{task}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taskGroupId">The <c>TaskGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taskId">The <c>Task</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TaskName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}/tasks/{task}</c>.
        /// </returns>
        public static string FormatProjectLocationJobTaskGroupTask(string projectId, string locationId, string jobId, string taskGroupId, string taskId) =>
            s_projectLocationJobTaskGroupTask.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)), gax::GaxPreconditions.CheckNotNullOrEmpty(taskGroupId, nameof(taskGroupId)), gax::GaxPreconditions.CheckNotNullOrEmpty(taskId, nameof(taskId)));

        /// <summary>Parses the given resource name string into a new <see cref="TaskName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}/tasks/{task}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="taskName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TaskName"/> if successful.</returns>
        public static TaskName Parse(string taskName) => Parse(taskName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TaskName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}/tasks/{task}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="taskName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TaskName"/> if successful.</returns>
        public static TaskName Parse(string taskName, bool allowUnparsed) =>
            TryParse(taskName, allowUnparsed, out TaskName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="TaskName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}/tasks/{task}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="taskName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TaskName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string taskName, out TaskName result) => TryParse(taskName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TaskName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}/tasks/{task}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="taskName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TaskName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string taskName, bool allowUnparsed, out TaskName result)
        {
            gax::GaxPreconditions.CheckNotNull(taskName, nameof(taskName));
            gax::TemplatedResourceName resourceName;
            if (s_projectLocationJobTaskGroupTask.TryParseName(taskName, out resourceName))
            {
                result = FromProjectLocationJobTaskGroupTask(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(taskName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TaskName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string jobId = null, string locationId = null, string projectId = null, string taskId = null, string taskGroupId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            JobId = jobId;
            LocationId = locationId;
            ProjectId = projectId;
            TaskId = taskId;
            TaskGroupId = taskGroupId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TaskName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}/taskGroups/{task_group}/tasks/{task}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taskGroupId">The <c>TaskGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taskId">The <c>Task</c> ID. Must not be <c>null</c> or empty.</param>
        public TaskName(string projectId, string locationId, string jobId, string taskGroupId, string taskId) : this(ResourceNameType.ProjectLocationJobTaskGroupTask, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), jobId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)), taskGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(taskGroupId, nameof(taskGroupId)), taskId: gax::GaxPreconditions.CheckNotNullOrEmpty(taskId, nameof(taskId)))
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
        /// The <c>Task</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TaskId { get; }

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
                case ResourceNameType.ProjectLocationJobTaskGroupTask: return s_projectLocationJobTaskGroupTask.Expand(ProjectId, LocationId, JobId, TaskGroupId, TaskId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TaskName);

        /// <inheritdoc/>
        public bool Equals(TaskName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(TaskName a, TaskName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(TaskName a, TaskName b) => !(a == b);
    }

    public partial class Task
    {
        /// <summary>
        /// <see cref="gcbv::TaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbv::TaskName TaskName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbv::TaskName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
