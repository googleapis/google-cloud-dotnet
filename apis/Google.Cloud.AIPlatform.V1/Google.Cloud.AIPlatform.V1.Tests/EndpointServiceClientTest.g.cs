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
    public sealed class GeneratedEndpointServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetEndpointRequestObject()
        {
            moq::Mock<EndpointService.EndpointServiceClient> mockGrpcClient = new moq::Mock<EndpointService.EndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedModels =
                {
                    new DeployedModel(),
                },
                TrafficSplit =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EncryptionSpec = new EncryptionSpec(),
                ModelDeploymentMonitoringJobAsModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            mockGrpcClient.Setup(x => x.GetEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EndpointServiceClient client = new EndpointServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint response = client.GetEndpoint(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEndpointRequestObjectAsync()
        {
            moq::Mock<EndpointService.EndpointServiceClient> mockGrpcClient = new moq::Mock<EndpointService.EndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedModels =
                {
                    new DeployedModel(),
                },
                TrafficSplit =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EncryptionSpec = new EncryptionSpec(),
                ModelDeploymentMonitoringJobAsModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            mockGrpcClient.Setup(x => x.GetEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Endpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EndpointServiceClient client = new EndpointServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint responseCallSettings = await client.GetEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Endpoint responseCancellationToken = await client.GetEndpointAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEndpoint()
        {
            moq::Mock<EndpointService.EndpointServiceClient> mockGrpcClient = new moq::Mock<EndpointService.EndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedModels =
                {
                    new DeployedModel(),
                },
                TrafficSplit =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EncryptionSpec = new EncryptionSpec(),
                ModelDeploymentMonitoringJobAsModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            mockGrpcClient.Setup(x => x.GetEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EndpointServiceClient client = new EndpointServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint response = client.GetEndpoint(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEndpointAsync()
        {
            moq::Mock<EndpointService.EndpointServiceClient> mockGrpcClient = new moq::Mock<EndpointService.EndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedModels =
                {
                    new DeployedModel(),
                },
                TrafficSplit =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EncryptionSpec = new EncryptionSpec(),
                ModelDeploymentMonitoringJobAsModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            mockGrpcClient.Setup(x => x.GetEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Endpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EndpointServiceClient client = new EndpointServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint responseCallSettings = await client.GetEndpointAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Endpoint responseCancellationToken = await client.GetEndpointAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEndpointResourceNames()
        {
            moq::Mock<EndpointService.EndpointServiceClient> mockGrpcClient = new moq::Mock<EndpointService.EndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedModels =
                {
                    new DeployedModel(),
                },
                TrafficSplit =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EncryptionSpec = new EncryptionSpec(),
                ModelDeploymentMonitoringJobAsModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            mockGrpcClient.Setup(x => x.GetEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EndpointServiceClient client = new EndpointServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint response = client.GetEndpoint(request.EndpointName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEndpointResourceNamesAsync()
        {
            moq::Mock<EndpointService.EndpointServiceClient> mockGrpcClient = new moq::Mock<EndpointService.EndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedModels =
                {
                    new DeployedModel(),
                },
                TrafficSplit =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EncryptionSpec = new EncryptionSpec(),
                ModelDeploymentMonitoringJobAsModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            mockGrpcClient.Setup(x => x.GetEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Endpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EndpointServiceClient client = new EndpointServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint responseCallSettings = await client.GetEndpointAsync(request.EndpointName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Endpoint responseCancellationToken = await client.GetEndpointAsync(request.EndpointName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEndpointRequestObject()
        {
            moq::Mock<EndpointService.EndpointServiceClient> mockGrpcClient = new moq::Mock<EndpointService.EndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateEndpointRequest request = new UpdateEndpointRequest
            {
                Endpoint = new Endpoint(),
                UpdateMask = new wkt::FieldMask(),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedModels =
                {
                    new DeployedModel(),
                },
                TrafficSplit =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EncryptionSpec = new EncryptionSpec(),
                ModelDeploymentMonitoringJobAsModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            mockGrpcClient.Setup(x => x.UpdateEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EndpointServiceClient client = new EndpointServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint response = client.UpdateEndpoint(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEndpointRequestObjectAsync()
        {
            moq::Mock<EndpointService.EndpointServiceClient> mockGrpcClient = new moq::Mock<EndpointService.EndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateEndpointRequest request = new UpdateEndpointRequest
            {
                Endpoint = new Endpoint(),
                UpdateMask = new wkt::FieldMask(),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedModels =
                {
                    new DeployedModel(),
                },
                TrafficSplit =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EncryptionSpec = new EncryptionSpec(),
                ModelDeploymentMonitoringJobAsModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            mockGrpcClient.Setup(x => x.UpdateEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Endpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EndpointServiceClient client = new EndpointServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint responseCallSettings = await client.UpdateEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Endpoint responseCancellationToken = await client.UpdateEndpointAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEndpoint()
        {
            moq::Mock<EndpointService.EndpointServiceClient> mockGrpcClient = new moq::Mock<EndpointService.EndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateEndpointRequest request = new UpdateEndpointRequest
            {
                Endpoint = new Endpoint(),
                UpdateMask = new wkt::FieldMask(),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedModels =
                {
                    new DeployedModel(),
                },
                TrafficSplit =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EncryptionSpec = new EncryptionSpec(),
                ModelDeploymentMonitoringJobAsModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            mockGrpcClient.Setup(x => x.UpdateEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EndpointServiceClient client = new EndpointServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint response = client.UpdateEndpoint(request.Endpoint, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEndpointAsync()
        {
            moq::Mock<EndpointService.EndpointServiceClient> mockGrpcClient = new moq::Mock<EndpointService.EndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateEndpointRequest request = new UpdateEndpointRequest
            {
                Endpoint = new Endpoint(),
                UpdateMask = new wkt::FieldMask(),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedModels =
                {
                    new DeployedModel(),
                },
                TrafficSplit =
                {
                    {
                        "key8a0b6e3c",
                        1623286560
                    },
                },
                Etag = "etage8ad7218",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                EncryptionSpec = new EncryptionSpec(),
                ModelDeploymentMonitoringJobAsModelDeploymentMonitoringJobName = ModelDeploymentMonitoringJobName.FromProjectLocationModelDeploymentMonitoringJob("[PROJECT]", "[LOCATION]", "[MODEL_DEPLOYMENT_MONITORING_JOB]"),
            };
            mockGrpcClient.Setup(x => x.UpdateEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Endpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EndpointServiceClient client = new EndpointServiceClientImpl(mockGrpcClient.Object, null);
            Endpoint responseCallSettings = await client.UpdateEndpointAsync(request.Endpoint, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Endpoint responseCancellationToken = await client.UpdateEndpointAsync(request.Endpoint, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
