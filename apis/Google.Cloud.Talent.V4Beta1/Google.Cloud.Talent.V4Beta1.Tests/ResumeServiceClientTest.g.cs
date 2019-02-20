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

namespace Google.Cloud.Talent.V4Beta1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using apis = Google.Cloud.Talent.V4Beta1;
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
    public class GeneratedResumeServiceClientTest
    {
        [Fact]
        public void ParseResume()
        {
            Mock<ResumeService.ResumeServiceClient> mockGrpcClient = new Mock<ResumeService.ResumeServiceClient>(MockBehavior.Strict);
            ParseResumeRequest expectedRequest = new ParseResumeRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Resume = ByteString.CopyFromUtf8("45"),
            };
            ParseResumeResponse expectedResponse = new ParseResumeResponse
            {
                RawText = "rawText503586532",
            };
            mockGrpcClient.Setup(x => x.ParseResume(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ResumeServiceClient client = new ResumeServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            ByteString resume = ByteString.CopyFromUtf8("45");
            ParseResumeResponse response = client.ParseResume(parent, resume);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ParseResumeAsync()
        {
            Mock<ResumeService.ResumeServiceClient> mockGrpcClient = new Mock<ResumeService.ResumeServiceClient>(MockBehavior.Strict);
            ParseResumeRequest expectedRequest = new ParseResumeRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Resume = ByteString.CopyFromUtf8("45"),
            };
            ParseResumeResponse expectedResponse = new ParseResumeResponse
            {
                RawText = "rawText503586532",
            };
            mockGrpcClient.Setup(x => x.ParseResumeAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ParseResumeResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ResumeServiceClient client = new ResumeServiceClientImpl(mockGrpcClient.Object, null);
            ProjectName parent = new ProjectName("[PROJECT]");
            ByteString resume = ByteString.CopyFromUtf8("45");
            ParseResumeResponse response = await client.ParseResumeAsync(parent, resume);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ParseResume2()
        {
            Mock<ResumeService.ResumeServiceClient> mockGrpcClient = new Mock<ResumeService.ResumeServiceClient>(MockBehavior.Strict);
            ParseResumeRequest request = new ParseResumeRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Resume = ByteString.CopyFromUtf8("45"),
            };
            ParseResumeResponse expectedResponse = new ParseResumeResponse
            {
                RawText = "rawText503586532",
            };
            mockGrpcClient.Setup(x => x.ParseResume(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            ResumeServiceClient client = new ResumeServiceClientImpl(mockGrpcClient.Object, null);
            ParseResumeResponse response = client.ParseResume(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ParseResumeAsync2()
        {
            Mock<ResumeService.ResumeServiceClient> mockGrpcClient = new Mock<ResumeService.ResumeServiceClient>(MockBehavior.Strict);
            ParseResumeRequest request = new ParseResumeRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                Resume = ByteString.CopyFromUtf8("45"),
            };
            ParseResumeResponse expectedResponse = new ParseResumeResponse
            {
                RawText = "rawText503586532",
            };
            mockGrpcClient.Setup(x => x.ParseResumeAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ParseResumeResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            ResumeServiceClient client = new ResumeServiceClientImpl(mockGrpcClient.Object, null);
            ParseResumeResponse response = await client.ParseResumeAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
