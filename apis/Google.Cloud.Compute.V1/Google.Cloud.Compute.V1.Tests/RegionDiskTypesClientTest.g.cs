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
    public sealed class GeneratedRegionDiskTypesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<RegionDiskTypes.RegionDiskTypesClient> mockGrpcClient = new moq::Mock<RegionDiskTypes.RegionDiskTypesClient>(moq::MockBehavior.Strict);
            GetRegionDiskTypeRequest request = new GetRegionDiskTypeRequest
            {
                DiskType = "disk_type355e37bc",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            DiskType expectedResponse = new DiskType
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                DefaultDiskSizeGb = -2608545772571403259L,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                ValidDiskSize = "valid_disk_size58dd558f",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionDiskTypesClient client = new RegionDiskTypesClientImpl(mockGrpcClient.Object, null);
            DiskType response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<RegionDiskTypes.RegionDiskTypesClient> mockGrpcClient = new moq::Mock<RegionDiskTypes.RegionDiskTypesClient>(moq::MockBehavior.Strict);
            GetRegionDiskTypeRequest request = new GetRegionDiskTypeRequest
            {
                DiskType = "disk_type355e37bc",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            DiskType expectedResponse = new DiskType
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                DefaultDiskSizeGb = -2608545772571403259L,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                ValidDiskSize = "valid_disk_size58dd558f",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DiskType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionDiskTypesClient client = new RegionDiskTypesClientImpl(mockGrpcClient.Object, null);
            DiskType responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DiskType responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<RegionDiskTypes.RegionDiskTypesClient> mockGrpcClient = new moq::Mock<RegionDiskTypes.RegionDiskTypesClient>(moq::MockBehavior.Strict);
            GetRegionDiskTypeRequest request = new GetRegionDiskTypeRequest
            {
                DiskType = "disk_type355e37bc",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            DiskType expectedResponse = new DiskType
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                DefaultDiskSizeGb = -2608545772571403259L,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                ValidDiskSize = "valid_disk_size58dd558f",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionDiskTypesClient client = new RegionDiskTypesClientImpl(mockGrpcClient.Object, null);
            DiskType response = client.Get(request.Project, request.Region, request.DiskType);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<RegionDiskTypes.RegionDiskTypesClient> mockGrpcClient = new moq::Mock<RegionDiskTypes.RegionDiskTypesClient>(moq::MockBehavior.Strict);
            GetRegionDiskTypeRequest request = new GetRegionDiskTypeRequest
            {
                DiskType = "disk_type355e37bc",
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            DiskType expectedResponse = new DiskType
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                Zone = "zone255f4ea8",
                CreationTimestamp = "creation_timestamp235e59a1",
                Region = "regionedb20d96",
                DefaultDiskSizeGb = -2608545772571403259L,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                ValidDiskSize = "valid_disk_size58dd558f",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<DiskType>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionDiskTypesClient client = new RegionDiskTypesClientImpl(mockGrpcClient.Object, null);
            DiskType responseCallSettings = await client.GetAsync(request.Project, request.Region, request.DiskType, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            DiskType responseCancellationToken = await client.GetAsync(request.Project, request.Region, request.DiskType, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<RegionDiskTypes.RegionDiskTypesClient> mockGrpcClient = new moq::Mock<RegionDiskTypes.RegionDiskTypesClient>(moq::MockBehavior.Strict);
            ListRegionDiskTypesRequest request = new ListRegionDiskTypesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            RegionDiskTypeList expectedResponse = new RegionDiskTypeList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new DiskType(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionDiskTypesClient client = new RegionDiskTypesClientImpl(mockGrpcClient.Object, null);
            RegionDiskTypeList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<RegionDiskTypes.RegionDiskTypesClient> mockGrpcClient = new moq::Mock<RegionDiskTypes.RegionDiskTypesClient>(moq::MockBehavior.Strict);
            ListRegionDiskTypesRequest request = new ListRegionDiskTypesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                Region = "regionedb20d96",
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            RegionDiskTypeList expectedResponse = new RegionDiskTypeList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new DiskType(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegionDiskTypeList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionDiskTypesClient client = new RegionDiskTypesClientImpl(mockGrpcClient.Object, null);
            RegionDiskTypeList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegionDiskTypeList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<RegionDiskTypes.RegionDiskTypesClient> mockGrpcClient = new moq::Mock<RegionDiskTypes.RegionDiskTypesClient>(moq::MockBehavior.Strict);
            ListRegionDiskTypesRequest request = new ListRegionDiskTypesRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            RegionDiskTypeList expectedResponse = new RegionDiskTypeList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new DiskType(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionDiskTypesClient client = new RegionDiskTypesClientImpl(mockGrpcClient.Object, null);
            RegionDiskTypeList response = client.List(request.Project, request.Region);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<RegionDiskTypes.RegionDiskTypesClient> mockGrpcClient = new moq::Mock<RegionDiskTypes.RegionDiskTypesClient>(moq::MockBehavior.Strict);
            ListRegionDiskTypesRequest request = new ListRegionDiskTypesRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            RegionDiskTypeList expectedResponse = new RegionDiskTypeList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new DiskType(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<RegionDiskTypeList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionDiskTypesClient client = new RegionDiskTypesClientImpl(mockGrpcClient.Object, null);
            RegionDiskTypeList responseCallSettings = await client.ListAsync(request.Project, request.Region, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            RegionDiskTypeList responseCancellationToken = await client.ListAsync(request.Project, request.Region, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
