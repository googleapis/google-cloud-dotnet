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
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedVpnTunnelsClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<VpnTunnels.VpnTunnelsClient> mockGrpcClient = new moq::Mock<VpnTunnels.VpnTunnelsClient>(moq::MockBehavior.Strict);
            DeleteVpnTunnelRequest request = new DeleteVpnTunnelRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                VpnTunnel = "vpn_tunnelfa4123fd",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnTunnelsClient client = new VpnTunnelsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<VpnTunnels.VpnTunnelsClient> mockGrpcClient = new moq::Mock<VpnTunnels.VpnTunnelsClient>(moq::MockBehavior.Strict);
            DeleteVpnTunnelRequest request = new DeleteVpnTunnelRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                VpnTunnel = "vpn_tunnelfa4123fd",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnTunnelsClient client = new VpnTunnelsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<VpnTunnels.VpnTunnelsClient> mockGrpcClient = new moq::Mock<VpnTunnels.VpnTunnelsClient>(moq::MockBehavior.Strict);
            DeleteVpnTunnelRequest request = new DeleteVpnTunnelRequest
            {
                Region = "regionedb20d96",
                VpnTunnel = "vpn_tunnelfa4123fd",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnTunnelsClient client = new VpnTunnelsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Region, request.VpnTunnel);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<VpnTunnels.VpnTunnelsClient> mockGrpcClient = new moq::Mock<VpnTunnels.VpnTunnelsClient>(moq::MockBehavior.Strict);
            DeleteVpnTunnelRequest request = new DeleteVpnTunnelRequest
            {
                Region = "regionedb20d96",
                VpnTunnel = "vpn_tunnelfa4123fd",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnTunnelsClient client = new VpnTunnelsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Region, request.VpnTunnel, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Region, request.VpnTunnel, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<VpnTunnels.VpnTunnelsClient> mockGrpcClient = new moq::Mock<VpnTunnels.VpnTunnelsClient>(moq::MockBehavior.Strict);
            GetVpnTunnelRequest request = new GetVpnTunnelRequest
            {
                Region = "regionedb20d96",
                VpnTunnel = "vpn_tunnelfa4123fd",
                Project = "projectaa6ff846",
            };
            VpnTunnel expectedResponse = new VpnTunnel
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                VpnGatewayInterface = 1166485993,
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Status = VpnTunnel.Types.Status.Provisioning,
                IkeVersion = 485306612,
                PeerGcpGateway = "peer_gcp_gateway613039db",
                LocalTrafficSelector =
                {
                    "local_traffic_selector09bfbb68",
                },
                DetailedStatus = "detailed_status4e3163c7",
                RemoteTrafficSelector =
                {
                    "remote_traffic_selector8463a07f",
                },
                SharedSecret = "shared_secret3a48b317",
                PeerIp = "peer_ip5b148b8e",
                PeerExternalGateway = "peer_external_gatewaye60baaef",
                SharedSecretHash = "shared_secret_hash3ba18c3b",
                VpnGateway = "vpn_gatewayaa15de14",
                Description = "description2cf9da67",
                PeerExternalGatewayInterface = -994715857,
                SelfLink = "self_link7e87f12d",
                TargetVpnGateway = "target_vpn_gateway6c481371",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnTunnelsClient client = new VpnTunnelsClientImpl(mockGrpcClient.Object, null);
            VpnTunnel response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<VpnTunnels.VpnTunnelsClient> mockGrpcClient = new moq::Mock<VpnTunnels.VpnTunnelsClient>(moq::MockBehavior.Strict);
            GetVpnTunnelRequest request = new GetVpnTunnelRequest
            {
                Region = "regionedb20d96",
                VpnTunnel = "vpn_tunnelfa4123fd",
                Project = "projectaa6ff846",
            };
            VpnTunnel expectedResponse = new VpnTunnel
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                VpnGatewayInterface = 1166485993,
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Status = VpnTunnel.Types.Status.Provisioning,
                IkeVersion = 485306612,
                PeerGcpGateway = "peer_gcp_gateway613039db",
                LocalTrafficSelector =
                {
                    "local_traffic_selector09bfbb68",
                },
                DetailedStatus = "detailed_status4e3163c7",
                RemoteTrafficSelector =
                {
                    "remote_traffic_selector8463a07f",
                },
                SharedSecret = "shared_secret3a48b317",
                PeerIp = "peer_ip5b148b8e",
                PeerExternalGateway = "peer_external_gatewaye60baaef",
                SharedSecretHash = "shared_secret_hash3ba18c3b",
                VpnGateway = "vpn_gatewayaa15de14",
                Description = "description2cf9da67",
                PeerExternalGatewayInterface = -994715857,
                SelfLink = "self_link7e87f12d",
                TargetVpnGateway = "target_vpn_gateway6c481371",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VpnTunnel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnTunnelsClient client = new VpnTunnelsClientImpl(mockGrpcClient.Object, null);
            VpnTunnel responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VpnTunnel responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<VpnTunnels.VpnTunnelsClient> mockGrpcClient = new moq::Mock<VpnTunnels.VpnTunnelsClient>(moq::MockBehavior.Strict);
            GetVpnTunnelRequest request = new GetVpnTunnelRequest
            {
                Region = "regionedb20d96",
                VpnTunnel = "vpn_tunnelfa4123fd",
                Project = "projectaa6ff846",
            };
            VpnTunnel expectedResponse = new VpnTunnel
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                VpnGatewayInterface = 1166485993,
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Status = VpnTunnel.Types.Status.Provisioning,
                IkeVersion = 485306612,
                PeerGcpGateway = "peer_gcp_gateway613039db",
                LocalTrafficSelector =
                {
                    "local_traffic_selector09bfbb68",
                },
                DetailedStatus = "detailed_status4e3163c7",
                RemoteTrafficSelector =
                {
                    "remote_traffic_selector8463a07f",
                },
                SharedSecret = "shared_secret3a48b317",
                PeerIp = "peer_ip5b148b8e",
                PeerExternalGateway = "peer_external_gatewaye60baaef",
                SharedSecretHash = "shared_secret_hash3ba18c3b",
                VpnGateway = "vpn_gatewayaa15de14",
                Description = "description2cf9da67",
                PeerExternalGatewayInterface = -994715857,
                SelfLink = "self_link7e87f12d",
                TargetVpnGateway = "target_vpn_gateway6c481371",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnTunnelsClient client = new VpnTunnelsClientImpl(mockGrpcClient.Object, null);
            VpnTunnel response = client.Get(request.Project, request.Region, request.VpnTunnel);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<VpnTunnels.VpnTunnelsClient> mockGrpcClient = new moq::Mock<VpnTunnels.VpnTunnelsClient>(moq::MockBehavior.Strict);
            GetVpnTunnelRequest request = new GetVpnTunnelRequest
            {
                Region = "regionedb20d96",
                VpnTunnel = "vpn_tunnelfa4123fd",
                Project = "projectaa6ff846",
            };
            VpnTunnel expectedResponse = new VpnTunnel
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                VpnGatewayInterface = 1166485993,
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Status = VpnTunnel.Types.Status.Provisioning,
                IkeVersion = 485306612,
                PeerGcpGateway = "peer_gcp_gateway613039db",
                LocalTrafficSelector =
                {
                    "local_traffic_selector09bfbb68",
                },
                DetailedStatus = "detailed_status4e3163c7",
                RemoteTrafficSelector =
                {
                    "remote_traffic_selector8463a07f",
                },
                SharedSecret = "shared_secret3a48b317",
                PeerIp = "peer_ip5b148b8e",
                PeerExternalGateway = "peer_external_gatewaye60baaef",
                SharedSecretHash = "shared_secret_hash3ba18c3b",
                VpnGateway = "vpn_gatewayaa15de14",
                Description = "description2cf9da67",
                PeerExternalGatewayInterface = -994715857,
                SelfLink = "self_link7e87f12d",
                TargetVpnGateway = "target_vpn_gateway6c481371",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VpnTunnel>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnTunnelsClient client = new VpnTunnelsClientImpl(mockGrpcClient.Object, null);
            VpnTunnel responseCallSettings = await client.GetAsync(request.Project, request.Region, request.VpnTunnel, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VpnTunnel responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.VpnTunnel, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<VpnTunnels.VpnTunnelsClient> mockGrpcClient = new moq::Mock<VpnTunnels.VpnTunnelsClient>(moq::MockBehavior.Strict);
            InsertVpnTunnelRequest request = new InsertVpnTunnelRequest
            {
                RequestId = "request_id362c8df6",
                VpnTunnelResource = new VpnTunnel(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnTunnelsClient client = new VpnTunnelsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<VpnTunnels.VpnTunnelsClient> mockGrpcClient = new moq::Mock<VpnTunnels.VpnTunnelsClient>(moq::MockBehavior.Strict);
            InsertVpnTunnelRequest request = new InsertVpnTunnelRequest
            {
                RequestId = "request_id362c8df6",
                VpnTunnelResource = new VpnTunnel(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnTunnelsClient client = new VpnTunnelsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<VpnTunnels.VpnTunnelsClient> mockGrpcClient = new moq::Mock<VpnTunnels.VpnTunnelsClient>(moq::MockBehavior.Strict);
            InsertVpnTunnelRequest request = new InsertVpnTunnelRequest
            {
                VpnTunnelResource = new VpnTunnel(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnTunnelsClient client = new VpnTunnelsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Region, request.VpnTunnelResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<VpnTunnels.VpnTunnelsClient> mockGrpcClient = new moq::Mock<VpnTunnels.VpnTunnelsClient>(moq::MockBehavior.Strict);
            InsertVpnTunnelRequest request = new InsertVpnTunnelRequest
            {
                VpnTunnelResource = new VpnTunnel(),
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                User = "userb1cb11ee",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                StartTime = "start_timebd8dd9c4",
                OperationGroupId = "operation_group_idd2040cf0",
                TargetLink = "target_link9b435dc0",
                Progress = 278622268,
                Error = new Error(),
                EndTime = "end_time89285d30",
                Region = "regionedb20d96",
                OperationType = "operation_typeece9e153",
                Status = Operation.Types.Status.Pending,
                HttpErrorMessage = "http_error_messageb5ef3c7f",
                TargetId = 6263187990225347157UL,
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnTunnelsClient client = new VpnTunnelsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Region, request.VpnTunnelResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Region, request.VpnTunnelResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
