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
using gcvv = Google.Cloud.VisionAI.V1;

namespace Google.Cloud.VisionAI.V1
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
        /// <see cref="gcvv::ClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ClusterName ClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ClusterName.Parse(Name, allowUnparsed: true);
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
        /// <see cref="gcvv::ClusterName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::ClusterName ClusterName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::ClusterName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListStreamsRequest
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

    public partial class GetStreamRequest
    {
        /// <summary>
        /// <see cref="gcvv::StreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::StreamName StreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::StreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateStreamRequest
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

    public partial class DeleteStreamRequest
    {
        /// <summary>
        /// <see cref="gcvv::StreamName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::StreamName StreamName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::StreamName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEventsRequest
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

    public partial class GetEventRequest
    {
        /// <summary>
        /// <see cref="gcvv::EventName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::EventName EventName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::EventName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateEventRequest
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

    public partial class DeleteEventRequest
    {
        /// <summary>
        /// <see cref="gcvv::EventName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::EventName EventName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::EventName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSeriesRequest
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

    public partial class GetSeriesRequest
    {
        /// <summary>
        /// <see cref="gcvv::SeriesName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::SeriesName SeriesName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::SeriesName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSeriesRequest
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

    public partial class DeleteSeriesRequest
    {
        /// <summary>
        /// <see cref="gcvv::SeriesName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcvv::SeriesName SeriesName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcvv::SeriesName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MaterializeChannelRequest
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
}
