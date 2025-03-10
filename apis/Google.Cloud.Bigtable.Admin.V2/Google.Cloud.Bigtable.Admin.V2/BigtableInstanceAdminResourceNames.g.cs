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
using gcbav = Google.Cloud.Bigtable.Admin.V2;
using gcbcv = Google.Cloud.Bigtable.Common.V2;

namespace Google.Cloud.Bigtable.Admin.V2
{
    public partial class CreateInstanceRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetInstanceRequest
    {
        /// <summary>
        /// <see cref="gcbcv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbcv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbcv::InstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListInstancesRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteInstanceRequest
    {
        /// <summary>
        /// <see cref="gcbcv::InstanceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbcv::InstanceName InstanceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbcv::InstanceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateClusterRequest
    {
        /// <summary>
        /// <see cref="gcbcv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcbcv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcbcv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetClusterRequest
    {
        /// <summary>
        /// <see cref="gcbav::ClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::ClusterName ClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::ClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListClustersRequest
    {
        /// <summary>
        /// <see cref="gcbcv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcbcv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcbcv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteClusterRequest
    {
        /// <summary>
        /// <see cref="gcbav::ClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::ClusterName ClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::ClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAppProfileRequest
    {
        /// <summary>
        /// <see cref="gcbcv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcbcv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcbcv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAppProfileRequest
    {
        /// <summary>
        /// <see cref="gcbav::AppProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::AppProfileName AppProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::AppProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAppProfilesRequest
    {
        /// <summary>
        /// <see cref="gcbcv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcbcv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcbcv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAppProfileRequest
    {
        /// <summary>
        /// <see cref="gcbav::AppProfileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::AppProfileName AppProfileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::AppProfileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListHotTabletsRequest
    {
        /// <summary>
        /// <see cref="ClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ClusterName ParentAsClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateLogicalViewRequest
    {
        /// <summary>
        /// <see cref="gcbcv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcbcv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcbcv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetLogicalViewRequest
    {
        /// <summary>
        /// <see cref="gcbav::LogicalViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::LogicalViewName LogicalViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::LogicalViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListLogicalViewsRequest
    {
        /// <summary>
        /// <see cref="gcbcv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcbcv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcbcv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteLogicalViewRequest
    {
        /// <summary>
        /// <see cref="gcbav::LogicalViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::LogicalViewName LogicalViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::LogicalViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateMaterializedViewRequest
    {
        /// <summary>
        /// <see cref="gcbcv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcbcv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcbcv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetMaterializedViewRequest
    {
        /// <summary>
        /// <see cref="gcbav::MaterializedViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::MaterializedViewName MaterializedViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::MaterializedViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListMaterializedViewsRequest
    {
        /// <summary>
        /// <see cref="gcbcv::InstanceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gcbcv::InstanceName ParentAsInstanceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gcbcv::InstanceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteMaterializedViewRequest
    {
        /// <summary>
        /// <see cref="gcbav::MaterializedViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcbav::MaterializedViewName MaterializedViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcbav::MaterializedViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
