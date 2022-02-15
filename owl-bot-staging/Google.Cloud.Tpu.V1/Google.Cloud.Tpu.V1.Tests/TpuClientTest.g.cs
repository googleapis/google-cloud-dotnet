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

namespace Google.Cloud.Tpu.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedTpuClientTest
    {
        [xunit::FactAttribute]
        public void GetNodeRequestObject()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNodeRequest request = new GetNodeRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
            };
            Node expectedResponse = new Node
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
                Description = "description2cf9da67",
                AcceleratorType = "accelerator_type68a25f42",
#pragma warning disable CS0612
                IpAddress = "ip_address46a72553",
#pragma warning restore CS0612
                State = Node.Types.State.Restarting,
                HealthDescription = "health_descriptionb522cddb",
                TensorflowVersion = "tensorflow_version878dc75b",
                Network = "networkd22ce091",
                CidrBlock = "cidr_block0fc04814",
#pragma warning disable CS0612
                Port = "portfb551590",
#pragma warning restore CS0612
                ServiceAccount = "service_accounta3c1b923",
                CreateTime = new wkt::Timestamp(),
                SchedulingConfig = new SchedulingConfig(),
                NetworkEndpoints =
                {
                    new NetworkEndpoint(),
                },
                Health = Node.Types.Health.UnhealthyMaintenance,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                UseServiceNetworking = true,
                ApiVersion = Node.Types.ApiVersion.V2Alpha1,
                Symptoms = { new Symptom(), },
            };
            mockGrpcClient.Setup(x => x.GetNode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            Node response = client.GetNode(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNodeRequestObjectAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNodeRequest request = new GetNodeRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
            };
            Node expectedResponse = new Node
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
                Description = "description2cf9da67",
                AcceleratorType = "accelerator_type68a25f42",
#pragma warning disable CS0612
                IpAddress = "ip_address46a72553",
#pragma warning restore CS0612
                State = Node.Types.State.Restarting,
                HealthDescription = "health_descriptionb522cddb",
                TensorflowVersion = "tensorflow_version878dc75b",
                Network = "networkd22ce091",
                CidrBlock = "cidr_block0fc04814",
#pragma warning disable CS0612
                Port = "portfb551590",
#pragma warning restore CS0612
                ServiceAccount = "service_accounta3c1b923",
                CreateTime = new wkt::Timestamp(),
                SchedulingConfig = new SchedulingConfig(),
                NetworkEndpoints =
                {
                    new NetworkEndpoint(),
                },
                Health = Node.Types.Health.UnhealthyMaintenance,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                UseServiceNetworking = true,
                ApiVersion = Node.Types.ApiVersion.V2Alpha1,
                Symptoms = { new Symptom(), },
            };
            mockGrpcClient.Setup(x => x.GetNodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Node>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            Node responseCallSettings = await client.GetNodeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Node responseCancellationToken = await client.GetNodeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNode()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNodeRequest request = new GetNodeRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
            };
            Node expectedResponse = new Node
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
                Description = "description2cf9da67",
                AcceleratorType = "accelerator_type68a25f42",
#pragma warning disable CS0612
                IpAddress = "ip_address46a72553",
#pragma warning restore CS0612
                State = Node.Types.State.Restarting,
                HealthDescription = "health_descriptionb522cddb",
                TensorflowVersion = "tensorflow_version878dc75b",
                Network = "networkd22ce091",
                CidrBlock = "cidr_block0fc04814",
#pragma warning disable CS0612
                Port = "portfb551590",
#pragma warning restore CS0612
                ServiceAccount = "service_accounta3c1b923",
                CreateTime = new wkt::Timestamp(),
                SchedulingConfig = new SchedulingConfig(),
                NetworkEndpoints =
                {
                    new NetworkEndpoint(),
                },
                Health = Node.Types.Health.UnhealthyMaintenance,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                UseServiceNetworking = true,
                ApiVersion = Node.Types.ApiVersion.V2Alpha1,
                Symptoms = { new Symptom(), },
            };
            mockGrpcClient.Setup(x => x.GetNode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            Node response = client.GetNode(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNodeAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNodeRequest request = new GetNodeRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
            };
            Node expectedResponse = new Node
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
                Description = "description2cf9da67",
                AcceleratorType = "accelerator_type68a25f42",
#pragma warning disable CS0612
                IpAddress = "ip_address46a72553",
#pragma warning restore CS0612
                State = Node.Types.State.Restarting,
                HealthDescription = "health_descriptionb522cddb",
                TensorflowVersion = "tensorflow_version878dc75b",
                Network = "networkd22ce091",
                CidrBlock = "cidr_block0fc04814",
#pragma warning disable CS0612
                Port = "portfb551590",
#pragma warning restore CS0612
                ServiceAccount = "service_accounta3c1b923",
                CreateTime = new wkt::Timestamp(),
                SchedulingConfig = new SchedulingConfig(),
                NetworkEndpoints =
                {
                    new NetworkEndpoint(),
                },
                Health = Node.Types.Health.UnhealthyMaintenance,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                UseServiceNetworking = true,
                ApiVersion = Node.Types.ApiVersion.V2Alpha1,
                Symptoms = { new Symptom(), },
            };
            mockGrpcClient.Setup(x => x.GetNodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Node>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            Node responseCallSettings = await client.GetNodeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Node responseCancellationToken = await client.GetNodeAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetNodeResourceNames()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNodeRequest request = new GetNodeRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
            };
            Node expectedResponse = new Node
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
                Description = "description2cf9da67",
                AcceleratorType = "accelerator_type68a25f42",
