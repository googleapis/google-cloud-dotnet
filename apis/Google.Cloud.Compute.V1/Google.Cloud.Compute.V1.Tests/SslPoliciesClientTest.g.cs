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
using lro = Google.LongRunning;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using xunit = Xunit;

namespace Google.Cloud.Compute.V1.Tests
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedSslPoliciesClientTest
    {
        [xunit::FactAttribute]
        public void GetRequestObject()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSslPolicyRequest request = new GetSslPolicyRequest
            {
                Project = "projectaa6ff846",
                SslPolicy = "ssl_policybf005a65",
            };
            SslPolicy expectedResponse = new SslPolicy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                MinTlsVersion = "min_tls_versionf843e251",
                CreationTimestamp = "creation_timestamp235e59a1",
                CustomFeatures =
                {
                    "custom_features19916d63",
                },
                Profile = "profile1b48977d",
                Fingerprint = "fingerprint009e6052",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                EnabledFeatures =
                {
                    "enabled_featuresf1f398e0",
                },
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null, null);
            SslPolicy response = client.Get(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetRequestObjectAsync()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSslPolicyRequest request = new GetSslPolicyRequest
            {
                Project = "projectaa6ff846",
                SslPolicy = "ssl_policybf005a65",
            };
            SslPolicy expectedResponse = new SslPolicy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                MinTlsVersion = "min_tls_versionf843e251",
                CreationTimestamp = "creation_timestamp235e59a1",
                CustomFeatures =
                {
                    "custom_features19916d63",
                },
                Profile = "profile1b48977d",
                Fingerprint = "fingerprint009e6052",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                EnabledFeatures =
                {
                    "enabled_featuresf1f398e0",
                },
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SslPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null, null);
            SslPolicy responseCallSettings = await client.GetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SslPolicy responseCancellationToken = await client.GetAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void Get()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSslPolicyRequest request = new GetSslPolicyRequest
            {
                Project = "projectaa6ff846",
                SslPolicy = "ssl_policybf005a65",
            };
            SslPolicy expectedResponse = new SslPolicy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                MinTlsVersion = "min_tls_versionf843e251",
                CreationTimestamp = "creation_timestamp235e59a1",
                CustomFeatures =
                {
                    "custom_features19916d63",
                },
                Profile = "profile1b48977d",
                Fingerprint = "fingerprint009e6052",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                EnabledFeatures =
                {
                    "enabled_featuresf1f398e0",
                },
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.Get(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null, null);
            SslPolicy response = client.Get(request.Project, request.SslPolicy);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task GetAsync()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            GetSslPolicyRequest request = new GetSslPolicyRequest
            {
                Project = "projectaa6ff846",
                SslPolicy = "ssl_policybf005a65",
            };
            SslPolicy expectedResponse = new SslPolicy
            {
                Id = 11672635353343658936UL,
                Kind = "kindf7aa39d9",
                Name = "name1c9368b0",
                MinTlsVersion = "min_tls_versionf843e251",
                CreationTimestamp = "creation_timestamp235e59a1",
                CustomFeatures =
                {
                    "custom_features19916d63",
                },
                Profile = "profile1b48977d",
                Fingerprint = "fingerprint009e6052",
                Description = "description2cf9da67",
                SelfLink = "self_link7e87f12d",
                EnabledFeatures =
                {
                    "enabled_featuresf1f398e0",
                },
                Warnings = { new Warnings(), },
            };
            mockGrpcClient.Setup(x => x.GetAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SslPolicy>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null, null);
            SslPolicy responseCallSettings = await client.GetAsync(request.Project, request.SslPolicy, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SslPolicy responseCancellationToken = await client.GetAsync(request.Project, request.SslPolicy, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListAvailableFeaturesRequestObject()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListAvailableFeaturesSslPoliciesRequest request = new ListAvailableFeaturesSslPoliciesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            SslPoliciesListAvailableFeaturesResponse expectedResponse = new SslPoliciesListAvailableFeaturesResponse
            {
                Features =
                {
                    "features634b039f",
                },
            };
            mockGrpcClient.Setup(x => x.ListAvailableFeatures(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null, null);
            SslPoliciesListAvailableFeaturesResponse response = client.ListAvailableFeatures(request);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAvailableFeaturesRequestObjectAsync()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListAvailableFeaturesSslPoliciesRequest request = new ListAvailableFeaturesSslPoliciesRequest
            {
                PageToken = "page_tokenf09e5538",
                MaxResults = 2806814450U,
                OrderBy = "order_byb4d33ada",
                Project = "projectaa6ff846",
                Filter = "filtere47ac9b2",
                ReturnPartialSuccess = false,
            };
            SslPoliciesListAvailableFeaturesResponse expectedResponse = new SslPoliciesListAvailableFeaturesResponse
            {
                Features =
                {
                    "features634b039f",
                },
            };
            mockGrpcClient.Setup(x => x.ListAvailableFeaturesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SslPoliciesListAvailableFeaturesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null, null);
            SslPoliciesListAvailableFeaturesResponse responseCallSettings = await client.ListAvailableFeaturesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SslPoliciesListAvailableFeaturesResponse responseCancellationToken = await client.ListAvailableFeaturesAsync(request, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public void ListAvailableFeatures()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListAvailableFeaturesSslPoliciesRequest request = new ListAvailableFeaturesSslPoliciesRequest
            {
                Project = "projectaa6ff846",
            };
            SslPoliciesListAvailableFeaturesResponse expectedResponse = new SslPoliciesListAvailableFeaturesResponse
            {
                Features =
                {
                    "features634b039f",
                },
            };
            mockGrpcClient.Setup(x => x.ListAvailableFeatures(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null, null);
            SslPoliciesListAvailableFeaturesResponse response = client.ListAvailableFeatures(request.Project);
            xunit::Assert.Same(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [xunit::FactAttribute]
        public async stt::Task ListAvailableFeaturesAsync()
        {
            moq::Mock<SslPolicies.SslPoliciesClient> mockGrpcClient = new moq::Mock<SslPolicies.SslPoliciesClient>(moq::MockBehavior.Strict);
            mockGrpcClient.Setup(x => x.CreateOperationsClientForGlobalOperations()).Returns(new moq::Mock<lro::Operations.OperationsClient>().Object);
            ListAvailableFeaturesSslPoliciesRequest request = new ListAvailableFeaturesSslPoliciesRequest
            {
                Project = "projectaa6ff846",
            };
            SslPoliciesListAvailableFeaturesResponse expectedResponse = new SslPoliciesListAvailableFeaturesResponse
            {
                Features =
                {
                    "features634b039f",
                },
            };
            mockGrpcClient.Setup(x => x.ListAvailableFeaturesAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<SslPoliciesListAvailableFeaturesResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            SslPoliciesClient client = new SslPoliciesClientImpl(mockGrpcClient.Object, null, null);
            SslPoliciesListAvailableFeaturesResponse responseCallSettings = await client.ListAvailableFeaturesAsync(request.Project, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            xunit::Assert.Same(expectedResponse, responseCallSettings);
            SslPoliciesListAvailableFeaturesResponse responseCancellationToken = await client.ListAvailableFeaturesAsync(request.Project, st::CancellationToken.None);
            xunit::Assert.Same(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}
