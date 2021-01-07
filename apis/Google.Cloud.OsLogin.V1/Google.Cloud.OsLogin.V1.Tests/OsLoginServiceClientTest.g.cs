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
using gcoc = Google.Cloud.OsLogin.Common;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.OsLogin.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedOsLoginServiceClientTest
    {
        [xunit::FactAttribute]
        public void DeletePosixAccountRequestObject()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            DeletePosixAccountRequest request = new DeletePosixAccountRequest
            {
                PosixAccountName = gcoc::PosixAccountName.FromUserProject("[USER]", "[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePosixAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            client.DeletePosixAccount(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePosixAccountRequestObjectAsync()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            DeletePosixAccountRequest request = new DeletePosixAccountRequest
            {
                PosixAccountName = gcoc::PosixAccountName.FromUserProject("[USER]", "[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePosixAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeletePosixAccountAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePosixAccountAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePosixAccount()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            DeletePosixAccountRequest request = new DeletePosixAccountRequest
            {
                PosixAccountName = gcoc::PosixAccountName.FromUserProject("[USER]", "[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePosixAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            client.DeletePosixAccount(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePosixAccountAsync()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            DeletePosixAccountRequest request = new DeletePosixAccountRequest
            {
                PosixAccountName = gcoc::PosixAccountName.FromUserProject("[USER]", "[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePosixAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeletePosixAccountAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePosixAccountAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeletePosixAccountResourceNames()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            DeletePosixAccountRequest request = new DeletePosixAccountRequest
            {
                PosixAccountName = gcoc::PosixAccountName.FromUserProject("[USER]", "[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePosixAccount(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            client.DeletePosixAccount(request.PosixAccountName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeletePosixAccountResourceNamesAsync()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            DeletePosixAccountRequest request = new DeletePosixAccountRequest
            {
                PosixAccountName = gcoc::PosixAccountName.FromUserProject("[USER]", "[PROJECT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeletePosixAccountAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeletePosixAccountAsync(request.PosixAccountName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeletePosixAccountAsync(request.PosixAccountName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSshPublicKeyRequestObject()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            DeleteSshPublicKeyRequest request = new DeleteSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSshPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteSshPublicKey(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSshPublicKeyRequestObjectAsync()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            DeleteSshPublicKeyRequest request = new DeleteSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSshPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSshPublicKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSshPublicKeyAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSshPublicKey()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            DeleteSshPublicKeyRequest request = new DeleteSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSshPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteSshPublicKey(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSshPublicKeyAsync()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            DeleteSshPublicKeyRequest request = new DeleteSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSshPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSshPublicKeyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSshPublicKeyAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSshPublicKeyResourceNames()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            DeleteSshPublicKeyRequest request = new DeleteSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSshPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteSshPublicKey(request.SshPublicKeyName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSshPublicKeyResourceNamesAsync()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            DeleteSshPublicKeyRequest request = new DeleteSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSshPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSshPublicKeyAsync(request.SshPublicKeyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSshPublicKeyAsync(request.SshPublicKeyName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLoginProfileRequestObject()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            GetLoginProfileRequest request = new GetLoginProfileRequest
            {
                UserName = gcoc::UserName.FromUser("[USER]"),
                ProjectId = "project_id43ad98b0",
                SystemId = "system_id43548ac1",
            };
            LoginProfile expectedResponse = new LoginProfile
            {
                Name = "name1c9368b0",
                PosixAccounts =
                {
                    new gcoc::PosixAccount(),
                },
                SshPublicKeys =
                {
                    {
                        "key8a0b6e3c",
                        new gcoc::SshPublicKey()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetLoginProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            LoginProfile response = client.GetLoginProfile(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLoginProfileRequestObjectAsync()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            GetLoginProfileRequest request = new GetLoginProfileRequest
            {
                UserName = gcoc::UserName.FromUser("[USER]"),
                ProjectId = "project_id43ad98b0",
                SystemId = "system_id43548ac1",
            };
            LoginProfile expectedResponse = new LoginProfile
            {
                Name = "name1c9368b0",
                PosixAccounts =
                {
                    new gcoc::PosixAccount(),
                },
                SshPublicKeys =
                {
                    {
                        "key8a0b6e3c",
                        new gcoc::SshPublicKey()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetLoginProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LoginProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            LoginProfile responseCallSettings = await client.GetLoginProfileAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LoginProfile responseCancellationToken = await client.GetLoginProfileAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLoginProfile()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            GetLoginProfileRequest request = new GetLoginProfileRequest
            {
                UserName = gcoc::UserName.FromUser("[USER]"),
            };
            LoginProfile expectedResponse = new LoginProfile
            {
                Name = "name1c9368b0",
                PosixAccounts =
                {
                    new gcoc::PosixAccount(),
                },
                SshPublicKeys =
                {
                    {
                        "key8a0b6e3c",
                        new gcoc::SshPublicKey()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetLoginProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            LoginProfile response = client.GetLoginProfile(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLoginProfileAsync()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            GetLoginProfileRequest request = new GetLoginProfileRequest
            {
                UserName = gcoc::UserName.FromUser("[USER]"),
            };
            LoginProfile expectedResponse = new LoginProfile
            {
                Name = "name1c9368b0",
                PosixAccounts =
                {
                    new gcoc::PosixAccount(),
                },
                SshPublicKeys =
                {
                    {
                        "key8a0b6e3c",
                        new gcoc::SshPublicKey()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetLoginProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LoginProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            LoginProfile responseCallSettings = await client.GetLoginProfileAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LoginProfile responseCancellationToken = await client.GetLoginProfileAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetLoginProfileResourceNames()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            GetLoginProfileRequest request = new GetLoginProfileRequest
            {
                UserName = gcoc::UserName.FromUser("[USER]"),
            };
            LoginProfile expectedResponse = new LoginProfile
            {
                Name = "name1c9368b0",
                PosixAccounts =
                {
                    new gcoc::PosixAccount(),
                },
                SshPublicKeys =
                {
                    {
                        "key8a0b6e3c",
                        new gcoc::SshPublicKey()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetLoginProfile(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            LoginProfile response = client.GetLoginProfile(request.UserName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetLoginProfileResourceNamesAsync()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            GetLoginProfileRequest request = new GetLoginProfileRequest
            {
                UserName = gcoc::UserName.FromUser("[USER]"),
            };
            LoginProfile expectedResponse = new LoginProfile
            {
                Name = "name1c9368b0",
                PosixAccounts =
                {
                    new gcoc::PosixAccount(),
                },
                SshPublicKeys =
                {
                    {
                        "key8a0b6e3c",
                        new gcoc::SshPublicKey()
                    },
                },
            };
            mockGrpcClient.Setup(x => x.GetLoginProfileAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<LoginProfile>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            LoginProfile responseCallSettings = await client.GetLoginProfileAsync(request.UserName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            LoginProfile responseCancellationToken = await client.GetLoginProfileAsync(request.UserName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSshPublicKeyRequestObject()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            GetSshPublicKeyRequest request = new GetSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            gcoc::SshPublicKey expectedResponse = new gcoc::SshPublicKey
            {
                Key = "key8a0b6e3c",
                ExpirationTimeUsec = -3860803259883837145L,
                Fingerprint = "fingerprint009e6052",
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            mockGrpcClient.Setup(x => x.GetSshPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            gcoc::SshPublicKey response = client.GetSshPublicKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSshPublicKeyRequestObjectAsync()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            GetSshPublicKeyRequest request = new GetSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            gcoc::SshPublicKey expectedResponse = new gcoc::SshPublicKey
            {
                Key = "key8a0b6e3c",
                ExpirationTimeUsec = -3860803259883837145L,
                Fingerprint = "fingerprint009e6052",
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            mockGrpcClient.Setup(x => x.GetSshPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gcoc::SshPublicKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            gcoc::SshPublicKey responseCallSettings = await client.GetSshPublicKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gcoc::SshPublicKey responseCancellationToken = await client.GetSshPublicKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSshPublicKey()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            GetSshPublicKeyRequest request = new GetSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            gcoc::SshPublicKey expectedResponse = new gcoc::SshPublicKey
            {
                Key = "key8a0b6e3c",
                ExpirationTimeUsec = -3860803259883837145L,
                Fingerprint = "fingerprint009e6052",
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            mockGrpcClient.Setup(x => x.GetSshPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            gcoc::SshPublicKey response = client.GetSshPublicKey(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSshPublicKeyAsync()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            GetSshPublicKeyRequest request = new GetSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            gcoc::SshPublicKey expectedResponse = new gcoc::SshPublicKey
            {
                Key = "key8a0b6e3c",
                ExpirationTimeUsec = -3860803259883837145L,
                Fingerprint = "fingerprint009e6052",
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            mockGrpcClient.Setup(x => x.GetSshPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gcoc::SshPublicKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            gcoc::SshPublicKey responseCallSettings = await client.GetSshPublicKeyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gcoc::SshPublicKey responseCancellationToken = await client.GetSshPublicKeyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSshPublicKeyResourceNames()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            GetSshPublicKeyRequest request = new GetSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            gcoc::SshPublicKey expectedResponse = new gcoc::SshPublicKey
            {
                Key = "key8a0b6e3c",
                ExpirationTimeUsec = -3860803259883837145L,
                Fingerprint = "fingerprint009e6052",
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            mockGrpcClient.Setup(x => x.GetSshPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            gcoc::SshPublicKey response = client.GetSshPublicKey(request.SshPublicKeyName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSshPublicKeyResourceNamesAsync()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            GetSshPublicKeyRequest request = new GetSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            gcoc::SshPublicKey expectedResponse = new gcoc::SshPublicKey
            {
                Key = "key8a0b6e3c",
                ExpirationTimeUsec = -3860803259883837145L,
                Fingerprint = "fingerprint009e6052",
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            mockGrpcClient.Setup(x => x.GetSshPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gcoc::SshPublicKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            gcoc::SshPublicKey responseCallSettings = await client.GetSshPublicKeyAsync(request.SshPublicKeyName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gcoc::SshPublicKey responseCancellationToken = await client.GetSshPublicKeyAsync(request.SshPublicKeyName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ImportSshPublicKeyRequestObject()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            ImportSshPublicKeyRequest request = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = gcoc::UserName.FromUser("[USER]"),
                SshPublicKey = new gcoc::SshPublicKey(),
                ProjectId = "project_id43ad98b0",
            };
            ImportSshPublicKeyResponse expectedResponse = new ImportSshPublicKeyResponse
            {
                LoginProfile = new LoginProfile(),
            };
            mockGrpcClient.Setup(x => x.ImportSshPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            ImportSshPublicKeyResponse response = client.ImportSshPublicKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ImportSshPublicKeyRequestObjectAsync()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            ImportSshPublicKeyRequest request = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = gcoc::UserName.FromUser("[USER]"),
                SshPublicKey = new gcoc::SshPublicKey(),
                ProjectId = "project_id43ad98b0",
            };
            ImportSshPublicKeyResponse expectedResponse = new ImportSshPublicKeyResponse
            {
                LoginProfile = new LoginProfile(),
            };
            mockGrpcClient.Setup(x => x.ImportSshPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ImportSshPublicKeyResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            ImportSshPublicKeyResponse responseCallSettings = await client.ImportSshPublicKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ImportSshPublicKeyResponse responseCancellationToken = await client.ImportSshPublicKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ImportSshPublicKey1()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            ImportSshPublicKeyRequest request = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = gcoc::UserName.FromUser("[USER]"),
                SshPublicKey = new gcoc::SshPublicKey(),
            };
            ImportSshPublicKeyResponse expectedResponse = new ImportSshPublicKeyResponse
            {
                LoginProfile = new LoginProfile(),
            };
            mockGrpcClient.Setup(x => x.ImportSshPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            ImportSshPublicKeyResponse response = client.ImportSshPublicKey(request.Parent, request.SshPublicKey);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ImportSshPublicKey1Async()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            ImportSshPublicKeyRequest request = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = gcoc::UserName.FromUser("[USER]"),
                SshPublicKey = new gcoc::SshPublicKey(),
            };
            ImportSshPublicKeyResponse expectedResponse = new ImportSshPublicKeyResponse
            {
                LoginProfile = new LoginProfile(),
            };
            mockGrpcClient.Setup(x => x.ImportSshPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ImportSshPublicKeyResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            ImportSshPublicKeyResponse responseCallSettings = await client.ImportSshPublicKeyAsync(request.Parent, request.SshPublicKey, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ImportSshPublicKeyResponse responseCancellationToken = await client.ImportSshPublicKeyAsync(request.Parent, request.SshPublicKey, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ImportSshPublicKey1ResourceNames()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            ImportSshPublicKeyRequest request = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = gcoc::UserName.FromUser("[USER]"),
                SshPublicKey = new gcoc::SshPublicKey(),
            };
            ImportSshPublicKeyResponse expectedResponse = new ImportSshPublicKeyResponse
            {
                LoginProfile = new LoginProfile(),
            };
            mockGrpcClient.Setup(x => x.ImportSshPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            ImportSshPublicKeyResponse response = client.ImportSshPublicKey(request.ParentAsUserName, request.SshPublicKey);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ImportSshPublicKey1ResourceNamesAsync()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            ImportSshPublicKeyRequest request = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = gcoc::UserName.FromUser("[USER]"),
                SshPublicKey = new gcoc::SshPublicKey(),
            };
            ImportSshPublicKeyResponse expectedResponse = new ImportSshPublicKeyResponse
            {
                LoginProfile = new LoginProfile(),
            };
            mockGrpcClient.Setup(x => x.ImportSshPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ImportSshPublicKeyResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            ImportSshPublicKeyResponse responseCallSettings = await client.ImportSshPublicKeyAsync(request.ParentAsUserName, request.SshPublicKey, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ImportSshPublicKeyResponse responseCancellationToken = await client.ImportSshPublicKeyAsync(request.ParentAsUserName, request.SshPublicKey, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ImportSshPublicKey2()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            ImportSshPublicKeyRequest request = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = gcoc::UserName.FromUser("[USER]"),
                SshPublicKey = new gcoc::SshPublicKey(),
                ProjectId = "project_id43ad98b0",
            };
            ImportSshPublicKeyResponse expectedResponse = new ImportSshPublicKeyResponse
            {
                LoginProfile = new LoginProfile(),
            };
            mockGrpcClient.Setup(x => x.ImportSshPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            ImportSshPublicKeyResponse response = client.ImportSshPublicKey(request.Parent, request.SshPublicKey, request.ProjectId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ImportSshPublicKey2Async()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            ImportSshPublicKeyRequest request = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = gcoc::UserName.FromUser("[USER]"),
                SshPublicKey = new gcoc::SshPublicKey(),
                ProjectId = "project_id43ad98b0",
            };
            ImportSshPublicKeyResponse expectedResponse = new ImportSshPublicKeyResponse
            {
                LoginProfile = new LoginProfile(),
            };
            mockGrpcClient.Setup(x => x.ImportSshPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ImportSshPublicKeyResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            ImportSshPublicKeyResponse responseCallSettings = await client.ImportSshPublicKeyAsync(request.Parent, request.SshPublicKey, request.ProjectId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ImportSshPublicKeyResponse responseCancellationToken = await client.ImportSshPublicKeyAsync(request.Parent, request.SshPublicKey, request.ProjectId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ImportSshPublicKey2ResourceNames()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            ImportSshPublicKeyRequest request = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = gcoc::UserName.FromUser("[USER]"),
                SshPublicKey = new gcoc::SshPublicKey(),
                ProjectId = "project_id43ad98b0",
            };
            ImportSshPublicKeyResponse expectedResponse = new ImportSshPublicKeyResponse
            {
                LoginProfile = new LoginProfile(),
            };
            mockGrpcClient.Setup(x => x.ImportSshPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            ImportSshPublicKeyResponse response = client.ImportSshPublicKey(request.ParentAsUserName, request.SshPublicKey, request.ProjectId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ImportSshPublicKey2ResourceNamesAsync()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            ImportSshPublicKeyRequest request = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = gcoc::UserName.FromUser("[USER]"),
                SshPublicKey = new gcoc::SshPublicKey(),
                ProjectId = "project_id43ad98b0",
            };
            ImportSshPublicKeyResponse expectedResponse = new ImportSshPublicKeyResponse
            {
                LoginProfile = new LoginProfile(),
            };
            mockGrpcClient.Setup(x => x.ImportSshPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ImportSshPublicKeyResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            ImportSshPublicKeyResponse responseCallSettings = await client.ImportSshPublicKeyAsync(request.ParentAsUserName, request.SshPublicKey, request.ProjectId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ImportSshPublicKeyResponse responseCancellationToken = await client.ImportSshPublicKeyAsync(request.ParentAsUserName, request.SshPublicKey, request.ProjectId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSshPublicKeyRequestObject()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            UpdateSshPublicKeyRequest request = new UpdateSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new gcoc::SshPublicKey(),
                UpdateMask = new wkt::FieldMask(),
            };
            gcoc::SshPublicKey expectedResponse = new gcoc::SshPublicKey
            {
                Key = "key8a0b6e3c",
                ExpirationTimeUsec = -3860803259883837145L,
                Fingerprint = "fingerprint009e6052",
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSshPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            gcoc::SshPublicKey response = client.UpdateSshPublicKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSshPublicKeyRequestObjectAsync()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            UpdateSshPublicKeyRequest request = new UpdateSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new gcoc::SshPublicKey(),
                UpdateMask = new wkt::FieldMask(),
            };
            gcoc::SshPublicKey expectedResponse = new gcoc::SshPublicKey
            {
                Key = "key8a0b6e3c",
                ExpirationTimeUsec = -3860803259883837145L,
                Fingerprint = "fingerprint009e6052",
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSshPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gcoc::SshPublicKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            gcoc::SshPublicKey responseCallSettings = await client.UpdateSshPublicKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gcoc::SshPublicKey responseCancellationToken = await client.UpdateSshPublicKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSshPublicKey1()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            UpdateSshPublicKeyRequest request = new UpdateSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new gcoc::SshPublicKey(),
            };
            gcoc::SshPublicKey expectedResponse = new gcoc::SshPublicKey
            {
                Key = "key8a0b6e3c",
                ExpirationTimeUsec = -3860803259883837145L,
                Fingerprint = "fingerprint009e6052",
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSshPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            gcoc::SshPublicKey response = client.UpdateSshPublicKey(request.Name, request.SshPublicKey);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSshPublicKey1Async()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            UpdateSshPublicKeyRequest request = new UpdateSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new gcoc::SshPublicKey(),
            };
            gcoc::SshPublicKey expectedResponse = new gcoc::SshPublicKey
            {
                Key = "key8a0b6e3c",
                ExpirationTimeUsec = -3860803259883837145L,
                Fingerprint = "fingerprint009e6052",
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSshPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gcoc::SshPublicKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            gcoc::SshPublicKey responseCallSettings = await client.UpdateSshPublicKeyAsync(request.Name, request.SshPublicKey, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gcoc::SshPublicKey responseCancellationToken = await client.UpdateSshPublicKeyAsync(request.Name, request.SshPublicKey, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSshPublicKey1ResourceNames()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            UpdateSshPublicKeyRequest request = new UpdateSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new gcoc::SshPublicKey(),
            };
            gcoc::SshPublicKey expectedResponse = new gcoc::SshPublicKey
            {
                Key = "key8a0b6e3c",
                ExpirationTimeUsec = -3860803259883837145L,
                Fingerprint = "fingerprint009e6052",
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSshPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            gcoc::SshPublicKey response = client.UpdateSshPublicKey(request.SshPublicKeyName, request.SshPublicKey);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSshPublicKey1ResourceNamesAsync()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            UpdateSshPublicKeyRequest request = new UpdateSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new gcoc::SshPublicKey(),
            };
            gcoc::SshPublicKey expectedResponse = new gcoc::SshPublicKey
            {
                Key = "key8a0b6e3c",
                ExpirationTimeUsec = -3860803259883837145L,
                Fingerprint = "fingerprint009e6052",
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSshPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gcoc::SshPublicKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            gcoc::SshPublicKey responseCallSettings = await client.UpdateSshPublicKeyAsync(request.SshPublicKeyName, request.SshPublicKey, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gcoc::SshPublicKey responseCancellationToken = await client.UpdateSshPublicKeyAsync(request.SshPublicKeyName, request.SshPublicKey, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSshPublicKey2()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            UpdateSshPublicKeyRequest request = new UpdateSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new gcoc::SshPublicKey(),
                UpdateMask = new wkt::FieldMask(),
            };
            gcoc::SshPublicKey expectedResponse = new gcoc::SshPublicKey
            {
                Key = "key8a0b6e3c",
                ExpirationTimeUsec = -3860803259883837145L,
                Fingerprint = "fingerprint009e6052",
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSshPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            gcoc::SshPublicKey response = client.UpdateSshPublicKey(request.Name, request.SshPublicKey, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSshPublicKey2Async()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            UpdateSshPublicKeyRequest request = new UpdateSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new gcoc::SshPublicKey(),
                UpdateMask = new wkt::FieldMask(),
            };
            gcoc::SshPublicKey expectedResponse = new gcoc::SshPublicKey
            {
                Key = "key8a0b6e3c",
                ExpirationTimeUsec = -3860803259883837145L,
                Fingerprint = "fingerprint009e6052",
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSshPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gcoc::SshPublicKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            gcoc::SshPublicKey responseCallSettings = await client.UpdateSshPublicKeyAsync(request.Name, request.SshPublicKey, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gcoc::SshPublicKey responseCancellationToken = await client.UpdateSshPublicKeyAsync(request.Name, request.SshPublicKey, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSshPublicKey2ResourceNames()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            UpdateSshPublicKeyRequest request = new UpdateSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new gcoc::SshPublicKey(),
                UpdateMask = new wkt::FieldMask(),
            };
            gcoc::SshPublicKey expectedResponse = new gcoc::SshPublicKey
            {
                Key = "key8a0b6e3c",
                ExpirationTimeUsec = -3860803259883837145L,
                Fingerprint = "fingerprint009e6052",
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSshPublicKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            gcoc::SshPublicKey response = client.UpdateSshPublicKey(request.SshPublicKeyName, request.SshPublicKey, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSshPublicKey2ResourceNamesAsync()
        {
            moq::Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new moq::Mock<OsLoginService.OsLoginServiceClient>(moq::MockBehavior.Strict);
            UpdateSshPublicKeyRequest request = new UpdateSshPublicKeyRequest
            {
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new gcoc::SshPublicKey(),
                UpdateMask = new wkt::FieldMask(),
            };
            gcoc::SshPublicKey expectedResponse = new gcoc::SshPublicKey
            {
                Key = "key8a0b6e3c",
                ExpirationTimeUsec = -3860803259883837145L,
                Fingerprint = "fingerprint009e6052",
                SshPublicKeyName = gcoc::SshPublicKeyName.FromUserFingerprint("[USER]", "[FINGERPRINT]"),
            };
            mockGrpcClient.Setup(x => x.UpdateSshPublicKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gcoc::SshPublicKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            gcoc::SshPublicKey responseCallSettings = await client.UpdateSshPublicKeyAsync(request.SshPublicKeyName, request.SshPublicKey, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            gcoc::SshPublicKey responseCancellationToken = await client.UpdateSshPublicKeyAsync(request.SshPublicKeyName, request.SshPublicKey, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
