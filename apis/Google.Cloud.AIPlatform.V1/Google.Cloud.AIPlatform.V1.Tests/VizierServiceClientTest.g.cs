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
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.AIPlatform.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedVizierServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateStudyRequestObject()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateStudyRequest request = new CreateStudyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Study = new Study(),
            };
            Study expectedResponse = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                State = Study.Types.State.Inactive,
                CreateTime = new wkt::Timestamp(),
                InactiveReason = "inactive_reason229b079f",
            };
            mockGrpcClient.Setup(x => x.CreateStudy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Study response = client.CreateStudy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateStudyRequestObjectAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateStudyRequest request = new CreateStudyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Study = new Study(),
            };
            Study expectedResponse = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                State = Study.Types.State.Inactive,
                CreateTime = new wkt::Timestamp(),
                InactiveReason = "inactive_reason229b079f",
            };
            mockGrpcClient.Setup(x => x.CreateStudyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Study>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Study responseCallSettings = await client.CreateStudyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Study responseCancellationToken = await client.CreateStudyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateStudy()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateStudyRequest request = new CreateStudyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Study = new Study(),
            };
            Study expectedResponse = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                State = Study.Types.State.Inactive,
                CreateTime = new wkt::Timestamp(),
                InactiveReason = "inactive_reason229b079f",
            };
            mockGrpcClient.Setup(x => x.CreateStudy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Study response = client.CreateStudy(request.Parent, request.Study);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateStudyAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateStudyRequest request = new CreateStudyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Study = new Study(),
            };
            Study expectedResponse = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                State = Study.Types.State.Inactive,
                CreateTime = new wkt::Timestamp(),
                InactiveReason = "inactive_reason229b079f",
            };
            mockGrpcClient.Setup(x => x.CreateStudyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Study>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Study responseCallSettings = await client.CreateStudyAsync(request.Parent, request.Study, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Study responseCancellationToken = await client.CreateStudyAsync(request.Parent, request.Study, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateStudyResourceNames()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateStudyRequest request = new CreateStudyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Study = new Study(),
            };
            Study expectedResponse = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                State = Study.Types.State.Inactive,
                CreateTime = new wkt::Timestamp(),
                InactiveReason = "inactive_reason229b079f",
            };
            mockGrpcClient.Setup(x => x.CreateStudy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Study response = client.CreateStudy(request.ParentAsLocationName, request.Study);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateStudyResourceNamesAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateStudyRequest request = new CreateStudyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                Study = new Study(),
            };
            Study expectedResponse = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                State = Study.Types.State.Inactive,
                CreateTime = new wkt::Timestamp(),
                InactiveReason = "inactive_reason229b079f",
            };
            mockGrpcClient.Setup(x => x.CreateStudyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Study>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Study responseCallSettings = await client.CreateStudyAsync(request.ParentAsLocationName, request.Study, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Study responseCancellationToken = await client.CreateStudyAsync(request.ParentAsLocationName, request.Study, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetStudyRequestObject()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStudyRequest request = new GetStudyRequest
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            Study expectedResponse = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                State = Study.Types.State.Inactive,
                CreateTime = new wkt::Timestamp(),
                InactiveReason = "inactive_reason229b079f",
            };
            mockGrpcClient.Setup(x => x.GetStudy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Study response = client.GetStudy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetStudyRequestObjectAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStudyRequest request = new GetStudyRequest
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            Study expectedResponse = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                State = Study.Types.State.Inactive,
                CreateTime = new wkt::Timestamp(),
                InactiveReason = "inactive_reason229b079f",
            };
            mockGrpcClient.Setup(x => x.GetStudyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Study>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Study responseCallSettings = await client.GetStudyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Study responseCancellationToken = await client.GetStudyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetStudy()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStudyRequest request = new GetStudyRequest
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            Study expectedResponse = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                State = Study.Types.State.Inactive,
                CreateTime = new wkt::Timestamp(),
                InactiveReason = "inactive_reason229b079f",
            };
            mockGrpcClient.Setup(x => x.GetStudy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Study response = client.GetStudy(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetStudyAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStudyRequest request = new GetStudyRequest
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            Study expectedResponse = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                State = Study.Types.State.Inactive,
                CreateTime = new wkt::Timestamp(),
                InactiveReason = "inactive_reason229b079f",
            };
            mockGrpcClient.Setup(x => x.GetStudyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Study>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Study responseCallSettings = await client.GetStudyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Study responseCancellationToken = await client.GetStudyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetStudyResourceNames()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStudyRequest request = new GetStudyRequest
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            Study expectedResponse = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                State = Study.Types.State.Inactive,
                CreateTime = new wkt::Timestamp(),
                InactiveReason = "inactive_reason229b079f",
            };
            mockGrpcClient.Setup(x => x.GetStudy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Study response = client.GetStudy(request.StudyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetStudyResourceNamesAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetStudyRequest request = new GetStudyRequest
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            Study expectedResponse = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                State = Study.Types.State.Inactive,
                CreateTime = new wkt::Timestamp(),
                InactiveReason = "inactive_reason229b079f",
            };
            mockGrpcClient.Setup(x => x.GetStudyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Study>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Study responseCallSettings = await client.GetStudyAsync(request.StudyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Study responseCancellationToken = await client.GetStudyAsync(request.StudyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteStudyRequestObject()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteStudyRequest request = new DeleteStudyRequest
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteStudy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteStudy(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteStudyRequestObjectAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteStudyRequest request = new DeleteStudyRequest
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteStudyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteStudyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteStudyAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteStudy()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteStudyRequest request = new DeleteStudyRequest
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteStudy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteStudy(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteStudyAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteStudyRequest request = new DeleteStudyRequest
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteStudyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteStudyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteStudyAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteStudyResourceNames()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteStudyRequest request = new DeleteStudyRequest
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteStudy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteStudy(request.StudyName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteStudyResourceNamesAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteStudyRequest request = new DeleteStudyRequest
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteStudyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteStudyAsync(request.StudyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteStudyAsync(request.StudyName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void LookupStudyRequestObject()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            LookupStudyRequest request = new LookupStudyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DisplayName = "display_name137f65c2",
            };
            Study expectedResponse = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                State = Study.Types.State.Inactive,
                CreateTime = new wkt::Timestamp(),
                InactiveReason = "inactive_reason229b079f",
            };
            mockGrpcClient.Setup(x => x.LookupStudy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Study response = client.LookupStudy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task LookupStudyRequestObjectAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            LookupStudyRequest request = new LookupStudyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                DisplayName = "display_name137f65c2",
            };
            Study expectedResponse = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                State = Study.Types.State.Inactive,
                CreateTime = new wkt::Timestamp(),
                InactiveReason = "inactive_reason229b079f",
            };
            mockGrpcClient.Setup(x => x.LookupStudyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Study>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Study responseCallSettings = await client.LookupStudyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Study responseCancellationToken = await client.LookupStudyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void LookupStudy()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            LookupStudyRequest request = new LookupStudyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Study expectedResponse = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                State = Study.Types.State.Inactive,
                CreateTime = new wkt::Timestamp(),
                InactiveReason = "inactive_reason229b079f",
            };
            mockGrpcClient.Setup(x => x.LookupStudy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Study response = client.LookupStudy(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task LookupStudyAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            LookupStudyRequest request = new LookupStudyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Study expectedResponse = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                State = Study.Types.State.Inactive,
                CreateTime = new wkt::Timestamp(),
                InactiveReason = "inactive_reason229b079f",
            };
            mockGrpcClient.Setup(x => x.LookupStudyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Study>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Study responseCallSettings = await client.LookupStudyAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Study responseCancellationToken = await client.LookupStudyAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void LookupStudyResourceNames()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            LookupStudyRequest request = new LookupStudyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Study expectedResponse = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                State = Study.Types.State.Inactive,
                CreateTime = new wkt::Timestamp(),
                InactiveReason = "inactive_reason229b079f",
            };
            mockGrpcClient.Setup(x => x.LookupStudy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Study response = client.LookupStudy(request.ParentAsLocationName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task LookupStudyResourceNamesAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            LookupStudyRequest request = new LookupStudyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
            };
            Study expectedResponse = new Study
            {
                StudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                DisplayName = "display_name137f65c2",
                StudySpec = new StudySpec(),
                State = Study.Types.State.Inactive,
                CreateTime = new wkt::Timestamp(),
                InactiveReason = "inactive_reason229b079f",
            };
            mockGrpcClient.Setup(x => x.LookupStudyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Study>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Study responseCallSettings = await client.LookupStudyAsync(request.ParentAsLocationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Study responseCancellationToken = await client.LookupStudyAsync(request.ParentAsLocationName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTrialRequestObject()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTrialRequest request = new CreateTrialRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                Trial = new Trial(),
            };
            Trial expectedResponse = new Trial
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Id = "id74b70bb8",
                State = Trial.Types.State.Unspecified,
                Parameters =
                {
                    new Trial.Types.Parameter(),
                },
                FinalMeasurement = new Measurement(),
                Measurements = { new Measurement(), },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ClientId = "client_id729dfe2b",
                InfeasibleReason = "infeasible_reason37cf5b09",
                CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateTrial(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Trial response = client.CreateTrial(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTrialRequestObjectAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTrialRequest request = new CreateTrialRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                Trial = new Trial(),
            };
            Trial expectedResponse = new Trial
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Id = "id74b70bb8",
                State = Trial.Types.State.Unspecified,
                Parameters =
                {
                    new Trial.Types.Parameter(),
                },
                FinalMeasurement = new Measurement(),
                Measurements = { new Measurement(), },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ClientId = "client_id729dfe2b",
                InfeasibleReason = "infeasible_reason37cf5b09",
                CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateTrialAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Trial>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Trial responseCallSettings = await client.CreateTrialAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Trial responseCancellationToken = await client.CreateTrialAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTrial()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTrialRequest request = new CreateTrialRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                Trial = new Trial(),
            };
            Trial expectedResponse = new Trial
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Id = "id74b70bb8",
                State = Trial.Types.State.Unspecified,
                Parameters =
                {
                    new Trial.Types.Parameter(),
                },
                FinalMeasurement = new Measurement(),
                Measurements = { new Measurement(), },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ClientId = "client_id729dfe2b",
                InfeasibleReason = "infeasible_reason37cf5b09",
                CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateTrial(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Trial response = client.CreateTrial(request.Parent, request.Trial);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTrialAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTrialRequest request = new CreateTrialRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                Trial = new Trial(),
            };
            Trial expectedResponse = new Trial
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Id = "id74b70bb8",
                State = Trial.Types.State.Unspecified,
                Parameters =
                {
                    new Trial.Types.Parameter(),
                },
                FinalMeasurement = new Measurement(),
                Measurements = { new Measurement(), },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ClientId = "client_id729dfe2b",
                InfeasibleReason = "infeasible_reason37cf5b09",
                CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateTrialAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Trial>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Trial responseCallSettings = await client.CreateTrialAsync(request.Parent, request.Trial, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Trial responseCancellationToken = await client.CreateTrialAsync(request.Parent, request.Trial, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateTrialResourceNames()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTrialRequest request = new CreateTrialRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                Trial = new Trial(),
            };
            Trial expectedResponse = new Trial
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Id = "id74b70bb8",
                State = Trial.Types.State.Unspecified,
                Parameters =
                {
                    new Trial.Types.Parameter(),
                },
                FinalMeasurement = new Measurement(),
                Measurements = { new Measurement(), },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ClientId = "client_id729dfe2b",
                InfeasibleReason = "infeasible_reason37cf5b09",
                CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateTrial(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Trial response = client.CreateTrial(request.ParentAsStudyName, request.Trial);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateTrialResourceNamesAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateTrialRequest request = new CreateTrialRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
                Trial = new Trial(),
            };
            Trial expectedResponse = new Trial
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Id = "id74b70bb8",
                State = Trial.Types.State.Unspecified,
                Parameters =
                {
                    new Trial.Types.Parameter(),
                },
                FinalMeasurement = new Measurement(),
                Measurements = { new Measurement(), },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ClientId = "client_id729dfe2b",
                InfeasibleReason = "infeasible_reason37cf5b09",
                CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CreateTrialAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Trial>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Trial responseCallSettings = await client.CreateTrialAsync(request.ParentAsStudyName, request.Trial, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Trial responseCancellationToken = await client.CreateTrialAsync(request.ParentAsStudyName, request.Trial, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTrialRequestObject()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTrialRequest request = new GetTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            Trial expectedResponse = new Trial
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Id = "id74b70bb8",
                State = Trial.Types.State.Unspecified,
                Parameters =
                {
                    new Trial.Types.Parameter(),
                },
                FinalMeasurement = new Measurement(),
                Measurements = { new Measurement(), },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ClientId = "client_id729dfe2b",
                InfeasibleReason = "infeasible_reason37cf5b09",
                CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetTrial(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Trial response = client.GetTrial(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTrialRequestObjectAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTrialRequest request = new GetTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            Trial expectedResponse = new Trial
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Id = "id74b70bb8",
                State = Trial.Types.State.Unspecified,
                Parameters =
                {
                    new Trial.Types.Parameter(),
                },
                FinalMeasurement = new Measurement(),
                Measurements = { new Measurement(), },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ClientId = "client_id729dfe2b",
                InfeasibleReason = "infeasible_reason37cf5b09",
                CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetTrialAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Trial>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Trial responseCallSettings = await client.GetTrialAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Trial responseCancellationToken = await client.GetTrialAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTrial()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTrialRequest request = new GetTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            Trial expectedResponse = new Trial
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Id = "id74b70bb8",
                State = Trial.Types.State.Unspecified,
                Parameters =
                {
                    new Trial.Types.Parameter(),
                },
                FinalMeasurement = new Measurement(),
                Measurements = { new Measurement(), },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ClientId = "client_id729dfe2b",
                InfeasibleReason = "infeasible_reason37cf5b09",
                CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetTrial(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Trial response = client.GetTrial(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTrialAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTrialRequest request = new GetTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            Trial expectedResponse = new Trial
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Id = "id74b70bb8",
                State = Trial.Types.State.Unspecified,
                Parameters =
                {
                    new Trial.Types.Parameter(),
                },
                FinalMeasurement = new Measurement(),
                Measurements = { new Measurement(), },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ClientId = "client_id729dfe2b",
                InfeasibleReason = "infeasible_reason37cf5b09",
                CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetTrialAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Trial>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Trial responseCallSettings = await client.GetTrialAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Trial responseCancellationToken = await client.GetTrialAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetTrialResourceNames()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTrialRequest request = new GetTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            Trial expectedResponse = new Trial
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Id = "id74b70bb8",
                State = Trial.Types.State.Unspecified,
                Parameters =
                {
                    new Trial.Types.Parameter(),
                },
                FinalMeasurement = new Measurement(),
                Measurements = { new Measurement(), },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ClientId = "client_id729dfe2b",
                InfeasibleReason = "infeasible_reason37cf5b09",
                CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetTrial(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Trial response = client.GetTrial(request.TrialName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetTrialResourceNamesAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetTrialRequest request = new GetTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            Trial expectedResponse = new Trial
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Id = "id74b70bb8",
                State = Trial.Types.State.Unspecified,
                Parameters =
                {
                    new Trial.Types.Parameter(),
                },
                FinalMeasurement = new Measurement(),
                Measurements = { new Measurement(), },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ClientId = "client_id729dfe2b",
                InfeasibleReason = "infeasible_reason37cf5b09",
                CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetTrialAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Trial>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Trial responseCallSettings = await client.GetTrialAsync(request.TrialName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Trial responseCancellationToken = await client.GetTrialAsync(request.TrialName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AddTrialMeasurementRequestObject()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddTrialMeasurementRequest request = new AddTrialMeasurementRequest
            {
                TrialNameAsTrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Measurement = new Measurement(),
            };
            Trial expectedResponse = new Trial
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Id = "id74b70bb8",
                State = Trial.Types.State.Unspecified,
                Parameters =
                {
                    new Trial.Types.Parameter(),
                },
                FinalMeasurement = new Measurement(),
                Measurements = { new Measurement(), },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ClientId = "client_id729dfe2b",
                InfeasibleReason = "infeasible_reason37cf5b09",
                CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.AddTrialMeasurement(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Trial response = client.AddTrialMeasurement(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AddTrialMeasurementRequestObjectAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AddTrialMeasurementRequest request = new AddTrialMeasurementRequest
            {
                TrialNameAsTrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Measurement = new Measurement(),
            };
            Trial expectedResponse = new Trial
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Id = "id74b70bb8",
                State = Trial.Types.State.Unspecified,
                Parameters =
                {
                    new Trial.Types.Parameter(),
                },
                FinalMeasurement = new Measurement(),
                Measurements = { new Measurement(), },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ClientId = "client_id729dfe2b",
                InfeasibleReason = "infeasible_reason37cf5b09",
                CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.AddTrialMeasurementAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Trial>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Trial responseCallSettings = await client.AddTrialMeasurementAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Trial responseCancellationToken = await client.AddTrialMeasurementAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CompleteTrialRequestObject()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CompleteTrialRequest request = new CompleteTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                FinalMeasurement = new Measurement(),
                TrialInfeasible = true,
                InfeasibleReason = "infeasible_reason37cf5b09",
            };
            Trial expectedResponse = new Trial
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Id = "id74b70bb8",
                State = Trial.Types.State.Unspecified,
                Parameters =
                {
                    new Trial.Types.Parameter(),
                },
                FinalMeasurement = new Measurement(),
                Measurements = { new Measurement(), },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ClientId = "client_id729dfe2b",
                InfeasibleReason = "infeasible_reason37cf5b09",
                CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CompleteTrial(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Trial response = client.CompleteTrial(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CompleteTrialRequestObjectAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CompleteTrialRequest request = new CompleteTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                FinalMeasurement = new Measurement(),
                TrialInfeasible = true,
                InfeasibleReason = "infeasible_reason37cf5b09",
            };
            Trial expectedResponse = new Trial
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Id = "id74b70bb8",
                State = Trial.Types.State.Unspecified,
                Parameters =
                {
                    new Trial.Types.Parameter(),
                },
                FinalMeasurement = new Measurement(),
                Measurements = { new Measurement(), },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ClientId = "client_id729dfe2b",
                InfeasibleReason = "infeasible_reason37cf5b09",
                CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CompleteTrialAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Trial>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Trial responseCallSettings = await client.CompleteTrialAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Trial responseCancellationToken = await client.CompleteTrialAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTrialRequestObject()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTrialRequest request = new DeleteTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTrial(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTrial(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTrialRequestObjectAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTrialRequest request = new DeleteTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTrialAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTrialAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTrialAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTrial()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTrialRequest request = new DeleteTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTrial(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTrial(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTrialAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTrialRequest request = new DeleteTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTrialAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTrialAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTrialAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteTrialResourceNames()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTrialRequest request = new DeleteTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTrial(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteTrial(request.TrialName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteTrialResourceNamesAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteTrialRequest request = new DeleteTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteTrialAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteTrialAsync(request.TrialName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteTrialAsync(request.TrialName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void StopTrialRequestObject()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            StopTrialRequest request = new StopTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            Trial expectedResponse = new Trial
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Id = "id74b70bb8",
                State = Trial.Types.State.Unspecified,
                Parameters =
                {
                    new Trial.Types.Parameter(),
                },
                FinalMeasurement = new Measurement(),
                Measurements = { new Measurement(), },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ClientId = "client_id729dfe2b",
                InfeasibleReason = "infeasible_reason37cf5b09",
                CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.StopTrial(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Trial response = client.StopTrial(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task StopTrialRequestObjectAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            StopTrialRequest request = new StopTrialRequest
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
            };
            Trial expectedResponse = new Trial
            {
                TrialName = TrialName.FromProjectLocationStudyTrial("[PROJECT]", "[LOCATION]", "[STUDY]", "[TRIAL]"),
                Id = "id74b70bb8",
                State = Trial.Types.State.Unspecified,
                Parameters =
                {
                    new Trial.Types.Parameter(),
                },
                FinalMeasurement = new Measurement(),
                Measurements = { new Measurement(), },
                StartTime = new wkt::Timestamp(),
                EndTime = new wkt::Timestamp(),
                ClientId = "client_id729dfe2b",
                InfeasibleReason = "infeasible_reason37cf5b09",
                CustomJobAsCustomJobName = CustomJobName.FromProjectLocationCustomJob("[PROJECT]", "[LOCATION]", "[CUSTOM_JOB]"),
                WebAccessUris =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
            };
            mockGrpcClient.Setup(x => x.StopTrialAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Trial>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            Trial responseCallSettings = await client.StopTrialAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Trial responseCancellationToken = await client.StopTrialAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListOptimalTrialsRequestObject()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListOptimalTrialsRequest request = new ListOptimalTrialsRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            ListOptimalTrialsResponse expectedResponse = new ListOptimalTrialsResponse
            {
                OptimalTrials = { new Trial(), },
            };
            mockGrpcClient.Setup(x => x.ListOptimalTrials(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            ListOptimalTrialsResponse response = client.ListOptimalTrials(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListOptimalTrialsRequestObjectAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListOptimalTrialsRequest request = new ListOptimalTrialsRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            ListOptimalTrialsResponse expectedResponse = new ListOptimalTrialsResponse
            {
                OptimalTrials = { new Trial(), },
            };
            mockGrpcClient.Setup(x => x.ListOptimalTrialsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListOptimalTrialsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            ListOptimalTrialsResponse responseCallSettings = await client.ListOptimalTrialsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListOptimalTrialsResponse responseCancellationToken = await client.ListOptimalTrialsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListOptimalTrials()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListOptimalTrialsRequest request = new ListOptimalTrialsRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            ListOptimalTrialsResponse expectedResponse = new ListOptimalTrialsResponse
            {
                OptimalTrials = { new Trial(), },
            };
            mockGrpcClient.Setup(x => x.ListOptimalTrials(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            ListOptimalTrialsResponse response = client.ListOptimalTrials(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListOptimalTrialsAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListOptimalTrialsRequest request = new ListOptimalTrialsRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            ListOptimalTrialsResponse expectedResponse = new ListOptimalTrialsResponse
            {
                OptimalTrials = { new Trial(), },
            };
            mockGrpcClient.Setup(x => x.ListOptimalTrialsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListOptimalTrialsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            ListOptimalTrialsResponse responseCallSettings = await client.ListOptimalTrialsAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListOptimalTrialsResponse responseCancellationToken = await client.ListOptimalTrialsAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListOptimalTrialsResourceNames()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListOptimalTrialsRequest request = new ListOptimalTrialsRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            ListOptimalTrialsResponse expectedResponse = new ListOptimalTrialsResponse
            {
                OptimalTrials = { new Trial(), },
            };
            mockGrpcClient.Setup(x => x.ListOptimalTrials(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            ListOptimalTrialsResponse response = client.ListOptimalTrials(request.ParentAsStudyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListOptimalTrialsResourceNamesAsync()
        {
            moq::Mock<VizierService.VizierServiceClient> mockGrpcClient = new moq::Mock<VizierService.VizierServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListOptimalTrialsRequest request = new ListOptimalTrialsRequest
            {
                ParentAsStudyName = StudyName.FromProjectLocationStudy("[PROJECT]", "[LOCATION]", "[STUDY]"),
            };
            ListOptimalTrialsResponse expectedResponse = new ListOptimalTrialsResponse
            {
                OptimalTrials = { new Trial(), },
            };
            mockGrpcClient.Setup(x => x.ListOptimalTrialsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListOptimalTrialsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            VizierServiceClient client = new VizierServiceClientImpl(mockGrpcClient.Object, null);
            ListOptimalTrialsResponse responseCallSettings = await client.ListOptimalTrialsAsync(request.ParentAsStudyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListOptimalTrialsResponse responseCancellationToken = await client.ListOptimalTrialsAsync(request.ParentAsStudyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
