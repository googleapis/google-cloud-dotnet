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

namespace Google.Cloud.WebRisk.V1Beta1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using apis = Google.Cloud.WebRisk.V1Beta1;
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
    public class GeneratedWebRiskServiceV1Beta1ClientTest
    {
        [Fact]
        public void ComputeThreatListDiff()
        {
            Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client> mockGrpcClient = new Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client>(MockBehavior.Strict);
            ComputeThreatListDiffRequest expectedRequest = new ComputeThreatListDiffRequest
            {
                ThreatType = ThreatType.Unspecified,
                VersionToken = ByteString.CopyFromUtf8("-46"),
                Constraints = new ComputeThreatListDiffRequest.Types.Constraints(),
            };
            ComputeThreatListDiffResponse expectedResponse = new ComputeThreatListDiffResponse
            {
                NewVersionToken = ByteString.CopyFromUtf8("115"),
            };
            mockGrpcClient.Setup(x => x.ComputeThreatListDiff(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            WebRiskServiceV1Beta1Client client = new WebRiskServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ThreatType threatType = ThreatType.Unspecified;
            ByteString versionToken = ByteString.CopyFromUtf8("-46");
            ComputeThreatListDiffRequest.Types.Constraints constraints = new ComputeThreatListDiffRequest.Types.Constraints();
            ComputeThreatListDiffResponse response = client.ComputeThreatListDiff(threatType, versionToken, constraints);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ComputeThreatListDiffAsync()
        {
            Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client> mockGrpcClient = new Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client>(MockBehavior.Strict);
            ComputeThreatListDiffRequest expectedRequest = new ComputeThreatListDiffRequest
            {
                ThreatType = ThreatType.Unspecified,
                VersionToken = ByteString.CopyFromUtf8("-46"),
                Constraints = new ComputeThreatListDiffRequest.Types.Constraints(),
            };
            ComputeThreatListDiffResponse expectedResponse = new ComputeThreatListDiffResponse
            {
                NewVersionToken = ByteString.CopyFromUtf8("115"),
            };
            mockGrpcClient.Setup(x => x.ComputeThreatListDiffAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ComputeThreatListDiffResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            WebRiskServiceV1Beta1Client client = new WebRiskServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ThreatType threatType = ThreatType.Unspecified;
            ByteString versionToken = ByteString.CopyFromUtf8("-46");
            ComputeThreatListDiffRequest.Types.Constraints constraints = new ComputeThreatListDiffRequest.Types.Constraints();
            ComputeThreatListDiffResponse response = await client.ComputeThreatListDiffAsync(threatType, versionToken, constraints);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ComputeThreatListDiff2()
        {
            Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client> mockGrpcClient = new Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client>(MockBehavior.Strict);
            ComputeThreatListDiffRequest request = new ComputeThreatListDiffRequest
            {
                ThreatType = ThreatType.Unspecified,
                Constraints = new ComputeThreatListDiffRequest.Types.Constraints(),
            };
            ComputeThreatListDiffResponse expectedResponse = new ComputeThreatListDiffResponse
            {
                NewVersionToken = ByteString.CopyFromUtf8("115"),
            };
            mockGrpcClient.Setup(x => x.ComputeThreatListDiff(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            WebRiskServiceV1Beta1Client client = new WebRiskServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ComputeThreatListDiffResponse response = client.ComputeThreatListDiff(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ComputeThreatListDiffAsync2()
        {
            Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client> mockGrpcClient = new Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client>(MockBehavior.Strict);
            ComputeThreatListDiffRequest request = new ComputeThreatListDiffRequest
            {
                ThreatType = ThreatType.Unspecified,
                Constraints = new ComputeThreatListDiffRequest.Types.Constraints(),
            };
            ComputeThreatListDiffResponse expectedResponse = new ComputeThreatListDiffResponse
            {
                NewVersionToken = ByteString.CopyFromUtf8("115"),
            };
            mockGrpcClient.Setup(x => x.ComputeThreatListDiffAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ComputeThreatListDiffResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            WebRiskServiceV1Beta1Client client = new WebRiskServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ComputeThreatListDiffResponse response = await client.ComputeThreatListDiffAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SearchUris()
        {
            Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client> mockGrpcClient = new Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client>(MockBehavior.Strict);
            SearchUrisRequest expectedRequest = new SearchUrisRequest
            {
                Uri = "uri116076",
                ThreatTypes = { },
            };
            SearchUrisResponse expectedResponse = new SearchUrisResponse();
            mockGrpcClient.Setup(x => x.SearchUris(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            WebRiskServiceV1Beta1Client client = new WebRiskServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            string uri = "uri116076";
            IEnumerable<ThreatType> threatTypes = new List<ThreatType>();
            SearchUrisResponse response = client.SearchUris(uri, threatTypes);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SearchUrisAsync()
        {
            Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client> mockGrpcClient = new Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client>(MockBehavior.Strict);
            SearchUrisRequest expectedRequest = new SearchUrisRequest
            {
                Uri = "uri116076",
                ThreatTypes = { },
            };
            SearchUrisResponse expectedResponse = new SearchUrisResponse();
            mockGrpcClient.Setup(x => x.SearchUrisAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SearchUrisResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            WebRiskServiceV1Beta1Client client = new WebRiskServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            string uri = "uri116076";
            IEnumerable<ThreatType> threatTypes = new List<ThreatType>();
            SearchUrisResponse response = await client.SearchUrisAsync(uri, threatTypes);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SearchUris2()
        {
            Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client> mockGrpcClient = new Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client>(MockBehavior.Strict);
            SearchUrisRequest request = new SearchUrisRequest
            {
                Uri = "uri116076",
                ThreatTypes = { },
            };
            SearchUrisResponse expectedResponse = new SearchUrisResponse();
            mockGrpcClient.Setup(x => x.SearchUris(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            WebRiskServiceV1Beta1Client client = new WebRiskServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            SearchUrisResponse response = client.SearchUris(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SearchUrisAsync2()
        {
            Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client> mockGrpcClient = new Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client>(MockBehavior.Strict);
            SearchUrisRequest request = new SearchUrisRequest
            {
                Uri = "uri116076",
                ThreatTypes = { },
            };
            SearchUrisResponse expectedResponse = new SearchUrisResponse();
            mockGrpcClient.Setup(x => x.SearchUrisAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SearchUrisResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            WebRiskServiceV1Beta1Client client = new WebRiskServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            SearchUrisResponse response = await client.SearchUrisAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SearchHashes()
        {
            Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client> mockGrpcClient = new Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client>(MockBehavior.Strict);
            SearchHashesRequest expectedRequest = new SearchHashesRequest
            {
                HashPrefix = ByteString.CopyFromUtf8("-29"),
                ThreatTypes = { },
            };
            SearchHashesResponse expectedResponse = new SearchHashesResponse();
            mockGrpcClient.Setup(x => x.SearchHashes(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            WebRiskServiceV1Beta1Client client = new WebRiskServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ByteString hashPrefix = ByteString.CopyFromUtf8("-29");
            IEnumerable<ThreatType> threatTypes = new List<ThreatType>();
            SearchHashesResponse response = client.SearchHashes(hashPrefix, threatTypes);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SearchHashesAsync()
        {
            Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client> mockGrpcClient = new Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client>(MockBehavior.Strict);
            SearchHashesRequest expectedRequest = new SearchHashesRequest
            {
                HashPrefix = ByteString.CopyFromUtf8("-29"),
                ThreatTypes = { },
            };
            SearchHashesResponse expectedResponse = new SearchHashesResponse();
            mockGrpcClient.Setup(x => x.SearchHashesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SearchHashesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            WebRiskServiceV1Beta1Client client = new WebRiskServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            ByteString hashPrefix = ByteString.CopyFromUtf8("-29");
            IEnumerable<ThreatType> threatTypes = new List<ThreatType>();
            SearchHashesResponse response = await client.SearchHashesAsync(hashPrefix, threatTypes);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void SearchHashes2()
        {
            Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client> mockGrpcClient = new Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client>(MockBehavior.Strict);
            SearchHashesRequest request = new SearchHashesRequest
            {
                ThreatTypes = { },
            };
            SearchHashesResponse expectedResponse = new SearchHashesResponse();
            mockGrpcClient.Setup(x => x.SearchHashes(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            WebRiskServiceV1Beta1Client client = new WebRiskServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            SearchHashesResponse response = client.SearchHashes(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task SearchHashesAsync2()
        {
            Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client> mockGrpcClient = new Mock<WebRiskServiceV1Beta1.WebRiskServiceV1Beta1Client>(MockBehavior.Strict);
            SearchHashesRequest request = new SearchHashesRequest
            {
                ThreatTypes = { },
            };
            SearchHashesResponse expectedResponse = new SearchHashesResponse();
            mockGrpcClient.Setup(x => x.SearchHashesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<SearchHashesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            WebRiskServiceV1Beta1Client client = new WebRiskServiceV1Beta1ClientImpl(mockGrpcClient.Object, null);
            SearchHashesResponse response = await client.SearchHashesAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}
