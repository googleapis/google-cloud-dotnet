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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.AIPlatform.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedModelServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetModelRequestObject()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelRequest request = new GetModelRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            Model expectedResponse = new Model
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PredictSchemata = new PredictSchemata(),
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                Metadata = new wkt::Value(),
                TrainingPipelineAsTrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                ContainerSpec = new ModelContainerSpec(),
                SupportedDeploymentResourcesTypes =
                {
                    Model.Types.DeploymentResourcesType.DedicatedResources,
                },
                SupportedInputStorageFormats =
                {
                    "supported_input_storage_formats82472d65",
                },
                SupportedOutputStorageFormats =
                {
                    "supported_output_storage_formats9adca4ec",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeployedModels =
                {
                    new DeployedModelRef(),
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SupportedExportFormats =
                {
                    new Model.Types.ExportFormat(),
                },
                ExplanationSpec = new ExplanationSpec(),
                EncryptionSpec = new EncryptionSpec(),
                ArtifactUri = "artifact_uri469c7020",
            };
            mockGrpcClient.Setup(x => x.GetModel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            Model response = client.GetModel(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetModelRequestObjectAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelRequest request = new GetModelRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            Model expectedResponse = new Model
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PredictSchemata = new PredictSchemata(),
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                Metadata = new wkt::Value(),
                TrainingPipelineAsTrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                ContainerSpec = new ModelContainerSpec(),
                SupportedDeploymentResourcesTypes =
                {
                    Model.Types.DeploymentResourcesType.DedicatedResources,
                },
                SupportedInputStorageFormats =
                {
                    "supported_input_storage_formats82472d65",
                },
                SupportedOutputStorageFormats =
                {
                    "supported_output_storage_formats9adca4ec",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeployedModels =
                {
                    new DeployedModelRef(),
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SupportedExportFormats =
                {
                    new Model.Types.ExportFormat(),
                },
                ExplanationSpec = new ExplanationSpec(),
                EncryptionSpec = new EncryptionSpec(),
                ArtifactUri = "artifact_uri469c7020",
            };
            mockGrpcClient.Setup(x => x.GetModelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Model>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            Model responseCallSettings = await client.GetModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Model responseCancellationToken = await client.GetModelAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetModel()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelRequest request = new GetModelRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            Model expectedResponse = new Model
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PredictSchemata = new PredictSchemata(),
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                Metadata = new wkt::Value(),
                TrainingPipelineAsTrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                ContainerSpec = new ModelContainerSpec(),
                SupportedDeploymentResourcesTypes =
                {
                    Model.Types.DeploymentResourcesType.DedicatedResources,
                },
                SupportedInputStorageFormats =
                {
                    "supported_input_storage_formats82472d65",
                },
                SupportedOutputStorageFormats =
                {
                    "supported_output_storage_formats9adca4ec",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeployedModels =
                {
                    new DeployedModelRef(),
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SupportedExportFormats =
                {
                    new Model.Types.ExportFormat(),
                },
                ExplanationSpec = new ExplanationSpec(),
                EncryptionSpec = new EncryptionSpec(),
                ArtifactUri = "artifact_uri469c7020",
            };
            mockGrpcClient.Setup(x => x.GetModel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            Model response = client.GetModel(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetModelAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelRequest request = new GetModelRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            Model expectedResponse = new Model
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PredictSchemata = new PredictSchemata(),
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                Metadata = new wkt::Value(),
                TrainingPipelineAsTrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                ContainerSpec = new ModelContainerSpec(),
                SupportedDeploymentResourcesTypes =
                {
                    Model.Types.DeploymentResourcesType.DedicatedResources,
                },
                SupportedInputStorageFormats =
                {
                    "supported_input_storage_formats82472d65",
                },
                SupportedOutputStorageFormats =
                {
                    "supported_output_storage_formats9adca4ec",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeployedModels =
                {
                    new DeployedModelRef(),
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SupportedExportFormats =
                {
                    new Model.Types.ExportFormat(),
                },
                ExplanationSpec = new ExplanationSpec(),
                EncryptionSpec = new EncryptionSpec(),
                ArtifactUri = "artifact_uri469c7020",
            };
            mockGrpcClient.Setup(x => x.GetModelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Model>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            Model responseCallSettings = await client.GetModelAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Model responseCancellationToken = await client.GetModelAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetModelResourceNames()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelRequest request = new GetModelRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            Model expectedResponse = new Model
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PredictSchemata = new PredictSchemata(),
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                Metadata = new wkt::Value(),
                TrainingPipelineAsTrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                ContainerSpec = new ModelContainerSpec(),
                SupportedDeploymentResourcesTypes =
                {
                    Model.Types.DeploymentResourcesType.DedicatedResources,
                },
                SupportedInputStorageFormats =
                {
                    "supported_input_storage_formats82472d65",
                },
                SupportedOutputStorageFormats =
                {
                    "supported_output_storage_formats9adca4ec",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeployedModels =
                {
                    new DeployedModelRef(),
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SupportedExportFormats =
                {
                    new Model.Types.ExportFormat(),
                },
                ExplanationSpec = new ExplanationSpec(),
                EncryptionSpec = new EncryptionSpec(),
                ArtifactUri = "artifact_uri469c7020",
            };
            mockGrpcClient.Setup(x => x.GetModel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            Model response = client.GetModel(request.ModelName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetModelResourceNamesAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelRequest request = new GetModelRequest
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
            };
            Model expectedResponse = new Model
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PredictSchemata = new PredictSchemata(),
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                Metadata = new wkt::Value(),
                TrainingPipelineAsTrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                ContainerSpec = new ModelContainerSpec(),
                SupportedDeploymentResourcesTypes =
                {
                    Model.Types.DeploymentResourcesType.DedicatedResources,
                },
                SupportedInputStorageFormats =
                {
                    "supported_input_storage_formats82472d65",
                },
                SupportedOutputStorageFormats =
                {
                    "supported_output_storage_formats9adca4ec",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeployedModels =
                {
                    new DeployedModelRef(),
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SupportedExportFormats =
                {
                    new Model.Types.ExportFormat(),
                },
                ExplanationSpec = new ExplanationSpec(),
                EncryptionSpec = new EncryptionSpec(),
                ArtifactUri = "artifact_uri469c7020",
            };
            mockGrpcClient.Setup(x => x.GetModelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Model>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            Model responseCallSettings = await client.GetModelAsync(request.ModelName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Model responseCancellationToken = await client.GetModelAsync(request.ModelName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateModelRequestObject()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateModelRequest request = new UpdateModelRequest
            {
                Model = new Model(),
                UpdateMask = new wkt::FieldMask(),
            };
            Model expectedResponse = new Model
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PredictSchemata = new PredictSchemata(),
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                Metadata = new wkt::Value(),
                TrainingPipelineAsTrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                ContainerSpec = new ModelContainerSpec(),
                SupportedDeploymentResourcesTypes =
                {
                    Model.Types.DeploymentResourcesType.DedicatedResources,
                },
                SupportedInputStorageFormats =
                {
                    "supported_input_storage_formats82472d65",
                },
                SupportedOutputStorageFormats =
                {
                    "supported_output_storage_formats9adca4ec",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeployedModels =
                {
                    new DeployedModelRef(),
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SupportedExportFormats =
                {
                    new Model.Types.ExportFormat(),
                },
                ExplanationSpec = new ExplanationSpec(),
                EncryptionSpec = new EncryptionSpec(),
                ArtifactUri = "artifact_uri469c7020",
            };
            mockGrpcClient.Setup(x => x.UpdateModel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            Model response = client.UpdateModel(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateModelRequestObjectAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateModelRequest request = new UpdateModelRequest
            {
                Model = new Model(),
                UpdateMask = new wkt::FieldMask(),
            };
            Model expectedResponse = new Model
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PredictSchemata = new PredictSchemata(),
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                Metadata = new wkt::Value(),
                TrainingPipelineAsTrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                ContainerSpec = new ModelContainerSpec(),
                SupportedDeploymentResourcesTypes =
                {
                    Model.Types.DeploymentResourcesType.DedicatedResources,
                },
                SupportedInputStorageFormats =
                {
                    "supported_input_storage_formats82472d65",
                },
                SupportedOutputStorageFormats =
                {
                    "supported_output_storage_formats9adca4ec",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeployedModels =
                {
                    new DeployedModelRef(),
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SupportedExportFormats =
                {
                    new Model.Types.ExportFormat(),
                },
                ExplanationSpec = new ExplanationSpec(),
                EncryptionSpec = new EncryptionSpec(),
                ArtifactUri = "artifact_uri469c7020",
            };
            mockGrpcClient.Setup(x => x.UpdateModelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Model>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            Model responseCallSettings = await client.UpdateModelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Model responseCancellationToken = await client.UpdateModelAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateModel()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateModelRequest request = new UpdateModelRequest
            {
                Model = new Model(),
                UpdateMask = new wkt::FieldMask(),
            };
            Model expectedResponse = new Model
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PredictSchemata = new PredictSchemata(),
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                Metadata = new wkt::Value(),
                TrainingPipelineAsTrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                ContainerSpec = new ModelContainerSpec(),
                SupportedDeploymentResourcesTypes =
                {
                    Model.Types.DeploymentResourcesType.DedicatedResources,
                },
                SupportedInputStorageFormats =
                {
                    "supported_input_storage_formats82472d65",
                },
                SupportedOutputStorageFormats =
                {
                    "supported_output_storage_formats9adca4ec",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeployedModels =
                {
                    new DeployedModelRef(),
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SupportedExportFormats =
                {
                    new Model.Types.ExportFormat(),
                },
                ExplanationSpec = new ExplanationSpec(),
                EncryptionSpec = new EncryptionSpec(),
                ArtifactUri = "artifact_uri469c7020",
            };
            mockGrpcClient.Setup(x => x.UpdateModel(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            Model response = client.UpdateModel(request.Model, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateModelAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateModelRequest request = new UpdateModelRequest
            {
                Model = new Model(),
                UpdateMask = new wkt::FieldMask(),
            };
            Model expectedResponse = new Model
            {
                ModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                PredictSchemata = new PredictSchemata(),
                MetadataSchemaUri = "metadata_schema_uric874bf0a",
                Metadata = new wkt::Value(),
                TrainingPipelineAsTrainingPipelineName = TrainingPipelineName.FromProjectLocationTrainingPipeline("[PROJECT]", "[LOCATION]", "[TRAINING_PIPELINE]"),
                ContainerSpec = new ModelContainerSpec(),
                SupportedDeploymentResourcesTypes =
                {
                    Model.Types.DeploymentResourcesType.DedicatedResources,
                },
                SupportedInputStorageFormats =
                {
                    "supported_input_storage_formats82472d65",
                },
                SupportedOutputStorageFormats =
                {
                    "supported_output_storage_formats9adca4ec",
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeployedModels =
                {
                    new DeployedModelRef(),
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                SupportedExportFormats =
                {
                    new Model.Types.ExportFormat(),
                },
                ExplanationSpec = new ExplanationSpec(),
                EncryptionSpec = new EncryptionSpec(),
                ArtifactUri = "artifact_uri469c7020",
            };
            mockGrpcClient.Setup(x => x.UpdateModelAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Model>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            Model responseCallSettings = await client.UpdateModelAsync(request.Model, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Model responseCancellationToken = await client.UpdateModelAsync(request.Model, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ImportModelEvaluationRequestObject()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ImportModelEvaluationRequest request = new ImportModelEvaluationRequest
            {
                ParentAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                ModelEvaluation = new ModelEvaluation(),
            };
            ModelEvaluation expectedResponse = new ModelEvaluation
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
                MetricsSchemaUri = "metrics_schema_uriad9a097a",
                Metrics = new wkt::Value(),
                CreateTime = new wkt::Timestamp(),
                SliceDimensions =
                {
                    "slice_dimensions7d96a205",
                },
                DataItemSchemaUri = "data_item_schema_urif10f8905",
                AnnotationSchemaUri = "annotation_schema_urie647f49c",
                ModelExplanation = new ModelExplanation(),
                ExplanationSpecs =
                {
                    new ModelEvaluation.Types.ModelEvaluationExplanationSpec(),
                },
                DisplayName = "display_name137f65c2",
                Metadata = new wkt::Value(),
            };
            mockGrpcClient.Setup(x => x.ImportModelEvaluation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ModelEvaluation response = client.ImportModelEvaluation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ImportModelEvaluationRequestObjectAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ImportModelEvaluationRequest request = new ImportModelEvaluationRequest
            {
                ParentAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                ModelEvaluation = new ModelEvaluation(),
            };
            ModelEvaluation expectedResponse = new ModelEvaluation
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
                MetricsSchemaUri = "metrics_schema_uriad9a097a",
                Metrics = new wkt::Value(),
                CreateTime = new wkt::Timestamp(),
                SliceDimensions =
                {
                    "slice_dimensions7d96a205",
                },
                DataItemSchemaUri = "data_item_schema_urif10f8905",
                AnnotationSchemaUri = "annotation_schema_urie647f49c",
                ModelExplanation = new ModelExplanation(),
                ExplanationSpecs =
                {
                    new ModelEvaluation.Types.ModelEvaluationExplanationSpec(),
                },
                DisplayName = "display_name137f65c2",
                Metadata = new wkt::Value(),
            };
            mockGrpcClient.Setup(x => x.ImportModelEvaluationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ModelEvaluation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ModelEvaluation responseCallSettings = await client.ImportModelEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ModelEvaluation responseCancellationToken = await client.ImportModelEvaluationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ImportModelEvaluation()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ImportModelEvaluationRequest request = new ImportModelEvaluationRequest
            {
                ParentAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                ModelEvaluation = new ModelEvaluation(),
            };
            ModelEvaluation expectedResponse = new ModelEvaluation
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
                MetricsSchemaUri = "metrics_schema_uriad9a097a",
                Metrics = new wkt::Value(),
                CreateTime = new wkt::Timestamp(),
                SliceDimensions =
                {
                    "slice_dimensions7d96a205",
                },
                DataItemSchemaUri = "data_item_schema_urif10f8905",
                AnnotationSchemaUri = "annotation_schema_urie647f49c",
                ModelExplanation = new ModelExplanation(),
                ExplanationSpecs =
                {
                    new ModelEvaluation.Types.ModelEvaluationExplanationSpec(),
                },
                DisplayName = "display_name137f65c2",
                Metadata = new wkt::Value(),
            };
            mockGrpcClient.Setup(x => x.ImportModelEvaluation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ModelEvaluation response = client.ImportModelEvaluation(request.Parent, request.ModelEvaluation);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ImportModelEvaluationAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ImportModelEvaluationRequest request = new ImportModelEvaluationRequest
            {
                ParentAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                ModelEvaluation = new ModelEvaluation(),
            };
            ModelEvaluation expectedResponse = new ModelEvaluation
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
                MetricsSchemaUri = "metrics_schema_uriad9a097a",
                Metrics = new wkt::Value(),
                CreateTime = new wkt::Timestamp(),
                SliceDimensions =
                {
                    "slice_dimensions7d96a205",
                },
                DataItemSchemaUri = "data_item_schema_urif10f8905",
                AnnotationSchemaUri = "annotation_schema_urie647f49c",
                ModelExplanation = new ModelExplanation(),
                ExplanationSpecs =
                {
                    new ModelEvaluation.Types.ModelEvaluationExplanationSpec(),
                },
                DisplayName = "display_name137f65c2",
                Metadata = new wkt::Value(),
            };
            mockGrpcClient.Setup(x => x.ImportModelEvaluationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ModelEvaluation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ModelEvaluation responseCallSettings = await client.ImportModelEvaluationAsync(request.Parent, request.ModelEvaluation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ModelEvaluation responseCancellationToken = await client.ImportModelEvaluationAsync(request.Parent, request.ModelEvaluation, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ImportModelEvaluationResourceNames()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ImportModelEvaluationRequest request = new ImportModelEvaluationRequest
            {
                ParentAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                ModelEvaluation = new ModelEvaluation(),
            };
            ModelEvaluation expectedResponse = new ModelEvaluation
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
                MetricsSchemaUri = "metrics_schema_uriad9a097a",
                Metrics = new wkt::Value(),
                CreateTime = new wkt::Timestamp(),
                SliceDimensions =
                {
                    "slice_dimensions7d96a205",
                },
                DataItemSchemaUri = "data_item_schema_urif10f8905",
                AnnotationSchemaUri = "annotation_schema_urie647f49c",
                ModelExplanation = new ModelExplanation(),
                ExplanationSpecs =
                {
                    new ModelEvaluation.Types.ModelEvaluationExplanationSpec(),
                },
                DisplayName = "display_name137f65c2",
                Metadata = new wkt::Value(),
            };
            mockGrpcClient.Setup(x => x.ImportModelEvaluation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ModelEvaluation response = client.ImportModelEvaluation(request.ParentAsModelName, request.ModelEvaluation);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ImportModelEvaluationResourceNamesAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ImportModelEvaluationRequest request = new ImportModelEvaluationRequest
            {
                ParentAsModelName = ModelName.FromProjectLocationModel("[PROJECT]", "[LOCATION]", "[MODEL]"),
                ModelEvaluation = new ModelEvaluation(),
            };
            ModelEvaluation expectedResponse = new ModelEvaluation
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
                MetricsSchemaUri = "metrics_schema_uriad9a097a",
                Metrics = new wkt::Value(),
                CreateTime = new wkt::Timestamp(),
                SliceDimensions =
                {
                    "slice_dimensions7d96a205",
                },
                DataItemSchemaUri = "data_item_schema_urif10f8905",
                AnnotationSchemaUri = "annotation_schema_urie647f49c",
                ModelExplanation = new ModelExplanation(),
                ExplanationSpecs =
                {
                    new ModelEvaluation.Types.ModelEvaluationExplanationSpec(),
                },
                DisplayName = "display_name137f65c2",
                Metadata = new wkt::Value(),
            };
            mockGrpcClient.Setup(x => x.ImportModelEvaluationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ModelEvaluation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ModelEvaluation responseCallSettings = await client.ImportModelEvaluationAsync(request.ParentAsModelName, request.ModelEvaluation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ModelEvaluation responseCancellationToken = await client.ImportModelEvaluationAsync(request.ParentAsModelName, request.ModelEvaluation, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetModelEvaluationRequestObject()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelEvaluationRequest request = new GetModelEvaluationRequest
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
            };
            ModelEvaluation expectedResponse = new ModelEvaluation
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
                MetricsSchemaUri = "metrics_schema_uriad9a097a",
                Metrics = new wkt::Value(),
                CreateTime = new wkt::Timestamp(),
                SliceDimensions =
                {
                    "slice_dimensions7d96a205",
                },
                DataItemSchemaUri = "data_item_schema_urif10f8905",
                AnnotationSchemaUri = "annotation_schema_urie647f49c",
                ModelExplanation = new ModelExplanation(),
                ExplanationSpecs =
                {
                    new ModelEvaluation.Types.ModelEvaluationExplanationSpec(),
                },
                DisplayName = "display_name137f65c2",
                Metadata = new wkt::Value(),
            };
            mockGrpcClient.Setup(x => x.GetModelEvaluation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ModelEvaluation response = client.GetModelEvaluation(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetModelEvaluationRequestObjectAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelEvaluationRequest request = new GetModelEvaluationRequest
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
            };
            ModelEvaluation expectedResponse = new ModelEvaluation
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
                MetricsSchemaUri = "metrics_schema_uriad9a097a",
                Metrics = new wkt::Value(),
                CreateTime = new wkt::Timestamp(),
                SliceDimensions =
                {
                    "slice_dimensions7d96a205",
                },
                DataItemSchemaUri = "data_item_schema_urif10f8905",
                AnnotationSchemaUri = "annotation_schema_urie647f49c",
                ModelExplanation = new ModelExplanation(),
                ExplanationSpecs =
                {
                    new ModelEvaluation.Types.ModelEvaluationExplanationSpec(),
                },
                DisplayName = "display_name137f65c2",
                Metadata = new wkt::Value(),
            };
            mockGrpcClient.Setup(x => x.GetModelEvaluationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ModelEvaluation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ModelEvaluation responseCallSettings = await client.GetModelEvaluationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ModelEvaluation responseCancellationToken = await client.GetModelEvaluationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetModelEvaluation()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelEvaluationRequest request = new GetModelEvaluationRequest
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
            };
            ModelEvaluation expectedResponse = new ModelEvaluation
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
                MetricsSchemaUri = "metrics_schema_uriad9a097a",
                Metrics = new wkt::Value(),
                CreateTime = new wkt::Timestamp(),
                SliceDimensions =
                {
                    "slice_dimensions7d96a205",
                },
                DataItemSchemaUri = "data_item_schema_urif10f8905",
                AnnotationSchemaUri = "annotation_schema_urie647f49c",
                ModelExplanation = new ModelExplanation(),
                ExplanationSpecs =
                {
                    new ModelEvaluation.Types.ModelEvaluationExplanationSpec(),
                },
                DisplayName = "display_name137f65c2",
                Metadata = new wkt::Value(),
            };
            mockGrpcClient.Setup(x => x.GetModelEvaluation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ModelEvaluation response = client.GetModelEvaluation(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetModelEvaluationAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelEvaluationRequest request = new GetModelEvaluationRequest
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
            };
            ModelEvaluation expectedResponse = new ModelEvaluation
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
                MetricsSchemaUri = "metrics_schema_uriad9a097a",
                Metrics = new wkt::Value(),
                CreateTime = new wkt::Timestamp(),
                SliceDimensions =
                {
                    "slice_dimensions7d96a205",
                },
                DataItemSchemaUri = "data_item_schema_urif10f8905",
                AnnotationSchemaUri = "annotation_schema_urie647f49c",
                ModelExplanation = new ModelExplanation(),
                ExplanationSpecs =
                {
                    new ModelEvaluation.Types.ModelEvaluationExplanationSpec(),
                },
                DisplayName = "display_name137f65c2",
                Metadata = new wkt::Value(),
            };
            mockGrpcClient.Setup(x => x.GetModelEvaluationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ModelEvaluation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ModelEvaluation responseCallSettings = await client.GetModelEvaluationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ModelEvaluation responseCancellationToken = await client.GetModelEvaluationAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetModelEvaluationResourceNames()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelEvaluationRequest request = new GetModelEvaluationRequest
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
            };
            ModelEvaluation expectedResponse = new ModelEvaluation
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
                MetricsSchemaUri = "metrics_schema_uriad9a097a",
                Metrics = new wkt::Value(),
                CreateTime = new wkt::Timestamp(),
                SliceDimensions =
                {
                    "slice_dimensions7d96a205",
                },
                DataItemSchemaUri = "data_item_schema_urif10f8905",
                AnnotationSchemaUri = "annotation_schema_urie647f49c",
                ModelExplanation = new ModelExplanation(),
                ExplanationSpecs =
                {
                    new ModelEvaluation.Types.ModelEvaluationExplanationSpec(),
                },
                DisplayName = "display_name137f65c2",
                Metadata = new wkt::Value(),
            };
            mockGrpcClient.Setup(x => x.GetModelEvaluation(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ModelEvaluation response = client.GetModelEvaluation(request.ModelEvaluationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetModelEvaluationResourceNamesAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelEvaluationRequest request = new GetModelEvaluationRequest
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
            };
            ModelEvaluation expectedResponse = new ModelEvaluation
            {
                ModelEvaluationName = ModelEvaluationName.FromProjectLocationModelEvaluation("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]"),
                MetricsSchemaUri = "metrics_schema_uriad9a097a",
                Metrics = new wkt::Value(),
                CreateTime = new wkt::Timestamp(),
                SliceDimensions =
                {
                    "slice_dimensions7d96a205",
                },
                DataItemSchemaUri = "data_item_schema_urif10f8905",
                AnnotationSchemaUri = "annotation_schema_urie647f49c",
                ModelExplanation = new ModelExplanation(),
                ExplanationSpecs =
                {
                    new ModelEvaluation.Types.ModelEvaluationExplanationSpec(),
                },
                DisplayName = "display_name137f65c2",
                Metadata = new wkt::Value(),
            };
            mockGrpcClient.Setup(x => x.GetModelEvaluationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ModelEvaluation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ModelEvaluation responseCallSettings = await client.GetModelEvaluationAsync(request.ModelEvaluationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ModelEvaluation responseCancellationToken = await client.GetModelEvaluationAsync(request.ModelEvaluationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetModelEvaluationSliceRequestObject()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelEvaluationSliceRequest request = new GetModelEvaluationSliceRequest
            {
                ModelEvaluationSliceName = ModelEvaluationSliceName.FromProjectLocationModelEvaluationSlice("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]"),
            };
            ModelEvaluationSlice expectedResponse = new ModelEvaluationSlice
            {
                ModelEvaluationSliceName = ModelEvaluationSliceName.FromProjectLocationModelEvaluationSlice("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]"),
                Slice = new ModelEvaluationSlice.Types.Slice(),
                MetricsSchemaUri = "metrics_schema_uriad9a097a",
                Metrics = new wkt::Value(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetModelEvaluationSlice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ModelEvaluationSlice response = client.GetModelEvaluationSlice(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetModelEvaluationSliceRequestObjectAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelEvaluationSliceRequest request = new GetModelEvaluationSliceRequest
            {
                ModelEvaluationSliceName = ModelEvaluationSliceName.FromProjectLocationModelEvaluationSlice("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]"),
            };
            ModelEvaluationSlice expectedResponse = new ModelEvaluationSlice
            {
                ModelEvaluationSliceName = ModelEvaluationSliceName.FromProjectLocationModelEvaluationSlice("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]"),
                Slice = new ModelEvaluationSlice.Types.Slice(),
                MetricsSchemaUri = "metrics_schema_uriad9a097a",
                Metrics = new wkt::Value(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetModelEvaluationSliceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ModelEvaluationSlice>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ModelEvaluationSlice responseCallSettings = await client.GetModelEvaluationSliceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ModelEvaluationSlice responseCancellationToken = await client.GetModelEvaluationSliceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetModelEvaluationSlice()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelEvaluationSliceRequest request = new GetModelEvaluationSliceRequest
            {
                ModelEvaluationSliceName = ModelEvaluationSliceName.FromProjectLocationModelEvaluationSlice("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]"),
            };
            ModelEvaluationSlice expectedResponse = new ModelEvaluationSlice
            {
                ModelEvaluationSliceName = ModelEvaluationSliceName.FromProjectLocationModelEvaluationSlice("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]"),
                Slice = new ModelEvaluationSlice.Types.Slice(),
                MetricsSchemaUri = "metrics_schema_uriad9a097a",
                Metrics = new wkt::Value(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetModelEvaluationSlice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ModelEvaluationSlice response = client.GetModelEvaluationSlice(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetModelEvaluationSliceAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelEvaluationSliceRequest request = new GetModelEvaluationSliceRequest
            {
                ModelEvaluationSliceName = ModelEvaluationSliceName.FromProjectLocationModelEvaluationSlice("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]"),
            };
            ModelEvaluationSlice expectedResponse = new ModelEvaluationSlice
            {
                ModelEvaluationSliceName = ModelEvaluationSliceName.FromProjectLocationModelEvaluationSlice("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]"),
                Slice = new ModelEvaluationSlice.Types.Slice(),
                MetricsSchemaUri = "metrics_schema_uriad9a097a",
                Metrics = new wkt::Value(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetModelEvaluationSliceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ModelEvaluationSlice>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ModelEvaluationSlice responseCallSettings = await client.GetModelEvaluationSliceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ModelEvaluationSlice responseCancellationToken = await client.GetModelEvaluationSliceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetModelEvaluationSliceResourceNames()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelEvaluationSliceRequest request = new GetModelEvaluationSliceRequest
            {
                ModelEvaluationSliceName = ModelEvaluationSliceName.FromProjectLocationModelEvaluationSlice("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]"),
            };
            ModelEvaluationSlice expectedResponse = new ModelEvaluationSlice
            {
                ModelEvaluationSliceName = ModelEvaluationSliceName.FromProjectLocationModelEvaluationSlice("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]"),
                Slice = new ModelEvaluationSlice.Types.Slice(),
                MetricsSchemaUri = "metrics_schema_uriad9a097a",
                Metrics = new wkt::Value(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetModelEvaluationSlice(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ModelEvaluationSlice response = client.GetModelEvaluationSlice(request.ModelEvaluationSliceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetModelEvaluationSliceResourceNamesAsync()
        {
            moq::Mock<ModelService.ModelServiceClient> mockGrpcClient = new moq::Mock<ModelService.ModelServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetModelEvaluationSliceRequest request = new GetModelEvaluationSliceRequest
            {
                ModelEvaluationSliceName = ModelEvaluationSliceName.FromProjectLocationModelEvaluationSlice("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]"),
            };
            ModelEvaluationSlice expectedResponse = new ModelEvaluationSlice
            {
                ModelEvaluationSliceName = ModelEvaluationSliceName.FromProjectLocationModelEvaluationSlice("[PROJECT]", "[LOCATION]", "[MODEL]", "[EVALUATION]", "[SLICE]"),
                Slice = new ModelEvaluationSlice.Types.Slice(),
                MetricsSchemaUri = "metrics_schema_uriad9a097a",
                Metrics = new wkt::Value(),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetModelEvaluationSliceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ModelEvaluationSlice>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ModelServiceClient client = new ModelServiceClientImpl(mockGrpcClient.Object, null);
            ModelEvaluationSlice responseCallSettings = await client.GetModelEvaluationSliceAsync(request.ModelEvaluationSliceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ModelEvaluationSlice responseCancellationToken = await client.GetModelEvaluationSliceAsync(request.ModelEvaluationSliceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
