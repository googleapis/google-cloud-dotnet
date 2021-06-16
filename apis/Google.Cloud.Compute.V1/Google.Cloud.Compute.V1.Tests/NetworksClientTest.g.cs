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
    public sealed class GeneratedNetworksClientTest
    {
        [xunit::FactAttribute]
        public void AddPeeringRequestObject()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            AddPeeringNetworkRequest request = new AddPeeringNetworkRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
                NetworksAddPeeringRequestResource = new NetworksAddPeeringRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.AddPeering(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddPeering(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddPeeringRequestObjectAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            AddPeeringNetworkRequest request = new AddPeeringNetworkRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
                NetworksAddPeeringRequestResource = new NetworksAddPeeringRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.AddPeeringAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddPeeringAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddPeeringAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddPeering()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            AddPeeringNetworkRequest request = new AddPeeringNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
                NetworksAddPeeringRequestResource = new NetworksAddPeeringRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.AddPeering(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.AddPeering(request.Project, request.Network, request.NetworksAddPeeringRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddPeeringAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            AddPeeringNetworkRequest request = new AddPeeringNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
                NetworksAddPeeringRequestResource = new NetworksAddPeeringRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.AddPeeringAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.AddPeeringAsync(request.Project, request.Network, request.NetworksAddPeeringRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.AddPeeringAsync(request.Project, request.Network, request.NetworksAddPeeringRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            DeleteNetworkRequest request = new DeleteNetworkRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            DeleteNetworkRequest request = new DeleteNetworkRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            DeleteNetworkRequest request = new DeleteNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Network);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            DeleteNetworkRequest request = new DeleteNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Network, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Network, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            GetNetworkRequest request = new GetNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Network expectedResponse = new Network
            {
                Id = "id74b70bb8",
                Mtu = 1280318054,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                IPv4Range = "I_pv4_range613b129f",
                Peerings =
                {
                    new NetworkPeering(),
                },
                GatewayIPv4 = "gateway_i_pv47f9ce361",
                AutoCreateSubnetworks = false,
                Subnetworks =
                {
                    "subnetworks81f34af0",
                },
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                RoutingConfig = new NetworkRoutingConfig(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Network response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            GetNetworkRequest request = new GetNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Network expectedResponse = new Network
            {
                Id = "id74b70bb8",
                Mtu = 1280318054,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                IPv4Range = "I_pv4_range613b129f",
                Peerings =
                {
                    new NetworkPeering(),
                },
                GatewayIPv4 = "gateway_i_pv47f9ce361",
                AutoCreateSubnetworks = false,
                Subnetworks =
                {
                    "subnetworks81f34af0",
                },
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                RoutingConfig = new NetworkRoutingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Network>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Network responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Network responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            GetNetworkRequest request = new GetNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Network expectedResponse = new Network
            {
                Id = "id74b70bb8",
                Mtu = 1280318054,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                IPv4Range = "I_pv4_range613b129f",
                Peerings =
                {
                    new NetworkPeering(),
                },
                GatewayIPv4 = "gateway_i_pv47f9ce361",
                AutoCreateSubnetworks = false,
                Subnetworks =
                {
                    "subnetworks81f34af0",
                },
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                RoutingConfig = new NetworkRoutingConfig(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Network response = client.Get(request.Project, request.Network);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            GetNetworkRequest request = new GetNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Network expectedResponse = new Network
            {
                Id = "id74b70bb8",
                Mtu = 1280318054,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                IPv4Range = "I_pv4_range613b129f",
                Peerings =
                {
                    new NetworkPeering(),
                },
                GatewayIPv4 = "gateway_i_pv47f9ce361",
                AutoCreateSubnetworks = false,
                Subnetworks =
                {
                    "subnetworks81f34af0",
                },
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                RoutingConfig = new NetworkRoutingConfig(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Network>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Network responseCallSettings = await client.GetAsync(request.Project, request.Network, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Network responseCancellationToken = await client.GetAsync(request.Project, request.Network, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEffectiveFirewallsRequestObject()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            GetEffectiveFirewallsNetworkRequest request = new GetEffectiveFirewallsNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            NetworksGetEffectiveFirewallsResponse expectedResponse = new NetworksGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewalls(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            NetworksGetEffectiveFirewallsResponse response = client.GetEffectiveFirewalls(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEffectiveFirewallsRequestObjectAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            GetEffectiveFirewallsNetworkRequest request = new GetEffectiveFirewallsNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            NetworksGetEffectiveFirewallsResponse expectedResponse = new NetworksGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewallsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NetworksGetEffectiveFirewallsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            NetworksGetEffectiveFirewallsResponse responseCallSettings = await client.GetEffectiveFirewallsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworksGetEffectiveFirewallsResponse responseCancellationToken = await client.GetEffectiveFirewallsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetEffectiveFirewalls()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            GetEffectiveFirewallsNetworkRequest request = new GetEffectiveFirewallsNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            NetworksGetEffectiveFirewallsResponse expectedResponse = new NetworksGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewalls(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            NetworksGetEffectiveFirewallsResponse response = client.GetEffectiveFirewalls(request.Project, request.Network);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetEffectiveFirewallsAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            GetEffectiveFirewallsNetworkRequest request = new GetEffectiveFirewallsNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            NetworksGetEffectiveFirewallsResponse expectedResponse = new NetworksGetEffectiveFirewallsResponse
            {
                Firewalls = { new Firewall(), },
                FirewallPolicys =
                {
                    new NetworksGetEffectiveFirewallsResponseEffectiveFirewallPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.GetEffectiveFirewallsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NetworksGetEffectiveFirewallsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            NetworksGetEffectiveFirewallsResponse responseCallSettings = await client.GetEffectiveFirewallsAsync(request.Project, request.Network, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworksGetEffectiveFirewallsResponse responseCancellationToken = await client.GetEffectiveFirewallsAsync(request.Project, request.Network, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            InsertNetworkRequest request = new InsertNetworkRequest
            {
                RequestId = "request_id362c8df6",
                NetworkResource = new Network(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            InsertNetworkRequest request = new InsertNetworkRequest
            {
                RequestId = "request_id362c8df6",
                NetworkResource = new Network(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            InsertNetworkRequest request = new InsertNetworkRequest
            {
                NetworkResource = new Network(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Insert(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.NetworkResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            InsertNetworkRequest request = new InsertNetworkRequest
            {
                NetworkResource = new Network(),
                Project = "projectaa6ff846",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.InsertAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.NetworkResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.NetworkResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            ListNetworksRequest request = new ListNetworksRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            NetworkList expectedResponse = new NetworkList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Network(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            NetworkList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            ListNetworksRequest request = new ListNetworksRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            NetworkList expectedResponse = new NetworkList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Network(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NetworkList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            NetworkList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworkList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            ListNetworksRequest request = new ListNetworksRequest
            {
                Project = "projectaa6ff846",
            };
            NetworkList expectedResponse = new NetworkList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Network(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            NetworkList response = client.List(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            ListNetworksRequest request = new ListNetworksRequest
            {
                Project = "projectaa6ff846",
            };
            NetworkList expectedResponse = new NetworkList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Network(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NetworkList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            NetworkList responseCallSettings = await client.ListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NetworkList responseCancellationToken = await client.ListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListPeeringRoutesRequestObject()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            ListPeeringRoutesNetworksRequest request = new ListPeeringRoutesNetworksRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Direction = ListPeeringRoutesNetworksRequest.Types.Direction.Outgoing,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
                PeeringName = "peering_nameb9164cac",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            ExchangedPeeringRoutesList expectedResponse = new ExchangedPeeringRoutesList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new ExchangedPeeringRoute(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListPeeringRoutes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            ExchangedPeeringRoutesList response = client.ListPeeringRoutes(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListPeeringRoutesRequestObjectAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            ListPeeringRoutesNetworksRequest request = new ListPeeringRoutesNetworksRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Direction = ListPeeringRoutesNetworksRequest.Types.Direction.Outgoing,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
                PeeringName = "peering_nameb9164cac",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            ExchangedPeeringRoutesList expectedResponse = new ExchangedPeeringRoutesList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new ExchangedPeeringRoute(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListPeeringRoutesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ExchangedPeeringRoutesList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            ExchangedPeeringRoutesList responseCallSettings = await client.ListPeeringRoutesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ExchangedPeeringRoutesList responseCancellationToken = await client.ListPeeringRoutesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListPeeringRoutes()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            ListPeeringRoutesNetworksRequest request = new ListPeeringRoutesNetworksRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            ExchangedPeeringRoutesList expectedResponse = new ExchangedPeeringRoutesList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new ExchangedPeeringRoute(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListPeeringRoutes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            ExchangedPeeringRoutesList response = client.ListPeeringRoutes(request.Project, request.Network);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListPeeringRoutesAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            ListPeeringRoutesNetworksRequest request = new ListPeeringRoutesNetworksRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            ExchangedPeeringRoutesList expectedResponse = new ExchangedPeeringRoutesList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new ExchangedPeeringRoute(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListPeeringRoutesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ExchangedPeeringRoutesList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            ExchangedPeeringRoutesList responseCallSettings = await client.ListPeeringRoutesAsync(request.Project, request.Network, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ExchangedPeeringRoutesList responseCancellationToken = await client.ListPeeringRoutesAsync(request.Project, request.Network, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            PatchNetworkRequest request = new PatchNetworkRequest
            {
                RequestId = "request_id362c8df6",
                NetworkResource = new Network(),
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Patch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            PatchNetworkRequest request = new PatchNetworkRequest
            {
                RequestId = "request_id362c8df6",
                NetworkResource = new Network(),
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.PatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            PatchNetworkRequest request = new PatchNetworkRequest
            {
                NetworkResource = new Network(),
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Patch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.Network, request.NetworkResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            PatchNetworkRequest request = new PatchNetworkRequest
            {
                NetworkResource = new Network(),
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.PatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.Network, request.NetworkResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.Network, request.NetworkResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemovePeeringRequestObject()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            RemovePeeringNetworkRequest request = new RemovePeeringNetworkRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
                NetworksRemovePeeringRequestResource = new NetworksRemovePeeringRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.RemovePeering(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RemovePeering(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemovePeeringRequestObjectAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            RemovePeeringNetworkRequest request = new RemovePeeringNetworkRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
                NetworksRemovePeeringRequestResource = new NetworksRemovePeeringRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.RemovePeeringAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RemovePeeringAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RemovePeeringAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RemovePeering()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            RemovePeeringNetworkRequest request = new RemovePeeringNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
                NetworksRemovePeeringRequestResource = new NetworksRemovePeeringRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.RemovePeering(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.RemovePeering(request.Project, request.Network, request.NetworksRemovePeeringRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RemovePeeringAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            RemovePeeringNetworkRequest request = new RemovePeeringNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
                NetworksRemovePeeringRequestResource = new NetworksRemovePeeringRequest(),
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.RemovePeeringAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.RemovePeeringAsync(request.Project, request.Network, request.NetworksRemovePeeringRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.RemovePeeringAsync(request.Project, request.Network, request.NetworksRemovePeeringRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SwitchToCustomModeRequestObject()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            SwitchToCustomModeNetworkRequest request = new SwitchToCustomModeNetworkRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SwitchToCustomMode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SwitchToCustomMode(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SwitchToCustomModeRequestObjectAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            SwitchToCustomModeNetworkRequest request = new SwitchToCustomModeNetworkRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SwitchToCustomModeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SwitchToCustomModeAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SwitchToCustomModeAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SwitchToCustomMode()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            SwitchToCustomModeNetworkRequest request = new SwitchToCustomModeNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SwitchToCustomMode(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SwitchToCustomMode(request.Project, request.Network);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SwitchToCustomModeAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            SwitchToCustomModeNetworkRequest request = new SwitchToCustomModeNetworkRequest
            {
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.SwitchToCustomModeAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SwitchToCustomModeAsync(request.Project, request.Network, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SwitchToCustomModeAsync(request.Project, request.Network, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePeeringRequestObject()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            UpdatePeeringNetworkRequest request = new UpdatePeeringNetworkRequest
            {
                RequestId = "request_id362c8df6",
                NetworksUpdatePeeringRequestResource = new NetworksUpdatePeeringRequest(),
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdatePeering(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdatePeering(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePeeringRequestObjectAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            UpdatePeeringNetworkRequest request = new UpdatePeeringNetworkRequest
            {
                RequestId = "request_id362c8df6",
                NetworksUpdatePeeringRequestResource = new NetworksUpdatePeeringRequest(),
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdatePeeringAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdatePeeringAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdatePeeringAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePeering()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            UpdatePeeringNetworkRequest request = new UpdatePeeringNetworkRequest
            {
                NetworksUpdatePeeringRequestResource = new NetworksUpdatePeeringRequest(),
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdatePeering(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation response = client.UpdatePeering(request.Project, request.Network, request.NetworksUpdatePeeringRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePeeringAsync()
        {
            moq::Mock<Networks.NetworksClient> mockGrpcClient = new moq::Mock<Networks.NetworksClient>(moq::MockBehavior.Strict);
            UpdatePeeringNetworkRequest request = new UpdatePeeringNetworkRequest
            {
                NetworksUpdatePeeringRequestResource = new NetworksUpdatePeeringRequest(),
                Project = "projectaa6ff846",
                Network = "networkd22ce091",
            };
            Operation expectedResponse = new Operation
            {
                Id = "id74b70bb8",
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
                TargetId = "target_id16dfe255",
                ClientOperationId = "client_operation_id4e51b631",
                StatusMessage = "status_message2c618f86",
                HttpErrorStatusCode = 1766362655,
                Description = "description2cf9da67",
                InsertTime = "insert_time7467185a",
                SelfLink = "self_link7e87f12d",
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.UpdatePeeringAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NetworksClient client = new NetworksClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.UpdatePeeringAsync(request.Project, request.Network, request.NetworksUpdatePeeringRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.UpdatePeeringAsync(request.Project, request.Network, request.NetworksUpdatePeeringRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
