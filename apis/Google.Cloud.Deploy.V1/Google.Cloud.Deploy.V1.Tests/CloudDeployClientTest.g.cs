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

namespace Google.Cloud.Deploy.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedCloudDeployClientTest
    {
        [xunit::FactAttribute]
        public void GetDeliveryPipelineRequestObject()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDeliveryPipelineRequest request = new GetDeliveryPipelineRequest
            {
                DeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
            };
            DeliveryPipeline expectedResponse = new DeliveryPipeline
            {
                DeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SerialPipeline = new SerialPipeline(),
                Etag = "etage8ad7218",
                Condition = new PipelineCondition(),
            };
            mockGrpcClient.Setup(x => x.GetDeliveryPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            DeliveryPipeline response = client.GetDeliveryPipeline(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeliveryPipelineRequestObjectAsync()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDeliveryPipelineRequest request = new GetDeliveryPipelineRequest
            {
                DeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
            };
            DeliveryPipeline expectedResponse = new DeliveryPipeline
            {
                DeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SerialPipeline = new SerialPipeline(),
                Etag = "etage8ad7218",
                Condition = new PipelineCondition(),
            };
            mockGrpcClient.Setup(x => x.GetDeliveryPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeliveryPipeline>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            DeliveryPipeline responseCallSettings = await client.GetDeliveryPipelineAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeliveryPipeline responseCancellationToken = await client.GetDeliveryPipelineAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDeliveryPipeline()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDeliveryPipelineRequest request = new GetDeliveryPipelineRequest
            {
                DeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
            };
            DeliveryPipeline expectedResponse = new DeliveryPipeline
            {
                DeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SerialPipeline = new SerialPipeline(),
                Etag = "etage8ad7218",
                Condition = new PipelineCondition(),
            };
            mockGrpcClient.Setup(x => x.GetDeliveryPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            DeliveryPipeline response = client.GetDeliveryPipeline(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeliveryPipelineAsync()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDeliveryPipelineRequest request = new GetDeliveryPipelineRequest
            {
                DeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
            };
            DeliveryPipeline expectedResponse = new DeliveryPipeline
            {
                DeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SerialPipeline = new SerialPipeline(),
                Etag = "etage8ad7218",
                Condition = new PipelineCondition(),
            };
            mockGrpcClient.Setup(x => x.GetDeliveryPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeliveryPipeline>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            DeliveryPipeline responseCallSettings = await client.GetDeliveryPipelineAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeliveryPipeline responseCancellationToken = await client.GetDeliveryPipelineAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDeliveryPipelineResourceNames()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDeliveryPipelineRequest request = new GetDeliveryPipelineRequest
            {
                DeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
            };
            DeliveryPipeline expectedResponse = new DeliveryPipeline
            {
                DeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SerialPipeline = new SerialPipeline(),
                Etag = "etage8ad7218",
                Condition = new PipelineCondition(),
            };
            mockGrpcClient.Setup(x => x.GetDeliveryPipeline(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            DeliveryPipeline response = client.GetDeliveryPipeline(request.DeliveryPipelineName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDeliveryPipelineResourceNamesAsync()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetDeliveryPipelineRequest request = new GetDeliveryPipelineRequest
            {
                DeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
            };
            DeliveryPipeline expectedResponse = new DeliveryPipeline
            {
                DeliveryPipelineName = DeliveryPipelineName.FromProjectLocationDeliveryPipeline("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]"),
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                SerialPipeline = new SerialPipeline(),
                Etag = "etage8ad7218",
                Condition = new PipelineCondition(),
            };
            mockGrpcClient.Setup(x => x.GetDeliveryPipelineAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DeliveryPipeline>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            DeliveryPipeline responseCallSettings = await client.GetDeliveryPipelineAsync(request.DeliveryPipelineName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DeliveryPipeline responseCancellationToken = await client.GetDeliveryPipelineAsync(request.DeliveryPipelineName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTargetRequestObject()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetRequest request = new GetTargetRequest
            {
                TargetName = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]"),
            };
            Target expectedResponse = new Target
            {
                TargetName = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]"),
                TargetId = "target_id16dfe255",
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                RequireApproval = false,
                Gke = new GkeCluster(),
                ExecutionConfigs =
                {
                    new ExecutionConfig(),
                },
                AnthosCluster = new AnthosCluster(),
            };
            mockGrpcClient.Setup(x => x.GetTarget(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Target response = client.GetTarget(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTargetRequestObjectAsync()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetRequest request = new GetTargetRequest
            {
                TargetName = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]"),
            };
            Target expectedResponse = new Target
            {
                TargetName = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]"),
                TargetId = "target_id16dfe255",
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                RequireApproval = false,
                Gke = new GkeCluster(),
                ExecutionConfigs =
                {
                    new ExecutionConfig(),
                },
                AnthosCluster = new AnthosCluster(),
            };
            mockGrpcClient.Setup(x => x.GetTargetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Target>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Target responseCallSettings = await client.GetTargetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Target responseCancellationToken = await client.GetTargetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTarget()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetRequest request = new GetTargetRequest
            {
                TargetName = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]"),
            };
            Target expectedResponse = new Target
            {
                TargetName = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]"),
                TargetId = "target_id16dfe255",
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                RequireApproval = false,
                Gke = new GkeCluster(),
                ExecutionConfigs =
                {
                    new ExecutionConfig(),
                },
                AnthosCluster = new AnthosCluster(),
            };
            mockGrpcClient.Setup(x => x.GetTarget(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Target response = client.GetTarget(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTargetAsync()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetRequest request = new GetTargetRequest
            {
                TargetName = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]"),
            };
            Target expectedResponse = new Target
            {
                TargetName = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]"),
                TargetId = "target_id16dfe255",
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                RequireApproval = false,
                Gke = new GkeCluster(),
                ExecutionConfigs =
                {
                    new ExecutionConfig(),
                },
                AnthosCluster = new AnthosCluster(),
            };
            mockGrpcClient.Setup(x => x.GetTargetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Target>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Target responseCallSettings = await client.GetTargetAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Target responseCancellationToken = await client.GetTargetAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTargetResourceNames()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetRequest request = new GetTargetRequest
            {
                TargetName = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]"),
            };
            Target expectedResponse = new Target
            {
                TargetName = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]"),
                TargetId = "target_id16dfe255",
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                RequireApproval = false,
                Gke = new GkeCluster(),
                ExecutionConfigs =
                {
                    new ExecutionConfig(),
                },
                AnthosCluster = new AnthosCluster(),
            };
            mockGrpcClient.Setup(x => x.GetTarget(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Target response = client.GetTarget(request.TargetName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTargetResourceNamesAsync()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTargetRequest request = new GetTargetRequest
            {
                TargetName = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]"),
            };
            Target expectedResponse = new Target
            {
                TargetName = TargetName.FromProjectLocationTarget("[PROJECT]", "[LOCATION]", "[TARGET]"),
                TargetId = "target_id16dfe255",
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Etag = "etage8ad7218",
                RequireApproval = false,
                Gke = new GkeCluster(),
                ExecutionConfigs =
                {
                    new ExecutionConfig(),
                },
                AnthosCluster = new AnthosCluster(),
            };
            mockGrpcClient.Setup(x => x.GetTargetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Target>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Target responseCallSettings = await client.GetTargetAsync(request.TargetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Target responseCancellationToken = await client.GetTargetAsync(request.TargetName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetReleaseRequestObject()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReleaseRequest request = new GetReleaseRequest
            {
                ReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
            };
            Release expectedResponse = new Release
            {
                ReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                RenderStartTime = new wkt::Timestamp(),
                RenderEndTime = new wkt::Timestamp(),
                SkaffoldConfigPath = "skaffold_config_path583ece19",
                BuildArtifacts =
                {
                    new BuildArtifact(),
                },
                DeliveryPipelineSnapshot = new DeliveryPipeline(),
                TargetSnapshots = { new Target(), },
                RenderState = Release.Types.RenderState.Failed,
                Etag = "etage8ad7218",
                SkaffoldConfigUri = "skaffold_config_urif0232045",
                SkaffoldVersion = "skaffold_versionc9ef9e12",
                TargetArtifacts =
                {
                    {
                        "key8a0b6e3c",
                        new TargetArtifact()
                    },
                },
                TargetRenders =
                {
                    {
                        "key8a0b6e3c",
                        new Release.Types.TargetRender()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetRelease(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Release response = client.GetRelease(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetReleaseRequestObjectAsync()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReleaseRequest request = new GetReleaseRequest
            {
                ReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
            };
            Release expectedResponse = new Release
            {
                ReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                RenderStartTime = new wkt::Timestamp(),
                RenderEndTime = new wkt::Timestamp(),
                SkaffoldConfigPath = "skaffold_config_path583ece19",
                BuildArtifacts =
                {
                    new BuildArtifact(),
                },
                DeliveryPipelineSnapshot = new DeliveryPipeline(),
                TargetSnapshots = { new Target(), },
                RenderState = Release.Types.RenderState.Failed,
                Etag = "etage8ad7218",
                SkaffoldConfigUri = "skaffold_config_urif0232045",
                SkaffoldVersion = "skaffold_versionc9ef9e12",
                TargetArtifacts =
                {
                    {
                        "key8a0b6e3c",
                        new TargetArtifact()
                    },
                },
                TargetRenders =
                {
                    {
                        "key8a0b6e3c",
                        new Release.Types.TargetRender()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetReleaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Release>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Release responseCallSettings = await client.GetReleaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Release responseCancellationToken = await client.GetReleaseAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRelease()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReleaseRequest request = new GetReleaseRequest
            {
                ReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
            };
            Release expectedResponse = new Release
            {
                ReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                RenderStartTime = new wkt::Timestamp(),
                RenderEndTime = new wkt::Timestamp(),
                SkaffoldConfigPath = "skaffold_config_path583ece19",
                BuildArtifacts =
                {
                    new BuildArtifact(),
                },
                DeliveryPipelineSnapshot = new DeliveryPipeline(),
                TargetSnapshots = { new Target(), },
                RenderState = Release.Types.RenderState.Failed,
                Etag = "etage8ad7218",
                SkaffoldConfigUri = "skaffold_config_urif0232045",
                SkaffoldVersion = "skaffold_versionc9ef9e12",
                TargetArtifacts =
                {
                    {
                        "key8a0b6e3c",
                        new TargetArtifact()
                    },
                },
                TargetRenders =
                {
                    {
                        "key8a0b6e3c",
                        new Release.Types.TargetRender()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetRelease(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Release response = client.GetRelease(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetReleaseAsync()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReleaseRequest request = new GetReleaseRequest
            {
                ReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
            };
            Release expectedResponse = new Release
            {
                ReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                RenderStartTime = new wkt::Timestamp(),
                RenderEndTime = new wkt::Timestamp(),
                SkaffoldConfigPath = "skaffold_config_path583ece19",
                BuildArtifacts =
                {
                    new BuildArtifact(),
                },
                DeliveryPipelineSnapshot = new DeliveryPipeline(),
                TargetSnapshots = { new Target(), },
                RenderState = Release.Types.RenderState.Failed,
                Etag = "etage8ad7218",
                SkaffoldConfigUri = "skaffold_config_urif0232045",
                SkaffoldVersion = "skaffold_versionc9ef9e12",
                TargetArtifacts =
                {
                    {
                        "key8a0b6e3c",
                        new TargetArtifact()
                    },
                },
                TargetRenders =
                {
                    {
                        "key8a0b6e3c",
                        new Release.Types.TargetRender()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetReleaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Release>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Release responseCallSettings = await client.GetReleaseAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Release responseCancellationToken = await client.GetReleaseAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetReleaseResourceNames()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReleaseRequest request = new GetReleaseRequest
            {
                ReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
            };
            Release expectedResponse = new Release
            {
                ReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                RenderStartTime = new wkt::Timestamp(),
                RenderEndTime = new wkt::Timestamp(),
                SkaffoldConfigPath = "skaffold_config_path583ece19",
                BuildArtifacts =
                {
                    new BuildArtifact(),
                },
                DeliveryPipelineSnapshot = new DeliveryPipeline(),
                TargetSnapshots = { new Target(), },
                RenderState = Release.Types.RenderState.Failed,
                Etag = "etage8ad7218",
                SkaffoldConfigUri = "skaffold_config_urif0232045",
                SkaffoldVersion = "skaffold_versionc9ef9e12",
                TargetArtifacts =
                {
                    {
                        "key8a0b6e3c",
                        new TargetArtifact()
                    },
                },
                TargetRenders =
                {
                    {
                        "key8a0b6e3c",
                        new Release.Types.TargetRender()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetRelease(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Release response = client.GetRelease(request.ReleaseName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetReleaseResourceNamesAsync()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetReleaseRequest request = new GetReleaseRequest
            {
                ReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
            };
            Release expectedResponse = new Release
            {
                ReleaseName = ReleaseName.FromProjectLocationDeliveryPipelineRelease("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]"),
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                RenderStartTime = new wkt::Timestamp(),
                RenderEndTime = new wkt::Timestamp(),
                SkaffoldConfigPath = "skaffold_config_path583ece19",
                BuildArtifacts =
                {
                    new BuildArtifact(),
                },
                DeliveryPipelineSnapshot = new DeliveryPipeline(),
                TargetSnapshots = { new Target(), },
                RenderState = Release.Types.RenderState.Failed,
                Etag = "etage8ad7218",
                SkaffoldConfigUri = "skaffold_config_urif0232045",
                SkaffoldVersion = "skaffold_versionc9ef9e12",
                TargetArtifacts =
                {
                    {
                        "key8a0b6e3c",
                        new TargetArtifact()
                    },
                },
                TargetRenders =
                {
                    {
                        "key8a0b6e3c",
                        new Release.Types.TargetRender()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetReleaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Release>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Release responseCallSettings = await client.GetReleaseAsync(request.ReleaseName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Release responseCancellationToken = await client.GetReleaseAsync(request.ReleaseName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ApproveRolloutRequestObject()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ApproveRolloutRequest request = new ApproveRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                Approved = true,
            };
            ApproveRolloutResponse expectedResponse = new ApproveRolloutResponse { };
            mockGrpcClient.Setup(x => x.ApproveRollout(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            ApproveRolloutResponse response = client.ApproveRollout(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ApproveRolloutRequestObjectAsync()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ApproveRolloutRequest request = new ApproveRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                Approved = true,
            };
            ApproveRolloutResponse expectedResponse = new ApproveRolloutResponse { };
            mockGrpcClient.Setup(x => x.ApproveRolloutAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApproveRolloutResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            ApproveRolloutResponse responseCallSettings = await client.ApproveRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApproveRolloutResponse responseCancellationToken = await client.ApproveRolloutAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ApproveRollout()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ApproveRolloutRequest request = new ApproveRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
            };
            ApproveRolloutResponse expectedResponse = new ApproveRolloutResponse { };
            mockGrpcClient.Setup(x => x.ApproveRollout(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            ApproveRolloutResponse response = client.ApproveRollout(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ApproveRolloutAsync()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ApproveRolloutRequest request = new ApproveRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
            };
            ApproveRolloutResponse expectedResponse = new ApproveRolloutResponse { };
            mockGrpcClient.Setup(x => x.ApproveRolloutAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApproveRolloutResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            ApproveRolloutResponse responseCallSettings = await client.ApproveRolloutAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApproveRolloutResponse responseCancellationToken = await client.ApproveRolloutAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ApproveRolloutResourceNames()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ApproveRolloutRequest request = new ApproveRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
            };
            ApproveRolloutResponse expectedResponse = new ApproveRolloutResponse { };
            mockGrpcClient.Setup(x => x.ApproveRollout(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            ApproveRolloutResponse response = client.ApproveRollout(request.RolloutName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ApproveRolloutResourceNamesAsync()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ApproveRolloutRequest request = new ApproveRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
            };
            ApproveRolloutResponse expectedResponse = new ApproveRolloutResponse { };
            mockGrpcClient.Setup(x => x.ApproveRolloutAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ApproveRolloutResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            ApproveRolloutResponse responseCallSettings = await client.ApproveRolloutAsync(request.RolloutName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ApproveRolloutResponse responseCancellationToken = await client.ApproveRolloutAsync(request.RolloutName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRolloutRequestObject()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRolloutRequest request = new GetRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
            };
            Rollout expectedResponse = new Rollout
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                ApproveTime = new wkt::Timestamp(),
                EnqueueTime = new wkt::Timestamp(),
                DeployStartTime = new wkt::Timestamp(),
                DeployEndTime = new wkt::Timestamp(),
                ApprovalState = Rollout.Types.ApprovalState.Rejected,
                State = Rollout.Types.State.Pending,
                FailureReason = "failure_reasonb933af24",
                Etag = "etage8ad7218",
                DeployingBuildAsBuildName = BuildName.FromProjectLocationBuild("[PROJECT]", "[LOCATION]", "[BUILD]"),
                TargetId = "target_id16dfe255",
                DeployFailureCause = Rollout.Types.FailureCause.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetRollout(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Rollout response = client.GetRollout(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRolloutRequestObjectAsync()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRolloutRequest request = new GetRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
            };
            Rollout expectedResponse = new Rollout
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                ApproveTime = new wkt::Timestamp(),
                EnqueueTime = new wkt::Timestamp(),
                DeployStartTime = new wkt::Timestamp(),
                DeployEndTime = new wkt::Timestamp(),
                ApprovalState = Rollout.Types.ApprovalState.Rejected,
                State = Rollout.Types.State.Pending,
                FailureReason = "failure_reasonb933af24",
                Etag = "etage8ad7218",
                DeployingBuildAsBuildName = BuildName.FromProjectLocationBuild("[PROJECT]", "[LOCATION]", "[BUILD]"),
                TargetId = "target_id16dfe255",
                DeployFailureCause = Rollout.Types.FailureCause.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetRolloutAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Rollout>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Rollout responseCallSettings = await client.GetRolloutAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Rollout responseCancellationToken = await client.GetRolloutAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRollout()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRolloutRequest request = new GetRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
            };
            Rollout expectedResponse = new Rollout
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                ApproveTime = new wkt::Timestamp(),
                EnqueueTime = new wkt::Timestamp(),
                DeployStartTime = new wkt::Timestamp(),
                DeployEndTime = new wkt::Timestamp(),
                ApprovalState = Rollout.Types.ApprovalState.Rejected,
                State = Rollout.Types.State.Pending,
                FailureReason = "failure_reasonb933af24",
                Etag = "etage8ad7218",
                DeployingBuildAsBuildName = BuildName.FromProjectLocationBuild("[PROJECT]", "[LOCATION]", "[BUILD]"),
                TargetId = "target_id16dfe255",
                DeployFailureCause = Rollout.Types.FailureCause.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetRollout(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Rollout response = client.GetRollout(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRolloutAsync()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRolloutRequest request = new GetRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
            };
            Rollout expectedResponse = new Rollout
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                ApproveTime = new wkt::Timestamp(),
                EnqueueTime = new wkt::Timestamp(),
                DeployStartTime = new wkt::Timestamp(),
                DeployEndTime = new wkt::Timestamp(),
                ApprovalState = Rollout.Types.ApprovalState.Rejected,
                State = Rollout.Types.State.Pending,
                FailureReason = "failure_reasonb933af24",
                Etag = "etage8ad7218",
                DeployingBuildAsBuildName = BuildName.FromProjectLocationBuild("[PROJECT]", "[LOCATION]", "[BUILD]"),
                TargetId = "target_id16dfe255",
                DeployFailureCause = Rollout.Types.FailureCause.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetRolloutAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Rollout>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Rollout responseCallSettings = await client.GetRolloutAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Rollout responseCancellationToken = await client.GetRolloutAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRolloutResourceNames()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRolloutRequest request = new GetRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
            };
            Rollout expectedResponse = new Rollout
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                ApproveTime = new wkt::Timestamp(),
                EnqueueTime = new wkt::Timestamp(),
                DeployStartTime = new wkt::Timestamp(),
                DeployEndTime = new wkt::Timestamp(),
                ApprovalState = Rollout.Types.ApprovalState.Rejected,
                State = Rollout.Types.State.Pending,
                FailureReason = "failure_reasonb933af24",
                Etag = "etage8ad7218",
                DeployingBuildAsBuildName = BuildName.FromProjectLocationBuild("[PROJECT]", "[LOCATION]", "[BUILD]"),
                TargetId = "target_id16dfe255",
                DeployFailureCause = Rollout.Types.FailureCause.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetRollout(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Rollout response = client.GetRollout(request.RolloutName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRolloutResourceNamesAsync()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRolloutRequest request = new GetRolloutRequest
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
            };
            Rollout expectedResponse = new Rollout
            {
                RolloutName = RolloutName.FromProjectLocationDeliveryPipelineReleaseRollout("[PROJECT]", "[LOCATION]", "[DELIVERY_PIPELINE]", "[RELEASE]", "[ROLLOUT]"),
                Uid = "uida2d37198",
                Description = "description2cf9da67",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                ApproveTime = new wkt::Timestamp(),
                EnqueueTime = new wkt::Timestamp(),
                DeployStartTime = new wkt::Timestamp(),
                DeployEndTime = new wkt::Timestamp(),
                ApprovalState = Rollout.Types.ApprovalState.Rejected,
                State = Rollout.Types.State.Pending,
                FailureReason = "failure_reasonb933af24",
                Etag = "etage8ad7218",
                DeployingBuildAsBuildName = BuildName.FromProjectLocationBuild("[PROJECT]", "[LOCATION]", "[BUILD]"),
                TargetId = "target_id16dfe255",
                DeployFailureCause = Rollout.Types.FailureCause.Unspecified,
            };
            mockGrpcClient.Setup(x => x.GetRolloutAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Rollout>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Rollout responseCallSettings = await client.GetRolloutAsync(request.RolloutName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Rollout responseCancellationToken = await client.GetRolloutAsync(request.RolloutName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConfigRequestObject()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConfigRequest request = new GetConfigRequest
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Config expectedResponse = new Config
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SupportedVersions =
                {
                    new SkaffoldVersion(),
                },
                DefaultSkaffoldVersion = "default_skaffold_versioncb9ecadf",
            };
            mockGrpcClient.Setup(x => x.GetConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Config response = client.GetConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConfigRequestObjectAsync()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConfigRequest request = new GetConfigRequest
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Config expectedResponse = new Config
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SupportedVersions =
                {
                    new SkaffoldVersion(),
                },
                DefaultSkaffoldVersion = "default_skaffold_versioncb9ecadf",
            };
            mockGrpcClient.Setup(x => x.GetConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Config>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Config responseCallSettings = await client.GetConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Config responseCancellationToken = await client.GetConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConfig()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConfigRequest request = new GetConfigRequest
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Config expectedResponse = new Config
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SupportedVersions =
                {
                    new SkaffoldVersion(),
                },
                DefaultSkaffoldVersion = "default_skaffold_versioncb9ecadf",
            };
            mockGrpcClient.Setup(x => x.GetConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Config response = client.GetConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConfigAsync()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConfigRequest request = new GetConfigRequest
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Config expectedResponse = new Config
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SupportedVersions =
                {
                    new SkaffoldVersion(),
                },
                DefaultSkaffoldVersion = "default_skaffold_versioncb9ecadf",
            };
            mockGrpcClient.Setup(x => x.GetConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Config>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Config responseCallSettings = await client.GetConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Config responseCancellationToken = await client.GetConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetConfigResourceNames()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConfigRequest request = new GetConfigRequest
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Config expectedResponse = new Config
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SupportedVersions =
                {
                    new SkaffoldVersion(),
                },
                DefaultSkaffoldVersion = "default_skaffold_versioncb9ecadf",
            };
            mockGrpcClient.Setup(x => x.GetConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Config response = client.GetConfig(request.ConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetConfigResourceNamesAsync()
        {
            moq::Mock<CloudDeploy.CloudDeployClient> mockGrpcClient = new moq::Mock<CloudDeploy.CloudDeployClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetConfigRequest request = new GetConfigRequest
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Config expectedResponse = new Config
            {
                ConfigName = ConfigName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                SupportedVersions =
                {
                    new SkaffoldVersion(),
                },
                DefaultSkaffoldVersion = "default_skaffold_versioncb9ecadf",
            };
            mockGrpcClient.Setup(x => x.GetConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Config>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            CloudDeployClient client = new CloudDeployClientImpl(mockGrpcClient.Object, null);
            Config responseCallSettings = await client.GetConfigAsync(request.ConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Config responseCancellationToken = await client.GetConfigAsync(request.ConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
