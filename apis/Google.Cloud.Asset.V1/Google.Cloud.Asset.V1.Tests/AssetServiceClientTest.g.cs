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
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagr = Google.Api.Gax.ResourceNames;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using gt = Google.Type;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Asset.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAssetServiceClientTest
    {
        [xunit::FactAttribute]
        public void BatchGetAssetsHistoryRequestObject()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchGetAssetsHistoryRequest request = new BatchGetAssetsHistoryRequest
            {
                ParentAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                AssetNames =
                {
                    "asset_namese42cd316",
                },
                ContentType = ContentType.AccessPolicy,
                ReadTimeWindow = new TimeWindow(),
                RelationshipTypes =
                {
                    "relationship_typesfb911a9b",
                },
            };
            BatchGetAssetsHistoryResponse expectedResponse = new BatchGetAssetsHistoryResponse
            {
                Assets =
                {
                    new TemporalAsset(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchGetAssetsHistory(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            BatchGetAssetsHistoryResponse response = client.BatchGetAssetsHistory(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchGetAssetsHistoryRequestObjectAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchGetAssetsHistoryRequest request = new BatchGetAssetsHistoryRequest
            {
                ParentAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                AssetNames =
                {
                    "asset_namese42cd316",
                },
                ContentType = ContentType.AccessPolicy,
                ReadTimeWindow = new TimeWindow(),
                RelationshipTypes =
                {
                    "relationship_typesfb911a9b",
                },
            };
            BatchGetAssetsHistoryResponse expectedResponse = new BatchGetAssetsHistoryResponse
            {
                Assets =
                {
                    new TemporalAsset(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchGetAssetsHistoryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchGetAssetsHistoryResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            BatchGetAssetsHistoryResponse responseCallSettings = await client.BatchGetAssetsHistoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchGetAssetsHistoryResponse responseCancellationToken = await client.BatchGetAssetsHistoryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateFeedRequestObject()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateFeedRequest request = new CreateFeedRequest
            {
                Parent = "parent7858e4d0",
                FeedId = "feed_id938e5ac9",
                Feed = new Feed(),
            };
            Feed expectedResponse = new Feed
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
                AssetNames =
                {
                    "asset_namese42cd316",
                },
                AssetTypes =
                {
                    "asset_types44c0f429",
                },
                ContentType = ContentType.AccessPolicy,
                FeedOutputConfig = new FeedOutputConfig(),
                Condition = new gt::Expr(),
                RelationshipTypes =
                {
                    "relationship_typesfb911a9b",
                },
            };
            mockGrpcClient.Setup(x => x.CreateFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            Feed response = client.CreateFeed(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateFeedRequestObjectAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateFeedRequest request = new CreateFeedRequest
            {
                Parent = "parent7858e4d0",
                FeedId = "feed_id938e5ac9",
                Feed = new Feed(),
            };
            Feed expectedResponse = new Feed
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
                AssetNames =
                {
                    "asset_namese42cd316",
                },
                AssetTypes =
                {
                    "asset_types44c0f429",
                },
                ContentType = ContentType.AccessPolicy,
                FeedOutputConfig = new FeedOutputConfig(),
                Condition = new gt::Expr(),
                RelationshipTypes =
                {
                    "relationship_typesfb911a9b",
                },
            };
            mockGrpcClient.Setup(x => x.CreateFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Feed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            Feed responseCallSettings = await client.CreateFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Feed responseCancellationToken = await client.CreateFeedAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateFeed()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateFeedRequest request = new CreateFeedRequest
            {
                Parent = "parent7858e4d0",
            };
            Feed expectedResponse = new Feed
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
                AssetNames =
                {
                    "asset_namese42cd316",
                },
                AssetTypes =
                {
                    "asset_types44c0f429",
                },
                ContentType = ContentType.AccessPolicy,
                FeedOutputConfig = new FeedOutputConfig(),
                Condition = new gt::Expr(),
                RelationshipTypes =
                {
                    "relationship_typesfb911a9b",
                },
            };
            mockGrpcClient.Setup(x => x.CreateFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            Feed response = client.CreateFeed(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateFeedAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateFeedRequest request = new CreateFeedRequest
            {
                Parent = "parent7858e4d0",
            };
            Feed expectedResponse = new Feed
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
                AssetNames =
                {
                    "asset_namese42cd316",
                },
                AssetTypes =
                {
                    "asset_types44c0f429",
                },
                ContentType = ContentType.AccessPolicy,
                FeedOutputConfig = new FeedOutputConfig(),
                Condition = new gt::Expr(),
                RelationshipTypes =
                {
                    "relationship_typesfb911a9b",
                },
            };
            mockGrpcClient.Setup(x => x.CreateFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Feed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            Feed responseCallSettings = await client.CreateFeedAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Feed responseCancellationToken = await client.CreateFeedAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFeedRequestObject()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeedRequest request = new GetFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            Feed expectedResponse = new Feed
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
                AssetNames =
                {
                    "asset_namese42cd316",
                },
                AssetTypes =
                {
                    "asset_types44c0f429",
                },
                ContentType = ContentType.AccessPolicy,
                FeedOutputConfig = new FeedOutputConfig(),
                Condition = new gt::Expr(),
                RelationshipTypes =
                {
                    "relationship_typesfb911a9b",
                },
            };
            mockGrpcClient.Setup(x => x.GetFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            Feed response = client.GetFeed(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFeedRequestObjectAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeedRequest request = new GetFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            Feed expectedResponse = new Feed
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
                AssetNames =
                {
                    "asset_namese42cd316",
                },
                AssetTypes =
                {
                    "asset_types44c0f429",
                },
                ContentType = ContentType.AccessPolicy,
                FeedOutputConfig = new FeedOutputConfig(),
                Condition = new gt::Expr(),
                RelationshipTypes =
                {
                    "relationship_typesfb911a9b",
                },
            };
            mockGrpcClient.Setup(x => x.GetFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Feed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            Feed responseCallSettings = await client.GetFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Feed responseCancellationToken = await client.GetFeedAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFeed()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeedRequest request = new GetFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            Feed expectedResponse = new Feed
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
                AssetNames =
                {
                    "asset_namese42cd316",
                },
                AssetTypes =
                {
                    "asset_types44c0f429",
                },
                ContentType = ContentType.AccessPolicy,
                FeedOutputConfig = new FeedOutputConfig(),
                Condition = new gt::Expr(),
                RelationshipTypes =
                {
                    "relationship_typesfb911a9b",
                },
            };
            mockGrpcClient.Setup(x => x.GetFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            Feed response = client.GetFeed(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFeedAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeedRequest request = new GetFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            Feed expectedResponse = new Feed
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
                AssetNames =
                {
                    "asset_namese42cd316",
                },
                AssetTypes =
                {
                    "asset_types44c0f429",
                },
                ContentType = ContentType.AccessPolicy,
                FeedOutputConfig = new FeedOutputConfig(),
                Condition = new gt::Expr(),
                RelationshipTypes =
                {
                    "relationship_typesfb911a9b",
                },
            };
            mockGrpcClient.Setup(x => x.GetFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Feed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            Feed responseCallSettings = await client.GetFeedAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Feed responseCancellationToken = await client.GetFeedAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetFeedResourceNames()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeedRequest request = new GetFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            Feed expectedResponse = new Feed
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
                AssetNames =
                {
                    "asset_namese42cd316",
                },
                AssetTypes =
                {
                    "asset_types44c0f429",
                },
                ContentType = ContentType.AccessPolicy,
                FeedOutputConfig = new FeedOutputConfig(),
                Condition = new gt::Expr(),
                RelationshipTypes =
                {
                    "relationship_typesfb911a9b",
                },
            };
            mockGrpcClient.Setup(x => x.GetFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            Feed response = client.GetFeed(request.FeedName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetFeedResourceNamesAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetFeedRequest request = new GetFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            Feed expectedResponse = new Feed
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
                AssetNames =
                {
                    "asset_namese42cd316",
                },
                AssetTypes =
                {
                    "asset_types44c0f429",
                },
                ContentType = ContentType.AccessPolicy,
                FeedOutputConfig = new FeedOutputConfig(),
                Condition = new gt::Expr(),
                RelationshipTypes =
                {
                    "relationship_typesfb911a9b",
                },
            };
            mockGrpcClient.Setup(x => x.GetFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Feed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            Feed responseCallSettings = await client.GetFeedAsync(request.FeedName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Feed responseCancellationToken = await client.GetFeedAsync(request.FeedName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListFeedsRequestObject()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListFeedsRequest request = new ListFeedsRequest
            {
                Parent = "parent7858e4d0",
            };
            ListFeedsResponse expectedResponse = new ListFeedsResponse { Feeds = { new Feed(), }, };
            mockGrpcClient.Setup(x => x.ListFeeds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            ListFeedsResponse response = client.ListFeeds(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListFeedsRequestObjectAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListFeedsRequest request = new ListFeedsRequest
            {
                Parent = "parent7858e4d0",
            };
            ListFeedsResponse expectedResponse = new ListFeedsResponse { Feeds = { new Feed(), }, };
            mockGrpcClient.Setup(x => x.ListFeedsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListFeedsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            ListFeedsResponse responseCallSettings = await client.ListFeedsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListFeedsResponse responseCancellationToken = await client.ListFeedsAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListFeeds()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListFeedsRequest request = new ListFeedsRequest
            {
                Parent = "parent7858e4d0",
            };
            ListFeedsResponse expectedResponse = new ListFeedsResponse { Feeds = { new Feed(), }, };
            mockGrpcClient.Setup(x => x.ListFeeds(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            ListFeedsResponse response = client.ListFeeds(request.Parent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListFeedsAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListFeedsRequest request = new ListFeedsRequest
            {
                Parent = "parent7858e4d0",
            };
            ListFeedsResponse expectedResponse = new ListFeedsResponse { Feeds = { new Feed(), }, };
            mockGrpcClient.Setup(x => x.ListFeedsAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ListFeedsResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            ListFeedsResponse responseCallSettings = await client.ListFeedsAsync(request.Parent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ListFeedsResponse responseCancellationToken = await client.ListFeedsAsync(request.Parent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateFeedRequestObject()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateFeedRequest request = new UpdateFeedRequest
            {
                Feed = new Feed(),
                UpdateMask = new wkt::FieldMask(),
            };
            Feed expectedResponse = new Feed
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
                AssetNames =
                {
                    "asset_namese42cd316",
                },
                AssetTypes =
                {
                    "asset_types44c0f429",
                },
                ContentType = ContentType.AccessPolicy,
                FeedOutputConfig = new FeedOutputConfig(),
                Condition = new gt::Expr(),
                RelationshipTypes =
                {
                    "relationship_typesfb911a9b",
                },
            };
            mockGrpcClient.Setup(x => x.UpdateFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            Feed response = client.UpdateFeed(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateFeedRequestObjectAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateFeedRequest request = new UpdateFeedRequest
            {
                Feed = new Feed(),
                UpdateMask = new wkt::FieldMask(),
            };
            Feed expectedResponse = new Feed
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
                AssetNames =
                {
                    "asset_namese42cd316",
                },
                AssetTypes =
                {
                    "asset_types44c0f429",
                },
                ContentType = ContentType.AccessPolicy,
                FeedOutputConfig = new FeedOutputConfig(),
                Condition = new gt::Expr(),
                RelationshipTypes =
                {
                    "relationship_typesfb911a9b",
                },
            };
            mockGrpcClient.Setup(x => x.UpdateFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Feed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            Feed responseCallSettings = await client.UpdateFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Feed responseCancellationToken = await client.UpdateFeedAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateFeed()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateFeedRequest request = new UpdateFeedRequest { Feed = new Feed(), };
            Feed expectedResponse = new Feed
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
                AssetNames =
                {
                    "asset_namese42cd316",
                },
                AssetTypes =
                {
                    "asset_types44c0f429",
                },
                ContentType = ContentType.AccessPolicy,
                FeedOutputConfig = new FeedOutputConfig(),
                Condition = new gt::Expr(),
                RelationshipTypes =
                {
                    "relationship_typesfb911a9b",
                },
            };
            mockGrpcClient.Setup(x => x.UpdateFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            Feed response = client.UpdateFeed(request.Feed);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateFeedAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateFeedRequest request = new UpdateFeedRequest { Feed = new Feed(), };
            Feed expectedResponse = new Feed
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
                AssetNames =
                {
                    "asset_namese42cd316",
                },
                AssetTypes =
                {
                    "asset_types44c0f429",
                },
                ContentType = ContentType.AccessPolicy,
                FeedOutputConfig = new FeedOutputConfig(),
                Condition = new gt::Expr(),
                RelationshipTypes =
                {
                    "relationship_typesfb911a9b",
                },
            };
            mockGrpcClient.Setup(x => x.UpdateFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Feed>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            Feed responseCallSettings = await client.UpdateFeedAsync(request.Feed, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Feed responseCancellationToken = await client.UpdateFeedAsync(request.Feed, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteFeedRequestObject()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteFeedRequest request = new DeleteFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteFeed(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteFeedRequestObjectAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteFeedRequest request = new DeleteFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteFeedAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteFeed()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteFeedRequest request = new DeleteFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteFeed(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteFeedAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteFeedRequest request = new DeleteFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteFeedAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteFeedAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteFeedResourceNames()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteFeedRequest request = new DeleteFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteFeed(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteFeed(request.FeedName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteFeedResourceNamesAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteFeedRequest request = new DeleteFeedRequest
            {
                FeedName = FeedName.FromProjectFeed("[PROJECT]", "[FEED]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteFeedAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteFeedAsync(request.FeedName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteFeedAsync(request.FeedName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeIamPolicyRequestObject()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AnalyzeIamPolicyRequest request = new AnalyzeIamPolicyRequest
            {
                AnalysisQuery = new IamPolicyAnalysisQuery(),
                ExecutionTimeout = new wkt::Duration(),
                SavedAnalysisQuery = "saved_analysis_query55fd0443",
            };
            AnalyzeIamPolicyResponse expectedResponse = new AnalyzeIamPolicyResponse
            {
                MainAnalysis = new AnalyzeIamPolicyResponse.Types.IamPolicyAnalysis(),
                ServiceAccountImpersonationAnalysis =
                {
                    new AnalyzeIamPolicyResponse.Types.IamPolicyAnalysis(),
                },
                FullyExplored = false,
            };
            mockGrpcClient.Setup(x => x.AnalyzeIamPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            AnalyzeIamPolicyResponse response = client.AnalyzeIamPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeIamPolicyRequestObjectAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AnalyzeIamPolicyRequest request = new AnalyzeIamPolicyRequest
            {
                AnalysisQuery = new IamPolicyAnalysisQuery(),
                ExecutionTimeout = new wkt::Duration(),
                SavedAnalysisQuery = "saved_analysis_query55fd0443",
            };
            AnalyzeIamPolicyResponse expectedResponse = new AnalyzeIamPolicyResponse
            {
                MainAnalysis = new AnalyzeIamPolicyResponse.Types.IamPolicyAnalysis(),
                ServiceAccountImpersonationAnalysis =
                {
                    new AnalyzeIamPolicyResponse.Types.IamPolicyAnalysis(),
                },
                FullyExplored = false,
            };
            mockGrpcClient.Setup(x => x.AnalyzeIamPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeIamPolicyResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            AnalyzeIamPolicyResponse responseCallSettings = await client.AnalyzeIamPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeIamPolicyResponse responseCancellationToken = await client.AnalyzeIamPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AnalyzeMoveRequestObject()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AnalyzeMoveRequest request = new AnalyzeMoveRequest
            {
                Resource = "resource164eab96",
                DestinationParent = "destination_parent29fce40d",
                View = AnalyzeMoveRequest.Types.AnalysisView.Full,
            };
            AnalyzeMoveResponse expectedResponse = new AnalyzeMoveResponse
            {
                MoveAnalysis = { new MoveAnalysis(), },
            };
            mockGrpcClient.Setup(x => x.AnalyzeMove(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            AnalyzeMoveResponse response = client.AnalyzeMove(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AnalyzeMoveRequestObjectAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            AnalyzeMoveRequest request = new AnalyzeMoveRequest
            {
                Resource = "resource164eab96",
                DestinationParent = "destination_parent29fce40d",
                View = AnalyzeMoveRequest.Types.AnalysisView.Full,
            };
            AnalyzeMoveResponse expectedResponse = new AnalyzeMoveResponse
            {
                MoveAnalysis = { new MoveAnalysis(), },
            };
            mockGrpcClient.Setup(x => x.AnalyzeMoveAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AnalyzeMoveResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            AnalyzeMoveResponse responseCallSettings = await client.AnalyzeMoveAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AnalyzeMoveResponse responseCancellationToken = await client.AnalyzeMoveAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSavedQueryRequestObject()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSavedQueryRequest request = new CreateSavedQueryRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SavedQuery = new SavedQuery(),
                SavedQueryId = "saved_query_iddcf159f2",
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.CreateSavedQuery(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery response = client.CreateSavedQuery(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSavedQueryRequestObjectAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSavedQueryRequest request = new CreateSavedQueryRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SavedQuery = new SavedQuery(),
                SavedQueryId = "saved_query_iddcf159f2",
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.CreateSavedQueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SavedQuery>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery responseCallSettings = await client.CreateSavedQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SavedQuery responseCancellationToken = await client.CreateSavedQueryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSavedQuery()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSavedQueryRequest request = new CreateSavedQueryRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SavedQuery = new SavedQuery(),
                SavedQueryId = "saved_query_iddcf159f2",
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.CreateSavedQuery(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery response = client.CreateSavedQuery(request.Parent, request.SavedQuery, request.SavedQueryId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSavedQueryAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSavedQueryRequest request = new CreateSavedQueryRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SavedQuery = new SavedQuery(),
                SavedQueryId = "saved_query_iddcf159f2",
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.CreateSavedQueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SavedQuery>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery responseCallSettings = await client.CreateSavedQueryAsync(request.Parent, request.SavedQuery, request.SavedQueryId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SavedQuery responseCancellationToken = await client.CreateSavedQueryAsync(request.Parent, request.SavedQuery, request.SavedQueryId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSavedQueryResourceNames1()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSavedQueryRequest request = new CreateSavedQueryRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SavedQuery = new SavedQuery(),
                SavedQueryId = "saved_query_iddcf159f2",
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.CreateSavedQuery(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery response = client.CreateSavedQuery(request.ParentAsProjectName, request.SavedQuery, request.SavedQueryId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSavedQueryResourceNames1Async()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSavedQueryRequest request = new CreateSavedQueryRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SavedQuery = new SavedQuery(),
                SavedQueryId = "saved_query_iddcf159f2",
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.CreateSavedQueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SavedQuery>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery responseCallSettings = await client.CreateSavedQueryAsync(request.ParentAsProjectName, request.SavedQuery, request.SavedQueryId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SavedQuery responseCancellationToken = await client.CreateSavedQueryAsync(request.ParentAsProjectName, request.SavedQuery, request.SavedQueryId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSavedQueryResourceNames2()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSavedQueryRequest request = new CreateSavedQueryRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SavedQuery = new SavedQuery(),
                SavedQueryId = "saved_query_iddcf159f2",
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.CreateSavedQuery(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery response = client.CreateSavedQuery(request.ParentAsFolderName, request.SavedQuery, request.SavedQueryId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSavedQueryResourceNames2Async()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSavedQueryRequest request = new CreateSavedQueryRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SavedQuery = new SavedQuery(),
                SavedQueryId = "saved_query_iddcf159f2",
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.CreateSavedQueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SavedQuery>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery responseCallSettings = await client.CreateSavedQueryAsync(request.ParentAsFolderName, request.SavedQuery, request.SavedQueryId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SavedQuery responseCancellationToken = await client.CreateSavedQueryAsync(request.ParentAsFolderName, request.SavedQuery, request.SavedQueryId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CreateSavedQueryResourceNames3()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSavedQueryRequest request = new CreateSavedQueryRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SavedQuery = new SavedQuery(),
                SavedQueryId = "saved_query_iddcf159f2",
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.CreateSavedQuery(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery response = client.CreateSavedQuery(request.ParentAsOrganizationName, request.SavedQuery, request.SavedQueryId);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CreateSavedQueryResourceNames3Async()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CreateSavedQueryRequest request = new CreateSavedQueryRequest
            {
                ParentAsProjectName = gagr::ProjectName.FromProject("[PROJECT]"),
                SavedQuery = new SavedQuery(),
                SavedQueryId = "saved_query_iddcf159f2",
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.CreateSavedQueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SavedQuery>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery responseCallSettings = await client.CreateSavedQueryAsync(request.ParentAsOrganizationName, request.SavedQuery, request.SavedQueryId, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SavedQuery responseCancellationToken = await client.CreateSavedQueryAsync(request.ParentAsOrganizationName, request.SavedQuery, request.SavedQueryId, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSavedQueryRequestObject()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSavedQueryRequest request = new GetSavedQueryRequest
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.GetSavedQuery(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery response = client.GetSavedQuery(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSavedQueryRequestObjectAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSavedQueryRequest request = new GetSavedQueryRequest
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.GetSavedQueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SavedQuery>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery responseCallSettings = await client.GetSavedQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SavedQuery responseCancellationToken = await client.GetSavedQueryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSavedQuery()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSavedQueryRequest request = new GetSavedQueryRequest
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.GetSavedQuery(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery response = client.GetSavedQuery(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSavedQueryAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSavedQueryRequest request = new GetSavedQueryRequest
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.GetSavedQueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SavedQuery>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery responseCallSettings = await client.GetSavedQueryAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SavedQuery responseCancellationToken = await client.GetSavedQueryAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetSavedQueryResourceNames()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSavedQueryRequest request = new GetSavedQueryRequest
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.GetSavedQuery(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery response = client.GetSavedQuery(request.SavedQueryName);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetSavedQueryResourceNamesAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSavedQueryRequest request = new GetSavedQueryRequest
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.GetSavedQueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SavedQuery>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery responseCallSettings = await client.GetSavedQueryAsync(request.SavedQueryName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SavedQuery responseCancellationToken = await client.GetSavedQueryAsync(request.SavedQueryName, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSavedQueryRequestObject()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSavedQueryRequest request = new UpdateSavedQueryRequest
            {
                SavedQuery = new SavedQuery(),
                UpdateMask = new wkt::FieldMask(),
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.UpdateSavedQuery(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery response = client.UpdateSavedQuery(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSavedQueryRequestObjectAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSavedQueryRequest request = new UpdateSavedQueryRequest
            {
                SavedQuery = new SavedQuery(),
                UpdateMask = new wkt::FieldMask(),
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.UpdateSavedQueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SavedQuery>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery responseCallSettings = await client.UpdateSavedQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SavedQuery responseCancellationToken = await client.UpdateSavedQueryAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void UpdateSavedQuery()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSavedQueryRequest request = new UpdateSavedQueryRequest
            {
                SavedQuery = new SavedQuery(),
                UpdateMask = new wkt::FieldMask(),
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.UpdateSavedQuery(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery response = client.UpdateSavedQuery(request.SavedQuery, request.UpdateMask);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task UpdateSavedQueryAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            UpdateSavedQueryRequest request = new UpdateSavedQueryRequest
            {
                SavedQuery = new SavedQuery(),
                UpdateMask = new wkt::FieldMask(),
            };
            SavedQuery expectedResponse = new SavedQuery
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
                Description = "description2cf9da67",
                CreateTime = new wkt::Timestamp(),
                Creator = "creator253324ee",
                LastUpdateTime = new wkt::Timestamp(),
                LastUpdater = "last_updater8c97e87e",
                Labels =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Content = new SavedQuery.Types.QueryContent(),
            };
            mockGrpcClient.Setup(x => x.UpdateSavedQueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SavedQuery>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            SavedQuery responseCallSettings = await client.UpdateSavedQueryAsync(request.SavedQuery, request.UpdateMask, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SavedQuery responseCancellationToken = await client.UpdateSavedQueryAsync(request.SavedQuery, request.UpdateMask, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSavedQueryRequestObject()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSavedQueryRequest request = new DeleteSavedQueryRequest
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSavedQuery(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteSavedQuery(request);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSavedQueryRequestObjectAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSavedQueryRequest request = new DeleteSavedQueryRequest
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSavedQueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteSavedQueryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSavedQueryAsync(request, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSavedQuery()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSavedQueryRequest request = new DeleteSavedQueryRequest
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSavedQuery(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteSavedQuery(request.Name);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSavedQueryAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSavedQueryRequest request = new DeleteSavedQueryRequest
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSavedQueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteSavedQueryAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSavedQueryAsync(request.Name, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void DeleteSavedQueryResourceNames()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSavedQueryRequest request = new DeleteSavedQueryRequest
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSavedQuery(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            client.DeleteSavedQuery(request.SavedQueryName);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task DeleteSavedQueryResourceNamesAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            DeleteSavedQueryRequest request = new DeleteSavedQueryRequest
            {
                SavedQueryName = SavedQueryName.FromProjectSavedQuery("[PROJECT]", "[SAVED_QUERY]"),
            };
            wkt::Empty expectedResponse = new wkt::Empty { };
            mockGrpcClient.Setup(x => x.DeleteSavedQueryAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<wkt::Empty>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            await client.DeleteSavedQueryAsync(request.SavedQueryName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            await client.DeleteSavedQueryAsync(request.SavedQueryName, st::CancellationToken.None);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void BatchGetEffectiveIamPoliciesRequestObject()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchGetEffectiveIamPoliciesRequest request = new BatchGetEffectiveIamPoliciesRequest
            {
                ScopeAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                ResourceNames =
                {
                    new gax::UnparsedResourceName("a/wildcard/resource"),
                },
            };
            BatchGetEffectiveIamPoliciesResponse expectedResponse = new BatchGetEffectiveIamPoliciesResponse
            {
                PolicyResults =
                {
                    new BatchGetEffectiveIamPoliciesResponse.Types.EffectiveIamPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchGetEffectiveIamPolicies(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            BatchGetEffectiveIamPoliciesResponse response = client.BatchGetEffectiveIamPolicies(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task BatchGetEffectiveIamPoliciesRequestObjectAsync()
        {
            moq::Mock<AssetService.AssetServiceClient> mockGrpcClient = new moq::Mock<AssetService.AssetServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            BatchGetEffectiveIamPoliciesRequest request = new BatchGetEffectiveIamPoliciesRequest
            {
                ScopeAsResourceName = new gax::UnparsedResourceName("a/wildcard/resource"),
                ResourceNames =
                {
                    new gax::UnparsedResourceName("a/wildcard/resource"),
                },
            };
            BatchGetEffectiveIamPoliciesResponse expectedResponse = new BatchGetEffectiveIamPoliciesResponse
            {
                PolicyResults =
                {
                    new BatchGetEffectiveIamPoliciesResponse.Types.EffectiveIamPolicy(),
                },
            };
            mockGrpcClient.Setup(x => x.BatchGetEffectiveIamPoliciesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<BatchGetEffectiveIamPoliciesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetServiceClient client = new AssetServiceClientImpl(mockGrpcClient.Object, null, null);
            BatchGetEffectiveIamPoliciesResponse responseCallSettings = await client.BatchGetEffectiveIamPoliciesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            BatchGetEffectiveIamPoliciesResponse responseCancellationToken = await client.BatchGetEffectiveIamPoliciesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
