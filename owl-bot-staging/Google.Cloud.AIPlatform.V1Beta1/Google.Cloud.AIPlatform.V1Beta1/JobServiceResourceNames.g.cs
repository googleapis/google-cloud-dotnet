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
using gcav = Google.Cloud.AIPlatform.V1Beta1;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    public partial class CreateCustomJobRequest
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

    public partial class GetCustomJobRequest
    {
        /// <summary>
        /// <see cref="gcav::CustomJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::CustomJobName CustomJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::CustomJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListCustomJobsRequest
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

    public partial class DeleteCustomJobRequest
    {
        /// <summary>
        /// <see cref="gcav::CustomJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::CustomJobName CustomJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::CustomJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CancelCustomJobRequest
    {
        /// <summary>
        /// <see cref="gcav::CustomJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::CustomJobName CustomJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::CustomJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateDataLabelingJobRequest
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

    public partial class GetDataLabelingJobRequest
    {
        /// <summary>
        /// <see cref="gcav::DataLabelingJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DataLabelingJobName DataLabelingJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DataLabelingJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListDataLabelingJobsRequest
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

    public partial class DeleteDataLabelingJobRequest
    {
        /// <summary>
        /// <see cref="gcav::DataLabelingJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DataLabelingJobName DataLabelingJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DataLabelingJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CancelDataLabelingJobRequest
    {
        /// <summary>
        /// <see cref="gcav::DataLabelingJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::DataLabelingJobName DataLabelingJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::DataLabelingJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateHyperparameterTuningJobRequest
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

    public partial class GetHyperparameterTuningJobRequest
    {
        /// <summary>
        /// <see cref="gcav::HyperparameterTuningJobName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::HyperparameterTuningJobName HyperparameterTuningJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::HyperparameterTuningJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListHyperparameterTuningJobsRequest
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

    public partial class DeleteHyperparameterTuningJobRequest
    {
        /// <summary>
        /// <see cref="gcav::HyperparameterTuningJobName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::HyperparameterTuningJobName HyperparameterTuningJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::HyperparameterTuningJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CancelHyperparameterTuningJobRequest
    {
        /// <summary>
        /// <see cref="gcav::HyperparameterTuningJobName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::HyperparameterTuningJobName HyperparameterTuningJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::HyperparameterTuningJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateNasJobRequest
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

    public partial class GetNasJobRequest
    {
        /// <summary>
        /// <see cref="gcav::NasJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::NasJobName NasJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NasJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListNasJobsRequest
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

    public partial class DeleteNasJobRequest
    {
        /// <summary>
        /// <see cref="gcav::NasJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::NasJobName NasJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NasJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CancelNasJobRequest
    {
        /// <summary>
        /// <see cref="gcav::NasJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::NasJobName NasJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NasJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class GetNasTrialDetailRequest
    {
        /// <summary>
        /// <see cref="gcav::NasTrialDetailName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::NasTrialDetailName NasTrialDetailName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::NasTrialDetailName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListNasTrialDetailsRequest
    {
        /// <summary><see cref="NasJobName"/>-typed view over the <see cref="Parent"/> resource name property.</summary>
        public NasJobName ParentAsNasJobName
        {
            get => string.IsNullOrEmpty(Parent) ? null : NasJobName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateBatchPredictionJobRequest
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

    public partial class GetBatchPredictionJobRequest
    {
        /// <summary>
        /// <see cref="gcav::BatchPredictionJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::BatchPredictionJobName BatchPredictionJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::BatchPredictionJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListBatchPredictionJobsRequest
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

    public partial class DeleteBatchPredictionJobRequest
    {
        /// <summary>
        /// <see cref="gcav::BatchPredictionJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::BatchPredictionJobName BatchPredictionJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::BatchPredictionJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CancelBatchPredictionJobRequest
    {
        /// <summary>
        /// <see cref="gcav::BatchPredictionJobName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::BatchPredictionJobName BatchPredictionJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::BatchPredictionJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class CreateModelDeploymentMonitoringJobRequest
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

    public partial class SearchModelDeploymentMonitoringStatsAnomaliesRequest
    {
        /// <summary>
        /// <see cref="ModelDeploymentMonitoringJobName"/>-typed view over the
        /// <see cref="ModelDeploymentMonitoringJob"/> resource name property.
        /// </summary>
        public ModelDeploymentMonitoringJobName ModelDeploymentMonitoringJobAsModelDeploymentMonitoringJobName
        {
            get => string.IsNullOrEmpty(ModelDeploymentMonitoringJob) ? null : ModelDeploymentMonitoringJobName.Parse(ModelDeploymentMonitoringJob, allowUnparsed: true);
            set => ModelDeploymentMonitoringJob = value?.ToString() ?? "";
        }
    }

    public partial class GetModelDeploymentMonitoringJobRequest
    {
        /// <summary>
        /// <see cref="gcav::ModelDeploymentMonitoringJobName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::ModelDeploymentMonitoringJobName ModelDeploymentMonitoringJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ModelDeploymentMonitoringJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListModelDeploymentMonitoringJobsRequest
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

    public partial class DeleteModelDeploymentMonitoringJobRequest
    {
        /// <summary>
        /// <see cref="gcav::ModelDeploymentMonitoringJobName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::ModelDeploymentMonitoringJobName ModelDeploymentMonitoringJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ModelDeploymentMonitoringJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class PauseModelDeploymentMonitoringJobRequest
    {
        /// <summary>
        /// <see cref="gcav::ModelDeploymentMonitoringJobName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::ModelDeploymentMonitoringJobName ModelDeploymentMonitoringJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ModelDeploymentMonitoringJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ResumeModelDeploymentMonitoringJobRequest
    {
        /// <summary>
        /// <see cref="gcav::ModelDeploymentMonitoringJobName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        public gcav::ModelDeploymentMonitoringJobName ModelDeploymentMonitoringJobName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::ModelDeploymentMonitoringJobName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}
