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

namespace Google.Cloud.OsLogin.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Cloud.OsLogin.Common;
    using apis = Google.Cloud.OsLogin.V1;
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
    public class GeneratedOsLoginServiceClientTest
    {
        [Fact]
        public void DeletePosixAccount()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            DeletePosixAccountRequest expectedRequest = new DeletePosixAccountRequest
            {
                ProjectName = new ProjectName("[USER]", "[PROJECT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeletePosixAccount(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[USER]", "[PROJECT]");
            client.DeletePosixAccount(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeletePosixAccountAsync()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            DeletePosixAccountRequest expectedRequest = new DeletePosixAccountRequest
            {
                ProjectName = new ProjectName("[USER]", "[PROJECT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeletePosixAccountAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[USER]", "[PROJECT]");
            await client.DeletePosixAccountAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeletePosixAccount2()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            DeletePosixAccountRequest request = new DeletePosixAccountRequest
            {
                ProjectName = new ProjectName("[USER]", "[PROJECT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeletePosixAccount(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            client.DeletePosixAccount(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeletePosixAccountAsync2()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            DeletePosixAccountRequest request = new DeletePosixAccountRequest
            {
                ProjectName = new ProjectName("[USER]", "[PROJECT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeletePosixAccountAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeletePosixAccountAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSshPublicKey()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            DeleteSshPublicKeyRequest expectedRequest = new DeleteSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSshPublicKey(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            client.DeleteSshPublicKey(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSshPublicKeyAsync()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            DeleteSshPublicKeyRequest expectedRequest = new DeleteSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSshPublicKeyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            await client.DeleteSshPublicKeyAsync(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSshPublicKey2()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            DeleteSshPublicKeyRequest request = new DeleteSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSshPublicKey(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteSshPublicKey(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteSshPublicKeyAsync2()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            DeleteSshPublicKeyRequest request = new DeleteSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteSshPublicKeyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteSshPublicKeyAsync(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetLoginProfile()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            GetLoginProfileRequest expectedRequest = new GetLoginProfileRequest
            {
                UserName = new UserName("[USER]"),
            };
            LoginProfile expectedResponse = new LoginProfile
            {
                Name = "name2-1052831874",
                Suspended = false,
            };
            mockGrpcClient.Setup(x => x.GetLoginProfile(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            UserName name = new UserName("[USER]");
            LoginProfile response = client.GetLoginProfile(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetLoginProfileAsync()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            GetLoginProfileRequest expectedRequest = new GetLoginProfileRequest
            {
                UserName = new UserName("[USER]"),
            };
            LoginProfile expectedResponse = new LoginProfile
            {
                Name = "name2-1052831874",
                Suspended = false,
            };
            mockGrpcClient.Setup(x => x.GetLoginProfileAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LoginProfile>(Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            UserName name = new UserName("[USER]");
            LoginProfile response = await client.GetLoginProfileAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetLoginProfile2()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            GetLoginProfileRequest request = new GetLoginProfileRequest
            {
                UserName = new UserName("[USER]"),
            };
            LoginProfile expectedResponse = new LoginProfile
            {
                Name = "name2-1052831874",
                Suspended = false,
            };
            mockGrpcClient.Setup(x => x.GetLoginProfile(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            LoginProfile response = client.GetLoginProfile(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetLoginProfileAsync2()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            GetLoginProfileRequest request = new GetLoginProfileRequest
            {
                UserName = new UserName("[USER]"),
            };
            LoginProfile expectedResponse = new LoginProfile
            {
                Name = "name2-1052831874",
                Suspended = false,
            };
            mockGrpcClient.Setup(x => x.GetLoginProfileAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<LoginProfile>(Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            LoginProfile response = await client.GetLoginProfileAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSshPublicKey()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            GetSshPublicKeyRequest expectedRequest = new GetSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
            };
            SshPublicKey expectedResponse = new SshPublicKey
            {
                Key = "key106079",
                ExpirationTimeUsec = 2058878882L,
                Fingerprint = "fingerprint-1375934236",
            };
            mockGrpcClient.Setup(x => x.GetSshPublicKey(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            SshPublicKey response = client.GetSshPublicKey(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSshPublicKeyAsync()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            GetSshPublicKeyRequest expectedRequest = new GetSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
            };
            SshPublicKey expectedResponse = new SshPublicKey
            {
                Key = "key106079",
                ExpirationTimeUsec = 2058878882L,
                Fingerprint = "fingerprint-1375934236",
            };
            mockGrpcClient.Setup(x => x.GetSshPublicKeyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SshPublicKey>(Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            SshPublicKey response = await client.GetSshPublicKeyAsync(name);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSshPublicKey2()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            GetSshPublicKeyRequest request = new GetSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
            };
            SshPublicKey expectedResponse = new SshPublicKey
            {
                Key = "key106079",
                ExpirationTimeUsec = 2058878882L,
                Fingerprint = "fingerprint-1375934236",
            };
            mockGrpcClient.Setup(x => x.GetSshPublicKey(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            SshPublicKey response = client.GetSshPublicKey(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetSshPublicKeyAsync2()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            GetSshPublicKeyRequest request = new GetSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
            };
            SshPublicKey expectedResponse = new SshPublicKey
            {
                Key = "key106079",
                ExpirationTimeUsec = 2058878882L,
                Fingerprint = "fingerprint-1375934236",
            };
            mockGrpcClient.Setup(x => x.GetSshPublicKeyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SshPublicKey>(Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            SshPublicKey response = await client.GetSshPublicKeyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ImportSshPublicKey()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            ImportSshPublicKeyRequest expectedRequest = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = new UserName("[USER]"),
                SshPublicKey = new SshPublicKey(),
            };
            ImportSshPublicKeyResponse expectedResponse = new ImportSshPublicKeyResponse();
            mockGrpcClient.Setup(x => x.ImportSshPublicKey(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            UserName parent = new UserName("[USER]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            ImportSshPublicKeyResponse response = client.ImportSshPublicKey(parent, sshPublicKey);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ImportSshPublicKeyAsync()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            ImportSshPublicKeyRequest expectedRequest = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = new UserName("[USER]"),
                SshPublicKey = new SshPublicKey(),
            };
            ImportSshPublicKeyResponse expectedResponse = new ImportSshPublicKeyResponse();
            mockGrpcClient.Setup(x => x.ImportSshPublicKeyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ImportSshPublicKeyResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            UserName parent = new UserName("[USER]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            ImportSshPublicKeyResponse response = await client.ImportSshPublicKeyAsync(parent, sshPublicKey);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ImportSshPublicKey2()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            ImportSshPublicKeyRequest expectedRequest = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = new UserName("[USER]"),
                SshPublicKey = new SshPublicKey(),
                ProjectId = "projectId-1969970175",
            };
            ImportSshPublicKeyResponse expectedResponse = new ImportSshPublicKeyResponse();
            mockGrpcClient.Setup(x => x.ImportSshPublicKey(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            UserName parent = new UserName("[USER]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            string projectId = "projectId-1969970175";
            ImportSshPublicKeyResponse response = client.ImportSshPublicKey(parent, sshPublicKey, projectId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ImportSshPublicKeyAsync2()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            ImportSshPublicKeyRequest expectedRequest = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = new UserName("[USER]"),
                SshPublicKey = new SshPublicKey(),
                ProjectId = "projectId-1969970175",
            };
            ImportSshPublicKeyResponse expectedResponse = new ImportSshPublicKeyResponse();
            mockGrpcClient.Setup(x => x.ImportSshPublicKeyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ImportSshPublicKeyResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            UserName parent = new UserName("[USER]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            string projectId = "projectId-1969970175";
            ImportSshPublicKeyResponse response = await client.ImportSshPublicKeyAsync(parent, sshPublicKey, projectId);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ImportSshPublicKey3()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            ImportSshPublicKeyRequest request = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = new UserName("[USER]"),
                SshPublicKey = new SshPublicKey(),
            };
            ImportSshPublicKeyResponse expectedResponse = new ImportSshPublicKeyResponse();
            mockGrpcClient.Setup(x => x.ImportSshPublicKey(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            ImportSshPublicKeyResponse response = client.ImportSshPublicKey(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ImportSshPublicKeyAsync3()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            ImportSshPublicKeyRequest request = new ImportSshPublicKeyRequest
            {
                ParentAsUserName = new UserName("[USER]"),
                SshPublicKey = new SshPublicKey(),
            };
            ImportSshPublicKeyResponse expectedResponse = new ImportSshPublicKeyResponse();
            mockGrpcClient.Setup(x => x.ImportSshPublicKeyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ImportSshPublicKeyResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            ImportSshPublicKeyResponse response = await client.ImportSshPublicKeyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSshPublicKey()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            UpdateSshPublicKeyRequest expectedRequest = new UpdateSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new SshPublicKey(),
            };
            SshPublicKey expectedResponse = new SshPublicKey
            {
                Key = "key106079",
                ExpirationTimeUsec = 2058878882L,
                Fingerprint = "fingerprint-1375934236",
            };
            mockGrpcClient.Setup(x => x.UpdateSshPublicKey(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            SshPublicKey response = client.UpdateSshPublicKey(name, sshPublicKey);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSshPublicKeyAsync()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            UpdateSshPublicKeyRequest expectedRequest = new UpdateSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new SshPublicKey(),
            };
            SshPublicKey expectedResponse = new SshPublicKey
            {
                Key = "key106079",
                ExpirationTimeUsec = 2058878882L,
                Fingerprint = "fingerprint-1375934236",
            };
            mockGrpcClient.Setup(x => x.UpdateSshPublicKeyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SshPublicKey>(Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            SshPublicKey response = await client.UpdateSshPublicKeyAsync(name, sshPublicKey);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSshPublicKey2()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            UpdateSshPublicKeyRequest expectedRequest = new UpdateSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new SshPublicKey(),
                UpdateMask = new FieldMask(),
            };
            SshPublicKey expectedResponse = new SshPublicKey
            {
                Key = "key106079",
                ExpirationTimeUsec = 2058878882L,
                Fingerprint = "fingerprint-1375934236",
            };
            mockGrpcClient.Setup(x => x.UpdateSshPublicKey(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            FieldMask updateMask = new FieldMask();
            SshPublicKey response = client.UpdateSshPublicKey(name, sshPublicKey, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSshPublicKeyAsync2()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            UpdateSshPublicKeyRequest expectedRequest = new UpdateSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new SshPublicKey(),
                UpdateMask = new FieldMask(),
            };
            SshPublicKey expectedResponse = new SshPublicKey
            {
                Key = "key106079",
                ExpirationTimeUsec = 2058878882L,
                Fingerprint = "fingerprint-1375934236",
            };
            mockGrpcClient.Setup(x => x.UpdateSshPublicKeyAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SshPublicKey>(Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            FieldMask updateMask = new FieldMask();
            SshPublicKey response = await client.UpdateSshPublicKeyAsync(name, sshPublicKey, updateMask);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSshPublicKey3()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            UpdateSshPublicKeyRequest request = new UpdateSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new SshPublicKey(),
            };
            SshPublicKey expectedResponse = new SshPublicKey
            {
                Key = "key106079",
                ExpirationTimeUsec = 2058878882L,
                Fingerprint = "fingerprint-1375934236",
            };
            mockGrpcClient.Setup(x => x.UpdateSshPublicKey(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            SshPublicKey response = client.UpdateSshPublicKey(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateSshPublicKeyAsync3()
        {
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient>(MockBehavior.Strict);
            UpdateSshPublicKeyRequest request = new UpdateSshPublicKeyRequest
            {
                FingerprintName = new FingerprintName("[USER]", "[FINGERPRINT]"),
                SshPublicKey = new SshPublicKey(),
            };
            SshPublicKey expectedResponse = new SshPublicKey
            {
                Key = "key106079",
                ExpirationTimeUsec = 2058878882L,
                Fingerprint = "fingerprint-1375934236",
            };
            mockGrpcClient.Setup(x => x.UpdateSshPublicKeyAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SshPublicKey>(Task.FromResult(expectedResponse), null, null, null, null));
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            SshPublicKey response = await client.UpdateSshPublicKeyAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
