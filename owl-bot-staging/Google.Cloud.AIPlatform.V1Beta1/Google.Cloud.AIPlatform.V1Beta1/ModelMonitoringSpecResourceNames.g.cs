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
using gax = Google.Api.Gax;

namespace Google.Cloud.AIPlatform.V1Beta1
{
    public partial class ModelMonitoringInput
    {
        public partial class Types
        {
            public partial class ModelMonitoringDataset
            {
                /// <summary>
                /// <see cref="DatasetName"/>-typed view over the <see cref="VertexDataset"/> resource name property.
                /// </summary>
                public DatasetName VertexDatasetAsDatasetName
                {
                    get => string.IsNullOrEmpty(VertexDataset) ? null : DatasetName.Parse(VertexDataset, allowUnparsed: true);
                    set => VertexDataset = value?.ToString() ?? "";
                }
            }

            public partial class BatchPredictionOutput
            {
                /// <summary>
                /// <see cref="BatchPredictionJobName"/>-typed view over the <see cref="BatchPredictionJob"/> resource
                /// name property.
                /// </summary>
                public BatchPredictionJobName BatchPredictionJobAsBatchPredictionJobName
                {
                    get => string.IsNullOrEmpty(BatchPredictionJob) ? null : BatchPredictionJobName.Parse(BatchPredictionJob, allowUnparsed: true);
                    set => BatchPredictionJob = value?.ToString() ?? "";
                }
            }

            public partial class VertexEndpointLogs
            {
                /// <summary>
                /// <see cref="EndpointName"/>-typed view over the <see cref="Endpoints"/> resource name property.
                /// </summary>
                public gax::ResourceNameList<EndpointName> EndpointsAsEndpointNames
                {
                    get => new gax::ResourceNameList<EndpointName>(Endpoints, s => string.IsNullOrEmpty(s) ? null : EndpointName.Parse(s, allowUnparsed: true));
                }
            }
        }
    }
}
