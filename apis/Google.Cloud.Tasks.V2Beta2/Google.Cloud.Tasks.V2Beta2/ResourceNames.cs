// Copyright 2018 Google LLC
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
using sys = System;
using linq = System.Linq;

namespace Google.Cloud.Tasks.V2Beta2
{
    /// <summary>
    /// Resource name for the 'location' resource.
    /// </summary>
    public sealed partial class LocationName : gax::IResourceName, sys::IEquatable<LocationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}");

        /// <summary>
        /// Parses the given location resource name in string form into a new
        /// <see cref="LocationName"/> instance.
        /// </summary>
        /// <param name="locationName">The location resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationName"/> if successful.</returns>
        public static LocationName Parse(string locationName)
        {
            gax::GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(locationName);
            return new LocationName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given location resource name in string form into a new
        /// <see cref="LocationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="locationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="locationName">The location resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LocationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationName, out LocationName result)
        {
            gax::GaxPreconditions.CheckNotNull(locationName, nameof(locationName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(locationName, out resourceName))
            {
                result = new LocationName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="LocationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        public LocationName(string projectId, string locationId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LocationName);

        /// <inheritdoc />
        public bool Equals(LocationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LocationName a, LocationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LocationName a, LocationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'queue' resource.
    /// </summary>
    public sealed partial class QueueName : gax::IResourceName, sys::IEquatable<QueueName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/queues/{queue}");

        /// <summary>
        /// Parses the given queue resource name in string form into a new
        /// <see cref="QueueName"/> instance.
        /// </summary>
        /// <param name="queueName">The queue resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="QueueName"/> if successful.</returns>
        public static QueueName Parse(string queueName)
        {
            gax::GaxPreconditions.CheckNotNull(queueName, nameof(queueName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(queueName);
            return new QueueName(resourceName[0], resourceName[1], resourceName[2]);
        }

        /// <summary>
        /// Tries to parse the given queue resource name in string form into a new
        /// <see cref="QueueName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="queueName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="queueName">The queue resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="QueueName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string queueName, out QueueName result)
        {
            gax::GaxPreconditions.CheckNotNull(queueName, nameof(queueName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(queueName, out resourceName))
            {
                result = new QueueName(resourceName[0], resourceName[1], resourceName[2]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="QueueName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="queueId">The queue ID. Must not be <c>null</c>.</param>
        public QueueName(string projectId, string locationId, string queueId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            QueueId = gax::GaxPreconditions.CheckNotNull(queueId, nameof(queueId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The queue ID. Never <c>null</c>.
        /// </summary>
        public string QueueId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, QueueId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as QueueName);

        /// <inheritdoc />
        public bool Equals(QueueName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(QueueName a, QueueName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(QueueName a, QueueName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'task' resource.
    /// </summary>
    public sealed partial class TaskName : gax::IResourceName, sys::IEquatable<TaskName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("projects/{project}/locations/{location}/queues/{queue}/tasks/{task}");

        /// <summary>
        /// Parses the given task resource name in string form into a new
        /// <see cref="TaskName"/> instance.
        /// </summary>
        /// <param name="taskName">The task resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TaskName"/> if successful.</returns>
        public static TaskName Parse(string taskName)
        {
            gax::GaxPreconditions.CheckNotNull(taskName, nameof(taskName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(taskName);
            return new TaskName(resourceName[0], resourceName[1], resourceName[2], resourceName[3]);
        }

        /// <summary>
        /// Tries to parse the given task resource name in string form into a new
        /// <see cref="TaskName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="taskName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="taskName">The task resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="TaskName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string taskName, out TaskName result)
        {
            gax::GaxPreconditions.CheckNotNull(taskName, nameof(taskName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(taskName, out resourceName))
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

        /// <summary>
        /// Constructs a new instance of the <see cref="TaskName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="projectId">The project ID. Must not be <c>null</c>.</param>
        /// <param name="locationId">The location ID. Must not be <c>null</c>.</param>
        /// <param name="queueId">The queue ID. Must not be <c>null</c>.</param>
        /// <param name="taskId">The task ID. Must not be <c>null</c>.</param>
        public TaskName(string projectId, string locationId, string queueId, string taskId)
        {
            ProjectId = gax::GaxPreconditions.CheckNotNull(projectId, nameof(projectId));
            LocationId = gax::GaxPreconditions.CheckNotNull(locationId, nameof(locationId));
            QueueId = gax::GaxPreconditions.CheckNotNull(queueId, nameof(queueId));
            TaskId = gax::GaxPreconditions.CheckNotNull(taskId, nameof(taskId));
        }

        /// <summary>
        /// The project ID. Never <c>null</c>.
        /// </summary>
        public string ProjectId { get; }

        /// <summary>
        /// The location ID. Never <c>null</c>.
        /// </summary>
        public string LocationId { get; }

        /// <summary>
        /// The queue ID. Never <c>null</c>.
        /// </summary>
        public string QueueId { get; }

        /// <summary>
        /// The task ID. Never <c>null</c>.
        /// </summary>
        public string TaskId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProjectId, LocationId, QueueId, TaskId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as TaskName);

        /// <inheritdoc />
        public bool Equals(TaskName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(TaskName a, TaskName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(TaskName a, TaskName b) => !(a == b);
    }


    public partial class AcknowledgeTaskRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Tasks.V2Beta2.TaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Tasks.V2Beta2.TaskName TaskName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Tasks.V2Beta2.TaskName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CancelLeaseRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Tasks.V2Beta2.TaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Tasks.V2Beta2.TaskName TaskName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Tasks.V2Beta2.TaskName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateQueueRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Tasks.V2Beta2.LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Tasks.V2Beta2.LocationName ParentAsLocationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Tasks.V2Beta2.LocationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class CreateTaskRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Tasks.V2Beta2.QueueName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Tasks.V2Beta2.QueueName ParentAsQueueName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Tasks.V2Beta2.QueueName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteQueueRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Tasks.V2Beta2.QueueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Tasks.V2Beta2.QueueName QueueName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Tasks.V2Beta2.QueueName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class DeleteTaskRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Tasks.V2Beta2.TaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Tasks.V2Beta2.TaskName TaskName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Tasks.V2Beta2.TaskName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetQueueRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Tasks.V2Beta2.QueueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Tasks.V2Beta2.QueueName QueueName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Tasks.V2Beta2.QueueName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class GetTaskRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Tasks.V2Beta2.TaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Tasks.V2Beta2.TaskName TaskName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Tasks.V2Beta2.TaskName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class LeaseTasksRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Tasks.V2Beta2.QueueName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Tasks.V2Beta2.QueueName ParentAsQueueName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Tasks.V2Beta2.QueueName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListQueuesRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Tasks.V2Beta2.LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Tasks.V2Beta2.LocationName ParentAsLocationName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Tasks.V2Beta2.LocationName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ListTasksRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Tasks.V2Beta2.QueueName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public Google.Cloud.Tasks.V2Beta2.QueueName ParentAsQueueName
        {
            get { return string.IsNullOrEmpty(Parent) ? null : Google.Cloud.Tasks.V2Beta2.QueueName.Parse(Parent); }
            set { Parent = value != null ? value.ToString() : ""; }
        }

    }

    public partial class PauseQueueRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Tasks.V2Beta2.QueueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Tasks.V2Beta2.QueueName QueueName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Tasks.V2Beta2.QueueName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class PurgeQueueRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Tasks.V2Beta2.QueueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Tasks.V2Beta2.QueueName QueueName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Tasks.V2Beta2.QueueName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Queue
    {
        /// <summary>
        /// <see cref="Google.Cloud.Tasks.V2Beta2.QueueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Tasks.V2Beta2.QueueName QueueName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Tasks.V2Beta2.QueueName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class RenewLeaseRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Tasks.V2Beta2.TaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Tasks.V2Beta2.TaskName TaskName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Tasks.V2Beta2.TaskName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class ResumeQueueRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Tasks.V2Beta2.QueueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Tasks.V2Beta2.QueueName QueueName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Tasks.V2Beta2.QueueName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class RunTaskRequest
    {
        /// <summary>
        /// <see cref="Google.Cloud.Tasks.V2Beta2.TaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Tasks.V2Beta2.TaskName TaskName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Tasks.V2Beta2.TaskName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

    public partial class Task
    {
        /// <summary>
        /// <see cref="Google.Cloud.Tasks.V2Beta2.TaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public Google.Cloud.Tasks.V2Beta2.TaskName TaskName
        {
            get { return string.IsNullOrEmpty(Name) ? null : Google.Cloud.Tasks.V2Beta2.TaskName.Parse(Name); }
            set { Name = value != null ? value.ToString() : ""; }
        }

    }

}