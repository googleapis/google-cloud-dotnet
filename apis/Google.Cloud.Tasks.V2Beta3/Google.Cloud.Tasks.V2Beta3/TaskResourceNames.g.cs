// Copyright 2019 Google LLC
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

using gax = Google.Api.Gax;
using gctv = Google.Cloud.Tasks.V2Beta3;
using sys = System;

namespace Google.Cloud.Tasks.V2Beta3
{
    /// <summary>Resource name for the <c>Task</c> resource.</summary>
    public sealed partial class TaskName : gax::IResourceName, sys::IEquatable<TaskName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/queues/{queue}/tasks/{task}");

        /// <summary>
        /// Parses the given <c>Task</c> resource name in string form into a new <see cref="TaskName"/> instance.
        /// </summary>
        /// <param name="taskName">The <c>Task</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TaskName"/> if successful.</returns>
        public static TaskName Parse(string taskName)
        {
            gax::GaxPreconditions.CheckNotNull(taskName, nameof(taskName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(taskName);
            return new TaskName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given session resource name in string form into a new <see cref="TaskName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="taskName"/> is <c>null</c>
        /// , as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="taskName">The <c>Task</c> resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TaskName"/>, or <c>null</c> if parsing fails.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string taskName, out TaskName result)
        {
            gax::GaxPreconditions.CheckNotNull(taskName, nameof(taskName));
            if (s_template.TryParseName(taskName, out gax::TemplatedResourceName resourceName))
            {
                result = new TaskName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>Formats the IDs into the string representation of the <see cref="TaskName"/>.</summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="queueId">The <c>Queue</c> ID. Must not be <c>null</c>.</param>
        /// <param name="taskId">The <c>Task</c> ID. Must not be <c>null</c>.</param>
        /// <returns>The string representation of the <see cref="TaskName"/>.</returns>
        public static string Format(string projectId, string locationId, string queueId, string taskId) =>
            s_template.Expand(gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId)), gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId)), gax::GaxPreconditions.CheckNotNull(queueId, nameof(queueId)), gax::GaxPreconditions.CheckNotNull(taskId, nameof(taskId)));

        /// <summary>
        /// Constructs a new instance of the <see cref="TaskName"/> resource name class from its component parts.
        /// </summary>
        /// <param name="projectId">The <c>Project</c> ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The <c>Location</c> ID. Must not be <c>null</c>.</param>
        /// <param name="queueId">The <c>Queue</c> ID. Must not be <c>null</c>.</param>
        /// <param name="taskId">The <c>Task</c> ID. Must not be <c>null</c>.</param>
        public TaskName(string projectId, string locationId, string queueId, string taskId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            QueueId = gax::GaxPreconditions.CheckNotNull(queueId, nameof(queueId));
            TaskId = gax::GaxPreconditions.CheckNotNull(taskId, nameof(taskId));
        }

        /// <summary>The <c>Project</c> ID. Never <c>null</c>.</summary>
        public string ProjectId { get; }

        /// <summary>The <c>Location</c> ID. Never <c>null</c>.</summary>
        public string LocationId { get; }

        /// <summary>The <c>Queue</c> ID. Never <c>null</c>.</summary>
        public string QueueId { get; }

        /// <summary>The <c>Task</c> ID. Never <c>null</c>.</summary>
        public string TaskId { get; }

        /// <inheritdoc/>
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc/>
        public override string ToString() => s_template.Expand(ProjectId, LocationId, QueueId, TaskId);

        /// <inheritdoc/>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TaskName);

        /// <inheritdoc/>
        public bool Equals(TaskName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(TaskName a, TaskName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(TaskName a, TaskName b) => !(a == b);
    }

    public partial class Task
    {
        /// <summary>
        /// <see cref="gctv::TaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::TaskName TaskName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::TaskName.Parse(Name);
            set => Name = value?.ToString() ?? "";
        }
    }
}
