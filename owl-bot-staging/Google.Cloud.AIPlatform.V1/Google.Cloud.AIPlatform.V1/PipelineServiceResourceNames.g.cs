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
using gax = Google.Api.Gax;
using gcav = Google.Cloud.AIPlatform.V1;

namespace Google.Cloud.AIPlatform.V1
{
    public partial class CreateTrainingPipelineRequest
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

    public partial class GetTrainingPipelineRequest
    {
        /// <summary>
        /// <see cref="gcav::TrainingPipelineName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TrainingPipelineName TrainingPipelineName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TrainingPipelineName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTrainingPipelinesRequest
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

    public partial class DeleteTrainingPipelineRequest
    {
        /// <summary>
        /// <see cref="gcav::TrainingPipelineName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TrainingPipelineName TrainingPipelineName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TrainingPipelineName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CancelTrainingPipelineRequest
    {
        /// <summary>
        /// <see cref="gcav::TrainingPipelineName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TrainingPipelineName TrainingPipelineName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TrainingPipelineName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreatePipelineJobRequest
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

    public partial class GetPipelineJobRequest
    {
        /// <summary>
        /// <see cref="gcav::PipelineJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PipelineJobName PipelineJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PipelineJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListPipelineJobsRequest
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

    public partial class DeletePipelineJobRequest
    {
        /// <summary>
        /// <see cref="gcav::PipelineJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PipelineJobName PipelineJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PipelineJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchDeletePipelineJobsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="PipelineJobName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<PipelineJobName> PipelineJobNames
        {
            get => new gax::ResourceNameList<PipelineJobName>(Names, s => string.IsNullOrEmpty(s) ? null : PipelineJobName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class CancelPipelineJobRequest
    {
        /// <summary>
        /// <see cref="gcav::PipelineJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::PipelineJobName PipelineJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::PipelineJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchCancelPipelineJobsRequest
    {
        /// <summary>
        /// <see cref="gagr::LocationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::LocationName ParentAsLocationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::LocationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="PipelineJobName"/>-typed view over the <see cref="Names"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<PipelineJobName> PipelineJobNames
        {
            get => new gax::ResourceNameList<PipelineJobName>(Names, s => string.IsNullOrEmpty(s) ? null : PipelineJobName.Parse(s, allowUnparsed: true));
        }
    }
}
