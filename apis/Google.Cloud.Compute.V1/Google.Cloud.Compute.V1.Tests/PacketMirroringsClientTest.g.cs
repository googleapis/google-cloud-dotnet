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
    public sealed class GeneratedPacketMirroringsClientTest
    {
        [xunit::FactAttribute]
        public void AggregatedListRequestObject()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            AggregatedListPacketMirroringsRequest request = new AggregatedListPacketMirroringsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            PacketMirroringAggregatedList expectedResponse = new PacketMirroringAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new PacketMirroringsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            PacketMirroringAggregatedList response = client.AggregatedList(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListRequestObjectAsync()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            AggregatedListPacketMirroringsRequest request = new AggregatedListPacketMirroringsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            PacketMirroringAggregatedList expectedResponse = new PacketMirroringAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new PacketMirroringsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PacketMirroringAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            PacketMirroringAggregatedList responseCallSettings = await client.AggregatedListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PacketMirroringAggregatedList responseCancellationToken = await client.AggregatedListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedList()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            AggregatedListPacketMirroringsRequest request = new AggregatedListPacketMirroringsRequest
            {
                Project = "projectaa6ff846",
            };
            PacketMirroringAggregatedList expectedResponse = new PacketMirroringAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new PacketMirroringsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            PacketMirroringAggregatedList response = client.AggregatedList(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListAsync()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            AggregatedListPacketMirroringsRequest request = new AggregatedListPacketMirroringsRequest
            {
                Project = "projectaa6ff846",
            };
            PacketMirroringAggregatedList expectedResponse = new PacketMirroringAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new PacketMirroringsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PacketMirroringAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            PacketMirroringAggregatedList responseCallSettings = await client.AggregatedListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PacketMirroringAggregatedList responseCancellationToken = await client.AggregatedListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            DeletePacketMirroringRequest request = new DeletePacketMirroringRequest
            {
                PacketMirroring = "packet_mirroringf2de2a5f",
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
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            DeletePacketMirroringRequest request = new DeletePacketMirroringRequest
            {
                PacketMirroring = "packet_mirroringf2de2a5f",
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
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            DeletePacketMirroringRequest request = new DeletePacketMirroringRequest
            {
                PacketMirroring = "packet_mirroringf2de2a5f",
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
            mockGrpcClient.Setup(x => x.Delete(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Region, request.PacketMirroring);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            DeletePacketMirroringRequest request = new DeletePacketMirroringRequest
            {
                PacketMirroring = "packet_mirroringf2de2a5f",
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
            mockGrpcClient.Setup(x => x.DeleteAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Region, request.PacketMirroring, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Region, request.PacketMirroring, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            GetPacketMirroringRequest request = new GetPacketMirroringRequest
            {
                PacketMirroring = "packet_mirroringf2de2a5f",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            PacketMirroring expectedResponse = new PacketMirroring
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                MirroredResources = new PacketMirroringMirroredResourceInfo(),
                Region = "regionedb20d96",
                Network = new PacketMirroringNetworkInfo(),
                Enable = PacketMirroring.Types.Enable.True,
                Filter = new PacketMirroringFilter(),
                Description = "description2cf9da67",
                CollectorIlb = new PacketMirroringForwardingRuleInfo(),
                Priority = 1546225849U,
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            PacketMirroring response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            GetPacketMirroringRequest request = new GetPacketMirroringRequest
            {
                PacketMirroring = "packet_mirroringf2de2a5f",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            PacketMirroring expectedResponse = new PacketMirroring
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                MirroredResources = new PacketMirroringMirroredResourceInfo(),
                Region = "regionedb20d96",
                Network = new PacketMirroringNetworkInfo(),
                Enable = PacketMirroring.Types.Enable.True,
                Filter = new PacketMirroringFilter(),
                Description = "description2cf9da67",
                CollectorIlb = new PacketMirroringForwardingRuleInfo(),
                Priority = 1546225849U,
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PacketMirroring>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            PacketMirroring responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PacketMirroring responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            GetPacketMirroringRequest request = new GetPacketMirroringRequest
            {
                PacketMirroring = "packet_mirroringf2de2a5f",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            PacketMirroring expectedResponse = new PacketMirroring
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                MirroredResources = new PacketMirroringMirroredResourceInfo(),
                Region = "regionedb20d96",
                Network = new PacketMirroringNetworkInfo(),
                Enable = PacketMirroring.Types.Enable.True,
                Filter = new PacketMirroringFilter(),
                Description = "description2cf9da67",
                CollectorIlb = new PacketMirroringForwardingRuleInfo(),
                Priority = 1546225849U,
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            PacketMirroring response = client.Get(request.Project, request.Region, request.PacketMirroring);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            GetPacketMirroringRequest request = new GetPacketMirroringRequest
            {
                PacketMirroring = "packet_mirroringf2de2a5f",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            PacketMirroring expectedResponse = new PacketMirroring
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                MirroredResources = new PacketMirroringMirroredResourceInfo(),
                Region = "regionedb20d96",
                Network = new PacketMirroringNetworkInfo(),
                Enable = PacketMirroring.Types.Enable.True,
                Filter = new PacketMirroringFilter(),
                Description = "description2cf9da67",
                CollectorIlb = new PacketMirroringForwardingRuleInfo(),
                Priority = 1546225849U,
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PacketMirroring>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            PacketMirroring responseCallSettings = await client.GetAsync(request.Project, request.Region, request.PacketMirroring, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PacketMirroring responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.PacketMirroring, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            InsertPacketMirroringRequest request = new InsertPacketMirroringRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                PacketMirroringResource = new PacketMirroring(),
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
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            InsertPacketMirroringRequest request = new InsertPacketMirroringRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                PacketMirroringResource = new PacketMirroring(),
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
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            InsertPacketMirroringRequest request = new InsertPacketMirroringRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                PacketMirroringResource = new PacketMirroring(),
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
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Region, request.PacketMirroringResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            InsertPacketMirroringRequest request = new InsertPacketMirroringRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                PacketMirroringResource = new PacketMirroring(),
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
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Region, request.PacketMirroringResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Region, request.PacketMirroringResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            ListPacketMirroringsRequest request = new ListPacketMirroringsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            PacketMirroringList expectedResponse = new PacketMirroringList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new PacketMirroring(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            PacketMirroringList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            ListPacketMirroringsRequest request = new ListPacketMirroringsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            PacketMirroringList expectedResponse = new PacketMirroringList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new PacketMirroring(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PacketMirroringList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            PacketMirroringList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PacketMirroringList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            ListPacketMirroringsRequest request = new ListPacketMirroringsRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            PacketMirroringList expectedResponse = new PacketMirroringList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new PacketMirroring(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            PacketMirroringList response = client.List(request.Project, request.Region);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            ListPacketMirroringsRequest request = new ListPacketMirroringsRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            PacketMirroringList expectedResponse = new PacketMirroringList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new PacketMirroring(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PacketMirroringList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            PacketMirroringList responseCallSettings = await client.ListAsync(request.Project, request.Region, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PacketMirroringList responseCancellationToken = await client.ListAsync(request.Project, request.Region, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            PatchPacketMirroringRequest request = new PatchPacketMirroringRequest
            {
                PacketMirroring = "packet_mirroringf2de2a5f",
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                PacketMirroringResource = new PacketMirroring(),
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
            mockGrpcClient.Setup(x => x.Patch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            PatchPacketMirroringRequest request = new PatchPacketMirroringRequest
            {
                PacketMirroring = "packet_mirroringf2de2a5f",
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                PacketMirroringResource = new PacketMirroring(),
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
            mockGrpcClient.Setup(x => x.PatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            PatchPacketMirroringRequest request = new PatchPacketMirroringRequest
            {
                PacketMirroring = "packet_mirroringf2de2a5f",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                PacketMirroringResource = new PacketMirroring(),
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
            mockGrpcClient.Setup(x => x.Patch(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.Region, request.PacketMirroring, request.PacketMirroringResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            PatchPacketMirroringRequest request = new PatchPacketMirroringRequest
            {
                PacketMirroring = "packet_mirroringf2de2a5f",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                PacketMirroringResource = new PacketMirroring(),
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
            mockGrpcClient.Setup(x => x.PatchAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Operation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.Region, request.PacketMirroring, request.PacketMirroringResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.Region, request.PacketMirroring, request.PacketMirroringResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissionsRequestObject()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            TestIamPermissionsPacketMirroringRequest request = new TestIamPermissionsPacketMirroringRequest
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
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsRequestObjectAsync()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            TestIamPermissionsPacketMirroringRequest request = new TestIamPermissionsPacketMirroringRequest
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
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void TestIamPermissions()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            TestIamPermissionsPacketMirroringRequest request = new TestIamPermissionsPacketMirroringRequest
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
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse response = client.TestIamPermissions(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task TestIamPermissionsAsync()
        {
            moq::Mock<PacketMirrorings.PacketMirroringsClient> mockGrpcClient = new moq::Mock<PacketMirrorings.PacketMirroringsClient>(moq::MockBehavior.Strict);
            TestIamPermissionsPacketMirroringRequest request = new TestIamPermissionsPacketMirroringRequest
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
            PacketMirroringsClient client = new PacketMirroringsClientImpl(mockGrpcClient.Object, null);
            TestPermissionsResponse responseCallSettings = await client.TestIamPermissionsAsync(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            TestPermissionsResponse responseCancellationToken = await client.TestIamPermissionsAsync(request.Project, request.Region, request.Resource, request.TestPermissionsRequestResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
