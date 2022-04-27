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
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.RecommendationEngine.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPredictionApiKeyRegistryClientTest
    {
        [xunit::FactAttribute]
        public void CreatePredictionApiKeyRegistrationRequestObject()
        {
            moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient> mockGrpcClient = new moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient>(moq::MockBehavior.Strict);
            CreatePredictionApiKeyRegistrationRequest request = new CreatePredictionApiKeyRegistrationRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                PredictionApiKeyRegistration = new PredictionApiKeyRegistration(),
            };
            PredictionApiKeyRegistration expectedResponse = new PredictionApiKeyRegistration
            {
                ApiKey = "api_key30288039",
            };
            mockGrpcClient.Setup(x => x.CreatePredictionApiKeyRegistration(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionApiKeyRegistryClient client = new PredictionApiKeyRegistryClientImpl(mockGrpcClient.Object, null, null);
            PredictionApiKeyRegistration response = client.CreatePredictionApiKeyRegistration(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePredictionApiKeyRegistrationRequestObjectAsync()
        {
            moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient> mockGrpcClient = new moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient>(moq::MockBehavior.Strict);
            CreatePredictionApiKeyRegistrationRequest request = new CreatePredictionApiKeyRegistrationRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                PredictionApiKeyRegistration = new PredictionApiKeyRegistration(),
            };
            PredictionApiKeyRegistration expectedResponse = new PredictionApiKeyRegistration
            {
                ApiKey = "api_key30288039",
            };
            mockGrpcClient.Setup(x => x.CreatePredictionApiKeyRegistrationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PredictionApiKeyRegistration>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionApiKeyRegistryClient client = new PredictionApiKeyRegistryClientImpl(mockGrpcClient.Object, null, null);
            PredictionApiKeyRegistration responseCallSettings = await client.CreatePredictionApiKeyRegistrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PredictionApiKeyRegistration responseCancellationToken = await client.CreatePredictionApiKeyRegistrationAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePredictionApiKeyRegistration()
        {
            moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient> mockGrpcClient = new moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient>(moq::MockBehavior.Strict);
            CreatePredictionApiKeyRegistrationRequest request = new CreatePredictionApiKeyRegistrationRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                PredictionApiKeyRegistration = new PredictionApiKeyRegistration(),
            };
            PredictionApiKeyRegistration expectedResponse = new PredictionApiKeyRegistration
            {
                ApiKey = "api_key30288039",
            };
            mockGrpcClient.Setup(x => x.CreatePredictionApiKeyRegistration(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionApiKeyRegistryClient client = new PredictionApiKeyRegistryClientImpl(mockGrpcClient.Object, null, null);
            PredictionApiKeyRegistration response = client.CreatePredictionApiKeyRegistration(request.Parent, request.PredictionApiKeyRegistration);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePredictionApiKeyRegistrationAsync()
        {
            moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient> mockGrpcClient = new moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient>(moq::MockBehavior.Strict);
            CreatePredictionApiKeyRegistrationRequest request = new CreatePredictionApiKeyRegistrationRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                PredictionApiKeyRegistration = new PredictionApiKeyRegistration(),
            };
            PredictionApiKeyRegistration expectedResponse = new PredictionApiKeyRegistration
            {
                ApiKey = "api_key30288039",
            };
            mockGrpcClient.Setup(x => x.CreatePredictionApiKeyRegistrationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PredictionApiKeyRegistration>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionApiKeyRegistryClient client = new PredictionApiKeyRegistryClientImpl(mockGrpcClient.Object, null, null);
            PredictionApiKeyRegistration responseCallSettings = await client.CreatePredictionApiKeyRegistrationAsync(request.Parent, request.PredictionApiKeyRegistration, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PredictionApiKeyRegistration responseCancellationToken = await client.CreatePredictionApiKeyRegistrationAsync(request.Parent, request.PredictionApiKeyRegistration, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreatePredictionApiKeyRegistrationResourceNames()
        {
            moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient> mockGrpcClient = new moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient>(moq::MockBehavior.Strict);
            CreatePredictionApiKeyRegistrationRequest request = new CreatePredictionApiKeyRegistrationRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                PredictionApiKeyRegistration = new PredictionApiKeyRegistration(),
            };
            PredictionApiKeyRegistration expectedResponse = new PredictionApiKeyRegistration
            {
                ApiKey = "api_key30288039",
            };
            mockGrpcClient.Setup(x => x.CreatePredictionApiKeyRegistration(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionApiKeyRegistryClient client = new PredictionApiKeyRegistryClientImpl(mockGrpcClient.Object, null, null);
            PredictionApiKeyRegistration response = client.CreatePredictionApiKeyRegistration(request.ParentAsEventStoreName, request.PredictionApiKeyRegistration);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreatePredictionApiKeyRegistrationResourceNamesAsync()
        {
            moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient> mockGrpcClient = new moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient>(moq::MockBehavior.Strict);
            CreatePredictionApiKeyRegistrationRequest request = new CreatePredictionApiKeyRegistrationRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                PredictionApiKeyRegistration = new PredictionApiKeyRegistration(),
            };
            PredictionApiKeyRegistration expectedResponse = new PredictionApiKeyRegistration
            {
                ApiKey = "api_key30288039",
            };
            mockGrpcClient.Setup(x => x.CreatePredictionApiKeyRegistrationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PredictionApiKeyRegistration>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionApiKeyRegistryClient client = new PredictionApiKeyRegistryClientImpl(mockGrpcClient.Object, null, null);
            PredictionApiKeyRegistration responseCallSettings = await client.CreatePredictionApiKeyRegistrationAsync(request.ParentAsEventStoreName, request.PredictionApiKeyRegistration, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PredictionApiKeyRegistration responseCancellationToken = await client.CreatePredictionApiKeyRegistrationAsync(request.ParentAsEventStoreName, request.PredictionApiKeyRegistration, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePredictionApiKeyRegistrationRequestObject()
        {
            moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient> mockGrpcClient = new moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient>(moq::MockBehavior.Strict);
            DeletePredictionApiKeyRegistrationRequest request = new DeletePredictionApiKeyRegistrationRequest
            {
                PredictionApiKeyRegistrationName = PredictionApiKeyRegistrationName.FromProjectLocationCatalogEventStorePredictionApiKeyRegistration("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]", "[PREDICTION_API_KEY_REGISTRATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePredictionApiKeyRegistration(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionApiKeyRegistryClient client = new PredictionApiKeyRegistryClientImpl(mockGrpcClient.Object, null, null);
            client.DeletePredictionApiKeyRegistration(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePredictionApiKeyRegistrationRequestObjectAsync()
        {
            moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient> mockGrpcClient = new moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient>(moq::MockBehavior.Strict);
            DeletePredictionApiKeyRegistrationRequest request = new DeletePredictionApiKeyRegistrationRequest
            {
                PredictionApiKeyRegistrationName = PredictionApiKeyRegistrationName.FromProjectLocationCatalogEventStorePredictionApiKeyRegistration("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]", "[PREDICTION_API_KEY_REGISTRATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePredictionApiKeyRegistrationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionApiKeyRegistryClient client = new PredictionApiKeyRegistryClientImpl(mockGrpcClient.Object, null, null);
            await client.DeletePredictionApiKeyRegistrationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePredictionApiKeyRegistrationAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePredictionApiKeyRegistration()
        {
            moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient> mockGrpcClient = new moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient>(moq::MockBehavior.Strict);
            DeletePredictionApiKeyRegistrationRequest request = new DeletePredictionApiKeyRegistrationRequest
            {
                PredictionApiKeyRegistrationName = PredictionApiKeyRegistrationName.FromProjectLocationCatalogEventStorePredictionApiKeyRegistration("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]", "[PREDICTION_API_KEY_REGISTRATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePredictionApiKeyRegistration(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionApiKeyRegistryClient client = new PredictionApiKeyRegistryClientImpl(mockGrpcClient.Object, null, null);
            client.DeletePredictionApiKeyRegistration(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePredictionApiKeyRegistrationAsync()
        {
            moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient> mockGrpcClient = new moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient>(moq::MockBehavior.Strict);
            DeletePredictionApiKeyRegistrationRequest request = new DeletePredictionApiKeyRegistrationRequest
            {
                PredictionApiKeyRegistrationName = PredictionApiKeyRegistrationName.FromProjectLocationCatalogEventStorePredictionApiKeyRegistration("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]", "[PREDICTION_API_KEY_REGISTRATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePredictionApiKeyRegistrationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionApiKeyRegistryClient client = new PredictionApiKeyRegistryClientImpl(mockGrpcClient.Object, null, null);
            await client.DeletePredictionApiKeyRegistrationAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePredictionApiKeyRegistrationAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePredictionApiKeyRegistrationResourceNames()
        {
            moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient> mockGrpcClient = new moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient>(moq::MockBehavior.Strict);
            DeletePredictionApiKeyRegistrationRequest request = new DeletePredictionApiKeyRegistrationRequest
            {
                PredictionApiKeyRegistrationName = PredictionApiKeyRegistrationName.FromProjectLocationCatalogEventStorePredictionApiKeyRegistration("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]", "[PREDICTION_API_KEY_REGISTRATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePredictionApiKeyRegistration(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PredictionApiKeyRegistryClient client = new PredictionApiKeyRegistryClientImpl(mockGrpcClient.Object, null, null);
            client.DeletePredictionApiKeyRegistration(request.PredictionApiKeyRegistrationName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePredictionApiKeyRegistrationResourceNamesAsync()
        {
            moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient> mockGrpcClient = new moq::Mock<PredictionApiKeyRegistry.PredictionApiKeyRegistryClient>(moq::MockBehavior.Strict);
            DeletePredictionApiKeyRegistrationRequest request = new DeletePredictionApiKeyRegistrationRequest
            {
                PredictionApiKeyRegistrationName = PredictionApiKeyRegistrationName.FromProjectLocationCatalogEventStorePredictionApiKeyRegistration("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]", "[PREDICTION_API_KEY_REGISTRATION]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePredictionApiKeyRegistrationAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PredictionApiKeyRegistryClient client = new PredictionApiKeyRegistryClientImpl(mockGrpcClient.Object, null, null);
            await client.DeletePredictionApiKeyRegistrationAsync(request.PredictionApiKeyRegistrationName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePredictionApiKeyRegistrationAsync(request.PredictionApiKeyRegistrationName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }
    }
}
