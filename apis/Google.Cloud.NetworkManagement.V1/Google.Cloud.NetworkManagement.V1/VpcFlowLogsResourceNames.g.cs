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
using gcnv = Google.Cloud.NetworkManagement.V1;

namespace Google.Cloud.NetworkManagement.V1
{
    public partial class ListVpcFlowLogsConfigsRequest
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

    public partial class GetVpcFlowLogsConfigRequest
    {
        /// <summary>
        /// <see cref="gcnv::VpcFlowLogsConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::VpcFlowLogsConfigName VpcFlowLogsConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::VpcFlowLogsConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateVpcFlowLogsConfigRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="VpcFlowLogsConfigName"/>-typed view over the <see cref="VpcFlowLogsConfigId"/> resource name
        /// property.
        /// </summary>
        public VpcFlowLogsConfigName VpcFlowLogsConfigIdAsVpcFlowLogsConfigName
        {
            get => string.IsNullOrEmpty(VpcFlowLogsConfigId) ? null : VpcFlowLogsConfigName.Parse(VpcFlowLogsConfigId, allowUnparsed: true);
            set => VpcFlowLogsConfigId = value?.ToString() ?? "";
        }
    }

    public partial class DeleteVpcFlowLogsConfigRequest
    {
        /// <summary>
        /// <see cref="gcnv::VpcFlowLogsConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcnv::VpcFlowLogsConfigName VpcFlowLogsConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcnv::VpcFlowLogsConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
