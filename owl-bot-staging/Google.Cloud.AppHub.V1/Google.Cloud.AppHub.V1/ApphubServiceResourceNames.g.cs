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
using gcav = Google.Cloud.AppHub.V1;

namespace Google.Cloud.AppHub.V1
{
    public partial class LookupServiceProjectAttachmentRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::LocationName LocationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::LocationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListServiceProjectAttachmentsRequest
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

    public partial class CreateServiceProjectAttachmentRequest
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

    public partial class GetServiceProjectAttachmentRequest
    {
        /// <summary>
        /// <see cref="gcav::ServiceProjectAttachmentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::ServiceProjectAttachmentName ServiceProjectAttachmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ServiceProjectAttachmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteServiceProjectAttachmentRequest
    {
        /// <summary>
        /// <see cref="gcav::ServiceProjectAttachmentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::ServiceProjectAttachmentName ServiceProjectAttachmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ServiceProjectAttachmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DetachServiceProjectAttachmentRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagr::LocationName LocationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagr::LocationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListServicesRequest
    {
        /// <summary>
        /// <see cref="ApplicationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApplicationName ParentAsApplicationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApplicationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListDiscoveredServicesRequest
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

    public partial class CreateServiceRequest
    {
        /// <summary>
        /// <see cref="ApplicationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApplicationName ParentAsApplicationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApplicationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetServiceRequest
    {
        /// <summary>
        /// <see cref="gcav::ServiceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ServiceName ServiceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ServiceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDiscoveredServiceRequest
    {
        /// <summary>
        /// <see cref="gcav::DiscoveredServiceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DiscoveredServiceName DiscoveredServiceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DiscoveredServiceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class LookupDiscoveredServiceRequest
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

    public partial class DeleteServiceRequest
    {
        /// <summary>
        /// <see cref="gcav::ServiceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ServiceName ServiceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ServiceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListApplicationsRequest
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

    public partial class CreateApplicationRequest
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

    public partial class GetApplicationRequest
    {
        /// <summary>
        /// <see cref="gcav::ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApplicationName ApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteApplicationRequest
    {
        /// <summary>
        /// <see cref="gcav::ApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ApplicationName ApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListWorkloadsRequest
    {
        /// <summary>
        /// <see cref="ApplicationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApplicationName ParentAsApplicationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApplicationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListDiscoveredWorkloadsRequest
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

    public partial class CreateWorkloadRequest
    {
        /// <summary>
        /// <see cref="ApplicationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ApplicationName ParentAsApplicationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ApplicationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetWorkloadRequest
    {
        /// <summary>
        /// <see cref="gcav::WorkloadName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::WorkloadName WorkloadName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::WorkloadName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetDiscoveredWorkloadRequest
    {
        /// <summary>
        /// <see cref="gcav::DiscoveredWorkloadName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DiscoveredWorkloadName DiscoveredWorkloadName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DiscoveredWorkloadName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class LookupDiscoveredWorkloadRequest
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

    public partial class DeleteWorkloadRequest
    {
        /// <summary>
        /// <see cref="gcav::WorkloadName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::WorkloadName WorkloadName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::WorkloadName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
