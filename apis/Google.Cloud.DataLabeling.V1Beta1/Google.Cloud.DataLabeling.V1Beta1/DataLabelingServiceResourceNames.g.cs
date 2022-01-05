// Copyright 2022 Google LLC
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
using gcdv = Google.Cloud.DataLabeling.V1Beta1;

namespace Google.Cloud.DataLabeling.V1Beta1
{
    public partial class CreateDatasetRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetDatasetRequest
    {
        /// <summary>
        /// <see cref="gcdv::DatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DatasetName DatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDatasetsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteDatasetRequest
    {
        /// <summary>
        /// <see cref="gcdv::DatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DatasetName DatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ImportDataRequest
    {
        /// <summary>
        /// <see cref="gcdv::DatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DatasetName DatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ExportDataRequest
    {
        /// <summary>
        /// <see cref="gcdv::DatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DatasetName DatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AnnotatedDatasetName"/>-typed view over the <see cref="AnnotatedDataset"/> resource name
        /// property.
        /// </summary>
        public AnnotatedDatasetName AnnotatedDatasetAsAnnotatedDatasetName
        {
            get => string.IsNullOrEmpty(AnnotatedDataset) ? null : AnnotatedDatasetName.Parse(AnnotatedDataset, allowUnparsed: true);
            set => AnnotatedDataset = value?.ToString() ?? "";
        }
    }

    public partial class GetDataItemRequest
    {
        /// <summary>
        /// <see cref="gcdv::DataItemName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::DataItemName DataItemName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::DataItemName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataItemsRequest
    {
        /// <summary>
        /// <see cref="DatasetName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DatasetName ParentAsDatasetName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DatasetName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAnnotatedDatasetRequest
    {
        /// <summary>
        /// <see cref="gcdv::AnnotatedDatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AnnotatedDatasetName AnnotatedDatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AnnotatedDatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAnnotatedDatasetsRequest
    {
        /// <summary>
        /// <see cref="DatasetName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DatasetName ParentAsDatasetName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DatasetName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAnnotatedDatasetRequest
    {
        /// <summary>
        /// <see cref="gcdv::AnnotatedDatasetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AnnotatedDatasetName AnnotatedDatasetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AnnotatedDatasetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class LabelImageRequest
    {
        /// <summary>
        /// <see cref="DatasetName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DatasetName ParentAsDatasetName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DatasetName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class LabelVideoRequest
    {
        /// <summary>
        /// <see cref="DatasetName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DatasetName ParentAsDatasetName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DatasetName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class LabelTextRequest
    {
        /// <summary>
        /// <see cref="DatasetName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public DatasetName ParentAsDatasetName
        {
            get => string.IsNullOrEmpty(Parent) ? null : DatasetName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetExampleRequest
    {
        /// <summary>
        /// <see cref="gcdv::ExampleName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::ExampleName ExampleName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::ExampleName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListExamplesRequest
    {
        /// <summary>
        /// <see cref="AnnotatedDatasetName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public AnnotatedDatasetName ParentAsAnnotatedDatasetName
        {
            get => string.IsNullOrEmpty(Parent) ? null : AnnotatedDatasetName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateAnnotationSpecSetRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetAnnotationSpecSetRequest
    {
        /// <summary>
        /// <see cref="gcdv::AnnotationSpecSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AnnotationSpecSetName AnnotationSpecSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AnnotationSpecSetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListAnnotationSpecSetsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteAnnotationSpecSetRequest
    {
        /// <summary>
        /// <see cref="gcdv::AnnotationSpecSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::AnnotationSpecSetName AnnotationSpecSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::AnnotationSpecSetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateInstructionRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetInstructionRequest
    {
        /// <summary>
        /// <see cref="gcdv::InstructionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::InstructionName InstructionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::InstructionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteInstructionRequest
    {
        /// <summary>
        /// <see cref="gcdv::InstructionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::InstructionName InstructionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::InstructionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListInstructionsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetEvaluationRequest
    {
        /// <summary>
        /// <see cref="gcdv::EvaluationName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EvaluationName EvaluationName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EvaluationName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class SearchEvaluationsRequest
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

    public partial class SearchExampleComparisonsRequest
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

    public partial class CreateEvaluationJobRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetEvaluationJobRequest
    {
        /// <summary>
        /// <see cref="gcdv::EvaluationJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EvaluationJobName EvaluationJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EvaluationJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PauseEvaluationJobRequest
    {
        /// <summary>
        /// <see cref="gcdv::EvaluationJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EvaluationJobName EvaluationJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EvaluationJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ResumeEvaluationJobRequest
    {
        /// <summary>
        /// <see cref="gcdv::EvaluationJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EvaluationJobName EvaluationJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EvaluationJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class DeleteEvaluationJobRequest
    {
        /// <summary>
        /// <see cref="gcdv::EvaluationJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcdv::EvaluationJobName EvaluationJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcdv::EvaluationJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListEvaluationJobsRequest
    {
        /// <summary>
        /// <see cref="gagr::ProjectName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public gagr::ProjectName ParentAsProjectName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagr::ProjectName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}
