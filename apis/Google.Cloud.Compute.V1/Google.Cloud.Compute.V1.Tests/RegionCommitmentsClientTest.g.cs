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
    public sealed class GeneratedRegionCommitmentsClientTest
    {
        [xunit::FactAttribute]
        public void AggregatedListRequestObject()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            AggregatedListRegionCommitmentsRequest request = new AggregatedListRegionCommitmentsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            CommitmentAggregatedList expectedResponse = new CommitmentAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new CommitmentsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            CommitmentAggregatedList response = client.AggregatedList(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListRequestObjectAsync()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            AggregatedListRegionCommitmentsRequest request = new AggregatedListRegionCommitmentsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            CommitmentAggregatedList expectedResponse = new CommitmentAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new CommitmentsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CommitmentAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            CommitmentAggregatedList responseCallSettings = await client.AggregatedListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CommitmentAggregatedList responseCancellationToken = await client.AggregatedListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedList()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            AggregatedListRegionCommitmentsRequest request = new AggregatedListRegionCommitmentsRequest
            {
                Project = "projectaa6ff846",
            };
            CommitmentAggregatedList expectedResponse = new CommitmentAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new CommitmentsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            CommitmentAggregatedList response = client.AggregatedList(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListAsync()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            AggregatedListRegionCommitmentsRequest request = new AggregatedListRegionCommitmentsRequest
            {
                Project = "projectaa6ff846",
            };
            CommitmentAggregatedList expectedResponse = new CommitmentAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new CommitmentsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CommitmentAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            CommitmentAggregatedList responseCallSettings = await client.AggregatedListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CommitmentAggregatedList responseCancellationToken = await client.AggregatedListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            GetRegionCommitmentRequest request = new GetRegionCommitmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Commitment = "commitment726158e4",
            };
            Commitment expectedResponse = new Commitment
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Plan = Commitment.Types.Plan.TwelveMonth,
                CreationTimestamp = "creation_timestamp235e59a1",
                Category = Commitment.Types.Category.UndefinedCategory,
                StartTimestamp = "start_timestamp8aac6e77",
                Region = "regionedb20d96",
                Resources =
                {
                    new ResourceCommitment(),
                },
                Status = Commitment.Types.Status.NotYetActive,
                StatusMessage = "status_message2c618f86",
                Reservations = { new Reservation(), },
                Description = "description2cf9da67",
                LicenseResource = new LicenseResourceCommitment(),
                SelfLink = "self_link7e87f12d",
                EndTimestamp = "end_timestamp91060b72",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            Commitment response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            GetRegionCommitmentRequest request = new GetRegionCommitmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Commitment = "commitment726158e4",
            };
            Commitment expectedResponse = new Commitment
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Plan = Commitment.Types.Plan.TwelveMonth,
                CreationTimestamp = "creation_timestamp235e59a1",
                Category = Commitment.Types.Category.UndefinedCategory,
                StartTimestamp = "start_timestamp8aac6e77",
                Region = "regionedb20d96",
                Resources =
                {
                    new ResourceCommitment(),
                },
                Status = Commitment.Types.Status.NotYetActive,
                StatusMessage = "status_message2c618f86",
                Reservations = { new Reservation(), },
                Description = "description2cf9da67",
                LicenseResource = new LicenseResourceCommitment(),
                SelfLink = "self_link7e87f12d",
                EndTimestamp = "end_timestamp91060b72",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Commitment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            Commitment responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Commitment responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            GetRegionCommitmentRequest request = new GetRegionCommitmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Commitment = "commitment726158e4",
            };
            Commitment expectedResponse = new Commitment
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Plan = Commitment.Types.Plan.TwelveMonth,
                CreationTimestamp = "creation_timestamp235e59a1",
                Category = Commitment.Types.Category.UndefinedCategory,
                StartTimestamp = "start_timestamp8aac6e77",
                Region = "regionedb20d96",
                Resources =
                {
                    new ResourceCommitment(),
                },
                Status = Commitment.Types.Status.NotYetActive,
                StatusMessage = "status_message2c618f86",
                Reservations = { new Reservation(), },
                Description = "description2cf9da67",
                LicenseResource = new LicenseResourceCommitment(),
                SelfLink = "self_link7e87f12d",
                EndTimestamp = "end_timestamp91060b72",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            Commitment response = client.Get(request.Project, request.Region, request.Commitment);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            GetRegionCommitmentRequest request = new GetRegionCommitmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                Commitment = "commitment726158e4",
            };
            Commitment expectedResponse = new Commitment
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Plan = Commitment.Types.Plan.TwelveMonth,
                CreationTimestamp = "creation_timestamp235e59a1",
                Category = Commitment.Types.Category.UndefinedCategory,
                StartTimestamp = "start_timestamp8aac6e77",
                Region = "regionedb20d96",
                Resources =
                {
                    new ResourceCommitment(),
                },
                Status = Commitment.Types.Status.NotYetActive,
                StatusMessage = "status_message2c618f86",
                Reservations = { new Reservation(), },
                Description = "description2cf9da67",
                LicenseResource = new LicenseResourceCommitment(),
                SelfLink = "self_link7e87f12d",
                EndTimestamp = "end_timestamp91060b72",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Commitment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            Commitment responseCallSettings = await client.GetAsync(request.Project, request.Region, request.Commitment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Commitment responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.Commitment, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            InsertRegionCommitmentRequest request = new InsertRegionCommitmentRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                CommitmentResource = new Commitment(),
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
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            InsertRegionCommitmentRequest request = new InsertRegionCommitmentRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                CommitmentResource = new Commitment(),
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
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            InsertRegionCommitmentRequest request = new InsertRegionCommitmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                CommitmentResource = new Commitment(),
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
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Region, request.CommitmentResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            InsertRegionCommitmentRequest request = new InsertRegionCommitmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                CommitmentResource = new Commitment(),
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
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Region, request.CommitmentResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Region, request.CommitmentResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            ListRegionCommitmentsRequest request = new ListRegionCommitmentsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            CommitmentList expectedResponse = new CommitmentList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Commitment(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            CommitmentList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            ListRegionCommitmentsRequest request = new ListRegionCommitmentsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            CommitmentList expectedResponse = new CommitmentList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Commitment(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CommitmentList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            CommitmentList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CommitmentList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            ListRegionCommitmentsRequest request = new ListRegionCommitmentsRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            CommitmentList expectedResponse = new CommitmentList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Commitment(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            CommitmentList response = client.List(request.Project, request.Region);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<RegionCommitments.RegionCommitmentsClient> mockGrpcClient = new moq::Mock<RegionCommitments.RegionCommitmentsClient>(moq::MockBehavior.Strict);
            ListRegionCommitmentsRequest request = new ListRegionCommitmentsRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            CommitmentList expectedResponse = new CommitmentList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Commitment(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CommitmentList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionCommitmentsClient client = new RegionCommitmentsClientImpl(mockGrpcClient.Object, null);
            CommitmentList responseCallSettings = await client.ListAsync(request.Project, request.Region, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CommitmentList responseCancellationToken = await client.ListAsync(request.Project, request.Region, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
