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
    using apis = Google.Cloud.Talent.V4Beta1;
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
    public class GeneratedCompletionClientTest
    {
        [Fact]
        public void CompleteQuery()
        {
            Mock<Completion.CompletionClient> mockGrpcClient = new Mock<Completion.CompletionClient>(MockBehavior.Strict);
            CompleteQueryRequest request = new CompleteQueryRequest
            {
                ParentAsTenantOrProjectNameOneof = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]")),
                Query = "query107944136",
                PageSize = 883849137,
            };
            CompleteQueryResponse expectedResponse = new CompleteQueryResponse();
            mockGrpcClient.Setup(x => x.CompleteQuery(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CompletionClient client = new CompletionClientImpl(mockGrpcClient.Object, null);
            CompleteQueryResponse response = client.CompleteQuery(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CompleteQueryAsync()
        {
            Mock<Completion.CompletionClient> mockGrpcClient = new Mock<Completion.CompletionClient>(MockBehavior.Strict);
            CompleteQueryRequest request = new CompleteQueryRequest
            {
                ParentAsTenantOrProjectNameOneof = TenantOrProjectNameOneof.From(new TenantName("[PROJECT]", "[TENANT]")),
                Query = "query107944136",
                PageSize = 883849137,
            };
            CompleteQueryResponse expectedResponse = new CompleteQueryResponse();
            mockGrpcClient.Setup(x => x.CompleteQueryAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CompleteQueryResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CompletionClient client = new CompletionClientImpl(mockGrpcClient.Object, null);
            CompleteQueryResponse response = await client.CompleteQueryAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
