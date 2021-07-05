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
    public sealed class GeneratedTargetVpnGatewaysClientTest
    {
        [xunit::FactAttribute]
        public void AggregatedListRequestObject()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            AggregatedListTargetVpnGatewaysRequest request = new AggregatedListTargetVpnGatewaysRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            TargetVpnGatewayAggregatedList expectedResponse = new TargetVpnGatewayAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new TargetVpnGatewaysScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TargetVpnGatewayAggregatedList response = client.AggregatedList(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListRequestObjectAsync()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            AggregatedListTargetVpnGatewaysRequest request = new AggregatedListTargetVpnGatewaysRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            TargetVpnGatewayAggregatedList expectedResponse = new TargetVpnGatewayAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new TargetVpnGatewaysScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetVpnGatewayAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TargetVpnGatewayAggregatedList responseCallSettings = await client.AggregatedListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetVpnGatewayAggregatedList responseCancellationToken = await client.AggregatedListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedList()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            AggregatedListTargetVpnGatewaysRequest request = new AggregatedListTargetVpnGatewaysRequest
            {
                Project = "projectaa6ff846",
            };
            TargetVpnGatewayAggregatedList expectedResponse = new TargetVpnGatewayAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new TargetVpnGatewaysScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TargetVpnGatewayAggregatedList response = client.AggregatedList(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListAsync()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            AggregatedListTargetVpnGatewaysRequest request = new AggregatedListTargetVpnGatewaysRequest
            {
                Project = "projectaa6ff846",
            };
            TargetVpnGatewayAggregatedList expectedResponse = new TargetVpnGatewayAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new TargetVpnGatewaysScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetVpnGatewayAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TargetVpnGatewayAggregatedList responseCallSettings = await client.AggregatedListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetVpnGatewayAggregatedList responseCancellationToken = await client.AggregatedListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            DeleteTargetVpnGatewayRequest request = new DeleteTargetVpnGatewayRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetVpnGateway = "target_vpn_gateway6c481371",
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
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            DeleteTargetVpnGatewayRequest request = new DeleteTargetVpnGatewayRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetVpnGateway = "target_vpn_gateway6c481371",
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
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            DeleteTargetVpnGatewayRequest request = new DeleteTargetVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetVpnGateway = "target_vpn_gateway6c481371",
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
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Region, request.TargetVpnGateway);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            DeleteTargetVpnGatewayRequest request = new DeleteTargetVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetVpnGateway = "target_vpn_gateway6c481371",
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
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Region, request.TargetVpnGateway, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Region, request.TargetVpnGateway, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            GetTargetVpnGatewayRequest request = new GetTargetVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetVpnGateway = "target_vpn_gateway6c481371",
            };
            TargetVpnGateway expectedResponse = new TargetVpnGateway
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Tunnels = { "tunnelsf736a212", },
                Region = "regionedb20d96",
                Status = TargetVpnGateway.Types.Status.Ready,
                Network = "networkd22ce091",
                ForwardingRules =
                {
                    "forwarding_rulesf78b2720",
                },
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TargetVpnGateway response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            GetTargetVpnGatewayRequest request = new GetTargetVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetVpnGateway = "target_vpn_gateway6c481371",
            };
            TargetVpnGateway expectedResponse = new TargetVpnGateway
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Tunnels = { "tunnelsf736a212", },
                Region = "regionedb20d96",
                Status = TargetVpnGateway.Types.Status.Ready,
                Network = "networkd22ce091",
                ForwardingRules =
                {
                    "forwarding_rulesf78b2720",
                },
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetVpnGateway>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TargetVpnGateway responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetVpnGateway responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            GetTargetVpnGatewayRequest request = new GetTargetVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetVpnGateway = "target_vpn_gateway6c481371",
            };
            TargetVpnGateway expectedResponse = new TargetVpnGateway
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Tunnels = { "tunnelsf736a212", },
                Region = "regionedb20d96",
                Status = TargetVpnGateway.Types.Status.Ready,
                Network = "networkd22ce091",
                ForwardingRules =
                {
                    "forwarding_rulesf78b2720",
                },
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TargetVpnGateway response = client.Get(request.Project, request.Region, request.TargetVpnGateway);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            GetTargetVpnGatewayRequest request = new GetTargetVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                TargetVpnGateway = "target_vpn_gateway6c481371",
            };
            TargetVpnGateway expectedResponse = new TargetVpnGateway
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Tunnels = { "tunnelsf736a212", },
                Region = "regionedb20d96",
                Status = TargetVpnGateway.Types.Status.Ready,
                Network = "networkd22ce091",
                ForwardingRules =
                {
                    "forwarding_rulesf78b2720",
                },
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetVpnGateway>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TargetVpnGateway responseCallSettings = await client.GetAsync(request.Project, request.Region, request.TargetVpnGateway, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetVpnGateway responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.TargetVpnGateway, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            InsertTargetVpnGatewayRequest request = new InsertTargetVpnGatewayRequest
            {
                TargetVpnGatewayResource = new TargetVpnGateway(),
                RequestId = "request_id362c8df6",
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
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            InsertTargetVpnGatewayRequest request = new InsertTargetVpnGatewayRequest
            {
                TargetVpnGatewayResource = new TargetVpnGateway(),
                RequestId = "request_id362c8df6",
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
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            InsertTargetVpnGatewayRequest request = new InsertTargetVpnGatewayRequest
            {
                TargetVpnGatewayResource = new TargetVpnGateway(),
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
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Region, request.TargetVpnGatewayResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            InsertTargetVpnGatewayRequest request = new InsertTargetVpnGatewayRequest
            {
                TargetVpnGatewayResource = new TargetVpnGateway(),
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
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Region, request.TargetVpnGatewayResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Region, request.TargetVpnGatewayResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            ListTargetVpnGatewaysRequest request = new ListTargetVpnGatewaysRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            TargetVpnGatewayList expectedResponse = new TargetVpnGatewayList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetVpnGateway(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TargetVpnGatewayList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            ListTargetVpnGatewaysRequest request = new ListTargetVpnGatewaysRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            TargetVpnGatewayList expectedResponse = new TargetVpnGatewayList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetVpnGateway(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetVpnGatewayList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TargetVpnGatewayList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetVpnGatewayList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            ListTargetVpnGatewaysRequest request = new ListTargetVpnGatewaysRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            TargetVpnGatewayList expectedResponse = new TargetVpnGatewayList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetVpnGateway(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TargetVpnGatewayList response = client.List(request.Project, request.Region);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient> mockGrpcClient = new moq::Mock<TargetVpnGateways.TargetVpnGatewaysClient>(moq::MockBehavior.Strict);
            ListTargetVpnGatewaysRequest request = new ListTargetVpnGatewaysRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            TargetVpnGatewayList expectedResponse = new TargetVpnGatewayList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new TargetVpnGateway(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TargetVpnGatewayList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            TargetVpnGatewaysClient client = new TargetVpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TargetVpnGatewayList responseCallSettings = await client.ListAsync(request.Project, request.Region, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TargetVpnGatewayList responseCancellationToken = await client.ListAsync(request.Project, request.Region, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
