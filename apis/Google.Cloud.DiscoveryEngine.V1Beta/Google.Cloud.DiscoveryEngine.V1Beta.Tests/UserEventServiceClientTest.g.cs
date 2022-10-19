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
using ga = Google.Api;
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.DiscoveryEngine.V1Beta.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedUserEventServiceClientTest
    {
        [xunit::FactAttribute]
        public void WriteUserEventRequestObject()
        {
            moq::Mock<UserEventService.UserEventServiceClient> mockGrpcClient = new moq::Mock<UserEventService.UserEventServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            WriteUserEventRequest request = new WriteUserEventRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                UserEvent = new UserEvent(),
            };
            UserEvent expectedResponse = new UserEvent
            {
                EventType = "event_type1436d01c",
                UserPseudoId = "user_pseudo_idf8a4beb0",
                EventTime = new wkt::Timestamp(),
                UserInfo = new UserInfo(),
                DirectUserRequest = true,
                SessionId = "session_id54efc87f",
                PageInfo = new PageInfo(),
                AttributionToken = "attribution_token14371a88",
                Filter = "filtere47ac9b2",
                Documents = { new DocumentInfo(), },
                Panel = new PanelInfo(),
                SearchInfo = new SearchInfo(),
                CompletionInfo = new CompletionInfo(),
                TransactionInfo = new TransactionInfo(),
                TagIds = { "tag_ids78bdf74c", },
                PromotionIds =
                {
                    "promotion_ids8e8d6acd",
                },
                Attributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                MediaInfo = new MediaInfo(),
            };
            mockGrpcClient.Setup(x => x.WriteUserEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserEventServiceClient client = new UserEventServiceClientImpl(mockGrpcClient.Object, null, null);
            UserEvent response = client.WriteUserEvent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task WriteUserEventRequestObjectAsync()
        {
            moq::Mock<UserEventService.UserEventServiceClient> mockGrpcClient = new moq::Mock<UserEventService.UserEventServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            WriteUserEventRequest request = new WriteUserEventRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                UserEvent = new UserEvent(),
            };
            UserEvent expectedResponse = new UserEvent
            {
                EventType = "event_type1436d01c",
                UserPseudoId = "user_pseudo_idf8a4beb0",
                EventTime = new wkt::Timestamp(),
                UserInfo = new UserInfo(),
                DirectUserRequest = true,
                SessionId = "session_id54efc87f",
                PageInfo = new PageInfo(),
                AttributionToken = "attribution_token14371a88",
                Filter = "filtere47ac9b2",
                Documents = { new DocumentInfo(), },
                Panel = new PanelInfo(),
                SearchInfo = new SearchInfo(),
                CompletionInfo = new CompletionInfo(),
                TransactionInfo = new TransactionInfo(),
                TagIds = { "tag_ids78bdf74c", },
                PromotionIds =
                {
                    "promotion_ids8e8d6acd",
                },
                Attributes =
                {
                    {
                        "key8a0b6e3c",
                        new CustomAttribute()
                    },
                },
                MediaInfo = new MediaInfo(),
            };
            mockGrpcClient.Setup(x => x.WriteUserEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserEvent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserEventServiceClient client = new UserEventServiceClientImpl(mockGrpcClient.Object, null, null);
            UserEvent responseCallSettings = await client.WriteUserEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserEvent responseCancellationToken = await client.WriteUserEventAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CollectUserEventRequestObject()
        {
            moq::Mock<UserEventService.UserEventServiceClient> mockGrpcClient = new moq::Mock<UserEventService.UserEventServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CollectUserEventRequest request = new CollectUserEventRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                UserEvent = "user_eventc8146d99",
                Uri = "uri3db70593",
                Ets = -4649673071663131288L,
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.CollectUserEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserEventServiceClient client = new UserEventServiceClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody response = client.CollectUserEvent(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CollectUserEventRequestObjectAsync()
        {
            moq::Mock<UserEventService.UserEventServiceClient> mockGrpcClient = new moq::Mock<UserEventService.UserEventServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CollectUserEventRequest request = new CollectUserEventRequest
            {
                ParentAsDataStoreName = DataStoreName.FromProjectLocationDataStore("[PROJECT]", "[LOCATION]", "[DATA_STORE]"),
                UserEvent = "user_eventc8146d99",
                Uri = "uri3db70593",
                Ets = -4649673071663131288L,
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions = { new wkt::Any(), },
            };
            mockGrpcClient.Setup(x => x.CollectUserEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::HttpBody>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserEventServiceClient client = new UserEventServiceClientImpl(mockGrpcClient.Object, null, null);
            ga::HttpBody responseCallSettings = await client.CollectUserEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::HttpBody responseCancellationToken = await client.CollectUserEventAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
