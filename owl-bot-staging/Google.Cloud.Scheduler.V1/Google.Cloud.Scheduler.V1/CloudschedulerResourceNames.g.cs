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
using gcsv = Google.Cloud.Scheduler.V1;

namespace Google.Cloud.Scheduler.V1
{
    public partial class ListJobsRequest
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
        /// <see cref="gcsv::JobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::JobName JobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::JobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

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

    public partial class DeleteJobRequest
    {
        /// <summary>
        /// <see cref="gcsv::JobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::JobName JobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::JobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PauseJobRequest
    {
        /// <summary>
        /// <see cref="gcsv::JobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::JobName JobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::JobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ResumeJobRequest
    {
        /// <summary>
        /// <see cref="gcsv::JobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::JobName JobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::JobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RunJobRequest
    {
        /// <summary>
        /// <see cref="gcsv::JobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcsv::JobName JobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcsv::JobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
