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
using gcgv = Google.Cloud.GkeMultiCloud.V1;

namespace Google.Cloud.GkeMultiCloud.V1
{
    public partial class GenerateAttachedClusterInstallManifestRequest
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

    public partial class CreateAttachedClusterRequest
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

    public partial class ImportAttachedClusterRequest
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

    public partial class GetAttachedClusterRequest
    {
        /// <summary>
        /// <see cref="gcgv::AttachedClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AttachedClusterName AttachedClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AttachedClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAttachedClustersRequest
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

    public partial class DeleteAttachedClusterRequest
    {
        /// <summary>
        /// <see cref="gcgv::AttachedClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AttachedClusterName AttachedClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AttachedClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAttachedServerConfigRequest
    {
        /// <summary>
        /// <see cref="gcgv::AttachedServerConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AttachedServerConfigName AttachedServerConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AttachedServerConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GenerateAttachedClusterAgentTokenRequest
    {
        /// <summary>
        /// <see cref="AttachedClusterName"/>-typed view over the <see cref="AttachedCluster"/> resource name property.
        /// </summary>
        public AttachedClusterName AttachedClusterAsAttachedClusterName
        {
            get => string.IsNullOrEmpty(AttachedCluster) ? null : AttachedClusterName.Parse(AttachedCluster, allowUnparsed: true);
            set => AttachedCluster = value?.ToString() ?? "";
        }
    }
}
