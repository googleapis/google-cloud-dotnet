// Copyright 2026 Google LLC
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
using gcav = Google.Cloud.AgentRegistry.V1;

namespace Google.Cloud.AgentRegistry.V1
{
    public partial class ListAgentsRequest
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

    public partial class SearchAgentsRequest
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

    public partial class GetAgentRequest
    {
        /// <summary>
        /// <see cref="gcav::AgentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::AgentName AgentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AgentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAiApplicationAgentRequest
    {
        /// <summary>
        /// <see cref="gcav::AgentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::AgentName AgentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AgentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAiApplicationAgentsRequest
    {
        /// <summary>
        /// <see cref="AiApplicationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AiApplicationName ParentAsAiApplicationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AiApplicationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListEndpointsRequest
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

    public partial class GetEndpointRequest
    {
        /// <summary>
        /// <see cref="gcav::EndpointName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::EndpointName EndpointName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::EndpointName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAiApplicationEndpointRequest
    {
        /// <summary>
        /// <see cref="gcav::EndpointName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::EndpointName EndpointName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::EndpointName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAiApplicationEndpointsRequest
    {
        /// <summary>
        /// <see cref="AiApplicationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AiApplicationName ParentAsAiApplicationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AiApplicationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListMcpServersRequest
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

    public partial class SearchMcpServersRequest
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

    public partial class GetMcpServerRequest
    {
        /// <summary>
        /// <see cref="gcav::McpServerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::McpServerName McpServerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::McpServerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetAiApplicationMcpServerRequest
    {
        /// <summary>
        /// <see cref="gcav::McpServerName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::McpServerName McpServerName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::McpServerName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAiApplicationMcpServersRequest
    {
        /// <summary>
        /// <see cref="AiApplicationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AiApplicationName ParentAsAiApplicationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AiApplicationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListServicesRequest
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

    public partial class CreateServiceRequest
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

    public partial class FetchAvailableBindingsRequest
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

    public partial class ListBindingsRequest
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

    public partial class GetBindingRequest
    {
        /// <summary>
        /// <see cref="gcav::BindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::BindingName BindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::BindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateBindingRequest
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

    public partial class DeleteBindingRequest
    {
        /// <summary>
        /// <see cref="gcav::BindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::BindingName BindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::BindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateSkillRequest
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

    public partial class GetSkillRequest
    {
        /// <summary>
        /// <see cref="gcav::SkillName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::SkillName SkillName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::SkillName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSkillRequest
    {
        /// <summary>
        /// <see cref="gcav::SkillName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::SkillName SkillName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::SkillName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSkillsRequest
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

    public partial class SearchSkillsRequest
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

    public partial class CreateSkillRevisionRequest
    {
        /// <summary><see cref="SkillName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SkillName ParentAsSkillName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SkillName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetSkillRevisionRequest
    {
        /// <summary>
        /// <see cref="gcav::SkillRevisionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::SkillRevisionName SkillRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::SkillRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteSkillRevisionRequest
    {
        /// <summary>
        /// <see cref="gcav::SkillRevisionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::SkillRevisionName SkillRevisionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::SkillRevisionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListSkillRevisionsRequest
    {
        /// <summary><see cref="SkillName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public SkillName ParentAsSkillName
        {
            get => string.IsNullOrEmpty(Parent) ? null : SkillName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetPublisherRequest
    {
        /// <summary>
        /// <see cref="gcav::PublisherName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PublisherName PublisherName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PublisherName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPublishersRequest
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

    public partial class GetAiApplicationRequest
    {
        /// <summary>
        /// <see cref="gcav::AiApplicationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::AiApplicationName AiApplicationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::AiApplicationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAiApplicationsRequest
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

    public partial class ListFindingsRequest
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

    public partial class GetFindingRequest
    {
        /// <summary>
        /// <see cref="gcav::FindingName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::FindingName FindingName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::FindingName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetSkillEncryptionSpecRequest
    {
        /// <summary>
        /// <see cref="gcav::SkillEncryptionSpecName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::SkillEncryptionSpecName SkillEncryptionSpecName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::SkillEncryptionSpecName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
