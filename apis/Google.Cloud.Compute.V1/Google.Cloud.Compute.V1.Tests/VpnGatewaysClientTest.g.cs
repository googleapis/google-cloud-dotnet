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
    public sealed class GeneratedVpnGatewaysClientTest
    {
        [xunit::FactAttribute]
        public void AggregatedListRequestObject()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            AggregatedListVpnGatewaysRequest request = new AggregatedListVpnGatewaysRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            VpnGatewayAggregatedList expectedResponse = new VpnGatewayAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new VpnGatewaysScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGatewayAggregatedList response = client.AggregatedList(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListRequestObjectAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            AggregatedListVpnGatewaysRequest request = new AggregatedListVpnGatewaysRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            VpnGatewayAggregatedList expectedResponse = new VpnGatewayAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new VpnGatewaysScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VpnGatewayAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGatewayAggregatedList responseCallSettings = await client.AggregatedListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VpnGatewayAggregatedList responseCancellationToken = await client.AggregatedListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedList()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            AggregatedListVpnGatewaysRequest request = new AggregatedListVpnGatewaysRequest
            {
                Project = "projectaa6ff846",
            };
            VpnGatewayAggregatedList expectedResponse = new VpnGatewayAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new VpnGatewaysScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGatewayAggregatedList response = client.AggregatedList(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            AggregatedListVpnGatewaysRequest request = new AggregatedListVpnGatewaysRequest
            {
                Project = "projectaa6ff846",
            };
            VpnGatewayAggregatedList expectedResponse = new VpnGatewayAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new VpnGatewaysScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VpnGatewayAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGatewayAggregatedList responseCallSettings = await client.AggregatedListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VpnGatewayAggregatedList responseCancellationToken = await client.AggregatedListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            DeleteVpnGatewayRequest request = new DeleteVpnGatewayRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
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
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            DeleteVpnGatewayRequest request = new DeleteVpnGatewayRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
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
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            DeleteVpnGatewayRequest request = new DeleteVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
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
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Region, request.VpnGateway);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            DeleteVpnGatewayRequest request = new DeleteVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
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
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Region, request.VpnGateway, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Region, request.VpnGateway, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            GetVpnGatewayRequest request = new GetVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
            };
            VpnGateway expectedResponse = new VpnGateway
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                VpnInterfaces =
                {
                    new VpnGatewayVpnGatewayInterface(),
                },
                Region = "regionedb20d96",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Network = "networkd22ce091",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGateway response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            GetVpnGatewayRequest request = new GetVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
            };
            VpnGateway expectedResponse = new VpnGateway
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                VpnInterfaces =
                {
                    new VpnGatewayVpnGatewayInterface(),
                },
                Region = "regionedb20d96",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Network = "networkd22ce091",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VpnGateway>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGateway responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VpnGateway responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            GetVpnGatewayRequest request = new GetVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
            };
            VpnGateway expectedResponse = new VpnGateway
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                VpnInterfaces =
                {
                    new VpnGatewayVpnGatewayInterface(),
                },
                Region = "regionedb20d96",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Network = "networkd22ce091",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGateway response = client.Get(request.Project, request.Region, request.VpnGateway);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            GetVpnGatewayRequest request = new GetVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
            };
            VpnGateway expectedResponse = new VpnGateway
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                VpnInterfaces =
                {
                    new VpnGatewayVpnGatewayInterface(),
                },
                Region = "regionedb20d96",
                LabelFingerprint = "label_fingerprint06ccff3a",
                Network = "networkd22ce091",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VpnGateway>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGateway responseCallSettings = await client.GetAsync(request.Project, request.Region, request.VpnGateway, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VpnGateway responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.VpnGateway, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetStatusRequestObject()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            GetStatusVpnGatewayRequest request = new GetStatusVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
            };
            VpnGatewaysGetStatusResponse expectedResponse = new VpnGatewaysGetStatusResponse
            {
                Result = new VpnGatewayStatus(),
            };
            mockGrpcClient.Setup(x => x.GetStatus(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGatewaysGetStatusResponse response = client.GetStatus(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetStatusRequestObjectAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            GetStatusVpnGatewayRequest request = new GetStatusVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
            };
            VpnGatewaysGetStatusResponse expectedResponse = new VpnGatewaysGetStatusResponse
            {
                Result = new VpnGatewayStatus(),
            };
            mockGrpcClient.Setup(x => x.GetStatusAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VpnGatewaysGetStatusResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGatewaysGetStatusResponse responseCallSettings = await client.GetStatusAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VpnGatewaysGetStatusResponse responseCancellationToken = await client.GetStatusAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetStatus()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            GetStatusVpnGatewayRequest request = new GetStatusVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
            };
            VpnGatewaysGetStatusResponse expectedResponse = new VpnGatewaysGetStatusResponse
            {
                Result = new VpnGatewayStatus(),
            };
            mockGrpcClient.Setup(x => x.GetStatus(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGatewaysGetStatusResponse response = client.GetStatus(request.Project, request.Region, request.VpnGateway);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetStatusAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            GetStatusVpnGatewayRequest request = new GetStatusVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                VpnGateway = "vpn_gatewayaa15de14",
            };
            VpnGatewaysGetStatusResponse expectedResponse = new VpnGatewaysGetStatusResponse
            {
                Result = new VpnGatewayStatus(),
            };
            mockGrpcClient.Setup(x => x.GetStatusAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VpnGatewaysGetStatusResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGatewaysGetStatusResponse responseCallSettings = await client.GetStatusAsync(request.Project, request.Region, request.VpnGateway, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VpnGatewaysGetStatusResponse responseCancellationToken = await client.GetStatusAsync(request.Project, request.Region, request.VpnGateway, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            InsertVpnGatewayRequest request = new InsertVpnGatewayRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                VpnGatewayResource = new VpnGateway(),
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
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            InsertVpnGatewayRequest request = new InsertVpnGatewayRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                VpnGatewayResource = new VpnGateway(),
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
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            InsertVpnGatewayRequest request = new InsertVpnGatewayRequest
            {
                Region = "regionedb20d96",
                VpnGatewayResource = new VpnGateway(),
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
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Region, request.VpnGatewayResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            InsertVpnGatewayRequest request = new InsertVpnGatewayRequest
            {
                Region = "regionedb20d96",
                VpnGatewayResource = new VpnGateway(),
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
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Region, request.VpnGatewayResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Region, request.VpnGatewayResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            ListVpnGatewaysRequest request = new ListVpnGatewaysRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            VpnGatewayList expectedResponse = new VpnGatewayList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new VpnGateway(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGatewayList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            ListVpnGatewaysRequest request = new ListVpnGatewaysRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            VpnGatewayList expectedResponse = new VpnGatewayList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new VpnGateway(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VpnGatewayList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGatewayList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VpnGatewayList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            ListVpnGatewaysRequest request = new ListVpnGatewaysRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            VpnGatewayList expectedResponse = new VpnGatewayList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new VpnGateway(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGatewayList response = client.List(request.Project, request.Region);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            ListVpnGatewaysRequest request = new ListVpnGatewaysRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            VpnGatewayList expectedResponse = new VpnGatewayList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new VpnGateway(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<VpnGatewayList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            VpnGatewayList responseCallSettings = await client.ListAsync(request.Project, request.Region, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            VpnGatewayList responseCancellationToken = await client.ListAsync(request.Project, request.Region, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetLabelsRequestObject()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            SetLabelsVpnGatewayRequest request = new SetLabelsVpnGatewayRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
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
            mockGrpcClient.Setup(x => x.SetLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLabels(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetLabelsRequestObjectAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            SetLabelsVpnGatewayRequest request = new SetLabelsVpnGatewayRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
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
            mockGrpcClient.Setup(x => x.SetLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetLabelsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SetLabels()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            SetLabelsVpnGatewayRequest request = new SetLabelsVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
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
            mockGrpcClient.Setup(x => x.SetLabels(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation response = client.SetLabels(request.Project, request.Region, request.Resource, request.RegionSetLabelsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SetLabelsAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            SetLabelsVpnGatewayRequest request = new SetLabelsVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                RegionSetLabelsRequestResource = new RegionSetLabelsRequest(),
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
            mockGrpcClient.Setup(x => x.SetLabelsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.SetLabelsAsync(request.Project, request.Region, request.Resource, request.RegionSetLabelsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.SetLabelsAsync(request.Project, request.Region, request.Resource, request.RegionSetLabelsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            TestIamPermissionsVpnGatewayRequest request = new TestIamPermissionsVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            TestIamPermissionsVpnGatewayRequest request = new TestIamPermissionsVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            TestIamPermissionsVpnGatewayRequest request = new TestIamPermissionsVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissions(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<VpnGateways.VpnGatewaysClient> mockGrpcClient = new moq::Mock<VpnGateways.VpnGatewaysClient>(moq::MockBehavior.Strict);
            TestIamPermissionsVpnGatewayRequest request = new TestIamPermissionsVpnGatewayRequest
            {
                Region = "regionedb20d96",
                Resource = "resource164eab96",
                Project = "projectaa6ff846",
                TestPermissionsRequestResource = new TestPermissionsRequest(),
            };
            TestPermissionsResponse expectedResponse = new TestPermissionsResponse
            {
                Permissions =
                {
                    "permissions535a2741",
                },
            };
            mockGrpcClient.Setup(x => x.TestIamPermissionsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<TestPermissionsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VpnGatewaysClient client = new VpnGatewaysClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
