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
using gagr = Google.Api.Gax.ResourceNames;
using gciv = Google.Cloud.Iam.V1;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Kms.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedEkmServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetEkmConnectionRequestObject()
        {
            moq::Mock<EkmService.EkmServiceClient> mockGrpcClient = new moq::Mock<EkmService.EkmServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetEkmConnectionRequest request = new GetEkmConnectionRequest
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
            };
            EkmConnection expectedResponse = new EkmConnection
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                ServiceResolvers =
                {
                    new EkmConnection.Types.ServiceResolver(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetEkmConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EkmServiceClient client = new EkmServiceClientImpl(mockGrpcClient.Object, null, null);
            EkmConnection response = client.GetEkmConnection(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEkmConnectionRequestObjectAsync()
        {
            moq::Mock<EkmService.EkmServiceClient> mockGrpcClient = new moq::Mock<EkmService.EkmServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetEkmConnectionRequest request = new GetEkmConnectionRequest
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
            };
            EkmConnection expectedResponse = new EkmConnection
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                ServiceResolvers =
                {
                    new EkmConnection.Types.ServiceResolver(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetEkmConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EkmConnection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EkmServiceClient client = new EkmServiceClientImpl(mockGrpcClient.Object, null, null);
            EkmConnection responseCallSettings = await client.GetEkmConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EkmConnection responseCancellationToken = await client.GetEkmConnectionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEkmConnection()
        {
            moq::Mock<EkmService.EkmServiceClient> mockGrpcClient = new moq::Mock<EkmService.EkmServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetEkmConnectionRequest request = new GetEkmConnectionRequest
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
            };
            EkmConnection expectedResponse = new EkmConnection
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                ServiceResolvers =
                {
                    new EkmConnection.Types.ServiceResolver(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetEkmConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EkmServiceClient client = new EkmServiceClientImpl(mockGrpcClient.Object, null, null);
            EkmConnection response = client.GetEkmConnection(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEkmConnectionAsync()
        {
            moq::Mock<EkmService.EkmServiceClient> mockGrpcClient = new moq::Mock<EkmService.EkmServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetEkmConnectionRequest request = new GetEkmConnectionRequest
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
            };
            EkmConnection expectedResponse = new EkmConnection
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                ServiceResolvers =
                {
                    new EkmConnection.Types.ServiceResolver(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetEkmConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EkmConnection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EkmServiceClient client = new EkmServiceClientImpl(mockGrpcClient.Object, null, null);
            EkmConnection responseCallSettings = await client.GetEkmConnectionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EkmConnection responseCancellationToken = await client.GetEkmConnectionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEkmConnectionResourceNames()
        {
            moq::Mock<EkmService.EkmServiceClient> mockGrpcClient = new moq::Mock<EkmService.EkmServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetEkmConnectionRequest request = new GetEkmConnectionRequest
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
            };
            EkmConnection expectedResponse = new EkmConnection
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                ServiceResolvers =
                {
                    new EkmConnection.Types.ServiceResolver(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetEkmConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EkmServiceClient client = new EkmServiceClientImpl(mockGrpcClient.Object, null, null);
            EkmConnection response = client.GetEkmConnection(request.EkmConnectionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEkmConnectionResourceNamesAsync()
        {
            moq::Mock<EkmService.EkmServiceClient> mockGrpcClient = new moq::Mock<EkmService.EkmServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            GetEkmConnectionRequest request = new GetEkmConnectionRequest
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
            };
            EkmConnection expectedResponse = new EkmConnection
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                ServiceResolvers =
                {
                    new EkmConnection.Types.ServiceResolver(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetEkmConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EkmConnection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EkmServiceClient client = new EkmServiceClientImpl(mockGrpcClient.Object, null, null);
            EkmConnection responseCallSettings = await client.GetEkmConnectionAsync(request.EkmConnectionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EkmConnection responseCancellationToken = await client.GetEkmConnectionAsync(request.EkmConnectionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEkmConnectionRequestObject()
        {
            moq::Mock<EkmService.EkmServiceClient> mockGrpcClient = new moq::Mock<EkmService.EkmServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateEkmConnectionRequest request = new CreateEkmConnectionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EkmConnectionId = "ekm_connection_id1bd1ac0c",
                EkmConnection = new EkmConnection(),
            };
            EkmConnection expectedResponse = new EkmConnection
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                ServiceResolvers =
                {
                    new EkmConnection.Types.ServiceResolver(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateEkmConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EkmServiceClient client = new EkmServiceClientImpl(mockGrpcClient.Object, null, null);
            EkmConnection response = client.CreateEkmConnection(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEkmConnectionRequestObjectAsync()
        {
            moq::Mock<EkmService.EkmServiceClient> mockGrpcClient = new moq::Mock<EkmService.EkmServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateEkmConnectionRequest request = new CreateEkmConnectionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EkmConnectionId = "ekm_connection_id1bd1ac0c",
                EkmConnection = new EkmConnection(),
            };
            EkmConnection expectedResponse = new EkmConnection
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                ServiceResolvers =
                {
                    new EkmConnection.Types.ServiceResolver(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateEkmConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EkmConnection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EkmServiceClient client = new EkmServiceClientImpl(mockGrpcClient.Object, null, null);
            EkmConnection responseCallSettings = await client.CreateEkmConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EkmConnection responseCancellationToken = await client.CreateEkmConnectionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEkmConnection()
        {
            moq::Mock<EkmService.EkmServiceClient> mockGrpcClient = new moq::Mock<EkmService.EkmServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateEkmConnectionRequest request = new CreateEkmConnectionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EkmConnectionId = "ekm_connection_id1bd1ac0c",
                EkmConnection = new EkmConnection(),
            };
            EkmConnection expectedResponse = new EkmConnection
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                ServiceResolvers =
                {
                    new EkmConnection.Types.ServiceResolver(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateEkmConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EkmServiceClient client = new EkmServiceClientImpl(mockGrpcClient.Object, null, null);
            EkmConnection response = client.CreateEkmConnection(request.Parent, request.EkmConnectionId, request.EkmConnection);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEkmConnectionAsync()
        {
            moq::Mock<EkmService.EkmServiceClient> mockGrpcClient = new moq::Mock<EkmService.EkmServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateEkmConnectionRequest request = new CreateEkmConnectionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EkmConnectionId = "ekm_connection_id1bd1ac0c",
                EkmConnection = new EkmConnection(),
            };
            EkmConnection expectedResponse = new EkmConnection
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                ServiceResolvers =
                {
                    new EkmConnection.Types.ServiceResolver(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateEkmConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EkmConnection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EkmServiceClient client = new EkmServiceClientImpl(mockGrpcClient.Object, null, null);
            EkmConnection responseCallSettings = await client.CreateEkmConnectionAsync(request.Parent, request.EkmConnectionId, request.EkmConnection, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EkmConnection responseCancellationToken = await client.CreateEkmConnectionAsync(request.Parent, request.EkmConnectionId, request.EkmConnection, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateEkmConnectionResourceNames()
        {
            moq::Mock<EkmService.EkmServiceClient> mockGrpcClient = new moq::Mock<EkmService.EkmServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateEkmConnectionRequest request = new CreateEkmConnectionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EkmConnectionId = "ekm_connection_id1bd1ac0c",
                EkmConnection = new EkmConnection(),
            };
            EkmConnection expectedResponse = new EkmConnection
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                ServiceResolvers =
                {
                    new EkmConnection.Types.ServiceResolver(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateEkmConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EkmServiceClient client = new EkmServiceClientImpl(mockGrpcClient.Object, null, null);
            EkmConnection response = client.CreateEkmConnection(request.ParentAsLocationName, request.EkmConnectionId, request.EkmConnection);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateEkmConnectionResourceNamesAsync()
        {
            moq::Mock<EkmService.EkmServiceClient> mockGrpcClient = new moq::Mock<EkmService.EkmServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            CreateEkmConnectionRequest request = new CreateEkmConnectionRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                EkmConnectionId = "ekm_connection_id1bd1ac0c",
                EkmConnection = new EkmConnection(),
            };
            EkmConnection expectedResponse = new EkmConnection
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                ServiceResolvers =
                {
                    new EkmConnection.Types.ServiceResolver(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.CreateEkmConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EkmConnection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EkmServiceClient client = new EkmServiceClientImpl(mockGrpcClient.Object, null, null);
            EkmConnection responseCallSettings = await client.CreateEkmConnectionAsync(request.ParentAsLocationName, request.EkmConnectionId, request.EkmConnection, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EkmConnection responseCancellationToken = await client.CreateEkmConnectionAsync(request.ParentAsLocationName, request.EkmConnectionId, request.EkmConnection, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEkmConnectionRequestObject()
        {
            moq::Mock<EkmService.EkmServiceClient> mockGrpcClient = new moq::Mock<EkmService.EkmServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateEkmConnectionRequest request = new UpdateEkmConnectionRequest
            {
                EkmConnection = new EkmConnection(),
                UpdateMask = new wkt::FieldMask(),
            };
            EkmConnection expectedResponse = new EkmConnection
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                ServiceResolvers =
                {
                    new EkmConnection.Types.ServiceResolver(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.UpdateEkmConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EkmServiceClient client = new EkmServiceClientImpl(mockGrpcClient.Object, null, null);
            EkmConnection response = client.UpdateEkmConnection(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEkmConnectionRequestObjectAsync()
        {
            moq::Mock<EkmService.EkmServiceClient> mockGrpcClient = new moq::Mock<EkmService.EkmServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateEkmConnectionRequest request = new UpdateEkmConnectionRequest
            {
                EkmConnection = new EkmConnection(),
                UpdateMask = new wkt::FieldMask(),
            };
            EkmConnection expectedResponse = new EkmConnection
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                ServiceResolvers =
                {
                    new EkmConnection.Types.ServiceResolver(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.UpdateEkmConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EkmConnection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EkmServiceClient client = new EkmServiceClientImpl(mockGrpcClient.Object, null, null);
            EkmConnection responseCallSettings = await client.UpdateEkmConnectionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EkmConnection responseCancellationToken = await client.UpdateEkmConnectionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateEkmConnection()
        {
            moq::Mock<EkmService.EkmServiceClient> mockGrpcClient = new moq::Mock<EkmService.EkmServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateEkmConnectionRequest request = new UpdateEkmConnectionRequest
            {
                EkmConnection = new EkmConnection(),
                UpdateMask = new wkt::FieldMask(),
            };
            EkmConnection expectedResponse = new EkmConnection
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                ServiceResolvers =
                {
                    new EkmConnection.Types.ServiceResolver(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.UpdateEkmConnection(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            EkmServiceClient client = new EkmServiceClientImpl(mockGrpcClient.Object, null, null);
            EkmConnection response = client.UpdateEkmConnection(request.EkmConnection, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateEkmConnectionAsync()
        {
            moq::Mock<EkmService.EkmServiceClient> mockGrpcClient = new moq::Mock<EkmService.EkmServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient()).Returns(new moq::Mock<gciv::IAMPolicy.IAMPolicyClient>().Object);
            UpdateEkmConnectionRequest request = new UpdateEkmConnectionRequest
            {
                EkmConnection = new EkmConnection(),
                UpdateMask = new wkt::FieldMask(),
            };
            EkmConnection expectedResponse = new EkmConnection
            {
                EkmConnectionName = EkmConnectionName.FromProjectLocationEkmConnection("[PROJECT]", "[LOCATION]", "[EKM_CONNECTION]"),
                CreateTime = new wkt::Timestamp(),
                ServiceResolvers =
                {
                    new EkmConnection.Types.ServiceResolver(),
                },
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.UpdateEkmConnectionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EkmConnection>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            EkmServiceClient client = new EkmServiceClientImpl(mockGrpcClient.Object, null, null);
            EkmConnection responseCallSettings = await client.UpdateEkmConnectionAsync(request.EkmConnection, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EkmConnection responseCancellationToken = await client.UpdateEkmConnectionAsync(request.EkmConnection, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
