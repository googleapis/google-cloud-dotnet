// Copyright 2022 Google LLC
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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using gcl = Google.Cloud.Location;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Dialogflow.V2Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedKnowledgeBasesClientTest
    {
        [xunit::FactAttribute]
        public void GetKnowledgeBaseRequestObject()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetKnowledgeBaseRequest request = new GetKnowledgeBaseRequest
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.GetKnowledgeBase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase response = client.GetKnowledgeBase(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetKnowledgeBaseRequestObjectAsync()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetKnowledgeBaseRequest request = new GetKnowledgeBaseRequest
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.GetKnowledgeBaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<KnowledgeBase>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase responseCallSettings = await client.GetKnowledgeBaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            KnowledgeBase responseCancellationToken = await client.GetKnowledgeBaseAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetKnowledgeBase()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetKnowledgeBaseRequest request = new GetKnowledgeBaseRequest
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.GetKnowledgeBase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase response = client.GetKnowledgeBase(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetKnowledgeBaseAsync()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetKnowledgeBaseRequest request = new GetKnowledgeBaseRequest
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.GetKnowledgeBaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<KnowledgeBase>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase responseCallSettings = await client.GetKnowledgeBaseAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            KnowledgeBase responseCancellationToken = await client.GetKnowledgeBaseAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetKnowledgeBaseResourceNames()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetKnowledgeBaseRequest request = new GetKnowledgeBaseRequest
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.GetKnowledgeBase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase response = client.GetKnowledgeBase(request.KnowledgeBaseName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetKnowledgeBaseResourceNamesAsync()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            GetKnowledgeBaseRequest request = new GetKnowledgeBaseRequest
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.GetKnowledgeBaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<KnowledgeBase>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase responseCallSettings = await client.GetKnowledgeBaseAsync(request.KnowledgeBaseName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            KnowledgeBase responseCancellationToken = await client.GetKnowledgeBaseAsync(request.KnowledgeBaseName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateKnowledgeBaseRequestObject()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateKnowledgeBaseRequest request = new CreateKnowledgeBaseRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                KnowledgeBase = new KnowledgeBase(),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.CreateKnowledgeBase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase response = client.CreateKnowledgeBase(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateKnowledgeBaseRequestObjectAsync()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateKnowledgeBaseRequest request = new CreateKnowledgeBaseRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                KnowledgeBase = new KnowledgeBase(),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.CreateKnowledgeBaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<KnowledgeBase>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase responseCallSettings = await client.CreateKnowledgeBaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            KnowledgeBase responseCancellationToken = await client.CreateKnowledgeBaseAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateKnowledgeBase()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateKnowledgeBaseRequest request = new CreateKnowledgeBaseRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                KnowledgeBase = new KnowledgeBase(),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.CreateKnowledgeBase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase response = client.CreateKnowledgeBase(request.Parent, request.KnowledgeBase);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateKnowledgeBaseAsync()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateKnowledgeBaseRequest request = new CreateKnowledgeBaseRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                KnowledgeBase = new KnowledgeBase(),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.CreateKnowledgeBaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<KnowledgeBase>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase responseCallSettings = await client.CreateKnowledgeBaseAsync(request.Parent, request.KnowledgeBase, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            KnowledgeBase responseCancellationToken = await client.CreateKnowledgeBaseAsync(request.Parent, request.KnowledgeBase, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateKnowledgeBaseResourceNames1()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateKnowledgeBaseRequest request = new CreateKnowledgeBaseRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                KnowledgeBase = new KnowledgeBase(),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.CreateKnowledgeBase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase response = client.CreateKnowledgeBase(request.ParentAsProjectName, request.KnowledgeBase);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateKnowledgeBaseResourceNames1Async()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateKnowledgeBaseRequest request = new CreateKnowledgeBaseRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                KnowledgeBase = new KnowledgeBase(),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.CreateKnowledgeBaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<KnowledgeBase>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase responseCallSettings = await client.CreateKnowledgeBaseAsync(request.ParentAsProjectName, request.KnowledgeBase, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            KnowledgeBase responseCancellationToken = await client.CreateKnowledgeBaseAsync(request.ParentAsProjectName, request.KnowledgeBase, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateKnowledgeBaseResourceNames2()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateKnowledgeBaseRequest request = new CreateKnowledgeBaseRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                KnowledgeBase = new KnowledgeBase(),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.CreateKnowledgeBase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase response = client.CreateKnowledgeBase(request.ParentAsLocationName, request.KnowledgeBase);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateKnowledgeBaseResourceNames2Async()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            CreateKnowledgeBaseRequest request = new CreateKnowledgeBaseRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                KnowledgeBase = new KnowledgeBase(),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.CreateKnowledgeBaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<KnowledgeBase>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase responseCallSettings = await client.CreateKnowledgeBaseAsync(request.ParentAsLocationName, request.KnowledgeBase, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            KnowledgeBase responseCancellationToken = await client.CreateKnowledgeBaseAsync(request.ParentAsLocationName, request.KnowledgeBase, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteKnowledgeBaseRequestObject()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteKnowledgeBaseRequest request = new DeleteKnowledgeBaseRequest
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteKnowledgeBase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteKnowledgeBase(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteKnowledgeBaseRequestObjectAsync()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteKnowledgeBaseRequest request = new DeleteKnowledgeBaseRequest
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                Force = true,
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteKnowledgeBaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteKnowledgeBaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteKnowledgeBaseAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteKnowledgeBase()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteKnowledgeBaseRequest request = new DeleteKnowledgeBaseRequest
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteKnowledgeBase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteKnowledgeBase(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteKnowledgeBaseAsync()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteKnowledgeBaseRequest request = new DeleteKnowledgeBaseRequest
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteKnowledgeBaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteKnowledgeBaseAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteKnowledgeBaseAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteKnowledgeBaseResourceNames()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteKnowledgeBaseRequest request = new DeleteKnowledgeBaseRequest
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteKnowledgeBase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteKnowledgeBase(request.KnowledgeBaseName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteKnowledgeBaseResourceNamesAsync()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            DeleteKnowledgeBaseRequest request = new DeleteKnowledgeBaseRequest
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteKnowledgeBaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteKnowledgeBaseAsync(request.KnowledgeBaseName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteKnowledgeBaseAsync(request.KnowledgeBaseName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateKnowledgeBaseRequestObject()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateKnowledgeBaseRequest request = new UpdateKnowledgeBaseRequest
            {
                KnowledgeBase = new KnowledgeBase(),
                UpdateMask = new wkt::FieldMask(),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.UpdateKnowledgeBase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase response = client.UpdateKnowledgeBase(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateKnowledgeBaseRequestObjectAsync()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateKnowledgeBaseRequest request = new UpdateKnowledgeBaseRequest
            {
                KnowledgeBase = new KnowledgeBase(),
                UpdateMask = new wkt::FieldMask(),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.UpdateKnowledgeBaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<KnowledgeBase>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase responseCallSettings = await client.UpdateKnowledgeBaseAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            KnowledgeBase responseCancellationToken = await client.UpdateKnowledgeBaseAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateKnowledgeBase1()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateKnowledgeBaseRequest request = new UpdateKnowledgeBaseRequest
            {
                KnowledgeBase = new KnowledgeBase(),
                UpdateMask = new wkt::FieldMask(),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.UpdateKnowledgeBase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase response = client.UpdateKnowledgeBase(request.KnowledgeBase, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateKnowledgeBase1Async()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateKnowledgeBaseRequest request = new UpdateKnowledgeBaseRequest
            {
                KnowledgeBase = new KnowledgeBase(),
                UpdateMask = new wkt::FieldMask(),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.UpdateKnowledgeBaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<KnowledgeBase>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase responseCallSettings = await client.UpdateKnowledgeBaseAsync(request.KnowledgeBase, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            KnowledgeBase responseCancellationToken = await client.UpdateKnowledgeBaseAsync(request.KnowledgeBase, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateKnowledgeBase2()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateKnowledgeBaseRequest request = new UpdateKnowledgeBaseRequest
            {
                KnowledgeBase = new KnowledgeBase(),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.UpdateKnowledgeBase(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase response = client.UpdateKnowledgeBase(request.KnowledgeBase);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateKnowledgeBase2Async()
        {
            moq::Mock<KnowledgeBases.KnowledgeBasesClient> mockGrpcClient = new moq::Mock<KnowledgeBases.KnowledgeBasesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateLocationsClient()).Returns(new moq::Mock<gcl::Locations.LocationsClient>().Object);
            UpdateKnowledgeBaseRequest request = new UpdateKnowledgeBaseRequest
            {
                KnowledgeBase = new KnowledgeBase(),
            };
            KnowledgeBase expectedResponse = new KnowledgeBase
            {
                KnowledgeBaseName = KnowledgeBaseName.FromProjectKnowledgeBase("[PROJECT]", "[KNOWLEDGE_BASE]"),
                DisplayName = "display_name137f65c2",
                LanguageCode = "language_code2f6c7160",
            };
            mockGrpcClient.Setup(x => x.UpdateKnowledgeBaseAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<KnowledgeBase>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KnowledgeBasesClient client = new KnowledgeBasesClientImpl(mockGrpcClient.Object, null, null);
            KnowledgeBase responseCallSettings = await client.UpdateKnowledgeBaseAsync(request.KnowledgeBase, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            KnowledgeBase responseCancellationToken = await client.UpdateKnowledgeBaseAsync(request.KnowledgeBase, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
