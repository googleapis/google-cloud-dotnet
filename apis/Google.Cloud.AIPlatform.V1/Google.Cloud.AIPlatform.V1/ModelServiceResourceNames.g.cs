// Copyright 2021 Google LLC
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
