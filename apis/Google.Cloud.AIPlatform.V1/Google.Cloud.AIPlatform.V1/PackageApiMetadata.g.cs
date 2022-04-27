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

using gaxgrpc = Google.Api.Gax.Grpc;
using gpr = Google.Protobuf.Reflection;
using scg = System.Collections.Generic;

namespace Google.Cloud.AIPlatform.V1
{
    /// <summary>Static class to provide common access to package-wide API metadata.</summary>
    internal static class PackageApiMetadata
    {
        /// <summary>The <see cref="gaxgrpc::ApiMetadata"/> for services in this package.</summary>
        internal static gaxgrpc::ApiMetadata ApiMetadata { get; } = new gaxgrpc::ApiMetadata("Google.Cloud.AIPlatform.V1", GetFileDescriptors);

        private static scg::IEnumerable<gpr::FileDescriptor> GetFileDescriptors()
        {
            yield return AcceleratorTypeReflection.Descriptor;
            yield return UserActionReferenceReflection.Descriptor;
            yield return AnnotationReflection.Descriptor;
            yield return AnnotationSpecReflection.Descriptor;
            yield return ArtifactReflection.Descriptor;
            yield return CompletionStatsReflection.Descriptor;
            yield return EncryptionSpecReflection.Descriptor;
            yield return ExplanationMetadataReflection.Descriptor;
            yield return ExplanationReflection.Descriptor;
            yield return IoReflection.Descriptor;
            yield return JobStateReflection.Descriptor;
            yield return MachineResourcesReflection.Descriptor;
            yield return ManualBatchTuningParametersReflection.Descriptor;
            yield return DeployedModelRefReflection.Descriptor;
            yield return EnvVarReflection.Descriptor;
            yield return ModelReflection.Descriptor;
            yield return UnmanagedContainerModelReflection.Descriptor;
            yield return BatchPredictionJobReflection.Descriptor;
            yield return ContextReflection.Descriptor;
            yield return CustomJobReflection.Descriptor;
            yield return DatasetReflection.Descriptor;
            yield return DataItemReflection.Descriptor;
            yield return OperationReflection.Descriptor;
            yield return DatasetServiceReflection.Descriptor;
            yield return DataLabelingJobReflection.Descriptor;
            yield return DeployedIndexRefReflection.Descriptor;
            yield return EndpointReflection.Descriptor;
            yield return EndpointServiceReflection.Descriptor;
            yield return FeaturestoreMonitoringReflection.Descriptor;
            yield return EntityTypeReflection.Descriptor;
            yield return EventReflection.Descriptor;
            yield return ExecutionReflection.Descriptor;
            yield return FeatureMonitoringStatsReflection.Descriptor;
            yield return FeatureReflection.Descriptor;
            yield return FeaturestoreReflection.Descriptor;
            yield return FeatureSelectorReflection.Descriptor;
            yield return TypesReflection.Descriptor;
            yield return FeaturestoreOnlineServiceReflection.Descriptor;
            yield return FeaturestoreServiceReflection.Descriptor;
            yield return StudyReflection.Descriptor;
            yield return HyperparameterTuningJobReflection.Descriptor;
            yield return IndexReflection.Descriptor;
            yield return IndexEndpointReflection.Descriptor;
            yield return IndexEndpointServiceReflection.Descriptor;
            yield return IndexServiceReflection.Descriptor;
            yield return ModelMonitoringReflection.Descriptor;
            yield return ModelDeploymentMonitoringJobReflection.Descriptor;
            yield return JobServiceReflection.Descriptor;
            yield return LineageSubgraphReflection.Descriptor;
            yield return MetadataSchemaReflection.Descriptor;
            yield return MetadataStoreReflection.Descriptor;
            yield return MetadataServiceReflection.Descriptor;
            yield return MigratableResourceReflection.Descriptor;
            yield return MigrationServiceReflection.Descriptor;
            yield return ModelEvaluationReflection.Descriptor;
            yield return ModelEvaluationSliceReflection.Descriptor;
            yield return ModelServiceReflection.Descriptor;
            yield return PipelineStateReflection.Descriptor;
            yield return ValueReflection.Descriptor;
            yield return PipelineJobReflection.Descriptor;
            yield return TrainingPipelineReflection.Descriptor;
            yield return PipelineServiceReflection.Descriptor;
            yield return PredictionServiceReflection.Descriptor;
            yield return SpecialistPoolReflection.Descriptor;
            yield return SpecialistPoolServiceReflection.Descriptor;
            yield return TensorboardReflection.Descriptor;
            yield return TensorboardTimeSeriesReflection.Descriptor;
            yield return TensorboardDataReflection.Descriptor;
            yield return TensorboardExperimentReflection.Descriptor;
            yield return TensorboardRunReflection.Descriptor;
            yield return TensorboardServiceReflection.Descriptor;
            yield return VizierServiceReflection.Descriptor;
        }
    }
}
