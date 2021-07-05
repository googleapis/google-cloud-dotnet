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
    public sealed class GeneratedZonesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<Zones.ZonesClient> mockGrpcClient = new moq::Mock<Zones.ZonesClient>(moq::MockBehavior.Strict);
            GetZoneRequest request = new GetZoneRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
            };
            Zone expectedResponse = new Zone
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SupportsPzs = false,
                Region = "regionedb20d96",
                AvailableCpuPlatforms =
                {
                    "available_cpu_platforms1e56dc3a",
                },
                Status = Zone.Types.Status.Up,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ZonesClient client = new ZonesClientImpl(mockGrpcClient.Object, null);
            Zone response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<Zones.ZonesClient> mockGrpcClient = new moq::Mock<Zones.ZonesClient>(moq::MockBehavior.Strict);
            GetZoneRequest request = new GetZoneRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
            };
            Zone expectedResponse = new Zone
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SupportsPzs = false,
                Region = "regionedb20d96",
                AvailableCpuPlatforms =
                {
                    "available_cpu_platforms1e56dc3a",
                },
                Status = Zone.Types.Status.Up,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Zone>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ZonesClient client = new ZonesClientImpl(mockGrpcClient.Object, null);
            Zone responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Zone responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<Zones.ZonesClient> mockGrpcClient = new moq::Mock<Zones.ZonesClient>(moq::MockBehavior.Strict);
            GetZoneRequest request = new GetZoneRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
            };
            Zone expectedResponse = new Zone
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SupportsPzs = false,
                Region = "regionedb20d96",
                AvailableCpuPlatforms =
                {
                    "available_cpu_platforms1e56dc3a",
                },
                Status = Zone.Types.Status.Up,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ZonesClient client = new ZonesClientImpl(mockGrpcClient.Object, null);
            Zone response = client.Get(request.Project, request.Zone);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<Zones.ZonesClient> mockGrpcClient = new moq::Mock<Zones.ZonesClient>(moq::MockBehavior.Strict);
            GetZoneRequest request = new GetZoneRequest
            {
                Zone = "zone255f4ea8",
                Project = "projectaa6ff846",
            };
            Zone expectedResponse = new Zone
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SupportsPzs = false,
                Region = "regionedb20d96",
                AvailableCpuPlatforms =
                {
                    "available_cpu_platforms1e56dc3a",
                },
                Status = Zone.Types.Status.Up,
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Zone>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ZonesClient client = new ZonesClientImpl(mockGrpcClient.Object, null);
            Zone responseCallSettings = await client.GetAsync(request.Project, request.Zone, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Zone responseCancellationToken = await client.GetAsync(request.Project, request.Zone, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListRequestObject()
        {
            moq::Mock<Zones.ZonesClient> mockGrpcClient = new moq::Mock<Zones.ZonesClient>(moq::MockBehavior.Strict);
            ListZonesRequest request = new ListZonesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            ZoneList expectedResponse = new ZoneList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Zone(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ZonesClient client = new ZonesClientImpl(mockGrpcClient.Object, null);
            ZoneList response = client.List(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListRequestObjectAsync()
        {
            moq::Mock<Zones.ZonesClient> mockGrpcClient = new moq::Mock<Zones.ZonesClient>(moq::MockBehavior.Strict);
            ListZonesRequest request = new ListZonesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            ZoneList expectedResponse = new ZoneList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Zone(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ZoneList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ZonesClient client = new ZonesClientImpl(mockGrpcClient.Object, null);
            ZoneList responseCallSettings = await client.ListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ZoneList responseCancellationToken = await client.ListAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void List()
        {
            moq::Mock<Zones.ZonesClient> mockGrpcClient = new moq::Mock<Zones.ZonesClient>(moq::MockBehavior.Strict);
            ListZonesRequest request = new ListZonesRequest
            {
                Project = "projectaa6ff846",
            };
            ZoneList expectedResponse = new ZoneList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Zone(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.List(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            ZonesClient client = new ZonesClientImpl(mockGrpcClient.Object, null);
            ZoneList response = client.List(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAsync()
        {
            moq::Mock<Zones.ZonesClient> mockGrpcClient = new moq::Mock<Zones.ZonesClient>(moq::MockBehavior.Strict);
            ListZonesRequest request = new ListZonesRequest
            {
                Project = "projectaa6ff846",
            };
            ZoneList expectedResponse = new ZoneList
            {
                Id = "id74b70bb8",
                Kind = "kindf7aa39d9",
                Warning = new Warning(),
                NextPageToken = "next_page_tokendbee0940",
                Items = { new Zone(), },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.ListAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<ZoneList>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            ZonesClient client = new ZonesClientImpl(mockGrpcClient.Object, null);
            ZoneList responseCallSettings = await client.ListAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            ZoneList responseCancellationToken = await client.ListAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
