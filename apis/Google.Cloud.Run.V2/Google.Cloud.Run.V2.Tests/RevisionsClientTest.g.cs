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

using ga = Google.Api;
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Run.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRevisionsClientTest
    {
        [xunit::FactAttribute]
        public void GetRevisionRequestObject()
        {
            moq::Mock<Revisions.RevisionsClient> mockGrpcClient = new moq::Mock<Revisions.RevisionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRevisionRequest request = new GetRevisionRequest
            {
                RevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
            };
            Revision expectedResponse = new Revision
            {
                RevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                Uid = "uida2d37198",
                Generation = -8788800127544411748L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                LaunchStage = ga::LaunchStage.Unspecified,
                ServiceAsServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                Scaling = new RevisionScaling(),
                VpcAccess = new VpcAccess(),
                ContainerConcurrency = -1256870318,
                Timeout = new wkt::Duration(),
                ServiceAccount = "service_accounta3c1b923",
                Containers = { new Container(), },
                Volumes = { new Volume(), },
                Confidential = true,
                ExecutionEnvironment = ExecutionEnvironment.Unspecified,
                EncryptionKeyAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Reconciling = false,
                Conditions = { new Condition(), },
                ObservedGeneration = -4521268473882310455L,
                LogUri = "log_urid89ae442",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetRevision(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RevisionsClient client = new RevisionsClientImpl(mockGrpcClient.Object, null, null);
            Revision response = client.GetRevision(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRevisionRequestObjectAsync()
        {
            moq::Mock<Revisions.RevisionsClient> mockGrpcClient = new moq::Mock<Revisions.RevisionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRevisionRequest request = new GetRevisionRequest
            {
                RevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
            };
            Revision expectedResponse = new Revision
            {
                RevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                Uid = "uida2d37198",
                Generation = -8788800127544411748L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                LaunchStage = ga::LaunchStage.Unspecified,
                ServiceAsServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                Scaling = new RevisionScaling(),
                VpcAccess = new VpcAccess(),
                ContainerConcurrency = -1256870318,
                Timeout = new wkt::Duration(),
                ServiceAccount = "service_accounta3c1b923",
                Containers = { new Container(), },
                Volumes = { new Volume(), },
                Confidential = true,
                ExecutionEnvironment = ExecutionEnvironment.Unspecified,
                EncryptionKeyAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Reconciling = false,
                Conditions = { new Condition(), },
                ObservedGeneration = -4521268473882310455L,
                LogUri = "log_urid89ae442",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetRevisionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Revision>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RevisionsClient client = new RevisionsClientImpl(mockGrpcClient.Object, null, null);
            Revision responseCallSettings = await client.GetRevisionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Revision responseCancellationToken = await client.GetRevisionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRevision()
        {
            moq::Mock<Revisions.RevisionsClient> mockGrpcClient = new moq::Mock<Revisions.RevisionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRevisionRequest request = new GetRevisionRequest
            {
                RevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
            };
            Revision expectedResponse = new Revision
            {
                RevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                Uid = "uida2d37198",
                Generation = -8788800127544411748L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                LaunchStage = ga::LaunchStage.Unspecified,
                ServiceAsServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                Scaling = new RevisionScaling(),
                VpcAccess = new VpcAccess(),
                ContainerConcurrency = -1256870318,
                Timeout = new wkt::Duration(),
                ServiceAccount = "service_accounta3c1b923",
                Containers = { new Container(), },
                Volumes = { new Volume(), },
                Confidential = true,
                ExecutionEnvironment = ExecutionEnvironment.Unspecified,
                EncryptionKeyAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Reconciling = false,
                Conditions = { new Condition(), },
                ObservedGeneration = -4521268473882310455L,
                LogUri = "log_urid89ae442",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetRevision(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RevisionsClient client = new RevisionsClientImpl(mockGrpcClient.Object, null, null);
            Revision response = client.GetRevision(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRevisionAsync()
        {
            moq::Mock<Revisions.RevisionsClient> mockGrpcClient = new moq::Mock<Revisions.RevisionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRevisionRequest request = new GetRevisionRequest
            {
                RevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
            };
            Revision expectedResponse = new Revision
            {
                RevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                Uid = "uida2d37198",
                Generation = -8788800127544411748L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                LaunchStage = ga::LaunchStage.Unspecified,
                ServiceAsServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                Scaling = new RevisionScaling(),
                VpcAccess = new VpcAccess(),
                ContainerConcurrency = -1256870318,
                Timeout = new wkt::Duration(),
                ServiceAccount = "service_accounta3c1b923",
                Containers = { new Container(), },
                Volumes = { new Volume(), },
                Confidential = true,
                ExecutionEnvironment = ExecutionEnvironment.Unspecified,
                EncryptionKeyAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Reconciling = false,
                Conditions = { new Condition(), },
                ObservedGeneration = -4521268473882310455L,
                LogUri = "log_urid89ae442",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetRevisionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Revision>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RevisionsClient client = new RevisionsClientImpl(mockGrpcClient.Object, null, null);
            Revision responseCallSettings = await client.GetRevisionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Revision responseCancellationToken = await client.GetRevisionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRevisionResourceNames()
        {
            moq::Mock<Revisions.RevisionsClient> mockGrpcClient = new moq::Mock<Revisions.RevisionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRevisionRequest request = new GetRevisionRequest
            {
                RevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
            };
            Revision expectedResponse = new Revision
            {
                RevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                Uid = "uida2d37198",
                Generation = -8788800127544411748L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                LaunchStage = ga::LaunchStage.Unspecified,
                ServiceAsServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                Scaling = new RevisionScaling(),
                VpcAccess = new VpcAccess(),
                ContainerConcurrency = -1256870318,
                Timeout = new wkt::Duration(),
                ServiceAccount = "service_accounta3c1b923",
                Containers = { new Container(), },
                Volumes = { new Volume(), },
                Confidential = true,
                ExecutionEnvironment = ExecutionEnvironment.Unspecified,
                EncryptionKeyAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Reconciling = false,
                Conditions = { new Condition(), },
                ObservedGeneration = -4521268473882310455L,
                LogUri = "log_urid89ae442",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetRevision(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RevisionsClient client = new RevisionsClientImpl(mockGrpcClient.Object, null, null);
            Revision response = client.GetRevision(request.RevisionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRevisionResourceNamesAsync()
        {
            moq::Mock<Revisions.RevisionsClient> mockGrpcClient = new moq::Mock<Revisions.RevisionsClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetRevisionRequest request = new GetRevisionRequest
            {
                RevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
            };
            Revision expectedResponse = new Revision
            {
                RevisionName = RevisionName.FromProjectLocationServiceRevision("[PROJECT]", "[LOCATION]", "[SERVICE]", "[REVISION]"),
                Uid = "uida2d37198",
                Generation = -8788800127544411748L,
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                LaunchStage = ga::LaunchStage.Unspecified,
                ServiceAsServiceName = ServiceName.FromProjectLocationService("[PROJECT]", "[LOCATION]", "[SERVICE]"),
                Scaling = new RevisionScaling(),
                VpcAccess = new VpcAccess(),
                ContainerConcurrency = -1256870318,
                Timeout = new wkt::Duration(),
                ServiceAccount = "service_accounta3c1b923",
                Containers = { new Container(), },
                Volumes = { new Volume(), },
                Confidential = true,
                ExecutionEnvironment = ExecutionEnvironment.Unspecified,
                EncryptionKeyAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Reconciling = false,
                Conditions = { new Condition(), },
                ObservedGeneration = -4521268473882310455L,
                LogUri = "log_urid89ae442",
                Etag = "etage8ad7218",
            };
            mockGrpcClient.Setup(x => x.GetRevisionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Revision>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RevisionsClient client = new RevisionsClientImpl(mockGrpcClient.Object, null, null);
            Revision responseCallSettings = await client.GetRevisionAsync(request.RevisionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Revision responseCancellationToken = await client.GetRevisionAsync(request.RevisionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
