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
    public sealed class GeneratedNodeTypesClientTest
    {
        [xunit::FactAttribute]
        public void AggregatedListRequestObject()
        {
            moq::Mock<NodeTypes.NodeTypesClient> mockGrpcClient = new moq::Mock<NodeTypes.NodeTypesClient>(moq::MockBehavior.Strict);
            AggregatedListNodeTypesRequest request = new AggregatedListNodeTypesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            NodeTypeAggregatedList expectedResponse = new NodeTypeAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new NodeTypesScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NodeTypesClient client = new NodeTypesClientImpl(mockGrpcClient.Object, null);
            NodeTypeAggregatedList response = client.AggregatedList(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListRequestObjectAsync()
        {
            moq::Mock<NodeTypes.NodeTypesClient> mockGrpcClient = new moq::Mock<NodeTypes.NodeTypesClient>(moq::MockBehavior.Strict);
            AggregatedListNodeTypesRequest request = new AggregatedListNodeTypesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                IncludeAllScopes = false,
                ReturnPartialSuccess = false,
            };
            NodeTypeAggregatedList expectedResponse = new NodeTypeAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new NodeTypesScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NodeTypeAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NodeTypesClient client = new NodeTypesClientImpl(mockGrpcClient.Object, null);
            NodeTypeAggregatedList responseCallSettings = await client.AggregatedListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NodeTypeAggregatedList responseCancellationToken = await client.AggregatedListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void AggregatedList()
        {
            moq::Mock<NodeTypes.NodeTypesClient> mockGrpcClient = new moq::Mock<NodeTypes.NodeTypesClient>(moq::MockBehavior.Strict);
            AggregatedListNodeTypesRequest request = new AggregatedListNodeTypesRequest
            {
                Project = "projectaa6ff846",
            };
            NodeTypeAggregatedList expectedResponse = new NodeTypeAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new NodeTypesScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedList(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NodeTypesClient client = new NodeTypesClientImpl(mockGrpcClient.Object, null);
            NodeTypeAggregatedList response = client.AggregatedList(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task AggregatedListAsync()
        {
            moq::Mock<NodeTypes.NodeTypesClient> mockGrpcClient = new moq::Mock<NodeTypes.NodeTypesClient>(moq::MockBehavior.Strict);
            AggregatedListNodeTypesRequest request = new AggregatedListNodeTypesRequest
            {
                Project = "projectaa6ff846",
            };
            NodeTypeAggregatedList expectedResponse = new NodeTypeAggregatedList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items =
                {
                    {
                        "key8a0b6e3c",
                        new NodeTypesScopedList()
                    },
                },
                Unreachables =
                {
                    "unreachables3ca950ee",
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.AggregatedListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NodeTypeAggregatedList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NodeTypesClient client = new NodeTypesClientImpl(mockGrpcClient.Object, null);
            NodeTypeAggregatedList responseCallSettings = await client.AggregatedListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NodeTypeAggregatedList responseCancellationToken = await client.AggregatedListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<NodeTypes.NodeTypesClient> mockGrpcClient = new moq::Mock<NodeTypes.NodeTypesClient>(moq::MockBehavior.Strict);
            GetNodeTypeRequest request = new GetNodeTypeRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                NodeType = "node_type98c685da",
            };
            NodeType expectedResponse = new NodeType
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                MemoryMb = -1241574521,
                LocalSsdGb = -81635889,
                GuestCpus = 325324266,
                CpuPlatform = "cpu_platformd5794042",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NodeTypesClient client = new NodeTypesClientImpl(mockGrpcClient.Object, null);
            NodeType response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<NodeTypes.NodeTypesClient> mockGrpcClient = new moq::Mock<NodeTypes.NodeTypesClient>(moq::MockBehavior.Strict);
            GetNodeTypeRequest request = new GetNodeTypeRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                NodeType = "node_type98c685da",
            };
            NodeType expectedResponse = new NodeType
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                MemoryMb = -1241574521,
                LocalSsdGb = -81635889,
                GuestCpus = 325324266,
                CpuPlatform = "cpu_platformd5794042",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NodeType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NodeTypesClient client = new NodeTypesClientImpl(mockGrpcClient.Object, null);
            NodeType responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NodeType responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<NodeTypes.NodeTypesClient> mockGrpcClient = new moq::Mock<NodeTypes.NodeTypesClient>(moq::MockBehavior.Strict);
            GetNodeTypeRequest request = new GetNodeTypeRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                NodeType = "node_type98c685da",
            };
            NodeType expectedResponse = new NodeType
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                MemoryMb = -1241574521,
                LocalSsdGb = -81635889,
                GuestCpus = 325324266,
                CpuPlatform = "cpu_platformd5794042",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NodeTypesClient client = new NodeTypesClientImpl(mockGrpcClient.Object, null);
            NodeType response = client.Get(request.Project, request.Zone, request.NodeType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<NodeTypes.NodeTypesClient> mockGrpcClient = new moq::Mock<NodeTypes.NodeTypesClient>(moq::MockBehavior.Strict);
            GetNodeTypeRequest request = new GetNodeTypeRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
                NodeType = "node_type98c685da",
            };
            NodeType expectedResponse = new NodeType
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                MemoryMb = -1241574521,
                LocalSsdGb = -81635889,
                GuestCpus = 325324266,
                CpuPlatform = "cpu_platformd5794042",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NodeType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NodeTypesClient client = new NodeTypesClientImpl(mockGrpcClient.Object, null);
            NodeType responseCallSettings = await client.GetAsync(request.Project, request.Zone, request.NodeType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NodeType responseCancellationToken = await client.GetAsync(request.Project, request.Zone, request.NodeType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<NodeTypes.NodeTypesClient> mockGrpcClient = new moq::Mock<NodeTypes.NodeTypesClient>(moq::MockBehavior.Strict);
            ListNodeTypesRequest request = new ListNodeTypesRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            NodeTypeList expectedResponse = new NodeTypeList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new NodeType(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NodeTypesClient client = new NodeTypesClientImpl(mockGrpcClient.Object, null);
            NodeTypeList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<NodeTypes.NodeTypesClient> mockGrpcClient = new moq::Mock<NodeTypes.NodeTypesClient>(moq::MockBehavior.Strict);
            ListNodeTypesRequest request = new ListNodeTypesRequest
            {
                Zone = "zone255f4ea8",
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            NodeTypeList expectedResponse = new NodeTypeList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new NodeType(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NodeTypeList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NodeTypesClient client = new NodeTypesClientImpl(mockGrpcClient.Object, null);
            NodeTypeList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NodeTypeList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<NodeTypes.NodeTypesClient> mockGrpcClient = new moq::Mock<NodeTypes.NodeTypesClient>(moq::MockBehavior.Strict);
            ListNodeTypesRequest request = new ListNodeTypesRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
            };
            NodeTypeList expectedResponse = new NodeTypeList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new NodeType(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            NodeTypesClient client = new NodeTypesClientImpl(mockGrpcClient.Object, null);
            NodeTypeList response = client.List(request.Project, request.Zone);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<NodeTypes.NodeTypesClient> mockGrpcClient = new moq::Mock<NodeTypes.NodeTypesClient>(moq::MockBehavior.Strict);
            ListNodeTypesRequest request = new ListNodeTypesRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
            };
            NodeTypeList expectedResponse = new NodeTypeList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new NodeType(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<NodeTypeList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            NodeTypesClient client = new NodeTypesClientImpl(mockGrpcClient.Object, null);
            NodeTypeList responseCallSettings = await client.ListAsync(request.Project, request.Zone, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            NodeTypeList responseCancellationToken = await client.ListAsync(request.Project, request.Zone, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
