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
using lro = Google.LongRunning;
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
        public void GetRequestObject()
        {
            moq::Mock<Interconnects.InterconnectsClient> mockGrpcClient = new moq::Mock<Interconnects.InterconnectsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
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
    }
}
