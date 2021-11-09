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

namespace Google.Cloud.Ids.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedIDSClientTest
    {
        [xunit::FactAttribute]
        public void GetEndpointRequestObject()
        {
            moq::Mock<IDS.IDSClient> mockGrpcClient = new moq::Mock<IDS.IDSClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Network = "networkd22ce091",
                EndpointForwardingRule = "endpoint_forwarding_ruleac397159",
                EndpointIp = "endpoint_ip2239df0a",
                Description = "description2cf9da67",
                Severity = Endpoint.Types.Severity.Unspecified,
                State = Endpoint.Types.State.Ready,
                TrafficLogs = true,
            };
            mockGrpcClient.Setup(x => x.GetEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IDSClient client = new IDSClientImpl(mockGrpcClient.Object, null);
            Endpoint response = client.GetEndpoint(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEndpointRequestObjectAsync()
        {
            moq::Mock<IDS.IDSClient> mockGrpcClient = new moq::Mock<IDS.IDSClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Network = "networkd22ce091",
                EndpointForwardingRule = "endpoint_forwarding_ruleac397159",
                EndpointIp = "endpoint_ip2239df0a",
                Description = "description2cf9da67",
                Severity = Endpoint.Types.Severity.Unspecified,
                State = Endpoint.Types.State.Ready,
                TrafficLogs = true,
            };
            mockGrpcClient.Setup(x => x.GetEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Endpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IDSClient client = new IDSClientImpl(mockGrpcClient.Object, null);
            Endpoint responseCallSettings = await client.GetEndpointAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Endpoint responseCancellationToken = await client.GetEndpointAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEndpoint()
        {
            moq::Mock<IDS.IDSClient> mockGrpcClient = new moq::Mock<IDS.IDSClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Network = "networkd22ce091",
                EndpointForwardingRule = "endpoint_forwarding_ruleac397159",
                EndpointIp = "endpoint_ip2239df0a",
                Description = "description2cf9da67",
                Severity = Endpoint.Types.Severity.Unspecified,
                State = Endpoint.Types.State.Ready,
                TrafficLogs = true,
            };
            mockGrpcClient.Setup(x => x.GetEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IDSClient client = new IDSClientImpl(mockGrpcClient.Object, null);
            Endpoint response = client.GetEndpoint(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEndpointAsync()
        {
            moq::Mock<IDS.IDSClient> mockGrpcClient = new moq::Mock<IDS.IDSClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Network = "networkd22ce091",
                EndpointForwardingRule = "endpoint_forwarding_ruleac397159",
                EndpointIp = "endpoint_ip2239df0a",
                Description = "description2cf9da67",
                Severity = Endpoint.Types.Severity.Unspecified,
                State = Endpoint.Types.State.Ready,
                TrafficLogs = true,
            };
            mockGrpcClient.Setup(x => x.GetEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Endpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IDSClient client = new IDSClientImpl(mockGrpcClient.Object, null);
            Endpoint responseCallSettings = await client.GetEndpointAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Endpoint responseCancellationToken = await client.GetEndpointAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEndpointResourceNames()
        {
            moq::Mock<IDS.IDSClient> mockGrpcClient = new moq::Mock<IDS.IDSClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Network = "networkd22ce091",
                EndpointForwardingRule = "endpoint_forwarding_ruleac397159",
                EndpointIp = "endpoint_ip2239df0a",
                Description = "description2cf9da67",
                Severity = Endpoint.Types.Severity.Unspecified,
                State = Endpoint.Types.State.Ready,
                TrafficLogs = true,
            };
            mockGrpcClient.Setup(x => x.GetEndpoint(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IDSClient client = new IDSClientImpl(mockGrpcClient.Object, null);
            Endpoint response = client.GetEndpoint(request.EndpointName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEndpointResourceNamesAsync()
        {
            moq::Mock<IDS.IDSClient> mockGrpcClient = new moq::Mock<IDS.IDSClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetEndpointRequest request = new GetEndpointRequest
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
            };
            Endpoint expectedResponse = new Endpoint
            {
                EndpointName = EndpointName.FromProjectLocationEndpoint("[PROJECT]", "[LOCATION]", "[ENDPOINT]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Network = "networkd22ce091",
                EndpointForwardingRule = "endpoint_forwarding_ruleac397159",
                EndpointIp = "endpoint_ip2239df0a",
                Description = "description2cf9da67",
                Severity = Endpoint.Types.Severity.Unspecified,
                State = Endpoint.Types.State.Ready,
                TrafficLogs = true,
            };
            mockGrpcClient.Setup(x => x.GetEndpointAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Endpoint>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IDSClient client = new IDSClientImpl(mockGrpcClient.Object, null);
            Endpoint responseCallSettings = await client.GetEndpointAsync(request.EndpointName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Endpoint responseCancellationToken = await client.GetEndpointAsync(request.EndpointName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
