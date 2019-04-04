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

namespace Google.Cloud.PhishingProtection.V1Beta1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using apis = Google.Cloud.PhishingProtection.V1Beta1;
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
    public class GeneratedPhishingProtectionServiceV1Beta1ClientTest
    {
        [Fact]
        public void ReportPhishing()
        {
            Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client> mockGrpcClient = new Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client>(MockBehavior.Strict);
            ReportPhishingRequest expectedRequest = new ReportPhishingRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Uri = "uri116076",
            };
            ReportPhishingResponse expectedResponse = new ReportPhishingResponse();
            mockGrpcClient.Setup(x => x.ReportPhishing(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            PhishingProtectionServiceV1Beta1Client client = new PhishingProtectionServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            string uri = "uri116076";
            ReportPhishingResponse response = client.ReportPhishing(parent, uri);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ReportPhishingAsync()
        {
            Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client> mockGrpcClient = new Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client>(MockBehavior.Strict);
            ReportPhishingRequest expectedRequest = new ReportPhishingRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Uri = "uri116076",
            };
            ReportPhishingResponse expectedResponse = new ReportPhishingResponse();
            mockGrpcClient.Setup(x => x.ReportPhishingAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ReportPhishingResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            PhishingProtectionServiceV1Beta1Client client = new PhishingProtectionServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            string uri = "uri116076";
            ReportPhishingResponse response = await client.ReportPhishingAsync(parent, uri);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ReportPhishing2()
        {
            Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client> mockGrpcClient = new Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client>(MockBehavior.Strict);
            ReportPhishingRequest request = new ReportPhishingRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Uri = "uri116076",
            };
            ReportPhishingResponse expectedResponse = new ReportPhishingResponse();
            mockGrpcClient.Setup(x => x.ReportPhishing(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            PhishingProtectionServiceV1Beta1Client client = new PhishingProtectionServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ReportPhishingResponse response = client.ReportPhishing(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ReportPhishingAsync2()
        {
            Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client> mockGrpcClient = new Mock<PhishingProtectionServiceV1Beta1.PhishingProtectionServiceV1Beta1Client>(MockBehavior.Strict);
            ReportPhishingRequest request = new ReportPhishingRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Uri = "uri116076",
            };
            ReportPhishingResponse expectedResponse = new ReportPhishingResponse();
            mockGrpcClient.Setup(x => x.ReportPhishingAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ReportPhishingResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            PhishingProtectionServiceV1Beta1Client client = new PhishingProtectionServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ReportPhishingResponse response = await client.ReportPhishingAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
