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
using gagr = Google.Api.Gax.ResourceNames;
using gctv = Google.Cloud.Tasks.V2;

namespace Google.Cloud.Tasks.V2
{
    public partial class ListQueuesRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetQueueRequest
    {
        /// <summary>
        /// <see cref="gctv::QueueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::QueueName QueueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::QueueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateQueueRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteQueueRequest
    {
        /// <summary>
        /// <see cref="gctv::QueueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::QueueName QueueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::QueueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PurgeQueueRequest
    {
        /// <summary>
        /// <see cref="gctv::QueueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::QueueName QueueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::QueueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PauseQueueRequest
    {
        /// <summary>
        /// <see cref="gctv::QueueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::QueueName QueueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::QueueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ResumeQueueRequest
    {
        /// <summary>
        /// <see cref="gctv::QueueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::QueueName QueueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::QueueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTasksRequest
    {
        /// <summary><see cref="QueueName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public QueueName ParentAsQueueName
        {
            get => string.IsNullOrEmpty(Parent) ? null : QueueName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTaskRequest
    {
        /// <summary>
        /// <see cref="gctv::TaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::TaskName TaskName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::TaskName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateTaskRequest
    {
        /// <summary><see cref="QueueName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public QueueName ParentAsQueueName
        {
            get => string.IsNullOrEmpty(Parent) ? null : QueueName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTaskRequest
    {
        /// <summary>
        /// <see cref="gctv::TaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::TaskName TaskName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::TaskName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RunTaskRequest
    {
        /// <summary>
        /// <see cref="gctv::TaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::TaskName TaskName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::TaskName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
