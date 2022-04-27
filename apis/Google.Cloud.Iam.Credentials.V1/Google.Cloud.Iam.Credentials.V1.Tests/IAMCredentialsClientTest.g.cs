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
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Iam.Credentials.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedIAMCredentialsClientTest
    {
        [xunit::FactAttribute]
        public void GenerateAccessTokenRequestObject()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            GenerateAccessTokenRequest request = new GenerateAccessTokenRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Scope = { "scope14fda131", },
                Lifetime = new wkt::Duration(),
            };
            GenerateAccessTokenResponse expectedResponse = new GenerateAccessTokenResponse
            {
                AccessToken = "access_token85826cd8",
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GenerateAccessToken(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            GenerateAccessTokenResponse response = client.GenerateAccessToken(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateAccessTokenRequestObjectAsync()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            GenerateAccessTokenRequest request = new GenerateAccessTokenRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Scope = { "scope14fda131", },
                Lifetime = new wkt::Duration(),
            };
            GenerateAccessTokenResponse expectedResponse = new GenerateAccessTokenResponse
            {
                AccessToken = "access_token85826cd8",
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GenerateAccessTokenAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateAccessTokenResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            GenerateAccessTokenResponse responseCallSettings = await client.GenerateAccessTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateAccessTokenResponse responseCancellationToken = await client.GenerateAccessTokenAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateAccessToken()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            GenerateAccessTokenRequest request = new GenerateAccessTokenRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Scope = { "scope14fda131", },
                Lifetime = new wkt::Duration(),
            };
            GenerateAccessTokenResponse expectedResponse = new GenerateAccessTokenResponse
            {
                AccessToken = "access_token85826cd8",
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GenerateAccessToken(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            GenerateAccessTokenResponse response = client.GenerateAccessToken(request.Name, request.Delegates, request.Scope, request.Lifetime);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateAccessTokenAsync()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            GenerateAccessTokenRequest request = new GenerateAccessTokenRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Scope = { "scope14fda131", },
                Lifetime = new wkt::Duration(),
            };
            GenerateAccessTokenResponse expectedResponse = new GenerateAccessTokenResponse
            {
                AccessToken = "access_token85826cd8",
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GenerateAccessTokenAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateAccessTokenResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            GenerateAccessTokenResponse responseCallSettings = await client.GenerateAccessTokenAsync(request.Name, request.Delegates, request.Scope, request.Lifetime, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateAccessTokenResponse responseCancellationToken = await client.GenerateAccessTokenAsync(request.Name, request.Delegates, request.Scope, request.Lifetime, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateAccessTokenResourceNames()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            GenerateAccessTokenRequest request = new GenerateAccessTokenRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Scope = { "scope14fda131", },
                Lifetime = new wkt::Duration(),
            };
            GenerateAccessTokenResponse expectedResponse = new GenerateAccessTokenResponse
            {
                AccessToken = "access_token85826cd8",
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GenerateAccessToken(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            GenerateAccessTokenResponse response = client.GenerateAccessToken(request.ServiceAccountName, request.Delegates, request.Scope, request.Lifetime);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateAccessTokenResourceNamesAsync()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            GenerateAccessTokenRequest request = new GenerateAccessTokenRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Scope = { "scope14fda131", },
                Lifetime = new wkt::Duration(),
            };
            GenerateAccessTokenResponse expectedResponse = new GenerateAccessTokenResponse
            {
                AccessToken = "access_token85826cd8",
                ExpireTime = new wkt::Timestamp(),
            };
            mockGrpcClient.Setup(x => x.GenerateAccessTokenAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateAccessTokenResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            GenerateAccessTokenResponse responseCallSettings = await client.GenerateAccessTokenAsync(request.ServiceAccountName, request.Delegates, request.Scope, request.Lifetime, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateAccessTokenResponse responseCancellationToken = await client.GenerateAccessTokenAsync(request.ServiceAccountName, request.Delegates, request.Scope, request.Lifetime, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateIdTokenRequestObject()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            GenerateIdTokenRequest request = new GenerateIdTokenRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Audience = "audience986f1fe3",
                IncludeEmail = false,
            };
            GenerateIdTokenResponse expectedResponse = new GenerateIdTokenResponse
            {
                Token = "tokena18da094",
            };
            mockGrpcClient.Setup(x => x.GenerateIdToken(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            GenerateIdTokenResponse response = client.GenerateIdToken(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateIdTokenRequestObjectAsync()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            GenerateIdTokenRequest request = new GenerateIdTokenRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Audience = "audience986f1fe3",
                IncludeEmail = false,
            };
            GenerateIdTokenResponse expectedResponse = new GenerateIdTokenResponse
            {
                Token = "tokena18da094",
            };
            mockGrpcClient.Setup(x => x.GenerateIdTokenAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateIdTokenResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            GenerateIdTokenResponse responseCallSettings = await client.GenerateIdTokenAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateIdTokenResponse responseCancellationToken = await client.GenerateIdTokenAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateIdToken()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            GenerateIdTokenRequest request = new GenerateIdTokenRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Audience = "audience986f1fe3",
                IncludeEmail = false,
            };
            GenerateIdTokenResponse expectedResponse = new GenerateIdTokenResponse
            {
                Token = "tokena18da094",
            };
            mockGrpcClient.Setup(x => x.GenerateIdToken(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            GenerateIdTokenResponse response = client.GenerateIdToken(request.Name, request.Delegates, request.Audience, request.IncludeEmail);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateIdTokenAsync()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            GenerateIdTokenRequest request = new GenerateIdTokenRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Audience = "audience986f1fe3",
                IncludeEmail = false,
            };
            GenerateIdTokenResponse expectedResponse = new GenerateIdTokenResponse
            {
                Token = "tokena18da094",
            };
            mockGrpcClient.Setup(x => x.GenerateIdTokenAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateIdTokenResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            GenerateIdTokenResponse responseCallSettings = await client.GenerateIdTokenAsync(request.Name, request.Delegates, request.Audience, request.IncludeEmail, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateIdTokenResponse responseCancellationToken = await client.GenerateIdTokenAsync(request.Name, request.Delegates, request.Audience, request.IncludeEmail, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GenerateIdTokenResourceNames()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            GenerateIdTokenRequest request = new GenerateIdTokenRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Audience = "audience986f1fe3",
                IncludeEmail = false,
            };
            GenerateIdTokenResponse expectedResponse = new GenerateIdTokenResponse
            {
                Token = "tokena18da094",
            };
            mockGrpcClient.Setup(x => x.GenerateIdToken(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            GenerateIdTokenResponse response = client.GenerateIdToken(request.ServiceAccountName, request.Delegates, request.Audience, request.IncludeEmail);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GenerateIdTokenResourceNamesAsync()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            GenerateIdTokenRequest request = new GenerateIdTokenRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Audience = "audience986f1fe3",
                IncludeEmail = false,
            };
            GenerateIdTokenResponse expectedResponse = new GenerateIdTokenResponse
            {
                Token = "tokena18da094",
            };
            mockGrpcClient.Setup(x => x.GenerateIdTokenAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<GenerateIdTokenResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            GenerateIdTokenResponse responseCallSettings = await client.GenerateIdTokenAsync(request.ServiceAccountName, request.Delegates, request.Audience, request.IncludeEmail, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            GenerateIdTokenResponse responseCancellationToken = await client.GenerateIdTokenAsync(request.ServiceAccountName, request.Delegates, request.Audience, request.IncludeEmail, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SignBlobRequestObject()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            SignBlobRequest request = new SignBlobRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
            };
            SignBlobResponse expectedResponse = new SignBlobResponse
            {
                KeyId = "key_id2691f630",
                SignedBlob = proto::ByteString.CopyFromUtf8("signed_blob0afddec9"),
            };
            mockGrpcClient.Setup(x => x.SignBlob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            SignBlobResponse response = client.SignBlob(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SignBlobRequestObjectAsync()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            SignBlobRequest request = new SignBlobRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
            };
            SignBlobResponse expectedResponse = new SignBlobResponse
            {
                KeyId = "key_id2691f630",
                SignedBlob = proto::ByteString.CopyFromUtf8("signed_blob0afddec9"),
            };
            mockGrpcClient.Setup(x => x.SignBlobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SignBlobResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            SignBlobResponse responseCallSettings = await client.SignBlobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SignBlobResponse responseCancellationToken = await client.SignBlobAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SignBlob()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            SignBlobRequest request = new SignBlobRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
            };
            SignBlobResponse expectedResponse = new SignBlobResponse
            {
                KeyId = "key_id2691f630",
                SignedBlob = proto::ByteString.CopyFromUtf8("signed_blob0afddec9"),
            };
            mockGrpcClient.Setup(x => x.SignBlob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            SignBlobResponse response = client.SignBlob(request.Name, request.Delegates, request.Payload);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SignBlobAsync()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            SignBlobRequest request = new SignBlobRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
            };
            SignBlobResponse expectedResponse = new SignBlobResponse
            {
                KeyId = "key_id2691f630",
                SignedBlob = proto::ByteString.CopyFromUtf8("signed_blob0afddec9"),
            };
            mockGrpcClient.Setup(x => x.SignBlobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SignBlobResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            SignBlobResponse responseCallSettings = await client.SignBlobAsync(request.Name, request.Delegates, request.Payload, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SignBlobResponse responseCancellationToken = await client.SignBlobAsync(request.Name, request.Delegates, request.Payload, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SignBlobResourceNames()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            SignBlobRequest request = new SignBlobRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
            };
            SignBlobResponse expectedResponse = new SignBlobResponse
            {
                KeyId = "key_id2691f630",
                SignedBlob = proto::ByteString.CopyFromUtf8("signed_blob0afddec9"),
            };
            mockGrpcClient.Setup(x => x.SignBlob(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            SignBlobResponse response = client.SignBlob(request.ServiceAccountName, request.Delegates, request.Payload);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SignBlobResourceNamesAsync()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            SignBlobRequest request = new SignBlobRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Payload = proto::ByteString.CopyFromUtf8("payloadf43c1c32"),
            };
            SignBlobResponse expectedResponse = new SignBlobResponse
            {
                KeyId = "key_id2691f630",
                SignedBlob = proto::ByteString.CopyFromUtf8("signed_blob0afddec9"),
            };
            mockGrpcClient.Setup(x => x.SignBlobAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SignBlobResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            SignBlobResponse responseCallSettings = await client.SignBlobAsync(request.ServiceAccountName, request.Delegates, request.Payload, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SignBlobResponse responseCancellationToken = await client.SignBlobAsync(request.ServiceAccountName, request.Delegates, request.Payload, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SignJwtRequestObject()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            SignJwtRequest request = new SignJwtRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Payload = "payloadf43c1c32",
            };
            SignJwtResponse expectedResponse = new SignJwtResponse
            {
                KeyId = "key_id2691f630",
                SignedJwt = "signed_jwt09d786db",
            };
            mockGrpcClient.Setup(x => x.SignJwt(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            SignJwtResponse response = client.SignJwt(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SignJwtRequestObjectAsync()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            SignJwtRequest request = new SignJwtRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Payload = "payloadf43c1c32",
            };
            SignJwtResponse expectedResponse = new SignJwtResponse
            {
                KeyId = "key_id2691f630",
                SignedJwt = "signed_jwt09d786db",
            };
            mockGrpcClient.Setup(x => x.SignJwtAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SignJwtResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            SignJwtResponse responseCallSettings = await client.SignJwtAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SignJwtResponse responseCancellationToken = await client.SignJwtAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SignJwt()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            SignJwtRequest request = new SignJwtRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Payload = "payloadf43c1c32",
            };
            SignJwtResponse expectedResponse = new SignJwtResponse
            {
                KeyId = "key_id2691f630",
                SignedJwt = "signed_jwt09d786db",
            };
            mockGrpcClient.Setup(x => x.SignJwt(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            SignJwtResponse response = client.SignJwt(request.Name, request.Delegates, request.Payload);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SignJwtAsync()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            SignJwtRequest request = new SignJwtRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Payload = "payloadf43c1c32",
            };
            SignJwtResponse expectedResponse = new SignJwtResponse
            {
                KeyId = "key_id2691f630",
                SignedJwt = "signed_jwt09d786db",
            };
            mockGrpcClient.Setup(x => x.SignJwtAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SignJwtResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            SignJwtResponse responseCallSettings = await client.SignJwtAsync(request.Name, request.Delegates, request.Payload, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SignJwtResponse responseCancellationToken = await client.SignJwtAsync(request.Name, request.Delegates, request.Payload, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void SignJwtResourceNames()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            SignJwtRequest request = new SignJwtRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Payload = "payloadf43c1c32",
            };
            SignJwtResponse expectedResponse = new SignJwtResponse
            {
                KeyId = "key_id2691f630",
                SignedJwt = "signed_jwt09d786db",
            };
            mockGrpcClient.Setup(x => x.SignJwt(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            SignJwtResponse response = client.SignJwt(request.ServiceAccountName, request.Delegates, request.Payload);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task SignJwtResourceNamesAsync()
        {
            moq::Mock<IAMCredentials.IAMCredentialsClient> mockGrpcClient = new moq::Mock<IAMCredentials.IAMCredentialsClient>(moq::MockBehavior.Strict);
            SignJwtRequest request = new SignJwtRequest
            {
                ServiceAccountName = ServiceAccountName.FromProjectServiceAccount("[PROJECT]", "[SERVICE_ACCOUNT]"),
                Delegates =
                {
                    "delegates331d18f6",
                },
                Payload = "payloadf43c1c32",
            };
            SignJwtResponse expectedResponse = new SignJwtResponse
            {
                KeyId = "key_id2691f630",
                SignedJwt = "signed_jwt09d786db",
            };
            mockGrpcClient.Setup(x => x.SignJwtAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SignJwtResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            IAMCredentialsClient client = new IAMCredentialsClientImpl(mockGrpcClient.Object, null, null);
            SignJwtResponse responseCallSettings = await client.SignJwtAsync(request.ServiceAccountName, request.Delegates, request.Payload, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SignJwtResponse responseCancellationToken = await client.SignJwtAsync(request.ServiceAccountName, request.Delegates, request.Payload, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
