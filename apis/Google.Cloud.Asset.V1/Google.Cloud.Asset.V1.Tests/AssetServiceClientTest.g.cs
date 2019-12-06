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

namespace Google.Cloud.Asset.V1.Tests
{
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Api.Gax.ResourceNames;
    using apis = Google.Cloud.Asset.V1;
    using Google.LongRunning;
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
    public class GeneratedAssetServiceClientTest
    {
        [Fact]
        public void BatchGetAssetsHistory()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            BatchGetAssetsHistoryRequest request = new BatchGetAssetsHistoryRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                ContentType = ContentType.Unspecified,
                ReadTimeWindow = new TimeWindow(),
            };
            BatchGetAssetsHistoryResponse expectedResponse = new BatchGetAssetsHistoryResponse();
            mockGrpcClient.Setup(x => x.BatchGetAssetsHistory(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            BatchGetAssetsHistoryResponse response = client.BatchGetAssetsHistory(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task BatchGetAssetsHistoryAsync()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            BatchGetAssetsHistoryRequest request = new BatchGetAssetsHistoryRequest
            {
                ParentAsProjectName = new ProjectName("[PROJECT]"),
                ContentType = ContentType.Unspecified,
                ReadTimeWindow = new TimeWindow(),
            };
            BatchGetAssetsHistoryResponse expectedResponse = new BatchGetAssetsHistoryResponse();
            mockGrpcClient.Setup(x => x.BatchGetAssetsHistoryAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<BatchGetAssetsHistoryResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            BatchGetAssetsHistoryResponse response = await client.BatchGetAssetsHistoryAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateFeed()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateFeedRequest expectedRequest = new CreateFeedRequest
            {
                Parent = "parent-995424086",
            };
            Feed expectedResponse = new Feed
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.CreateFeed(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            string parent = "parent-995424086";
            Feed response = client.CreateFeed(parent);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateFeedAsync()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateFeedRequest expectedRequest = new CreateFeedRequest
            {
                Parent = "parent-995424086",
            };
            Feed expectedResponse = new Feed
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.CreateFeedAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Feed>(Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            string parent = "parent-995424086";
            Feed response = await client.CreateFeedAsync(parent);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void CreateFeed2()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateFeedRequest request = new CreateFeedRequest
            {
                Parent = "parent-995424086",
                FeedId = "feedId-976011428",
                Feed = new Feed(),
            };
            Feed expectedResponse = new Feed
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.CreateFeed(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            Feed response = client.CreateFeed(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task CreateFeedAsync2()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            CreateFeedRequest request = new CreateFeedRequest
            {
                Parent = "parent-995424086",
                FeedId = "feedId-976011428",
                Feed = new Feed(),
            };
            Feed expectedResponse = new Feed
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.CreateFeedAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Feed>(Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            Feed response = await client.CreateFeedAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetFeed()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetFeedRequest expectedRequest = new GetFeedRequest
            {
                Name = new FeedName("[PROJECT]", "[FEED]").ToString(),
            };
            Feed expectedResponse = new Feed
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetFeed(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new FeedName("[PROJECT]", "[FEED]").ToString();
            Feed response = client.GetFeed(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetFeedAsync()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetFeedRequest expectedRequest = new GetFeedRequest
            {
                Name = new FeedName("[PROJECT]", "[FEED]").ToString(),
            };
            Feed expectedResponse = new Feed
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetFeedAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Feed>(Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new FeedName("[PROJECT]", "[FEED]").ToString();
            Feed response = await client.GetFeedAsync(formattedName);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void GetFeed2()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetFeedRequest request = new GetFeedRequest
            {
                Name = new FeedName("[PROJECT]", "[FEED]").ToString(),
            };
            Feed expectedResponse = new Feed
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetFeed(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            Feed response = client.GetFeed(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task GetFeedAsync2()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            GetFeedRequest request = new GetFeedRequest
            {
                Name = new FeedName("[PROJECT]", "[FEED]").ToString(),
            };
            Feed expectedResponse = new Feed
            {
                Name = "name2-1052831874",
            };
            mockGrpcClient.Setup(x => x.GetFeedAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Feed>(Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            Feed response = await client.GetFeedAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListFeeds()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListFeedsRequest expectedRequest = new ListFeedsRequest
            {
                Parent = "parent-995424086",
            };
            ListFeedsResponse expectedResponse = new ListFeedsResponse();
            mockGrpcClient.Setup(x => x.ListFeeds(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            string parent = "parent-995424086";
            ListFeedsResponse response = client.ListFeeds(parent);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListFeedsAsync()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListFeedsRequest expectedRequest = new ListFeedsRequest
            {
                Parent = "parent-995424086",
            };
            ListFeedsResponse expectedResponse = new ListFeedsResponse();
            mockGrpcClient.Setup(x => x.ListFeedsAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListFeedsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            string parent = "parent-995424086";
            ListFeedsResponse response = await client.ListFeedsAsync(parent);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void ListFeeds2()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListFeedsRequest request = new ListFeedsRequest
            {
                Parent = "parent-995424086",
            };
            ListFeedsResponse expectedResponse = new ListFeedsResponse();
            mockGrpcClient.Setup(x => x.ListFeeds(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            ListFeedsResponse response = client.ListFeeds(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task ListFeedsAsync2()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            ListFeedsRequest request = new ListFeedsRequest
            {
                Parent = "parent-995424086",
            };
            ListFeedsResponse expectedResponse = new ListFeedsResponse();
            mockGrpcClient.Setup(x => x.ListFeedsAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<ListFeedsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            ListFeedsResponse response = await client.ListFeedsAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateFeed()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateFeedRequest expectedRequest = new UpdateFeedRequest
            {
                Feed = new Feed(),
            };
            Feed expectedResponse = new Feed
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.UpdateFeed(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            Feed feed = new Feed();
            Feed response = client.UpdateFeed(feed);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateFeedAsync()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateFeedRequest expectedRequest = new UpdateFeedRequest
            {
                Feed = new Feed(),
            };
            Feed expectedResponse = new Feed
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.UpdateFeedAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Feed>(Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            Feed feed = new Feed();
            Feed response = await client.UpdateFeedAsync(feed);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void UpdateFeed2()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateFeedRequest request = new UpdateFeedRequest
            {
                Feed = new Feed(),
                UpdateMask = new FieldMask(),
            };
            Feed expectedResponse = new Feed
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.UpdateFeed(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            Feed response = client.UpdateFeed(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task UpdateFeedAsync2()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            UpdateFeedRequest request = new UpdateFeedRequest
            {
                Feed = new Feed(),
                UpdateMask = new FieldMask(),
            };
            Feed expectedResponse = new Feed
            {
                Name = "name3373707",
            };
            mockGrpcClient.Setup(x => x.UpdateFeedAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Feed>(Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            Feed response = await client.UpdateFeedAsync(request);
            Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteFeed()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteFeedRequest expectedRequest = new DeleteFeedRequest
            {
                Name = new FeedName("[PROJECT]", "[FEED]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteFeed(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new FeedName("[PROJECT]", "[FEED]").ToString();
            client.DeleteFeed(formattedName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteFeedAsync()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteFeedRequest expectedRequest = new DeleteFeedRequest
            {
                Name = new FeedName("[PROJECT]", "[FEED]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteFeedAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            string formattedName = new FeedName("[PROJECT]", "[FEED]").ToString();
            await client.DeleteFeedAsync(formattedName);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public void DeleteFeed2()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteFeedRequest request = new DeleteFeedRequest
            {
                Name = new FeedName("[PROJECT]", "[FEED]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteFeed(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            client.DeleteFeed(request);
            mockGrpcClient.VerifyAll();
        }

        [Fact]
        public async Task DeleteFeedAsync2()
        {
            Mock<AssetService.AssetServiceClient> mockGrpcClient = new Mock<AssetService.AssetServiceClient>(MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient())
                .Returns(new Mock<Operations.OperationsClient>().Object);
            DeleteFeedRequest request = new DeleteFeedRequest
            {
                Name = new FeedName("[PROJECT]", "[FEED]").ToString(),
            };
            Empty expectedResponse = new Empty();
            mockGrpcClient.Setup(x => x.DeleteFeedAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<Empty>(Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null);
            await client.DeleteFeedAsync(request);
            mockGrpcClient.VerifyAll();
        }

    }
}
