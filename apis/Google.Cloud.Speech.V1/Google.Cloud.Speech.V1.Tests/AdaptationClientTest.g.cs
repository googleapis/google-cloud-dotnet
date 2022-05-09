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

using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Speech.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAdaptationClientTest
    {
        [xunit::FactAttribute]
        public void CreatePhraseSetRequestObject()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            CreatePhraseSetRequest request = new CreatePhraseSetRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PhraseSetId = "phrase_set_ide6971137",
                PhraseSet = new PhraseSet(),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
            };
            mockGrpcClient.Setup(x => x.CreatePhraseSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            PhraseSet response = client.CreatePhraseSet(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePhraseSetRequestObjectAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            CreatePhraseSetRequest request = new CreatePhraseSetRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PhraseSetId = "phrase_set_ide6971137",
                PhraseSet = new PhraseSet(),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
            };
            mockGrpcClient.Setup(x => x.CreatePhraseSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            PhraseSet responseCallSettings = await client.CreatePhraseSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseSet responseCancellationToken = await client.CreatePhraseSetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePhraseSet()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            CreatePhraseSetRequest request = new CreatePhraseSetRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PhraseSetId = "phrase_set_ide6971137",
                PhraseSet = new PhraseSet(),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
            };
            mockGrpcClient.Setup(x => x.CreatePhraseSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            PhraseSet response = client.CreatePhraseSet(request.Parent, request.PhraseSet, request.PhraseSetId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePhraseSetAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            CreatePhraseSetRequest request = new CreatePhraseSetRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PhraseSetId = "phrase_set_ide6971137",
                PhraseSet = new PhraseSet(),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
            };
            mockGrpcClient.Setup(x => x.CreatePhraseSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            PhraseSet responseCallSettings = await client.CreatePhraseSetAsync(request.Parent, request.PhraseSet, request.PhraseSetId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseSet responseCancellationToken = await client.CreatePhraseSetAsync(request.Parent, request.PhraseSet, request.PhraseSetId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePhraseSetResourceNames()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            CreatePhraseSetRequest request = new CreatePhraseSetRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PhraseSetId = "phrase_set_ide6971137",
                PhraseSet = new PhraseSet(),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
            };
            mockGrpcClient.Setup(x => x.CreatePhraseSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            PhraseSet response = client.CreatePhraseSet(request.ParentAsLocationName, request.PhraseSet, request.PhraseSetId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePhraseSetResourceNamesAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            CreatePhraseSetRequest request = new CreatePhraseSetRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                PhraseSetId = "phrase_set_ide6971137",
                PhraseSet = new PhraseSet(),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
            };
            mockGrpcClient.Setup(x => x.CreatePhraseSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            PhraseSet responseCallSettings = await client.CreatePhraseSetAsync(request.ParentAsLocationName, request.PhraseSet, request.PhraseSetId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseSet responseCancellationToken = await client.CreatePhraseSetAsync(request.ParentAsLocationName, request.PhraseSet, request.PhraseSetId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPhraseSetRequestObject()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            GetPhraseSetRequest request = new GetPhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
            };
            mockGrpcClient.Setup(x => x.GetPhraseSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            PhraseSet response = client.GetPhraseSet(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPhraseSetRequestObjectAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            GetPhraseSetRequest request = new GetPhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
            };
            mockGrpcClient.Setup(x => x.GetPhraseSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            PhraseSet responseCallSettings = await client.GetPhraseSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseSet responseCancellationToken = await client.GetPhraseSetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPhraseSet()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            GetPhraseSetRequest request = new GetPhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
            };
            mockGrpcClient.Setup(x => x.GetPhraseSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            PhraseSet response = client.GetPhraseSet(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPhraseSetAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            GetPhraseSetRequest request = new GetPhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
            };
            mockGrpcClient.Setup(x => x.GetPhraseSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            PhraseSet responseCallSettings = await client.GetPhraseSetAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseSet responseCancellationToken = await client.GetPhraseSetAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPhraseSetResourceNames()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            GetPhraseSetRequest request = new GetPhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
            };
            mockGrpcClient.Setup(x => x.GetPhraseSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            PhraseSet response = client.GetPhraseSet(request.PhraseSetName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPhraseSetResourceNamesAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            GetPhraseSetRequest request = new GetPhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
            };
            mockGrpcClient.Setup(x => x.GetPhraseSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            PhraseSet responseCallSettings = await client.GetPhraseSetAsync(request.PhraseSetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseSet responseCancellationToken = await client.GetPhraseSetAsync(request.PhraseSetName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePhraseSetRequestObject()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            UpdatePhraseSetRequest request = new UpdatePhraseSetRequest
            {
                PhraseSet = new PhraseSet(),
                UpdateMask = new wkt::FieldMask(),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
            };
            mockGrpcClient.Setup(x => x.UpdatePhraseSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            PhraseSet response = client.UpdatePhraseSet(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePhraseSetRequestObjectAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            UpdatePhraseSetRequest request = new UpdatePhraseSetRequest
            {
                PhraseSet = new PhraseSet(),
                UpdateMask = new wkt::FieldMask(),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
            };
            mockGrpcClient.Setup(x => x.UpdatePhraseSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            PhraseSet responseCallSettings = await client.UpdatePhraseSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseSet responseCancellationToken = await client.UpdatePhraseSetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdatePhraseSet()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            UpdatePhraseSetRequest request = new UpdatePhraseSetRequest
            {
                PhraseSet = new PhraseSet(),
                UpdateMask = new wkt::FieldMask(),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
            };
            mockGrpcClient.Setup(x => x.UpdatePhraseSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            PhraseSet response = client.UpdatePhraseSet(request.PhraseSet, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdatePhraseSetAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            UpdatePhraseSetRequest request = new UpdatePhraseSetRequest
            {
                PhraseSet = new PhraseSet(),
                UpdateMask = new wkt::FieldMask(),
            };
            PhraseSet expectedResponse = new PhraseSet
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
                Phrases =
                {
                    new PhraseSet.Types.Phrase(),
                },
                Boost = 7.584708E+17F,
            };
            mockGrpcClient.Setup(x => x.UpdatePhraseSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PhraseSet>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            PhraseSet responseCallSettings = await client.UpdatePhraseSetAsync(request.PhraseSet, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PhraseSet responseCancellationToken = await client.UpdatePhraseSetAsync(request.PhraseSet, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePhraseSetRequestObject()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            DeletePhraseSetRequest request = new DeletePhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePhraseSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            client.DeletePhraseSet(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePhraseSetRequestObjectAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            DeletePhraseSetRequest request = new DeletePhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePhraseSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            await client.DeletePhraseSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePhraseSetAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePhraseSet()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            DeletePhraseSetRequest request = new DeletePhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePhraseSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            client.DeletePhraseSet(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePhraseSetAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            DeletePhraseSetRequest request = new DeletePhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePhraseSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            await client.DeletePhraseSetAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePhraseSetAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePhraseSetResourceNames()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            DeletePhraseSetRequest request = new DeletePhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePhraseSet(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            client.DeletePhraseSet(request.PhraseSetName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePhraseSetResourceNamesAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            DeletePhraseSetRequest request = new DeletePhraseSetRequest
            {
                PhraseSetName = PhraseSetName.FromProjectLocationPhraseSet("[PROJECT]", "[LOCATION]", "[PHRASE_SET]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePhraseSetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            await client.DeletePhraseSetAsync(request.PhraseSetName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePhraseSetAsync(request.PhraseSetName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCustomClassRequestObject()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            CreateCustomClassRequest request = new CreateCustomClassRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomClassId = "custom_class_idb1fbae50",
                CustomClass = new CustomClass(),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                CustomClassId = "custom_class_idb1fbae50",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateCustomClass(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            CustomClass response = client.CreateCustomClass(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCustomClassRequestObjectAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            CreateCustomClassRequest request = new CreateCustomClassRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomClassId = "custom_class_idb1fbae50",
                CustomClass = new CustomClass(),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                CustomClassId = "custom_class_idb1fbae50",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateCustomClassAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomClass>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            CustomClass responseCallSettings = await client.CreateCustomClassAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomClass responseCancellationToken = await client.CreateCustomClassAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCustomClass()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            CreateCustomClassRequest request = new CreateCustomClassRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomClassId = "custom_class_idb1fbae50",
                CustomClass = new CustomClass(),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                CustomClassId = "custom_class_idb1fbae50",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateCustomClass(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            CustomClass response = client.CreateCustomClass(request.Parent, request.CustomClass, request.CustomClassId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCustomClassAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            CreateCustomClassRequest request = new CreateCustomClassRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomClassId = "custom_class_idb1fbae50",
                CustomClass = new CustomClass(),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                CustomClassId = "custom_class_idb1fbae50",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateCustomClassAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomClass>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            CustomClass responseCallSettings = await client.CreateCustomClassAsync(request.Parent, request.CustomClass, request.CustomClassId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomClass responseCancellationToken = await client.CreateCustomClassAsync(request.Parent, request.CustomClass, request.CustomClassId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCustomClassResourceNames()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            CreateCustomClassRequest request = new CreateCustomClassRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomClassId = "custom_class_idb1fbae50",
                CustomClass = new CustomClass(),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                CustomClassId = "custom_class_idb1fbae50",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateCustomClass(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            CustomClass response = client.CreateCustomClass(request.ParentAsLocationName, request.CustomClass, request.CustomClassId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCustomClassResourceNamesAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            CreateCustomClassRequest request = new CreateCustomClassRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                CustomClassId = "custom_class_idb1fbae50",
                CustomClass = new CustomClass(),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                CustomClassId = "custom_class_idb1fbae50",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
            };
            mockGrpcClient.Setup(x => x.CreateCustomClassAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomClass>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            CustomClass responseCallSettings = await client.CreateCustomClassAsync(request.ParentAsLocationName, request.CustomClass, request.CustomClassId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomClass responseCancellationToken = await client.CreateCustomClassAsync(request.ParentAsLocationName, request.CustomClass, request.CustomClassId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomClassRequestObject()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            GetCustomClassRequest request = new GetCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                CustomClassId = "custom_class_idb1fbae50",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomClass(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            CustomClass response = client.GetCustomClass(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomClassRequestObjectAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            GetCustomClassRequest request = new GetCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                CustomClassId = "custom_class_idb1fbae50",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomClassAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomClass>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            CustomClass responseCallSettings = await client.GetCustomClassAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomClass responseCancellationToken = await client.GetCustomClassAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomClass()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            GetCustomClassRequest request = new GetCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                CustomClassId = "custom_class_idb1fbae50",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomClass(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            CustomClass response = client.GetCustomClass(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomClassAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            GetCustomClassRequest request = new GetCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                CustomClassId = "custom_class_idb1fbae50",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomClassAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomClass>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            CustomClass responseCallSettings = await client.GetCustomClassAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomClass responseCancellationToken = await client.GetCustomClassAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCustomClassResourceNames()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            GetCustomClassRequest request = new GetCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                CustomClassId = "custom_class_idb1fbae50",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomClass(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            CustomClass response = client.GetCustomClass(request.CustomClassName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCustomClassResourceNamesAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            GetCustomClassRequest request = new GetCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                CustomClassId = "custom_class_idb1fbae50",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
            };
            mockGrpcClient.Setup(x => x.GetCustomClassAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomClass>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            CustomClass responseCallSettings = await client.GetCustomClassAsync(request.CustomClassName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomClass responseCancellationToken = await client.GetCustomClassAsync(request.CustomClassName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCustomClassRequestObject()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            UpdateCustomClassRequest request = new UpdateCustomClassRequest
            {
                CustomClass = new CustomClass(),
                UpdateMask = new wkt::FieldMask(),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                CustomClassId = "custom_class_idb1fbae50",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateCustomClass(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            CustomClass response = client.UpdateCustomClass(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCustomClassRequestObjectAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            UpdateCustomClassRequest request = new UpdateCustomClassRequest
            {
                CustomClass = new CustomClass(),
                UpdateMask = new wkt::FieldMask(),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                CustomClassId = "custom_class_idb1fbae50",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateCustomClassAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomClass>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            CustomClass responseCallSettings = await client.UpdateCustomClassAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomClass responseCancellationToken = await client.UpdateCustomClassAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCustomClass()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            UpdateCustomClassRequest request = new UpdateCustomClassRequest
            {
                CustomClass = new CustomClass(),
                UpdateMask = new wkt::FieldMask(),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                CustomClassId = "custom_class_idb1fbae50",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateCustomClass(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            CustomClass response = client.UpdateCustomClass(request.CustomClass, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCustomClassAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            UpdateCustomClassRequest request = new UpdateCustomClassRequest
            {
                CustomClass = new CustomClass(),
                UpdateMask = new wkt::FieldMask(),
            };
            CustomClass expectedResponse = new CustomClass
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
                CustomClassId = "custom_class_idb1fbae50",
                Items =
                {
                    new CustomClass.Types.ClassItem(),
                },
            };
            mockGrpcClient.Setup(x => x.UpdateCustomClassAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CustomClass>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            CustomClass responseCallSettings = await client.UpdateCustomClassAsync(request.CustomClass, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CustomClass responseCancellationToken = await client.UpdateCustomClassAsync(request.CustomClass, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCustomClassRequestObject()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            DeleteCustomClassRequest request = new DeleteCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCustomClass(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            client.DeleteCustomClass(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteCustomClassRequestObjectAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            DeleteCustomClassRequest request = new DeleteCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCustomClassAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            await client.DeleteCustomClassAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteCustomClassAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCustomClass()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            DeleteCustomClassRequest request = new DeleteCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCustomClass(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            client.DeleteCustomClass(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteCustomClassAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            DeleteCustomClassRequest request = new DeleteCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCustomClassAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            await client.DeleteCustomClassAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteCustomClassAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteCustomClassResourceNames()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            DeleteCustomClassRequest request = new DeleteCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCustomClass(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            client.DeleteCustomClass(request.CustomClassName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteCustomClassResourceNamesAsync()
        {
            moq::Mock<Adaptation.AdaptationClient> mockGrpcClient = new moq::Mock<Adaptation.AdaptationClient>(moq::MockBehavior.Strict);
            DeleteCustomClassRequest request = new DeleteCustomClassRequest
            {
                CustomClassName = CustomClassName.FromProjectLocationCustomClass("[PROJECT]", "[LOCATION]", "[CUSTOM_CLASS]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteCustomClassAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AdaptationClient client = new AdaptationClientImpl(mockGrpcClient.Object, null);
            await client.DeleteCustomClassAsync(request.CustomClassName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteCustomClassAsync(request.CustomClassName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
