// Copyright 2018 Google LLC
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

using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Cloud.OsLogin.Common;
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

namespace Google.Cloud.OsLogin.V1Beta.UnitTests
{
    /// <summary>Generated unit tests</summary>
    public class GeneratedOsLoginServiceClientTest
    {
        [Fact]
        public void DeletePosixAccountTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeletePosixAccount(It.IsAny<DeletePosixAccountRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName name = new ProjectName("[USER]", "[PROJECT]");
            client.DeletePosixAccount(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteSshPublicKeyTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient> { DefaultValue = DefaultValue.Mock };
            Empty expectedResponse = new Empty();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.DeleteSshPublicKey(It.IsAny<DeleteSshPublicKeyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            client.DeleteSshPublicKey(name);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetLoginProfileTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient> { DefaultValue = DefaultValue.Mock };
            LoginProfile expectedResponse = new LoginProfile
            {
                Name = "name2-1052831874",
                Suspended = false,
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetLoginProfile(It.IsAny<GetLoginProfileRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            UserName name = new UserName("[USER]");
            LoginProfile response = client.GetLoginProfile(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetSshPublicKeyTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient> { DefaultValue = DefaultValue.Mock };
            SshPublicKey expectedResponse = new SshPublicKey
            {
                Key = "key106079",
                ExpirationTimeUsec = 2058878882L,
                Fingerprint = "fingerprint-1375934236",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.GetSshPublicKey(It.IsAny<GetSshPublicKeyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            SshPublicKey response = client.GetSshPublicKey(name);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ImportSshPublicKeyTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient> { DefaultValue = DefaultValue.Mock };
            ImportSshPublicKeyResponse expectedResponse = new ImportSshPublicKeyResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ImportSshPublicKey(It.IsAny<ImportSshPublicKeyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            UserName parent = new UserName("[USER]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            ImportSshPublicKeyResponse response = client.ImportSshPublicKey(parent, sshPublicKey);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ImportSshPublicKeyTest2()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient> { DefaultValue = DefaultValue.Mock };
            ImportSshPublicKeyResponse expectedResponse = new ImportSshPublicKeyResponse();
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.ImportSshPublicKey(It.IsAny<ImportSshPublicKeyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            UserName parent = new UserName("[USER]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            string projectId = "projectId-1969970175";
            ImportSshPublicKeyResponse response = client.ImportSshPublicKey(parent, sshPublicKey, projectId);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSshPublicKeyTest()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient> { DefaultValue = DefaultValue.Mock };
            SshPublicKey expectedResponse = new SshPublicKey
            {
                Key = "key106079",
                ExpirationTimeUsec = 2058878882L,
                Fingerprint = "fingerprint-1375934236",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.UpdateSshPublicKey(It.IsAny<UpdateSshPublicKeyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            SshPublicKey response = client.UpdateSshPublicKey(name, sshPublicKey);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateSshPublicKeyTest2()
        {
            // TODO: Use a strict mock; need to handle getRerouteToGrpcInterface
            Mock<OsLoginService.OsLoginServiceClient> mockGrpcClient = new Mock<OsLoginService.OsLoginServiceClient> { DefaultValue = DefaultValue.Mock };
            SshPublicKey expectedResponse = new SshPublicKey
            {
                Key = "key106079",
                ExpirationTimeUsec = 2058878882L,
                Fingerprint = "fingerprint-1375934236",
            };
            // TODO: Add verification of request object
            mockGrpcClient.Setup(x => x.UpdateSshPublicKey(It.IsAny<UpdateSshPublicKeyRequest>(), It.IsAny<CallOptions>())).Returns(expectedResponse);
            OsLoginServiceClient client = new OsLoginServiceClientImpl(mockGrpcClient.Object, null);
            FingerprintName name = new FingerprintName("[USER]", "[FINGERPRINT]");
            SshPublicKey sshPublicKey = new SshPublicKey();
            FieldMask updateMask = new FieldMask();
            SshPublicKey response = client.UpdateSshPublicKey(name, sshPublicKey, updateMask);
            Assert.Equal(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
