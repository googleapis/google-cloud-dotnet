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

#pragma warning disable CS8981
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Security.PublicCA.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPublicCertificateAuthorityServiceClientTest
    {
        [xunit::FactAttribute]
        public void CreateExternalAccountKeyRequestObject()
        {
            moq::Mock<PublicCertificateAuthorityService.PublicCertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<PublicCertificateAuthorityService.PublicCertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            CreateExternalAccountKeyRequest request = new CreateExternalAccountKeyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExternalAccountKey = new ExternalAccountKey(),
            };
            ExternalAccountKey expectedResponse = new ExternalAccountKey
            {
                ExternalAccountKeyName = ExternalAccountKeyName.FromProjectLocationExternalAccountKey("[PROJECT]", "[LOCATION]", "[EXTERNAL_ACCOUNT_KEY]"),
                KeyId = "key_id2691f630",
                B64MacKey = proto::ByteString.CopyFromUtf8("b64_mac_key40b0d3fa"),
            };
            mockGrpcClient.Setup(x => x.CreateExternalAccountKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublicCertificateAuthorityServiceClient client = new PublicCertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            ExternalAccountKey response = client.CreateExternalAccountKey(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExternalAccountKeyRequestObjectAsync()
        {
            moq::Mock<PublicCertificateAuthorityService.PublicCertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<PublicCertificateAuthorityService.PublicCertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            CreateExternalAccountKeyRequest request = new CreateExternalAccountKeyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExternalAccountKey = new ExternalAccountKey(),
            };
            ExternalAccountKey expectedResponse = new ExternalAccountKey
            {
                ExternalAccountKeyName = ExternalAccountKeyName.FromProjectLocationExternalAccountKey("[PROJECT]", "[LOCATION]", "[EXTERNAL_ACCOUNT_KEY]"),
                KeyId = "key_id2691f630",
                B64MacKey = proto::ByteString.CopyFromUtf8("b64_mac_key40b0d3fa"),
            };
            mockGrpcClient.Setup(x => x.CreateExternalAccountKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ExternalAccountKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublicCertificateAuthorityServiceClient client = new PublicCertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            ExternalAccountKey responseCallSettings = await client.CreateExternalAccountKeyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ExternalAccountKey responseCancellationToken = await client.CreateExternalAccountKeyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExternalAccountKey()
        {
            moq::Mock<PublicCertificateAuthorityService.PublicCertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<PublicCertificateAuthorityService.PublicCertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            CreateExternalAccountKeyRequest request = new CreateExternalAccountKeyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExternalAccountKey = new ExternalAccountKey(),
            };
            ExternalAccountKey expectedResponse = new ExternalAccountKey
            {
                ExternalAccountKeyName = ExternalAccountKeyName.FromProjectLocationExternalAccountKey("[PROJECT]", "[LOCATION]", "[EXTERNAL_ACCOUNT_KEY]"),
                KeyId = "key_id2691f630",
                B64MacKey = proto::ByteString.CopyFromUtf8("b64_mac_key40b0d3fa"),
            };
            mockGrpcClient.Setup(x => x.CreateExternalAccountKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublicCertificateAuthorityServiceClient client = new PublicCertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            ExternalAccountKey response = client.CreateExternalAccountKey(request.Parent, request.ExternalAccountKey);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExternalAccountKeyAsync()
        {
            moq::Mock<PublicCertificateAuthorityService.PublicCertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<PublicCertificateAuthorityService.PublicCertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            CreateExternalAccountKeyRequest request = new CreateExternalAccountKeyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExternalAccountKey = new ExternalAccountKey(),
            };
            ExternalAccountKey expectedResponse = new ExternalAccountKey
            {
                ExternalAccountKeyName = ExternalAccountKeyName.FromProjectLocationExternalAccountKey("[PROJECT]", "[LOCATION]", "[EXTERNAL_ACCOUNT_KEY]"),
                KeyId = "key_id2691f630",
                B64MacKey = proto::ByteString.CopyFromUtf8("b64_mac_key40b0d3fa"),
            };
            mockGrpcClient.Setup(x => x.CreateExternalAccountKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ExternalAccountKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublicCertificateAuthorityServiceClient client = new PublicCertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            ExternalAccountKey responseCallSettings = await client.CreateExternalAccountKeyAsync(request.Parent, request.ExternalAccountKey, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ExternalAccountKey responseCancellationToken = await client.CreateExternalAccountKeyAsync(request.Parent, request.ExternalAccountKey, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateExternalAccountKeyResourceNames()
        {
            moq::Mock<PublicCertificateAuthorityService.PublicCertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<PublicCertificateAuthorityService.PublicCertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            CreateExternalAccountKeyRequest request = new CreateExternalAccountKeyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExternalAccountKey = new ExternalAccountKey(),
            };
            ExternalAccountKey expectedResponse = new ExternalAccountKey
            {
                ExternalAccountKeyName = ExternalAccountKeyName.FromProjectLocationExternalAccountKey("[PROJECT]", "[LOCATION]", "[EXTERNAL_ACCOUNT_KEY]"),
                KeyId = "key_id2691f630",
                B64MacKey = proto::ByteString.CopyFromUtf8("b64_mac_key40b0d3fa"),
            };
            mockGrpcClient.Setup(x => x.CreateExternalAccountKey(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublicCertificateAuthorityServiceClient client = new PublicCertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            ExternalAccountKey response = client.CreateExternalAccountKey(request.ParentAsLocationName, request.ExternalAccountKey);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateExternalAccountKeyResourceNamesAsync()
        {
            moq::Mock<PublicCertificateAuthorityService.PublicCertificateAuthorityServiceClient> mockGrpcClient = new moq::Mock<PublicCertificateAuthorityService.PublicCertificateAuthorityServiceClient>(moq::MockBehavior.Strict);
            CreateExternalAccountKeyRequest request = new CreateExternalAccountKeyRequest
            {
                ParentAsLocationName = gagr::LocationName.FromProjectLocation("[PROJECT]", "[LOCATION]"),
                ExternalAccountKey = new ExternalAccountKey(),
            };
            ExternalAccountKey expectedResponse = new ExternalAccountKey
            {
                ExternalAccountKeyName = ExternalAccountKeyName.FromProjectLocationExternalAccountKey("[PROJECT]", "[LOCATION]", "[EXTERNAL_ACCOUNT_KEY]"),
                KeyId = "key_id2691f630",
                B64MacKey = proto::ByteString.CopyFromUtf8("b64_mac_key40b0d3fa"),
            };
            mockGrpcClient.Setup(x => x.CreateExternalAccountKeyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ExternalAccountKey>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublicCertificateAuthorityServiceClient client = new PublicCertificateAuthorityServiceClientImpl(mockGrpcClient.Object, null, null);
            ExternalAccountKey responseCallSettings = await client.CreateExternalAccountKeyAsync(request.ParentAsLocationName, request.ExternalAccountKey, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ExternalAccountKey responseCancellationToken = await client.CreateExternalAccountKeyAsync(request.ParentAsLocationName, request.ExternalAccountKey, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
