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
    public sealed class GeneratedIndexEndpointServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetIndexEndpointRequestObject()
        {
            moq::Mock<IndexEndpointService.IndexEndpointServiceClient> mockGrpcClient = new moq::Mock<IndexEndpointService.IndexEndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIndexEndpointRequest request = new GetIndexEndpointRequest
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
            };
            IndexEndpoint expectedResponse = new IndexEndpoint
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedIndexes =
                {
                    new DeployedIndex(),
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
                Network = "networkd22ce091",
#pragma warning disable CS0612
                EnablePrivateServiceConnect = false,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetIndexEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IndexEndpointServiceClient client = new IndexEndpointServiceClientImpl(mockGrpcClient.Object, null);
            IndexEndpoint response = client.GetIndexEndpoint(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIndexEndpointRequestObjectAsync()
        {
            moq::Mock<IndexEndpointService.IndexEndpointServiceClient> mockGrpcClient = new moq::Mock<IndexEndpointService.IndexEndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIndexEndpointRequest request = new GetIndexEndpointRequest
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
            };
            IndexEndpoint expectedResponse = new IndexEndpoint
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedIndexes =
                {
                    new DeployedIndex(),
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
                Network = "networkd22ce091",
#pragma warning disable CS0612
                EnablePrivateServiceConnect = false,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetIndexEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IndexEndpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IndexEndpointServiceClient client = new IndexEndpointServiceClientImpl(mockGrpcClient.Object, null);
            IndexEndpoint responseCallSettings = await client.GetIndexEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IndexEndpoint responseCancellationToken = await client.GetIndexEndpointAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIndexEndpoint()
        {
            moq::Mock<IndexEndpointService.IndexEndpointServiceClient> mockGrpcClient = new moq::Mock<IndexEndpointService.IndexEndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIndexEndpointRequest request = new GetIndexEndpointRequest
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
            };
            IndexEndpoint expectedResponse = new IndexEndpoint
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedIndexes =
                {
                    new DeployedIndex(),
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
                Network = "networkd22ce091",
#pragma warning disable CS0612
                EnablePrivateServiceConnect = false,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetIndexEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IndexEndpointServiceClient client = new IndexEndpointServiceClientImpl(mockGrpcClient.Object, null);
            IndexEndpoint response = client.GetIndexEndpoint(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIndexEndpointAsync()
        {
            moq::Mock<IndexEndpointService.IndexEndpointServiceClient> mockGrpcClient = new moq::Mock<IndexEndpointService.IndexEndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIndexEndpointRequest request = new GetIndexEndpointRequest
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
            };
            IndexEndpoint expectedResponse = new IndexEndpoint
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedIndexes =
                {
                    new DeployedIndex(),
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
                Network = "networkd22ce091",
#pragma warning disable CS0612
                EnablePrivateServiceConnect = false,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetIndexEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IndexEndpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IndexEndpointServiceClient client = new IndexEndpointServiceClientImpl(mockGrpcClient.Object, null);
            IndexEndpoint responseCallSettings = await client.GetIndexEndpointAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IndexEndpoint responseCancellationToken = await client.GetIndexEndpointAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIndexEndpointResourceNames()
        {
            moq::Mock<IndexEndpointService.IndexEndpointServiceClient> mockGrpcClient = new moq::Mock<IndexEndpointService.IndexEndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIndexEndpointRequest request = new GetIndexEndpointRequest
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
            };
            IndexEndpoint expectedResponse = new IndexEndpoint
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedIndexes =
                {
                    new DeployedIndex(),
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
                Network = "networkd22ce091",
#pragma warning disable CS0612
                EnablePrivateServiceConnect = false,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetIndexEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IndexEndpointServiceClient client = new IndexEndpointServiceClientImpl(mockGrpcClient.Object, null);
            IndexEndpoint response = client.GetIndexEndpoint(request.IndexEndpointName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIndexEndpointResourceNamesAsync()
        {
            moq::Mock<IndexEndpointService.IndexEndpointServiceClient> mockGrpcClient = new moq::Mock<IndexEndpointService.IndexEndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetIndexEndpointRequest request = new GetIndexEndpointRequest
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
            };
            IndexEndpoint expectedResponse = new IndexEndpoint
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedIndexes =
                {
                    new DeployedIndex(),
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
                Network = "networkd22ce091",
#pragma warning disable CS0612
                EnablePrivateServiceConnect = false,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.GetIndexEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IndexEndpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IndexEndpointServiceClient client = new IndexEndpointServiceClientImpl(mockGrpcClient.Object, null);
            IndexEndpoint responseCallSettings = await client.GetIndexEndpointAsync(request.IndexEndpointName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IndexEndpoint responseCancellationToken = await client.GetIndexEndpointAsync(request.IndexEndpointName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateIndexEndpointRequestObject()
        {
            moq::Mock<IndexEndpointService.IndexEndpointServiceClient> mockGrpcClient = new moq::Mock<IndexEndpointService.IndexEndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateIndexEndpointRequest request = new UpdateIndexEndpointRequest
            {
                IndexEndpoint = new IndexEndpoint(),
                UpdateMask = new wkt::FieldMask(),
            };
            IndexEndpoint expectedResponse = new IndexEndpoint
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedIndexes =
                {
                    new DeployedIndex(),
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
                Network = "networkd22ce091",
#pragma warning disable CS0612
                EnablePrivateServiceConnect = false,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.UpdateIndexEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IndexEndpointServiceClient client = new IndexEndpointServiceClientImpl(mockGrpcClient.Object, null);
            IndexEndpoint response = client.UpdateIndexEndpoint(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateIndexEndpointRequestObjectAsync()
        {
            moq::Mock<IndexEndpointService.IndexEndpointServiceClient> mockGrpcClient = new moq::Mock<IndexEndpointService.IndexEndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateIndexEndpointRequest request = new UpdateIndexEndpointRequest
            {
                IndexEndpoint = new IndexEndpoint(),
                UpdateMask = new wkt::FieldMask(),
            };
            IndexEndpoint expectedResponse = new IndexEndpoint
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedIndexes =
                {
                    new DeployedIndex(),
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
                Network = "networkd22ce091",
#pragma warning disable CS0612
                EnablePrivateServiceConnect = false,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.UpdateIndexEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IndexEndpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IndexEndpointServiceClient client = new IndexEndpointServiceClientImpl(mockGrpcClient.Object, null);
            IndexEndpoint responseCallSettings = await client.UpdateIndexEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IndexEndpoint responseCancellationToken = await client.UpdateIndexEndpointAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateIndexEndpoint()
        {
            moq::Mock<IndexEndpointService.IndexEndpointServiceClient> mockGrpcClient = new moq::Mock<IndexEndpointService.IndexEndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateIndexEndpointRequest request = new UpdateIndexEndpointRequest
            {
                IndexEndpoint = new IndexEndpoint(),
                UpdateMask = new wkt::FieldMask(),
            };
            IndexEndpoint expectedResponse = new IndexEndpoint
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedIndexes =
                {
                    new DeployedIndex(),
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
                Network = "networkd22ce091",
#pragma warning disable CS0612
                EnablePrivateServiceConnect = false,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.UpdateIndexEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IndexEndpointServiceClient client = new IndexEndpointServiceClientImpl(mockGrpcClient.Object, null);
            IndexEndpoint response = client.UpdateIndexEndpoint(request.IndexEndpoint, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateIndexEndpointAsync()
        {
            moq::Mock<IndexEndpointService.IndexEndpointServiceClient> mockGrpcClient = new moq::Mock<IndexEndpointService.IndexEndpointServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateIndexEndpointRequest request = new UpdateIndexEndpointRequest
            {
                IndexEndpoint = new IndexEndpoint(),
                UpdateMask = new wkt::FieldMask(),
            };
            IndexEndpoint expectedResponse = new IndexEndpoint
            {
                IndexEndpointName = IndexEndpointName.FromProjectLocationIndexEndpoint("[PROJECT]", "[LOCATION]", "[INDEX_ENDPOINT]"),
                DisplayName = "display_name137f65c2",
                Description = "description2cf9da67",
                DeployedIndexes =
                {
                    new DeployedIndex(),
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
                Network = "networkd22ce091",
#pragma warning disable CS0612
                EnablePrivateServiceConnect = false,
#pragma warning restore CS0612
            };
            mockGrpcClient.Setup(x => x.UpdateIndexEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<IndexEndpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IndexEndpointServiceClient client = new IndexEndpointServiceClientImpl(mockGrpcClient.Object, null);
            IndexEndpoint responseCallSettings = await client.UpdateIndexEndpointAsync(request.IndexEndpoint, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            IndexEndpoint responseCancellationToken = await client.UpdateIndexEndpointAsync(request.IndexEndpoint, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
