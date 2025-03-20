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
using gcav = Google.Cloud.AIPlatform.V1Beta1;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    public partial class CreateFeatureGroupRequest
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

    public partial class GetFeatureGroupRequest
    {
        /// <summary>
        /// <see cref="gcav::FeatureGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FeatureGroupName FeatureGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FeatureGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFeatureGroupsRequest
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

    public partial class DeleteFeatureGroupRequest
    {
        /// <summary>
        /// <see cref="gcav::FeatureGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FeatureGroupName FeatureGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FeatureGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateFeatureMonitorRequest
    {
        /// <summary>
        /// <see cref="FeatureGroupName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FeatureGroupName ParentAsFeatureGroupName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FeatureGroupName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetFeatureMonitorRequest
    {
        /// <summary>
        /// <see cref="gcav::FeatureMonitorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FeatureMonitorName FeatureMonitorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FeatureMonitorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFeatureMonitorsRequest
    {
        /// <summary>
        /// <see cref="FeatureGroupName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FeatureGroupName ParentAsFeatureGroupName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FeatureGroupName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteFeatureMonitorRequest
    {
        /// <summary>
        /// <see cref="gcav::FeatureMonitorName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FeatureMonitorName FeatureMonitorName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FeatureMonitorName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateFeatureMonitorJobRequest
    {
        /// <summary>
        /// <see cref="FeatureMonitorName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FeatureMonitorName ParentAsFeatureMonitorName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FeatureMonitorName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetFeatureMonitorJobRequest
    {
        /// <summary>
        /// <see cref="gcav::FeatureMonitorJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FeatureMonitorJobName FeatureMonitorJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FeatureMonitorJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListFeatureMonitorJobsRequest
    {
        /// <summary>
        /// <see cref="FeatureMonitorName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public FeatureMonitorName ParentAsFeatureMonitorName
        {
            get => string.IsNullOrEmpty(Parent) ? null : FeatureMonitorName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
