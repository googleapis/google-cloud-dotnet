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
using gagr = Google.Api.Gax.ResourceNames;
using gcbv = Google.Cloud.Batch.V1;

namespace Google.Cloud.Batch.V1
{
    public partial class CreateJobRequest
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

    public partial class GetJobRequest
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

    public partial class CancelJobRequest
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

    public partial class ListTasksRequest
    {
        /// <summary>
        /// <see cref="TaskGroupName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TaskGroupName ParentAsTaskGroupName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TaskGroupName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTaskRequest
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
