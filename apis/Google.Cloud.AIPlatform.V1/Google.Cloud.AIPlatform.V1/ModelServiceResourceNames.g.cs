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
using gcav = Google.Cloud.AIPlatform.V1;

namespace Google.Cloud.AIPlatform.V1
{
    public partial class UploadModelRequest
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

    public partial class UploadModelResponse
    {
        /// <summary><see cref="ModelName"/>-typed view over the <see cref="Model"/> resource name property.</summary>
        public ModelName ModelAsModelName
        {
            get => string.IsNullOrEmpty(Model) ? null : ModelName.Parse(Model, allowUnparsed: true);
            set => Model = value?.ToString() ?? "";
        }
    }

    public partial class GetModelRequest
    {
        /// <summary>
        /// <see cref="gcav::ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ModelName ModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListModelsRequest
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

    public partial class ListModelVersionsRequest
    {
        /// <summary>
        /// <see cref="gcav::ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ModelName ModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class UpdateExplanationDatasetRequest
    {
        /// <summary><see cref="ModelName"/>-typed view over the <see cref="Model"/> resource name property.</summary>
        public ModelName ModelAsModelName
        {
            get => string.IsNullOrEmpty(Model) ? null : ModelName.Parse(Model, allowUnparsed: true);
            set => Model = value?.ToString() ?? "";
        }
    }

    public partial class DeleteModelRequest
    {
        /// <summary>
        /// <see cref="gcav::ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ModelName ModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteModelVersionRequest
    {
        /// <summary>
        /// <see cref="gcav::ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ModelName ModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class MergeVersionAliasesRequest
    {
        /// <summary>
        /// <see cref="gcav::ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ModelName ModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExportModelRequest
    {
        /// <summary>
        /// <see cref="gcav::ModelName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ModelName ModelName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ModelName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CopyModelRequest
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
        /// <see cref="ModelName"/>-typed view over the <see cref="SourceModel"/> resource name property.
        /// </summary>
        public ModelName SourceModelAsModelName
        {
            get => string.IsNullOrEmpty(SourceModel) ? null : ModelName.Parse(SourceModel, allowUnparsed: true);
            set => SourceModel = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ModelName"/>-typed view over the <see cref="ParentModel"/> resource name property.
        /// </summary>
        public ModelName ParentModelAsModelName
        {
            get => string.IsNullOrEmpty(ParentModel) ? null : ModelName.Parse(ParentModel, allowUnparsed: true);
            set => ParentModel = value?.ToString() ?? "";
        }
    }

    public partial class CopyModelResponse
    {
        /// <summary><see cref="ModelName"/>-typed view over the <see cref="Model"/> resource name property.</summary>
        public ModelName ModelAsModelName
        {
            get => string.IsNullOrEmpty(Model) ? null : ModelName.Parse(Model, allowUnparsed: true);
            set => Model = value?.ToString() ?? "";
        }
    }

    public partial class ImportModelEvaluationRequest
    {
        /// <summary><see cref="ModelName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ModelName ParentAsModelName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ModelName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchImportModelEvaluationSlicesRequest
    {
        /// <summary>
        /// <see cref="ModelEvaluationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ModelEvaluationName ParentAsModelEvaluationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ModelEvaluationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class BatchImportEvaluatedAnnotationsRequest
    {
        /// <summary>
        /// <see cref="ModelEvaluationSliceName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ModelEvaluationSliceName ParentAsModelEvaluationSliceName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ModelEvaluationSliceName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetModelEvaluationRequest
    {
        /// <summary>
        /// <see cref="gcav::ModelEvaluationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ModelEvaluationName ModelEvaluationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ModelEvaluationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListModelEvaluationsRequest
    {
        /// <summary><see cref="ModelName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public ModelName ParentAsModelName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ModelName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetModelEvaluationSliceRequest
    {
        /// <summary>
        /// <see cref="gcav::ModelEvaluationSliceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::ModelEvaluationSliceName ModelEvaluationSliceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ModelEvaluationSliceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListModelEvaluationSlicesRequest
    {
        /// <summary>
        /// <see cref="ModelEvaluationName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public ModelEvaluationName ParentAsModelEvaluationName
        {
            get => string.IsNullOrEmpty(Parent) ? null : ModelEvaluationName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
