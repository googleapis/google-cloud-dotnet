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
    public sealed class GeneratedPublicAdvertisedPrefixesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient> mockGrpcClient = new moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPublicAdvertisedPrefixeRequest request = new GetPublicAdvertisedPrefixeRequest
            {
                PublicAdvertisedPrefix = "public_advertised_prefix53682ff1",
                Project = "projectaa6ff846",
            };
            PublicAdvertisedPrefix expectedResponse = new PublicAdvertisedPrefix
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                IpCidrRange = "ip_cidr_range745a04d3",
                Status = "status5444cb9a",
                Fingerprint = "fingerprint009e6052",
                DnsVerificationIp = "dns_verification_ipd7378841",
                SharedSecret = "shared_secret3a48b317",
                Description = "description2cf9da67",
                PublicDelegatedPrefixs =
                {
                    new PublicAdvertisedPrefixPublicDelegatedPrefix(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublicAdvertisedPrefixesClient client = new PublicAdvertisedPrefixesClientImpl(mockGrpcClient.Object, null);
            PublicAdvertisedPrefix response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient> mockGrpcClient = new moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPublicAdvertisedPrefixeRequest request = new GetPublicAdvertisedPrefixeRequest
            {
                PublicAdvertisedPrefix = "public_advertised_prefix53682ff1",
                Project = "projectaa6ff846",
            };
            PublicAdvertisedPrefix expectedResponse = new PublicAdvertisedPrefix
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                IpCidrRange = "ip_cidr_range745a04d3",
                Status = "status5444cb9a",
                Fingerprint = "fingerprint009e6052",
                DnsVerificationIp = "dns_verification_ipd7378841",
                SharedSecret = "shared_secret3a48b317",
                Description = "description2cf9da67",
                PublicDelegatedPrefixs =
                {
                    new PublicAdvertisedPrefixPublicDelegatedPrefix(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PublicAdvertisedPrefix>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublicAdvertisedPrefixesClient client = new PublicAdvertisedPrefixesClientImpl(mockGrpcClient.Object, null);
            PublicAdvertisedPrefix responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PublicAdvertisedPrefix responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient> mockGrpcClient = new moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPublicAdvertisedPrefixeRequest request = new GetPublicAdvertisedPrefixeRequest
            {
                PublicAdvertisedPrefix = "public_advertised_prefix53682ff1",
                Project = "projectaa6ff846",
            };
            PublicAdvertisedPrefix expectedResponse = new PublicAdvertisedPrefix
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                IpCidrRange = "ip_cidr_range745a04d3",
                Status = "status5444cb9a",
                Fingerprint = "fingerprint009e6052",
                DnsVerificationIp = "dns_verification_ipd7378841",
                SharedSecret = "shared_secret3a48b317",
                Description = "description2cf9da67",
                PublicDelegatedPrefixs =
                {
                    new PublicAdvertisedPrefixPublicDelegatedPrefix(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PublicAdvertisedPrefixesClient client = new PublicAdvertisedPrefixesClientImpl(mockGrpcClient.Object, null);
            PublicAdvertisedPrefix response = client.Get(request.Project, request.PublicAdvertisedPrefix);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient> mockGrpcClient = new moq::Mock<PublicAdvertisedPrefixes.PublicAdvertisedPrefixesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPublicAdvertisedPrefixeRequest request = new GetPublicAdvertisedPrefixeRequest
            {
                PublicAdvertisedPrefix = "public_advertised_prefix53682ff1",
                Project = "projectaa6ff846",
            };
            PublicAdvertisedPrefix expectedResponse = new PublicAdvertisedPrefix
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                CreationTimestamp = "creation_timestamp235e59a1",
                IpCidrRange = "ip_cidr_range745a04d3",
                Status = "status5444cb9a",
                Fingerprint = "fingerprint009e6052",
                DnsVerificationIp = "dns_verification_ipd7378841",
                SharedSecret = "shared_secret3a48b317",
                Description = "description2cf9da67",
                PublicDelegatedPrefixs =
                {
                    new PublicAdvertisedPrefixPublicDelegatedPrefix(),
                },
                SelfLink = "self_link7e87f12d",
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<PublicAdvertisedPrefix>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PublicAdvertisedPrefixesClient client = new PublicAdvertisedPrefixesClientImpl(mockGrpcClient.Object, null);
            PublicAdvertisedPrefix responseCallSettings = await client.GetAsync(request.Project, request.PublicAdvertisedPrefix, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            PublicAdvertisedPrefix responseCancellationToken = await client.GetAsync(request.Project, request.PublicAdvertisedPrefix, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
