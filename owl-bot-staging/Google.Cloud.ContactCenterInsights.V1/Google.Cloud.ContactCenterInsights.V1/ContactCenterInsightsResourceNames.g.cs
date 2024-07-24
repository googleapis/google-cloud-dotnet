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
using gccv = Google.Cloud.ContactCenterInsights.V1;

namespace Google.Cloud.ContactCenterInsights.V1
{
    public partial class CalculateStatsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Location"/> resource name property.
        /// </summary>
        public gagr::LocationName LocationAsLocationName
        {
            get => string.IsNullOrEmpty(Location) ? null : gagr::LocationName.Parse(Location, allowUnparsed: true);
            set => Location = value?.ToString() ?? "";
        }
    }

    public partial class CreateAnalysisOperationMetadata
    {
        /// <summary>
        /// <see cref="ConversationName"/>-typed view over the <see cref="Conversation"/> resource name property.
        /// </summary>
        public ConversationName ConversationAsConversationName
        {
            get => string.IsNullOrEmpty(Conversation) ? null : ConversationName.Parse(Conversation, allowUnparsed: true);
            set => Conversation = value?.ToString() ?? "";
        }
    }

    public partial class CreateConversationRequest
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

    public partial class UploadConversationRequest
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

    public partial class ListConversationsRequest
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

    public partial class GetConversationRequest
    {
        /// <summary>
        /// <see cref="gccv::ConversationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConversationName ConversationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConversationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteConversationRequest
    {
        /// <summary>
        /// <see cref="gccv::ConversationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ConversationName ConversationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ConversationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class IngestConversationsRequest
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

    public partial class CreateAnalysisRequest
    {
        /// <summary>
        /// <see cref="ConversationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ConversationName ParentAsConversationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ConversationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListAnalysesRequest
    {
        /// <summary>
        /// <see cref="ConversationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ConversationName ParentAsConversationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ConversationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAnalysisRequest
    {
        /// <summary>
        /// <see cref="gccv::AnalysisName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::AnalysisName AnalysisName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::AnalysisName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAnalysisRequest
    {
        /// <summary>
        /// <see cref="gccv::AnalysisName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::AnalysisName AnalysisName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::AnalysisName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BulkAnalyzeConversationsRequest
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

    public partial class BulkDeleteConversationsRequest
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

    public partial class ExportInsightsDataRequest
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

    public partial class CreateIssueModelRequest
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

    public partial class ListIssueModelsRequest
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

    public partial class GetIssueModelRequest
    {
        /// <summary>
        /// <see cref="gccv::IssueModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::IssueModelName IssueModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::IssueModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteIssueModelRequest
    {
        /// <summary>
        /// <see cref="gccv::IssueModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::IssueModelName IssueModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::IssueModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeployIssueModelRequest
    {
        /// <summary>
        /// <see cref="gccv::IssueModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::IssueModelName IssueModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::IssueModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UndeployIssueModelRequest
    {
        /// <summary>
        /// <see cref="gccv::IssueModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::IssueModelName IssueModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::IssueModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetIssueRequest
    {
        /// <summary>
        /// <see cref="gccv::IssueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::IssueName IssueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::IssueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListIssuesRequest
    {
        /// <summary>
        /// <see cref="IssueModelName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public IssueModelName ParentAsIssueModelName
        {
            get => string.IsNullOrEmpty(Parent) ? null : IssueModelName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteIssueRequest
    {
        /// <summary>
        /// <see cref="gccv::IssueName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::IssueName IssueName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::IssueName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CalculateIssueModelStatsRequest
    {
        /// <summary>
        /// <see cref="IssueModelName"/>-typed view over the <see cref="IssueModel"/> resource name property.
        /// </summary>
        public IssueModelName IssueModelAsIssueModelName
        {
            get => string.IsNullOrEmpty(IssueModel) ? null : IssueModelName.Parse(IssueModel, allowUnparsed: true);
            set => IssueModel = value?.ToString() ?? "";
        }
    }

    public partial class CreatePhraseMatcherRequest
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

    public partial class ListPhraseMatchersRequest
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

    public partial class GetPhraseMatcherRequest
    {
        /// <summary>
        /// <see cref="gccv::PhraseMatcherName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::PhraseMatcherName PhraseMatcherName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::PhraseMatcherName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeletePhraseMatcherRequest
    {
        /// <summary>
        /// <see cref="gccv::PhraseMatcherName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::PhraseMatcherName PhraseMatcherName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::PhraseMatcherName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetSettingsRequest
    {
        /// <summary>
        /// <see cref="gccv::SettingsName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::SettingsName SettingsName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::SettingsName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateViewRequest
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

    public partial class GetViewRequest
    {
        /// <summary>
        /// <see cref="gccv::ViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ViewName ViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListViewsRequest
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

    public partial class DeleteViewRequest
    {
        /// <summary>
        /// <see cref="gccv::ViewName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::ViewName ViewName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ViewName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
