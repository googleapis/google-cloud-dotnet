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
using gcdv = Google.Cloud.Dataplex.V1;

namespace Google.Cloud.Dataplex.V1
{
    public partial class CreateLakeRequest
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

    public partial class DeleteLakeRequest
    {
        /// <summary>
        /// <see cref="gcdv::LakeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::LakeName LakeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::LakeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListLakesRequest
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

    public partial class ListLakeActionsRequest
    {
        /// <summary><see cref="LakeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public LakeName ParentAsLakeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LakeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetLakeRequest
    {
        /// <summary>
        /// <see cref="gcdv::LakeName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::LakeName LakeName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::LakeName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateZoneRequest
    {
        /// <summary><see cref="LakeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public LakeName ParentAsLakeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LakeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteZoneRequest
    {
        /// <summary>
        /// <see cref="gcdv::ZoneName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ZoneName ZoneName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ZoneName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListZonesRequest
    {
        /// <summary><see cref="LakeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public LakeName ParentAsLakeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LakeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListZoneActionsRequest
    {
        /// <summary><see cref="ZoneName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ZoneName ParentAsZoneName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ZoneName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetZoneRequest
    {
        /// <summary>
        /// <see cref="gcdv::ZoneName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ZoneName ZoneName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ZoneName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAssetRequest
    {
        /// <summary><see cref="ZoneName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ZoneName ParentAsZoneName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ZoneName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAssetRequest
    {
        /// <summary>
        /// <see cref="gcdv::AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AssetName AssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAssetsRequest
    {
        /// <summary><see cref="ZoneName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ZoneName ParentAsZoneName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ZoneName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListAssetActionsRequest
    {
        /// <summary><see cref="AssetName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AssetName ParentAsAssetName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AssetName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAssetRequest
    {
        /// <summary>
        /// <see cref="gcdv::AssetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AssetName AssetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AssetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateTaskRequest
    {
        /// <summary><see cref="LakeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public LakeName ParentAsLakeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LakeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTaskRequest
    {
        /// <summary>
        /// <see cref="gcdv::TaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TaskName TaskName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TaskName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTasksRequest
    {
        /// <summary><see cref="LakeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public LakeName ParentAsLakeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LakeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTaskRequest
    {
        /// <summary>
        /// <see cref="gcdv::TaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TaskName TaskName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TaskName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetJobRequest
    {
        /// <summary>
        /// <see cref="gcdv::JobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::JobName JobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::JobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class RunTaskRequest
    {
        /// <summary>
        /// <see cref="gcdv::TaskName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::TaskName TaskName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::TaskName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListJobsRequest
    {
        /// <summary><see cref="TaskName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public TaskName ParentAsTaskName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TaskName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CancelJobRequest
    {
        /// <summary>
        /// <see cref="gcdv::JobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::JobName JobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::JobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateEnvironmentRequest
    {
        /// <summary><see cref="LakeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public LakeName ParentAsLakeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LakeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEnvironmentRequest
    {
        /// <summary>
        /// <see cref="gcdv::EnvironmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EnvironmentName EnvironmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EnvironmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEnvironmentsRequest
    {
        /// <summary><see cref="LakeName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public LakeName ParentAsLakeName
        {
            get => string.IsNullOrEmpty(Parent) ? null : LakeName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetEnvironmentRequest
    {
        /// <summary>
        /// <see cref="gcdv::EnvironmentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EnvironmentName EnvironmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EnvironmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSessionsRequest
    {
        /// <summary>
        /// <see cref="EnvironmentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EnvironmentName ParentAsEnvironmentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EnvironmentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
