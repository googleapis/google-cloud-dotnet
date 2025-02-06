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
using gcgv = Google.Cloud.GkeMultiCloud.V1;

namespace Google.Cloud.GkeMultiCloud.V1
{
    public partial class CreateAwsClusterRequest
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

    public partial class GetAwsClusterRequest
    {
        /// <summary>
        /// <see cref="gcgv::AwsClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AwsClusterName AwsClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AwsClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAwsClustersRequest
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

    public partial class DeleteAwsClusterRequest
    {
        /// <summary>
        /// <see cref="gcgv::AwsClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AwsClusterName AwsClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AwsClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAwsNodePoolRequest
    {
        /// <summary>
        /// <see cref="AwsClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AwsClusterName ParentAsAwsClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AwsClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class RollbackAwsNodePoolUpdateRequest
    {
        /// <summary>
        /// <see cref="gcgv::AwsNodePoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AwsNodePoolName AwsNodePoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AwsNodePoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAwsNodePoolRequest
    {
        /// <summary>
        /// <see cref="gcgv::AwsNodePoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AwsNodePoolName AwsNodePoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AwsNodePoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAwsNodePoolsRequest
    {
        /// <summary>
        /// <see cref="AwsClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AwsClusterName ParentAsAwsClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AwsClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAwsNodePoolRequest
    {
        /// <summary>
        /// <see cref="gcgv::AwsNodePoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AwsNodePoolName AwsNodePoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AwsNodePoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAwsOpenIdConfigRequest
    {
        /// <summary>
        /// <see cref="AwsClusterName"/>-typed view over the <see cref="AwsCluster"/> resource name property.
        /// </summary>
        public AwsClusterName AwsClusterAsAwsClusterName
        {
            get => string.IsNullOrEmpty(AwsCluster) ? null : AwsClusterName.Parse(AwsCluster, allowUnparsed: true);
            set => AwsCluster = value?.ToString() ?? "";
        }
    }

    public partial class GetAwsJsonWebKeysRequest
    {
        /// <summary>
        /// <see cref="AwsClusterName"/>-typed view over the <see cref="AwsCluster"/> resource name property.
        /// </summary>
        public AwsClusterName AwsClusterAsAwsClusterName
        {
            get => string.IsNullOrEmpty(AwsCluster) ? null : AwsClusterName.Parse(AwsCluster, allowUnparsed: true);
            set => AwsCluster = value?.ToString() ?? "";
        }
    }

    public partial class GetAwsServerConfigRequest
    {
        /// <summary>
        /// <see cref="gcgv::AwsServerConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AwsServerConfigName AwsServerConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AwsServerConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GenerateAwsAccessTokenRequest
    {
        /// <summary>
        /// <see cref="AwsClusterName"/>-typed view over the <see cref="AwsCluster"/> resource name property.
        /// </summary>
        public AwsClusterName AwsClusterAsAwsClusterName
        {
            get => string.IsNullOrEmpty(AwsCluster) ? null : AwsClusterName.Parse(AwsCluster, allowUnparsed: true);
            set => AwsCluster = value?.ToString() ?? "";
        }
    }

    public partial class GenerateAwsClusterAgentTokenRequest
    {
        /// <summary>
        /// <see cref="AwsClusterName"/>-typed view over the <see cref="AwsCluster"/> resource name property.
        /// </summary>
        public AwsClusterName AwsClusterAsAwsClusterName
        {
            get => string.IsNullOrEmpty(AwsCluster) ? null : AwsClusterName.Parse(AwsCluster, allowUnparsed: true);
            set => AwsCluster = value?.ToString() ?? "";
        }
    }
}
