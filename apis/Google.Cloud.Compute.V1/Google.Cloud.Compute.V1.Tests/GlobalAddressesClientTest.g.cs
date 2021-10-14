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
using lro = Google.LongRunning;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedGlobalAddressesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGlobalAddressRequest request = new GetGlobalAddressRequest
            {
                Project = "projectaa6ff846",
                Address = "address04984d88",
            };
            Address expectedResponse = new Address
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Users = { "users2a5cc69b", },
                Region = "regionedb20d96",
                Status = Address.Types.Status.Reserved,
                Network = "networkd22ce091",
                AddressType = Address.Types.AddressType.Internal,
                IpVersion = Address.Types.IpVersion.UndefinedIpVersion,
                Subnetwork = "subnetworkf55bf572",
                Purpose = Address.Types.Purpose.IpsecInterconnect,
                Description = "description2cf9da67",
                PrefixLength = -686118004,
                SelfLink = "self_link7e87f12d",
                Address_ = "address04984d88",
                NetworkTier = Address.Types.NetworkTier.Standard,
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            Address response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGlobalAddressRequest request = new GetGlobalAddressRequest
            {
                Project = "projectaa6ff846",
                Address = "address04984d88",
            };
            Address expectedResponse = new Address
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Users = { "users2a5cc69b", },
                Region = "regionedb20d96",
                Status = Address.Types.Status.Reserved,
                Network = "networkd22ce091",
                AddressType = Address.Types.AddressType.Internal,
                IpVersion = Address.Types.IpVersion.UndefinedIpVersion,
                Subnetwork = "subnetworkf55bf572",
                Purpose = Address.Types.Purpose.IpsecInterconnect,
                Description = "description2cf9da67",
                PrefixLength = -686118004,
                SelfLink = "self_link7e87f12d",
                Address_ = "address04984d88",
                NetworkTier = Address.Types.NetworkTier.Standard,
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Address>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            Address responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Address responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGlobalAddressRequest request = new GetGlobalAddressRequest
            {
                Project = "projectaa6ff846",
                Address = "address04984d88",
            };
            Address expectedResponse = new Address
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Users = { "users2a5cc69b", },
                Region = "regionedb20d96",
                Status = Address.Types.Status.Reserved,
                Network = "networkd22ce091",
                AddressType = Address.Types.AddressType.Internal,
                IpVersion = Address.Types.IpVersion.UndefinedIpVersion,
                Subnetwork = "subnetworkf55bf572",
                Purpose = Address.Types.Purpose.IpsecInterconnect,
                Description = "description2cf9da67",
                PrefixLength = -686118004,
                SelfLink = "self_link7e87f12d",
                Address_ = "address04984d88",
                NetworkTier = Address.Types.NetworkTier.Standard,
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            Address response = client.Get(request.Project, request.Address);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<GlobalAddresses.GlobalAddressesClient> mockGrpcClient = new moq::Mock<GlobalAddresses.GlobalAddressesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetGlobalAddressRequest request = new GetGlobalAddressRequest
            {
                Project = "projectaa6ff846",
                Address = "address04984d88",
            };
            Address expectedResponse = new Address
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                Users = { "users2a5cc69b", },
                Region = "regionedb20d96",
                Status = Address.Types.Status.Reserved,
                Network = "networkd22ce091",
                AddressType = Address.Types.AddressType.Internal,
                IpVersion = Address.Types.IpVersion.UndefinedIpVersion,
                Subnetwork = "subnetworkf55bf572",
                Purpose = Address.Types.Purpose.IpsecInterconnect,
                Description = "description2cf9da67",
                PrefixLength = -686118004,
                SelfLink = "self_link7e87f12d",
                Address_ = "address04984d88",
                NetworkTier = Address.Types.NetworkTier.Standard,
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Address>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GlobalAddressesClient client = new GlobalAddressesClientImpl(mockGrpcClient.Object, null);
            Address responseCallSettings = await client.GetAsync(request.Project, request.Address, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Address responseCancellationToken = await client.GetAsync(request.Project, request.Address, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
