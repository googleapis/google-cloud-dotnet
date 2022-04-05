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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gciv = Google.Cloud.Iam.V1;
using gcscv = Google.Cloud.Spanner.Common.V1;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Spanner.Admin.Instance.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedInstanceAdminClientTest
    {
        [xunit::FactAttribute]
        public void GetInstanceConfigRequestObject()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceConfigRequest request = new GetInstanceConfigRequest
            {
                InstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
            };
            InstanceConfig expectedResponse = new InstanceConfig
            {
                InstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "display_name137f65c2",
                Replicas = { new ReplicaInfo(), },
                LeaderOptions =
                {
                    "leader_optionscedbfd6e",
                },
            };
            mockGrpcClient.Setup(x => x.GetInstanceConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceConfig response = client.GetInstanceConfig(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceConfigRequestObjectAsync()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceConfigRequest request = new GetInstanceConfigRequest
            {
                InstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
            };
            InstanceConfig expectedResponse = new InstanceConfig
            {
                InstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "display_name137f65c2",
                Replicas = { new ReplicaInfo(), },
                LeaderOptions =
                {
                    "leader_optionscedbfd6e",
                },
            };
            mockGrpcClient.Setup(x => x.GetInstanceConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceConfig responseCallSettings = await client.GetInstanceConfigAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceConfig responseCancellationToken = await client.GetInstanceConfigAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceConfig()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceConfigRequest request = new GetInstanceConfigRequest
            {
                InstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
            };
            InstanceConfig expectedResponse = new InstanceConfig
            {
                InstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "display_name137f65c2",
                Replicas = { new ReplicaInfo(), },
                LeaderOptions =
                {
                    "leader_optionscedbfd6e",
                },
            };
            mockGrpcClient.Setup(x => x.GetInstanceConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceConfig response = client.GetInstanceConfig(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceConfigAsync()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceConfigRequest request = new GetInstanceConfigRequest
            {
                InstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
            };
            InstanceConfig expectedResponse = new InstanceConfig
            {
                InstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "display_name137f65c2",
                Replicas = { new ReplicaInfo(), },
                LeaderOptions =
                {
                    "leader_optionscedbfd6e",
                },
            };
            mockGrpcClient.Setup(x => x.GetInstanceConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceConfig responseCallSettings = await client.GetInstanceConfigAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceConfig responseCancellationToken = await client.GetInstanceConfigAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceConfigResourceNames()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceConfigRequest request = new GetInstanceConfigRequest
            {
                InstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
            };
            InstanceConfig expectedResponse = new InstanceConfig
            {
                InstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "display_name137f65c2",
                Replicas = { new ReplicaInfo(), },
                LeaderOptions =
                {
                    "leader_optionscedbfd6e",
                },
            };
            mockGrpcClient.Setup(x => x.GetInstanceConfig(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceConfig response = client.GetInstanceConfig(request.InstanceConfigName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceConfigResourceNamesAsync()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceConfigRequest request = new GetInstanceConfigRequest
            {
                InstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
            };
            InstanceConfig expectedResponse = new InstanceConfig
            {
                InstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "display_name137f65c2",
                Replicas = { new ReplicaInfo(), },
                LeaderOptions =
                {
                    "leader_optionscedbfd6e",
                },
            };
            mockGrpcClient.Setup(x => x.GetInstanceConfigAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InstanceConfig>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            InstanceConfig responseCallSettings = await client.GetInstanceConfigAsync(request.InstanceConfigName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InstanceConfig responseCancellationToken = await client.GetInstanceConfigAsync(request.InstanceConfigName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceRequestObject()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = gcscv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                FieldMask = new wkt::FieldMask(),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = gcscv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                ConfigAsInstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "display_name137f65c2",
                NodeCount = -1659500730,
                State = Instance.Types.State.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EndpointUris =
                {
                    "endpoint_uris93f83605",
                },
                ProcessingUnits = 759326966,
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceRequestObjectAsync()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = gcscv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                FieldMask = new wkt::FieldMask(),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = gcscv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                ConfigAsInstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "display_name137f65c2",
                NodeCount = -1659500730,
                State = Instance.Types.State.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EndpointUris =
                {
                    "endpoint_uris93f83605",
                },
                ProcessingUnits = 759326966,
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstance()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = gcscv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = gcscv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                ConfigAsInstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "display_name137f65c2",
                NodeCount = -1659500730,
                State = Instance.Types.State.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EndpointUris =
                {
                    "endpoint_uris93f83605",
                },
                ProcessingUnits = 759326966,
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceAsync()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = gcscv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = gcscv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                ConfigAsInstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "display_name137f65c2",
                NodeCount = -1659500730,
                State = Instance.Types.State.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EndpointUris =
                {
                    "endpoint_uris93f83605",
                },
                ProcessingUnits = 759326966,
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetInstanceResourceNames()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = gcscv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = gcscv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                ConfigAsInstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "display_name137f65c2",
                NodeCount = -1659500730,
                State = Instance.Types.State.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EndpointUris =
                {
                    "endpoint_uris93f83605",
                },
                ProcessingUnits = 759326966,
            };
            mockGrpcClient.Setup(x => x.GetInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            Instance response = client.GetInstance(request.InstanceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetInstanceResourceNamesAsync()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetInstanceRequest request = new GetInstanceRequest
            {
                InstanceName = gcscv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            Instance expectedResponse = new Instance
            {
                InstanceName = gcscv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
                ConfigAsInstanceConfigName = InstanceConfigName.FromProjectInstanceConfig("[PROJECT]", "[INSTANCE_CONFIG]"),
                DisplayName = "display_name137f65c2",
                NodeCount = -1659500730,
                State = Instance.Types.State.Unspecified,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                EndpointUris =
                {
                    "endpoint_uris93f83605",
                },
                ProcessingUnits = 759326966,
            };
            mockGrpcClient.Setup(x => x.GetInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Instance>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            Instance responseCallSettings = await client.GetInstanceAsync(request.InstanceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Instance responseCancellationToken = await client.GetInstanceAsync(request.InstanceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteInstanceRequestObject()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = gcscv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteInstance(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteInstanceRequestObjectAsync()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = gcscv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteInstanceAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteInstanceAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteInstance()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = gcscv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteInstance(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteInstanceAsync()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = gcscv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteInstanceAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteInstanceAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteInstanceResourceNames()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = gcscv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInstance(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            client.DeleteInstance(request.InstanceName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteInstanceResourceNamesAsync()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteInstanceRequest request = new DeleteInstanceRequest
            {
                InstanceName = gcscv::InstanceName.FromProjectInstance("[PROJECT]", "[INSTANCE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteInstanceAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            await client.DeleteInstanceAsync(request.InstanceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteInstanceAsync(request.InstanceName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyRequestObject()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyRequestObjectAsync()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
                UpdateMask = new wkt::FieldMask(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicy()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.Resource, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyAsync()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.Resource, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.Resource, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetIamPolicyResourceNames()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.SetIamPolicy(request.ResourceAsResourceName, request.Policy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetIamPolicyResourceNamesAsync()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::SetIamPolicyRequest request = new gciv::SetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Policy = new gciv::Policy(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.SetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.SetIamPolicyAsync(request.ResourceAsResourceName, request.Policy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyRequestObject()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyRequestObjectAsync()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Options = new gciv::GetPolicyOptions(),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicy()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.Resource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyAsync()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.Resource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.Resource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetIamPolicyResourceNames()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy response = client.GetIamPolicy(request.ResourceAsResourceName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetIamPolicyResourceNamesAsync()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::GetIamPolicyRequest request = new gciv::GetIamPolicyRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
            };
            gciv::Policy expectedResponse = new gciv::Policy
            {
                Version = 271578922,
                Etag = proto::ByteString.CopyFromUtf8("etage8ad7218"),
                Bindings =
                {
                    new gciv::Binding(),
                },
                AuditConfigs =
                {
                    new gciv::AuditConfig(),
                },
            };
            mockGrpcClient.Setup(x => x.GetIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::Policy responseCallSettings = await client.GetIamPolicyAsync(request.ResourceAsResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::Policy responseCancellationToken = await client.GetIamPolicyAsync(request.ResourceAsResourceName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.Resource, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Resource, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsResourceNames()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse response = client.TestIamPermissions(request.ResourceAsResourceName, request.Permissions);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsResourceNamesAsync()
        {
            moq::Mock<InstanceAdmin.InstanceAdminClient> mockGrpcClient = new moq::Mock<InstanceAdmin.InstanceAdminClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            gciv::TestIamPermissionsRequest request = new gciv::TestIamPermissionsRequest
            {
                ResourceAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            gciv::TestIamPermissionsResponse expectedResponse = new gciv::TestIamPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gciv::TestIamPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InstanceAdminClient client = new InstanceAdminClientImpl(mockGrpcClient.Object, null);
            gciv::TestIamPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gciv::TestIamPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.ResourceAsResourceName, request.Permissions, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
