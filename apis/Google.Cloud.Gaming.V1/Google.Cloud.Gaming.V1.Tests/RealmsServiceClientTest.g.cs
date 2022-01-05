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
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Gaming.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRealmsServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetRealmRequestObject()
        {
            moq::Mock<RealmsService.RealmsServiceClient> mockGrpcClient = new moq::Mock<RealmsService.RealmsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRealmRequest request = new GetRealmRequest
            {
                RealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
            };
            Realm expectedResponse = new Realm
            {
                RealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                TimeZone = "time_zone73f23b20",
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetRealm(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RealmsServiceClient client = new RealmsServiceClientImpl(mockGrpcClient.Object, null);
            Realm response = client.GetRealm(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRealmRequestObjectAsync()
        {
            moq::Mock<RealmsService.RealmsServiceClient> mockGrpcClient = new moq::Mock<RealmsService.RealmsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRealmRequest request = new GetRealmRequest
            {
                RealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
            };
            Realm expectedResponse = new Realm
            {
                RealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                TimeZone = "time_zone73f23b20",
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetRealmAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Realm>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RealmsServiceClient client = new RealmsServiceClientImpl(mockGrpcClient.Object, null);
            Realm responseCallSettings = await client.GetRealmAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Realm responseCancellationToken = await client.GetRealmAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRealm()
        {
            moq::Mock<RealmsService.RealmsServiceClient> mockGrpcClient = new moq::Mock<RealmsService.RealmsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRealmRequest request = new GetRealmRequest
            {
                RealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
            };
            Realm expectedResponse = new Realm
            {
                RealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                TimeZone = "time_zone73f23b20",
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetRealm(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RealmsServiceClient client = new RealmsServiceClientImpl(mockGrpcClient.Object, null);
            Realm response = client.GetRealm(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRealmAsync()
        {
            moq::Mock<RealmsService.RealmsServiceClient> mockGrpcClient = new moq::Mock<RealmsService.RealmsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRealmRequest request = new GetRealmRequest
            {
                RealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
            };
            Realm expectedResponse = new Realm
            {
                RealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                TimeZone = "time_zone73f23b20",
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetRealmAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Realm>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RealmsServiceClient client = new RealmsServiceClientImpl(mockGrpcClient.Object, null);
            Realm responseCallSettings = await client.GetRealmAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Realm responseCancellationToken = await client.GetRealmAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRealmResourceNames()
        {
            moq::Mock<RealmsService.RealmsServiceClient> mockGrpcClient = new moq::Mock<RealmsService.RealmsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRealmRequest request = new GetRealmRequest
            {
                RealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
            };
            Realm expectedResponse = new Realm
            {
                RealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                TimeZone = "time_zone73f23b20",
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetRealm(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RealmsServiceClient client = new RealmsServiceClientImpl(mockGrpcClient.Object, null);
            Realm response = client.GetRealm(request.RealmName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRealmResourceNamesAsync()
        {
            moq::Mock<RealmsService.RealmsServiceClient> mockGrpcClient = new moq::Mock<RealmsService.RealmsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRealmRequest request = new GetRealmRequest
            {
                RealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
            };
            Realm expectedResponse = new Realm
            {
                RealmName = RealmName.FromProjectLocationRealm("[PROJECT]", "[LOCATION]", "[REALM]"),
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                TimeZone = "time_zone73f23b20",
                Etag = "etage8ad7218",
                Description = "description2cf9da67",
            };
            mockGrpcClient.Setup(x => x.GetRealmAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Realm>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RealmsServiceClient client = new RealmsServiceClientImpl(mockGrpcClient.Object, null);
            Realm responseCallSettings = await client.GetRealmAsync(request.RealmName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Realm responseCancellationToken = await client.GetRealmAsync(request.RealmName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void PreviewRealmUpdateRequestObject()
        {
            moq::Mock<RealmsService.RealmsServiceClient> mockGrpcClient = new moq::Mock<RealmsService.RealmsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PreviewRealmUpdateRequest request = new PreviewRealmUpdateRequest
            {
                Realm = new Realm(),
                UpdateMask = new wkt::FieldMask(),
                PreviewTime = new wkt::Timestamp(),
            };
            PreviewRealmUpdateResponse expectedResponse = new PreviewRealmUpdateResponse
            {
                Etag = "etage8ad7218",
                TargetState = new TargetState(),
            };
            mockGrpcClient.Setup(x => x.PreviewRealmUpdate(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RealmsServiceClient client = new RealmsServiceClientImpl(mockGrpcClient.Object, null);
            PreviewRealmUpdateResponse response = client.PreviewRealmUpdate(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task PreviewRealmUpdateRequestObjectAsync()
        {
            moq::Mock<RealmsService.RealmsServiceClient> mockGrpcClient = new moq::Mock<RealmsService.RealmsServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            PreviewRealmUpdateRequest request = new PreviewRealmUpdateRequest
            {
                Realm = new Realm(),
                UpdateMask = new wkt::FieldMask(),
                PreviewTime = new wkt::Timestamp(),
            };
            PreviewRealmUpdateResponse expectedResponse = new PreviewRealmUpdateResponse
            {
                Etag = "etage8ad7218",
                TargetState = new TargetState(),
            };
            mockGrpcClient.Setup(x => x.PreviewRealmUpdateAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PreviewRealmUpdateResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RealmsServiceClient client = new RealmsServiceClientImpl(mockGrpcClient.Object, null);
            PreviewRealmUpdateResponse responseCallSettings = await client.PreviewRealmUpdateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PreviewRealmUpdateResponse responseCancellationToken = await client.PreviewRealmUpdateAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
