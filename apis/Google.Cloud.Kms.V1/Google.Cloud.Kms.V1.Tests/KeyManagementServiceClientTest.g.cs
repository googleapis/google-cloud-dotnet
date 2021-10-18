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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Kms.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedKeyManagementServiceClientTest
    {
        [xunit::FactAttribute]
        public void GetKeyRingRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetKeyRingRequest request = new GetKeyRingRequest
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetKeyRing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRing response = client.GetKeyRing(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetKeyRingRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetKeyRingRequest request = new GetKeyRingRequest
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetKeyRingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<KeyRing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRing responseCallSettings = await client.GetKeyRingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            KeyRing responseCancellationToken = await client.GetKeyRingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetKeyRing()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetKeyRingRequest request = new GetKeyRingRequest
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetKeyRing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRing response = client.GetKeyRing(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetKeyRingAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetKeyRingRequest request = new GetKeyRingRequest
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetKeyRingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<KeyRing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRing responseCallSettings = await client.GetKeyRingAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            KeyRing responseCancellationToken = await client.GetKeyRingAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetKeyRingResourceNames()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetKeyRingRequest request = new GetKeyRingRequest
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetKeyRing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRing response = client.GetKeyRing(request.KeyRingName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetKeyRingResourceNamesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetKeyRingRequest request = new GetKeyRingRequest
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetKeyRingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<KeyRing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRing responseCallSettings = await client.GetKeyRingAsync(request.KeyRingName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            KeyRing responseCancellationToken = await client.GetKeyRingAsync(request.KeyRingName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCryptoKeyRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetCryptoKeyRequest request = new GetCryptoKeyRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetCryptoKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = client.GetCryptoKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCryptoKeyRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetCryptoKeyRequest request = new GetCryptoKeyRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetCryptoKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey responseCallSettings = await client.GetCryptoKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKey responseCancellationToken = await client.GetCryptoKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCryptoKey()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetCryptoKeyRequest request = new GetCryptoKeyRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetCryptoKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = client.GetCryptoKey(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCryptoKeyAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetCryptoKeyRequest request = new GetCryptoKeyRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetCryptoKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey responseCallSettings = await client.GetCryptoKeyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKey responseCancellationToken = await client.GetCryptoKeyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCryptoKeyResourceNames()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetCryptoKeyRequest request = new GetCryptoKeyRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetCryptoKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = client.GetCryptoKey(request.CryptoKeyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCryptoKeyResourceNamesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetCryptoKeyRequest request = new GetCryptoKeyRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.GetCryptoKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey responseCallSettings = await client.GetCryptoKeyAsync(request.CryptoKeyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKey responseCancellationToken = await client.GetCryptoKeyAsync(request.CryptoKeyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCryptoKeyVersionRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetCryptoKeyVersionRequest request = new GetCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.GetCryptoKeyVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.GetCryptoKeyVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCryptoKeyVersionRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetCryptoKeyVersionRequest request = new GetCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.GetCryptoKeyVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKeyVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion responseCallSettings = await client.GetCryptoKeyVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKeyVersion responseCancellationToken = await client.GetCryptoKeyVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCryptoKeyVersion()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetCryptoKeyVersionRequest request = new GetCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.GetCryptoKeyVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.GetCryptoKeyVersion(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCryptoKeyVersionAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetCryptoKeyVersionRequest request = new GetCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.GetCryptoKeyVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKeyVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion responseCallSettings = await client.GetCryptoKeyVersionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKeyVersion responseCancellationToken = await client.GetCryptoKeyVersionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetCryptoKeyVersionResourceNames()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetCryptoKeyVersionRequest request = new GetCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.GetCryptoKeyVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.GetCryptoKeyVersion(request.CryptoKeyVersionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetCryptoKeyVersionResourceNamesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetCryptoKeyVersionRequest request = new GetCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.GetCryptoKeyVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKeyVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion responseCallSettings = await client.GetCryptoKeyVersionAsync(request.CryptoKeyVersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKeyVersion responseCancellationToken = await client.GetCryptoKeyVersionAsync(request.CryptoKeyVersionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPublicKeyRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetPublicKeyRequest request = new GetPublicKeyRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            PublicKey expectedResponse = new PublicKey
            {
                Pem = "pemd6ff2189",
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                PemCrc32C = 7888183666447720391L,
                PublicKeyName = PublicKeyName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.GetPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            PublicKey response = client.GetPublicKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPublicKeyRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetPublicKeyRequest request = new GetPublicKeyRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            PublicKey expectedResponse = new PublicKey
            {
                Pem = "pemd6ff2189",
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                PemCrc32C = 7888183666447720391L,
                PublicKeyName = PublicKeyName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.GetPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PublicKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            PublicKey responseCallSettings = await client.GetPublicKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PublicKey responseCancellationToken = await client.GetPublicKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPublicKey()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetPublicKeyRequest request = new GetPublicKeyRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            PublicKey expectedResponse = new PublicKey
            {
                Pem = "pemd6ff2189",
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                PemCrc32C = 7888183666447720391L,
                PublicKeyName = PublicKeyName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.GetPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            PublicKey response = client.GetPublicKey(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPublicKeyAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetPublicKeyRequest request = new GetPublicKeyRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            PublicKey expectedResponse = new PublicKey
            {
                Pem = "pemd6ff2189",
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                PemCrc32C = 7888183666447720391L,
                PublicKeyName = PublicKeyName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.GetPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PublicKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            PublicKey responseCallSettings = await client.GetPublicKeyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PublicKey responseCancellationToken = await client.GetPublicKeyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPublicKeyResourceNames()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetPublicKeyRequest request = new GetPublicKeyRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            PublicKey expectedResponse = new PublicKey
            {
                Pem = "pemd6ff2189",
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                PemCrc32C = 7888183666447720391L,
                PublicKeyName = PublicKeyName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.GetPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            PublicKey response = client.GetPublicKey(request.CryptoKeyVersionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPublicKeyResourceNamesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetPublicKeyRequest request = new GetPublicKeyRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            PublicKey expectedResponse = new PublicKey
            {
                Pem = "pemd6ff2189",
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                PemCrc32C = 7888183666447720391L,
                PublicKeyName = PublicKeyName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.GetPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PublicKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            PublicKey responseCallSettings = await client.GetPublicKeyAsync(request.CryptoKeyVersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PublicKey responseCancellationToken = await client.GetPublicKeyAsync(request.CryptoKeyVersionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetImportJobRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetImportJobRequest request = new GetImportJobRequest
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
            };
            ImportJob expectedResponse = new ImportJob
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
                ImportMethod = ImportJob.Types.ImportMethod.Unspecified,
                CreateTime = new wkt::Timestamp(),
                GenerateTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                State = ImportJob.Types.ImportJobState.Active,
                PublicKey = new ImportJob.Types.WrappingPublicKey(),
                Attestation = new KeyOperationAttestation(),
                ProtectionLevel = ProtectionLevel.Hsm,
                ExpireEventTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetImportJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            ImportJob response = client.GetImportJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetImportJobRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetImportJobRequest request = new GetImportJobRequest
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
            };
            ImportJob expectedResponse = new ImportJob
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
                ImportMethod = ImportJob.Types.ImportMethod.Unspecified,
                CreateTime = new wkt::Timestamp(),
                GenerateTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                State = ImportJob.Types.ImportJobState.Active,
                PublicKey = new ImportJob.Types.WrappingPublicKey(),
                Attestation = new KeyOperationAttestation(),
                ProtectionLevel = ProtectionLevel.Hsm,
                ExpireEventTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetImportJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ImportJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            ImportJob responseCallSettings = await client.GetImportJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ImportJob responseCancellationToken = await client.GetImportJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetImportJob()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetImportJobRequest request = new GetImportJobRequest
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
            };
            ImportJob expectedResponse = new ImportJob
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
                ImportMethod = ImportJob.Types.ImportMethod.Unspecified,
                CreateTime = new wkt::Timestamp(),
                GenerateTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                State = ImportJob.Types.ImportJobState.Active,
                PublicKey = new ImportJob.Types.WrappingPublicKey(),
                Attestation = new KeyOperationAttestation(),
                ProtectionLevel = ProtectionLevel.Hsm,
                ExpireEventTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetImportJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            ImportJob response = client.GetImportJob(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetImportJobAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetImportJobRequest request = new GetImportJobRequest
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
            };
            ImportJob expectedResponse = new ImportJob
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
                ImportMethod = ImportJob.Types.ImportMethod.Unspecified,
                CreateTime = new wkt::Timestamp(),
                GenerateTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                State = ImportJob.Types.ImportJobState.Active,
                PublicKey = new ImportJob.Types.WrappingPublicKey(),
                Attestation = new KeyOperationAttestation(),
                ProtectionLevel = ProtectionLevel.Hsm,
                ExpireEventTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetImportJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ImportJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            ImportJob responseCallSettings = await client.GetImportJobAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ImportJob responseCancellationToken = await client.GetImportJobAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetImportJobResourceNames()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetImportJobRequest request = new GetImportJobRequest
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
            };
            ImportJob expectedResponse = new ImportJob
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
                ImportMethod = ImportJob.Types.ImportMethod.Unspecified,
                CreateTime = new wkt::Timestamp(),
                GenerateTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                State = ImportJob.Types.ImportJobState.Active,
                PublicKey = new ImportJob.Types.WrappingPublicKey(),
                Attestation = new KeyOperationAttestation(),
                ProtectionLevel = ProtectionLevel.Hsm,
                ExpireEventTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetImportJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            ImportJob response = client.GetImportJob(request.ImportJobName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetImportJobResourceNamesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GetImportJobRequest request = new GetImportJobRequest
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
            };
            ImportJob expectedResponse = new ImportJob
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
                ImportMethod = ImportJob.Types.ImportMethod.Unspecified,
                CreateTime = new wkt::Timestamp(),
                GenerateTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                State = ImportJob.Types.ImportJobState.Active,
                PublicKey = new ImportJob.Types.WrappingPublicKey(),
                Attestation = new KeyOperationAttestation(),
                ProtectionLevel = ProtectionLevel.Hsm,
                ExpireEventTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GetImportJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ImportJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            ImportJob responseCallSettings = await client.GetImportJobAsync(request.ImportJobName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ImportJob responseCancellationToken = await client.GetImportJobAsync(request.ImportJobName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateKeyRingRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateKeyRingRequest request = new CreateKeyRingRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KeyRingId = "key_ring_id56c9cb14",
                KeyRing = new KeyRing(),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateKeyRing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRing response = client.CreateKeyRing(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateKeyRingRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateKeyRingRequest request = new CreateKeyRingRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KeyRingId = "key_ring_id56c9cb14",
                KeyRing = new KeyRing(),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateKeyRingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<KeyRing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRing responseCallSettings = await client.CreateKeyRingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            KeyRing responseCancellationToken = await client.CreateKeyRingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateKeyRing()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateKeyRingRequest request = new CreateKeyRingRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KeyRingId = "key_ring_id56c9cb14",
                KeyRing = new KeyRing(),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateKeyRing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRing response = client.CreateKeyRing(request.Parent, request.KeyRingId, request.KeyRing);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateKeyRingAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateKeyRingRequest request = new CreateKeyRingRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KeyRingId = "key_ring_id56c9cb14",
                KeyRing = new KeyRing(),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateKeyRingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<KeyRing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRing responseCallSettings = await client.CreateKeyRingAsync(request.Parent, request.KeyRingId, request.KeyRing, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            KeyRing responseCancellationToken = await client.CreateKeyRingAsync(request.Parent, request.KeyRingId, request.KeyRing, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateKeyRingResourceNames()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateKeyRingRequest request = new CreateKeyRingRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KeyRingId = "key_ring_id56c9cb14",
                KeyRing = new KeyRing(),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateKeyRing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRing response = client.CreateKeyRing(request.ParentAsLocationName, request.KeyRingId, request.KeyRing);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateKeyRingResourceNamesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateKeyRingRequest request = new CreateKeyRingRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                KeyRingId = "key_ring_id56c9cb14",
                KeyRing = new KeyRing(),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CreateTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateKeyRingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<KeyRing>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRing responseCallSettings = await client.CreateKeyRingAsync(request.ParentAsLocationName, request.KeyRingId, request.KeyRing, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            KeyRing responseCancellationToken = await client.CreateKeyRingAsync(request.ParentAsLocationName, request.KeyRingId, request.KeyRing, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCryptoKeyRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateCryptoKeyRequest request = new CreateCryptoKeyRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CryptoKeyId = "crypto_key_ida49f0bf3",
                CryptoKey = new CryptoKey(),
                SkipInitialVersionCreation = true,
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = client.CreateCryptoKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCryptoKeyRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateCryptoKeyRequest request = new CreateCryptoKeyRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CryptoKeyId = "crypto_key_ida49f0bf3",
                CryptoKey = new CryptoKey(),
                SkipInitialVersionCreation = true,
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey responseCallSettings = await client.CreateCryptoKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKey responseCancellationToken = await client.CreateCryptoKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCryptoKey()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateCryptoKeyRequest request = new CreateCryptoKeyRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CryptoKeyId = "crypto_key_ida49f0bf3",
                CryptoKey = new CryptoKey(),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = client.CreateCryptoKey(request.Parent, request.CryptoKeyId, request.CryptoKey);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCryptoKeyAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateCryptoKeyRequest request = new CreateCryptoKeyRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CryptoKeyId = "crypto_key_ida49f0bf3",
                CryptoKey = new CryptoKey(),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey responseCallSettings = await client.CreateCryptoKeyAsync(request.Parent, request.CryptoKeyId, request.CryptoKey, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKey responseCancellationToken = await client.CreateCryptoKeyAsync(request.Parent, request.CryptoKeyId, request.CryptoKey, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCryptoKeyResourceNames()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateCryptoKeyRequest request = new CreateCryptoKeyRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CryptoKeyId = "crypto_key_ida49f0bf3",
                CryptoKey = new CryptoKey(),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = client.CreateCryptoKey(request.ParentAsKeyRingName, request.CryptoKeyId, request.CryptoKey);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCryptoKeyResourceNamesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateCryptoKeyRequest request = new CreateCryptoKeyRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CryptoKeyId = "crypto_key_ida49f0bf3",
                CryptoKey = new CryptoKey(),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey responseCallSettings = await client.CreateCryptoKeyAsync(request.ParentAsKeyRingName, request.CryptoKeyId, request.CryptoKey, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKey responseCancellationToken = await client.CreateCryptoKeyAsync(request.ParentAsKeyRingName, request.CryptoKeyId, request.CryptoKey, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCryptoKeyVersionRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateCryptoKeyVersionRequest request = new CreateCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersion = new CryptoKeyVersion(),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKeyVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.CreateCryptoKeyVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCryptoKeyVersionRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateCryptoKeyVersionRequest request = new CreateCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersion = new CryptoKeyVersion(),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKeyVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKeyVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion responseCallSettings = await client.CreateCryptoKeyVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKeyVersion responseCancellationToken = await client.CreateCryptoKeyVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCryptoKeyVersion()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateCryptoKeyVersionRequest request = new CreateCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersion = new CryptoKeyVersion(),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKeyVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.CreateCryptoKeyVersion(request.Parent, request.CryptoKeyVersion);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCryptoKeyVersionAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateCryptoKeyVersionRequest request = new CreateCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersion = new CryptoKeyVersion(),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKeyVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKeyVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion responseCallSettings = await client.CreateCryptoKeyVersionAsync(request.Parent, request.CryptoKeyVersion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKeyVersion responseCancellationToken = await client.CreateCryptoKeyVersionAsync(request.Parent, request.CryptoKeyVersion, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateCryptoKeyVersionResourceNames()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateCryptoKeyVersionRequest request = new CreateCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersion = new CryptoKeyVersion(),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKeyVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.CreateCryptoKeyVersion(request.ParentAsCryptoKeyName, request.CryptoKeyVersion);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateCryptoKeyVersionResourceNamesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateCryptoKeyVersionRequest request = new CreateCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersion = new CryptoKeyVersion(),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKeyVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKeyVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion responseCallSettings = await client.CreateCryptoKeyVersionAsync(request.ParentAsCryptoKeyName, request.CryptoKeyVersion, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKeyVersion responseCancellationToken = await client.CreateCryptoKeyVersionAsync(request.ParentAsCryptoKeyName, request.CryptoKeyVersion, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ImportCryptoKeyVersionRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            ImportCryptoKeyVersionRequest request = new ImportCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                ImportJob = "import_job02c374ab",
                RsaAesWrappedKey = proto::ByteString.CopyFromUtf8("rsa_aes_wrapped_keyeffad66d"),
                CryptoKeyVersionAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.ImportCryptoKeyVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.ImportCryptoKeyVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ImportCryptoKeyVersionRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            ImportCryptoKeyVersionRequest request = new ImportCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                ImportJob = "import_job02c374ab",
                RsaAesWrappedKey = proto::ByteString.CopyFromUtf8("rsa_aes_wrapped_keyeffad66d"),
                CryptoKeyVersionAsCryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.ImportCryptoKeyVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKeyVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion responseCallSettings = await client.ImportCryptoKeyVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKeyVersion responseCancellationToken = await client.ImportCryptoKeyVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateImportJobRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateImportJobRequest request = new CreateImportJobRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                ImportJobId = "import_job_idc41664a1",
                ImportJob = new ImportJob(),
            };
            ImportJob expectedResponse = new ImportJob
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
                ImportMethod = ImportJob.Types.ImportMethod.Unspecified,
                CreateTime = new wkt::Timestamp(),
                GenerateTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                State = ImportJob.Types.ImportJobState.Active,
                PublicKey = new ImportJob.Types.WrappingPublicKey(),
                Attestation = new KeyOperationAttestation(),
                ProtectionLevel = ProtectionLevel.Hsm,
                ExpireEventTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateImportJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            ImportJob response = client.CreateImportJob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateImportJobRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateImportJobRequest request = new CreateImportJobRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                ImportJobId = "import_job_idc41664a1",
                ImportJob = new ImportJob(),
            };
            ImportJob expectedResponse = new ImportJob
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
                ImportMethod = ImportJob.Types.ImportMethod.Unspecified,
                CreateTime = new wkt::Timestamp(),
                GenerateTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                State = ImportJob.Types.ImportJobState.Active,
                PublicKey = new ImportJob.Types.WrappingPublicKey(),
                Attestation = new KeyOperationAttestation(),
                ProtectionLevel = ProtectionLevel.Hsm,
                ExpireEventTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateImportJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ImportJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            ImportJob responseCallSettings = await client.CreateImportJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ImportJob responseCancellationToken = await client.CreateImportJobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateImportJob()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateImportJobRequest request = new CreateImportJobRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                ImportJobId = "import_job_idc41664a1",
                ImportJob = new ImportJob(),
            };
            ImportJob expectedResponse = new ImportJob
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
                ImportMethod = ImportJob.Types.ImportMethod.Unspecified,
                CreateTime = new wkt::Timestamp(),
                GenerateTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                State = ImportJob.Types.ImportJobState.Active,
                PublicKey = new ImportJob.Types.WrappingPublicKey(),
                Attestation = new KeyOperationAttestation(),
                ProtectionLevel = ProtectionLevel.Hsm,
                ExpireEventTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateImportJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            ImportJob response = client.CreateImportJob(request.Parent, request.ImportJobId, request.ImportJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateImportJobAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateImportJobRequest request = new CreateImportJobRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                ImportJobId = "import_job_idc41664a1",
                ImportJob = new ImportJob(),
            };
            ImportJob expectedResponse = new ImportJob
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
                ImportMethod = ImportJob.Types.ImportMethod.Unspecified,
                CreateTime = new wkt::Timestamp(),
                GenerateTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                State = ImportJob.Types.ImportJobState.Active,
                PublicKey = new ImportJob.Types.WrappingPublicKey(),
                Attestation = new KeyOperationAttestation(),
                ProtectionLevel = ProtectionLevel.Hsm,
                ExpireEventTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateImportJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ImportJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            ImportJob responseCallSettings = await client.CreateImportJobAsync(request.Parent, request.ImportJobId, request.ImportJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ImportJob responseCancellationToken = await client.CreateImportJobAsync(request.Parent, request.ImportJobId, request.ImportJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateImportJobResourceNames()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateImportJobRequest request = new CreateImportJobRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                ImportJobId = "import_job_idc41664a1",
                ImportJob = new ImportJob(),
            };
            ImportJob expectedResponse = new ImportJob
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
                ImportMethod = ImportJob.Types.ImportMethod.Unspecified,
                CreateTime = new wkt::Timestamp(),
                GenerateTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                State = ImportJob.Types.ImportJobState.Active,
                PublicKey = new ImportJob.Types.WrappingPublicKey(),
                Attestation = new KeyOperationAttestation(),
                ProtectionLevel = ProtectionLevel.Hsm,
                ExpireEventTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateImportJob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            ImportJob response = client.CreateImportJob(request.ParentAsKeyRingName, request.ImportJobId, request.ImportJob);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateImportJobResourceNamesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            CreateImportJobRequest request = new CreateImportJobRequest
            {
                ParentAsKeyRingName = KeyRingName.FromProjectLocationKeyRing("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                ImportJobId = "import_job_idc41664a1",
                ImportJob = new ImportJob(),
            };
            ImportJob expectedResponse = new ImportJob
            {
                ImportJobName = ImportJobName.FromProjectLocationKeyRingImportJob("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
                ImportMethod = ImportJob.Types.ImportMethod.Unspecified,
                CreateTime = new wkt::Timestamp(),
                GenerateTime = new wkt::Timestamp(),
                ExpireTime = new wkt::Timestamp(),
                State = ImportJob.Types.ImportJobState.Active,
                PublicKey = new ImportJob.Types.WrappingPublicKey(),
                Attestation = new KeyOperationAttestation(),
                ProtectionLevel = ProtectionLevel.Hsm,
                ExpireEventTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.CreateImportJobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ImportJob>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            ImportJob responseCallSettings = await client.CreateImportJobAsync(request.ParentAsKeyRingName, request.ImportJobId, request.ImportJob, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ImportJob responseCancellationToken = await client.CreateImportJobAsync(request.ParentAsKeyRingName, request.ImportJobId, request.ImportJob, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCryptoKeyRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            UpdateCryptoKeyRequest request = new UpdateCryptoKeyRequest
            {
                CryptoKey = new CryptoKey(),
                UpdateMask = new wkt::FieldMask(),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = client.UpdateCryptoKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCryptoKeyRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            UpdateCryptoKeyRequest request = new UpdateCryptoKeyRequest
            {
                CryptoKey = new CryptoKey(),
                UpdateMask = new wkt::FieldMask(),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey responseCallSettings = await client.UpdateCryptoKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKey responseCancellationToken = await client.UpdateCryptoKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCryptoKey()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            UpdateCryptoKeyRequest request = new UpdateCryptoKeyRequest
            {
                CryptoKey = new CryptoKey(),
                UpdateMask = new wkt::FieldMask(),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = client.UpdateCryptoKey(request.CryptoKey, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCryptoKeyAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            UpdateCryptoKeyRequest request = new UpdateCryptoKeyRequest
            {
                CryptoKey = new CryptoKey(),
                UpdateMask = new wkt::FieldMask(),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey responseCallSettings = await client.UpdateCryptoKeyAsync(request.CryptoKey, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKey responseCancellationToken = await client.UpdateCryptoKeyAsync(request.CryptoKey, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCryptoKeyVersionRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            UpdateCryptoKeyVersionRequest request = new UpdateCryptoKeyVersionRequest
            {
                CryptoKeyVersion = new CryptoKeyVersion(),
                UpdateMask = new wkt::FieldMask(),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.UpdateCryptoKeyVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCryptoKeyVersionRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            UpdateCryptoKeyVersionRequest request = new UpdateCryptoKeyVersionRequest
            {
                CryptoKeyVersion = new CryptoKeyVersion(),
                UpdateMask = new wkt::FieldMask(),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKeyVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion responseCallSettings = await client.UpdateCryptoKeyVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKeyVersion responseCancellationToken = await client.UpdateCryptoKeyVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCryptoKeyVersion()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            UpdateCryptoKeyVersionRequest request = new UpdateCryptoKeyVersionRequest
            {
                CryptoKeyVersion = new CryptoKeyVersion(),
                UpdateMask = new wkt::FieldMask(),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.UpdateCryptoKeyVersion(request.CryptoKeyVersion, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCryptoKeyVersionAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            UpdateCryptoKeyVersionRequest request = new UpdateCryptoKeyVersionRequest
            {
                CryptoKeyVersion = new CryptoKeyVersion(),
                UpdateMask = new wkt::FieldMask(),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKeyVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion responseCallSettings = await client.UpdateCryptoKeyVersionAsync(request.CryptoKeyVersion, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKeyVersion responseCancellationToken = await client.UpdateCryptoKeyVersionAsync(request.CryptoKeyVersion, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCryptoKeyPrimaryVersionRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            UpdateCryptoKeyPrimaryVersionRequest request = new UpdateCryptoKeyPrimaryVersionRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersionId = "crypto_key_version_id469b0067",
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyPrimaryVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = client.UpdateCryptoKeyPrimaryVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCryptoKeyPrimaryVersionRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            UpdateCryptoKeyPrimaryVersionRequest request = new UpdateCryptoKeyPrimaryVersionRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersionId = "crypto_key_version_id469b0067",
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyPrimaryVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey responseCallSettings = await client.UpdateCryptoKeyPrimaryVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKey responseCancellationToken = await client.UpdateCryptoKeyPrimaryVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCryptoKeyPrimaryVersion()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            UpdateCryptoKeyPrimaryVersionRequest request = new UpdateCryptoKeyPrimaryVersionRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersionId = "crypto_key_version_id469b0067",
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyPrimaryVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = client.UpdateCryptoKeyPrimaryVersion(request.Name, request.CryptoKeyVersionId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCryptoKeyPrimaryVersionAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            UpdateCryptoKeyPrimaryVersionRequest request = new UpdateCryptoKeyPrimaryVersionRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersionId = "crypto_key_version_id469b0067",
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyPrimaryVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey responseCallSettings = await client.UpdateCryptoKeyPrimaryVersionAsync(request.Name, request.CryptoKeyVersionId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKey responseCancellationToken = await client.UpdateCryptoKeyPrimaryVersionAsync(request.Name, request.CryptoKeyVersionId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateCryptoKeyPrimaryVersionResourceNames()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            UpdateCryptoKeyPrimaryVersionRequest request = new UpdateCryptoKeyPrimaryVersionRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersionId = "crypto_key_version_id469b0067",
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyPrimaryVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = client.UpdateCryptoKeyPrimaryVersion(request.CryptoKeyName, request.CryptoKeyVersionId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateCryptoKeyPrimaryVersionResourceNamesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            UpdateCryptoKeyPrimaryVersionRequest request = new UpdateCryptoKeyPrimaryVersionRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersionId = "crypto_key_version_id469b0067",
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Primary = new CryptoKeyVersion(),
                Purpose = CryptoKey.Types.CryptoKeyPurpose.Mac,
                CreateTime = new wkt::Timestamp(),
                NextRotationTime = new wkt::Timestamp(),
                RotationPeriod = new wkt::Duration(),
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                VersionTemplate = new CryptoKeyVersionTemplate(),
                ImportOnly = false,
                DestroyScheduledDuration = new wkt::Duration(),
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyPrimaryVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey responseCallSettings = await client.UpdateCryptoKeyPrimaryVersionAsync(request.CryptoKeyName, request.CryptoKeyVersionId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKey responseCancellationToken = await client.UpdateCryptoKeyPrimaryVersionAsync(request.CryptoKeyName, request.CryptoKeyVersionId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DestroyCryptoKeyVersionRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            DestroyCryptoKeyVersionRequest request = new DestroyCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.DestroyCryptoKeyVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.DestroyCryptoKeyVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DestroyCryptoKeyVersionRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            DestroyCryptoKeyVersionRequest request = new DestroyCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.DestroyCryptoKeyVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKeyVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion responseCallSettings = await client.DestroyCryptoKeyVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKeyVersion responseCancellationToken = await client.DestroyCryptoKeyVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DestroyCryptoKeyVersion()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            DestroyCryptoKeyVersionRequest request = new DestroyCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.DestroyCryptoKeyVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.DestroyCryptoKeyVersion(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DestroyCryptoKeyVersionAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            DestroyCryptoKeyVersionRequest request = new DestroyCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.DestroyCryptoKeyVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKeyVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion responseCallSettings = await client.DestroyCryptoKeyVersionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKeyVersion responseCancellationToken = await client.DestroyCryptoKeyVersionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DestroyCryptoKeyVersionResourceNames()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            DestroyCryptoKeyVersionRequest request = new DestroyCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.DestroyCryptoKeyVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.DestroyCryptoKeyVersion(request.CryptoKeyVersionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DestroyCryptoKeyVersionResourceNamesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            DestroyCryptoKeyVersionRequest request = new DestroyCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.DestroyCryptoKeyVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKeyVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion responseCallSettings = await client.DestroyCryptoKeyVersionAsync(request.CryptoKeyVersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKeyVersion responseCancellationToken = await client.DestroyCryptoKeyVersionAsync(request.CryptoKeyVersionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RestoreCryptoKeyVersionRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            RestoreCryptoKeyVersionRequest request = new RestoreCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.RestoreCryptoKeyVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.RestoreCryptoKeyVersion(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RestoreCryptoKeyVersionRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            RestoreCryptoKeyVersionRequest request = new RestoreCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.RestoreCryptoKeyVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKeyVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion responseCallSettings = await client.RestoreCryptoKeyVersionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKeyVersion responseCancellationToken = await client.RestoreCryptoKeyVersionAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RestoreCryptoKeyVersion()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            RestoreCryptoKeyVersionRequest request = new RestoreCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.RestoreCryptoKeyVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.RestoreCryptoKeyVersion(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RestoreCryptoKeyVersionAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            RestoreCryptoKeyVersionRequest request = new RestoreCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.RestoreCryptoKeyVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKeyVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion responseCallSettings = await client.RestoreCryptoKeyVersionAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKeyVersion responseCancellationToken = await client.RestoreCryptoKeyVersionAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void RestoreCryptoKeyVersionResourceNames()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            RestoreCryptoKeyVersionRequest request = new RestoreCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.RestoreCryptoKeyVersion(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.RestoreCryptoKeyVersion(request.CryptoKeyVersionName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task RestoreCryptoKeyVersionResourceNamesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            RestoreCryptoKeyVersionRequest request = new RestoreCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                State = CryptoKeyVersion.Types.CryptoKeyVersionState.PendingImport,
                CreateTime = new wkt::Timestamp(),
                DestroyTime = new wkt::Timestamp(),
                DestroyEventTime = new wkt::Timestamp(),
                ProtectionLevel = ProtectionLevel.Hsm,
                Attestation = new KeyOperationAttestation(),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.RsaDecryptOaep4096Sha512,
                GenerateTime = new wkt::Timestamp(),
                ImportJob = "import_job02c374ab",
                ImportTime = new wkt::Timestamp(),
                ImportFailureReason = "import_failure_reason8924b287",
                ExternalProtectionLevelOptions = new ExternalProtectionLevelOptions(),
                ReimportEligible = false,
            };
            mockGrpcClient.Setup(x => x.RestoreCryptoKeyVersionAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<CryptoKeyVersion>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion responseCallSettings = await client.RestoreCryptoKeyVersionAsync(request.CryptoKeyVersionName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            CryptoKeyVersion responseCancellationToken = await client.RestoreCryptoKeyVersionAsync(request.CryptoKeyVersionName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void EncryptRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            EncryptRequest request = new EncryptRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Plaintext = proto::ByteString.CopyFromUtf8("plaintext1d5bbcf2"),
                AdditionalAuthenticatedData = proto::ByteString.CopyFromUtf8("additional_authenticated_data3a987f33"),
                PlaintextCrc32C = -5108784857370523788L,
                AdditionalAuthenticatedDataCrc32C = -8178775638889629022L,
            };
            EncryptResponse expectedResponse = new EncryptResponse
            {
                Name = "name1c9368b0",
                Ciphertext = proto::ByteString.CopyFromUtf8("ciphertext676154cb"),
                CiphertextCrc32C = 5835079685918568182L,
                VerifiedPlaintextCrc32C = false,
                VerifiedAdditionalAuthenticatedDataCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.Encrypt(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            EncryptResponse response = client.Encrypt(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task EncryptRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            EncryptRequest request = new EncryptRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Plaintext = proto::ByteString.CopyFromUtf8("plaintext1d5bbcf2"),
                AdditionalAuthenticatedData = proto::ByteString.CopyFromUtf8("additional_authenticated_data3a987f33"),
                PlaintextCrc32C = -5108784857370523788L,
                AdditionalAuthenticatedDataCrc32C = -8178775638889629022L,
            };
            EncryptResponse expectedResponse = new EncryptResponse
            {
                Name = "name1c9368b0",
                Ciphertext = proto::ByteString.CopyFromUtf8("ciphertext676154cb"),
                CiphertextCrc32C = 5835079685918568182L,
                VerifiedPlaintextCrc32C = false,
                VerifiedAdditionalAuthenticatedDataCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.EncryptAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EncryptResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            EncryptResponse responseCallSettings = await client.EncryptAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EncryptResponse responseCancellationToken = await client.EncryptAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Encrypt()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            EncryptRequest request = new EncryptRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Plaintext = proto::ByteString.CopyFromUtf8("plaintext1d5bbcf2"),
            };
            EncryptResponse expectedResponse = new EncryptResponse
            {
                Name = "name1c9368b0",
                Ciphertext = proto::ByteString.CopyFromUtf8("ciphertext676154cb"),
                CiphertextCrc32C = 5835079685918568182L,
                VerifiedPlaintextCrc32C = false,
                VerifiedAdditionalAuthenticatedDataCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.Encrypt(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            EncryptResponse response = client.Encrypt(request.Name, request.Plaintext);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task EncryptAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            EncryptRequest request = new EncryptRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Plaintext = proto::ByteString.CopyFromUtf8("plaintext1d5bbcf2"),
            };
            EncryptResponse expectedResponse = new EncryptResponse
            {
                Name = "name1c9368b0",
                Ciphertext = proto::ByteString.CopyFromUtf8("ciphertext676154cb"),
                CiphertextCrc32C = 5835079685918568182L,
                VerifiedPlaintextCrc32C = false,
                VerifiedAdditionalAuthenticatedDataCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.EncryptAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EncryptResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            EncryptResponse responseCallSettings = await client.EncryptAsync(request.Name, request.Plaintext, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EncryptResponse responseCancellationToken = await client.EncryptAsync(request.Name, request.Plaintext, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void EncryptResourceNames()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            EncryptRequest request = new EncryptRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Plaintext = proto::ByteString.CopyFromUtf8("plaintext1d5bbcf2"),
            };
            EncryptResponse expectedResponse = new EncryptResponse
            {
                Name = "name1c9368b0",
                Ciphertext = proto::ByteString.CopyFromUtf8("ciphertext676154cb"),
                CiphertextCrc32C = 5835079685918568182L,
                VerifiedPlaintextCrc32C = false,
                VerifiedAdditionalAuthenticatedDataCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.Encrypt(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            EncryptResponse response = client.Encrypt(request.ResourceName, request.Plaintext);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task EncryptResourceNamesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            EncryptRequest request = new EncryptRequest
            {
                ResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                Plaintext = proto::ByteString.CopyFromUtf8("plaintext1d5bbcf2"),
            };
            EncryptResponse expectedResponse = new EncryptResponse
            {
                Name = "name1c9368b0",
                Ciphertext = proto::ByteString.CopyFromUtf8("ciphertext676154cb"),
                CiphertextCrc32C = 5835079685918568182L,
                VerifiedPlaintextCrc32C = false,
                VerifiedAdditionalAuthenticatedDataCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.EncryptAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<EncryptResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            EncryptResponse responseCallSettings = await client.EncryptAsync(request.ResourceName, request.Plaintext, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            EncryptResponse responseCancellationToken = await client.EncryptAsync(request.ResourceName, request.Plaintext, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DecryptRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            DecryptRequest request = new DecryptRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Ciphertext = proto::ByteString.CopyFromUtf8("ciphertext676154cb"),
                AdditionalAuthenticatedData = proto::ByteString.CopyFromUtf8("additional_authenticated_data3a987f33"),
                CiphertextCrc32C = 5835079685918568182L,
                AdditionalAuthenticatedDataCrc32C = -8178775638889629022L,
            };
            DecryptResponse expectedResponse = new DecryptResponse
            {
                Plaintext = proto::ByteString.CopyFromUtf8("plaintext1d5bbcf2"),
                PlaintextCrc32C = -5108784857370523788L,
                UsedPrimary = false,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.Decrypt(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            DecryptResponse response = client.Decrypt(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DecryptRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            DecryptRequest request = new DecryptRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Ciphertext = proto::ByteString.CopyFromUtf8("ciphertext676154cb"),
                AdditionalAuthenticatedData = proto::ByteString.CopyFromUtf8("additional_authenticated_data3a987f33"),
                CiphertextCrc32C = 5835079685918568182L,
                AdditionalAuthenticatedDataCrc32C = -8178775638889629022L,
            };
            DecryptResponse expectedResponse = new DecryptResponse
            {
                Plaintext = proto::ByteString.CopyFromUtf8("plaintext1d5bbcf2"),
                PlaintextCrc32C = -5108784857370523788L,
                UsedPrimary = false,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.DecryptAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DecryptResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            DecryptResponse responseCallSettings = await client.DecryptAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DecryptResponse responseCancellationToken = await client.DecryptAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Decrypt()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            DecryptRequest request = new DecryptRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Ciphertext = proto::ByteString.CopyFromUtf8("ciphertext676154cb"),
            };
            DecryptResponse expectedResponse = new DecryptResponse
            {
                Plaintext = proto::ByteString.CopyFromUtf8("plaintext1d5bbcf2"),
                PlaintextCrc32C = -5108784857370523788L,
                UsedPrimary = false,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.Decrypt(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            DecryptResponse response = client.Decrypt(request.Name, request.Ciphertext);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DecryptAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            DecryptRequest request = new DecryptRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Ciphertext = proto::ByteString.CopyFromUtf8("ciphertext676154cb"),
            };
            DecryptResponse expectedResponse = new DecryptResponse
            {
                Plaintext = proto::ByteString.CopyFromUtf8("plaintext1d5bbcf2"),
                PlaintextCrc32C = -5108784857370523788L,
                UsedPrimary = false,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.DecryptAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DecryptResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            DecryptResponse responseCallSettings = await client.DecryptAsync(request.Name, request.Ciphertext, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DecryptResponse responseCancellationToken = await client.DecryptAsync(request.Name, request.Ciphertext, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DecryptResourceNames()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            DecryptRequest request = new DecryptRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Ciphertext = proto::ByteString.CopyFromUtf8("ciphertext676154cb"),
            };
            DecryptResponse expectedResponse = new DecryptResponse
            {
                Plaintext = proto::ByteString.CopyFromUtf8("plaintext1d5bbcf2"),
                PlaintextCrc32C = -5108784857370523788L,
                UsedPrimary = false,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.Decrypt(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            DecryptResponse response = client.Decrypt(request.CryptoKeyName, request.Ciphertext);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DecryptResourceNamesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            DecryptRequest request = new DecryptRequest
            {
                CryptoKeyName = CryptoKeyName.FromProjectLocationKeyRingCryptoKey("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Ciphertext = proto::ByteString.CopyFromUtf8("ciphertext676154cb"),
            };
            DecryptResponse expectedResponse = new DecryptResponse
            {
                Plaintext = proto::ByteString.CopyFromUtf8("plaintext1d5bbcf2"),
                PlaintextCrc32C = -5108784857370523788L,
                UsedPrimary = false,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.DecryptAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DecryptResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            DecryptResponse responseCallSettings = await client.DecryptAsync(request.CryptoKeyName, request.Ciphertext, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DecryptResponse responseCancellationToken = await client.DecryptAsync(request.CryptoKeyName, request.Ciphertext, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AsymmetricSignRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            AsymmetricSignRequest request = new AsymmetricSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Digest = new Digest(),
                DigestCrc32C = -5836273086403280409L,
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                DataCrc32C = 7692496952697975269L,
            };
            AsymmetricSignResponse expectedResponse = new AsymmetricSignResponse
            {
                Signature = proto::ByteString.CopyFromUtf8("signatured21f20ac"),
                SignatureCrc32C = 1544810433627481177L,
                VerifiedDigestCrc32C = true,
                Name = "name1c9368b0",
                VerifiedDataCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.AsymmetricSign(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            AsymmetricSignResponse response = client.AsymmetricSign(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AsymmetricSignRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            AsymmetricSignRequest request = new AsymmetricSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Digest = new Digest(),
                DigestCrc32C = -5836273086403280409L,
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                DataCrc32C = 7692496952697975269L,
            };
            AsymmetricSignResponse expectedResponse = new AsymmetricSignResponse
            {
                Signature = proto::ByteString.CopyFromUtf8("signatured21f20ac"),
                SignatureCrc32C = 1544810433627481177L,
                VerifiedDigestCrc32C = true,
                Name = "name1c9368b0",
                VerifiedDataCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.AsymmetricSignAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AsymmetricSignResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            AsymmetricSignResponse responseCallSettings = await client.AsymmetricSignAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AsymmetricSignResponse responseCancellationToken = await client.AsymmetricSignAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AsymmetricSign()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            AsymmetricSignRequest request = new AsymmetricSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Digest = new Digest(),
            };
            AsymmetricSignResponse expectedResponse = new AsymmetricSignResponse
            {
                Signature = proto::ByteString.CopyFromUtf8("signatured21f20ac"),
                SignatureCrc32C = 1544810433627481177L,
                VerifiedDigestCrc32C = true,
                Name = "name1c9368b0",
                VerifiedDataCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.AsymmetricSign(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            AsymmetricSignResponse response = client.AsymmetricSign(request.Name, request.Digest);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AsymmetricSignAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            AsymmetricSignRequest request = new AsymmetricSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Digest = new Digest(),
            };
            AsymmetricSignResponse expectedResponse = new AsymmetricSignResponse
            {
                Signature = proto::ByteString.CopyFromUtf8("signatured21f20ac"),
                SignatureCrc32C = 1544810433627481177L,
                VerifiedDigestCrc32C = true,
                Name = "name1c9368b0",
                VerifiedDataCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.AsymmetricSignAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AsymmetricSignResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            AsymmetricSignResponse responseCallSettings = await client.AsymmetricSignAsync(request.Name, request.Digest, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AsymmetricSignResponse responseCancellationToken = await client.AsymmetricSignAsync(request.Name, request.Digest, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AsymmetricSignResourceNames()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            AsymmetricSignRequest request = new AsymmetricSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Digest = new Digest(),
            };
            AsymmetricSignResponse expectedResponse = new AsymmetricSignResponse
            {
                Signature = proto::ByteString.CopyFromUtf8("signatured21f20ac"),
                SignatureCrc32C = 1544810433627481177L,
                VerifiedDigestCrc32C = true,
                Name = "name1c9368b0",
                VerifiedDataCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.AsymmetricSign(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            AsymmetricSignResponse response = client.AsymmetricSign(request.CryptoKeyVersionName, request.Digest);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AsymmetricSignResourceNamesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            AsymmetricSignRequest request = new AsymmetricSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Digest = new Digest(),
            };
            AsymmetricSignResponse expectedResponse = new AsymmetricSignResponse
            {
                Signature = proto::ByteString.CopyFromUtf8("signatured21f20ac"),
                SignatureCrc32C = 1544810433627481177L,
                VerifiedDigestCrc32C = true,
                Name = "name1c9368b0",
                VerifiedDataCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.AsymmetricSignAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AsymmetricSignResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            AsymmetricSignResponse responseCallSettings = await client.AsymmetricSignAsync(request.CryptoKeyVersionName, request.Digest, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AsymmetricSignResponse responseCancellationToken = await client.AsymmetricSignAsync(request.CryptoKeyVersionName, request.Digest, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AsymmetricDecryptRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            AsymmetricDecryptRequest request = new AsymmetricDecryptRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Ciphertext = proto::ByteString.CopyFromUtf8("ciphertext676154cb"),
                CiphertextCrc32C = 5835079685918568182L,
            };
            AsymmetricDecryptResponse expectedResponse = new AsymmetricDecryptResponse
            {
                Plaintext = proto::ByteString.CopyFromUtf8("plaintext1d5bbcf2"),
                PlaintextCrc32C = -5108784857370523788L,
                VerifiedCiphertextCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.AsymmetricDecrypt(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            AsymmetricDecryptResponse response = client.AsymmetricDecrypt(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AsymmetricDecryptRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            AsymmetricDecryptRequest request = new AsymmetricDecryptRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Ciphertext = proto::ByteString.CopyFromUtf8("ciphertext676154cb"),
                CiphertextCrc32C = 5835079685918568182L,
            };
            AsymmetricDecryptResponse expectedResponse = new AsymmetricDecryptResponse
            {
                Plaintext = proto::ByteString.CopyFromUtf8("plaintext1d5bbcf2"),
                PlaintextCrc32C = -5108784857370523788L,
                VerifiedCiphertextCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.AsymmetricDecryptAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AsymmetricDecryptResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            AsymmetricDecryptResponse responseCallSettings = await client.AsymmetricDecryptAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AsymmetricDecryptResponse responseCancellationToken = await client.AsymmetricDecryptAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AsymmetricDecrypt()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            AsymmetricDecryptRequest request = new AsymmetricDecryptRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Ciphertext = proto::ByteString.CopyFromUtf8("ciphertext676154cb"),
            };
            AsymmetricDecryptResponse expectedResponse = new AsymmetricDecryptResponse
            {
                Plaintext = proto::ByteString.CopyFromUtf8("plaintext1d5bbcf2"),
                PlaintextCrc32C = -5108784857370523788L,
                VerifiedCiphertextCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.AsymmetricDecrypt(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            AsymmetricDecryptResponse response = client.AsymmetricDecrypt(request.Name, request.Ciphertext);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AsymmetricDecryptAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            AsymmetricDecryptRequest request = new AsymmetricDecryptRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Ciphertext = proto::ByteString.CopyFromUtf8("ciphertext676154cb"),
            };
            AsymmetricDecryptResponse expectedResponse = new AsymmetricDecryptResponse
            {
                Plaintext = proto::ByteString.CopyFromUtf8("plaintext1d5bbcf2"),
                PlaintextCrc32C = -5108784857370523788L,
                VerifiedCiphertextCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.AsymmetricDecryptAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AsymmetricDecryptResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            AsymmetricDecryptResponse responseCallSettings = await client.AsymmetricDecryptAsync(request.Name, request.Ciphertext, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AsymmetricDecryptResponse responseCancellationToken = await client.AsymmetricDecryptAsync(request.Name, request.Ciphertext, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AsymmetricDecryptResourceNames()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            AsymmetricDecryptRequest request = new AsymmetricDecryptRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Ciphertext = proto::ByteString.CopyFromUtf8("ciphertext676154cb"),
            };
            AsymmetricDecryptResponse expectedResponse = new AsymmetricDecryptResponse
            {
                Plaintext = proto::ByteString.CopyFromUtf8("plaintext1d5bbcf2"),
                PlaintextCrc32C = -5108784857370523788L,
                VerifiedCiphertextCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.AsymmetricDecrypt(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            AsymmetricDecryptResponse response = client.AsymmetricDecrypt(request.CryptoKeyVersionName, request.Ciphertext);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AsymmetricDecryptResourceNamesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            AsymmetricDecryptRequest request = new AsymmetricDecryptRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Ciphertext = proto::ByteString.CopyFromUtf8("ciphertext676154cb"),
            };
            AsymmetricDecryptResponse expectedResponse = new AsymmetricDecryptResponse
            {
                Plaintext = proto::ByteString.CopyFromUtf8("plaintext1d5bbcf2"),
                PlaintextCrc32C = -5108784857370523788L,
                VerifiedCiphertextCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.AsymmetricDecryptAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AsymmetricDecryptResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            AsymmetricDecryptResponse responseCallSettings = await client.AsymmetricDecryptAsync(request.CryptoKeyVersionName, request.Ciphertext, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AsymmetricDecryptResponse responseCancellationToken = await client.AsymmetricDecryptAsync(request.CryptoKeyVersionName, request.Ciphertext, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MacSignRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            MacSignRequest request = new MacSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                DataCrc32C = 7692496952697975269L,
            };
            MacSignResponse expectedResponse = new MacSignResponse
            {
                Name = "name1c9368b0",
                Mac = proto::ByteString.CopyFromUtf8("mac121f0c14"),
                MacCrc32C = 8296593316352450800L,
                VerifiedDataCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.MacSign(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            MacSignResponse response = client.MacSign(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MacSignRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            MacSignRequest request = new MacSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                DataCrc32C = 7692496952697975269L,
            };
            MacSignResponse expectedResponse = new MacSignResponse
            {
                Name = "name1c9368b0",
                Mac = proto::ByteString.CopyFromUtf8("mac121f0c14"),
                MacCrc32C = 8296593316352450800L,
                VerifiedDataCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.MacSignAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MacSignResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            MacSignResponse responseCallSettings = await client.MacSignAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MacSignResponse responseCancellationToken = await client.MacSignAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MacSign()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            MacSignRequest request = new MacSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
            };
            MacSignResponse expectedResponse = new MacSignResponse
            {
                Name = "name1c9368b0",
                Mac = proto::ByteString.CopyFromUtf8("mac121f0c14"),
                MacCrc32C = 8296593316352450800L,
                VerifiedDataCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.MacSign(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            MacSignResponse response = client.MacSign(request.Name, request.Data);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MacSignAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            MacSignRequest request = new MacSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
            };
            MacSignResponse expectedResponse = new MacSignResponse
            {
                Name = "name1c9368b0",
                Mac = proto::ByteString.CopyFromUtf8("mac121f0c14"),
                MacCrc32C = 8296593316352450800L,
                VerifiedDataCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.MacSignAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MacSignResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            MacSignResponse responseCallSettings = await client.MacSignAsync(request.Name, request.Data, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MacSignResponse responseCancellationToken = await client.MacSignAsync(request.Name, request.Data, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MacSignResourceNames()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            MacSignRequest request = new MacSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
            };
            MacSignResponse expectedResponse = new MacSignResponse
            {
                Name = "name1c9368b0",
                Mac = proto::ByteString.CopyFromUtf8("mac121f0c14"),
                MacCrc32C = 8296593316352450800L,
                VerifiedDataCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.MacSign(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            MacSignResponse response = client.MacSign(request.CryptoKeyVersionName, request.Data);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MacSignResourceNamesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            MacSignRequest request = new MacSignRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
            };
            MacSignResponse expectedResponse = new MacSignResponse
            {
                Name = "name1c9368b0",
                Mac = proto::ByteString.CopyFromUtf8("mac121f0c14"),
                MacCrc32C = 8296593316352450800L,
                VerifiedDataCrc32C = true,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.MacSignAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MacSignResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            MacSignResponse responseCallSettings = await client.MacSignAsync(request.CryptoKeyVersionName, request.Data, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MacSignResponse responseCancellationToken = await client.MacSignAsync(request.CryptoKeyVersionName, request.Data, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MacVerifyRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            MacVerifyRequest request = new MacVerifyRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                DataCrc32C = 7692496952697975269L,
                Mac = proto::ByteString.CopyFromUtf8("mac121f0c14"),
                MacCrc32C = 8296593316352450800L,
            };
            MacVerifyResponse expectedResponse = new MacVerifyResponse
            {
                Name = "name1c9368b0",
                Success = false,
                VerifiedDataCrc32C = true,
                VerifiedMacCrc32C = false,
                VerifiedSuccessIntegrity = false,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.MacVerify(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            MacVerifyResponse response = client.MacVerify(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MacVerifyRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            MacVerifyRequest request = new MacVerifyRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                DataCrc32C = 7692496952697975269L,
                Mac = proto::ByteString.CopyFromUtf8("mac121f0c14"),
                MacCrc32C = 8296593316352450800L,
            };
            MacVerifyResponse expectedResponse = new MacVerifyResponse
            {
                Name = "name1c9368b0",
                Success = false,
                VerifiedDataCrc32C = true,
                VerifiedMacCrc32C = false,
                VerifiedSuccessIntegrity = false,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.MacVerifyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MacVerifyResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            MacVerifyResponse responseCallSettings = await client.MacVerifyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MacVerifyResponse responseCancellationToken = await client.MacVerifyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MacVerify()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            MacVerifyRequest request = new MacVerifyRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Mac = proto::ByteString.CopyFromUtf8("mac121f0c14"),
            };
            MacVerifyResponse expectedResponse = new MacVerifyResponse
            {
                Name = "name1c9368b0",
                Success = false,
                VerifiedDataCrc32C = true,
                VerifiedMacCrc32C = false,
                VerifiedSuccessIntegrity = false,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.MacVerify(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            MacVerifyResponse response = client.MacVerify(request.Name, request.Data, request.Mac);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MacVerifyAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            MacVerifyRequest request = new MacVerifyRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Mac = proto::ByteString.CopyFromUtf8("mac121f0c14"),
            };
            MacVerifyResponse expectedResponse = new MacVerifyResponse
            {
                Name = "name1c9368b0",
                Success = false,
                VerifiedDataCrc32C = true,
                VerifiedMacCrc32C = false,
                VerifiedSuccessIntegrity = false,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.MacVerifyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MacVerifyResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            MacVerifyResponse responseCallSettings = await client.MacVerifyAsync(request.Name, request.Data, request.Mac, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MacVerifyResponse responseCancellationToken = await client.MacVerifyAsync(request.Name, request.Data, request.Mac, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void MacVerifyResourceNames()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            MacVerifyRequest request = new MacVerifyRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Mac = proto::ByteString.CopyFromUtf8("mac121f0c14"),
            };
            MacVerifyResponse expectedResponse = new MacVerifyResponse
            {
                Name = "name1c9368b0",
                Success = false,
                VerifiedDataCrc32C = true,
                VerifiedMacCrc32C = false,
                VerifiedSuccessIntegrity = false,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.MacVerify(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            MacVerifyResponse response = client.MacVerify(request.CryptoKeyVersionName, request.Data, request.Mac);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task MacVerifyResourceNamesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            MacVerifyRequest request = new MacVerifyRequest
            {
                CryptoKeyVersionName = CryptoKeyVersionName.FromProjectLocationKeyRingCryptoKeyCryptoKeyVersion("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Mac = proto::ByteString.CopyFromUtf8("mac121f0c14"),
            };
            MacVerifyResponse expectedResponse = new MacVerifyResponse
            {
                Name = "name1c9368b0",
                Success = false,
                VerifiedDataCrc32C = true,
                VerifiedMacCrc32C = false,
                VerifiedSuccessIntegrity = false,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            mockGrpcClient.Setup(x => x.MacVerifyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<MacVerifyResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            MacVerifyResponse responseCallSettings = await client.MacVerifyAsync(request.CryptoKeyVersionName, request.Data, request.Mac, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            MacVerifyResponse responseCancellationToken = await client.MacVerifyAsync(request.CryptoKeyVersionName, request.Data, request.Mac, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateRandomBytesRequestObject()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GenerateRandomBytesRequest request = new GenerateRandomBytesRequest
            {
                Location = "locatione09d18d5",
                LengthBytes = 1939961421,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            GenerateRandomBytesResponse expectedResponse = new GenerateRandomBytesResponse
            {
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                DataCrc32C = 7692496952697975269L,
            };
            mockGrpcClient.Setup(x => x.GenerateRandomBytes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            GenerateRandomBytesResponse response = client.GenerateRandomBytes(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateRandomBytesRequestObjectAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GenerateRandomBytesRequest request = new GenerateRandomBytesRequest
            {
                Location = "locatione09d18d5",
                LengthBytes = 1939961421,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            GenerateRandomBytesResponse expectedResponse = new GenerateRandomBytesResponse
            {
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                DataCrc32C = 7692496952697975269L,
            };
            mockGrpcClient.Setup(x => x.GenerateRandomBytesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateRandomBytesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            GenerateRandomBytesResponse responseCallSettings = await client.GenerateRandomBytesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateRandomBytesResponse responseCancellationToken = await client.GenerateRandomBytesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateRandomBytes()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GenerateRandomBytesRequest request = new GenerateRandomBytesRequest
            {
                Location = "locatione09d18d5",
                LengthBytes = 1939961421,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            GenerateRandomBytesResponse expectedResponse = new GenerateRandomBytesResponse
            {
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                DataCrc32C = 7692496952697975269L,
            };
            mockGrpcClient.Setup(x => x.GenerateRandomBytes(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            GenerateRandomBytesResponse response = client.GenerateRandomBytes(request.Location, request.LengthBytes, request.ProtectionLevel);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateRandomBytesAsync()
        {
            moq::Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new moq::Mock<KeyManagementService.KeyManagementServiceClient>(moq::MockBehavior.Strict);
            GenerateRandomBytesRequest request = new GenerateRandomBytesRequest
            {
                Location = "locatione09d18d5",
                LengthBytes = 1939961421,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            GenerateRandomBytesResponse expectedResponse = new GenerateRandomBytesResponse
            {
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                DataCrc32C = 7692496952697975269L,
            };
            mockGrpcClient.Setup(x => x.GenerateRandomBytesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateRandomBytesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            GenerateRandomBytesResponse responseCallSettings = await client.GenerateRandomBytesAsync(request.Location, request.LengthBytes, request.ProtectionLevel, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateRandomBytesResponse responseCancellationToken = await client.GenerateRandomBytesAsync(request.Location, request.LengthBytes, request.ProtectionLevel, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
