// Copyright 2019 Google LLC
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

namespace Google.Cloud.Kms.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.Iam.V1;
    using apis = Google.Cloud.Kms.V1;
    using Google.Protobuf;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using Xunit;

    /// <summary>Generated unit tests</summary>
    public class GeneratedKeyManagementServiceClientTest
    {
        [Fact]
        public void GetKeyRing()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetKeyRingRequest expectedRequest = new GetKeyRingRequest
            {
                KeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            mockGrpcClient.Setup(x => x.GetKeyRing(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRingName name = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            KeyRing response = client.GetKeyRing(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetKeyRingAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetKeyRingRequest expectedRequest = new GetKeyRingRequest
            {
                KeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            mockGrpcClient.Setup(x => x.GetKeyRingAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<KeyRing>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRingName name = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            KeyRing response = await client.GetKeyRingAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetKeyRing2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetKeyRingRequest request = new GetKeyRingRequest
            {
                KeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            mockGrpcClient.Setup(x => x.GetKeyRing(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRing response = client.GetKeyRing(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetKeyRingAsync2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetKeyRingRequest request = new GetKeyRingRequest
            {
                KeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            mockGrpcClient.Setup(x => x.GetKeyRingAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<KeyRing>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRing response = await client.GetKeyRingAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetImportJob()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetImportJobRequest expectedRequest = new GetImportJobRequest
            {
                ImportJobName = new ImportJobName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
            };
            ImportJob expectedResponse = new ImportJob
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetImportJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            ImportJobName name = new ImportJobName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]");
            ImportJob response = client.GetImportJob(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetImportJobAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetImportJobRequest expectedRequest = new GetImportJobRequest
            {
                ImportJobName = new ImportJobName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
            };
            ImportJob expectedResponse = new ImportJob
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetImportJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ImportJob>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            ImportJobName name = new ImportJobName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]");
            ImportJob response = await client.GetImportJobAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetImportJob2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetImportJobRequest request = new GetImportJobRequest
            {
                ImportJobName = new ImportJobName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
            };
            ImportJob expectedResponse = new ImportJob
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetImportJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            ImportJob response = client.GetImportJob(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetImportJobAsync2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetImportJobRequest request = new GetImportJobRequest
            {
                ImportJobName = new ImportJobName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[IMPORT_JOB]"),
            };
            ImportJob expectedResponse = new ImportJob
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetImportJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ImportJob>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            ImportJob response = await client.GetImportJobAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetCryptoKey()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetCryptoKeyRequest expectedRequest = new GetCryptoKeyRequest
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            mockGrpcClient.Setup(x => x.GetCryptoKey(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyName name = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            CryptoKey response = client.GetCryptoKey(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetCryptoKeyAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetCryptoKeyRequest expectedRequest = new GetCryptoKeyRequest
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            mockGrpcClient.Setup(x => x.GetCryptoKeyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKey>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyName name = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            CryptoKey response = await client.GetCryptoKeyAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetCryptoKey2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetCryptoKeyRequest request = new GetCryptoKeyRequest
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            mockGrpcClient.Setup(x => x.GetCryptoKey(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = client.GetCryptoKey(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetCryptoKeyAsync2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetCryptoKeyRequest request = new GetCryptoKeyRequest
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            mockGrpcClient.Setup(x => x.GetCryptoKeyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKey>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = await client.GetCryptoKeyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetCryptoKeyVersion()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetCryptoKeyVersionRequest expectedRequest = new GetCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.GetCryptoKeyVersion(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            CryptoKeyVersion response = client.GetCryptoKeyVersion(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetCryptoKeyVersionAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetCryptoKeyVersionRequest expectedRequest = new GetCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.GetCryptoKeyVersionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKeyVersion>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            CryptoKeyVersion response = await client.GetCryptoKeyVersionAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetCryptoKeyVersion2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetCryptoKeyVersionRequest request = new GetCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.GetCryptoKeyVersion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.GetCryptoKeyVersion(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetCryptoKeyVersionAsync2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetCryptoKeyVersionRequest request = new GetCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.GetCryptoKeyVersionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKeyVersion>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = await client.GetCryptoKeyVersionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateKeyRing()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateKeyRingRequest expectedRequest = new CreateKeyRingRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                KeyRingId = "keyRingId-2056646742",
                KeyRing = new KeyRing(),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            mockGrpcClient.Setup(x => x.CreateKeyRing(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            string keyRingId = "keyRingId-2056646742";
            KeyRing keyRing = new KeyRing();
            KeyRing response = client.CreateKeyRing(parent, keyRingId, keyRing);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateKeyRingAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateKeyRingRequest expectedRequest = new CreateKeyRingRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                KeyRingId = "keyRingId-2056646742",
                KeyRing = new KeyRing(),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            mockGrpcClient.Setup(x => x.CreateKeyRingAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<KeyRing>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            LocationName parent = new LocationName("[PROJECT]", "[LOCATION]");
            string keyRingId = "keyRingId-2056646742";
            KeyRing keyRing = new KeyRing();
            KeyRing response = await client.CreateKeyRingAsync(parent, keyRingId, keyRing);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateKeyRing2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateKeyRingRequest request = new CreateKeyRingRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                KeyRingId = "keyRingId-2056646742",
                KeyRing = new KeyRing(),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            mockGrpcClient.Setup(x => x.CreateKeyRing(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRing response = client.CreateKeyRing(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateKeyRingAsync2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateKeyRingRequest request = new CreateKeyRingRequest
            {
                ParentAsLocationName = new LocationName("[PROJECT]", "[LOCATION]"),
                KeyRingId = "keyRingId-2056646742",
                KeyRing = new KeyRing(),
            };
            KeyRing expectedResponse = new KeyRing
            {
                KeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
            };
            mockGrpcClient.Setup(x => x.CreateKeyRingAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<KeyRing>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRing response = await client.CreateKeyRingAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateImportJob()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateImportJobRequest expectedRequest = new CreateImportJobRequest
            {
                ParentAsKeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                ImportJobId = "my-import-job",
                ImportJob = new ImportJob
                {
                    ImportMethod = ImportJob.Types.ImportMethod.RsaOaep3072Sha1Aes256,
                    ProtectionLevel = ProtectionLevel.Hsm,
                },
            };
            ImportJob expectedResponse = new ImportJob
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.CreateImportJob(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRingName parent = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            string importJobId = "my-import-job";
            ImportJob importJob = new ImportJob
            {
                ImportMethod = ImportJob.Types.ImportMethod.RsaOaep3072Sha1Aes256,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            ImportJob response = client.CreateImportJob(parent, importJobId, importJob);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateImportJobAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateImportJobRequest expectedRequest = new CreateImportJobRequest
            {
                ParentAsKeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                ImportJobId = "my-import-job",
                ImportJob = new ImportJob
                {
                    ImportMethod = ImportJob.Types.ImportMethod.RsaOaep3072Sha1Aes256,
                    ProtectionLevel = ProtectionLevel.Hsm,
                },
            };
            ImportJob expectedResponse = new ImportJob
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.CreateImportJobAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ImportJob>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRingName parent = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            string importJobId = "my-import-job";
            ImportJob importJob = new ImportJob
            {
                ImportMethod = ImportJob.Types.ImportMethod.RsaOaep3072Sha1Aes256,
                ProtectionLevel = ProtectionLevel.Hsm,
            };
            ImportJob response = await client.CreateImportJobAsync(parent, importJobId, importJob);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateImportJob2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateImportJobRequest request = new CreateImportJobRequest
            {
                ParentAsKeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                ImportJobId = "my-import-job",
                ImportJob = new ImportJob
                {
                    ImportMethod = ImportJob.Types.ImportMethod.RsaOaep3072Sha1Aes256,
                    ProtectionLevel = ProtectionLevel.Hsm,
                },
            };
            ImportJob expectedResponse = new ImportJob
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.CreateImportJob(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            ImportJob response = client.CreateImportJob(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateImportJobAsync2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateImportJobRequest request = new CreateImportJobRequest
            {
                ParentAsKeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                ImportJobId = "my-import-job",
                ImportJob = new ImportJob
                {
                    ImportMethod = ImportJob.Types.ImportMethod.RsaOaep3072Sha1Aes256,
                    ProtectionLevel = ProtectionLevel.Hsm,
                },
            };
            ImportJob expectedResponse = new ImportJob
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.CreateImportJobAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ImportJob>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            ImportJob response = await client.CreateImportJobAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateCryptoKey()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateCryptoKeyRequest expectedRequest = new CreateCryptoKeyRequest
            {
                ParentAsKeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CryptoKeyId = "my-app-key",
                CryptoKey = new CryptoKey
                {
                    Purpose = CryptoKey.Types.CryptoKeyPurpose.EncryptDecrypt,
                    NextRotationTime = new Timestamp
                                       {
                                           Seconds = 2147483647L,
                                       },
                    RotationPeriod = new Duration
                                     {
                                         Seconds = 604800L,
                                     },
                },
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKey(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRingName parent = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            string cryptoKeyId = "my-app-key";
            CryptoKey cryptoKey = new CryptoKey
            {
                Purpose = CryptoKey.Types.CryptoKeyPurpose.EncryptDecrypt,
                NextRotationTime = new Timestamp
                {
                    Seconds = 2147483647L,
                },
                RotationPeriod = new Duration
                {
                    Seconds = 604800L,
                },
            };
            CryptoKey response = client.CreateCryptoKey(parent, cryptoKeyId, cryptoKey);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateCryptoKeyAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateCryptoKeyRequest expectedRequest = new CreateCryptoKeyRequest
            {
                ParentAsKeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CryptoKeyId = "my-app-key",
                CryptoKey = new CryptoKey
                {
                    Purpose = CryptoKey.Types.CryptoKeyPurpose.EncryptDecrypt,
                    NextRotationTime = new Timestamp
                                       {
                                           Seconds = 2147483647L,
                                       },
                    RotationPeriod = new Duration
                                     {
                                         Seconds = 604800L,
                                     },
                },
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKeyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKey>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            KeyRingName parent = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]");
            string cryptoKeyId = "my-app-key";
            CryptoKey cryptoKey = new CryptoKey
            {
                Purpose = CryptoKey.Types.CryptoKeyPurpose.EncryptDecrypt,
                NextRotationTime = new Timestamp
                {
                    Seconds = 2147483647L,
                },
                RotationPeriod = new Duration
                {
                    Seconds = 604800L,
                },
            };
            CryptoKey response = await client.CreateCryptoKeyAsync(parent, cryptoKeyId, cryptoKey);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateCryptoKey2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateCryptoKeyRequest request = new CreateCryptoKeyRequest
            {
                ParentAsKeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CryptoKeyId = "my-app-key",
                CryptoKey = new CryptoKey
                {
                    Purpose = CryptoKey.Types.CryptoKeyPurpose.EncryptDecrypt,
                    NextRotationTime = new Timestamp
                                       {
                                           Seconds = 2147483647L,
                                       },
                    RotationPeriod = new Duration
                                     {
                                         Seconds = 604800L,
                                     },
                },
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKey(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = client.CreateCryptoKey(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateCryptoKeyAsync2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateCryptoKeyRequest request = new CreateCryptoKeyRequest
            {
                ParentAsKeyRingName = new KeyRingName("[PROJECT]", "[LOCATION]", "[KEY_RING]"),
                CryptoKeyId = "my-app-key",
                CryptoKey = new CryptoKey
                {
                    Purpose = CryptoKey.Types.CryptoKeyPurpose.EncryptDecrypt,
                    NextRotationTime = new Timestamp
                                       {
                                           Seconds = 2147483647L,
                                       },
                    RotationPeriod = new Duration
                                     {
                                         Seconds = 604800L,
                                     },
                },
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKeyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKey>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = await client.CreateCryptoKeyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateCryptoKeyVersion()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateCryptoKeyVersionRequest expectedRequest = new CreateCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersion = new CryptoKeyVersion(),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKeyVersion(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyName parent = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            CryptoKeyVersion response = client.CreateCryptoKeyVersion(parent, cryptoKeyVersion);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateCryptoKeyVersionAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateCryptoKeyVersionRequest expectedRequest = new CreateCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersion = new CryptoKeyVersion(),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKeyVersionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKeyVersion>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyName parent = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            CryptoKeyVersion response = await client.CreateCryptoKeyVersionAsync(parent, cryptoKeyVersion);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateCryptoKeyVersion2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateCryptoKeyVersionRequest request = new CreateCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersion = new CryptoKeyVersion(),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKeyVersion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.CreateCryptoKeyVersion(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateCryptoKeyVersionAsync2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            CreateCryptoKeyVersionRequest request = new CreateCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersion = new CryptoKeyVersion(),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.CreateCryptoKeyVersionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKeyVersion>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = await client.CreateCryptoKeyVersionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ImportCryptoKeyVersion()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            ImportCryptoKeyVersionRequest request = new ImportCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.Unspecified,
                ImportJob = "importJob2125587491",
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2-1714851050",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.ImportCryptoKeyVersion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.ImportCryptoKeyVersion(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ImportCryptoKeyVersionAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            ImportCryptoKeyVersionRequest request = new ImportCryptoKeyVersionRequest
            {
                ParentAsCryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Algorithm = CryptoKeyVersion.Types.CryptoKeyVersionAlgorithm.Unspecified,
                ImportJob = "importJob2125587491",
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2-1714851050",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.ImportCryptoKeyVersionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKeyVersion>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = await client.ImportCryptoKeyVersionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateCryptoKey()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            UpdateCryptoKeyRequest expectedRequest = new UpdateCryptoKeyRequest
            {
                CryptoKey = new CryptoKey(),
                UpdateMask = new FieldMask(),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKey(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey cryptoKey = new CryptoKey();
            FieldMask updateMask = new FieldMask();
            CryptoKey response = client.UpdateCryptoKey(cryptoKey, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateCryptoKeyAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            UpdateCryptoKeyRequest expectedRequest = new UpdateCryptoKeyRequest
            {
                CryptoKey = new CryptoKey(),
                UpdateMask = new FieldMask(),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKey>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey cryptoKey = new CryptoKey();
            FieldMask updateMask = new FieldMask();
            CryptoKey response = await client.UpdateCryptoKeyAsync(cryptoKey, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateCryptoKey2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            UpdateCryptoKeyRequest request = new UpdateCryptoKeyRequest
            {
                CryptoKey = new CryptoKey(),
                UpdateMask = new FieldMask(),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKey(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = client.UpdateCryptoKey(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateCryptoKeyAsync2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            UpdateCryptoKeyRequest request = new UpdateCryptoKeyRequest
            {
                CryptoKey = new CryptoKey(),
                UpdateMask = new FieldMask(),
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKey>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = await client.UpdateCryptoKeyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateCryptoKeyVersion()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            UpdateCryptoKeyVersionRequest expectedRequest = new UpdateCryptoKeyVersionRequest
            {
                CryptoKeyVersion = new CryptoKeyVersion(),
                UpdateMask = new FieldMask(),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyVersion(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            FieldMask updateMask = new FieldMask();
            CryptoKeyVersion response = client.UpdateCryptoKeyVersion(cryptoKeyVersion, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateCryptoKeyVersionAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            UpdateCryptoKeyVersionRequest expectedRequest = new UpdateCryptoKeyVersionRequest
            {
                CryptoKeyVersion = new CryptoKeyVersion(),
                UpdateMask = new FieldMask(),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyVersionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKeyVersion>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion cryptoKeyVersion = new CryptoKeyVersion();
            FieldMask updateMask = new FieldMask();
            CryptoKeyVersion response = await client.UpdateCryptoKeyVersionAsync(cryptoKeyVersion, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateCryptoKeyVersion2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            UpdateCryptoKeyVersionRequest request = new UpdateCryptoKeyVersionRequest
            {
                CryptoKeyVersion = new CryptoKeyVersion(),
                UpdateMask = new FieldMask(),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyVersion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.UpdateCryptoKeyVersion(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateCryptoKeyVersionAsync2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            UpdateCryptoKeyVersionRequest request = new UpdateCryptoKeyVersionRequest
            {
                CryptoKeyVersion = new CryptoKeyVersion(),
                UpdateMask = new FieldMask(),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyVersionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKeyVersion>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = await client.UpdateCryptoKeyVersionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Encrypt()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            EncryptRequest expectedRequest = new EncryptRequest
            {
                CryptoKeyPathName = new CryptoKeyPathName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY_PATH]"),
                Plaintext = ByteString.CopyFromUtf8("-9"),
            };
            EncryptResponse expectedResponse = new EncryptResponse
            {
                Name = "name2-1052831874",
                Ciphertext = ByteString.CopyFromUtf8("-72"),
            };
            mockGrpcClient.Setup(x => x.Encrypt(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyPathName name = new CryptoKeyPathName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY_PATH]");
            ByteString plaintext = ByteString.CopyFromUtf8("-9");
            EncryptResponse response = client.Encrypt(name, plaintext);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task EncryptAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            EncryptRequest expectedRequest = new EncryptRequest
            {
                CryptoKeyPathName = new CryptoKeyPathName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY_PATH]"),
                Plaintext = ByteString.CopyFromUtf8("-9"),
            };
            EncryptResponse expectedResponse = new EncryptResponse
            {
                Name = "name2-1052831874",
                Ciphertext = ByteString.CopyFromUtf8("-72"),
            };
            mockGrpcClient.Setup(x => x.EncryptAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<EncryptResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyPathName name = new CryptoKeyPathName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY_PATH]");
            ByteString plaintext = ByteString.CopyFromUtf8("-9");
            EncryptResponse response = await client.EncryptAsync(name, plaintext);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Encrypt2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            EncryptRequest request = new EncryptRequest
            {
                CryptoKeyPathName = new CryptoKeyPathName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY_PATH]"),
                Plaintext = ByteString.CopyFromUtf8("-9"),
            };
            EncryptResponse expectedResponse = new EncryptResponse
            {
                Name = "name2-1052831874",
                Ciphertext = ByteString.CopyFromUtf8("-72"),
            };
            mockGrpcClient.Setup(x => x.Encrypt(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            EncryptResponse response = client.Encrypt(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task EncryptAsync2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            EncryptRequest request = new EncryptRequest
            {
                CryptoKeyPathName = new CryptoKeyPathName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY_PATH]"),
                Plaintext = ByteString.CopyFromUtf8("-9"),
            };
            EncryptResponse expectedResponse = new EncryptResponse
            {
                Name = "name2-1052831874",
                Ciphertext = ByteString.CopyFromUtf8("-72"),
            };
            mockGrpcClient.Setup(x => x.EncryptAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<EncryptResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            EncryptResponse response = await client.EncryptAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Decrypt()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DecryptRequest expectedRequest = new DecryptRequest
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Ciphertext = ByteString.CopyFromUtf8("-72"),
            };
            DecryptResponse expectedResponse = new DecryptResponse
            {
                Plaintext = ByteString.CopyFromUtf8("-9"),
            };
            mockGrpcClient.Setup(x => x.Decrypt(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyName name = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            ByteString ciphertext = ByteString.CopyFromUtf8("-72");
            DecryptResponse response = client.Decrypt(name, ciphertext);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DecryptAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DecryptRequest expectedRequest = new DecryptRequest
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Ciphertext = ByteString.CopyFromUtf8("-72"),
            };
            DecryptResponse expectedResponse = new DecryptResponse
            {
                Plaintext = ByteString.CopyFromUtf8("-9"),
            };
            mockGrpcClient.Setup(x => x.DecryptAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DecryptResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyName name = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            ByteString ciphertext = ByteString.CopyFromUtf8("-72");
            DecryptResponse response = await client.DecryptAsync(name, ciphertext);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void Decrypt2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DecryptRequest request = new DecryptRequest
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Ciphertext = ByteString.CopyFromUtf8("-72"),
            };
            DecryptResponse expectedResponse = new DecryptResponse
            {
                Plaintext = ByteString.CopyFromUtf8("-9"),
            };
            mockGrpcClient.Setup(x => x.Decrypt(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            DecryptResponse response = client.Decrypt(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DecryptAsync2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DecryptRequest request = new DecryptRequest
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                Ciphertext = ByteString.CopyFromUtf8("-72"),
            };
            DecryptResponse expectedResponse = new DecryptResponse
            {
                Plaintext = ByteString.CopyFromUtf8("-9"),
            };
            mockGrpcClient.Setup(x => x.DecryptAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<DecryptResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            DecryptResponse response = await client.DecryptAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateCryptoKeyPrimaryVersion()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            UpdateCryptoKeyPrimaryVersionRequest expectedRequest = new UpdateCryptoKeyPrimaryVersionRequest
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersionId = "cryptoKeyVersionId729489152",
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyPrimaryVersion(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyName name = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            string cryptoKeyVersionId = "cryptoKeyVersionId729489152";
            CryptoKey response = client.UpdateCryptoKeyPrimaryVersion(name, cryptoKeyVersionId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateCryptoKeyPrimaryVersionAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            UpdateCryptoKeyPrimaryVersionRequest expectedRequest = new UpdateCryptoKeyPrimaryVersionRequest
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersionId = "cryptoKeyVersionId729489152",
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyPrimaryVersionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKey>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyName name = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]");
            string cryptoKeyVersionId = "cryptoKeyVersionId729489152";
            CryptoKey response = await client.UpdateCryptoKeyPrimaryVersionAsync(name, cryptoKeyVersionId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateCryptoKeyPrimaryVersion2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            UpdateCryptoKeyPrimaryVersionRequest request = new UpdateCryptoKeyPrimaryVersionRequest
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersionId = "cryptoKeyVersionId729489152",
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyPrimaryVersion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = client.UpdateCryptoKeyPrimaryVersion(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateCryptoKeyPrimaryVersionAsync2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            UpdateCryptoKeyPrimaryVersionRequest request = new UpdateCryptoKeyPrimaryVersionRequest
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
                CryptoKeyVersionId = "cryptoKeyVersionId729489152",
            };
            CryptoKey expectedResponse = new CryptoKey
            {
                CryptoKeyName = new CryptoKeyName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]"),
            };
            mockGrpcClient.Setup(x => x.UpdateCryptoKeyPrimaryVersionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKey>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKey response = await client.UpdateCryptoKeyPrimaryVersionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DestroyCryptoKeyVersion()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DestroyCryptoKeyVersionRequest expectedRequest = new DestroyCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.DestroyCryptoKeyVersion(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            CryptoKeyVersion response = client.DestroyCryptoKeyVersion(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DestroyCryptoKeyVersionAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DestroyCryptoKeyVersionRequest expectedRequest = new DestroyCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.DestroyCryptoKeyVersionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKeyVersion>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            CryptoKeyVersion response = await client.DestroyCryptoKeyVersionAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DestroyCryptoKeyVersion2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DestroyCryptoKeyVersionRequest request = new DestroyCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.DestroyCryptoKeyVersion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.DestroyCryptoKeyVersion(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DestroyCryptoKeyVersionAsync2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            DestroyCryptoKeyVersionRequest request = new DestroyCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.DestroyCryptoKeyVersionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKeyVersion>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = await client.DestroyCryptoKeyVersionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RestoreCryptoKeyVersion()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            RestoreCryptoKeyVersionRequest expectedRequest = new RestoreCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.RestoreCryptoKeyVersion(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            CryptoKeyVersion response = client.RestoreCryptoKeyVersion(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RestoreCryptoKeyVersionAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            RestoreCryptoKeyVersionRequest expectedRequest = new RestoreCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.RestoreCryptoKeyVersionAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKeyVersion>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            CryptoKeyVersion response = await client.RestoreCryptoKeyVersionAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void RestoreCryptoKeyVersion2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            RestoreCryptoKeyVersionRequest request = new RestoreCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.RestoreCryptoKeyVersion(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = client.RestoreCryptoKeyVersion(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task RestoreCryptoKeyVersionAsync2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            RestoreCryptoKeyVersionRequest request = new RestoreCryptoKeyVersionRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            CryptoKeyVersion expectedResponse = new CryptoKeyVersion
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                ImportJob = "importJob2125587491",
                ImportFailureReason = "importFailureReason-494073229",
            };
            mockGrpcClient.Setup(x => x.RestoreCryptoKeyVersionAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CryptoKeyVersion>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersion response = await client.RestoreCryptoKeyVersionAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetPublicKey()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetPublicKeyRequest expectedRequest = new GetPublicKeyRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            PublicKey expectedResponse = new PublicKey
            {
                Pem = "pem110872",
            };
            mockGrpcClient.Setup(x => x.GetPublicKey(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            PublicKey response = client.GetPublicKey(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetPublicKeyAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetPublicKeyRequest expectedRequest = new GetPublicKeyRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            PublicKey expectedResponse = new PublicKey
            {
                Pem = "pem110872",
            };
            mockGrpcClient.Setup(x => x.GetPublicKeyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<PublicKey>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            PublicKey response = await client.GetPublicKeyAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetPublicKey2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetPublicKeyRequest request = new GetPublicKeyRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            PublicKey expectedResponse = new PublicKey
            {
                Pem = "pem110872",
            };
            mockGrpcClient.Setup(x => x.GetPublicKey(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            PublicKey response = client.GetPublicKey(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetPublicKeyAsync2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            GetPublicKeyRequest request = new GetPublicKeyRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
            };
            PublicKey expectedResponse = new PublicKey
            {
                Pem = "pem110872",
            };
            mockGrpcClient.Setup(x => x.GetPublicKeyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<PublicKey>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            PublicKey response = await client.GetPublicKeyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AsymmetricDecrypt()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            AsymmetricDecryptRequest expectedRequest = new AsymmetricDecryptRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Ciphertext = ByteString.CopyFromUtf8("-72"),
            };
            AsymmetricDecryptResponse expectedResponse = new AsymmetricDecryptResponse
            {
                Plaintext = ByteString.CopyFromUtf8("-9"),
            };
            mockGrpcClient.Setup(x => x.AsymmetricDecrypt(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            ByteString ciphertext = ByteString.CopyFromUtf8("-72");
            AsymmetricDecryptResponse response = client.AsymmetricDecrypt(name, ciphertext);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AsymmetricDecryptAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            AsymmetricDecryptRequest expectedRequest = new AsymmetricDecryptRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Ciphertext = ByteString.CopyFromUtf8("-72"),
            };
            AsymmetricDecryptResponse expectedResponse = new AsymmetricDecryptResponse
            {
                Plaintext = ByteString.CopyFromUtf8("-9"),
            };
            mockGrpcClient.Setup(x => x.AsymmetricDecryptAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AsymmetricDecryptResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            ByteString ciphertext = ByteString.CopyFromUtf8("-72");
            AsymmetricDecryptResponse response = await client.AsymmetricDecryptAsync(name, ciphertext);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AsymmetricDecrypt2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            AsymmetricDecryptRequest request = new AsymmetricDecryptRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Ciphertext = ByteString.CopyFromUtf8("-72"),
            };
            AsymmetricDecryptResponse expectedResponse = new AsymmetricDecryptResponse
            {
                Plaintext = ByteString.CopyFromUtf8("-9"),
            };
            mockGrpcClient.Setup(x => x.AsymmetricDecrypt(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            AsymmetricDecryptResponse response = client.AsymmetricDecrypt(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AsymmetricDecryptAsync2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            AsymmetricDecryptRequest request = new AsymmetricDecryptRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Ciphertext = ByteString.CopyFromUtf8("-72"),
            };
            AsymmetricDecryptResponse expectedResponse = new AsymmetricDecryptResponse
            {
                Plaintext = ByteString.CopyFromUtf8("-9"),
            };
            mockGrpcClient.Setup(x => x.AsymmetricDecryptAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AsymmetricDecryptResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            AsymmetricDecryptResponse response = await client.AsymmetricDecryptAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AsymmetricSign()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            AsymmetricSignRequest expectedRequest = new AsymmetricSignRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Digest = new Digest(),
            };
            AsymmetricSignResponse expectedResponse = new AsymmetricSignResponse
            {
                Signature = ByteString.CopyFromUtf8("106"),
            };
            mockGrpcClient.Setup(x => x.AsymmetricSign(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            Digest digest = new Digest();
            AsymmetricSignResponse response = client.AsymmetricSign(name, digest);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AsymmetricSignAsync()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            AsymmetricSignRequest expectedRequest = new AsymmetricSignRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Digest = new Digest(),
            };
            AsymmetricSignResponse expectedResponse = new AsymmetricSignResponse
            {
                Signature = ByteString.CopyFromUtf8("-100"),
            };
            mockGrpcClient.Setup(x => x.AsymmetricSignAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AsymmetricSignResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            CryptoKeyVersionName name = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]");
            Digest digest = new Digest();
            AsymmetricSignResponse response = await client.AsymmetricSignAsync(name, digest);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void AsymmetricSign2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            AsymmetricSignRequest request = new AsymmetricSignRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Digest = new Digest(),
            };
            AsymmetricSignResponse expectedResponse = new AsymmetricSignResponse
            {
                Signature = ByteString.CopyFromUtf8("78"),
            };
            mockGrpcClient.Setup(x => x.AsymmetricSign(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            AsymmetricSignResponse response = client.AsymmetricSign(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task AsymmetricSignAsync2()
        {
            Mock<KeyManagementService.KeyManagementServiceClient> mockGrpcClient = new Mock<KeyManagementService.KeyManagementServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateIAMPolicyClient())
                .Returns(new Mock<IAMPolicy.IAMPolicyClient>().Object);
            AsymmetricSignRequest request = new AsymmetricSignRequest
            {
                CryptoKeyVersionName = new CryptoKeyVersionName("[PROJECT]", "[LOCATION]", "[KEY_RING]", "[CRYPTO_KEY]", "[CRYPTO_KEY_VERSION]"),
                Digest = new Digest(),
            };
            AsymmetricSignResponse expectedResponse = new AsymmetricSignResponse
            {
                Signature = ByteString.CopyFromUtf8("-128"),
            };
            mockGrpcClient.Setup(x => x.AsymmetricSignAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AsymmetricSignResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            KeyManagementServiceClient client = new KeyManagementServiceClientImpl(mockGrpcClient.Object, null);
            AsymmetricSignResponse response = await client.AsymmetricSignAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
