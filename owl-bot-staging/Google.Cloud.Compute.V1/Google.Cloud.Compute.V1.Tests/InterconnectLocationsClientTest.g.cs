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
    public sealed class GeneratedInterconnectLocationsClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<InterconnectLocations.InterconnectLocationsClient> mockGrpcClient = new moq::Mock<InterconnectLocations.InterconnectLocationsClient>(moq::MockBehavior.Strict);
            GetInterconnectLocationRequest request = new GetInterconnectLocationRequest
            {
                Project = "projectaa6ff846",
                InterconnectLocation = "interconnect_location365a00f5",
            };
            InterconnectLocation expectedResponse = new InterconnectLocation
            {
                Id = 11672635353343658936UL,
                City = "cityead2d54e",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SupportsPzs = false,
                FacilityProviderFacilityId = "facility_provider_facility_id936c09db",
                Continent = "continent4ee8200e",
                AvailabilityZone = "availability_zone1778d0ba",
                Status = "status5444cb9a",
                RegionInfos =
                {
                    new InterconnectLocationRegionInfo(),
                },
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Address = "address04984d88",
                FacilityProvider = "facility_provider3fff5132",
                PeeringdbFacilityId = "peeringdb_facility_idcce67e85",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InterconnectLocationsClient client = new InterconnectLocationsClientImpl(mockGrpcClient.Object, null);
            InterconnectLocation response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<InterconnectLocations.InterconnectLocationsClient> mockGrpcClient = new moq::Mock<InterconnectLocations.InterconnectLocationsClient>(moq::MockBehavior.Strict);
            GetInterconnectLocationRequest request = new GetInterconnectLocationRequest
            {
                Project = "projectaa6ff846",
                InterconnectLocation = "interconnect_location365a00f5",
            };
            InterconnectLocation expectedResponse = new InterconnectLocation
            {
                Id = 11672635353343658936UL,
                City = "cityead2d54e",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SupportsPzs = false,
                FacilityProviderFacilityId = "facility_provider_facility_id936c09db",
                Continent = "continent4ee8200e",
                AvailabilityZone = "availability_zone1778d0ba",
                Status = "status5444cb9a",
                RegionInfos =
                {
                    new InterconnectLocationRegionInfo(),
                },
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Address = "address04984d88",
                FacilityProvider = "facility_provider3fff5132",
                PeeringdbFacilityId = "peeringdb_facility_idcce67e85",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InterconnectLocation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InterconnectLocationsClient client = new InterconnectLocationsClientImpl(mockGrpcClient.Object, null);
            InterconnectLocation responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InterconnectLocation responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<InterconnectLocations.InterconnectLocationsClient> mockGrpcClient = new moq::Mock<InterconnectLocations.InterconnectLocationsClient>(moq::MockBehavior.Strict);
            GetInterconnectLocationRequest request = new GetInterconnectLocationRequest
            {
                Project = "projectaa6ff846",
                InterconnectLocation = "interconnect_location365a00f5",
            };
            InterconnectLocation expectedResponse = new InterconnectLocation
            {
                Id = 11672635353343658936UL,
                City = "cityead2d54e",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SupportsPzs = false,
                FacilityProviderFacilityId = "facility_provider_facility_id936c09db",
                Continent = "continent4ee8200e",
                AvailabilityZone = "availability_zone1778d0ba",
                Status = "status5444cb9a",
                RegionInfos =
                {
                    new InterconnectLocationRegionInfo(),
                },
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Address = "address04984d88",
                FacilityProvider = "facility_provider3fff5132",
                PeeringdbFacilityId = "peeringdb_facility_idcce67e85",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            InterconnectLocationsClient client = new InterconnectLocationsClientImpl(mockGrpcClient.Object, null);
            InterconnectLocation response = client.Get(request.Project, request.InterconnectLocation);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<InterconnectLocations.InterconnectLocationsClient> mockGrpcClient = new moq::Mock<InterconnectLocations.InterconnectLocationsClient>(moq::MockBehavior.Strict);
            GetInterconnectLocationRequest request = new GetInterconnectLocationRequest
            {
                Project = "projectaa6ff846",
                InterconnectLocation = "interconnect_location365a00f5",
            };
            InterconnectLocation expectedResponse = new InterconnectLocation
            {
                Id = 11672635353343658936UL,
                City = "cityead2d54e",
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                SupportsPzs = false,
                FacilityProviderFacilityId = "facility_provider_facility_id936c09db",
                Continent = "continent4ee8200e",
                AvailabilityZone = "availability_zone1778d0ba",
                Status = "status5444cb9a",
                RegionInfos =
                {
                    new InterconnectLocationRegionInfo(),
                },
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                Address = "address04984d88",
                FacilityProvider = "facility_provider3fff5132",
                PeeringdbFacilityId = "peeringdb_facility_idcce67e85",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<InterconnectLocation>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            InterconnectLocationsClient client = new InterconnectLocationsClientImpl(mockGrpcClient.Object, null);
            InterconnectLocation responseCallSettings = await client.GetAsync(request.Project, request.InterconnectLocation, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            InterconnectLocation responseCancellationToken = await client.GetAsync(request.Project, request.InterconnectLocation, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
