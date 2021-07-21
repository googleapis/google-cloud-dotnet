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
    public sealed class GeneratedInterconnectAttachmentsClientTest
    {
        [xunit::FactAttribute]
        public void AggregatedListRequestObject()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            AggregatedListInterconnectAttachmentsRequest request = new AggregatedListInterconnectAttachmentsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            InterconnectAttachmentAggregatedList expectedResponse = new InterconnectAttachmentAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new InterconnectAttachmentsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            InterconnectAttachmentAggregatedList response = client.AggregatedList(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListRequestObjectAsync()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            AggregatedListInterconnectAttachmentsRequest request = new AggregatedListInterconnectAttachmentsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            InterconnectAttachmentAggregatedList expectedResponse = new InterconnectAttachmentAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new InterconnectAttachmentsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InterconnectAttachmentAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            InterconnectAttachmentAggregatedList responseCallSettings = await client.AggregatedListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InterconnectAttachmentAggregatedList responseCancellationToken = await client.AggregatedListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedList()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            AggregatedListInterconnectAttachmentsRequest request = new AggregatedListInterconnectAttachmentsRequest
            {
                Project = "projectaa6ff846",
            };
            InterconnectAttachmentAggregatedList expectedResponse = new InterconnectAttachmentAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new InterconnectAttachmentsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            InterconnectAttachmentAggregatedList response = client.AggregatedList(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListAsync()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            AggregatedListInterconnectAttachmentsRequest request = new AggregatedListInterconnectAttachmentsRequest
            {
                Project = "projectaa6ff846",
            };
            InterconnectAttachmentAggregatedList expectedResponse = new InterconnectAttachmentAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new InterconnectAttachmentsScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InterconnectAttachmentAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            InterconnectAttachmentAggregatedList responseCallSettings = await client.AggregatedListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InterconnectAttachmentAggregatedList responseCancellationToken = await client.AggregatedListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            DeleteInterconnectAttachmentRequest request = new DeleteInterconnectAttachmentRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InterconnectAttachment = "interconnect_attachmentc83a7a7c",
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
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            DeleteInterconnectAttachmentRequest request = new DeleteInterconnectAttachmentRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InterconnectAttachment = "interconnect_attachmentc83a7a7c",
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
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            DeleteInterconnectAttachmentRequest request = new DeleteInterconnectAttachmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InterconnectAttachment = "interconnect_attachmentc83a7a7c",
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
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Region, request.InterconnectAttachment);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            DeleteInterconnectAttachmentRequest request = new DeleteInterconnectAttachmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InterconnectAttachment = "interconnect_attachmentc83a7a7c",
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
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Region, request.InterconnectAttachment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Region, request.InterconnectAttachment, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            GetInterconnectAttachmentRequest request = new GetInterconnectAttachmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InterconnectAttachment = "interconnect_attachmentc83a7a7c",
            };
            InterconnectAttachment expectedResponse = new InterconnectAttachment
            {
                Id = 11672635353343658936UL,
                Mtu = 1280318054,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = InterconnectAttachment.Types.Type.PartnerProvider,
                CreationTimestamp = "creation_timestamp235e59a1",
                DataplaneVersion = -763719012,
                PartnerMetadata = new InterconnectAttachmentPartnerMetadata(),
                EdgeAvailabilityDomain = InterconnectAttachment.Types.EdgeAvailabilityDomain.AvailabilityDomain1,
                Encryption = InterconnectAttachment.Types.Encryption.None,
                State = InterconnectAttachment.Types.State.Unspecified,
                VlanTag8021Q = 1290733749,
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Bandwidth = InterconnectAttachment.Types.Bandwidth.Bps500M,
                OperationalStatus = InterconnectAttachment.Types.OperationalStatus.UndefinedOperationalStatus,
                Interconnect = "interconnect253e8bf5",
                PrivateInterconnectInfo = new InterconnectAttachmentPrivateInfo(),
                CandidateSubnets =
                {
                    "candidate_subnets3377adaa",
                },
                CloudRouterIpAddress = "cloud_router_ip_address62b476a9",
                CustomerRouterIpAddress = "customer_router_ip_address819aa186",
                IpsecInternalAddresses =
                {
                    "ipsec_internal_addresses8b47c5bb",
                },
                Description = "description2cf9da67",
                PartnerAsn = 6862354938501622805L,
                PairingKey = "pairing_keyfe878c44",
                AdminEnabled = true,
                SelfLink = "self_link7e87f12d",
                GoogleReferenceId = "google_reference_id815b6ab4",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            InterconnectAttachment response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            GetInterconnectAttachmentRequest request = new GetInterconnectAttachmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InterconnectAttachment = "interconnect_attachmentc83a7a7c",
            };
            InterconnectAttachment expectedResponse = new InterconnectAttachment
            {
                Id = 11672635353343658936UL,
                Mtu = 1280318054,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = InterconnectAttachment.Types.Type.PartnerProvider,
                CreationTimestamp = "creation_timestamp235e59a1",
                DataplaneVersion = -763719012,
                PartnerMetadata = new InterconnectAttachmentPartnerMetadata(),
                EdgeAvailabilityDomain = InterconnectAttachment.Types.EdgeAvailabilityDomain.AvailabilityDomain1,
                Encryption = InterconnectAttachment.Types.Encryption.None,
                State = InterconnectAttachment.Types.State.Unspecified,
                VlanTag8021Q = 1290733749,
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Bandwidth = InterconnectAttachment.Types.Bandwidth.Bps500M,
                OperationalStatus = InterconnectAttachment.Types.OperationalStatus.UndefinedOperationalStatus,
                Interconnect = "interconnect253e8bf5",
                PrivateInterconnectInfo = new InterconnectAttachmentPrivateInfo(),
                CandidateSubnets =
                {
                    "candidate_subnets3377adaa",
                },
                CloudRouterIpAddress = "cloud_router_ip_address62b476a9",
                CustomerRouterIpAddress = "customer_router_ip_address819aa186",
                IpsecInternalAddresses =
                {
                    "ipsec_internal_addresses8b47c5bb",
                },
                Description = "description2cf9da67",
                PartnerAsn = 6862354938501622805L,
                PairingKey = "pairing_keyfe878c44",
                AdminEnabled = true,
                SelfLink = "self_link7e87f12d",
                GoogleReferenceId = "google_reference_id815b6ab4",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InterconnectAttachment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            InterconnectAttachment responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InterconnectAttachment responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            GetInterconnectAttachmentRequest request = new GetInterconnectAttachmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InterconnectAttachment = "interconnect_attachmentc83a7a7c",
            };
            InterconnectAttachment expectedResponse = new InterconnectAttachment
            {
                Id = 11672635353343658936UL,
                Mtu = 1280318054,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = InterconnectAttachment.Types.Type.PartnerProvider,
                CreationTimestamp = "creation_timestamp235e59a1",
                DataplaneVersion = -763719012,
                PartnerMetadata = new InterconnectAttachmentPartnerMetadata(),
                EdgeAvailabilityDomain = InterconnectAttachment.Types.EdgeAvailabilityDomain.AvailabilityDomain1,
                Encryption = InterconnectAttachment.Types.Encryption.None,
                State = InterconnectAttachment.Types.State.Unspecified,
                VlanTag8021Q = 1290733749,
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Bandwidth = InterconnectAttachment.Types.Bandwidth.Bps500M,
                OperationalStatus = InterconnectAttachment.Types.OperationalStatus.UndefinedOperationalStatus,
                Interconnect = "interconnect253e8bf5",
                PrivateInterconnectInfo = new InterconnectAttachmentPrivateInfo(),
                CandidateSubnets =
                {
                    "candidate_subnets3377adaa",
                },
                CloudRouterIpAddress = "cloud_router_ip_address62b476a9",
                CustomerRouterIpAddress = "customer_router_ip_address819aa186",
                IpsecInternalAddresses =
                {
                    "ipsec_internal_addresses8b47c5bb",
                },
                Description = "description2cf9da67",
                PartnerAsn = 6862354938501622805L,
                PairingKey = "pairing_keyfe878c44",
                AdminEnabled = true,
                SelfLink = "self_link7e87f12d",
                GoogleReferenceId = "google_reference_id815b6ab4",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            InterconnectAttachment response = client.Get(request.Project, request.Region, request.InterconnectAttachment);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            GetInterconnectAttachmentRequest request = new GetInterconnectAttachmentRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
                InterconnectAttachment = "interconnect_attachmentc83a7a7c",
            };
            InterconnectAttachment expectedResponse = new InterconnectAttachment
            {
                Id = 11672635353343658936UL,
                Mtu = 1280318054,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Type = InterconnectAttachment.Types.Type.PartnerProvider,
                CreationTimestamp = "creation_timestamp235e59a1",
                DataplaneVersion = -763719012,
                PartnerMetadata = new InterconnectAttachmentPartnerMetadata(),
                EdgeAvailabilityDomain = InterconnectAttachment.Types.EdgeAvailabilityDomain.AvailabilityDomain1,
                Encryption = InterconnectAttachment.Types.Encryption.None,
                State = InterconnectAttachment.Types.State.Unspecified,
                VlanTag8021Q = 1290733749,
                Region = "regionedb20d96",
                Router = "routerd55c39f3",
                Bandwidth = InterconnectAttachment.Types.Bandwidth.Bps500M,
                OperationalStatus = InterconnectAttachment.Types.OperationalStatus.UndefinedOperationalStatus,
                Interconnect = "interconnect253e8bf5",
                PrivateInterconnectInfo = new InterconnectAttachmentPrivateInfo(),
                CandidateSubnets =
                {
                    "candidate_subnets3377adaa",
                },
                CloudRouterIpAddress = "cloud_router_ip_address62b476a9",
                CustomerRouterIpAddress = "customer_router_ip_address819aa186",
                IpsecInternalAddresses =
                {
                    "ipsec_internal_addresses8b47c5bb",
                },
                Description = "description2cf9da67",
                PartnerAsn = 6862354938501622805L,
                PairingKey = "pairing_keyfe878c44",
                AdminEnabled = true,
                SelfLink = "self_link7e87f12d",
                GoogleReferenceId = "google_reference_id815b6ab4",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InterconnectAttachment>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            InterconnectAttachment responseCallSettings = await client.GetAsync(request.Project, request.Region, request.InterconnectAttachment, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InterconnectAttachment responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.InterconnectAttachment, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            InsertInterconnectAttachmentRequest request = new InsertInterconnectAttachmentRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                InterconnectAttachmentResource = new InterconnectAttachment(),
                Project = "projectaa6ff846",
                ValidateOnly = true,
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
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            InsertInterconnectAttachmentRequest request = new InsertInterconnectAttachmentRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                InterconnectAttachmentResource = new InterconnectAttachment(),
                Project = "projectaa6ff846",
                ValidateOnly = true,
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
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            InsertInterconnectAttachmentRequest request = new InsertInterconnectAttachmentRequest
            {
                Region = "regionedb20d96",
                InterconnectAttachmentResource = new InterconnectAttachment(),
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
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.Region, request.InterconnectAttachmentResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            InsertInterconnectAttachmentRequest request = new InsertInterconnectAttachmentRequest
            {
                Region = "regionedb20d96",
                InterconnectAttachmentResource = new InterconnectAttachment(),
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
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.Region, request.InterconnectAttachmentResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.Region, request.InterconnectAttachmentResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            ListInterconnectAttachmentsRequest request = new ListInterconnectAttachmentsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            InterconnectAttachmentList expectedResponse = new InterconnectAttachmentList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InterconnectAttachment(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            InterconnectAttachmentList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            ListInterconnectAttachmentsRequest request = new ListInterconnectAttachmentsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            InterconnectAttachmentList expectedResponse = new InterconnectAttachmentList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InterconnectAttachment(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InterconnectAttachmentList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            InterconnectAttachmentList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InterconnectAttachmentList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            ListInterconnectAttachmentsRequest request = new ListInterconnectAttachmentsRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            InterconnectAttachmentList expectedResponse = new InterconnectAttachmentList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InterconnectAttachment(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            InterconnectAttachmentList response = client.List(request.Project, request.Region);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            ListInterconnectAttachmentsRequest request = new ListInterconnectAttachmentsRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            InterconnectAttachmentList expectedResponse = new InterconnectAttachmentList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new InterconnectAttachment(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InterconnectAttachmentList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            InterconnectAttachmentList responseCallSettings = await client.ListAsync(request.Project, request.Region, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InterconnectAttachmentList responseCancellationToken = await client.ListAsync(request.Project, request.Region, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            PatchInterconnectAttachmentRequest request = new PatchInterconnectAttachmentRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                InterconnectAttachmentResource = new InterconnectAttachment(),
                Project = "projectaa6ff846",
                InterconnectAttachment = "interconnect_attachmentc83a7a7c",
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
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            PatchInterconnectAttachmentRequest request = new PatchInterconnectAttachmentRequest
            {
                RequestId = "request_id362c8df6",
                Region = "regionedb20d96",
                InterconnectAttachmentResource = new InterconnectAttachment(),
                Project = "projectaa6ff846",
                InterconnectAttachment = "interconnect_attachmentc83a7a7c",
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
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            PatchInterconnectAttachmentRequest request = new PatchInterconnectAttachmentRequest
            {
                Region = "regionedb20d96",
                InterconnectAttachmentResource = new InterconnectAttachment(),
                Project = "projectaa6ff846",
                InterconnectAttachment = "interconnect_attachmentc83a7a7c",
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
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.Region, request.InterconnectAttachment, request.InterconnectAttachmentResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient> mockGrpcClient = new moq::Mock<InterconnectAttachments.InterconnectAttachmentsClient>(moq::MockBehavior.Strict);
            PatchInterconnectAttachmentRequest request = new PatchInterconnectAttachmentRequest
            {
                Region = "regionedb20d96",
                InterconnectAttachmentResource = new InterconnectAttachment(),
                Project = "projectaa6ff846",
                InterconnectAttachment = "interconnect_attachmentc83a7a7c",
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
            InterconnectAttachmentsClient client = new InterconnectAttachmentsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.Region, request.InterconnectAttachment, request.InterconnectAttachmentResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.Region, request.InterconnectAttachment, request.InterconnectAttachmentResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
