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

using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAcceleratorTypesClientTest
    {
        [xunit::FactAttribute]
        public void AggregatedListRequestObject()
        {
            moq::Mock<AcceleratorTypes.AcceleratorTypesClient> mockGrpcClient = new moq::Mock<AcceleratorTypes.AcceleratorTypesClient>(moq::MockBehavior.Strict);
            AggregatedListAcceleratorTypesRequest request = new AggregatedListAcceleratorTypesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            AcceleratorTypeAggregatedList expectedResponse = new AcceleratorTypeAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new AcceleratorTypesScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AcceleratorTypesClient client = new AcceleratorTypesClientImpl(mockGrpcClient.Object, null);
            AcceleratorTypeAggregatedList response = client.AggregatedList(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListRequestObjectAsync()
        {
            moq::Mock<AcceleratorTypes.AcceleratorTypesClient> mockGrpcClient = new moq::Mock<AcceleratorTypes.AcceleratorTypesClient>(moq::MockBehavior.Strict);
            AggregatedListAcceleratorTypesRequest request = new AggregatedListAcceleratorTypesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            AcceleratorTypeAggregatedList expectedResponse = new AcceleratorTypeAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new AcceleratorTypesScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AcceleratorTypeAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AcceleratorTypesClient client = new AcceleratorTypesClientImpl(mockGrpcClient.Object, null);
            AcceleratorTypeAggregatedList responseCallSettings = await client.AggregatedListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AcceleratorTypeAggregatedList responseCancellationToken = await client.AggregatedListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedList()
        {
            moq::Mock<AcceleratorTypes.AcceleratorTypesClient> mockGrpcClient = new moq::Mock<AcceleratorTypes.AcceleratorTypesClient>(moq::MockBehavior.Strict);
            AggregatedListAcceleratorTypesRequest request = new AggregatedListAcceleratorTypesRequest
            {
                Project = "projectaa6ff846",
            };
            AcceleratorTypeAggregatedList expectedResponse = new AcceleratorTypeAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new AcceleratorTypesScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AcceleratorTypesClient client = new AcceleratorTypesClientImpl(mockGrpcClient.Object, null);
            AcceleratorTypeAggregatedList response = client.AggregatedList(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListAsync()
        {
            moq::Mock<AcceleratorTypes.AcceleratorTypesClient> mockGrpcClient = new moq::Mock<AcceleratorTypes.AcceleratorTypesClient>(moq::MockBehavior.Strict);
            AggregatedListAcceleratorTypesRequest request = new AggregatedListAcceleratorTypesRequest
            {
                Project = "projectaa6ff846",
            };
            AcceleratorTypeAggregatedList expectedResponse = new AcceleratorTypeAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new AcceleratorTypesScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AcceleratorTypeAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AcceleratorTypesClient client = new AcceleratorTypesClientImpl(mockGrpcClient.Object, null);
            AcceleratorTypeAggregatedList responseCallSettings = await client.AggregatedListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AcceleratorTypeAggregatedList responseCancellationToken = await client.AggregatedListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<AcceleratorTypes.AcceleratorTypesClient> mockGrpcClient = new moq::Mock<AcceleratorTypes.AcceleratorTypesClient>(moq::MockBehavior.Strict);
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                Zone = "zone255f4ea8",
                AcceleratorType = "accelerator_type68a25f42",
                Project = "projectaa6ff846",
            };
            AcceleratorType expectedResponse = new AcceleratorType
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                MaximumCardsPerInstance = 739769688,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AcceleratorTypesClient client = new AcceleratorTypesClientImpl(mockGrpcClient.Object, null);
            AcceleratorType response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<AcceleratorTypes.AcceleratorTypesClient> mockGrpcClient = new moq::Mock<AcceleratorTypes.AcceleratorTypesClient>(moq::MockBehavior.Strict);
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                Zone = "zone255f4ea8",
                AcceleratorType = "accelerator_type68a25f42",
                Project = "projectaa6ff846",
            };
            AcceleratorType expectedResponse = new AcceleratorType
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                MaximumCardsPerInstance = 739769688,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AcceleratorType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AcceleratorTypesClient client = new AcceleratorTypesClientImpl(mockGrpcClient.Object, null);
            AcceleratorType responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AcceleratorType responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<AcceleratorTypes.AcceleratorTypesClient> mockGrpcClient = new moq::Mock<AcceleratorTypes.AcceleratorTypesClient>(moq::MockBehavior.Strict);
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                Zone = "zone255f4ea8",
                AcceleratorType = "accelerator_type68a25f42",
                Project = "projectaa6ff846",
            };
            AcceleratorType expectedResponse = new AcceleratorType
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                MaximumCardsPerInstance = 739769688,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AcceleratorTypesClient client = new AcceleratorTypesClientImpl(mockGrpcClient.Object, null);
            AcceleratorType response = client.Get(request.Project, request.Zone, request.AcceleratorType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<AcceleratorTypes.AcceleratorTypesClient> mockGrpcClient = new moq::Mock<AcceleratorTypes.AcceleratorTypesClient>(moq::MockBehavior.Strict);
            GetAcceleratorTypeRequest request = new GetAcceleratorTypeRequest
            {
                Zone = "zone255f4ea8",
                AcceleratorType = "accelerator_type68a25f42",
                Project = "projectaa6ff846",
            };
            AcceleratorType expectedResponse = new AcceleratorType
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                MaximumCardsPerInstance = 739769688,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AcceleratorType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AcceleratorTypesClient client = new AcceleratorTypesClientImpl(mockGrpcClient.Object, null);
            AcceleratorType responseCallSettings = await client.GetAsync(request.Project, request.Zone, request.AcceleratorType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AcceleratorType responseCancellationToken = await client.GetAsync(request.Project, request.Zone, request.AcceleratorType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<AcceleratorTypes.AcceleratorTypesClient> mockGrpcClient = new moq::Mock<AcceleratorTypes.AcceleratorTypesClient>(moq::MockBehavior.Strict);
            ListAcceleratorTypesRequest request = new ListAcceleratorTypesRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            AcceleratorTypeList expectedResponse = new AcceleratorTypeList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new AcceleratorType(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AcceleratorTypesClient client = new AcceleratorTypesClientImpl(mockGrpcClient.Object, null);
            AcceleratorTypeList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<AcceleratorTypes.AcceleratorTypesClient> mockGrpcClient = new moq::Mock<AcceleratorTypes.AcceleratorTypesClient>(moq::MockBehavior.Strict);
            ListAcceleratorTypesRequest request = new ListAcceleratorTypesRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            AcceleratorTypeList expectedResponse = new AcceleratorTypeList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new AcceleratorType(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AcceleratorTypeList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AcceleratorTypesClient client = new AcceleratorTypesClientImpl(mockGrpcClient.Object, null);
            AcceleratorTypeList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AcceleratorTypeList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<AcceleratorTypes.AcceleratorTypesClient> mockGrpcClient = new moq::Mock<AcceleratorTypes.AcceleratorTypesClient>(moq::MockBehavior.Strict);
            ListAcceleratorTypesRequest request = new ListAcceleratorTypesRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
            };
            AcceleratorTypeList expectedResponse = new AcceleratorTypeList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new AcceleratorType(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AcceleratorTypesClient client = new AcceleratorTypesClientImpl(mockGrpcClient.Object, null);
            AcceleratorTypeList response = client.List(request.Project, request.Zone);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<AcceleratorTypes.AcceleratorTypesClient> mockGrpcClient = new moq::Mock<AcceleratorTypes.AcceleratorTypesClient>(moq::MockBehavior.Strict);
            ListAcceleratorTypesRequest request = new ListAcceleratorTypesRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
            };
            AcceleratorTypeList expectedResponse = new AcceleratorTypeList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    new AcceleratorType(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<AcceleratorTypeList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AcceleratorTypesClient client = new AcceleratorTypesClientImpl(mockGrpcClient.Object, null);
            AcceleratorTypeList responseCallSettings = await client.ListAsync(request.Project, request.Zone, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            AcceleratorTypeList responseCancellationToken = await client.ListAsync(request.Project, request.Zone, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
