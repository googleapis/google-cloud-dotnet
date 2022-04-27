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

using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedRegionsClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<Regions.RegionsClient> mockGrpcClient = new moq::Mock<Regions.RegionsClient>(moq::MockBehavior.Strict);
            GetRegionRequest request = new GetRegionRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            Region expectedResponse = new Region
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SupportsPzs = false,
                Zones = { "zones3641f926", },
                Quotas = { new Quota(), },
                Status = "status5444cb9a",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionsClient client = new RegionsClientImpl(mockGrpcClient.Object, null, null);
            Region response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<Regions.RegionsClient> mockGrpcClient = new moq::Mock<Regions.RegionsClient>(moq::MockBehavior.Strict);
            GetRegionRequest request = new GetRegionRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            Region expectedResponse = new Region
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SupportsPzs = false,
                Zones = { "zones3641f926", },
                Quotas = { new Quota(), },
                Status = "status5444cb9a",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Region>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionsClient client = new RegionsClientImpl(mockGrpcClient.Object, null, null);
            Region responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Region responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<Regions.RegionsClient> mockGrpcClient = new moq::Mock<Regions.RegionsClient>(moq::MockBehavior.Strict);
            GetRegionRequest request = new GetRegionRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            Region expectedResponse = new Region
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SupportsPzs = false,
                Zones = { "zones3641f926", },
                Quotas = { new Quota(), },
                Status = "status5444cb9a",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            RegionsClient client = new RegionsClientImpl(mockGrpcClient.Object, null, null);
            Region response = client.Get(request.Project, request.Region);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<Regions.RegionsClient> mockGrpcClient = new moq::Mock<Regions.RegionsClient>(moq::MockBehavior.Strict);
            GetRegionRequest request = new GetRegionRequest
            {
                Region = "regionedb20d96",
                Project = "projectaa6ff846",
            };
            Region expectedResponse = new Region
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SupportsPzs = false,
                Zones = { "zones3641f926", },
                Quotas = { new Quota(), },
                Status = "status5444cb9a",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Deprecated = new DeprecationStatus(),
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Region>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            RegionsClient client = new RegionsClientImpl(mockGrpcClient.Object, null, null);
            Region responseCallSettings = await client.GetAsync(request.Project, request.Region, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Region responseCancellationToken = await client.GetAsync(request.Project, request.Region, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
