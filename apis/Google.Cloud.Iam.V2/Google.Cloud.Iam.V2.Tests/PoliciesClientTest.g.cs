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
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Iam.V2.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedPoliciesClientTest
    {
        [xunit::FactAttribute]
        public void GetPolicyRequestObject()
        {
            moq::Mock<Policies.PoliciesClient> mockGrpcClient = new moq::Mock<Policies.PoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPolicyRequest request = new GetPolicyRequest
            {
                Name = "name1c9368b0",
            };
            Policy expectedResponse = new Policy
            {
                Name = "name1c9368b0",
                Uid = "uida2d37198",
                Kind = "kindf7aa39d9",
                DisplayName = "display_name137f65c2",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Rules = { new PolicyRule(), },
                ManagingAuthority = "managing_authority7ca5f743",
            };
            mockGrpcClient.Setup(x => x.GetPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PoliciesClient client = new PoliciesClientImpl(mockGrpcClient.Object, null, null);
            Policy response = client.GetPolicy(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPolicyRequestObjectAsync()
        {
            moq::Mock<Policies.PoliciesClient> mockGrpcClient = new moq::Mock<Policies.PoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPolicyRequest request = new GetPolicyRequest
            {
                Name = "name1c9368b0",
            };
            Policy expectedResponse = new Policy
            {
                Name = "name1c9368b0",
                Uid = "uida2d37198",
                Kind = "kindf7aa39d9",
                DisplayName = "display_name137f65c2",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Rules = { new PolicyRule(), },
                ManagingAuthority = "managing_authority7ca5f743",
            };
            mockGrpcClient.Setup(x => x.GetPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PoliciesClient client = new PoliciesClientImpl(mockGrpcClient.Object, null, null);
            Policy responseCallSettings = await client.GetPolicyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetPolicyAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void GetPolicy()
        {
            moq::Mock<Policies.PoliciesClient> mockGrpcClient = new moq::Mock<Policies.PoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPolicyRequest request = new GetPolicyRequest
            {
                Name = "name1c9368b0",
            };
            Policy expectedResponse = new Policy
            {
                Name = "name1c9368b0",
                Uid = "uida2d37198",
                Kind = "kindf7aa39d9",
                DisplayName = "display_name137f65c2",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Rules = { new PolicyRule(), },
                ManagingAuthority = "managing_authority7ca5f743",
            };
            mockGrpcClient.Setup(x => x.GetPolicy(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            PoliciesClient client = new PoliciesClientImpl(mockGrpcClient.Object, null, null);
            Policy response = client.GetPolicy(request.Name);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetPolicyAsync()
        {
            moq::Mock<Policies.PoliciesClient> mockGrpcClient = new moq::Mock<Policies.PoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClient()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetPolicyRequest request = new GetPolicyRequest
            {
                Name = "name1c9368b0",
            };
            Policy expectedResponse = new Policy
            {
                Name = "name1c9368b0",
                Uid = "uida2d37198",
                Kind = "kindf7aa39d9",
                DisplayName = "display_name137f65c2",
                Annotations =
                {
                    {
                        "key8a0b6e3c",
                        "value60c16320"
                    },
                },
                Etag = "etage8ad7218",
                CreateTime = new wkt::Timestamp(),
                UpdateTime = new wkt::Timestamp(),
                DeleteTime = new wkt::Timestamp(),
                Rules = { new PolicyRule(), },
                ManagingAuthority = "managing_authority7ca5f743",
            };
            mockGrpcClient.Setup(x => x.GetPolicyAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<Policy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            PoliciesClient client = new PoliciesClientImpl(mockGrpcClient.Object, null, null);
            Policy responseCallSettings = await client.GetPolicyAsync(request.Name, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            Policy responseCancellationToken = await client.GetPolicyAsync(request.Name, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
