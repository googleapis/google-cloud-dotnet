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
    public partial class CreateIndexEndpointRequest
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

    public partial class GetIndexEndpointRequest
    {
        /// <summary>
        /// <see cref="gcav::IndexEndpointName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::IndexEndpointName IndexEndpointName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::IndexEndpointName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListIndexEndpointsRequest
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

    public partial class DeleteIndexEndpointRequest
    {
        /// <summary>
        /// <see cref="gcav::IndexEndpointName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::IndexEndpointName IndexEndpointName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::IndexEndpointName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeployIndexRequest
    {
        /// <summary>
        /// <see cref="IndexEndpointName"/>-typed view over the <see cref="IndexEndpoint"/> resource name property.
        /// </summary>
        public IndexEndpointName IndexEndpointAsIndexEndpointName
        {
            get => string.IsNullOrEmpty(IndexEndpoint) ? null : IndexEndpointName.Parse(IndexEndpoint, allowUnparsed: true);
            set => IndexEndpoint = value?.ToString() ?? "";
        }
    }

    public partial class UndeployIndexRequest
    {
        /// <summary>
        /// <see cref="IndexEndpointName"/>-typed view over the <see cref="IndexEndpoint"/> resource name property.
        /// </summary>
        public IndexEndpointName IndexEndpointAsIndexEndpointName
        {
            get => string.IsNullOrEmpty(IndexEndpoint) ? null : IndexEndpointName.Parse(IndexEndpoint, allowUnparsed: true);
            set => IndexEndpoint = value?.ToString() ?? "";
        }
    }

    public partial class MutateDeployedIndexRequest
    {
        /// <summary>
        /// <see cref="IndexEndpointName"/>-typed view over the <see cref="IndexEndpoint"/> resource name property.
        /// </summary>
        public IndexEndpointName IndexEndpointAsIndexEndpointName
        {
            get => string.IsNullOrEmpty(IndexEndpoint) ? null : IndexEndpointName.Parse(IndexEndpoint, allowUnparsed: true);
            set => IndexEndpoint = value?.ToString() ?? "";
        }
    }
}
