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
using gcnv = Google.Cloud.Notebooks.V1;

namespace Google.Cloud.Notebooks.V1
{
    public partial class GetInstanceHealthRequest
    {
        /// <summary>
        /// <see cref="gcnv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::InstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DiagnoseInstanceRequest
    {
        /// <summary>
        /// <see cref="gcnv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::InstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSchedulesRequest
    {
        /// <summary>
        /// <see cref="ScheduleName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ScheduleName ParentAsScheduleName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ScheduleName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetScheduleRequest
    {
        /// <summary>
        /// <see cref="gcnv::ScheduleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ScheduleName ScheduleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ScheduleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteScheduleRequest
    {
        /// <summary>
        /// <see cref="gcnv::ScheduleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ScheduleName ScheduleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ScheduleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateScheduleRequest
    {
        /// <summary>
        /// <see cref="ScheduleName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ScheduleName ParentAsScheduleName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ScheduleName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class TriggerScheduleRequest
    {
        /// <summary>
        /// <see cref="gcnv::ScheduleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ScheduleName ScheduleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ScheduleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListExecutionsRequest
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

    public partial class GetExecutionRequest
    {
        /// <summary>
        /// <see cref="gcnv::ExecutionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ExecutionName ExecutionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ExecutionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteExecutionRequest
    {
        /// <summary>
        /// <see cref="gcnv::ExecutionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::ExecutionName ExecutionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::ExecutionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateExecutionRequest
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
}
