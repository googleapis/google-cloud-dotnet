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
using gctv = Google.Cloud.Talent.V4;

namespace Google.Cloud.Talent.V4
{
    public partial class CreateJobRequest
    {
        /// <summary><see cref="TenantName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public TenantName ParentAsTenantName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TenantName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetJobRequest
    {
        /// <summary>
        /// <see cref="gctv::JobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::JobName JobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::JobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteJobRequest
    {
        /// <summary>
        /// <see cref="gctv::JobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gctv::JobName JobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gctv::JobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListJobsRequest
    {
        /// <summary><see cref="TenantName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public TenantName ParentAsTenantName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TenantName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class SearchJobsRequest
    {
        /// <summary><see cref="TenantName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public TenantName ParentAsTenantName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TenantName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchCreateJobsRequest
    {
        /// <summary><see cref="TenantName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public TenantName ParentAsTenantName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TenantName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchUpdateJobsRequest
    {
        /// <summary><see cref="TenantName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public TenantName ParentAsTenantName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TenantName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchDeleteJobsRequest
    {
        /// <summary><see cref="TenantName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public TenantName ParentAsTenantName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TenantName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary><see cref="JobName"/>-typed view over the <see cref="Names"/> resource name property.</summary>
        public gax::ResourceNameList<JobName> JobNames
        {
            get => new gax::ResourceNameList<JobName>(Names, s => string.IsNullOrEmpty(s) ? null : JobName.Parse(s, allowUnparsed: true));
        }
    }
}