#pragma warning disable CS0612
                IpAddress = "ip_address46a72553",
#pragma warning restore CS0612
                State = Node.Types.State.Restarting,
                HealthDescription = "health_descriptionb522cddb",
                TensorflowVersion = "tensorflow_version878dc75b",
                Network = "networkd22ce091",
                CidrBlock = "cidr_block0fc04814",
#pragma warning disable CS0612
                Port = "portfb551590",
#pragma warning restore CS0612
                ServiceAccount = "service_accounta3c1b923",
                CreateTime = new wkt::Timestamp(),
                SchedulingConfig = new SchedulingConfig(),
                NetworkEndpoints =
                {
                    new NetworkEndpoint(),
                },
                Health = Node.Types.Health.UnhealthyMaintenance,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                UseServiceNetworking = true,
                ApiVersion = Node.Types.ApiVersion.V2Alpha1,
                Symptoms = { new Symptom(), },
            };
            mockGrpcClient.Setup(x => x.GetNode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            Node response = client.GetNode(request.NodeName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetNodeResourceNamesAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetNodeRequest request = new GetNodeRequest
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
            };
            Node expectedResponse = new Node
            {
                NodeName = NodeName.FromProjectLocationNode("[PROJECT]", "[LOCATION]", "[NODE]"),
                Description = "description2cf9da67",
                AcceleratorType = "accelerator_type68a25f42",
#pragma warning disable CS0612
                IpAddress = "ip_address46a72553",
#pragma warning restore CS0612
                State = Node.Types.State.Restarting,
                HealthDescription = "health_descriptionb522cddb",
                TensorflowVersion = "tensorflow_version878dc75b",
                Network = "networkd22ce091",
                CidrBlock = "cidr_block0fc04814",
#pragma warning disable CS0612
                Port = "portfb551590",
#pragma warning restore CS0612
                ServiceAccount = "service_accounta3c1b923",
                CreateTime = new wkt::Timestamp(),
                SchedulingConfig = new SchedulingConfig(),
                NetworkEndpoints =
                {
                    new NetworkEndpoint(),
                },
                Health = Node.Types.Health.UnhealthyMaintenance,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                UseServiceNetworking = true,
                ApiVersion = Node.Types.ApiVersion.V2Alpha1,
                Symptoms = { new Symptom(), },
            };
            mockGrpcClient.Setup(x => x.GetNodeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Node>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            Node responseCallSettings = await client.GetNodeAsync(request.NodeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Node responseCancellationToken = await client.GetNodeAsync(request.NodeName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTensorFlowVersionRequestObject()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorFlowVersionRequest request = new GetTensorFlowVersionRequest
            {
                TensorFlowVersionName = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]"),
            };
            TensorFlowVersion expectedResponse = new TensorFlowVersion
            {
                TensorFlowVersionName = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]"),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.GetTensorFlowVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            TensorFlowVersion response = client.GetTensorFlowVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTensorFlowVersionRequestObjectAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorFlowVersionRequest request = new GetTensorFlowVersionRequest
            {
                TensorFlowVersionName = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]"),
            };
            TensorFlowVersion expectedResponse = new TensorFlowVersion
            {
                TensorFlowVersionName = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]"),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.GetTensorFlowVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorFlowVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            TensorFlowVersion responseCallSettings = await client.GetTensorFlowVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorFlowVersion responseCancellationToken = await client.GetTensorFlowVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTensorFlowVersion()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorFlowVersionRequest request = new GetTensorFlowVersionRequest
            {
                TensorFlowVersionName = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]"),
            };
            TensorFlowVersion expectedResponse = new TensorFlowVersion
            {
                TensorFlowVersionName = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]"),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.GetTensorFlowVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            TensorFlowVersion response = client.GetTensorFlowVersion(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTensorFlowVersionAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorFlowVersionRequest request = new GetTensorFlowVersionRequest
            {
                TensorFlowVersionName = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]"),
            };
            TensorFlowVersion expectedResponse = new TensorFlowVersion
            {
                TensorFlowVersionName = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]"),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.GetTensorFlowVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorFlowVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            TensorFlowVersion responseCallSettings = await client.GetTensorFlowVersionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorFlowVersion responseCancellationToken = await client.GetTensorFlowVersionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTensorFlowVersionResourceNames()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorFlowVersionRequest request = new GetTensorFlowVersionRequest
            {
                TensorFlowVersionName = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]"),
            };
            TensorFlowVersion expectedResponse = new TensorFlowVersion
            {
                TensorFlowVersionName = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]"),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.GetTensorFlowVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            TensorFlowVersion response = client.GetTensorFlowVersion(request.TensorFlowVersionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTensorFlowVersionResourceNamesAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTensorFlowVersionRequest request = new GetTensorFlowVersionRequest
            {
                TensorFlowVersionName = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]"),
            };
            TensorFlowVersion expectedResponse = new TensorFlowVersion
            {
                TensorFlowVersionName = TensorFlowVersionName.FromProjectLocationTensorFlowVersion("[PROJECT]", "[LOCATION]", "[TENSOR_FLOW_VERSION]"),
                Version = "version102ff72a",
            };
            mockGrpcClient.Setup(x => x.GetTensorFlowVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TensorFlowVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            TensorFlowVersion responseCallSettings = await client.GetTensorFlowVersionAsync(request.TensorFlowVersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TensorFlowVersion responseCancellationToken = await client.GetTensorFlowVersionAsync(request.TensorFlowVersionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAcceleratorTypeRequestObject()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
            };
            AcceleratorType expectedResponse = new AcceleratorType
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
                Type = "typee2cc9d59",
            };
            mockGrpcClient.Setup(x => x.GetAcceleratorType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            AcceleratorType response = client.GetAcceleratorType(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAcceleratorTypeRequestObjectAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
            };
            AcceleratorType expectedResponse = new AcceleratorType
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
                Type = "typee2cc9d59",
            };
            mockGrpcClient.Setup(x => x.GetAcceleratorTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AcceleratorType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            AcceleratorType responseCallSettings = await client.GetAcceleratorTypeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AcceleratorType responseCancellationToken = await client.GetAcceleratorTypeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAcceleratorType()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
            };
            AcceleratorType expectedResponse = new AcceleratorType
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
                Type = "typee2cc9d59",
            };
            mockGrpcClient.Setup(x => x.GetAcceleratorType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            AcceleratorType response = client.GetAcceleratorType(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAcceleratorTypeAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
            };
            AcceleratorType expectedResponse = new AcceleratorType
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
                Type = "typee2cc9d59",
            };
            mockGrpcClient.Setup(x => x.GetAcceleratorTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AcceleratorType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            AcceleratorType responseCallSettings = await client.GetAcceleratorTypeAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AcceleratorType responseCancellationToken = await client.GetAcceleratorTypeAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetAcceleratorTypeResourceNames()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
            };
            AcceleratorType expectedResponse = new AcceleratorType
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
                Type = "typee2cc9d59",
            };
            mockGrpcClient.Setup(x => x.GetAcceleratorType(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            AcceleratorType response = client.GetAcceleratorType(request.AcceleratorTypeName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAcceleratorTypeResourceNamesAsync()
        {
            moq::Mock<Tpu.TpuClient> mockGrpcClient = new moq::Mock<Tpu.TpuClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
            };
            AcceleratorType expectedResponse = new AcceleratorType
            {
                AcceleratorTypeName = AcceleratorTypeName.FromProjectLocationAcceleratorType("[PROJECT]", "[LOCATION]", "[ACCELERATOR_TYPE]"),
                Type = "typee2cc9d59",
            };
            mockGrpcClient.Setup(x => x.GetAcceleratorTypeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AcceleratorType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TpuClient client = new TpuClientImpl(mockGrpcClient.Object, null);
            AcceleratorType responseCallSettings = await client.GetAcceleratorTypeAsync(request.AcceleratorTypeName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AcceleratorType responseCancellationToken = await client.GetAcceleratorTypeAsync(request.AcceleratorTypeName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
