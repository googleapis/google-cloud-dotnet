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
using gcmv = Google.Cloud.ManagedKafka.V1;

namespace Google.Cloud.ManagedKafka.V1
{
    public partial class ListClustersRequest
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

    public partial class GetClusterRequest
    {
        /// <summary>
        /// <see cref="gcmv::ClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ClusterName ClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateClusterRequest
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

    public partial class DeleteClusterRequest
    {
        /// <summary>
        /// <see cref="gcmv::ClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ClusterName ClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTopicsRequest
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

    public partial class GetTopicRequest
    {
        /// <summary>
        /// <see cref="gcmv::TopicName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::TopicName TopicName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::TopicName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateTopicRequest
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

    public partial class DeleteTopicRequest
    {
        /// <summary>
        /// <see cref="gcmv::TopicName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::TopicName TopicName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::TopicName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListConsumerGroupsRequest
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

    public partial class GetConsumerGroupRequest
    {
        /// <summary>
        /// <see cref="gcmv::ConsumerGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ConsumerGroupName ConsumerGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ConsumerGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteConsumerGroupRequest
    {
        /// <summary>
        /// <see cref="gcmv::ConsumerGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcmv::ConsumerGroupName ConsumerGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcmv::ConsumerGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
