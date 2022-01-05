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
using gagr = Google.Api.Gax.ResourceNames;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.PhishingProtection.V1Beta1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPhishingProtectionServiceV1Beta1ClientTest
    {
        [xunit::FactAttribute]
        public void ReportPhishingRequestObject()
        {
            moq::Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client> mockGrpcClient = new moq::Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client>(moq::MockBehavior.Strict);
            ReportPhishingRequest request = new ReportPhishingRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Uri = "uri3db70593",
            };
            ReportPhishingResponse expectedResponse = new ReportPhishingResponse { };
            mockGrpcClient.Setup(x => x.ReportPhishing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhishingProtectionServiceV1Beta1Client client = new PhishingProtectionServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ReportPhishingResponse response = client.ReportPhishing(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReportPhishingRequestObjectAsync()
        {
            moq::Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client> mockGrpcClient = new moq::Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client>(moq::MockBehavior.Strict);
            ReportPhishingRequest request = new ReportPhishingRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Uri = "uri3db70593",
            };
            ReportPhishingResponse expectedResponse = new ReportPhishingResponse { };
            mockGrpcClient.Setup(x => x.ReportPhishingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReportPhishingResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhishingProtectionServiceV1Beta1Client client = new PhishingProtectionServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ReportPhishingResponse responseCallSettings = await client.ReportPhishingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReportPhishingResponse responseCancellationToken = await client.ReportPhishingAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReportPhishing()
        {
            moq::Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client> mockGrpcClient = new moq::Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client>(moq::MockBehavior.Strict);
            ReportPhishingRequest request = new ReportPhishingRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Uri = "uri3db70593",
            };
            ReportPhishingResponse expectedResponse = new ReportPhishingResponse { };
            mockGrpcClient.Setup(x => x.ReportPhishing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhishingProtectionServiceV1Beta1Client client = new PhishingProtectionServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ReportPhishingResponse response = client.ReportPhishing(request.Parent, request.Uri);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReportPhishingAsync()
        {
            moq::Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client> mockGrpcClient = new moq::Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client>(moq::MockBehavior.Strict);
            ReportPhishingRequest request = new ReportPhishingRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Uri = "uri3db70593",
            };
            ReportPhishingResponse expectedResponse = new ReportPhishingResponse { };
            mockGrpcClient.Setup(x => x.ReportPhishingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReportPhishingResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhishingProtectionServiceV1Beta1Client client = new PhishingProtectionServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ReportPhishingResponse responseCallSettings = await client.ReportPhishingAsync(request.Parent, request.Uri, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReportPhishingResponse responseCancellationToken = await client.ReportPhishingAsync(request.Parent, request.Uri, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ReportPhishingResourceNames()
        {
            moq::Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client> mockGrpcClient = new moq::Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client>(moq::MockBehavior.Strict);
            ReportPhishingRequest request = new ReportPhishingRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Uri = "uri3db70593",
            };
            ReportPhishingResponse expectedResponse = new ReportPhishingResponse { };
            mockGrpcClient.Setup(x => x.ReportPhishing(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PhishingProtectionServiceV1Beta1Client client = new PhishingProtectionServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ReportPhishingResponse response = client.ReportPhishing(request.ParentAsProjectName, request.Uri);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ReportPhishingResourceNamesAsync()
        {
            moq::Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client> mockGrpcClient = new moq::Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client>(moq::MockBehavior.Strict);
            ReportPhishingRequest request = new ReportPhishingRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                Uri = "uri3db70593",
            };
            ReportPhishingResponse expectedResponse = new ReportPhishingResponse { };
            mockGrpcClient.Setup(x => x.ReportPhishingAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ReportPhishingResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PhishingProtectionServiceV1Beta1Client client = new PhishingProtectionServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ReportPhishingResponse responseCallSettings = await client.ReportPhishingAsync(request.ParentAsProjectName, request.Uri, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ReportPhishingResponse responseCancellationToken = await client.ReportPhishingAsync(request.ParentAsProjectName, request.Uri, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
