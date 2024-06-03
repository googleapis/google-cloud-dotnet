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
using gcrv = Google.Cloud.Run.V2;
using sys = System;

namespace Google.Cloud.Run.V2
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
            /// <c>projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}</c>.
            /// </summary>
            ProjectLocationJobExecutionTask = 1,
        }

        private static gax::PathTemplate s_projectLocationJobExecutionTask = new gax::PathTemplate("projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}");

        /// <summary>Creates a <see cref="TaskName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TaskName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TaskName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TaskName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TaskName"/> with the pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="executionId">The <c>Execution</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taskId">The <c>Task</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TaskName"/> constructed from the provided ids.</returns>
        public static TaskName FromProjectLocationJobExecutionTask(string projectId, string locationId, string jobId, string executionId, string taskId) =>
            new TaskName(ResourceNameType.ProjectLocationJobExecutionTask, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), jobId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)), executionId: gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)), taskId: gax::GaxPreconditions.CheckNotNullOrEmpty(taskId, nameof(taskId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TaskName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="executionId">The <c>Execution</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taskId">The <c>Task</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TaskName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}</c>.
        /// </returns>
        public static string Format(string projectId, string locationId, string jobId, string executionId, string taskId) =>
            FormatProjectLocationJobExecutionTask(projectId, locationId, jobId, executionId, taskId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TaskName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}</c>.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="executionId">The <c>Execution</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taskId">The <c>Task</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TaskName"/> with pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}</c>.
        /// </returns>
        public static string FormatProjectLocationJobExecutionTask(string projectId, string locationId, string jobId, string executionId, string taskId) =>
            s_projectLocationJobExecutionTask.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)), gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)), gax::GaxPreconditions.CheckNotNullOrEmpty(taskId, nameof(taskId)));

        /// <summary>Parses the given resource name string into a new <see cref="TaskName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}</c>
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
        /// <c>projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}</c>
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
        /// <c>projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}</c>
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
        /// <c>projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}</c>
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
            if (s_projectLocationJobExecutionTask.TryParseName(taskName, out resourceName))
            {
                result = FromProjectLocationJobExecutionTask(resourceName[0], resourceName[1], resourceName[2], resourceName[3], resourceName[4]);
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

        private TaskName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string executionId = null, string jobId = null, string locationId = null, string projectId = null, string taskId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ExecutionId = executionId;
            JobId = jobId;
            LocationId = locationId;
            ProjectId = projectId;
            TaskId = taskId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TaskName"/> class from the component parts of pattern
        /// <c>projects/{project}/locations/{location}/jobs/{job}/executions/{execution}/tasks/{task}</c>
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="jobId">The <c>Job</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="executionId">The <c>Execution</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="taskId">The <c>Task</c> ID. Must not be <c>null</c> or empty.</param>
        public TaskName(string projectId, string locationId, string jobId, string executionId, string taskId) : this(ResourceNameType.ProjectLocationJobExecutionTask, projectId: gax::GaxPreconditions.CheckNotNullOrEmpty(projectId, nameof(projectId)), locationId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationId, nameof(locationId)), jobId: gax::GaxPreconditions.CheckNotNullOrEmpty(jobId, nameof(jobId)), executionId: gax::GaxPreconditions.CheckNotNullOrEmpty(executionId, nameof(executionId)), taskId: gax::GaxPreconditions.CheckNotNullOrEmpty(taskId, nameof(taskId)))
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
        /// The <c>Execution</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ExecutionId { get; }

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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ProjectLocationJobExecutionTask: return s_projectLocationJobExecutionTask.Expand(ProjectId, LocationId, JobId, ExecutionId, TaskId);
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

    public partial class GetTaskRequest
    {
        /// <summary>
        /// <see cref="gcrv::TaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::TaskName TaskName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::TaskName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTasksRequest
    {
        /// <summary>
        /// <see cref="ExecutionName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ExecutionName ParentAsExecutionName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ExecutionName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class Task
    {
        /// <summary>
        /// <see cref="gcrv::TaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcrv::TaskName TaskName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcrv::TaskName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary><see cref="JobName"/>-typed view over the <see cref="Job"/> resource name property.</summary>
        public JobName JobAsJobName
        {
            get => string.IsNullOrEmpty(Job) ? null : JobName.Parse(Job, allowUnparsed: true);
            set => Job = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ExecutionName"/>-typed view over the <see cref="Execution"/> resource name property.
        /// </summary>
        public ExecutionName ExecutionAsExecutionName
        {
            get => string.IsNullOrEmpty(Execution) ? null : ExecutionName.Parse(Execution, allowUnparsed: true);
            set => Execution = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CryptoKeyName"/>-typed view over the <see cref="EncryptionKey"/> resource name property.
        /// </summary>
        public CryptoKeyName EncryptionKeyAsCryptoKeyName
        {
            get => string.IsNullOrEmpty(EncryptionKey) ? null : CryptoKeyName.Parse(EncryptionKey, allowUnparsed: true);
            set => EncryptionKey = value?.ToString() ?? "";
        }
    }
}
