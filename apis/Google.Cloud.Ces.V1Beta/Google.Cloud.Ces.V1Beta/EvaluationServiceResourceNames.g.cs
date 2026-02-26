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
using gax = Google.Api.Gax;
using gccv = Google.Cloud.Ces.V1Beta;

namespace Google.Cloud.Ces.V1Beta
{
    public partial class RunEvaluationResponse
    {
        /// <summary>
        /// <see cref="EvaluationRunName"/>-typed view over the <see cref="EvaluationRun"/> resource name property.
        /// </summary>
        public EvaluationRunName EvaluationRunAsEvaluationRunName
        {
            get => string.IsNullOrEmpty(EvaluationRun) ? null : EvaluationRunName.Parse(EvaluationRun, allowUnparsed: true);
            set => EvaluationRun = value?.ToString() ?? "";
        }
    }

    public partial class RunEvaluationOperationMetadata
    {
        /// <summary>
        /// <see cref="EvaluationName"/>-typed view over the <see cref="Evaluations"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<EvaluationName> EvaluationsAsEvaluationNames
        {
            get => new gax::ResourceNameList<EvaluationName>(Evaluations, s => string.IsNullOrEmpty(s) ? null : EvaluationName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="EvaluationRunName"/>-typed view over the <see cref="EvaluationRun"/> resource name property.
        /// </summary>
        public EvaluationRunName EvaluationRunAsEvaluationRunName
        {
            get => string.IsNullOrEmpty(EvaluationRun) ? null : EvaluationRunName.Parse(EvaluationRun, allowUnparsed: true);
            set => EvaluationRun = value?.ToString() ?? "";
        }
    }

    public partial class CreateEvaluationRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GenerateEvaluationRequest
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

    public partial class ImportEvaluationsRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateEvaluationDatasetRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEvaluationRequest
    {
        /// <summary>
        /// <see cref="gccv::EvaluationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::EvaluationName EvaluationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::EvaluationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEvaluationResultRequest
    {
        /// <summary>
        /// <see cref="gccv::EvaluationResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::EvaluationResultName EvaluationResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::EvaluationResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEvaluationDatasetRequest
    {
        /// <summary>
        /// <see cref="gccv::EvaluationDatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::EvaluationDatasetName EvaluationDatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::EvaluationDatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEvaluationRunRequest
    {
        /// <summary>
        /// <see cref="gccv::EvaluationRunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::EvaluationRunName EvaluationRunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::EvaluationRunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetEvaluationRequest
    {
        /// <summary>
        /// <see cref="gccv::EvaluationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::EvaluationName EvaluationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::EvaluationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetEvaluationResultRequest
    {
        /// <summary>
        /// <see cref="gccv::EvaluationResultName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::EvaluationResultName EvaluationResultName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::EvaluationResultName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetEvaluationDatasetRequest
    {
        /// <summary>
        /// <see cref="gccv::EvaluationDatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::EvaluationDatasetName EvaluationDatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::EvaluationDatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetEvaluationRunRequest
    {
        /// <summary>
        /// <see cref="gccv::EvaluationRunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::EvaluationRunName EvaluationRunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::EvaluationRunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEvaluationsRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListEvaluationResultsRequest
    {
        /// <summary>
        /// <see cref="EvaluationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public EvaluationName ParentAsEvaluationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : EvaluationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListEvaluationDatasetsRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class ListEvaluationRunsRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateScheduledEvaluationRunRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetScheduledEvaluationRunRequest
    {
        /// <summary>
        /// <see cref="gccv::ScheduledEvaluationRunName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::ScheduledEvaluationRunName ScheduledEvaluationRunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ScheduledEvaluationRunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListScheduledEvaluationRunsRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteScheduledEvaluationRunRequest
    {
        /// <summary>
        /// <see cref="gccv::ScheduledEvaluationRunName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gccv::ScheduledEvaluationRunName ScheduledEvaluationRunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::ScheduledEvaluationRunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class TestPersonaVoiceRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="App"/> resource name property.</summary>
        public AppName AppAsAppName
        {
            get => string.IsNullOrEmpty(App) ? null : AppName.Parse(App, allowUnparsed: true);
            set => App = value?.ToString() ?? "";
        }
    }

    public partial class UploadEvaluationAudioRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="App"/> resource name property.</summary>
        public AppName AppAsAppName
        {
            get => string.IsNullOrEmpty(App) ? null : AppName.Parse(App, allowUnparsed: true);
            set => App = value?.ToString() ?? "";
        }
    }

    public partial class CreateEvaluationExpectationRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEvaluationExpectationRequest
    {
        /// <summary>
        /// <see cref="gccv::EvaluationExpectationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::EvaluationExpectationName EvaluationExpectationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::EvaluationExpectationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetEvaluationExpectationRequest
    {
        /// <summary>
        /// <see cref="gccv::EvaluationExpectationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gccv::EvaluationExpectationName EvaluationExpectationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gccv::EvaluationExpectationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEvaluationExpectationsRequest
    {
        /// <summary><see cref="AppName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public AppName ParentAsAppName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AppName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
