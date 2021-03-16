// Copyright 2021 Google LLC
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

namespace Google.Cloud.RecommendationEngine.V1Beta1.Tests
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
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                UserEvent = new UserEvent
                {
                    EventType = "event_type1436d01c",
                    UserInfo = new UserInfo
                    {
                        VisitorId = "visitor_id25f1c2bf",
                        UserId = "user_idd41a70e8",
                        IpAddress = "ip_address46a72553",
                        UserAgent = "user_agent707c6483",
                        DirectUserRequest = true,
                    },
                    EventDetail = new EventDetail
                    {
                        Uri = "uri3db70593",
                        PageViewId = "page_view_id77a7ed70",
                        ExperimentIds =
                        {
                            "experiment_ids9777ca1b",
                        },
                        RecommendationToken = "recommendation_token2a33f3e2",
                        EventAttributes = new FeatureMap
                        {
                            CategoricalFeatures =
                            {
                                {
                                    "key8a0b6e3c",
                                    new FeatureMap.Types.StringList
                                    {
                                        Value = { "value60c16320", },
                                    }
                                },
                            },
                            NumericalFeatures =
                            {
                                {
                                    "key8a0b6e3c",
                                    new FeatureMap.Types.FloatList
                                    {
                                        Value = { -7.291809E+17F, },
                                    }
                                },
                            },
                        },
                        ReferrerUri = "referrer_uri4d3a0115",
                    },
                    ProductEventDetail = new ProductEventDetail
                    {
                        SearchQuery = "search_query6ef02091",
                        PageCategories =
                        {
                            new CatalogItem.Types.CategoryHierarchy
                            {
                                Categories =
                                {
                                    "categoriesb4ccb5b0",
                                },
                            },
                        },
                        ProductDetails =
                        {
                            new ProductDetail
                            {
                                Id = "id74b70bb8",
                                CurrencyCode = "currency_code7f81e352",
                                OriginalPrice = 8.0793406E+17F,
                                DisplayPrice = -6.3182856E+16F,
                                StockState = ProductCatalogItem.Types.StockState.OutOfStock,
                                Quantity = 1261051170,
                                AvailableQuantity = 719656040,
                                ItemAttributes = new FeatureMap
                                {
                                    CategoricalFeatures =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            new FeatureMap.Types.StringList
                                            {
                                                Value = { "value60c16320", },
                                            }
                                        },
                                    },
                                    NumericalFeatures =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            new FeatureMap.Types.FloatList
                                            {
                                                Value = { -7.291809E+17F, },
                                            }
                                        },
                                    },
                                },
                            },
                        },
                        ListId = "list_id20e8a34d",
                        CartId = "cart_idf7834dc4",
                        PurchaseTransaction = new PurchaseTransaction
                        {
                            Id = "id74b70bb8",
                            Revenue = -7.227312E+16F,
                            Taxes =
                            {
                                {
                                    "key8a0b6e3c",
                                    -7.291809E+17F
                                },
                            },
                            Costs =
                            {
                                {
                                    "key8a0b6e3c",
                                    -7.291809E+17F
                                },
                            },
                            CurrencyCode = "currency_code7f81e352",
                        },
                    },
                    EventTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    EventSource = UserEvent.Types.EventSource.Automl,
                },
            };
            UserEvent expectedResponse = new UserEvent
            {
                EventType = "event_type1436d01c",
                UserInfo = new UserInfo
                {
                    VisitorId = "visitor_id25f1c2bf",
                    UserId = "user_idd41a70e8",
                    IpAddress = "ip_address46a72553",
                    UserAgent = "user_agent707c6483",
                    DirectUserRequest = true,
                },
                EventDetail = new EventDetail
                {
                    Uri = "uri3db70593",
                    PageViewId = "page_view_id77a7ed70",
                    ExperimentIds =
                    {
                        "experiment_ids9777ca1b",
                    },
                    RecommendationToken = "recommendation_token2a33f3e2",
                    EventAttributes = new FeatureMap
                    {
                        CategoricalFeatures =
                        {
                            {
                                "key8a0b6e3c",
                                new FeatureMap.Types.StringList
                                {
                                    Value = { "value60c16320", },
                                }
                            },
                        },
                        NumericalFeatures =
                        {
                            {
                                "key8a0b6e3c",
                                new FeatureMap.Types.FloatList
                                {
                                    Value = { -7.291809E+17F, },
                                }
                            },
                        },
                    },
                    ReferrerUri = "referrer_uri4d3a0115",
                },
                ProductEventDetail = new ProductEventDetail
                {
                    SearchQuery = "search_query6ef02091",
                    PageCategories =
                    {
                        new CatalogItem.Types.CategoryHierarchy
                        {
                            Categories =
                            {
                                "categoriesb4ccb5b0",
                            },
                        },
                    },
                    ProductDetails =
                    {
                        new ProductDetail
                        {
                            Id = "id74b70bb8",
                            CurrencyCode = "currency_code7f81e352",
                            OriginalPrice = 8.0793406E+17F,
                            DisplayPrice = -6.3182856E+16F,
                            StockState = ProductCatalogItem.Types.StockState.OutOfStock,
                            Quantity = 1261051170,
                            AvailableQuantity = 719656040,
                            ItemAttributes = new FeatureMap
                            {
                                CategoricalFeatures =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new FeatureMap.Types.StringList
                                        {
                                            Value = { "value60c16320", },
                                        }
                                    },
                                },
                                NumericalFeatures =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new FeatureMap.Types.FloatList
                                        {
                                            Value = { -7.291809E+17F, },
                                        }
                                    },
                                },
                            },
                        },
                    },
                    ListId = "list_id20e8a34d",
                    CartId = "cart_idf7834dc4",
                    PurchaseTransaction = new PurchaseTransaction
                    {
                        Id = "id74b70bb8",
                        Revenue = -7.227312E+16F,
                        Taxes =
                        {
                            {
                                "key8a0b6e3c",
                                -7.291809E+17F
                            },
                        },
                        Costs =
                        {
                            {
                                "key8a0b6e3c",
                                -7.291809E+17F
                            },
                        },
                        CurrencyCode = "currency_code7f81e352",
                    },
                },
                EventTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EventSource = UserEvent.Types.EventSource.Automl,
            };
            mockGrpcClient.Setup(x => x.WriteUserEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserEventServiceClient client = new UserEventServiceClientImpl(mockGrpcClient.Object, null);
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
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                UserEvent = new UserEvent
                {
                    EventType = "event_type1436d01c",
                    UserInfo = new UserInfo
                    {
                        VisitorId = "visitor_id25f1c2bf",
                        UserId = "user_idd41a70e8",
                        IpAddress = "ip_address46a72553",
                        UserAgent = "user_agent707c6483",
                        DirectUserRequest = true,
                    },
                    EventDetail = new EventDetail
                    {
                        Uri = "uri3db70593",
                        PageViewId = "page_view_id77a7ed70",
                        ExperimentIds =
                        {
                            "experiment_ids9777ca1b",
                        },
                        RecommendationToken = "recommendation_token2a33f3e2",
                        EventAttributes = new FeatureMap
                        {
                            CategoricalFeatures =
                            {
                                {
                                    "key8a0b6e3c",
                                    new FeatureMap.Types.StringList
                                    {
                                        Value = { "value60c16320", },
                                    }
                                },
                            },
                            NumericalFeatures =
                            {
                                {
                                    "key8a0b6e3c",
                                    new FeatureMap.Types.FloatList
                                    {
                                        Value = { -7.291809E+17F, },
                                    }
                                },
                            },
                        },
                        ReferrerUri = "referrer_uri4d3a0115",
                    },
                    ProductEventDetail = new ProductEventDetail
                    {
                        SearchQuery = "search_query6ef02091",
                        PageCategories =
                        {
                            new CatalogItem.Types.CategoryHierarchy
                            {
                                Categories =
                                {
                                    "categoriesb4ccb5b0",
                                },
                            },
                        },
                        ProductDetails =
                        {
                            new ProductDetail
                            {
                                Id = "id74b70bb8",
                                CurrencyCode = "currency_code7f81e352",
                                OriginalPrice = 8.0793406E+17F,
                                DisplayPrice = -6.3182856E+16F,
                                StockState = ProductCatalogItem.Types.StockState.OutOfStock,
                                Quantity = 1261051170,
                                AvailableQuantity = 719656040,
                                ItemAttributes = new FeatureMap
                                {
                                    CategoricalFeatures =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            new FeatureMap.Types.StringList
                                            {
                                                Value = { "value60c16320", },
                                            }
                                        },
                                    },
                                    NumericalFeatures =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            new FeatureMap.Types.FloatList
                                            {
                                                Value = { -7.291809E+17F, },
                                            }
                                        },
                                    },
                                },
                            },
                        },
                        ListId = "list_id20e8a34d",
                        CartId = "cart_idf7834dc4",
                        PurchaseTransaction = new PurchaseTransaction
                        {
                            Id = "id74b70bb8",
                            Revenue = -7.227312E+16F,
                            Taxes =
                            {
                                {
                                    "key8a0b6e3c",
                                    -7.291809E+17F
                                },
                            },
                            Costs =
                            {
                                {
                                    "key8a0b6e3c",
                                    -7.291809E+17F
                                },
                            },
                            CurrencyCode = "currency_code7f81e352",
                        },
                    },
                    EventTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    EventSource = UserEvent.Types.EventSource.Automl,
                },
            };
            UserEvent expectedResponse = new UserEvent
            {
                EventType = "event_type1436d01c",
                UserInfo = new UserInfo
                {
                    VisitorId = "visitor_id25f1c2bf",
                    UserId = "user_idd41a70e8",
                    IpAddress = "ip_address46a72553",
                    UserAgent = "user_agent707c6483",
                    DirectUserRequest = true,
                },
                EventDetail = new EventDetail
                {
                    Uri = "uri3db70593",
                    PageViewId = "page_view_id77a7ed70",
                    ExperimentIds =
                    {
                        "experiment_ids9777ca1b",
                    },
                    RecommendationToken = "recommendation_token2a33f3e2",
                    EventAttributes = new FeatureMap
                    {
                        CategoricalFeatures =
                        {
                            {
                                "key8a0b6e3c",
                                new FeatureMap.Types.StringList
                                {
                                    Value = { "value60c16320", },
                                }
                            },
                        },
                        NumericalFeatures =
                        {
                            {
                                "key8a0b6e3c",
                                new FeatureMap.Types.FloatList
                                {
                                    Value = { -7.291809E+17F, },
                                }
                            },
                        },
                    },
                    ReferrerUri = "referrer_uri4d3a0115",
                },
                ProductEventDetail = new ProductEventDetail
                {
                    SearchQuery = "search_query6ef02091",
                    PageCategories =
                    {
                        new CatalogItem.Types.CategoryHierarchy
                        {
                            Categories =
                            {
                                "categoriesb4ccb5b0",
                            },
                        },
                    },
                    ProductDetails =
                    {
                        new ProductDetail
                        {
                            Id = "id74b70bb8",
                            CurrencyCode = "currency_code7f81e352",
                            OriginalPrice = 8.0793406E+17F,
                            DisplayPrice = -6.3182856E+16F,
                            StockState = ProductCatalogItem.Types.StockState.OutOfStock,
                            Quantity = 1261051170,
                            AvailableQuantity = 719656040,
                            ItemAttributes = new FeatureMap
                            {
                                CategoricalFeatures =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new FeatureMap.Types.StringList
                                        {
                                            Value = { "value60c16320", },
                                        }
                                    },
                                },
                                NumericalFeatures =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new FeatureMap.Types.FloatList
                                        {
                                            Value = { -7.291809E+17F, },
                                        }
                                    },
                                },
                            },
                        },
                    },
                    ListId = "list_id20e8a34d",
                    CartId = "cart_idf7834dc4",
                    PurchaseTransaction = new PurchaseTransaction
                    {
                        Id = "id74b70bb8",
                        Revenue = -7.227312E+16F,
                        Taxes =
                        {
                            {
                                "key8a0b6e3c",
                                -7.291809E+17F
                            },
                        },
                        Costs =
                        {
                            {
                                "key8a0b6e3c",
                                -7.291809E+17F
                            },
                        },
                        CurrencyCode = "currency_code7f81e352",
                    },
                },
                EventTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EventSource = UserEvent.Types.EventSource.Automl,
            };
            mockGrpcClient.Setup(x => x.WriteUserEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserEvent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserEventServiceClient client = new UserEventServiceClientImpl(mockGrpcClient.Object, null);
            UserEvent responseCallSettings = await client.WriteUserEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserEvent responseCancellationToken = await client.WriteUserEventAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void WriteUserEvent()
        {
            moq::Mock<UserEventService.UserEventServiceClient> mockGrpcClient = new moq::Mock<UserEventService.UserEventServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            WriteUserEventRequest request = new WriteUserEventRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                UserEvent = new UserEvent
                {
                    EventType = "event_type1436d01c",
                    UserInfo = new UserInfo
                    {
                        VisitorId = "visitor_id25f1c2bf",
                        UserId = "user_idd41a70e8",
                        IpAddress = "ip_address46a72553",
                        UserAgent = "user_agent707c6483",
                        DirectUserRequest = true,
                    },
                    EventDetail = new EventDetail
                    {
                        Uri = "uri3db70593",
                        PageViewId = "page_view_id77a7ed70",
                        ExperimentIds =
                        {
                            "experiment_ids9777ca1b",
                        },
                        RecommendationToken = "recommendation_token2a33f3e2",
                        EventAttributes = new FeatureMap
                        {
                            CategoricalFeatures =
                            {
                                {
                                    "key8a0b6e3c",
                                    new FeatureMap.Types.StringList
                                    {
                                        Value = { "value60c16320", },
                                    }
                                },
                            },
                            NumericalFeatures =
                            {
                                {
                                    "key8a0b6e3c",
                                    new FeatureMap.Types.FloatList
                                    {
                                        Value = { -7.291809E+17F, },
                                    }
                                },
                            },
                        },
                        ReferrerUri = "referrer_uri4d3a0115",
                    },
                    ProductEventDetail = new ProductEventDetail
                    {
                        SearchQuery = "search_query6ef02091",
                        PageCategories =
                        {
                            new CatalogItem.Types.CategoryHierarchy
                            {
                                Categories =
                                {
                                    "categoriesb4ccb5b0",
                                },
                            },
                        },
                        ProductDetails =
                        {
                            new ProductDetail
                            {
                                Id = "id74b70bb8",
                                CurrencyCode = "currency_code7f81e352",
                                OriginalPrice = 8.0793406E+17F,
                                DisplayPrice = -6.3182856E+16F,
                                StockState = ProductCatalogItem.Types.StockState.OutOfStock,
                                Quantity = 1261051170,
                                AvailableQuantity = 719656040,
                                ItemAttributes = new FeatureMap
                                {
                                    CategoricalFeatures =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            new FeatureMap.Types.StringList
                                            {
                                                Value = { "value60c16320", },
                                            }
                                        },
                                    },
                                    NumericalFeatures =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            new FeatureMap.Types.FloatList
                                            {
                                                Value = { -7.291809E+17F, },
                                            }
                                        },
                                    },
                                },
                            },
                        },
                        ListId = "list_id20e8a34d",
                        CartId = "cart_idf7834dc4",
                        PurchaseTransaction = new PurchaseTransaction
                        {
                            Id = "id74b70bb8",
                            Revenue = -7.227312E+16F,
                            Taxes =
                            {
                                {
                                    "key8a0b6e3c",
                                    -7.291809E+17F
                                },
                            },
                            Costs =
                            {
                                {
                                    "key8a0b6e3c",
                                    -7.291809E+17F
                                },
                            },
                            CurrencyCode = "currency_code7f81e352",
                        },
                    },
                    EventTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    EventSource = UserEvent.Types.EventSource.Automl,
                },
            };
            UserEvent expectedResponse = new UserEvent
            {
                EventType = "event_type1436d01c",
                UserInfo = new UserInfo
                {
                    VisitorId = "visitor_id25f1c2bf",
                    UserId = "user_idd41a70e8",
                    IpAddress = "ip_address46a72553",
                    UserAgent = "user_agent707c6483",
                    DirectUserRequest = true,
                },
                EventDetail = new EventDetail
                {
                    Uri = "uri3db70593",
                    PageViewId = "page_view_id77a7ed70",
                    ExperimentIds =
                    {
                        "experiment_ids9777ca1b",
                    },
                    RecommendationToken = "recommendation_token2a33f3e2",
                    EventAttributes = new FeatureMap
                    {
                        CategoricalFeatures =
                        {
                            {
                                "key8a0b6e3c",
                                new FeatureMap.Types.StringList
                                {
                                    Value = { "value60c16320", },
                                }
                            },
                        },
                        NumericalFeatures =
                        {
                            {
                                "key8a0b6e3c",
                                new FeatureMap.Types.FloatList
                                {
                                    Value = { -7.291809E+17F, },
                                }
                            },
                        },
                    },
                    ReferrerUri = "referrer_uri4d3a0115",
                },
                ProductEventDetail = new ProductEventDetail
                {
                    SearchQuery = "search_query6ef02091",
                    PageCategories =
                    {
                        new CatalogItem.Types.CategoryHierarchy
                        {
                            Categories =
                            {
                                "categoriesb4ccb5b0",
                            },
                        },
                    },
                    ProductDetails =
                    {
                        new ProductDetail
                        {
                            Id = "id74b70bb8",
                            CurrencyCode = "currency_code7f81e352",
                            OriginalPrice = 8.0793406E+17F,
                            DisplayPrice = -6.3182856E+16F,
                            StockState = ProductCatalogItem.Types.StockState.OutOfStock,
                            Quantity = 1261051170,
                            AvailableQuantity = 719656040,
                            ItemAttributes = new FeatureMap
                            {
                                CategoricalFeatures =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new FeatureMap.Types.StringList
                                        {
                                            Value = { "value60c16320", },
                                        }
                                    },
                                },
                                NumericalFeatures =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new FeatureMap.Types.FloatList
                                        {
                                            Value = { -7.291809E+17F, },
                                        }
                                    },
                                },
                            },
                        },
                    },
                    ListId = "list_id20e8a34d",
                    CartId = "cart_idf7834dc4",
                    PurchaseTransaction = new PurchaseTransaction
                    {
                        Id = "id74b70bb8",
                        Revenue = -7.227312E+16F,
                        Taxes =
                        {
                            {
                                "key8a0b6e3c",
                                -7.291809E+17F
                            },
                        },
                        Costs =
                        {
                            {
                                "key8a0b6e3c",
                                -7.291809E+17F
                            },
                        },
                        CurrencyCode = "currency_code7f81e352",
                    },
                },
                EventTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EventSource = UserEvent.Types.EventSource.Automl,
            };
            mockGrpcClient.Setup(x => x.WriteUserEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserEventServiceClient client = new UserEventServiceClientImpl(mockGrpcClient.Object, null);
            UserEvent response = client.WriteUserEvent(request.Parent, request.UserEvent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task WriteUserEventAsync()
        {
            moq::Mock<UserEventService.UserEventServiceClient> mockGrpcClient = new moq::Mock<UserEventService.UserEventServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            WriteUserEventRequest request = new WriteUserEventRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                UserEvent = new UserEvent
                {
                    EventType = "event_type1436d01c",
                    UserInfo = new UserInfo
                    {
                        VisitorId = "visitor_id25f1c2bf",
                        UserId = "user_idd41a70e8",
                        IpAddress = "ip_address46a72553",
                        UserAgent = "user_agent707c6483",
                        DirectUserRequest = true,
                    },
                    EventDetail = new EventDetail
                    {
                        Uri = "uri3db70593",
                        PageViewId = "page_view_id77a7ed70",
                        ExperimentIds =
                        {
                            "experiment_ids9777ca1b",
                        },
                        RecommendationToken = "recommendation_token2a33f3e2",
                        EventAttributes = new FeatureMap
                        {
                            CategoricalFeatures =
                            {
                                {
                                    "key8a0b6e3c",
                                    new FeatureMap.Types.StringList
                                    {
                                        Value = { "value60c16320", },
                                    }
                                },
                            },
                            NumericalFeatures =
                            {
                                {
                                    "key8a0b6e3c",
                                    new FeatureMap.Types.FloatList
                                    {
                                        Value = { -7.291809E+17F, },
                                    }
                                },
                            },
                        },
                        ReferrerUri = "referrer_uri4d3a0115",
                    },
                    ProductEventDetail = new ProductEventDetail
                    {
                        SearchQuery = "search_query6ef02091",
                        PageCategories =
                        {
                            new CatalogItem.Types.CategoryHierarchy
                            {
                                Categories =
                                {
                                    "categoriesb4ccb5b0",
                                },
                            },
                        },
                        ProductDetails =
                        {
                            new ProductDetail
                            {
                                Id = "id74b70bb8",
                                CurrencyCode = "currency_code7f81e352",
                                OriginalPrice = 8.0793406E+17F,
                                DisplayPrice = -6.3182856E+16F,
                                StockState = ProductCatalogItem.Types.StockState.OutOfStock,
                                Quantity = 1261051170,
                                AvailableQuantity = 719656040,
                                ItemAttributes = new FeatureMap
                                {
                                    CategoricalFeatures =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            new FeatureMap.Types.StringList
                                            {
                                                Value = { "value60c16320", },
                                            }
                                        },
                                    },
                                    NumericalFeatures =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            new FeatureMap.Types.FloatList
                                            {
                                                Value = { -7.291809E+17F, },
                                            }
                                        },
                                    },
                                },
                            },
                        },
                        ListId = "list_id20e8a34d",
                        CartId = "cart_idf7834dc4",
                        PurchaseTransaction = new PurchaseTransaction
                        {
                            Id = "id74b70bb8",
                            Revenue = -7.227312E+16F,
                            Taxes =
                            {
                                {
                                    "key8a0b6e3c",
                                    -7.291809E+17F
                                },
                            },
                            Costs =
                            {
                                {
                                    "key8a0b6e3c",
                                    -7.291809E+17F
                                },
                            },
                            CurrencyCode = "currency_code7f81e352",
                        },
                    },
                    EventTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    EventSource = UserEvent.Types.EventSource.Automl,
                },
            };
            UserEvent expectedResponse = new UserEvent
            {
                EventType = "event_type1436d01c",
                UserInfo = new UserInfo
                {
                    VisitorId = "visitor_id25f1c2bf",
                    UserId = "user_idd41a70e8",
                    IpAddress = "ip_address46a72553",
                    UserAgent = "user_agent707c6483",
                    DirectUserRequest = true,
                },
                EventDetail = new EventDetail
                {
                    Uri = "uri3db70593",
                    PageViewId = "page_view_id77a7ed70",
                    ExperimentIds =
                    {
                        "experiment_ids9777ca1b",
                    },
                    RecommendationToken = "recommendation_token2a33f3e2",
                    EventAttributes = new FeatureMap
                    {
                        CategoricalFeatures =
                        {
                            {
                                "key8a0b6e3c",
                                new FeatureMap.Types.StringList
                                {
                                    Value = { "value60c16320", },
                                }
                            },
                        },
                        NumericalFeatures =
                        {
                            {
                                "key8a0b6e3c",
                                new FeatureMap.Types.FloatList
                                {
                                    Value = { -7.291809E+17F, },
                                }
                            },
                        },
                    },
                    ReferrerUri = "referrer_uri4d3a0115",
                },
                ProductEventDetail = new ProductEventDetail
                {
                    SearchQuery = "search_query6ef02091",
                    PageCategories =
                    {
                        new CatalogItem.Types.CategoryHierarchy
                        {
                            Categories =
                            {
                                "categoriesb4ccb5b0",
                            },
                        },
                    },
                    ProductDetails =
                    {
                        new ProductDetail
                        {
                            Id = "id74b70bb8",
                            CurrencyCode = "currency_code7f81e352",
                            OriginalPrice = 8.0793406E+17F,
                            DisplayPrice = -6.3182856E+16F,
                            StockState = ProductCatalogItem.Types.StockState.OutOfStock,
                            Quantity = 1261051170,
                            AvailableQuantity = 719656040,
                            ItemAttributes = new FeatureMap
                            {
                                CategoricalFeatures =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new FeatureMap.Types.StringList
                                        {
                                            Value = { "value60c16320", },
                                        }
                                    },
                                },
                                NumericalFeatures =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new FeatureMap.Types.FloatList
                                        {
                                            Value = { -7.291809E+17F, },
                                        }
                                    },
                                },
                            },
                        },
                    },
                    ListId = "list_id20e8a34d",
                    CartId = "cart_idf7834dc4",
                    PurchaseTransaction = new PurchaseTransaction
                    {
                        Id = "id74b70bb8",
                        Revenue = -7.227312E+16F,
                        Taxes =
                        {
                            {
                                "key8a0b6e3c",
                                -7.291809E+17F
                            },
                        },
                        Costs =
                        {
                            {
                                "key8a0b6e3c",
                                -7.291809E+17F
                            },
                        },
                        CurrencyCode = "currency_code7f81e352",
                    },
                },
                EventTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EventSource = UserEvent.Types.EventSource.Automl,
            };
            mockGrpcClient.Setup(x => x.WriteUserEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserEvent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserEventServiceClient client = new UserEventServiceClientImpl(mockGrpcClient.Object, null);
            UserEvent responseCallSettings = await client.WriteUserEventAsync(request.Parent, request.UserEvent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserEvent responseCancellationToken = await client.WriteUserEventAsync(request.Parent, request.UserEvent, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void WriteUserEventResourceNames()
        {
            moq::Mock<UserEventService.UserEventServiceClient> mockGrpcClient = new moq::Mock<UserEventService.UserEventServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            WriteUserEventRequest request = new WriteUserEventRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                UserEvent = new UserEvent
                {
                    EventType = "event_type1436d01c",
                    UserInfo = new UserInfo
                    {
                        VisitorId = "visitor_id25f1c2bf",
                        UserId = "user_idd41a70e8",
                        IpAddress = "ip_address46a72553",
                        UserAgent = "user_agent707c6483",
                        DirectUserRequest = true,
                    },
                    EventDetail = new EventDetail
                    {
                        Uri = "uri3db70593",
                        PageViewId = "page_view_id77a7ed70",
                        ExperimentIds =
                        {
                            "experiment_ids9777ca1b",
                        },
                        RecommendationToken = "recommendation_token2a33f3e2",
                        EventAttributes = new FeatureMap
                        {
                            CategoricalFeatures =
                            {
                                {
                                    "key8a0b6e3c",
                                    new FeatureMap.Types.StringList
                                    {
                                        Value = { "value60c16320", },
                                    }
                                },
                            },
                            NumericalFeatures =
                            {
                                {
                                    "key8a0b6e3c",
                                    new FeatureMap.Types.FloatList
                                    {
                                        Value = { -7.291809E+17F, },
                                    }
                                },
                            },
                        },
                        ReferrerUri = "referrer_uri4d3a0115",
                    },
                    ProductEventDetail = new ProductEventDetail
                    {
                        SearchQuery = "search_query6ef02091",
                        PageCategories =
                        {
                            new CatalogItem.Types.CategoryHierarchy
                            {
                                Categories =
                                {
                                    "categoriesb4ccb5b0",
                                },
                            },
                        },
                        ProductDetails =
                        {
                            new ProductDetail
                            {
                                Id = "id74b70bb8",
                                CurrencyCode = "currency_code7f81e352",
                                OriginalPrice = 8.0793406E+17F,
                                DisplayPrice = -6.3182856E+16F,
                                StockState = ProductCatalogItem.Types.StockState.OutOfStock,
                                Quantity = 1261051170,
                                AvailableQuantity = 719656040,
                                ItemAttributes = new FeatureMap
                                {
                                    CategoricalFeatures =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            new FeatureMap.Types.StringList
                                            {
                                                Value = { "value60c16320", },
                                            }
                                        },
                                    },
                                    NumericalFeatures =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            new FeatureMap.Types.FloatList
                                            {
                                                Value = { -7.291809E+17F, },
                                            }
                                        },
                                    },
                                },
                            },
                        },
                        ListId = "list_id20e8a34d",
                        CartId = "cart_idf7834dc4",
                        PurchaseTransaction = new PurchaseTransaction
                        {
                            Id = "id74b70bb8",
                            Revenue = -7.227312E+16F,
                            Taxes =
                            {
                                {
                                    "key8a0b6e3c",
                                    -7.291809E+17F
                                },
                            },
                            Costs =
                            {
                                {
                                    "key8a0b6e3c",
                                    -7.291809E+17F
                                },
                            },
                            CurrencyCode = "currency_code7f81e352",
                        },
                    },
                    EventTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    EventSource = UserEvent.Types.EventSource.Automl,
                },
            };
            UserEvent expectedResponse = new UserEvent
            {
                EventType = "event_type1436d01c",
                UserInfo = new UserInfo
                {
                    VisitorId = "visitor_id25f1c2bf",
                    UserId = "user_idd41a70e8",
                    IpAddress = "ip_address46a72553",
                    UserAgent = "user_agent707c6483",
                    DirectUserRequest = true,
                },
                EventDetail = new EventDetail
                {
                    Uri = "uri3db70593",
                    PageViewId = "page_view_id77a7ed70",
                    ExperimentIds =
                    {
                        "experiment_ids9777ca1b",
                    },
                    RecommendationToken = "recommendation_token2a33f3e2",
                    EventAttributes = new FeatureMap
                    {
                        CategoricalFeatures =
                        {
                            {
                                "key8a0b6e3c",
                                new FeatureMap.Types.StringList
                                {
                                    Value = { "value60c16320", },
                                }
                            },
                        },
                        NumericalFeatures =
                        {
                            {
                                "key8a0b6e3c",
                                new FeatureMap.Types.FloatList
                                {
                                    Value = { -7.291809E+17F, },
                                }
                            },
                        },
                    },
                    ReferrerUri = "referrer_uri4d3a0115",
                },
                ProductEventDetail = new ProductEventDetail
                {
                    SearchQuery = "search_query6ef02091",
                    PageCategories =
                    {
                        new CatalogItem.Types.CategoryHierarchy
                        {
                            Categories =
                            {
                                "categoriesb4ccb5b0",
                            },
                        },
                    },
                    ProductDetails =
                    {
                        new ProductDetail
                        {
                            Id = "id74b70bb8",
                            CurrencyCode = "currency_code7f81e352",
                            OriginalPrice = 8.0793406E+17F,
                            DisplayPrice = -6.3182856E+16F,
                            StockState = ProductCatalogItem.Types.StockState.OutOfStock,
                            Quantity = 1261051170,
                            AvailableQuantity = 719656040,
                            ItemAttributes = new FeatureMap
                            {
                                CategoricalFeatures =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new FeatureMap.Types.StringList
                                        {
                                            Value = { "value60c16320", },
                                        }
                                    },
                                },
                                NumericalFeatures =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new FeatureMap.Types.FloatList
                                        {
                                            Value = { -7.291809E+17F, },
                                        }
                                    },
                                },
                            },
                        },
                    },
                    ListId = "list_id20e8a34d",
                    CartId = "cart_idf7834dc4",
                    PurchaseTransaction = new PurchaseTransaction
                    {
                        Id = "id74b70bb8",
                        Revenue = -7.227312E+16F,
                        Taxes =
                        {
                            {
                                "key8a0b6e3c",
                                -7.291809E+17F
                            },
                        },
                        Costs =
                        {
                            {
                                "key8a0b6e3c",
                                -7.291809E+17F
                            },
                        },
                        CurrencyCode = "currency_code7f81e352",
                    },
                },
                EventTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EventSource = UserEvent.Types.EventSource.Automl,
            };
            mockGrpcClient.Setup(x => x.WriteUserEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserEventServiceClient client = new UserEventServiceClientImpl(mockGrpcClient.Object, null);
            UserEvent response = client.WriteUserEvent(request.ParentAsEventStoreName, request.UserEvent);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task WriteUserEventResourceNamesAsync()
        {
            moq::Mock<UserEventService.UserEventServiceClient> mockGrpcClient = new moq::Mock<UserEventService.UserEventServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            WriteUserEventRequest request = new WriteUserEventRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                UserEvent = new UserEvent
                {
                    EventType = "event_type1436d01c",
                    UserInfo = new UserInfo
                    {
                        VisitorId = "visitor_id25f1c2bf",
                        UserId = "user_idd41a70e8",
                        IpAddress = "ip_address46a72553",
                        UserAgent = "user_agent707c6483",
                        DirectUserRequest = true,
                    },
                    EventDetail = new EventDetail
                    {
                        Uri = "uri3db70593",
                        PageViewId = "page_view_id77a7ed70",
                        ExperimentIds =
                        {
                            "experiment_ids9777ca1b",
                        },
                        RecommendationToken = "recommendation_token2a33f3e2",
                        EventAttributes = new FeatureMap
                        {
                            CategoricalFeatures =
                            {
                                {
                                    "key8a0b6e3c",
                                    new FeatureMap.Types.StringList
                                    {
                                        Value = { "value60c16320", },
                                    }
                                },
                            },
                            NumericalFeatures =
                            {
                                {
                                    "key8a0b6e3c",
                                    new FeatureMap.Types.FloatList
                                    {
                                        Value = { -7.291809E+17F, },
                                    }
                                },
                            },
                        },
                        ReferrerUri = "referrer_uri4d3a0115",
                    },
                    ProductEventDetail = new ProductEventDetail
                    {
                        SearchQuery = "search_query6ef02091",
                        PageCategories =
                        {
                            new CatalogItem.Types.CategoryHierarchy
                            {
                                Categories =
                                {
                                    "categoriesb4ccb5b0",
                                },
                            },
                        },
                        ProductDetails =
                        {
                            new ProductDetail
                            {
                                Id = "id74b70bb8",
                                CurrencyCode = "currency_code7f81e352",
                                OriginalPrice = 8.0793406E+17F,
                                DisplayPrice = -6.3182856E+16F,
                                StockState = ProductCatalogItem.Types.StockState.OutOfStock,
                                Quantity = 1261051170,
                                AvailableQuantity = 719656040,
                                ItemAttributes = new FeatureMap
                                {
                                    CategoricalFeatures =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            new FeatureMap.Types.StringList
                                            {
                                                Value = { "value60c16320", },
                                            }
                                        },
                                    },
                                    NumericalFeatures =
                                    {
                                        {
                                            "key8a0b6e3c",
                                            new FeatureMap.Types.FloatList
                                            {
                                                Value = { -7.291809E+17F, },
                                            }
                                        },
                                    },
                                },
                            },
                        },
                        ListId = "list_id20e8a34d",
                        CartId = "cart_idf7834dc4",
                        PurchaseTransaction = new PurchaseTransaction
                        {
                            Id = "id74b70bb8",
                            Revenue = -7.227312E+16F,
                            Taxes =
                            {
                                {
                                    "key8a0b6e3c",
                                    -7.291809E+17F
                                },
                            },
                            Costs =
                            {
                                {
                                    "key8a0b6e3c",
                                    -7.291809E+17F
                                },
                            },
                            CurrencyCode = "currency_code7f81e352",
                        },
                    },
                    EventTime = new wkt::Timestamp
                    {
                        Seconds = -2106654494186127752L,
                        Nanos = 985689544,
                    },
                    EventSource = UserEvent.Types.EventSource.Automl,
                },
            };
            UserEvent expectedResponse = new UserEvent
            {
                EventType = "event_type1436d01c",
                UserInfo = new UserInfo
                {
                    VisitorId = "visitor_id25f1c2bf",
                    UserId = "user_idd41a70e8",
                    IpAddress = "ip_address46a72553",
                    UserAgent = "user_agent707c6483",
                    DirectUserRequest = true,
                },
                EventDetail = new EventDetail
                {
                    Uri = "uri3db70593",
                    PageViewId = "page_view_id77a7ed70",
                    ExperimentIds =
                    {
                        "experiment_ids9777ca1b",
                    },
                    RecommendationToken = "recommendation_token2a33f3e2",
                    EventAttributes = new FeatureMap
                    {
                        CategoricalFeatures =
                        {
                            {
                                "key8a0b6e3c",
                                new FeatureMap.Types.StringList
                                {
                                    Value = { "value60c16320", },
                                }
                            },
                        },
                        NumericalFeatures =
                        {
                            {
                                "key8a0b6e3c",
                                new FeatureMap.Types.FloatList
                                {
                                    Value = { -7.291809E+17F, },
                                }
                            },
                        },
                    },
                    ReferrerUri = "referrer_uri4d3a0115",
                },
                ProductEventDetail = new ProductEventDetail
                {
                    SearchQuery = "search_query6ef02091",
                    PageCategories =
                    {
                        new CatalogItem.Types.CategoryHierarchy
                        {
                            Categories =
                            {
                                "categoriesb4ccb5b0",
                            },
                        },
                    },
                    ProductDetails =
                    {
                        new ProductDetail
                        {
                            Id = "id74b70bb8",
                            CurrencyCode = "currency_code7f81e352",
                            OriginalPrice = 8.0793406E+17F,
                            DisplayPrice = -6.3182856E+16F,
                            StockState = ProductCatalogItem.Types.StockState.OutOfStock,
                            Quantity = 1261051170,
                            AvailableQuantity = 719656040,
                            ItemAttributes = new FeatureMap
                            {
                                CategoricalFeatures =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new FeatureMap.Types.StringList
                                        {
                                            Value = { "value60c16320", },
                                        }
                                    },
                                },
                                NumericalFeatures =
                                {
                                    {
                                        "key8a0b6e3c",
                                        new FeatureMap.Types.FloatList
                                        {
                                            Value = { -7.291809E+17F, },
                                        }
                                    },
                                },
                            },
                        },
                    },
                    ListId = "list_id20e8a34d",
                    CartId = "cart_idf7834dc4",
                    PurchaseTransaction = new PurchaseTransaction
                    {
                        Id = "id74b70bb8",
                        Revenue = -7.227312E+16F,
                        Taxes =
                        {
                            {
                                "key8a0b6e3c",
                                -7.291809E+17F
                            },
                        },
                        Costs =
                        {
                            {
                                "key8a0b6e3c",
                                -7.291809E+17F
                            },
                        },
                        CurrencyCode = "currency_code7f81e352",
                    },
                },
                EventTime = new wkt::Timestamp
                {
                    Seconds = -2106654494186127752L,
                    Nanos = 985689544,
                },
                EventSource = UserEvent.Types.EventSource.Automl,
            };
            mockGrpcClient.Setup(x => x.WriteUserEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UserEvent>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserEventServiceClient client = new UserEventServiceClientImpl(mockGrpcClient.Object, null);
            UserEvent responseCallSettings = await client.WriteUserEventAsync(request.ParentAsEventStoreName, request.UserEvent, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            UserEvent responseCancellationToken = await client.WriteUserEventAsync(request.ParentAsEventStoreName, request.UserEvent, st::CancellationToken.None);
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
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                UserEvent = "user_eventc8146d99",
                Uri = "uri3db70593",
                Ets = -4649673071663131288L,
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions =
                {
                    new wkt::Any
                    {
                        TypeUrl = "type_urlfde5623b",
                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CollectUserEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserEventServiceClient client = new UserEventServiceClientImpl(mockGrpcClient.Object, null);
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
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                UserEvent = "user_eventc8146d99",
                Uri = "uri3db70593",
                Ets = -4649673071663131288L,
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions =
                {
                    new wkt::Any
                    {
                        TypeUrl = "type_urlfde5623b",
                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CollectUserEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::HttpBody>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserEventServiceClient client = new UserEventServiceClientImpl(mockGrpcClient.Object, null);
            ga::HttpBody responseCallSettings = await client.CollectUserEventAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::HttpBody responseCancellationToken = await client.CollectUserEventAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CollectUserEvent()
        {
            moq::Mock<UserEventService.UserEventServiceClient> mockGrpcClient = new moq::Mock<UserEventService.UserEventServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CollectUserEventRequest request = new CollectUserEventRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                UserEvent = "user_eventc8146d99",
                Uri = "uri3db70593",
                Ets = -4649673071663131288L,
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions =
                {
                    new wkt::Any
                    {
                        TypeUrl = "type_urlfde5623b",
                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CollectUserEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserEventServiceClient client = new UserEventServiceClientImpl(mockGrpcClient.Object, null);
            ga::HttpBody response = client.CollectUserEvent(request.Parent, request.UserEvent, request.Uri, request.Ets);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CollectUserEventAsync()
        {
            moq::Mock<UserEventService.UserEventServiceClient> mockGrpcClient = new moq::Mock<UserEventService.UserEventServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CollectUserEventRequest request = new CollectUserEventRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                UserEvent = "user_eventc8146d99",
                Uri = "uri3db70593",
                Ets = -4649673071663131288L,
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions =
                {
                    new wkt::Any
                    {
                        TypeUrl = "type_urlfde5623b",
                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CollectUserEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::HttpBody>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserEventServiceClient client = new UserEventServiceClientImpl(mockGrpcClient.Object, null);
            ga::HttpBody responseCallSettings = await client.CollectUserEventAsync(request.Parent, request.UserEvent, request.Uri, request.Ets, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::HttpBody responseCancellationToken = await client.CollectUserEventAsync(request.Parent, request.UserEvent, request.Uri, request.Ets, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void CollectUserEventResourceNames()
        {
            moq::Mock<UserEventService.UserEventServiceClient> mockGrpcClient = new moq::Mock<UserEventService.UserEventServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CollectUserEventRequest request = new CollectUserEventRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                UserEvent = "user_eventc8146d99",
                Uri = "uri3db70593",
                Ets = -4649673071663131288L,
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions =
                {
                    new wkt::Any
                    {
                        TypeUrl = "type_urlfde5623b",
                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CollectUserEvent(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserEventServiceClient client = new UserEventServiceClientImpl(mockGrpcClient.Object, null);
            ga::HttpBody response = client.CollectUserEvent(request.ParentAsEventStoreName, request.UserEvent, request.Uri, request.Ets);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task CollectUserEventResourceNamesAsync()
        {
            moq::Mock<UserEventService.UserEventServiceClient> mockGrpcClient = new moq::Mock<UserEventService.UserEventServiceClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            CollectUserEventRequest request = new CollectUserEventRequest
            {
                ParentAsEventStoreName = EventStoreName.FromProjectLocationCatalogEventStore("[PROJECT]", "[LOCATION]", "[CATALOG]", "[EVENT_STORE]"),
                UserEvent = "user_eventc8146d99",
                Uri = "uri3db70593",
                Ets = -4649673071663131288L,
            };
            ga::HttpBody expectedResponse = new ga::HttpBody
            {
                ContentType = "content_type085be0ea",
                Data = proto::ByteString.CopyFromUtf8("data387f778d"),
                Extensions =
                {
                    new wkt::Any
                    {
                        TypeUrl = "type_urlfde5623b",
                        Value = proto::ByteString.CopyFromUtf8("value60c16320"),
                    },
                },
            };
            mockGrpcClient.Setup(x => x.CollectUserEventAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ga::HttpBody>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserEventServiceClient client = new UserEventServiceClientImpl(mockGrpcClient.Object, null);
            ga::HttpBody responseCallSettings = await client.CollectUserEventAsync(request.ParentAsEventStoreName, request.UserEvent, request.Uri, request.Ets, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ga::HttpBody responseCancellationToken = await client.CollectUserEventAsync(request.ParentAsEventStoreName, request.UserEvent, request.Uri, request.Ets, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
