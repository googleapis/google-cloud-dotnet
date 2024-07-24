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
    public partial class CreateAzureClusterRequest
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

    public partial class GetAzureClusterRequest
    {
        /// <summary>
        /// <see cref="gcgv::AzureClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AzureClusterName AzureClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AzureClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAzureClustersRequest
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

    public partial class DeleteAzureClusterRequest
    {
        /// <summary>
        /// <see cref="gcgv::AzureClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AzureClusterName AzureClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AzureClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAzureNodePoolRequest
    {
        /// <summary>
        /// <see cref="AzureClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AzureClusterName ParentAsAzureClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AzureClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAzureNodePoolRequest
    {
        /// <summary>
        /// <see cref="gcgv::AzureNodePoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AzureNodePoolName AzureNodePoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AzureNodePoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAzureNodePoolsRequest
    {
        /// <summary>
        /// <see cref="AzureClusterName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AzureClusterName ParentAsAzureClusterName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AzureClusterName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAzureNodePoolRequest
    {
        /// <summary>
        /// <see cref="gcgv::AzureNodePoolName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AzureNodePoolName AzureNodePoolName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AzureNodePoolName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAzureOpenIdConfigRequest
    {
        /// <summary>
        /// <see cref="AzureClusterName"/>-typed view over the <see cref="AzureCluster"/> resource name property.
        /// </summary>
        public AzureClusterName AzureClusterAsAzureClusterName
        {
            get => string.IsNullOrEmpty(AzureCluster) ? null : AzureClusterName.Parse(AzureCluster, allowUnparsed: true);
            set => AzureCluster = value?.ToString() ?? "";
        }
    }

    public partial class GetAzureJsonWebKeysRequest
    {
        /// <summary>
        /// <see cref="AzureClusterName"/>-typed view over the <see cref="AzureCluster"/> resource name property.
        /// </summary>
        public AzureClusterName AzureClusterAsAzureClusterName
        {
            get => string.IsNullOrEmpty(AzureCluster) ? null : AzureClusterName.Parse(AzureCluster, allowUnparsed: true);
            set => AzureCluster = value?.ToString() ?? "";
        }
    }

    public partial class GetAzureServerConfigRequest
    {
        /// <summary>
        /// <see cref="gcgv::AzureServerConfigName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AzureServerConfigName AzureServerConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AzureServerConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateAzureClientRequest
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

    public partial class GetAzureClientRequest
    {
        /// <summary>
        /// <see cref="gcgv::AzureClientName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AzureClientName AzureClientName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AzureClientName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAzureClientsRequest
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

    public partial class DeleteAzureClientRequest
    {
        /// <summary>
        /// <see cref="gcgv::AzureClientName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcgv::AzureClientName AzureClientName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcgv::AzureClientName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GenerateAzureAccessTokenRequest
    {
        /// <summary>
        /// <see cref="AzureClusterName"/>-typed view over the <see cref="AzureCluster"/> resource name property.
        /// </summary>
        public AzureClusterName AzureClusterAsAzureClusterName
        {
            get => string.IsNullOrEmpty(AzureCluster) ? null : AzureClusterName.Parse(AzureCluster, allowUnparsed: true);
            set => AzureCluster = value?.ToString() ?? "";
        }
    }

    public partial class GenerateAzureClusterAgentTokenRequest
    {
        /// <summary>
        /// <see cref="AzureClusterName"/>-typed view over the <see cref="AzureCluster"/> resource name property.
        /// </summary>
        public AzureClusterName AzureClusterAsAzureClusterName
        {
            get => string.IsNullOrEmpty(AzureCluster) ? null : AzureClusterName.Parse(AzureCluster, allowUnparsed: true);
            set => AzureCluster = value?.ToString() ?? "";
        }
    }
}
