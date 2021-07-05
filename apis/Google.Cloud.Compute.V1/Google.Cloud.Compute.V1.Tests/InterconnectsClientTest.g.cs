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
    public sealed class GeneratedInterconnectsClientTest
    {
        [xunit::FactAttribute]
        public void DeleteRequestObject()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            DeleteInterconnectRequest request = new DeleteInterconnectRequest
            {
                RequestId = "request_id362c8df6",
                Interconnect = "interconnect253e8bf5",
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
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteRequestObjectAsync()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            DeleteInterconnectRequest request = new DeleteInterconnectRequest
            {
                RequestId = "request_id362c8df6",
                Interconnect = "interconnect253e8bf5",
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
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Delete()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            DeleteInterconnectRequest request = new DeleteInterconnectRequest
            {
                Interconnect = "interconnect253e8bf5",
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
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Delete(request.Project, request.Interconnect);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteAsync()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            DeleteInterconnectRequest request = new DeleteInterconnectRequest
            {
                Interconnect = "interconnect253e8bf5",
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
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.DeleteAsync(request.Project, request.Interconnect, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.DeleteAsync(request.Project, request.Interconnect, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            GetInterconnectRequest request = new GetInterconnectRequest
            {
                Interconnect = "interconnect253e8bf5",
                Project = "projectaa6ff846",
            };
            Interconnect expectedResponse = new Interconnect
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CustomerName = "customer_name2ace137a",
                NocContactEmail = "noc_contact_email1d95c1b6",
                CreationTimestamp = "creation_timestamp235e59a1",
                RequestedLinkCount = 2020560861,
                State = Interconnect.Types.State.UndefinedState,
                CircuitInfos =
                {
                    new InterconnectCircuitInfo(),
                },
                OperationalStatus = Interconnect.Types.OperationalStatus.UndefinedOperationalStatus,
                PeerIpAddress = "peer_ip_address07617b81",
                ExpectedOutages =
                {
                    new InterconnectOutageNotification(),
                },
                Location = "locatione09d18d5",
                ProvisionedLinkCount = 1441690745,
                Description = "description2cf9da67",
                InterconnectAttachments =
                {
                    "interconnect_attachmentsdc10a889",
                },
                GoogleIpAddress = "google_ip_address246d4427",
                AdminEnabled = true,
                SelfLink = "self_link7e87f12d",
                InterconnectType = Interconnect.Types.InterconnectType.Partner,
                LinkType = Interconnect.Types.LinkType.UndefinedLinkType,
                GoogleReferenceId = "google_reference_id815b6ab4",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            Interconnect response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            GetInterconnectRequest request = new GetInterconnectRequest
            {
                Interconnect = "interconnect253e8bf5",
                Project = "projectaa6ff846",
            };
            Interconnect expectedResponse = new Interconnect
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CustomerName = "customer_name2ace137a",
                NocContactEmail = "noc_contact_email1d95c1b6",
                CreationTimestamp = "creation_timestamp235e59a1",
                RequestedLinkCount = 2020560861,
                State = Interconnect.Types.State.UndefinedState,
                CircuitInfos =
                {
                    new InterconnectCircuitInfo(),
                },
                OperationalStatus = Interconnect.Types.OperationalStatus.UndefinedOperationalStatus,
                PeerIpAddress = "peer_ip_address07617b81",
                ExpectedOutages =
                {
                    new InterconnectOutageNotification(),
                },
                Location = "locatione09d18d5",
                ProvisionedLinkCount = 1441690745,
                Description = "description2cf9da67",
                InterconnectAttachments =
                {
                    "interconnect_attachmentsdc10a889",
                },
                GoogleIpAddress = "google_ip_address246d4427",
                AdminEnabled = true,
                SelfLink = "self_link7e87f12d",
                InterconnectType = Interconnect.Types.InterconnectType.Partner,
                LinkType = Interconnect.Types.LinkType.UndefinedLinkType,
                GoogleReferenceId = "google_reference_id815b6ab4",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Interconnect>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            Interconnect responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Interconnect responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            GetInterconnectRequest request = new GetInterconnectRequest
            {
                Interconnect = "interconnect253e8bf5",
                Project = "projectaa6ff846",
            };
            Interconnect expectedResponse = new Interconnect
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CustomerName = "customer_name2ace137a",
                NocContactEmail = "noc_contact_email1d95c1b6",
                CreationTimestamp = "creation_timestamp235e59a1",
                RequestedLinkCount = 2020560861,
                State = Interconnect.Types.State.UndefinedState,
                CircuitInfos =
                {
                    new InterconnectCircuitInfo(),
                },
                OperationalStatus = Interconnect.Types.OperationalStatus.UndefinedOperationalStatus,
                PeerIpAddress = "peer_ip_address07617b81",
                ExpectedOutages =
                {
                    new InterconnectOutageNotification(),
                },
                Location = "locatione09d18d5",
                ProvisionedLinkCount = 1441690745,
                Description = "description2cf9da67",
                InterconnectAttachments =
                {
                    "interconnect_attachmentsdc10a889",
                },
                GoogleIpAddress = "google_ip_address246d4427",
                AdminEnabled = true,
                SelfLink = "self_link7e87f12d",
                InterconnectType = Interconnect.Types.InterconnectType.Partner,
                LinkType = Interconnect.Types.LinkType.UndefinedLinkType,
                GoogleReferenceId = "google_reference_id815b6ab4",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            Interconnect response = client.Get(request.Project, request.Interconnect);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            GetInterconnectRequest request = new GetInterconnectRequest
            {
                Interconnect = "interconnect253e8bf5",
                Project = "projectaa6ff846",
            };
            Interconnect expectedResponse = new Interconnect
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CustomerName = "customer_name2ace137a",
                NocContactEmail = "noc_contact_email1d95c1b6",
                CreationTimestamp = "creation_timestamp235e59a1",
                RequestedLinkCount = 2020560861,
                State = Interconnect.Types.State.UndefinedState,
                CircuitInfos =
                {
                    new InterconnectCircuitInfo(),
                },
                OperationalStatus = Interconnect.Types.OperationalStatus.UndefinedOperationalStatus,
                PeerIpAddress = "peer_ip_address07617b81",
                ExpectedOutages =
                {
                    new InterconnectOutageNotification(),
                },
                Location = "locatione09d18d5",
                ProvisionedLinkCount = 1441690745,
                Description = "description2cf9da67",
                InterconnectAttachments =
                {
                    "interconnect_attachmentsdc10a889",
                },
                GoogleIpAddress = "google_ip_address246d4427",
                AdminEnabled = true,
                SelfLink = "self_link7e87f12d",
                InterconnectType = Interconnect.Types.InterconnectType.Partner,
                LinkType = Interconnect.Types.LinkType.UndefinedLinkType,
                GoogleReferenceId = "google_reference_id815b6ab4",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Interconnect>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            Interconnect responseCallSettings = await client.GetAsync(request.Project, request.Interconnect, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Interconnect responseCancellationToken = await client.GetAsync(request.Project, request.Interconnect, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDiagnosticsRequestObject()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            GetDiagnosticsInterconnectRequest request = new GetDiagnosticsInterconnectRequest
            {
                Interconnect = "interconnect253e8bf5",
                Project = "projectaa6ff846",
            };
            InterconnectsGetDiagnosticsResponse expectedResponse = new InterconnectsGetDiagnosticsResponse
            {
                Result = new InterconnectDiagnostics(),
            };
            mockGrpcClient.Setup(x => x.GetDiagnostics(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            InterconnectsGetDiagnosticsResponse response = client.GetDiagnostics(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDiagnosticsRequestObjectAsync()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            GetDiagnosticsInterconnectRequest request = new GetDiagnosticsInterconnectRequest
            {
                Interconnect = "interconnect253e8bf5",
                Project = "projectaa6ff846",
            };
            InterconnectsGetDiagnosticsResponse expectedResponse = new InterconnectsGetDiagnosticsResponse
            {
                Result = new InterconnectDiagnostics(),
            };
            mockGrpcClient.Setup(x => x.GetDiagnosticsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InterconnectsGetDiagnosticsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            InterconnectsGetDiagnosticsResponse responseCallSettings = await client.GetDiagnosticsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InterconnectsGetDiagnosticsResponse responseCancellationToken = await client.GetDiagnosticsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetDiagnostics()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            GetDiagnosticsInterconnectRequest request = new GetDiagnosticsInterconnectRequest
            {
                Interconnect = "interconnect253e8bf5",
                Project = "projectaa6ff846",
            };
            InterconnectsGetDiagnosticsResponse expectedResponse = new InterconnectsGetDiagnosticsResponse
            {
                Result = new InterconnectDiagnostics(),
            };
            mockGrpcClient.Setup(x => x.GetDiagnostics(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            InterconnectsGetDiagnosticsResponse response = client.GetDiagnostics(request.Project, request.Interconnect);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetDiagnosticsAsync()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            GetDiagnosticsInterconnectRequest request = new GetDiagnosticsInterconnectRequest
            {
                Interconnect = "interconnect253e8bf5",
                Project = "projectaa6ff846",
            };
            InterconnectsGetDiagnosticsResponse expectedResponse = new InterconnectsGetDiagnosticsResponse
            {
                Result = new InterconnectDiagnostics(),
            };
            mockGrpcClient.Setup(x => x.GetDiagnosticsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InterconnectsGetDiagnosticsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            InterconnectsGetDiagnosticsResponse responseCallSettings = await client.GetDiagnosticsAsync(request.Project, request.Interconnect, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InterconnectsGetDiagnosticsResponse responseCancellationToken = await client.GetDiagnosticsAsync(request.Project, request.Interconnect, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void InsertRequestObject()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            InsertInterconnectRequest request = new InsertInterconnectRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InterconnectResource = new Interconnect(),
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
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertRequestObjectAsync()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            InsertInterconnectRequest request = new InsertInterconnectRequest
            {
                RequestId = "request_id362c8df6",
                Project = "projectaa6ff846",
                InterconnectResource = new Interconnect(),
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
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Insert()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            InsertInterconnectRequest request = new InsertInterconnectRequest
            {
                Project = "projectaa6ff846",
                InterconnectResource = new Interconnect(),
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
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Insert(request.Project, request.InterconnectResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task InsertAsync()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            InsertInterconnectRequest request = new InsertInterconnectRequest
            {
                Project = "projectaa6ff846",
                InterconnectResource = new Interconnect(),
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
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.InsertAsync(request.Project, request.InterconnectResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.InsertAsync(request.Project, request.InterconnectResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            ListInterconnectsRequest request = new ListInterconnectsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            InterconnectList expectedResponse = new InterconnectList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Interconnect(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            InterconnectList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            ListInterconnectsRequest request = new ListInterconnectsRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            InterconnectList expectedResponse = new InterconnectList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Interconnect(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InterconnectList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            InterconnectList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InterconnectList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            ListInterconnectsRequest request = new ListInterconnectsRequest
            {
                Project = "projectaa6ff846",
            };
            InterconnectList expectedResponse = new InterconnectList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Interconnect(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            InterconnectList response = client.List(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            ListInterconnectsRequest request = new ListInterconnectsRequest
            {
                Project = "projectaa6ff846",
            };
            InterconnectList expectedResponse = new InterconnectList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Interconnect(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InterconnectList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            InterconnectList responseCallSettings = await client.ListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InterconnectList responseCancellationToken = await client.ListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PatchRequestObject()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            PatchInterconnectRequest request = new PatchInterconnectRequest
            {
                RequestId = "request_id362c8df6",
                Interconnect = "interconnect253e8bf5",
                Project = "projectaa6ff846",
                InterconnectResource = new Interconnect(),
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
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchRequestObjectAsync()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            PatchInterconnectRequest request = new PatchInterconnectRequest
            {
                RequestId = "request_id362c8df6",
                Interconnect = "interconnect253e8bf5",
                Project = "projectaa6ff846",
                InterconnectResource = new Interconnect(),
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
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Patch()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            PatchInterconnectRequest request = new PatchInterconnectRequest
            {
                Interconnect = "interconnect253e8bf5",
                Project = "projectaa6ff846",
                InterconnectResource = new Interconnect(),
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
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            Operation response = client.Patch(request.Project, request.Interconnect, request.InterconnectResource);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PatchAsync()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            PatchInterconnectRequest request = new PatchInterconnectRequest
            {
                Interconnect = "interconnect253e8bf5",
                Project = "projectaa6ff846",
                InterconnectResource = new Interconnect(),
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
            InterconnectsClient client = new InterconnectsClientImpl(mockGrpcClient.Object, null);
            Operation responseCallSettings = await client.PatchAsync(request.Project, request.Interconnect, request.InterconnectResource, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Operation responseCancellationToken = await client.PatchAsync(request.Project, request.Interconnect, request.InterconnectResource, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
