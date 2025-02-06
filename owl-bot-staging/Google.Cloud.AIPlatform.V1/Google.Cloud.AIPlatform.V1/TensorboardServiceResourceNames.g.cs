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
    public partial class CreateTensorboardRequest
    {
        /// <summary>
        /// <see cref="TensorboardName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TensorboardName ParentAsTensorboardName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TensorboardName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTensorboardRequest
    {
        /// <summary>
        /// <see cref="gcav::TensorboardName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TensorboardName TensorboardName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TensorboardName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTensorboardsRequest
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

    public partial class DeleteTensorboardRequest
    {
        /// <summary>
        /// <see cref="gcav::TensorboardName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TensorboardName TensorboardName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TensorboardName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReadTensorboardUsageRequest
    {
        /// <summary>
        /// <see cref="TensorboardName"/>-typed view over the <see cref="Tensorboard"/> resource name property.
        /// </summary>
        public TensorboardName TensorboardAsTensorboardName
        {
            get => string.IsNullOrEmpty(Tensorboard) ? null : TensorboardName.Parse(Tensorboard, allowUnparsed: true);
            set => Tensorboard = value?.ToString() ?? "";
        }
    }

    public partial class ReadTensorboardSizeRequest
    {
        /// <summary>
        /// <see cref="TensorboardName"/>-typed view over the <see cref="Tensorboard"/> resource name property.
        /// </summary>
        public TensorboardName TensorboardAsTensorboardName
        {
            get => string.IsNullOrEmpty(Tensorboard) ? null : TensorboardName.Parse(Tensorboard, allowUnparsed: true);
            set => Tensorboard = value?.ToString() ?? "";
        }
    }

    public partial class CreateTensorboardExperimentRequest
    {
        /// <summary>
        /// <see cref="TensorboardExperimentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TensorboardExperimentName ParentAsTensorboardExperimentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TensorboardExperimentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTensorboardExperimentRequest
    {
        /// <summary>
        /// <see cref="gcav::TensorboardExperimentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TensorboardExperimentName TensorboardExperimentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TensorboardExperimentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTensorboardExperimentsRequest
    {
        /// <summary>
        /// <see cref="TensorboardName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TensorboardName ParentAsTensorboardName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TensorboardName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTensorboardExperimentRequest
    {
        /// <summary>
        /// <see cref="gcav::TensorboardExperimentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TensorboardExperimentName TensorboardExperimentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TensorboardExperimentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchCreateTensorboardRunsRequest
    {
        /// <summary>
        /// <see cref="TensorboardExperimentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TensorboardExperimentName ParentAsTensorboardExperimentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TensorboardExperimentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateTensorboardRunRequest
    {
        /// <summary>
        /// <see cref="TensorboardRunName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TensorboardRunName ParentAsTensorboardRunName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TensorboardRunName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTensorboardRunRequest
    {
        /// <summary>
        /// <see cref="gcav::TensorboardRunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TensorboardRunName TensorboardRunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TensorboardRunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ReadTensorboardBlobDataRequest
    {
        /// <summary>
        /// <see cref="TensorboardTimeSeriesName"/>-typed view over the <see cref="TimeSeries"/> resource name property.
        /// </summary>
        public TensorboardTimeSeriesName TimeSeriesAsTensorboardTimeSeriesName
        {
            get => string.IsNullOrEmpty(TimeSeries) ? null : TensorboardTimeSeriesName.Parse(TimeSeries, allowUnparsed: true);
            set => TimeSeries = value?.ToString() ?? "";
        }
    }

    public partial class ListTensorboardRunsRequest
    {
        /// <summary>
        /// <see cref="TensorboardExperimentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TensorboardExperimentName ParentAsTensorboardExperimentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TensorboardExperimentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTensorboardRunRequest
    {
        /// <summary>
        /// <see cref="gcav::TensorboardRunName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TensorboardRunName TensorboardRunName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TensorboardRunName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchCreateTensorboardTimeSeriesRequest
    {
        /// <summary>
        /// <see cref="TensorboardExperimentName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TensorboardExperimentName ParentAsTensorboardExperimentName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TensorboardExperimentName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class CreateTensorboardTimeSeriesRequest
    {
        /// <summary>
        /// <see cref="TensorboardTimeSeriesName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TensorboardTimeSeriesName ParentAsTensorboardTimeSeriesName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TensorboardTimeSeriesName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class GetTensorboardTimeSeriesRequest
    {
        /// <summary>
        /// <see cref="gcav::TensorboardTimeSeriesName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TensorboardTimeSeriesName TensorboardTimeSeriesName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TensorboardTimeSeriesName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class ListTensorboardTimeSeriesRequest
    {
        /// <summary>
        /// <see cref="TensorboardRunName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        public TensorboardRunName ParentAsTensorboardRunName
        {
            get => string.IsNullOrEmpty(Parent) ? null : TensorboardRunName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }

    public partial class DeleteTensorboardTimeSeriesRequest
    {
        /// <summary>
        /// <see cref="gcav::TensorboardTimeSeriesName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gcav::TensorboardTimeSeriesName TensorboardTimeSeriesName
        {
            get => string.IsNullOrEmpty(Name) ? null : gcav::TensorboardTimeSeriesName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }

    public partial class BatchReadTensorboardTimeSeriesDataRequest
    {
        /// <summary>
        /// <see cref="TensorboardName"/>-typed view over the <see cref="Tensorboard"/> resource name property.
        /// </summary>
        public TensorboardName TensorboardAsTensorboardName
        {
            get => string.IsNullOrEmpty(Tensorboard) ? null : TensorboardName.Parse(Tensorboard, allowUnparsed: true);
            set => Tensorboard = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="TensorboardTimeSeriesName"/>-typed view over the <see cref="TimeSeries"/> resource name property.
        /// </summary>
        public gax::ResourceNameList<TensorboardTimeSeriesName> TimeSeriesAsTensorboardTimeSeriesNames
        {
            get => new gax::ResourceNameList<TensorboardTimeSeriesName>(TimeSeries, s => string.IsNullOrEmpty(s) ? null : TensorboardTimeSeriesName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class ReadTensorboardTimeSeriesDataRequest
    {
        /// <summary>
        /// <see cref="TensorboardTimeSeriesName"/>-typed view over the <see cref="TensorboardTimeSeries"/> resource
        /// name property.
        /// </summary>
        public TensorboardTimeSeriesName TensorboardTimeSeriesAsTensorboardTimeSeriesName
        {
            get => string.IsNullOrEmpty(TensorboardTimeSeries) ? null : TensorboardTimeSeriesName.Parse(TensorboardTimeSeries, allowUnparsed: true);
            set => TensorboardTimeSeries = value?.ToString() ?? "";
        }
    }

    public partial class WriteTensorboardExperimentDataRequest
    {
        /// <summary>
        /// <see cref="TensorboardExperimentName"/>-typed view over the <see cref="TensorboardExperiment"/> resource
        /// name property.
        /// </summary>
        public TensorboardExperimentName TensorboardExperimentAsTensorboardExperimentName
        {
            get => string.IsNullOrEmpty(TensorboardExperiment) ? null : TensorboardExperimentName.Parse(TensorboardExperiment, allowUnparsed: true);
            set => TensorboardExperiment = value?.ToString() ?? "";
        }
    }

    public partial class WriteTensorboardRunDataRequest
    {
        /// <summary>
        /// <see cref="TensorboardRunName"/>-typed view over the <see cref="TensorboardRun"/> resource name property.
        /// </summary>
        public TensorboardRunName TensorboardRunAsTensorboardRunName
        {
            get => string.IsNullOrEmpty(TensorboardRun) ? null : TensorboardRunName.Parse(TensorboardRun, allowUnparsed: true);
            set => TensorboardRun = value?.ToString() ?? "";
        }
    }

    public partial class ExportTensorboardTimeSeriesDataRequest
    {
        /// <summary>
        /// <see cref="TensorboardTimeSeriesName"/>-typed view over the <see cref="TensorboardTimeSeries"/> resource
        /// name property.
        /// </summary>
        public TensorboardTimeSeriesName TensorboardTimeSeriesAsTensorboardTimeSeriesName
        {
            get => string.IsNullOrEmpty(TensorboardTimeSeries) ? null : TensorboardTimeSeriesName.Parse(TensorboardTimeSeries, allowUnparsed: true);
            set => TensorboardTimeSeries = value?.ToString() ?? "";
        }
    }
}
